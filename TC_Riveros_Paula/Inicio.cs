using ServicesTest.BLL;
using ServicesTest;
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
using ServicesTest.Domain.Exceptions;
using ServicesTest.Facade;

namespace TC_Riveros_Paula
{
    public partial class InicioForm : Form
    {
        string cultureInfo = Thread.CurrentThread.CurrentUICulture.Name; 
        //BLLRepositories bllRepositories = new BLLRepositories();
        ResourceManager idioma;


        public InicioForm()
        {
            InitializeComponent();
            idioma = FacadeService.Translate(cultureInfo);
            this.Text = idioma.GetString("InicioForm");
            CargarTraducciones(idioma);

       }

        private void CargarTraducciones(ResourceManager idioma) {
            //idioma = Services.BLL.LanguageManager.Current.Translate.Translate("en-US");
            try
            {
               // Exception ex = new Exception();
                // FacadeService.ManageException(new UIException(ex));
                productosToolStripMenuItem.Text = idioma.GetString("productosToolStripMenuItem");
                MateriaPrimaToolStripMenuItem.Text = idioma.GetString("MateriaPrimaToolStripMenuItem");
                herramientasToolStripMenuItem.Text = idioma.GetString("herramientasToolStripMenuItem");
                promocionesToolStripMenuItem.Text = idioma.GetString("promocionesToolStripMenuItem");
                ventasToolStripMenuItem.Text = idioma.GetString("ventasToolStripMenuItem");
                reportesToolStripMenuItem.Text = idioma.GetString("reportesToolStripMenuItem");
                calcularToolStripMenuItem.Text = idioma.GetString("calcularToolStripMenuItem");
                SeguridadToolStripMenuItem.Text = idioma.GetString("SeguridadToolStripMenuItem");
                ayudaToolStripMenuItem.Text = idioma.GetString("ayudaToolStripMenuItem");

                MenuItemNuevoProducto.Text = idioma.GetString("MenuItemNuevoProducto");
                MenuItemCatalogo.Text = idioma.GetString("MenuItemCatalogo");
                MenuItemNuevoMateriaPrima.Text = idioma.GetString("MenuItemNuevoMateriaPrima");
                MenuItemVerMateriaPrima.Text = idioma.GetString("MenuItemVerMateriaPrima");
                nuevaHerramientaToolStripMenuItem.Text = idioma.GetString("nuevaHerramientaToolStripMenuItem");
                listarHerramientasToolStripMenuItem.Text = idioma.GetString("listarHerramientasToolStripMenuItem");
                MenuItemNuevaPromocion.Text = idioma.GetString("MenuItemNuevaPromocion");
                MenuItemVerPromociones.Text = idioma.GetString("MenuItemVerPromociones");
                nuevaVentaToolStripMenuItem.Text = idioma.GetString("nuevaVentaToolStripMenuItem");
                MenuItemReportesVentas.Text = idioma.GetString("MenuItemReportesVentas");
                MenuItemCalcularPresupuesto.Text = idioma.GetString("MenuItemCalcularPresupuesto");
                CalcularPerdidasToolStripMenuItem.Text = idioma.GetString("CalcularPerdidasToolStripMenuItem");
                BitacoraToolStripMenuItem.Text = idioma.GetString("BitacoraToolStripMenuItem");
            }
            catch (UIException ex) {
                FacadeService.ManageException(ex);
                MessageBox.Show("Error al cargar las traducciones");
            }
        }

        //nuevo producto
        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NuevoProductoForm nuevoProducto = new NuevoProductoForm(idioma);
            nuevoProducto.ShowDialog();
        }

        private void MenuItemCatalogo_Click(object sender, EventArgs e)
        {
            CatalogoForm catalogo = new CatalogoForm(idioma);
            catalogo.ShowDialog();
        }

        private void MenuItemNuevoStock_Click(object sender, EventArgs e)
        {
            NuevoMateriaPrimaForm nuevoStock = new NuevoMateriaPrimaForm(idioma);
            nuevoStock.ShowDialog();
        }

        private void MenuItemVerStock_Click(object sender, EventArgs e)
        {
            ListarMateriaPrimaForm listarMateriaPrima = new ListarMateriaPrimaForm(idioma);
            listarMateriaPrima.ShowDialog();
        }

        private void MenuItemNuevaPromocion_Click(object sender, EventArgs e)
        {
            NuevaPromocionForm nuevaPromocion = new NuevaPromocionForm(idioma);
            nuevaPromocion.ShowDialog();
        }

        private void MenuItemVerPromociones_Click(object sender, EventArgs e)
        {
            ListarPromocionesForm listarPromociones = new ListarPromocionesForm(idioma);
            listarPromociones.ShowDialog();
        }

        private void MenuItemReportesVentas_Click(object sender, EventArgs e)
        {
            ReporteVentasForm reporteVentas = new ReporteVentasForm(idioma);
            reporteVentas.ShowDialog();
        }

        private void MenuItemCalcularPresupuesto_Click(object sender, EventArgs e)
        {
            CalcularPresupuestoForm calcularPresupuesto = new CalcularPresupuestoForm(idioma);
            calcularPresupuesto.ShowDialog();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //nueva herramienta
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaHerramientaForm nuevaHerramienta = new NuevaHerramientaForm(idioma);
            nuevaHerramienta.ShowDialog();
        }

        private void listarHerramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarHerramientasForm listarHerramientas = new ListarHerramientasForm(idioma);
            listarHerramientas.ShowDialog();
        }

        private void CalcularPerdidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcularPerdidasForm calcularPerdidas = new CalcularPerdidasForm(idioma);
            calcularPerdidas.ShowDialog();
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaVentaForm nuevaVenta = new NuevaVentaForm(idioma);
            nuevaVenta.ShowDialog();
        }

        private void BitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBitacora bitacora = new FormBitacora(idioma);
            bitacora.ShowDialog();
        }

        

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
