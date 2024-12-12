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
    public partial class TrainerCoachInfo : Form
    {
        private string display;
        public TrainerCoachInfo()
        {
            InitializeComponent();
        }

        private void Button_Add_CoachInfo_Click(object sender, EventArgs e)
        {
            Coach_Info ad = new Coach_Info();
            MessageBox.Show(ad.AddCoachInfo(Textbox_ModuleName.Text, Textbox_Charge.Text, Textbox_ClassSchedule.Text));

        }

        private void TrainerCoachInfo_Load(object sender, EventArgs e)
        {

        }

        private void Button_Show_Grid_Table_Click(object sender, EventArgs e)
        {
            Coach_Info table = new Coach_Info(display);
            DataTable dt = table.DataGridRetrive();
            DataGridView_CoachInfo.DataSource = dt;
        }

        private void Button_Update_CoachInfo_Click(object sender, EventArgs e)
        {
            Coach_Info ud = new Coach_Info(display);
            ud.UpdateCoachInfo(Textbox_ModuleName.Text, Textbox_Charge.Text, Textbox_ClassSchedule.Text);
            MessageBox.Show("Updated!");
        }

        private void Button_Delete_CoachInfo_Click(object sender, EventArgs e)
        {
            Coach_Info dl = new Coach_Info(display);
            dl.DeleteCoachInfo(Textbox_ModuleName.Text, Textbox_Charge.Text, Textbox_ClassSchedule.Text);
            MessageBox.Show("Deleted!");
        }
    }
}
