﻿using BLLTest.Facade;
using BLLTest.Managers;
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
    public partial class ActualizarPromocion : DevExpress.XtraEditors.XtraForm
    {
        ResourceManager language;
        public ActualizarPromocion(ResourceManager idioma)
        {
            InitializeComponent();
            language = idioma;
            CargarTraducciones();
            CargarPromociones();
            btnActualizar.Enabled = false;
            cargarAyuda();
        }
        /// <summary>
        /// load the help when the user press the F1 key
        /// </summary>
        public void cargarAyuda()
        {
            helpProviderActPromocion.HelpNamespace = Application.StartupPath + "/CookerSoft.chm";
            helpProviderActPromocion.SetHelpString(this, "Crear Promocion");
            helpProviderActPromocion.SetHelpKeyword(this, "Crear Promocion");
            helpProviderActPromocion.SetHelpNavigator(this, HelpNavigator.KeywordIndex);
        }
        /// <summary>
        /// load translations
        /// </summary>
        private void CargarTraducciones()
        {
            try
            {
                labelNombre.Text = language.GetString("labelNombre");
                labelComentario.Text = language.GetString("labelComentario");
                labelDescuento.Text = language.GetString("labelDescuento");
                labelVigencia.Text = language.GetString("labelVencimiento");

                checkBoxHabilitado.Text = language.GetString("checkBoxHabilitado");
                btnBuscar.Text = language.GetString("btnBuscar");
                btnActualizar.Text = language.GetString("btnActualizar");
                btnCancelar.Text = language.GetString("btnCancelar");

            }
            catch (UIException ex)
            {
                FacadeServiceBusiness.ManageException(ex);
                System.Console.WriteLine("Error al cargar las traducciones : " + ex.Message);
            }
        }

        private void ActualizarPromocion_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// load the promoctions combobox
        /// </summary>
        public void CargarPromociones() { 
        
        }
        /// <summary>
        /// search the information to complete the fields in the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// create the Promocion object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Promocion promocion = new Promocion();
            Actualizar(promocion);
        }
        /// <summary>
        /// update the Promocion
        /// </summary>
        /// <param name="promocion"></param>
        public void Actualizar(Promocion promocion) {
            try
            {
                int guardado = 1;// PromocionManager.Current.ActualizarPromocion(promocion);
                
                if (guardado == 1)
                {
                    MessageBox.Show(language.GetString("MsgOkMPRegister"), "Ok", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(language.GetString("MsgErrorMPRegister"), language.GetString("Error"), MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                FacadeServiceBusiness.ManageException(new UIException(ex));
                MessageBox.Show("Ha ocurrido un error, contacte al administrador del sistema","Error",MessageBoxButtons.OK);
            }
        }
        /// <summary>
        /// close the screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
