﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9demo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void signin_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string stat;
            User obj1 = new User(txtUsername.Text, txtPassword.Text);
            stat = obj1.login(txtUsername.Text);
            if (stat != null)
            {
                MessageBox.Show(stat);
            }
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }

        private void username_Click(object sender, EventArgs e)
        {

        }
    }
}