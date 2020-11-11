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
    public partial class BackupForm : DevExpress.XtraEditors.XtraForm
    {
        private string msgConfirm, titleConfirm, msgOk, msgError;
        public BackupForm(ResourceManager idioma)
        {
            InitializeComponent();
            this.Text = idioma.GetString("FormBitacora");
            this.CargarTraducciones(idioma);
            CargarTabla();
            cargarAyuda();
        }
        /// <summary>
        /// load the help when the user press the F1 key
        /// </summary>
        public void cargarAyuda()
        {
            helpProviderBackup.HelpNamespace = Application.StartupPath + "/CookerSoft.chm";
            helpProviderBackup.SetHelpString(this, "Backup");
            // helpProviderCrearMP.SetHelpKeyword(this, "Crear Materia Prima");
            // helpProviderCrearMP.SetHelpNavigator(this,helpProviderCrearMP.);
        }
        /// <summary>
        /// load the translations
        /// </summary>
        /// <param name="idioma"></param>
        public void CargarTraducciones(ResourceManager idioma) 
        {
            this.btnRestaurar.Text = idioma.GetString("btnRestaurar");
            this.msgConfirm = idioma.GetString("msgConfirm");
            this.titleConfirm = idioma.GetString("titleConfirm");
            this.msgOk = idioma.GetString("msgOk");
            this.msgError = idioma.GetString("msgError");
            this.btnRestaurar.Enabled = false;
        }
        /// <summary>
        /// load the table with the backups
        /// </summary>
        public void CargarTabla()
        {
            try
            {
                /*string desde = this.dateTimePickerDesde.Value.ToString();
                string hasta = this.dateTimePickerHasta.Value.ToString();*/
                String[] filtros = new string[] { };//desde, hasta };

                IEnumerable<Backup> backup = BackupManager.Current.ObtenerBackup(filtros);
                gridControlBackup.DataSource = backup.ToList();
                if (backup.ToList().Count > 0)
                {
                    this.btnRestaurar.Enabled = true;
                }
                else {
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
        }
        /// <summary>
        /// restore the backup selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
           DialogResult response = MessageBox.Show(msgConfirm, titleConfirm, MessageBoxButtons.OKCancel);
            System.Console.WriteLine("Response ::: " + response);

            if (response == DialogResult.OK) {
                Backup backup = new Backup();
                backup = (Backup)this.gridView1.GetFocusedRow();
                System.Console.WriteLine("seleccion ::: " + backup.Path);
                this.Restaurar(backup.Path);
                //  this.Restaurar(gridControlBackup);//.Cells[2].Value.ToString());                
            }
        }
        /// <summary>
        /// show a message to confirm the restore
        /// </summary>
        /// <param name="path"></param>
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
