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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace lab9demo
{
    public partial class LecturerModifyStudents : Form
    {
        private string username;
        public LecturerModifyStudents()
        {
            InitializeComponent();
            btnRefreshtable.Click += btnRefreshtable_Click;
        }

        public LecturerModifyStudents(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void email_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (IsStudentRecordExist(txtTpnumber.Text))
            {
                MessageBox.Show("Student record exists. Kindly check the TPnumber you stated.");
                return;
            }

            // Validate input fields
            if (!ValidateInputFields())
            {
                MessageBox.Show("Not enough information. Please fill in all required fields.");
                return;
            }

            Student ad = new Student(txtName.Text, txtEmail.Text, txtPhone.Text, txtTpnumber.Text, txtAddress.Text, cmbLevel.Text, txtMonth.Text, cmbModules.Text);
            MessageBox.Show(ad.addStudent());

            RefreshDataGridView();
            ResetComboBoxes();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            Lecturer lecturer = new Lecturer(username);
            DataTable dtModules = lecturer.GetModuleNames();
            foreach (DataRow row in dtModules.Rows)
            {
                cmbModules.Items.Add(row["module_name"].ToString());
            }
            DataTable dtLevels = lecturer.GetLevelNames();
            foreach (DataRow row in dtLevels.Rows)
            {
                cmbLevel.Items.Add(row["level_name"].ToString());
            }

            DataTable dt = lecturer.GetAllStudents();
            RefreshDataGridView();
            ResetComboBoxes();
        }

        private void addstudentlabel_Click(object sender, EventArgs e)
        {

        }

        private void tpnumber_Click(object sender, EventArgs e)
        {

        }

        private void phonenumber_Click(object sender, EventArgs e)
        {

        }

        private void txtModules_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonth_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTpnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLevel_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsStudentRecordExist(txtTpnumber.Text))
            {
                MessageBox.Show("Record doesn't exist");
                return;
            }

            // Validate input fields
            if (!ValidateInputFields())
            {
                MessageBox.Show("Not enough information. Please fill in all required fields.");
                return;
            }

            Lecturer lecturer = new Lecturer(username);
            lecturer.UpdateStudent(txtName.Text, txtEmail.Text, txtPhone.Text, txtTpnumber.Text, txtAddress.Text, cmbLevel.Text, txtMonth.Text, cmbModules.Text);
            MessageBox.Show("Successfully Updated");

            RefreshDataGridView();
            ResetComboBoxes();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!IsStudentRecordExist(txtTpnumber.Text))
            {
                MessageBox.Show("Record doesn't exist");
                return;
            }

            Lecturer lecturer = new Lecturer(username);
            lecturer.DeleteStudent(txtTpnumber.Text);
            MessageBox.Show("Successfully Deleted");

            RefreshDataGridView();
            ResetComboBoxes();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string studentName = txtName.Text;
            string email = txtEmail.Text;
            string phoneNumber = txtPhone.Text;
            string tpnumber = txtTpnumber.Text;
            string address = txtAddress.Text;
            string level = cmbLevel.Text;
            string month = txtMonth.Text;
            string modules = cmbModules.Text;

            Lecturer lecturer = new Lecturer(username);
            DataTable dt = lecturer.SearchStudent(studentName, email, phoneNumber, tpnumber, address, level, month, modules);

            dgStudentlist.DataSource = dt;
            ResetComboBoxes();
        }

        private void btnShowtable_Click(object sender, EventArgs e)
        {
            Lecturer lecturer = new Lecturer(username);
            DataTable dt = lecturer.GetAllStudents();
            dgStudentlist.DataSource = dt;
        }
        private void RefreshDataGridView()
        {
            Lecturer lecturer = new Lecturer(username);
            DataTable dt = lecturer.GetAllStudents();
            dgStudentlist.DataSource = dt;

        }

        private void cmbModules_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool ValidateInputFields()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtTpnumber.Text) ||
                string.IsNullOrWhiteSpace(txtMonth.Text) || string.IsNullOrWhiteSpace(cmbModules.Text) ||
                string.IsNullOrWhiteSpace(cmbLevel.Text))
            {
                return false;
            }

            // Validate if name and month contain only letters
            if (!IsLettersOnly(txtName.Text))
            {
                MessageBox.Show("Name should consist of only letters.");
                return false;
            }

            if (!IsLettersOnly(txtMonth.Text))
            {
                MessageBox.Show("Month should consist of only letters.");
                return false;
            }

            return true;
        }
        private bool ValidateSearchInput()
        {
            // Check if at least one search criteria is specified
            return !string.IsNullOrWhiteSpace(txtName.Text) ||
                !string.IsNullOrWhiteSpace(txtTpnumber.Text) ||
                !string.IsNullOrWhiteSpace(txtEmail.Text) ||
                !string.IsNullOrWhiteSpace(txtPhone.Text) ||
                !string.IsNullOrWhiteSpace(txtAddress.Text) ||
                !string.IsNullOrWhiteSpace(cmbLevel.Text) ||
                !string.IsNullOrWhiteSpace(txtMonth.Text) ||
                !string.IsNullOrWhiteSpace(cmbModules.Text);
        }

        private bool IsLettersOnly(string input)
        {
            return input.All(c => char.IsLetter(c) || c == ' ');
        }
        private bool IsStudentRecordExist(string tpnumber)
        {
            Lecturer lecturer = new Lecturer(username);
            return lecturer.IsStudentRecordExist(tpnumber);
        }

        private void btnRefreshtable_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();
            ResetComboBoxes();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ResetComboBoxes()
        {
            cmbLevel.SelectedIndex = -1;
            cmbModules.SelectedIndex = -1;
        }
    }
}
