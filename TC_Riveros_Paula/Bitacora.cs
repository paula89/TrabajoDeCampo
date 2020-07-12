using ServicesTest.Domain;
using ServicesTest.BLL;
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
using ServicesTest.Domain.Exceptions;
using ServicesTest.Facade;

namespace TC_Riveros_Paula
{
    public partial class FormBitacora : Form
    {
        public FormBitacora(ResourceManager idioma)
        {
            InitializeComponent();
            this.Text = idioma.GetString("FormBitacora");
            this.CargarTraducciones(idioma);
        }

        public void CargarTraducciones(ResourceManager idioma) 
        {
            this.btnFiltrar.Text = idioma.GetString("btnFiltrar");
            this.lblCriticidad.Text = idioma.GetString("lblCriticidad");
            this.lblHasta.Text = idioma.GetString("lblHasta");
            this.lblDesde.Text = idioma.GetString("lblDesde");

            this.comboBoxCriticidad.Items.Add(Bitacora.CriticidadEnum.Menor);
            this.comboBoxCriticidad.Items.Add(Bitacora.CriticidadEnum.Medio);
            this.comboBoxCriticidad.Items.Add(Bitacora.CriticidadEnum.Mayor);
        }
        public void CargarTabla() {
            try
            {
                string criticidad = (this.comboBoxCriticidad.Text != "") ?
                   this.comboBoxCriticidad.Text: null ;
                string desde = this.dateTimePickerDesde.Value.ToString();
                string hasta = this.dateTimePickerHasta.Value.ToString();
                String[] filtros = new string[] { criticidad, desde, hasta };
            

                IEnumerable<Bitacora> bitacora = BitacoraManager.Current.ObtenerBitacoras(filtros);
                BitacoraDataGridView.DataSource = bitacora.ToList();
            }
            catch (UIException ex) {
                FacadeService.ManageException(ex);
            }

        }
        private void BitacoraDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormBitacora_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }
    }
}
