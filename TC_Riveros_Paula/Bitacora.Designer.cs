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
            this.BitacoraDataGridView.Location = new System.Drawing.Point(43, 51);
            this.BitacoraDataGridView.Name = "BitacoraDataGridView";
            this.BitacoraDataGridView.ReadOnly = true;
            this.BitacoraDataGridView.Size = new System.Drawing.Size(704, 345);
            this.BitacoraDataGridView.TabIndex = 0;
            this.BitacoraDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BitacoraDataGridView_CellContentClick);
            // 
            // FormBitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BitacoraDataGridView);
            this.Name = "FormBitacora";
            this.Text = "BitacoraForm";
            this.Load += new System.EventHandler(this.FormBitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BitacoraDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView BitacoraDataGridView;
    }
}