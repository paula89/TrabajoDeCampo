namespace TC_Riveros_Paula
{
    partial class NuevaVentaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAceptar = new System.Windows.Forms.Button();
            this.helpProviderVentas = new System.Windows.Forms.HelpProvider();
            this.gridControlPresupuestos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPresupuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(0, 521);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(930, 34);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "btnAceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // gridControlPresupuestos
            // 
            this.gridControlPresupuestos.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlPresupuestos.Location = new System.Drawing.Point(0, 0);
            this.gridControlPresupuestos.MainView = this.gridView1;
            this.gridControlPresupuestos.Name = "gridControlPresupuestos";
            this.gridControlPresupuestos.Size = new System.Drawing.Size(930, 513);
            this.gridControlPresupuestos.TabIndex = 3;
            this.gridControlPresupuestos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlPresupuestos;
            this.gridView1.Name = "gridView1";
            // 
            // NuevaVentaForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.OliveDrab;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 555);
            this.Controls.Add(this.gridControlPresupuestos);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NuevaVentaForm";
            this.Text = "NuevaVentaForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPresupuestos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.HelpProvider helpProviderVentas;
        private DevExpress.XtraGrid.GridControl gridControlPresupuestos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}