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
        public ListarMateriaPrimaForm(ResourceManager idioma)
        {
            InitializeComponent();
            this.Text = idioma.GetString("ListarMateriaPrimaForm");
            CargarTraducciones(idioma);
        }

        private void CargarTraducciones(ResourceManager idioma) { 
        
        }
        private void ListarMateriaPrimaForm_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try {
                CargarTabla();
            }
            catch (Exception ex) {
                FacadeServiceBusiness.ManageException(new UIException(ex));

            }
        }

        private void CargarTabla() {
            MateriaPrima materiaPrima = new MateriaPrima();
            string desde = this.dateTimePickerVencimientoHasta.Value.ToString();
            string nombre = textBoxNombre.Text;
            string proveedor = textBoxProveedor.Text;
            String[] filtros = new string[] { desde, nombre, proveedor };
            try
            {
                IEnumerable<MateriaPrima> materiaPrimas = MateriaPrimaManager.Current.ListarMateriaPrima(filtros);
                dataGridViewMateriaPrima.DataSource = materiaPrimas.ToList();
            }
            catch (Exception ex) {
                FacadeServiceBusiness.ManageException(new UIException(ex));
            }
        
        }
    }
}
