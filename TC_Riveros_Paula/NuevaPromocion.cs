﻿using System;
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
    public partial class NuevaPromocionForm : Form
    {
        public NuevaPromocionForm(ResourceManager idioma)
        {
            InitializeComponent();
            this.Text = idioma.GetString("NuevaPromocionForm");
        }
    }
}
