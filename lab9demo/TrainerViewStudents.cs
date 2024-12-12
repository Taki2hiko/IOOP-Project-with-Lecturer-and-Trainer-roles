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
    public partial class TrainerViewStudents : Form
    {
        public string display;
        public TrainerViewStudents()
        {
            InitializeComponent();
        }

        private void Button_Show_Students_Click(object sender, EventArgs e)
        {
            Coach_Info table2 = new Coach_Info(display);
            DataTable charges = table2.DataGridRetrive2();
            DataGridView_Students.DataSource = charges;
        }

        private void TrainerViewStudents_Load(object sender, EventArgs e)
        {

        }
    }
}
