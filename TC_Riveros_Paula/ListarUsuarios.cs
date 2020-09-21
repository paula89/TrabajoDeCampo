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
        IEnumerable<Usuario> usuarios;
        public ListarUsuariosForm(ResourceManager idioma)
        {
            InitializeComponent();
            CargarTraducciones(idioma);
            this.Text = idioma.GetString("ListarUsuariosForm");
            CargarTabla();
        }

        private void CargarTraducciones(ResourceManager idioma) {
          //  this.lblHasta.Text = idioma.GetString("lblHasta");
            this.lblUsuario.Text = idioma.GetString("lblUsuario");
            this.labelNombre.Text = idioma.GetString("labelNombre");
         //   this.btnFiltrar.Text = idioma.GetString("btnFiltrar");
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string desde = "";// this.dateTimePickerDesde.Value.ToString();
            string hasta = "";// this.dateTimePickerHasta.Value.ToString();
            string nombre = this.textBoxNombre.Text;
            String[] filtros = new string[] { desde, hasta, nombre };
            CargarTabla(filtros);
        }

        private void CargarTabla(String[] filtros) {
            
            try
            {
                usuarios = UsersManager.Current.ListarUsuariosFilter(filtros);
                dataGridViewUsuarios.DataSource = usuarios.ToList();
                dataGridViewUsuarios.Columns.Remove("Password");
                dataGridViewUsuarios.Columns.Remove("DVH");
            }
            catch (UIException ex) {
                FacadeService.ManageException(ex);

            }
        }

        private void CargarTabla()
        {

            try
            {
                usuarios = UsersManager.Current.ListarUsuarios();
                dataGridViewUsuarios.DataSource = usuarios.ToList();
                dataGridViewUsuarios.Columns.Remove("Password");
                dataGridViewUsuarios.Columns.Remove("DVH");
                dataGridViewUsuarios.Refresh();
            }
            catch (UIException ex)
            {
                FacadeService.ManageException(ex);

            }
        }

        private void dataGridViewUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarTabla();
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            string input = textBoxNombre.Text;

            if (input.Length == 0)
            {
                dataGridViewUsuarios.DataSource = usuarios.ToList();
                dataGridViewUsuarios.Columns.Remove("Password");
                dataGridViewUsuarios.Columns.Remove("DVH");
            }
            else
            {
                dataGridViewUsuarios.DataSource = usuarios.Where(x => x.Nombre.Contains(input)).ToList();
                dataGridViewUsuarios.Columns.Remove("Password");
                dataGridViewUsuarios.Columns.Remove("DVH");
            }

            dataGridViewUsuarios.Refresh();
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            string input = textBoxUsuario.Text.ToUpper();

            if (input.Length == 0)
            {
                dataGridViewUsuarios.DataSource = usuarios.ToList();
                dataGridViewUsuarios.Columns.Remove("Password");
                dataGridViewUsuarios.Columns.Remove("DVH");
            }
            else
            {
                dataGridViewUsuarios.DataSource = usuarios.Where(x => x.Cod_Usuario.Contains(input)).ToList();
                dataGridViewUsuarios.Columns.Remove("Password");
                dataGridViewUsuarios.Columns.Remove("DVH");
            }

            dataGridViewUsuarios.Refresh();
        }

        private void ListarUsuariosForm_Load(object sender, EventArgs e)
        {

        }
    }
}
