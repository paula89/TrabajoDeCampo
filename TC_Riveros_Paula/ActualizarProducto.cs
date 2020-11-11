using BLLTest.Facade;
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
    public partial class ActualizarProducto : DevExpress.XtraEditors.XtraForm
    {
        ResourceManager language;
        public ActualizarProducto(ResourceManager idioma)
        {
            InitializeComponent();
            language = idioma;
            CargarTraducciones();
            cargarProductos();
            btnActualizar.Enabled = false;
        }
        /// <summary>
        /// load translations
        /// </summary>
        private void CargarTraducciones()
        {
            try
            {
                labelNombre.Text = language.GetString("labelNombre");
                labelStockHerramientas.Text = language.GetString("labelStockHerramientas");
                labelComentario.Text = language.GetString("labelComentario");
                labelStockMateriaPrima.Text = language.GetString("labelStockMateriaPrima");

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
        /// <summary>
        /// load the Productos cmbobox
        /// </summary>
        public void cargarProductos() { 
        }
        private void ActualizarProducto_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// complete the fields in the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// create the new object Producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            Actualizar(producto);
        }
        /// <summary>
        /// update the Producto
        /// </summary>
        public void Actualizar(Producto producto) { 
        
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
