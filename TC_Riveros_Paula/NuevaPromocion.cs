using BLLTest.Facade;
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
    public partial class NuevaPromocionForm : DevExpress.XtraEditors.XtraForm
    {
        ResourceManager language;
        public NuevaPromocionForm(ResourceManager idioma)
        {
            InitializeComponent();
            language = idioma;
            this.Text = idioma.GetString("NuevaPromocionForm");
            CargarTraducciones();
            cargarAyuda();
        }
        /// <summary>
        /// load the help when the user press the F1 key
        /// </summary>
        public void cargarAyuda()
        {
            helpProviderCrearPromocion.HelpNamespace = Application.StartupPath + "/CookerSoft.chm";
            helpProviderCrearPromocion.SetHelpString(this, "Crear promocion");
            // helpProviderCrearMP.SetHelpKeyword(this, "Crear Materia Prima");
            // helpProviderCrearMP.SetHelpNavigator(this,helpProviderCrearMP.);
        }
        private void NuevaPromocionForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// close the screen
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
                labelComentario.Text = language.GetString("labelComentario");
                labelDescuento.Text = language.GetString("labelDescuento");
                labelVigencia.Text = language.GetString("labelVencimiento");

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
        /// create the Promocion object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
