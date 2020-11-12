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
    public partial class CatalogoForm : DevExpress.XtraEditors.XtraForm
    {
        public CatalogoForm(ResourceManager idioma)
        {
            InitializeComponent();
            this.Text = idioma.GetString("CatalogoForm");
            this.btnImprimir.Text = idioma.GetString("btnImprimir");
            cargarAyuda();
        }
        /// <summary>
        /// load the help when the user press the F1 key
        /// </summary>
        public void cargarAyuda()
        {
            helpProviderCatalogo.HelpNamespace = Application.StartupPath + "/CookerSoft.chm";
            helpProviderCatalogo.SetHelpString(this, "Listar Productos");
            helpProviderCatalogo.SetHelpKeyword(this, "Listar Productos");
            helpProviderCatalogo.SetHelpNavigator(this, HelpNavigator.KeywordIndex);
        }
        private void CatalogoForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewCatalogo_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
