using ServicesTest.BLL;
using ServicesTest.Domain.Composite;
using ServicesTest.Domain.Exceptions;
using ServicesTest.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TC_Riveros_Paula
{
    public partial class UsuariosForm : Form
    {
        public UsuariosForm(ResourceManager idioma)
        {
            InitializeComponent();
            CargarTraducciones(idioma);
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
        private void CargarTraducciones(ResourceManager idioma)
        {
            try
            {
                lblCodUsuario.Text = idioma.GetString("lblCodUsuario");
                labelNombre.Text = idioma.GetString("labelNombre");
                lblApellido.Text = idioma.GetString("lblApellido");
                lblDireccion.Text = idioma.GetString("lblDireccion");
                lblEmail.Text = idioma.GetString("lblEmail");
                lblPassword.Text = idioma.GetString("lblPassword");
                lblPassword2.Text = idioma.GetString("lblPassword2");
                lblTelefono.Text = idioma.GetString("lblTelefono");
                lblRoles.Text = idioma.GetString("lblRoles");

                btnAceptar.Text = idioma.GetString("btnAceptar");
                btnCancelar.Text = idioma.GetString("btnCancelar");

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
            Patente permisoUsuario = new Patente();
            permisoUsuario.Nombre = comboBoxRoles.SelectedItem.ToString();

            Familia familia = new Familia();
            familia.Nombre = comboBoxRoles.SelectedItem.ToString();
            familia.Permisos.Add(permisoUsuario);

            Usuario usuario = new Usuario();
            usuario.Cod_Usuario = this.textBoxCodUsuario.Text;
            usuario.Nombre = this.txtNombre.Text;
            usuario.Apellido = this.txtApellido.Text;
            usuario.Direccion = this.txtDireccion.Text;
            usuario.Email = this.txtEmail.Text;
            usuario.Telefono = this.txtTelefono.Text;
            usuario.Password = this.txtPassword.Text;
            usuario.Permisos.Add(familia);
            usuario.FechaAlta = DateTime.Now;

            bool valido = ValidarUsuario(usuario);
            if (valido)
            {
                RegistrarUsuario(usuario);
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos");
            }

        }

        private bool ValidarUsuario(Usuario usuario) {

            return true;

        }
        private static void RegistrarUsuario(Usuario usuario) {
            try
            {
                //guardar
                int result = FacadeService.RegistrarUsuario(usuario);
                if (result == 1)
                {
                    MessageBox.Show("Usuario Registrado OK");
                }
                else
                {
                    MessageBox.Show("El usuario no pudo registrarse");
                }
                //System.Console.WriteLine("resultado usuarios ::: " + result);
            }
            catch (Exception ex)
            {

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
    }
}
