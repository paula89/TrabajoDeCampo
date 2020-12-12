using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicesTest.BLL;
using ServicesTest.Domain.Composite;
using ServicesTest.Domain.Exceptions;
using ServicesTest.Facade;
using ServicesTest.Tools;

namespace TC_Riveros_Paula
{
    public partial class InicioSesionForm : DevExpress.XtraEditors.XtraForm
    {
        string cultureInfo = Thread.CurrentThread.CurrentUICulture.Name;
        ResourceManager idioma; 

        public InicioSesionForm()
        {
            InitializeComponent();
            idioma = FacadeService.Translate(cultureInfo);
            this.Text = idioma.GetString("InicioSesionForm");
            CargarTraducciones();
        }
        /// <summary>
        /// init the login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            List<String> permiso = new List<string>();
            try
            {
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
                            idioma = FacadeService.Translate(getIdioma(usuarios));
                            this.Hide();
                            BienvenidoForm bienvenido = new BienvenidoForm(txtUsuario.Text.ToUpper());
                            bienvenido.ShowDialog();

                            InicioForm inicio = new InicioForm(permiso, txtUsuario.Text.ToUpper(), idioma);
                            inicio.ShowDialog();
                            this.Close();
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show(idioma.GetString("MsgErrorLogin"), idioma.GetString("Error"), MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show(idioma.GetString("MsgErrorIntegridad"), idioma.GetString("Error"), MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show(idioma.GetString("MsgErrorCompletarLogin"), idioma.GetString("Error"), MessageBoxButtons.OK);
                }
            }
            catch (Exception ex) {
                FacadeService.ManageException(new UIException(ex));
                MessageBox.Show("Ha ocurrido un error, contacte al administrador del sistema", "Error", MessageBoxButtons.OK);
            }
        }
        /// <summary>
        /// verify the DVV
        /// </summary>
        /// <returns></returns>
        private bool VerificarDV() {
            bool verificar = true;
            decimal DVV = 0;
            try
            {
                decimal currentDVV = UsersManager.Current.GetDVV();
                IEnumerable<Usuario> usuarios = UsersManager.Current.ListarDVH();

                foreach (var item in usuarios)
                {
                    decimal DVH = Encrypt.DVHCalculate(item.Cod_Usuario.Trim() + item.Nombre.Trim() + item.FechaAlta);
                    DVV = DVV + DVH;
                    if (item.DVH != DVH)
                    {
                        verificar = false;
                    }
                }
                if (DVV != currentDVV)
                {
                    verificar = false;
                }
                return verificar;
            }
            catch (Exception ex) {
                FacadeService.ManageException(new UIException(ex));
                return false;
            }

        }

        /// <summary>
        /// load translations
        /// </summary>
        private void CargarTraducciones()
        {
            this.Text = idioma.GetString("usuarioSesionForm");
            btnAceptar.Text = idioma.GetString("btnLogin");
            lblUsuario.Text = idioma.GetString("lblUsuario");
            lblPassword.Text = idioma.GetString("lblPassword");
        }
        /// <summary>
        /// search the user data
        /// </summary>
        /// <param name="filtros"></param>
        /// <returns></returns>
        private IEnumerable<Usuario> VerificarDatos(String[] filtros) {
            try
            {
                var usuarios = UsersManager.Current.GetLogin(filtros);
                return usuarios;
            }
            catch (Exception ex) {
                FacadeService.ManageException(new UIException(ex));
                return null;
            }
        }
        /// <summary>
        /// get the data user by filters
        /// </summary>
        /// <param name="filtros"></param>
        /// <returns></returns>
        private IEnumerable<Usuario> getUsuario(String[] filtros) {
            try
            {
                var usuarios = UsersManager.Current.ObtenerUsuariosLogin(filtros);
                return usuarios;
            }
            catch (Exception ex) {
                FacadeService.ManageException(new UIException(ex));
                return null;
            }
        }
        /// <summary>
        /// get user language
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        private string getIdioma(IEnumerable<Usuario> usuario) {
            string languageUser = "";
            foreach (var item in usuario)
            {
                languageUser = item.Idioma;
            }
            return languageUser;
        }

        /// <summary>
        /// get user permissions
        /// </summary>
        /// <param name="users"></param>
        /// <returns></returns>
        private IEnumerable<String> getPermisos(IEnumerable<Usuario> users) {
            //bool existe = UsersManager.Current.ObtenerUsuariosLogin(filtros);

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

        /// <summary>
        /// get through permissions
        /// </summary>
        /// <param name="permisos"></param>
        /// <returns></returns>
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
       /// <summary>
       /// verify fields
       /// </summary>
       /// <returns></returns>
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

        private void comboBoxIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InicioSesionForm_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
