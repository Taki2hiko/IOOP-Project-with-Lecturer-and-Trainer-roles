    using System;
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
        public partial class AdminHome : Form
        {
            public static string name;
            public AdminHome(string n)  
            {
                InitializeComponent();
                name = n;
            }

            public AdminHome()
            {
            }

            private void btnAdd_Click(object sender, EventArgs e)
            {
                AdminTrainers ad = new AdminTrainers();
                ad.ShowDialog();
            }

            private void AdminHome_Load(object sender, EventArgs e)
            {
                lblIdentity.Text = "Hello, " + name;
            }

            private void btnView_Click(object sender, EventArgs e)
            {
                AdminIncomeReport ad = new AdminIncomeReport();
                ad.ShowDialog();
            }

            private void lblIdentity_Click(object sender, EventArgs e)
            {

            }

            private void adminhomepage_Click(object sender, EventArgs e)
            {

            }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminProfile ad = new AdminProfile();
            ad.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminViewFeedback ad = new AdminViewFeedback();
            ad.ShowDialog();
        }
    }
    }
