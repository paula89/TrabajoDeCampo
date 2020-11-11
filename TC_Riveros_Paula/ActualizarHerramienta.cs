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
    public partial class ActualizarHerramientaForm : DevExpress.XtraEditors.XtraForm
    {
        ResourceManager language;
        public ActualizarHerramientaForm(ResourceManager idioma)
        {
            InitializeComponent();
            language = idioma;
            this.Text = idioma.GetString("ActualizarHerramientaForm");
            CargarTraducciones();
            CargarHerramientas();
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
                labelMarca.Text = language.GetString("labelMarca");
                labelProveedor.Text = language.GetString("labelProveedor");
                labelComentario.Text = language.GetString("labelComentario");
                labelCantidad.Text = language.GetString("labelCantidad");

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
        private void ActualizarHerramienta_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// create the new Herramienta object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Herramientas herramienta = new Herramientas();
            Actualizar(herramienta);
        }
        /// <summary>
        /// update the Herramienta
        /// </summary>
        /// <param name="herramienta"></param>
        public void Actualizar(Herramientas herramienta) { 
        
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
        /// load the fields in the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarHerramienta();
        }
        /// <summary>
        /// search the data since the Herramienta selected
        /// </summary>
        public void BuscarHerramienta() { 
            
        }
        /// <summary>
        /// load the Herramientas combobox
        /// </summary>
        public void CargarHerramientas() { 
        
        }
    }
}
