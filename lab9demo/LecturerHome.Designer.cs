namespace lab9demo
{
    partial class LecturerHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerHome));
            this.lblIdentity = new System.Windows.Forms.Label();
            this.lblLectureHomePage = new System.Windows.Forms.Label();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnModules = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdentity
            // 
            this.lblIdentity.AutoSize = true;
            this.lblIdentity.BackColor = System.Drawing.Color.Transparent;
            this.lblIdentity.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIdentity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIdentity.Location = new System.Drawing.Point(361, 177);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(0, 42);
            this.lblIdentity.TabIndex = 6;
            // 
            // lblLectureHomePage
            // 
            this.lblLectureHomePage.AutoSize = true;
            this.lblLectureHomePage.BackColor = System.Drawing.Color.Transparent;
            this.lblLectureHomePage.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLectureHomePage.ForeColor = System.Drawing.Color.Black;
            this.lblLectureHomePage.Location = new System.Drawing.Point(213, 96);
            this.lblLectureHomePage.Name = "lblLectureHomePage";
            this.lblLectureHomePage.Size = new System.Drawing.Size(571, 57);
            this.lblLectureHomePage.TabIndex = 5;
            this.lblLectureHomePage.Text = "LECTURE HOMEPAGE";
            this.lblLectureHomePage.Click += new System.EventHandler(this.lecturerhomepage_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.Gainsboro;
            this.btnStudents.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStudents.Location = new System.Drawing.Point(377, 311);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(234, 45);
            this.btnStudents.TabIndex = 9;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // btnModules
            // 
            this.btnModules.BackColor = System.Drawing.Color.Gainsboro;
            this.btnModules.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnModules.Location = new System.Drawing.Point(377, 375);
            this.btnModules.Name = "btnModules";
            this.btnModules.Size = new System.Drawing.Size(234, 46);
            this.btnModules.TabIndex = 10;
            this.btnModules.Text = "Modules requests";
            this.btnModules.UseVisualStyleBackColor = false;
            this.btnModules.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Gainsboro;
            this.btnProfile.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProfile.Location = new System.Drawing.Point(377, 240);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(234, 47);
            this.btnProfile.TabIndex = 11;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.button2_Click);
            // 
            // LecturerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1041, 570);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnModules);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.lblIdentity);
            this.Controls.Add(this.lblLectureHomePage);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "LecturerHome";
            this.Text = "LecturerHomepage";
            this.Load += new System.EventHandler(this.LecturerHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.Label lblLectureHomePage;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnModules;
        private System.Windows.Forms.Button btnProfile;
    }
}