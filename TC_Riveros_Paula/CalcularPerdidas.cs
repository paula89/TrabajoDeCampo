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
    public partial class CalcularPerdidasForm : DevExpress.XtraEditors.XtraForm
    {
        ResourceManager language;
        public CalcularPerdidasForm(ResourceManager idioma)
        {
            InitializeComponent();
            this.Text = idioma.GetString("CalcularPerdidasForm");
            language = idioma;
            this.cargarAyuda();
            CargarTraducciones();
        }
        /// <summary>
        /// load the translations
        /// </summary>
        private void CargarTraducciones()
        {
            try
            {
                btnCalcular.Text = language.GetString("btnCalcular");
                btnImprimir.Text = language.GetString("btnImprimir");

            }
            catch (UIException ex)
            {
                FacadeServiceBusiness.ManageException(ex);
                System.Console.WriteLine("Error al cargar las traducciones : " + ex.Message);
            }
        }
        /// <summary>
        /// load the help when the user press the F1 key
        /// </summary>
        public void cargarAyuda()
        {
            helpProviderCalculoPerdidas.HelpNamespace = Application.StartupPath + "/CookerSoft.chm";
            helpProviderCalculoPerdidas.SetHelpString(this, "Calculos");
            helpProviderCalculoPerdidas.SetHelpKeyword(this, "Calculos");
            helpProviderCalculoPerdidas.SetHelpNavigator(this, HelpNavigator.KeywordIndex);
        }
        private void CalcularPerdidasForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// calculate the losses by tools
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// print or exportthe table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            gridControlHerramientas.ShowPrintPreview();
        }
    }
}
