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
using ServicesTest.Facade;

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
            bool verificar = verificarCampos();
            if (verificar)
            {
                this.Hide();
                InicioForm inicio = new InicioForm();
                inicio.ShowDialog();
                this.Close();
                this.Dispose();
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
