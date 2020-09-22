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
    public partial class ListarMateriaPrimaForm : Form
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
            lblNombre.Text = idioma.GetString("labelNombre");
            lblProveedor.Text = idioma.GetString("labelProveedor");
        }
        private void ListarMateriaPrimaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try {
                MateriaPrima materiaPrima = new MateriaPrima();
                string desde = "";//= this.dateTimePickerVencimientoHasta.Value.ToString();
                string nombre = textBoxNombre.Text.Trim();
                string proveedor = textBoxProveedor.Text.Trim();
                String[] filtros = new string[] { desde, nombre, proveedor };
                CargarTabla(filtros);
            }
            catch (Exception ex) {
                FacadeServiceBusiness.ManageException(new UIException(ex));

            }
        }

        private void CargarTabla(String[] filtros) {
            
            try
            {
                IEnumerable<MateriaPrima> materiaPrimas = MateriaPrimaManager.Current.ListarMateriaPrimaFilters(filtros);
                dataGridViewMateriaPrima.DataSource = materiaPrimas.ToList();
            }
            catch (Exception ex) {
                FacadeServiceBusiness.ManageException(new UIException(ex));
            }
        
        }

        private void CargarTabla()
        {
            try
            {
                materiaPrimas = MateriaPrimaManager.Current.ListarMateriaPrima();

                dataGridViewMateriaPrima.DataSource = materiaPrimas;
                dataGridViewMateriaPrima.Columns["IdMateriaPrima"].Visible = false;
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
            string input = textBoxNombre.Text;
          
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

            dataGridViewMateriaPrima.Refresh();
        }

        private void textBoxProveedor_TextChanged(object sender, EventArgs e)
        {
            string input = textBoxProveedor.Text;

            if (input.Length == 0)
            {
                dataGridViewMateriaPrima.DataSource = materiaPrimas.ToList();
            }
            else
            {
                dataGridViewMateriaPrima.DataSource = materiaPrimas.Where(x => x.proveedor.Contains(input)).ToList();
            }

            dataGridViewMateriaPrima.Refresh();
        }
    }
}
