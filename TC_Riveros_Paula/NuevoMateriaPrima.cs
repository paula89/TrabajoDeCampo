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
    public partial class NuevoMateriaPrimaForm : Form
    {
        public NuevoMateriaPrimaForm(ResourceManager idioma)
        {
            InitializeComponent();
            this.Text = idioma.GetString("NuevoMateriaPrimaForm");


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
