namespace TC_Riveros_Paula
{
    partial class FormBitacora
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
            this.BitacoraDataGridView = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.comboBoxCriticidad = new System.Windows.Forms.ComboBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblCriticidad = new System.Windows.Forms.Label();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.BitacoraDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BitacoraDataGridView
            // 
            this.BitacoraDataGridView.AllowUserToAddRows = false;
            this.BitacoraDataGridView.AllowUserToDeleteRows = false;
            this.BitacoraDataGridView.AllowUserToOrderColumns = true;
            this.BitacoraDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BitacoraDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.BitacoraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BitacoraDataGridView.Location = new System.Drawing.Point(55, 141);
            this.BitacoraDataGridView.Name = "BitacoraDataGridView";
            this.BitacoraDataGridView.ReadOnly = true;
            this.BitacoraDataGridView.Size = new System.Drawing.Size(704, 345);
            this.BitacoraDataGridView.TabIndex = 0;
            this.BitacoraDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BitacoraDataGridView_CellContentClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(684, 97);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "btnBuscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // comboBoxCriticidad
            // 
            this.comboBoxCriticidad.FormattingEnabled = true;
            this.comboBoxCriticidad.Location = new System.Drawing.Point(560, 68);
            this.comboBoxCriticidad.Name = "comboBoxCriticidad";
            this.comboBoxCriticidad.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCriticidad.TabIndex = 3;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(52, 41);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(48, 13);
            this.lblDesde.TabIndex = 6;
            this.lblDesde.Text = "lblDesde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(295, 41);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(45, 13);
            this.lblHasta.TabIndex = 7;
            this.lblHasta.Text = "lblHasta";
            // 
            // lblCriticidad
            // 
            this.lblCriticidad.AutoSize = true;
            this.lblCriticidad.Location = new System.Drawing.Point(557, 41);
            this.lblCriticidad.Name = "lblCriticidad";
            this.lblCriticidad.Size = new System.Drawing.Size(60, 13);
            this.lblCriticidad.TabIndex = 8;
            this.lblCriticidad.Text = "lblCriticidad";
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Location = new System.Drawing.Point(298, 69);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerHasta.TabIndex = 9;
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Location = new System.Drawing.Point(55, 69);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDesde.TabIndex = 10;
            // 
            // FormBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 525);
            this.Controls.Add(this.dateTimePickerDesde);
            this.Controls.Add(this.dateTimePickerHasta);
            this.Controls.Add(this.lblCriticidad);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.comboBoxCriticidad);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.BitacoraDataGridView);
            this.Name = "FormBitacora";
            this.Text = "BitacoraForm";
            this.Load += new System.EventHandler(this.FormBitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BitacoraDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView BitacoraDataGridView;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox comboBoxCriticidad;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblCriticidad;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
    }
}