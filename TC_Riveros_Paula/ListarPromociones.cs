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
    public partial class ListarPromocionesForm : DevExpress.XtraEditors.XtraForm
    {
        public ListarPromocionesForm(ResourceManager idioma)
        {
            InitializeComponent();
            this.Text = idioma.GetString("ListarPromocionesForm");
            this.btnImprimir.Text = idioma.GetString("btnImprimir");
            cargarAyuda();
        }
        /// <summary>
        /// load the help when the user press the F1 key
        /// </summary>
        public void cargarAyuda()
        {
            helpProviderListarPromociones.HelpNamespace = Application.StartupPath + "/CookerSoft.chm";
            helpProviderListarPromociones.SetHelpString(this, "Listar promociones");
            helpProviderListarPromociones.SetHelpKeyword(this, "Listar promociones");
            helpProviderListarPromociones.SetHelpNavigator(this, HelpNavigator.KeywordIndex);
        }
        /// <summary>
        /// print table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }
    }
}
