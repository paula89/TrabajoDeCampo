using ServicesTest.BLL;
using ServicesTest.Domain;
using ServicesTest.Domain.Exceptions;
using ServicesTest.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TC_Riveros_Paula
{
    public partial class TrackingForm : DevExpress.XtraEditors.XtraForm
    {
        public TrackingForm(ResourceManager idioma)
        {
            InitializeComponent();
            CargarTraducciones(idioma);
            this.Text = idioma.GetString("TrackingForm");
            CargarTabla();
            cargarAyuda();
        }
        /// <summary>
        /// load the help when the user press the F1 key
        /// </summary>
        public void cargarAyuda()
        {
            helpProviderTracking.HelpNamespace = Application.StartupPath + "/CookerSoft.chm";
            helpProviderTracking.SetHelpString(this, "Tracking");
            // helpProviderCrearMP.SetHelpKeyword(this, "Crear Materia Prima");
            // helpProviderCrearMP.SetHelpNavigator(this,helpProviderCrearMP.);
        }
        /// <summary>
        /// loas translations
        /// </summary>
        /// <param name="idioma"></param>
        private void CargarTraducciones(ResourceManager idioma)
        {
            this.btnImprimir.Text = idioma.GetString("btnImprimir");
        }
        /// <summary>
        /// print the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            gridControlTracking.ShowPrintPreview();

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            
        }
        /// <summary>
        /// load the table
        /// </summary>
        private void CargarTabla()
        {
            try
            {
                IEnumerable<Tracking> tracking = TrackingManager.Current.ObtenerTracking();

                if (tracking.Any())
                {
                    gridControlTracking.DataSource = tracking.ToList();
                    btnImprimir.Enabled = true;
                    
                   // dataGridViewTracking.DataSource = tracking.ToList();
                }
                else {
                    btnImprimir.Enabled = false;
                    MessageBox.Show("No hay tracking en la base de datos.","",MessageBoxButtons.OK);
                }
            }
            catch (UIException ex)
            {
                FacadeService.ManageException(ex);

            }
        }




    }
}
