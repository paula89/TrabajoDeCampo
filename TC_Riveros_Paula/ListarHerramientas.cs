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
        public ListarHerramientasForm(ResourceManager idioma)
        {
            InitializeComponent();
            this.Text = idioma.GetString("ListarHerramientasForm");
            this.btnImprimir.Text = idioma.GetString("btnImprimir");
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
