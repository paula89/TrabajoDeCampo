namespace TC_Riveros_Paula
{
    partial class NuevoProducto
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxProveedor = new System.Windows.Forms.TextBox();
            this.textBoxComentario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.labelComentario = new System.Windows.Forms.Label();
            this.dataGridViewListarStockHerramientas = new System.Windows.Forms.DataGridView();
            this.labelStockHerramientas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarStockHerramientas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(586, 415);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(687, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(29, 21);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(197, 20);
            this.textBoxNombre.TabIndex = 2;
            // 
            // textBoxProveedor
            // 
            this.textBoxProveedor.Location = new System.Drawing.Point(29, 74);
            this.textBoxProveedor.Name = "textBoxProveedor";
            this.textBoxProveedor.Size = new System.Drawing.Size(197, 20);
            this.textBoxProveedor.TabIndex = 3;
            // 
            // textBoxComentario
            // 
            this.textBoxComentario.Location = new System.Drawing.Point(29, 138);
            this.textBoxComentario.Multiline = true;
            this.textBoxComentario.Name = "textBoxComentario";
            this.textBoxComentario.Size = new System.Drawing.Size(190, 72);
            this.textBoxComentario.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre";
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Location = new System.Drawing.Point(248, 81);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(56, 13);
            this.labelProveedor.TabIndex = 11;
            this.labelProveedor.Text = "Proveedor";
            // 
            // labelComentario
            // 
            this.labelComentario.AutoSize = true;
            this.labelComentario.Location = new System.Drawing.Point(244, 141);
            this.labelComentario.Name = "labelComentario";
            this.labelComentario.Size = new System.Drawing.Size(60, 13);
            this.labelComentario.TabIndex = 15;
            this.labelComentario.Text = "Comentario";
            // 
            // dataGridViewListarStockHerramientas
            // 
            this.dataGridViewListarStockHerramientas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListarStockHerramientas.Location = new System.Drawing.Point(400, 42);
            this.dataGridViewListarStockHerramientas.Name = "dataGridViewListarStockHerramientas";
            this.dataGridViewListarStockHerramientas.Size = new System.Drawing.Size(362, 344);
            this.dataGridViewListarStockHerramientas.TabIndex = 16;
            // 
            // labelStockHerramientas
            // 
            this.labelStockHerramientas.AutoSize = true;
            this.labelStockHerramientas.Location = new System.Drawing.Point(397, 24);
            this.labelStockHerramientas.Name = "labelStockHerramientas";
            this.labelStockHerramientas.Size = new System.Drawing.Size(359, 13);
            this.labelStockHerramientas.TabIndex = 17;
            this.labelStockHerramientas.Text = "Elija la materia prima y las herramientas necesarias para realizar el producto";
            // 
            // NuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelStockHerramientas);
            this.Controls.Add(this.dataGridViewListarStockHerramientas);
            this.Controls.Add(this.labelComentario);
            this.Controls.Add(this.labelProveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxComentario);
            this.Controls.Add(this.textBoxProveedor);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "NuevoProducto";
            this.Text = "Nuevo Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarStockHerramientas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxProveedor;
        private System.Windows.Forms.TextBox textBoxComentario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.Label labelComentario;
        private System.Windows.Forms.DataGridView dataGridViewListarStockHerramientas;
        private System.Windows.Forms.Label labelStockHerramientas;
    }
}