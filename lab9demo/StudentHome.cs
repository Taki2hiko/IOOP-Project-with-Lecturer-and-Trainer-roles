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
    public partial class StudentHome : Form
    {
        public StudentHome(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void StudentHome_Load(object sender, EventArgs e)
        {
            lblIdentity.Text = "Hello, " + name;
        }
        public static string name;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            StudentTimetable ad = new StudentTimetable();
            ad.ShowDialog();
        }

        private void Requests_Click(object sender, EventArgs e)
        {
            StudentRequests ad = new StudentRequests();
            ad.ShowDialog();
        }

        private void Viewinvoice_Click(object sender, EventArgs e)
        {
            StudentInvoice ad = new StudentInvoice();
            ad.ShowDialog();
        }
    }
}
