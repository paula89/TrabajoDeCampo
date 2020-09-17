using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicesTest.BLL;
using ServicesTest.Domain.Composite;
using ServicesTest.Facade;
using ServicesTest.Tools;

namespace TC_Riveros_Paula
{
    public partial class InicioSesionForm : Form
    {
        string cultureInfo = Thread.CurrentThread.CurrentUICulture.Name;
        ResourceManager idioma;

        public InicioSesionForm()
        {
            InitializeComponent();
            idioma = FacadeService.Translate(cultureInfo);
            CargarTraducciones(idioma);
            verificarCampos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            List<String> permiso = new List<string>();
            bool verificar = verificarCampos();
            if (verificar)
            {
                if (VerificarDV())
                {
                    String[] filtros = new string[] { this.txtUsuario.Text.ToUpper(), Encrypt.encryptPass(this.txtPassword.Text) };
                    IEnumerable<Usuario> usuarios = VerificarDatos(filtros);
                    if (usuarios.Any())
                    {
                        permiso = (List<string>)getPermisos(usuarios);

                        this.Hide();
                        InicioForm inicio = new InicioForm(permiso, txtUsuario.Text.ToUpper());
                        inicio.ShowDialog();
                        this.Close();
                        this.Dispose();
                    }
                    else {
                        MessageBox.Show("El usuario y/o contraseña no son correctos", "Error", MessageBoxButtons.OK);
                    }
                }
                else {
                    MessageBox.Show("Inconsistencia de datos en la base de datos. Comuniquese con el administrador del sistema.");
                }
            }
            else {
                // agregar traducciones
                MessageBox.Show("Debe ingresar usuario y contraseña para iniciar sesion en el sistema", "Error", MessageBoxButtons.OK);
            }
        }

        private bool VerificarDV() {
            bool verificar = true;
            decimal DVV = 0;
            decimal currentDVV = UsersManager.Current.GetDVV();
            IEnumerable<Usuario> usuarios = UsersManager.Current.ListarDVH();

            foreach (var item in usuarios)
            {
                decimal DVH = Encrypt.DVHCalculate(item.Cod_Usuario.Trim() + item.Nombre.Trim() + item.FechaAlta);
                DVV = DVV + DVH;
                if (item.DVH != DVH) {
                    verificar = false;
                }
            }
            if (DVV != currentDVV) {
                verificar = false;
            }
            return verificar;

        }


        private void CargarTraducciones(ResourceManager idioma)
        {
            this.Text = idioma.GetString("usuarioSesionForm");
            btnAceptar.Text = idioma.GetString("btnLogin");
            lblUsuario.Text = idioma.GetString("lblUsuario");
            lblPassword.Text = idioma.GetString("lblPassword");
        }

        private IEnumerable<Usuario> VerificarDatos(String[] filtros) {
            var usuarios = UsersManager.Current.GetLogin(filtros);
            return usuarios;
        }

        private IEnumerable<Usuario> getUsuario(String[] filtros) {
            var usuarios = UsersManager.Current.ObtenerUsuariosLogin(filtros);
            return usuarios;
        }




        private IEnumerable<String> getPermisos(IEnumerable<Usuario> users) {
            //bool existe = UsersManager.Current.ObtenerUsuariosLogin(filtros);

            //String[] cod_usuario = new string[] { this.txtUsuario.Text.ToUpper() };
            //IEnumerable<Usuario> usuarios = users;//getUsuario(cod_usuario);

            List<String> permiso = new List<string>();
            foreach (var user in users)
            {
               var result = RecorrerListado(user.Permisos);
               foreach (var item in result)
               {
                    permiso.Add(item);
               }
            }
            return permiso;
        }


        private static IEnumerable<String> RecorrerListado(List<FamiliaComponent> permisos)
        {
            List<String> permiso = new List<string>();
            foreach (var listPermisos in permisos)
            {
                    dynamic value = listPermisos;
                    foreach (var item in value.Permisos)
                    {
                        if (item.GetChilds() == 0)
                        {
                            permiso.Add(item.Nombre);
                        }
                    }
            }
            return permiso;
         }
       
        private bool verificarCampos() {
            if ((txtUsuario.Text.Length == 0) || (txtPassword.Text.Length == 0))
            {
                return false;
            }
            else {
                return true;
            }
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
