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
    public partial class CalcularPerdidasForm : DevExpress.XtraEditors.XtraForm
    {
        public CalcularPerdidasForm(ResourceManager idioma)
        {
            InitializeComponent();
            this.Text = idioma.GetString("CalcularPerdidasForm");
        }

        private void CalcularPerdidasForm_Load(object sender, EventArgs e)
        {

        }
    }
}
