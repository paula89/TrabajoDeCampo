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
                String[] filtros = new string[] { this.txtUsuario.Text, Encrypt.encryptPass(this.txtPassword.Text) };

                if (VerificarDatos(filtros))
                {
                    permiso = (List<string>)getPermisos(filtros);
                    this.Hide();
                    InicioForm inicio = new InicioForm(permiso, txtUsuario.Text);
                    inicio.ShowDialog();
                    this.Close();
                    this.Dispose();
                }
                else {
                    MessageBox.Show("El usuario y/o contraseña no son correctos", "Error", MessageBoxButtons.OK);
                }
            }
            else {
                // agregar traducciones
                MessageBox.Show("Debe ingresar usuario y contraseña para iniciar sesion en el sistema", "Error", MessageBoxButtons.OK);
            }
        }

        private void CargarTraducciones(ResourceManager idioma)
        {
            this.Text = idioma.GetString("usuarioSesionForm");
            btnAceptar.Text = idioma.GetString("btnLogin");
            lblUsuario.Text = idioma.GetString("lblUsuario");
            lblPassword.Text = idioma.GetString("lblPassword");
        }

        private bool VerificarDatos(String[] filtros) {

            bool existe = UsersManager.Current.GetLogin(filtros);
            return existe;
        }

        private IEnumerable<String> getPermisos(String[] filtros) {
            //bool existe = UsersManager.Current.ObtenerUsuariosLogin(filtros);
            var usuarios = UsersManager.Current.ObtenerUsuariosLogin(filtros);

            List<String> permiso = new List<string>();
            foreach (var user in usuarios)
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
