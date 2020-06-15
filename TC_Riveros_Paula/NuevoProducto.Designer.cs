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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxComentario = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
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
            this.btnGuardar.Text = "btnGuardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(687, 415);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(29, 21);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(197, 20);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxComentario
            // 
            this.textBoxComentario.Location = new System.Drawing.Point(29, 138);
            this.textBoxComentario.Multiline = true;
            this.textBoxComentario.Name = "textBoxComentario";
            this.textBoxComentario.Size = new System.Drawing.Size(190, 72);
            this.textBoxComentario.TabIndex = 7;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(248, 28);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(66, 13);
            this.labelNombre.TabIndex = 10;
            this.labelNombre.Text = "labelNombre";
            // 
            // labelComentario
            // 
            this.labelComentario.AutoSize = true;
            this.labelComentario.Location = new System.Drawing.Point(244, 141);
            this.labelComentario.Name = "labelComentario";
            this.labelComentario.Size = new System.Drawing.Size(82, 13);
            this.labelComentario.TabIndex = 15;
            this.labelComentario.Text = "labelComentario";
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
            this.labelStockHerramientas.Size = new System.Drawing.Size(119, 13);
            this.labelStockHerramientas.TabIndex = 17;
            this.labelStockHerramientas.Text = "labelStockHerramientas";
            this.labelStockHerramientas.Click += new System.EventHandler(this.labelStockHerramientas_Click);
            // 
            // NuevoProductoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelStockHerramientas);
            this.Controls.Add(this.dataGridViewListarStockHerramientas);
            this.Controls.Add(this.labelComentario);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxComentario);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "NuevoProductoForm";
            this.Text = "NuevoProductoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarStockHerramientas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxComentario;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelComentario;
        private System.Windows.Forms.DataGridView dataGridViewListarStockHerramientas;
        private System.Windows.Forms.Label labelStockHerramientas;
    }
}