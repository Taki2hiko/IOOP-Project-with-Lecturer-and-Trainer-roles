using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab9demo
{
    public partial class LecturerHome : Form
    {
        private static string name;

        public LecturerHome(string n)
        {
            InitializeComponent();
            name = n;
        }
        public LecturerHome()
        {
            InitializeComponent();
        }
        private void lecturerhomepage_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LecturerModifyStudents ad = new LecturerModifyStudents();
            ad.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }

        private void LecturerHome_Load(object sender, EventArgs e)
        {
            lblIdentity.Text = "Welcome, " + name;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            LecturerModifyStudents ad = new LecturerModifyStudents();
            ad.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LecturerProfile ad = new LecturerProfile(name);
            ad.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LecturerRequests ad = new LecturerRequests();
            ad.ShowDialog();
        }
    }
}
