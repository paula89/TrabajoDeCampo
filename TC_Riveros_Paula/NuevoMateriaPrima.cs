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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TC_Riveros_Paula
{
    public partial class NuevoMateriaPrimaForm : Form
    {
        string usuario;
        ResourceManager language;
        public NuevoMateriaPrimaForm(ResourceManager idioma, string user)
        {
            InitializeComponent();
            language = idioma;
            this.Text = language.GetString("NuevoMateriaPrimaForm");
            usuario = user;
            CargarTraducciones();

        }
        private void CargarTraducciones()
        {
            try
            {
                labelNombre.Text = language.GetString("labelNombre");
                labelMarca.Text = language.GetString("labelMarca");
                labelProveedor.Text = language.GetString("labelProveedor");
                labelComentario.Text = language.GetString("labelComentario");
                labelCantidad.Text = language.GetString("labelCantidad");
                labelVencimiento.Text = language.GetString("labelVencimiento");
                
                btnAceptar.Text = language.GetString("btnAceptar");
                btnCancelar.Text = language.GetString("btnCancelar");

            }
            catch (UIException ex)
            {
                FacadeServiceBusiness.ManageException(ex);
                System.Console.WriteLine("Error al cargar las traducciones : " + ex.Message);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MateriaPrima materiaPrima = new MateriaPrima();
            try
            {
                bool valido = ValidarCampos();
                if (valido)
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
            }
            catch (Exception ex) {
                FacadeServiceBusiness.ManageException(new UIException(ex));
            }
        }

        private bool ValidarCampos() {
            if (textBoxNombre.Text.Length == 0 || textBoxProveedor.Text.Length == 0 || textBoxMarca.Text.Length == 0 ||
                   textBoxCantidad.Text.Length == 0)
            {
                MessageBox.Show(language.GetString("MsgErrorCamposObligatorios"), language.GetString("Error"), MessageBoxButtons.OK);
                return false;
            }
            else
            {
                
                if (!Regex.IsMatch(textBoxNombre.Text, @"^[A-Za-z0-9\s]+$"))
                {
                    MessageBox.Show(language.GetString("MsgErrorNombre"), language.GetString("Error"), MessageBoxButtons.OK);
                    return false;
                }
                if (!Regex.IsMatch(textBoxProveedor.Text, @"^[A-Za-z0-9\s]+$"))
                {
                    MessageBox.Show(language.GetString("MsgErrorProveedor"), language.GetString("Error"), MessageBoxButtons.OK);
                    return false;
                }
                if (!Regex.IsMatch(textBoxMarca.Text, @"^[A-Za-z0-9\s]+$"))
                {
                    MessageBox.Show(language.GetString("MsgErrorMarca"), language.GetString("Error"), MessageBoxButtons.OK);
                    return false;
                }
                if (!Regex.IsMatch(textBoxCantidad.Text, @"^[0-9]+$"))
                {
                    MessageBox.Show(language.GetString("MsgErrorCantidad"), language.GetString("Error"), MessageBoxButtons.OK);
                    return false;
                }
                
            }

            return true;
        }

        private void GuardarMateriaPrima(MateriaPrima materiaPrima) {
            try
            {
                int guardado = FacadeServiceBusiness.RegistrarMateriaPrima(materiaPrima);
                if (guardado == 1)
                {
                    MessageBox.Show(language.GetString("MsgOkMPRegister"), "Ok", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(language.GetString("MsgErrorMPRegister"), language.GetString("Error"), MessageBoxButtons.OK);
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
