namespace TC_Riveros_Paula
{
    partial class NuevoMateriaPrimaForm
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxProveedor = new System.Windows.Forms.TextBox();
            this.textBoxComentario = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelProveedor = new System.Windows.Forms.Label();
            this.labelComentario = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.labelCantidadKG = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.dateTimePickerVencimiento = new System.Windows.Forms.DateTimePicker();
            this.labelVencimiento = new System.Windows.Forms.Label();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.helpProviderCrearMP = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(482, 443);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(112, 28);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "btnAceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(650, 443);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 28);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "btnCancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(37, 41);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(198, 27);
            this.textBoxNombre.TabIndex = 2;
            // 
            // textBoxProveedor
            // 
            this.textBoxProveedor.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxProveedor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProveedor.Location = new System.Drawing.Point(37, 119);
            this.textBoxProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxProveedor.Name = "textBoxProveedor";
            this.textBoxProveedor.Size = new System.Drawing.Size(198, 27);
            this.textBoxProveedor.TabIndex = 3;
            // 
            // textBoxComentario
            // 
            this.textBoxComentario.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxComentario.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBoxComentario.Location = new System.Drawing.Point(37, 292);
            this.textBoxComentario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxComentario.MaxLength = 100;
            this.textBoxComentario.Multiline = true;
            this.textBoxComentario.Name = "textBoxComentario";
            this.textBoxComentario.Size = new System.Drawing.Size(198, 115);
            this.textBoxComentario.TabIndex = 4;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelNombre.Location = new System.Drawing.Point(280, 49);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(93, 17);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "labelNombre";
            // 
            // labelProveedor
            // 
            this.labelProveedor.AutoSize = true;
            this.labelProveedor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelProveedor.Location = new System.Drawing.Point(280, 123);
            this.labelProveedor.Name = "labelProveedor";
            this.labelProveedor.Size = new System.Drawing.Size(107, 17);
            this.labelProveedor.TabIndex = 6;
            this.labelProveedor.Text = "labelProveedor";
            // 
            // labelComentario
            // 
            this.labelComentario.AutoSize = true;
            this.labelComentario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelComentario.Location = new System.Drawing.Point(280, 295);
            this.labelComentario.Name = "labelComentario";
            this.labelComentario.Size = new System.Drawing.Size(119, 17);
            this.labelComentario.TabIndex = 7;
            this.labelComentario.Text = "labelComentario";
            this.labelComentario.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxCantidad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCantidad.Location = new System.Drawing.Point(482, 41);
            this.textBoxCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(233, 27);
            this.textBoxCantidad.TabIndex = 8;
            // 
            // labelCantidadKG
            // 
            this.labelCantidadKG.AutoSize = true;
            this.labelCantidadKG.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelCantidadKG.Location = new System.Drawing.Point(752, 44);
            this.labelCantidadKG.Name = "labelCantidadKG";
            this.labelCantidadKG.Size = new System.Drawing.Size(122, 17);
            this.labelCantidadKG.TabIndex = 10;
            this.labelCantidadKG.Text = "labelCantidadKG";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelMarca.Location = new System.Drawing.Point(280, 210);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(81, 17);
            this.labelMarca.TabIndex = 11;
            this.labelMarca.Text = "labelMarca";
            // 
            // dateTimePickerVencimiento
            // 
            this.dateTimePickerVencimiento.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.dateTimePickerVencimiento.Location = new System.Drawing.Point(482, 123);
            this.dateTimePickerVencimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerVencimiento.Name = "dateTimePickerVencimiento";
            this.dateTimePickerVencimiento.Size = new System.Drawing.Size(233, 22);
            this.dateTimePickerVencimiento.TabIndex = 12;
            // 
            // labelVencimiento
            // 
            this.labelVencimiento.AutoSize = true;
            this.labelVencimiento.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.labelVencimiento.Location = new System.Drawing.Point(752, 132);
            this.labelVencimiento.Name = "labelVencimiento";
            this.labelVencimiento.Size = new System.Drawing.Size(122, 17);
            this.labelVencimiento.TabIndex = 13;
            this.labelVencimiento.Text = "labelVencimiento";
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxMarca.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarca.Location = new System.Drawing.Point(37, 202);
            this.textBoxMarca.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(198, 27);
            this.textBoxMarca.TabIndex = 14;
            // 
            // NuevoMateriaPrimaForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.OliveDrab;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 555);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.labelVencimiento);
            this.Controls.Add(this.dateTimePickerVencimiento);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelCantidadKG);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.labelComentario);
            this.Controls.Add(this.labelProveedor);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxComentario);
            this.Controls.Add(this.textBoxProveedor);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NuevoMateriaPrimaForm";
            this.Text = "NuevoMateriaPrimaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxProveedor;
        private System.Windows.Forms.TextBox textBoxComentario;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelProveedor;
        private System.Windows.Forms.Label labelComentario;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label labelCantidadKG;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.DateTimePicker dateTimePickerVencimiento;
        private System.Windows.Forms.Label labelVencimiento;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.HelpProvider helpProviderCrearMP;
    }
}