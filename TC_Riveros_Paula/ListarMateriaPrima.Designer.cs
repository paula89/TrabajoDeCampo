namespace TC_Riveros_Paula
{
    partial class ListarMateriaPrimaForm
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
            this.dataGridViewMateriaPrima = new System.Windows.Forms.DataGridView();
            this.dateTimePickerVencimientoHasta = new System.Windows.Forms.DateTimePicker();
            this.textBoxProveedor = new System.Windows.Forms.TextBox();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateriaPrima)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMateriaPrima
            // 
            this.dataGridViewMateriaPrima.AllowUserToAddRows = false;
            this.dataGridViewMateriaPrima.AllowUserToDeleteRows = false;
            this.dataGridViewMateriaPrima.AllowUserToOrderColumns = true;
            this.dataGridViewMateriaPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMateriaPrima.Location = new System.Drawing.Point(28, 182);
            this.dataGridViewMateriaPrima.Name = "dataGridViewMateriaPrima";
            this.dataGridViewMateriaPrima.Size = new System.Drawing.Size(739, 244);
            this.dataGridViewMateriaPrima.TabIndex = 0;
            // 
            // dateTimePickerVencimientoHasta
            // 
            this.dateTimePickerVencimientoHasta.Location = new System.Drawing.Point(18, 48);
            this.dateTimePickerVencimientoHasta.Name = "dateTimePickerVencimientoHasta";
            this.dateTimePickerVencimientoHasta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerVencimientoHasta.TabIndex = 1;
            // 
            // textBoxProveedor
            // 
            this.textBoxProveedor.Location = new System.Drawing.Point(527, 48);
            this.textBoxProveedor.Name = "textBoxProveedor";
            this.textBoxProveedor.Size = new System.Drawing.Size(138, 20);
            this.textBoxProveedor.TabIndex = 3;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(15, 32);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(105, 13);
            this.lblFechaVencimiento.TabIndex = 4;
            this.lblFechaVencimiento.Text = "lblFechaVencimiento";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(282, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "lblNombre";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(524, 32);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(66, 13);
            this.lblProveedor.TabIndex = 6;
            this.lblProveedor.Text = "lblProveedor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.dateTimePickerVencimientoHasta);
            this.groupBox1.Controls.Add(this.lblProveedor);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.textBoxProveedor);
            this.groupBox1.Controls.Add(this.lblFechaVencimiento);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 127);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(285, 51);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(143, 20);
            this.textBoxNombre.TabIndex = 8;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(638, 98);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "btnFiltrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(692, 446);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "btnActualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(527, 98);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "btnBuscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ListarMateriaPrimaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewMateriaPrima);
            this.Name = "ListarMateriaPrimaForm";
            this.Text = "ListarMateriaPrimaForm";
            this.Load += new System.EventHandler(this.ListarMateriaPrimaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateriaPrima)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMateriaPrima;
        private System.Windows.Forms.DateTimePicker dateTimePickerVencimientoHasta;
        private System.Windows.Forms.TextBox textBoxProveedor;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnBuscar;
    }
}