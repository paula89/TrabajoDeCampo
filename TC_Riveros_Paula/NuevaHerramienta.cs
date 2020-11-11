using BLLTest.Facade;
using DevExpress.XtraBars.Navigation;
using DomainTest;
using ServicesTest.Domain.Exceptions;
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
    public partial class NuevaHerramientaForm : DevExpress.XtraEditors.XtraForm
    {
        ResourceManager language;

        public NuevaHerramientaForm(ResourceManager idioma)
        {
            InitializeComponent();
            language = idioma;
            this.Text = idioma.GetString("NuevaHerramientaForm");
            CargarTraducciones();
            cargarAyuda();
        }

        /// <summary>
        /// load the help when the user press the F1 key
        /// </summary>
        public void cargarAyuda()
        {
            helpProviderH.HelpNamespace = Application.StartupPath + "/CookerSoft.chm";
            helpProviderH.SetHelpString(this, "Crear Herramienta");
            // helpProviderCrearMP.SetHelpKeyword(this, "Crear Materia Prima");
            // helpProviderCrearMP.SetHelpNavigator(this,helpProviderCrearMP.);
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// close teh screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// load translations
        /// </summary>
        private void CargarTraducciones()
        {
            try
            {
                labelNombre.Text = language.GetString("labelNombre");
                labelMarca.Text = language.GetString("labelMarca");
                labelProveedor.Text = language.GetString("labelProveedor");
                labelComentario.Text = language.GetString("labelComentario");
                labelCantidad.Text = language.GetString("labelCantidad");

                btnAceptar.Text = language.GetString("btnAceptar");
                btnCancelar.Text = language.GetString("btnCancelar");

            }
            catch (UIException ex)
            {
                FacadeServiceBusiness.ManageException(ex);
                System.Console.WriteLine("Error al cargar las traducciones : " + ex.Message);
            }
        }
        /// <summary>
        /// create the Herramienta object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            Herramientas herramienta = new Herramientas();
            herramienta.nombre = textBoxNombre.Text;
            herramienta.marca = textBoxMarca.Text;
            herramienta.habilitado = true;
            herramienta.cantidad = Convert.ToInt32(textBoxCantidad.Text);
            herramienta.comentario = textBoxComentario.Text;
            herramienta.proveedor = textBoxProveedor.Text;
            herramienta.tiempoDeUso = 0;
            herramienta.IdHerramienta = Guid.NewGuid();
            herramienta.fechaAlta = Convert.ToDateTime(DateTime.Now);
            GuardarHerramienta(herramienta);
        }
        /// <summary>
        /// Save the Herramienta and show confirmation message
        /// </summary>
        /// <param name="herramienta"></param>
        private void GuardarHerramienta(Herramientas herramienta)
        {
            try
            {
                int guardado = FacadeServiceBusiness.RegistrarHerramienta(herramienta);
                if (guardado == 1)
                {
                    MessageBox.Show(language.GetString("MsgOkMPRegister"), "Ok", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(language.GetString("MsgErrorMPRegister"), language.GetString("Error"), MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                FacadeServiceBusiness.ManageException(new UIException(ex));

            }
        }
    }
}
