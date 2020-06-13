using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TC_Riveros_Paula
{
    public partial class Inicio : Form
    {
        string cultureInfo = Thread.CurrentThread.CurrentUICulture.Name; 
        BLLRepositories bllRepositories = new BLLRepositories();
        ResourceManager idioma;


        public Inicio()
        {
            InitializeComponent();
            idioma = Services.BLL.LanguageManager.Current.Translate(cultureInfo);
            CargarTraducciones(idioma);

       }

        private void CargarTraducciones(ResourceManager idioma) {
            //idioma = ServicesBLL.Translate("en-US");

            MenuItemNuevoProducto.Text = idioma.GetString("nuevo");
        }

        //nuevo producto
        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NuevoProducto nuevoProducto = new NuevoProducto(idioma);
            nuevoProducto.ShowDialog();
        }

        private void MenuItemCatalogo_Click(object sender, EventArgs e)
        {
            Catalogo catalogo = new Catalogo();
            catalogo.ShowDialog();
        }

        private void MenuItemNuevoStock_Click(object sender, EventArgs e)
        {
            NuevoStock nuevoStock = new NuevoStock();
            nuevoStock.ShowDialog();
        }

        private void MenuItemVerStock_Click(object sender, EventArgs e)
        {
            ListarMateriaPrima listarStock = new ListarMateriaPrima();
            listarStock.ShowDialog();
        }

        private void MenuItemNuevaPromocion_Click(object sender, EventArgs e)
        {
            NuevaPromocion nuevaPromocion = new NuevaPromocion();
            nuevaPromocion.ShowDialog();
        }

        private void MenuItemVerPromociones_Click(object sender, EventArgs e)
        {
            ListarPromociones listarPromociones = new ListarPromociones();
            listarPromociones.ShowDialog();
        }

        private void MenuItemReportesVentas_Click(object sender, EventArgs e)
        {
            ReporteVentas reporteVentas = new ReporteVentas();
            reporteVentas.ShowDialog();
        }

        private void MenuItemCalcularPresupuesto_Click(object sender, EventArgs e)
        {
            CalcularPresupuesto calcularPresupuesto = new CalcularPresupuesto();
            calcularPresupuesto.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //nueva herramienta
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaHerramienta nuevaHerramienta = new NuevaHerramienta();
            nuevaHerramienta.ShowDialog();
        }

        private void listarHerramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarHerramientas listarHerramientas = new ListarHerramientas();
            listarHerramientas.ShowDialog();
        }

        private void CalcularPerdidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcularPerdidas calcularPerdidas = new CalcularPerdidas();
            calcularPerdidas.ShowDialog();
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaVenta nuevaVenta = new NuevaVenta();
            nuevaVenta.ShowDialog();
        }
    }
}
