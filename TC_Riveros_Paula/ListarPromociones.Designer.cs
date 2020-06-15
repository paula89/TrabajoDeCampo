namespace TC_Riveros_Paula
{
    partial class ListarPromocionesForm
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
            this.dataGridViewPromociones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPromociones)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPromociones
            // 
            this.dataGridViewPromociones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPromociones.Location = new System.Drawing.Point(35, 22);
            this.dataGridViewPromociones.Name = "dataGridViewPromociones";
            this.dataGridViewPromociones.Size = new System.Drawing.Size(725, 404);
            this.dataGridViewPromociones.TabIndex = 0;
            // 
            // ListarPromocionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewPromociones);
            this.Name = "ListarPromocionesForm";
            this.Text = "ListarPromocionesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPromociones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPromociones;
    }
}