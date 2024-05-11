﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachSan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                labelError.Visible = false;
                Dashboard ds = new Dashboard();
                this.Hide();
                ds.Show();

            }
            else
            {
                labelError.Visible = true;
                txtPassword.Clear();
            }
        }

        private void labelError_Click(object sender, EventArgs e)
        {

        }
    }
}
