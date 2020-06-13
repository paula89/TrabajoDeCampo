namespace TC_Riveros_Paula
{
    partial class ListarMateriaPrima
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateriaPrima)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMateriaPrima
            // 
            this.dataGridViewMateriaPrima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMateriaPrima.Location = new System.Drawing.Point(28, 24);
            this.dataGridViewMateriaPrima.Name = "dataGridViewMateriaPrima";
            this.dataGridViewMateriaPrima.Size = new System.Drawing.Size(739, 402);
            this.dataGridViewMateriaPrima.TabIndex = 0;
            // 
            // ListarMateriaPrima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewMateriaPrima);
            this.Name = "ListarMateriaPrima";
            this.Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMateriaPrima)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMateriaPrima;
    }
}