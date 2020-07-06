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
using ServicesTest;
using ServicesTest.Domain.Exceptions;
using ServicesTest.Facade;

namespace TC_Riveros_Paula
{
    public partial class FormBitacora : Form
    {
        public FormBitacora(ResourceManager idioma)
        {
            InitializeComponent();
            this.Text = idioma.GetString("FormBitacora");
            CargarTabla();
        }

        public void CargarTabla() {
            try
            {
                IEnumerable<Bitacora> bitacora = BitacoraManager.Current.ObtenerBitacoras();
                BitacoraDataGridView.DataSource = bitacora.ToList();
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
    }
}
