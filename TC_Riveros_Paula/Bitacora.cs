﻿using DomainTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServicesTest;

namespace TC_Riveros_Paula
{
    public partial class FormBitacora : Form
    {
        public FormBitacora(ResourceManager idioma)
        {
            InitializeComponent();
            this.Text = idioma.GetString("FormBitacora");
            CargarTabla();
        }

        public void CargarTabla() {
            IEnumerable<Bitacora> bitacora = ServicesTest.BLL.BitacoraManager.Current.ObtenerBitacoras();
            BitacoraDataGridView.DataSource = bitacora.ToList();

        }
        private void BitacoraDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormBitacora_Load(object sender, EventArgs e)
        {

        }
    }
}
