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
    public partial class CalcularPresupuestoForm : DevExpress.XtraEditors.XtraForm
    {
        ResourceManager language;
        public CalcularPresupuestoForm(ResourceManager idioma)
        {
            InitializeComponent();
            this.Text = idioma.GetString("CalcularPresupuestoForm");
            language = idioma;
            cargarAyuda();
            CargarTraducciones();
        }
        /// <summary>
        /// load the translations
        /// </summary>
        private void CargarTraducciones()
        {
            try
            {
                labelCantidad.Text = language.GetString("labelCantidad");
                labelProducto.Text = language.GetString("labelProducto");
                labelProductosPresupuesto.Text = language.GetString("labelProductosPresupuesto");

                btnAgregar.Text = language.GetString("btnAgregar");
                btnCalcular.Text = language.GetString("btnCalcular");
                btnGuardar.Text = language.GetString("btnGuardar");

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
            helpProviderCalcularPresupuesto.HelpNamespace = Application.StartupPath + "/CookerSoft.chm";
            helpProviderCalcularPresupuesto.SetHelpString(this, "Calculos");
            // helpProviderCrearMP.SetHelpKeyword(this, "Crear Materia Prima");
            // helpProviderCrearMP.SetHelpNavigator(this,helpProviderCrearMP.);
        }

        private void CalcularPresupuestoForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Calculate the total amount to the budget and show it in the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float amount = Calcular();
            labelPresupuesto.Text = "Total: " + amount;
        }
        /// <summary>
        /// Calculate the total amount to the budget
        /// </summary>
        public float Calcular() {
            return 1;
        }
        /// <summary>
        /// create the Presupuesto object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Load the table with the selected products
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
