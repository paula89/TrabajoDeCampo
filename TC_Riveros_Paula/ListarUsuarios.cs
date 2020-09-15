using ServicesTest.BLL;
using ServicesTest.Domain.Composite;
using ServicesTest.Domain.Exceptions;
using ServicesTest.Facade;
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
    public partial class ListarUsuariosForm : Form
    {
        public ListarUsuariosForm(ResourceManager idioma)
        {
            InitializeComponent();
            CargarTraducciones(idioma);
            this.Text = idioma.GetString("ListarUsuariosForm");
        }

        private void CargarTraducciones(ResourceManager idioma) {
            this.lblHasta.Text = idioma.GetString("lblHasta");
            this.lblDesde.Text = idioma.GetString("lblDesde");
            this.labelNombre.Text = idioma.GetString("labelNombre");
            this.btnFiltrar.Text = idioma.GetString("btnFiltrar");
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string desde = this.dateTimePickerDesde.Value.ToString();
            string hasta = this.dateTimePickerHasta.Value.ToString();
            string nombre = this.textBoxNombre.Text;
            String[] filtros = new string[] { desde, hasta, nombre };
            CargarTabla(filtros);
        }

        private void CargarTabla(String[] filtros) {
            
            try
            {
                IEnumerable<Usuario> usuarios = UsersManager.Current.ListarUsuarios(filtros);
                dataGridViewUsuarios.DataSource = usuarios.ToList();
            }
            catch (UIException ex) {
                FacadeService.ManageException(ex);

            }
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String[] filtros = new string[0];
            CargarTabla(filtros);
        }
    }
}
