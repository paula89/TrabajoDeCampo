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
using ServicesTest.Domain.Composite;
using ServicesTest.Domain.Exceptions;
using ServicesTest.Facade;

namespace TC_Riveros_Paula
{
    public partial class InicioForm : Form
    {
        //string cultureInfo = Thread.CurrentThread.CurrentUICulture.Name; 
        ResourceManager idioma;
        string usuario;

        public InicioForm(List<String> permiso, String Cod_Usuario, ResourceManager idiomaElegido)
        {
            InitializeComponent(permiso);
            idioma = idiomaElegido;
            usuario = Cod_Usuario;
            this.Text = idioma.GetString("InicioForm");
            CargarTraducciones(idioma, permiso);
            RegistrarBackup();
       }

        private void RegistrarBackup() {
            FacadeService.ManageBackup();
        }

        private void CargarTraducciones(ResourceManager idioma, List<String> permiso) {
            //idioma = Services.BLL.LanguageManager.Current.Translate.Translate("en-US");
            try
            {
                //Exception ex = new Exception();
                //FacadeService.ManageException(new UIException(ex));
               
                productosToolStripMenuItem.Text = idioma.GetString("productosToolStripMenuItem");
                MateriaPrimaToolStripMenuItem.Text = idioma.GetString("MateriaPrimaToolStripMenuItem");
                herramientasToolStripMenuItem.Text = idioma.GetString("herramientasToolStripMenuItem");
                promocionesToolStripMenuItem.Text = idioma.GetString("promocionesToolStripMenuItem");
                ventasToolStripMenuItem.Text = idioma.GetString("ventasToolStripMenuItem");
                reportesToolStripMenuItem.Text = idioma.GetString("reportesToolStripMenuItem");
                calcularToolStripMenuItem.Text = idioma.GetString("calcularToolStripMenuItem");
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
               
                if (isAdmin(permiso)) {
                    UsuariosToolStripMenuItem.Text = idioma.GetString("UsuariosToolStripMenuItem");
                    SeguridadToolStripMenuItem.Text = idioma.GetString("SeguridadToolStripMenuItem");

                    BitacoraToolStripMenuItem.Text = idioma.GetString("BitacoraToolStripMenuItem");
                    BackupToolStripMenuItem.Text = idioma.GetString("BackupToolStripMenuItem");
                    MenuItemNuevoUsuario.Text = idioma.GetString("MenuItemNuevoUsuario"); 
                    MenuItemVerUsuarios.Text = idioma.GetString("MenuItemVerUsuarios");
                    TrackingToolStripMenuItem.Text = idioma.GetString("TrackingToolStripMenuItem");

                }

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
            NuevoMateriaPrimaForm nuevoStock = new NuevoMateriaPrimaForm(idioma, usuario);
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
        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosForm usuarios = new UsuariosForm(idioma);
            usuarios.ShowDialog();
        }
        private void VerUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarUsuariosForm usuarios = new ListarUsuariosForm(idioma);
            usuarios.ShowDialog();
        }
        private void BitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBitacora bitacora = new FormBitacora(idioma);
            bitacora.ShowDialog();
        }

        private void BackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackupForm backup = new BackupForm(idioma);
            backup.ShowDialog();
        }

        private void TrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrackingForm tracking = new TrackingForm(idioma);
            tracking.ShowDialog();
        }


        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
