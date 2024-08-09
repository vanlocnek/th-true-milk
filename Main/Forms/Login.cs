﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main.Forms
{
    public partial class Login : Form
    {
        public PanelDefault panel;
        public Login(PanelDefault panel)
        {
            InitializeComponent();
            this.panel = panel;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.panel.setFormName("AddAccount");
        }
    }
}
