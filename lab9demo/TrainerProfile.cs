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
    public partial class TrainerProfile : Form
    {
        public static string name;

        public TrainerProfile()
        {
            InitializeComponent();
        }

        public TrainerProfile(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TrainerProfile_Load(object sender, EventArgs e)
        {
            Coach_Info obj1 = new Coach_Info(name);

            //calling static method require className.method(..)
            //pass object obj1 to method viewProfile
            Coach_Info.ProfileViewing(obj1);

            Label_Name.Text = obj1.Trainer_name;
            Label_Email.Text = obj1.Trainer_email;
            Label_PhoneNum.Text = obj1.Phone_num;
        }

        private void ButtonProfile_Update_Click(object sender, EventArgs e)
        {
            Coach_Info obj1 = new Coach_Info(name);
            if (!(string.IsNullOrWhiteSpace(TextboxProfile_Email.Text)) && !(string.IsNullOrWhiteSpace(TextboxProfile_PhoneNum.Text)) && !(string.IsNullOrWhiteSpace(TextboxProfile_Password.Text)))
            {
                MessageBox.Show(obj1.TrainerProfUpdate(TextboxProfile_Email.Text, TextboxProfile_PhoneNum.Text, TextboxProfile_Password.Text));
            }
            else
            {
                MessageBox.Show("Data is empty. Please insert complete data");
            }
        }
    }
}
