using BLLTest.Facade;
using BLLTest.Managers;
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
    public partial class ListarHerramientasForm : DevExpress.XtraEditors.XtraForm
    {
        IEnumerable<Herramientas> herramientas;

        public ListarHerramientasForm(ResourceManager idioma)
        {
            InitializeComponent();
            this.Text = idioma.GetString("ListarHerramientasForm");
            this.btnImprimir.Text = idioma.GetString("btnImprimir");
            CargarTabla();
        }
        private void CargarTabla()
        {
            try
            {
                herramientas = HerramientasManager.Current.ListarHerramientas();
                if (herramientas.Any())
                {
                    gridControl1.DataSource = herramientas;
                    gridView1.Columns["IdHerramienta"].Visible = false;
                    btnImprimir.Enabled = true;
                }
                else
                {
                    btnImprimir.Enabled = false;
                    MessageBox.Show("No hay herramientas guardadas", "", MessageBoxButtons.OK);

                }

            }
            catch (Exception ex)
            {
                FacadeServiceBusiness.ManageException(new UIException(ex));
            }

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// print the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }
    }
}
