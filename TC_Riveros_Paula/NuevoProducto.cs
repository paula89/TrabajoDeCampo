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
    public partial class NuevoProducto : Form
    {
        public NuevoProducto(ResourceManager idioma)
        {
            InitializeComponent();
            CargarTraducciones(idioma);
        }

        private void CargarTraducciones(ResourceManager idioma)
        {
            labelComentario.Text = idioma.GetString("labelComentario");
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
