using ServicesTest.BLL;
using ServicesTest.Domain;
using ServicesTest.Domain.Exceptions;
using ServicesTest.Facade;
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
    public partial class TrackingForm : Form
    {
        public TrackingForm(ResourceManager idioma)
        {
            InitializeComponent();
            CargarTraducciones(idioma);
            this.Text = idioma.GetString("TrackingForm");

        }
        private void CargarTraducciones(ResourceManager idioma)
        {
            this.btnBuscar.Text = idioma.GetString("btnBuscar");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            
        }

        private void CargarTabla()
        {
            try
            {
                IEnumerable<Tracking> tracking = TrackingManager.Current.ObtenerTracking();

                if (tracking.Any())
                {
                    dataGridViewTracking.DataSource = tracking.ToList();
                }
                else {
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
