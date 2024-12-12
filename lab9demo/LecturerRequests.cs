using System;
using System.Collections;
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
    public partial class LecturerRequests : Form
    {
        private string username;
        private string selectStudent;
        private string selectModule;

        public LecturerRequests()
        {
            InitializeComponent();
        }

        public LecturerRequests(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void LecturerRequests_Load(object sender, EventArgs e)
        {
            ArrayList studentNames = Lecturer.viewStudentNameFromRequests(); // Use the method to retrieve student names from requests datatable
            foreach (var item in studentNames)
            {
                cmbStudents.Items.Add(item);
            }
            RefreshStudentComboBox();
        }
        private void RefreshStudentComboBox()
        {
            cmbStudents.Items.Clear();

            ArrayList studentNames = Lecturer.viewStudentNameFromRequests(); // Use the method to retrieve student names from requests datatable
            foreach (var item in studentNames)
            {
                cmbStudents.Items.Add(item);
            }
        }
        private void RefreshModuleComboBox()
        {
            cmbModules.Items.Clear();

            if (!string.IsNullOrEmpty(selectStudent))
            {
                ArrayList moduleNames = Lecturer.viewModuleName(selectStudent);

                foreach (var item in moduleNames)
                {
                    if (Lecturer.IsModuleRequested(selectStudent, item.ToString()))
                    {
                        cmbModules.Items.Add(item);
                    }
                }
            }
        }
        private void cmbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectStudent = cmbStudents.SelectedItem.ToString();

            RefreshModuleComboBox();
        }


        private void cmbModules_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectModule = cmbModules.SelectedItem.ToString();
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectStudent) && !string.IsNullOrEmpty(selectModule))
            {
                DialogResult result = MessageBox.Show("Are you sure you want to decline the request?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Lecturer lecturer = new Lecturer(username);
                    lecturer.DeclineRequest(selectStudent, selectModule);
                    MessageBox.Show("Request declined successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    RefreshStudentComboBox();
                    RefreshModuleComboBox();
                }
            }
            else
            {
                MessageBox.Show("Please select a student and a module.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectStudent) && !string.IsNullOrEmpty(selectModule))
            {
                Lecturer lecturer = new Lecturer(username);
                lecturer.ApproveModule(selectStudent, selectModule);
                MessageBox.Show("Module approved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                RefreshStudentComboBox();
                RefreshModuleComboBox();
            }
            else
            {
                MessageBox.Show("Please select a student and a module.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}