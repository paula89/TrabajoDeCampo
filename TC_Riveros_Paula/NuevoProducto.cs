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
    public partial class NuevoProductoForm : Form
    {
        public NuevoProductoForm(ResourceManager idioma)
        {
            InitializeComponent();
            this.Text = idioma.GetString("NuevoProductoForm");
            CargarTraducciones(idioma);
        }

        private void CargarTraducciones(ResourceManager idioma)
        {
            labelComentario.Text = idioma.GetString("labelComentario");
            labelNombre.Text = idioma.GetString("labelNombre");
            labelStockHerramientas.Text = idioma.GetString("labelStockHerramientas");

            btnCancelar.Text = idioma.GetString("btnCancelar");
            btnGuardar.Text = idioma.GetString("btnGuardar");

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void labelStockHerramientas_Click(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
