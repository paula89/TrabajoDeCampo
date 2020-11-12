using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class InicioForm : DevExpress.XtraEditors.XtraForm
    {
        ResourceManager idioma;
        string usuario;

        public InicioForm(List<String> permiso, String Cod_Usuario, ResourceManager idiomaElegido)
        {
            InitializeComponent(permiso);
            idioma = idiomaElegido;
            usuario = Cod_Usuario;
            this.Text = "CookerSoft";
            CargarTraducciones(idioma, permiso);
            RegistrarBackup();
       }
        /// <summary>
        /// Regiter a backup automatically when the system init 
        /// </summary>
        private void RegistrarBackup() {
            FacadeService.ManageBackup();
        }
        /// <summary>
        /// load translations
        /// </summary>
        /// <param name="idioma"></param>
        /// <param name="permiso"></param>
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
                MenuItemActualizarProducto.Text = idioma.GetString("MenuItemActualizarProducto");//
                MenuItemNuevoMateriaPrima.Text = idioma.GetString("MenuItemNuevoMateriaPrima");
                MenuItemVerMateriaPrima.Text = idioma.GetString("MenuItemVerMateriaPrima");
                MenuItemActualizarMateriaPrima.Text = idioma.GetString("MenuItemActualizarMateriaPrima");//
                nuevaHerramientaToolStripMenuItem.Text = idioma.GetString("nuevaHerramientaToolStripMenuItem");
                listarHerramientasToolStripMenuItem.Text = idioma.GetString("listarHerramientasToolStripMenuItem");
                actualizarHerramientaToolStripMenuItem.Text = idioma.GetString("actualizarHerramientaToolStripMenuItem");//
                MenuItemNuevaPromocion.Text = idioma.GetString("MenuItemNuevaPromocion");
                MenuItemVerPromociones.Text = idioma.GetString("MenuItemVerPromociones");
                MenuItemActualizarPromocion.Text = idioma.GetString("MenuItemActualizarPromocion");//
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
                    MenuItemActualizarUsuario.Text = idioma.GetString("MenuItemActualizarUsuario");
                    TrackingToolStripMenuItem.Text = idioma.GetString("TrackingToolStripMenuItem");

                }

            }
            catch (UIException ex) {
                FacadeService.ManageException(ex);
                MessageBox.Show("Error al cargar las traducciones");
            }
        }



        /// <summary>
        /// load the NuevoProductoForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NuevoProductoForm nuevoProducto = new NuevoProductoForm(idioma);
            nuevoProducto.ShowDialog();
        }
        /// <summary>
        /// load the CatalogoForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemCatalogo_Click(object sender, EventArgs e)
        {
            CatalogoForm catalogo = new CatalogoForm(idioma);
            catalogo.ShowDialog();
        }
        /// <summary>
        /// load the ActualizarProductoForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemActualizarProducto_Click(object sender, EventArgs e)
        {
            ActualizarProducto actualizarProducto = new ActualizarProducto(idioma);
            actualizarProducto.ShowDialog();
        }
        /// <summary>
        /// load the ActualizarProductoForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemActualizarMateriaPrima_Click(object sender, EventArgs e)
        {
            ActualizarMateriaPrimaForm actualizarMateriaPrima = new ActualizarMateriaPrimaForm(idioma);
            actualizarMateriaPrima.ShowDialog();
        }
        /// <summary>
        /// load the ActualizarHerramientaForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void actualizarHerramientaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActualizarHerramientaForm actualizarHerramienta = new ActualizarHerramientaForm(idioma);
            actualizarHerramienta.ShowDialog();
        }
        /// <summary>
        /// load the ActualizarPromocionForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemActualizarPromocion_Click(object sender, EventArgs e)
        {
              ActualizarPromocion actualizarPromocion = new ActualizarPromocion(idioma);
              actualizarPromocion.ShowDialog();
        }
        /// <summary>
        /// load the NuevoMateriaPrimaForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemNuevoStock_Click(object sender, EventArgs e)
        {
            NuevoMateriaPrimaForm nuevoStock = new NuevoMateriaPrimaForm(idioma, usuario);
            nuevoStock.ShowDialog();
        }
        /// <summary>
        /// load the ListarMateriaPrimaForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemVerStock_Click(object sender, EventArgs e)
        {
            ListarMateriaPrimaForm listarMateriaPrima = new ListarMateriaPrimaForm(idioma);
            listarMateriaPrima.ShowDialog();
        }
        /// <summary>
        /// load the NuevaPromocionForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemNuevaPromocion_Click(object sender, EventArgs e)
        {
            NuevaPromocionForm nuevaPromocion = new NuevaPromocionForm(idioma);
            nuevaPromocion.ShowDialog();
        }
        /// <summary>
        /// load the ListarPromocionesForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemVerPromociones_Click(object sender, EventArgs e)
        {
            ListarPromocionesForm listarPromociones = new ListarPromocionesForm(idioma);
            listarPromociones.ShowDialog();
        }
        /// <summary>
        /// load the ReporteVentasForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemReportesVentas_Click(object sender, EventArgs e)
        {
            ReporteVentasForm reporteVentas = new ReporteVentasForm(idioma);
            reporteVentas.ShowDialog();
        }
        /// <summary>
        /// load the CalcularPresupuestoForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemCalcularPresupuesto_Click(object sender, EventArgs e)
        {
            CalcularPresupuestoForm calcularPresupuesto = new CalcularPresupuestoForm(idioma);
            calcularPresupuesto.ShowDialog();
        }
        
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// load the NuevaHerramientaForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaHerramientaForm nuevaHerramienta = new NuevaHerramientaForm(idioma);
            nuevaHerramienta.ShowDialog();
        }
        /// <summary>
        /// load the ListarHerramientasForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listarHerramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarHerramientasForm listarHerramientas = new ListarHerramientasForm(idioma);
            listarHerramientas.ShowDialog();
        }
        /// <summary>
        /// load the CalcularPerdidasForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalcularPerdidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalcularPerdidasForm calcularPerdidas = new CalcularPerdidasForm(idioma);
            calcularPerdidas.ShowDialog();
        }
        /// <summary>
        /// load the NuevaVentaForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevaVentaForm nuevaVenta = new NuevaVentaForm(idioma);
            nuevaVenta.ShowDialog();
        }
        /// <summary>
        /// load the UsuariosForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsuariosForm usuarios = new UsuariosForm(idioma);
            usuarios.ShowDialog();
        }
        /// <summary>
        /// load the ListarUsuariosForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VerUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListarUsuariosForm usuarios = new ListarUsuariosForm(idioma);
            usuarios.ShowDialog();
        }
        /// <summary>
        /// load the ActualizarUsuarioForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuItemActualizarUsuario_Click(object sender, EventArgs e)
        {
            ActualizarUsuarioForm actualizarUsuarios = new ActualizarUsuarioForm(idioma);
            actualizarUsuarios.ShowDialog();
        }
        /// <summary>
        /// load the FormBitacora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBitacora bitacora = new FormBitacora(idioma);
            bitacora.ShowDialog();
        }
        /// <summary>
        /// load the BackupForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackupForm backup = new BackupForm(idioma);
            backup.ShowDialog();
        }
        /// <summary>
        /// load the TrackingForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrackingForm tracking = new TrackingForm(idioma);
            tracking.ShowDialog();
        }
        /// <summary>
        /// Open the help pdf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this,Application.StartupPath + "/CookerSoft.chm");
            //Process.Start("CookerSoft.pdf");
        }
        


        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void InicioForm_Load(object sender, EventArgs e)
        {

        }

        private void InicioForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
