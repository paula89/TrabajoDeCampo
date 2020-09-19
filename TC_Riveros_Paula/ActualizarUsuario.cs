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
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TC_Riveros_Paula
{
    public partial class ActualizarUsuarioForm : Form
    {
        static decimal actualDVH;
        IEnumerable<Usuario> usuarios;
        public ActualizarUsuarioForm(ResourceManager idioma)
        {
            InitializeComponent();
            CargarTraducciones(idioma);
            this.Text = idioma.GetString("ActualizarUsuarioForm");
            btnActualizar.Enabled = false;
        }
        private void CargarTraducciones(ResourceManager idioma)
        {
            
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string usuario = this.textBoxUsuario.Text;
            String[] filtros = new string[] { usuario };
            CargarTabla(filtros);
        }
        private void CargarTabla(String[] filtros)
        {

            try
            {
                usuarios = UsersManager.Current.ObtenerUsuariosLogin(filtros);
                if (usuarios.Count() == 0) { MessageBox.Show("No se encontro el usuario " + filtros[0].ToString()); }
                else {
                    foreach (var item in usuarios)
                    {
                        textBoxNombre.Text = item.Nombre;
                        textBoxApellido.Text = item.Apellido;
                        textBoxEmail.Text = item.Email;
                        textBoxTelefono.Text = item.Telefono;
                        textBoxDireccion.Text = item.Direccion;
                        checkBoxHabilitado.Checked = item.Habilitado;
                        String permiso = "";
                        foreach (var permisos in item.Permisos)
                        {
                            permiso = permiso + permisos.Nombre + " ";
                        }
                        textBoxRolActual.Text = permiso;
                        actualDVH = item.DVH;
                    }
                    CargarRoles();
                    btnActualizar.Enabled = true;

                }
            }
            catch (UIException ex)
            {
                FacadeService.ManageException(ex);

            }
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            bool valido = ValidarUsuario();
            if (valido)
            {
                Usuario usuario = CrearUsuario();
                ActualizarUsuario(usuario);
                this.Close();
            }
            
        }
        private static void ActualizarUsuario(Usuario usuario)
        {
            try
            {
                int result = FacadeService.ActualizarUsuario(usuario);
                if (result == 1)
                {
                    RegistrarDVV(usuario.DVH);
                    MessageBox.Show("El Usuario fue actualizado exitosamente", "OK", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("El usuario no pudo actualizarse", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                FacadeService.ManageException(new UIException(ex));
            }

        }
        private static int RegistrarDVV(decimal DVH)
        {
            try
            {
                decimal a = DVH - actualDVH;
                decimal DVV = Encrypt.DVVCalculate(a);
                return FacadeService.RegistrarDVV(DVV);
            }
            catch (Exception ex)
            {
                FacadeService.ManageException(new UIException(ex));
                return 0;
            }
        }
        private bool ValidarUsuario()
        {
            if (textBoxNombre.Text.Length == 0 || textBoxApellido.Text.Length == 0 || textBoxDireccion.Text.Length == 0 ||
                textBoxEmail.Text.Length == 0 || textBoxTelefono.Text.Length == 0)
            {
                MessageBox.Show("Debe completar todos los campos obligatorios.", "", MessageBoxButtons.OK);
                return false;
            }
            else { 
                string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";
                var regex = new Regex(pattern, RegexOptions.IgnoreCase);

                if (!regex.IsMatch(textBoxEmail.Text)) {
                    MessageBox.Show("Debe ingresa un mail valido", "Error", MessageBoxButtons.OK);
                    return false;
                } 
                if (!Regex.IsMatch(textBoxNombre.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Debe ingresa un nombre valido", "Error", MessageBoxButtons.OK);
                    return false;
                }
                if (!Regex.IsMatch(textBoxApellido.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Debe ingresa un apellido valido", "Error", MessageBoxButtons.OK);
                    return false;
                }
                if (!Regex.IsMatch(textBoxDireccion.Text, @"^[A-Za-z0-9\s]+$"))
                {
                    MessageBox.Show("Debe ingresa una direccion valida", "Error", MessageBoxButtons.OK);
                    return false;
                }
                if (!Regex.IsMatch(textBoxTelefono.Text, @"^[0-9\s]+$"))
                {
                    MessageBox.Show("Debe ingresa un telefono valido", "Error", MessageBoxButtons.OK);
                    return false;
                }
                if (textBoxPassword.Text != textBoxPassword2.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK);
                    return false;
                }
            }

            return true;

        }
        public Usuario CrearUsuario()
        {
            Usuario usuario = new Usuario();

            try
            {
                Patente permisoUsuario = new Patente();
                permisoUsuario.Nombre = comboBoxRoles.SelectedItem.ToString().Trim();

                Familia familia = new Familia();
                familia.Nombre = comboBoxRoles.SelectedItem.ToString();
                familia.Permisos.Add(permisoUsuario);

                usuario.Cod_Usuario = this.textBoxUsuario.Text.Trim().ToUpper();
                usuario.Nombre = this.textBoxNombre.Text.Trim();
                usuario.Apellido = this.textBoxApellido.Text.Trim();
                usuario.Direccion = this.textBoxDireccion.Text.Trim();
                usuario.Email = this.textBoxEmail.Text.Trim();
                usuario.Telefono = this.textBoxTelefono.Text.Trim();
                usuario.Habilitado = this.checkBoxHabilitado.Checked;
                foreach (var item in usuarios)
                {
                    usuario.FechaAlta = item.FechaAlta;
                }
                if (textBoxPassword.Text.Length != 0 && textBoxPassword2.Text.Length != 0)
                {
                    usuario.Password = Encrypt.encryptPass(this.textBoxPassword.Text.Trim());
                }
                else {
                    foreach (var item in usuarios)
                    {
                        usuario.Password = item.Password;
                    }
                }
                usuario.Permisos.Add(familia);
                usuario.DVH = Encrypt.DVHCalculate(usuario.Cod_Usuario + usuario.Nombre + usuario.FechaAlta);

                return usuario;
            }
            catch (Exception ex)
            {
                FacadeService.ManageException(new UIException(ex));
                return usuario;
            }
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            textBoxUsuario.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        { 
        
        }
            
    }
}
