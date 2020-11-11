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
    public partial class NuevoProductoForm : DevExpress.XtraEditors.XtraForm
    {
        public NuevoProductoForm(ResourceManager idioma)
        {
            InitializeComponent();
            this.Text = idioma.GetString("NuevoProductoForm");
            CargarTraducciones(idioma);
            cargarAyuda();
            CargarTabla();
        }
        /// <summary>
        /// load the help when the user press the F1 key
        /// </summary>
        public void cargarAyuda()
        {
            helpProviderNuevoProducto.HelpNamespace = Application.StartupPath + "/CookerSoft.chm";
            helpProviderNuevoProducto.SetHelpString(this, "Crear producto");
            // helpProviderCrearMP.SetHelpKeyword(this, "Crear Materia Prima");
            // helpProviderCrearMP.SetHelpNavigator(this,helpProviderCrearMP.);
        }
        /// <summary>
        /// load translations
        /// </summary>
        /// <param name="idioma"></param>
        private void CargarTraducciones(ResourceManager idioma)
        {
            labelComentario.Text = idioma.GetString("labelComentario");
            labelNombre.Text = idioma.GetString("labelNombre");
            labelStockHerramientas.Text = idioma.GetString("labelStockHerramientas");
            labelStockMateriaPrima.Text = idioma.GetString("labelStockMateriaPrima");

            btnCancelar.Text = idioma.GetString("btnCancelar");
            btnGuardar.Text = idioma.GetString("btnGuardar");

        }
        /// <summary>
        /// load the Herramienta and MateriaPrima tables
        /// </summary>
        public void CargarTabla() { 
        
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelStockHerramientas_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
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
        /// <summary>
        /// create the Producto object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
