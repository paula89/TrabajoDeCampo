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
    public partial class ReporteVentasForm : DevExpress.XtraEditors.XtraForm
    {
        public ReporteVentasForm(ResourceManager idioma)
        {
            InitializeComponent();
            this.Text = idioma.GetString("ReporteVentasForm");
            this.btnImprimir.Text = idioma.GetString("btnImprimir");
            cargarAyuda();
        }
        /// <summary>
        /// load the help when the user press the F1 key
        /// </summary>
        public void cargarAyuda()
        {
            helpProviderReporte.HelpNamespace = Application.StartupPath + "/CookerSoft.chm";
            helpProviderReporte.SetHelpString(this, "Listar ventas");
            // helpProviderCrearMP.SetHelpKeyword(this, "Crear Materia Prima");
            // helpProviderCrearMP.SetHelpNavigator(this,helpProviderCrearMP.);
        }
        private void ReporteVentasForm_Load(object sender, EventArgs e)
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
