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
    public partial class TrainerFeedback : Form
    {
        public static string name;
        public TrainerFeedback()
        {
            InitializeComponent();
        }

        public TrainerFeedback(string n)
        {
            InitializeComponent();
            name = n;
        }

        private void Button_Send_Feedback_Click(object sender, EventArgs e)
        {
            Coach_Info obj1 = new Coach_Info(name);
            if (!(string.IsNullOrWhiteSpace(Textbox_Feedback.Text)))
            {
                MessageBox.Show(obj1.SendFeedback(name, Textbox_Feedback.Text));
            }
            else
            {
                MessageBox.Show("Feedback is empty.");
            }
        }

        private void TrainerFeedback_Load(object sender, EventArgs e)
        {
            Coach_Info obj1 = new Coach_Info(name);
        }
    }
}
