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
    public partial class NuevaVentaForm : DevExpress.XtraEditors.XtraForm
    {
        ResourceManager language;
        public NuevaVentaForm(ResourceManager idioma)
        {
            InitializeComponent();
            this.Text = idioma.GetString("NuevaVentaForm");
            language = idioma;
            CargarTraducciones();
            cargarAyuda();
            CargarTabla();
        }
        /// <summary>
        /// load the help when the user press the F1 key
        /// </summary>
        public void cargarAyuda()
        {
            helpProviderVentas.HelpNamespace = Application.StartupPath + "/CookerSoft.chm";
            helpProviderVentas.SetHelpString(this, "Crear venta");
            // helpProviderCrearMP.SetHelpKeyword(this, "Crear Materia Prima");
            // helpProviderCrearMP.SetHelpNavigator(this,helpProviderCrearMP.);
        }
        /// <summary>
        /// load translations
        /// </summary>
        private void CargarTraducciones()
        {
            try
            {
                
                btnAceptar.Text = language.GetString("btnConfirmar");

            }
            catch (UIException ex)
            {
                FacadeServiceBusiness.ManageException(ex);
                System.Console.WriteLine("Error al cargar las traducciones : " + ex.Message);
            }
        }
        /// <summary>
        /// load the Presupuestos table
        /// </summary>
        public void CargarTabla() { 
        
        }
           
        /// <summary>
        /// create the venta object since a Presupuesto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// close the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
