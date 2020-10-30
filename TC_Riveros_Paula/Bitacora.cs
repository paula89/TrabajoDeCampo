using ServicesTest.Domain;
using ServicesTest.BLL;
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
using ServicesTest.Domain.Exceptions;
using ServicesTest.Facade;

namespace TC_Riveros_Paula
{
    public partial class FormBitacora : DevExpress.XtraEditors.XtraForm
    {
        public FormBitacora(ResourceManager idioma)
        {
            InitializeComponent();
            this.Text = idioma.GetString("FormBitacora");
            this.CargarTraducciones(idioma);
            this.CargarTabla();
        }

        public void CargarTraducciones(ResourceManager idioma) 
        {
            this.btnImprimir.Text = idioma.GetString("btnImprimir");
        }
        public void CargarTabla() {
            try
            {
                String[] filtros = new string[] { };
                IEnumerable<Bitacora> allBitacora;

                IEnumerable<Bitacora> bitacora = BitacoraManager.Current.ObtenerBitacoras(filtros);
                IEnumerable<Bitacora> criticos = BitacoraManager.Current.ObtenerBitacorasFile();
                if (criticos.Any()) { allBitacora = bitacora.Concat(criticos); } else { allBitacora = bitacora.ToList(); };
                if (bitacora.Any())
                {
                    gridControlBitacora.DataSource = allBitacora.ToList();
                    btnImprimir.Enabled = true;
                }
                else {
                    btnImprimir.Enabled = false;
                    MessageBox.Show("La bitacora esta vacia", "", MessageBoxButtons.OK);
                }
            }
            catch (UIException ex) {
                FacadeService.ManageException(ex);
            }

        }
        private void BitacoraDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormBitacora_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            gridControlBitacora.ShowPrintPreview();
        }
    }
}
