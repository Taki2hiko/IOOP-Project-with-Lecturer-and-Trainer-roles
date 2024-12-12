using lab9demo;
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
    public partial class StudentProfile : Form
    {
        public static string name;
        public StudentProfile(string n)
        {
            InitializeComponent();
            name = n;
        }
        private void StudentProfile_Load(object sender, EventArgs e)
        {
            Student obj1 = new Student(name);

            //calling static method require className.method(..)
            //pass object obj1 to method viewProfile
            Student.viewProfile(obj1);

            txtEmail.Text = obj1.Email;
            txtPhone.Text = obj1.PhoneNum;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Student obj1 = new Student(name);
            MessageBox.Show(obj1.updateProfile(txtEmail.Text, txtPhone.Text));
        }
    }
}
