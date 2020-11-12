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
    public partial class ActualizarMateriaPrimaForm : DevExpress.XtraEditors.XtraForm
    {
        ResourceManager language;
        public ActualizarMateriaPrimaForm(ResourceManager idioma)
        {
            InitializeComponent();
            btnActualizar.Enabled = false;
            language = idioma;
            CargarTraducciones();
            cargarAyuda();
        }
        /// <summary>
        /// load the help when the user press the F1 key
        /// </summary>
        public void cargarAyuda()
        {
            helpProviderActMP.HelpNamespace = Application.StartupPath + "/CookerSoft.chm";
            helpProviderActMP.SetHelpString(this, "Crear Materia Prima");
            helpProviderActMP.SetHelpKeyword(this, "Crear Materia Prima");
            helpProviderActMP.SetHelpNavigator(this, HelpNavigator.KeywordIndex);
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
                labelCantidadKG.Text = language.GetString("labelCantidadKG");
                labelVencimiento .Text = language.GetString("labelVencimiento");
                checkBoxHabilitado.Text = language.GetString("checkBoxHabilitado");
                btnBuscar.Text = language.GetString("btnBuscar");
                btnActualizar.Text = language.GetString("btnActualizar");
                btnCancelar.Text = language.GetString("btnCancelar");

            }
            catch (UIException ex)
            {
                FacadeServiceBusiness.ManageException(ex);
                System.Console.WriteLine("Error al cargar las traducciones : " + ex.Message);
            }
        }
        private void ActualizarMateriaPrima_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// complete the fields with the Materia prima information 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// update the materia prima information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
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
    }
}
