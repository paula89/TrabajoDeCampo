namespace TC_Riveros_Paula
{
    partial class NuevoProductoForm
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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxComentario = new System.Windows.Forms.TextBox();
            this.dataGridViewListarStockHerramientas = new System.Windows.Forms.DataGridView();
            this.labelStockHerramientas = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelComentario = new System.Windows.Forms.Label();
            this.helpProviderNuevoProducto = new System.Windows.Forms.HelpProvider();
            this.dataGridViewMateriaPrima = new System.Windows.Forms.DataGridView();
            this.labelStockMateriaPrima = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarStockHerramientas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateriaPrima)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(34, 26);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(229, 21);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxComentario
            // 
            this.textBoxComentario.Location = new System.Drawing.Point(467, 32);
            this.textBoxComentario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxComentario.Multiline = true;
            this.textBoxComentario.Name = "textBoxComentario";
            this.textBoxComentario.Size = new System.Drawing.Size(221, 88);
            this.textBoxComentario.TabIndex = 7;
            // 
            // dataGridViewListarStockHerramientas
            // 
            this.dataGridViewListarStockHerramientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListarStockHerramientas.Location = new System.Drawing.Point(467, 190);
            this.dataGridViewListarStockHerramientas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewListarStockHerramientas.Name = "dataGridViewListarStockHerramientas";
            this.dataGridViewListarStockHerramientas.Size = new System.Drawing.Size(422, 279);
            this.dataGridViewListarStockHerramientas.TabIndex = 16;
            // 
            // labelStockHerramientas
            // 
            this.labelStockHerramientas.AutoSize = true;
            this.labelStockHerramientas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockHerramientas.Location = new System.Drawing.Point(464, 170);
            this.labelStockHerramientas.Name = "labelStockHerramientas";
            this.labelStockHerramientas.Size = new System.Drawing.Size(135, 16);
            this.labelStockHerramientas.TabIndex = 17;
            this.labelStockHerramientas.Text = "labelStockHerramientas";
            this.labelStockHerramientas.Click += new System.EventHandler(this.labelStockHerramientas_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(777, 508);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 28);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(631, 508);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 28);
            this.btnGuardar.TabIndex = 19;
            this.btnGuardar.Text = "btnGuardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(291, 30);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(111, 21);
            this.labelNombre.TabIndex = 20;
            this.labelNombre.Text = "labelNombre";
            // 
            // labelComentario
            // 
            this.labelComentario.AutoSize = true;
            this.labelComentario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComentario.Location = new System.Drawing.Point(718, 32);
            this.labelComentario.Name = "labelComentario";
            this.labelComentario.Size = new System.Drawing.Size(142, 21);
            this.labelComentario.TabIndex = 21;
            this.labelComentario.Text = "labelComentario";
            // 
            // dataGridViewMateriaPrima
            // 
            this.dataGridViewMateriaPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMateriaPrima.Location = new System.Drawing.Point(12, 190);
            this.dataGridViewMateriaPrima.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewMateriaPrima.Name = "dataGridViewMateriaPrima";
            this.dataGridViewMateriaPrima.Size = new System.Drawing.Size(422, 279);
            this.dataGridViewMateriaPrima.TabIndex = 22;
            // 
            // labelStockMateriaPrima
            // 
            this.labelStockMateriaPrima.AutoSize = true;
            this.labelStockMateriaPrima.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStockMateriaPrima.Location = new System.Drawing.Point(12, 170);
            this.labelStockMateriaPrima.Name = "labelStockMateriaPrima";
            this.labelStockMateriaPrima.Size = new System.Drawing.Size(137, 16);
            this.labelStockMateriaPrima.TabIndex = 23;
            this.labelStockMateriaPrima.Text = "labelStockMateriaPrima";
            // 
            // NuevoProductoForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.OliveDrab;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 555);
            this.Controls.Add(this.labelStockMateriaPrima);
            this.Controls.Add(this.dataGridViewMateriaPrima);
            this.Controls.Add(this.labelComentario);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.labelStockHerramientas);
            this.Controls.Add(this.dataGridViewListarStockHerramientas);
            this.Controls.Add(this.textBoxComentario);
            this.Controls.Add(this.textBoxNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NuevoProductoForm";
            this.Text = "NuevoProductoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarStockHerramientas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateriaPrima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxComentario;
        private System.Windows.Forms.DataGridView dataGridViewListarStockHerramientas;
        private System.Windows.Forms.Label labelStockHerramientas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelComentario;
        private System.Windows.Forms.HelpProvider helpProviderNuevoProducto;
        private System.Windows.Forms.DataGridView dataGridViewMateriaPrima;
        private System.Windows.Forms.Label labelStockMateriaPrima;
    }
}