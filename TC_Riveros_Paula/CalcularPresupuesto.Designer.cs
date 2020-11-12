namespace TC_Riveros_Paula
{
    partial class CalcularPresupuestoForm
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
            this.helpProviderCalcularPresupuesto = new System.Windows.Forms.HelpProvider();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.labelProducto = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelProductosPresupuesto = new System.Windows.Forms.Label();
            this.labelPresupuesto = new System.Windows.Forms.Label();
            this.comboBoxPromociones = new System.Windows.Forms.ComboBox();
            this.btnAgregar2 = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.labelPromociones = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(40, 514);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(112, 28);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "btnCalcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(40, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 21);
            this.textBox1.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(569, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(358, 393);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(40, 202);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 31);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "btnAgregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(223, 514);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 28);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "btnGuardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelProducto.Location = new System.Drawing.Point(312, 50);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(100, 17);
            this.labelProducto.TabIndex = 9;
            this.labelProducto.Text = "labelProducto";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelCantidad.Location = new System.Drawing.Point(312, 147);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(103, 17);
            this.labelCantidad.TabIndex = 10;
            this.labelCantidad.Text = "labelCantidad";
            // 
            // labelProductosPresupuesto
            // 
            this.labelProductosPresupuesto.AutoSize = true;
            this.labelProductosPresupuesto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelProductosPresupuesto.Location = new System.Drawing.Point(566, 9);
            this.labelProductosPresupuesto.Name = "labelProductosPresupuesto";
            this.labelProductosPresupuesto.Size = new System.Drawing.Size(182, 17);
            this.labelProductosPresupuesto.TabIndex = 11;
            this.labelProductosPresupuesto.Text = "labelProductosPresupuesto";
            // 
            // labelPresupuesto
            // 
            this.labelPresupuesto.AutoSize = true;
            this.labelPresupuesto.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPresupuesto.Location = new System.Drawing.Point(56, 382);
            this.labelPresupuesto.Name = "labelPresupuesto";
            this.labelPresupuesto.Size = new System.Drawing.Size(91, 32);
            this.labelPresupuesto.TabIndex = 12;
            this.labelPresupuesto.Text = "Total :";
            // 
            // comboBoxPromociones
            // 
            this.comboBoxPromociones.FormattingEnabled = true;
            this.comboBoxPromociones.Location = new System.Drawing.Point(40, 287);
            this.comboBoxPromociones.Name = "comboBoxPromociones";
            this.comboBoxPromociones.Size = new System.Drawing.Size(237, 24);
            this.comboBoxPromociones.TabIndex = 13;
            // 
            // btnAgregar2
            // 
            this.btnAgregar2.Location = new System.Drawing.Point(317, 287);
            this.btnAgregar2.Name = "btnAgregar2";
            this.btnAgregar2.Size = new System.Drawing.Size(98, 31);
            this.btnAgregar2.TabIndex = 14;
            this.btnAgregar2.Text = "btnAgregar";
            this.btnAgregar2.UseVisualStyleBackColor = true;
            this.btnAgregar2.Click += new System.EventHandler(this.btnAgregar2_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(569, 442);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(98, 31);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "btnEliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // labelPromociones
            // 
            this.labelPromociones.AutoSize = true;
            this.labelPromociones.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelPromociones.Location = new System.Drawing.Point(37, 267);
            this.labelPromociones.Name = "labelPromociones";
            this.labelPromociones.Size = new System.Drawing.Size(124, 17);
            this.labelPromociones.TabIndex = 16;
            this.labelPromociones.Text = "labelPromociones";
            // 
            // CalcularPresupuestoForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.OliveDrab;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 555);
            this.Controls.Add(this.labelPromociones);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar2);
            this.Controls.Add(this.comboBoxPromociones);
            this.Controls.Add(this.labelPresupuesto);
            this.Controls.Add(this.labelProductosPresupuesto);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelProducto);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnCalcular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CalcularPresupuestoForm";
            this.Text = "CalcularPresupuestoForm";
            this.Load += new System.EventHandler(this.CalcularPresupuestoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HelpProvider helpProviderCalcularPresupuesto;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelProductosPresupuesto;
        private System.Windows.Forms.Label labelPresupuesto;
        private System.Windows.Forms.ComboBox comboBoxPromociones;
        private System.Windows.Forms.Button btnAgregar2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label labelPromociones;
    }
}