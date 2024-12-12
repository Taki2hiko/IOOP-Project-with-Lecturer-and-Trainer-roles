using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab9demo
{
    public partial class LecturerProfile : Form
    {
        private static string name;

        public LecturerProfile(string n)
        {
            InitializeComponent();
            name = n;
        }
        public LecturerProfile()
        {
            InitializeComponent();
        }

        private void LecturerProfile_Load(object sender, EventArgs e)
        {
            Lecturer obj1 = new Lecturer(name);

            //calling static method require className.method(..)
            //pass object obj1 to method viewProfile
            lab9demo.Lecturer.viewProfile(obj1);
            lblValueCurrentEmail.Text = obj1.Email;
            lblValueCurrentPhone.Text = obj1.PhoneNum;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();

            Lecturer obj1 = new Lecturer(name);

            string updateStatus = obj1.updateProfile(email, phone);
            MessageBox.Show(updateStatus);

            // Update the properties with the new values
            obj1.Email = email;
            obj1.PhoneNum = phone;

            // Update the labels with the new values
            lblValueCurrentEmail.Text = obj1.Email;
            lblValueCurrentPhone.Text = obj1.PhoneNum;
        }

        private void Lecturer_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUpdatedPhoneNumber_Click(object sender, EventArgs e)
        {

        }
    }
}