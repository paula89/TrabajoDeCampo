using BLLTest;
using BLLTest.Facade;
using DomainTest;
using ServicesTest.Domain.Exceptions;
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

namespace TC_Riveros_Paula
{
    public partial class ListarMateriaPrimaForm : DevExpress.XtraEditors.XtraForm
    {
        IEnumerable<MateriaPrima> materiaPrimas;
        public ListarMateriaPrimaForm(ResourceManager idioma)
        {
            InitializeComponent();
            this.Text = idioma.GetString("ListarMateriaPrimaForm");
            CargarTraducciones(idioma);
            CargarTabla();        
        }

        private void CargarTraducciones(ResourceManager idioma) {
            btnImprimir.Text = idioma.GetString("btnImprimir");
        }
        private void ListarMateriaPrimaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
           /* try {
                MateriaPrima materiaPrima = new MateriaPrima();
                string desde = "";//= this.dateTimePickerVencimientoHasta.Value.ToString();
                String[] filtros = new string[] { desde };
                CargarTabla(filtros);
            }
            catch (Exception ex) {
                FacadeServiceBusiness.ManageException(new UIException(ex));

            }*/
        }

        private void CargarTabla(String[] filtros) {
          /*  
            try
            {
                IEnumerable<MateriaPrima> materiaPrimas = MateriaPrimaManager.Current.ListarMateriaPrimaFilters(filtros);
                dataGridViewMateriaPrima.DataSource = materiaPrimas.ToList();
            }
            catch (Exception ex) {
                FacadeServiceBusiness.ManageException(new UIException(ex));
            }
        */
        }

        private void CargarTabla()
        {
            try
            {
                materiaPrimas = MateriaPrimaManager.Current.ListarMateriaPrima();
                if (materiaPrimas.Any())
                {
                    gridControlMateriaPrima.DataSource = materiaPrimas;
                    gridView1.Columns["IdMateriaPrima"].Visible = false;
                    btnImprimir.Enabled = true;
                }
                else {
                    btnImprimir.Enabled = false;
                    MessageBox.Show("No hay materias primas", "", MessageBoxButtons.OK);

                }
                
            }
            catch (Exception ex)
            {
                FacadeServiceBusiness.ManageException(new UIException(ex));
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarTabla();
            }
            catch (Exception ex)
            {
                FacadeServiceBusiness.ManageException(new UIException(ex));

            }
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
         /*   string input = textBoxNombre.Text;
          
            if (input.Length == 0)
            {
                dataGridViewMateriaPrima.DataSource = materiaPrimas.ToList();
                dataGridViewMateriaPrima.Columns["IdMateriaPrima"].Visible = false;
            }
            else
            {
                dataGridViewMateriaPrima.DataSource = materiaPrimas.Where(x => x.nombre.Contains(input)).ToList();
                dataGridViewMateriaPrima.Columns["IdMateriaPrima"].Visible = false;
            }

            dataGridViewMateriaPrima.Refresh();*/
        }

        private void textBoxProveedor_TextChanged(object sender, EventArgs e)
        {
          /*  string input = textBoxProveedor.Text;

            if (input.Length == 0)
            {
                dataGridViewMateriaPrima.DataSource = materiaPrimas.ToList();
            }
            else
            {
                dataGridViewMateriaPrima.DataSource = materiaPrimas.Where(x => x.proveedor.Contains(input)).ToList();
            }

            dataGridViewMateriaPrima.Refresh();*/
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            gridControlMateriaPrima.ShowPrintPreview();
        }
    }
}
