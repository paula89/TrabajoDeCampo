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
        }

        private void CatalogoForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewCatalogo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }
    }
}
