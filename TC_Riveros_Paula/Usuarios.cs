using ServicesTest.BLL;
using ServicesTest.Domain.Composite;
using ServicesTest.Domain.Exceptions;
using ServicesTest.Facade;
using ServicesTest.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TC_Riveros_Paula
{
    public partial class UsuariosForm : Form
    {
        ResourceManager language;
        public UsuariosForm(ResourceManager idioma)
        {
            InitializeComponent();
            language = idioma;
            this.Text = language.GetString("UsuariosForm");
            CargarTraducciones();
            CargarRoles();
        }

        private void CargarRoles() 
        {
            try
            {
                IEnumerable<String> roles = UsersManager.Current.ObtenerRoles();
                comboBoxRoles.DataSource = roles.ToList();
            }

            catch (UIException ex)
            {
                FacadeService.ManageException(ex);
                System.Console.WriteLine("Error al cargar los roles : " + ex.Message);
            }
        
        
        }
        private void CargarTraducciones()
        {
            try
            {
                lblCodUsuario.Text = language.GetString("lblCodUsuario");
                labelNombre.Text = language.GetString("labelNombre");
                lblApellido.Text = language.GetString("lblApellido");
                lblDireccion.Text = language.GetString("lblDireccion");
                lblEmail.Text = language.GetString("lblEmail");
                lblPassword.Text = language.GetString("lblPassword");
                lblPassword2.Text = language.GetString("lblPassword2");
                lblTelefono.Text = language.GetString("lblTelefono");
                lblRoles.Text = language.GetString("lblRoles");

                btnAceptar.Text = language.GetString("btnAceptar");
                btnCancelar.Text = language.GetString("btnCancelar");

            }
            catch (UIException ex)
            {
                FacadeService.ManageException(ex);
                System.Console.WriteLine("Error al cargar las traducciones : " + ex.Message);
            }
        }
        private void UsuariosForm_Load(object sender, EventArgs e)
        {

        }

        private void txtTelefono_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = CrearUsuario();

            bool valido = ValidarUsuario();
            if (valido)
            {
                RegistrarUsuario(usuario);
                this.Close();
            }
        }


        public Usuario CrearUsuario() {
            Usuario usuario = new Usuario();

            try
            {
                Patente permisoUsuario = new Patente();
                permisoUsuario.Nombre = comboBoxRoles.SelectedItem.ToString().Trim();

                Familia familia = new Familia();
                familia.Nombre = comboBoxRoles.SelectedItem.ToString();
                familia.Permisos.Add(permisoUsuario);

                usuario.Cod_Usuario = this.textBoxCodUsuario.Text.Trim().ToUpper();
                usuario.Nombre = this.txtNombre.Text.Trim();
                usuario.Apellido = this.txtApellido.Text.Trim();
                usuario.Direccion = this.txtDireccion.Text.Trim();
                usuario.Email = this.txtEmail.Text.Trim();
                usuario.Telefono = this.txtTelefono.Text.Trim();
                usuario.Password = Encrypt.encryptPass(this.txtPassword.Text.Trim());
                usuario.Permisos.Add(familia);
                usuario.FechaAlta = DateTime.Now;
                usuario.DVH = Encrypt.DVHCalculate(usuario.Cod_Usuario + usuario.Nombre + usuario.FechaAlta);

                return usuario;
            }
            catch (Exception ex) {
                FacadeService.ManageException(new UIException(ex));
                return usuario;
            }
        }
        private bool ValidarUsuario()
        {
            if (textBoxCodUsuario.Text.Length == 0 || txtNombre.Text.Length == 0 || txtApellido.Text.Length == 0 || txtDireccion.Text.Length == 0 ||
                txtEmail.Text.Length == 0 || txtTelefono.Text.Length == 0 || txtPassword.Text.Length == 0)
            {
                MessageBox.Show(language.GetString("MsgErrorCamposObligatorios"), language.GetString("Error"), MessageBoxButtons.OK);
                return false;
            }
            else
            {
                string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
                var regex = new Regex(pattern, RegexOptions.IgnoreCase);

                if (!regex.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show(language.GetString("MsgErrorEmail"), language.GetString("Error"), MessageBoxButtons.OK);
                    return false;
                }
                if (!Regex.IsMatch(txtNombre.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show(language.GetString("MsgErrorNombre"), language.GetString("Error"), MessageBoxButtons.OK);
                    return false;
                }
                if (!Regex.IsMatch(txtApellido.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show(language.GetString("MsgErrorApellido"), language.GetString("Error"), MessageBoxButtons.OK);
                    return false;
                }
                if (!Regex.IsMatch(txtDireccion.Text, @"^[A-Za-z0-9\s]+$"))
                {
                    MessageBox.Show(language.GetString("MsgErrorDireccion"), language.GetString("Error"), MessageBoxButtons.OK);
                    return false;
                }
                if (!Regex.IsMatch(txtTelefono.Text, @"^[0-9\s]+$"))
                {
                    MessageBox.Show(language.GetString("MsgErrorTelefono"), language.GetString("Error"), MessageBoxButtons.OK);
                    return false;
                }
                if (txtPassword.Text != txtPassword2.Text)
                {
                    MessageBox.Show(language.GetString("MsgErrorPassword"), language.GetString("Error"), MessageBoxButtons.OK);
                    return false;
                }
                bool userValidRegex = Regex.IsMatch(textBoxCodUsuario.Text, @"^[A-Za-z0-9]+$");
                if (!userValidRegex)
                {
                    MessageBox.Show(language.GetString("MsgErrorUser"), language.GetString("Error"), MessageBoxButtons.OK);
                    return false;
                }
                else {
                    string nombre = this.textBoxCodUsuario.Text;
                    String[] filtros = new string[] { nombre };
                    IEnumerable<Usuario> usuarios = UsersManager.Current.ListarUsuariosFilter(filtros);
                    if (usuarios.Count() > 0) {
                        MessageBox.Show(language.GetString("MsgErrorUserExiste"), language.GetString("Error"), MessageBoxButtons.OK);
                        return false;
                    }
                }
            }
            return true;
        }

        private void RegistrarUsuario(Usuario usuario) {
            try
            {
                int result = FacadeService.RegistrarUsuario(usuario);
                if (result == 1)
                {
                    RegistrarDVV(usuario.DVH);
                    MessageBox.Show(language.GetString("MsgOkUserRegister"), "OK", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(language.GetString("MsgErrorUserRegister"), language.GetString("Error"), MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                FacadeService.ManageException(new UIException(ex));
            }

        }

        private static int RegistrarDVV(decimal DVH) {
            try
            {
                decimal DVV = Encrypt.DVVCalculate(DVH);
                return FacadeService.RegistrarDVV(DVV);
            }
            catch (Exception ex) {
                FacadeService.ManageException(new UIException(ex));
                return 0;
            }
        }
        private static void RecorrerListado(List<FamiliaComponent> permisos, string separator = "")
        {
            separator = separator + "-";
            foreach (var item in permisos)
            {
                if (item.GetChilds() == 0)
                    Console.WriteLine($"{separator} Acceso a UI: {item.Nombre} ");
                else
                {
                    dynamic value = item;
                    RecorrerListado(value.Permisos, separator);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxCodUsuario_TextChanged(object sender, EventArgs e)
        {
            textBoxCodUsuario.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
