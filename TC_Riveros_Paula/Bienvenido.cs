using ServicesTest.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TC_Riveros_Paula
{
    public partial class BienvenidoForm : Form
    {

        string cultureInfo = Thread.CurrentThread.CurrentUICulture.Name;
        ResourceManager idioma;

        public BienvenidoForm(string user)
        {
            InitializeComponent();
            idioma = FacadeService.Translate(cultureInfo);
            CargarTraducciones(user);

        }

        private void CargarTraducciones(string user)
        {
            lblUser.Text = user;
            lblWelcome.Text = idioma.GetString("lblWelcome");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <1) this.Opacity += 0.05;
            progressBar.Value += 1;
            if (progressBar.Value == 100) {
                timer1.Stop();
                timer2.Start();
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.01;
            if (this.Opacity == 0) { 
                timer2.Stop();
                this.Close();
            }

        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
        }
    }
}
