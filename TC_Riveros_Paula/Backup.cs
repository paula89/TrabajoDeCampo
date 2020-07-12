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
        private string msgConfirm, titleConfirm, msgOk, msgError;
        public BackupForm(ResourceManager idioma)
        {
            InitializeComponent();
            this.Text = idioma.GetString("FormBitacora");
            this.CargarTraducciones(idioma);
        }

        public void CargarTraducciones(ResourceManager idioma) 
        {
            this.btnFiltrar.Text = idioma.GetString("btnFiltrar");
            this.lblHasta.Text = idioma.GetString("lblHasta");
            this.lblDesde.Text = idioma.GetString("lblDesde");
            this.btnRestaurar.Text = idioma.GetString("btnRestaurar");
            this.msgConfirm = idioma.GetString("msgConfirm");
            this.titleConfirm = idioma.GetString("titleConfirm");
            this.msgOk = idioma.GetString("msgOk");
            this.msgError = idioma.GetString("msgError");
        }
        public void CargarTabla()
        {
            try
            {
                string desde = this.dateTimePickerDesde.Value.ToString();
                string hasta = this.dateTimePickerHasta.Value.ToString();
                String[] filtros = new string[] { desde, hasta };

                IEnumerable<Backup> backup = BackupManager.Current.ObtenerBackup(filtros);
                BackupDataGridView.DataSource = backup.ToList();

                if (backup.ToList().Count == 0) {
                    this.btnRestaurar.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                FacadeService.ManageException((UIException)ex);
            }

        }

        private void BackupForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
           DialogResult response = MessageBox.Show(msgConfirm, titleConfirm, MessageBoxButtons.OKCancel);
            System.Console.WriteLine("Response ::: " + response);

            if (response == DialogResult.OK) {
                this.Restaurar(BackupDataGridView.CurrentRow.Cells[2].Value.ToString());                
            } 
        }

        private void Restaurar(string path) {
            try
            {
                if (BackupManager.Current.RestaurarBackup(path) == -1)
                {
                    MessageBox.Show(msgOk, titleConfirm, MessageBoxButtons.OK);
                }
                else {
                    MessageBox.Show(msgError, titleConfirm, MessageBoxButtons.OK);

                }
            }
            catch (Exception ex) {
                FacadeService.ManageException((UIException)ex);
            }

        }

    }
}
