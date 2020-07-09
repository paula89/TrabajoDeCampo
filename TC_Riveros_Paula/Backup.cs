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
    public partial class BackupForm : Form
    {
        public BackupForm(ResourceManager idioma)
        {
            InitializeComponent();
            this.Text = idioma.GetString("FormBitacora");
            CargarTabla();
        }

        public void CargarTabla()
        {
            try
            {
                IEnumerable<Backup> bitacora = BackupManager.Current.ObtenerBackup();
                BackupDataGridView.DataSource = bitacora.ToList();
            }
            catch (UIException ex)
            {
                FacadeService.ManageException(ex);
            }

        }

        private void BackupForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
