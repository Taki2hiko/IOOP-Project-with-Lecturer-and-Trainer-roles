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
    public partial class TrainerHome : Form
    {
        public static string name;
        public TrainerHome(string n)
        {
            InitializeComponent();
            name = n;
        }
        public TrainerHome()
        {
            InitializeComponent();
        }

        private void TrainerHome_Load(object sender, EventArgs e)
        {
            lblIdentity.Text = "Hello, " + name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrainerProfile tp = new TrainerProfile(name);
            tp.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TrainerCoachInfo tci = new TrainerCoachInfo();
            tci.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            TrainerViewStudents tvs = new TrainerViewStudents();
            tvs.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TrainerFeedback tf = new TrainerFeedback(name);
            tf.ShowDialog();
        }
    }
}
