using BLLTest.Facade;
using DomainTest;
using ServicesTest.Domain.Composite;
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
    public partial class NuevoMateriaPrimaForm : Form
    {
        string usuario;
        public NuevoMateriaPrimaForm(ResourceManager idioma, string user)
        {
            InitializeComponent();
            this.Text = idioma.GetString("NuevoMateriaPrimaForm");
            usuario = user;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MateriaPrima materiaPrima = new MateriaPrima();
            try
            {
                materiaPrima.IdMateriaPrima = Guid.NewGuid();
                materiaPrima.nombre = this.textBoxNombre.Text;
                materiaPrima.proveedor = this.textBoxProveedor.Text;
                materiaPrima.cantidad = Convert.ToInt32(this.textBoxCantidad.Text);
                materiaPrima.marca = textBoxMarca.Text;
                materiaPrima.usuario = usuario;
                materiaPrima.comentario = textBoxComentario.Text;
                materiaPrima.fechaAlta = Convert.ToDateTime(DateTime.Now);
                materiaPrima.vencimiento = Convert.ToDateTime(dateTimePickerVencimiento.Value);
                GuardarMateriaPrima(materiaPrima);
            }
            catch (Exception ex) {
                FacadeServiceBusiness.ManageException(new UIException(ex));
            }
        }

        private void GuardarMateriaPrima(MateriaPrima materiaPrima) {
            try
            {
                int guardado = FacadeServiceBusiness.RegistrarMateriaPrima(materiaPrima);
                if (guardado == 1)
                {
                    MessageBox.Show("Materia Prima registrada exitosamente", "Ok", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Error al registrar la materia prima", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex) {
                FacadeServiceBusiness.ManageException(new UIException(ex));

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
