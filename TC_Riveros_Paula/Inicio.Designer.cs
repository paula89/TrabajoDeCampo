namespace TC_Riveros_Paula
{
    partial class InicioForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNuevoProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCatalogo = new System.Windows.Forms.ToolStripMenuItem();
            this.MateriaPrimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNuevoMateriaPrima = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemVerMateriaPrima = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaHerramientaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarHerramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promocionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNuevaPromocion = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemVerPromociones = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReportesVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.calcularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCalcularPresupuesto = new System.Windows.Forms.ToolStripMenuItem();
            this.CalcularPerdidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.MateriaPrimaToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.promocionesToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.calcularToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(647, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemNuevoProducto,
            this.MenuItemCatalogo});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(176, 20);
            this.productosToolStripMenuItem.Text = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // MenuItemNuevoProducto
            // 
            this.MenuItemNuevoProducto.Name = "MenuItemNuevoProducto";
            this.MenuItemNuevoProducto.Size = new System.Drawing.Size(213, 22);
            this.MenuItemNuevoProducto.Text = "MenuItemNuevoProducto";
            this.MenuItemNuevoProducto.Click += new System.EventHandler(this.nuevoToolStripMenuItem1_Click);
            // 
            // MenuItemCatalogo
            // 
            this.MenuItemCatalogo.Name = "MenuItemCatalogo";
            this.MenuItemCatalogo.Size = new System.Drawing.Size(213, 22);
            this.MenuItemCatalogo.Text = "MenuItemCatalogo";
            this.MenuItemCatalogo.Click += new System.EventHandler(this.MenuItemCatalogo_Click);
            // 
            // MateriaPrimaToolStripMenuItem
            // 
            this.MateriaPrimaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemNuevoMateriaPrima,
            this.MenuItemVerMateriaPrima});
            this.MateriaPrimaToolStripMenuItem.Name = "MateriaPrimaToolStripMenuItem";
            this.MateriaPrimaToolStripMenuItem.Size = new System.Drawing.Size(193, 20);
            this.MateriaPrimaToolStripMenuItem.Text = "MateriaPrimaToolStripMenuItem";
            // 
            // MenuItemNuevoMateriaPrima
            // 
            this.MenuItemNuevoMateriaPrima.Name = "MenuItemNuevoMateriaPrima";
            this.MenuItemNuevoMateriaPrima.Size = new System.Drawing.Size(235, 22);
            this.MenuItemNuevoMateriaPrima.Text = "MenuItemNuevoMateriaPrima";
            this.MenuItemNuevoMateriaPrima.Click += new System.EventHandler(this.MenuItemNuevoStock_Click);
            // 
            // MenuItemVerMateriaPrima
            // 
            this.MenuItemVerMateriaPrima.Name = "MenuItemVerMateriaPrima";
            this.MenuItemVerMateriaPrima.Size = new System.Drawing.Size(235, 22);
            this.MenuItemVerMateriaPrima.Text = "MenuItemVerMateriaPrima";
            this.MenuItemVerMateriaPrima.Click += new System.EventHandler(this.MenuItemVerStock_Click);
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaHerramientaToolStripMenuItem,
            this.listarHerramientasToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(191, 20);
            this.herramientasToolStripMenuItem.Text = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Click += new System.EventHandler(this.herramientasToolStripMenuItem_Click);
            // 
            // nuevaHerramientaToolStripMenuItem
            // 
            this.nuevaHerramientaToolStripMenuItem.Name = "nuevaHerramientaToolStripMenuItem";
            this.nuevaHerramientaToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.nuevaHerramientaToolStripMenuItem.Text = "nuevaHerramientaToolStripMenuItem";
            this.nuevaHerramientaToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // listarHerramientasToolStripMenuItem
            // 
            this.listarHerramientasToolStripMenuItem.Name = "listarHerramientasToolStripMenuItem";
            this.listarHerramientasToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
            this.listarHerramientasToolStripMenuItem.Text = "listarHerramientasToolStripMenuItem";
            this.listarHerramientasToolStripMenuItem.Click += new System.EventHandler(this.listarHerramientasToolStripMenuItem_Click);
            // 
            // promocionesToolStripMenuItem
            // 
            this.promocionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemNuevaPromocion,
            this.MenuItemVerPromociones});
            this.promocionesToolStripMenuItem.Name = "promocionesToolStripMenuItem";
            this.promocionesToolStripMenuItem.Size = new System.Drawing.Size(192, 20);
            this.promocionesToolStripMenuItem.Text = "promocionesToolStripMenuItem";
            // 
            // MenuItemNuevaPromocion
            // 
            this.MenuItemNuevaPromocion.Name = "MenuItemNuevaPromocion";
            this.MenuItemNuevaPromocion.Size = new System.Drawing.Size(222, 22);
            this.MenuItemNuevaPromocion.Text = "MenuItemNuevaPromocion";
            this.MenuItemNuevaPromocion.Click += new System.EventHandler(this.MenuItemNuevaPromocion_Click);
            // 
            // MenuItemVerPromociones
            // 
            this.MenuItemVerPromociones.Name = "MenuItemVerPromociones";
            this.MenuItemVerPromociones.Size = new System.Drawing.Size(222, 22);
            this.MenuItemVerPromociones.Text = "MenuItemVerPromociones";
            this.MenuItemVerPromociones.Click += new System.EventHandler(this.MenuItemVerPromociones_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaVentaToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.ventasToolStripMenuItem.Text = "ventasToolStripMenuItem";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.nuevaVentaToolStripMenuItem.Text = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Click += new System.EventHandler(this.nuevaVentaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemReportesVentas});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(165, 20);
            this.reportesToolStripMenuItem.Text = "reportesToolStripMenuItem";
            // 
            // MenuItemReportesVentas
            // 
            this.MenuItemReportesVentas.Name = "MenuItemReportesVentas";
            this.MenuItemReportesVentas.Size = new System.Drawing.Size(210, 22);
            this.MenuItemReportesVentas.Text = "MenuItemReportesVentas";
            this.MenuItemReportesVentas.Click += new System.EventHandler(this.MenuItemReportesVentas_Click);
            // 
            // calcularToolStripMenuItem
            // 
            this.calcularToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCalcularPresupuesto,
            this.CalcularPerdidasToolStripMenuItem});
            this.calcularToolStripMenuItem.Name = "calcularToolStripMenuItem";
            this.calcularToolStripMenuItem.Size = new System.Drawing.Size(163, 20);
            this.calcularToolStripMenuItem.Text = "calcularToolStripMenuItem";
            // 
            // MenuItemCalcularPresupuesto
            // 
            this.MenuItemCalcularPresupuesto.Name = "MenuItemCalcularPresupuesto";
            this.MenuItemCalcularPresupuesto.Size = new System.Drawing.Size(265, 22);
            this.MenuItemCalcularPresupuesto.Text = "MenuItemCalcularPresupuesto";
            this.MenuItemCalcularPresupuesto.Click += new System.EventHandler(this.MenuItemCalcularPresupuesto_Click);
            // 
            // CalcularPerdidasToolStripMenuItem
            // 
            this.CalcularPerdidasToolStripMenuItem.Name = "CalcularPerdidasToolStripMenuItem";
            this.CalcularPerdidasToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.CalcularPerdidasToolStripMenuItem.Text = "CalcularPerdidasToolStripMenuItem";
            this.CalcularPerdidasToolStripMenuItem.Click += new System.EventHandler(this.CalcularPerdidasToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BitacoraToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(154, 20);
            this.ayudaToolStripMenuItem.Text = "ayudaToolStripMenuItem";
            // 
            // BitacoraToolStripMenuItem
            // 
            this.BitacoraToolStripMenuItem.Name = "BitacoraToolStripMenuItem";
            this.BitacoraToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.BitacoraToolStripMenuItem.Text = "BitacoraToolStripMenuItem";
            this.BitacoraToolStripMenuItem.Click += new System.EventHandler(this.BitacoraToolStripMenuItem_Click);

            // 
            // InicioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InicioForm";
            this.Text = "InicioForm";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MateriaPrimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calcularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNuevoProducto;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCatalogo;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNuevoMateriaPrima;
        private System.Windows.Forms.ToolStripMenuItem MenuItemVerMateriaPrima;
        private System.Windows.Forms.ToolStripMenuItem promocionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNuevaPromocion;
        private System.Windows.Forms.ToolStripMenuItem MenuItemVerPromociones;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReportesVentas;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCalcularPresupuesto;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaHerramientaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarHerramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CalcularPerdidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BitacoraToolStripMenuItem;
    }
}

