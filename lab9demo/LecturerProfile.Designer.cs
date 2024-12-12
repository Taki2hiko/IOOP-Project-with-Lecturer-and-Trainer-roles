namespace lab9demo
{
    partial class LecturerProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerProfile));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblUpdatedEmail = new System.Windows.Forms.Label();
            this.lblUpdateInformation = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblUpdatedPhoneNumber = new System.Windows.Forms.Label();
            this.lblYourProfile = new System.Windows.Forms.Label();
            this.lblCurrentEmail = new System.Windows.Forms.Label();
            this.lblValueCurrentEmail = new System.Windows.Forms.Label();
            this.lblValueCurrentPhone = new System.Windows.Forms.Label();
            this.lblCurrentPhone = new System.Windows.Forms.Label();
            this.lblRoleLecturer = new System.Windows.Forms.Label();
            this.lblCurrentRole = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate.Location = new System.Drawing.Point(909, 258);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(184, 54);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEmail.Location = new System.Drawing.Point(995, 162);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 39);
            this.txtEmail.TabIndex = 31;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblUpdatedEmail
            // 
            this.lblUpdatedEmail.AutoSize = true;
            this.lblUpdatedEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdatedEmail.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdatedEmail.Location = new System.Drawing.Point(874, 159);
            this.lblUpdatedEmail.Name = "lblUpdatedEmail";
            this.lblUpdatedEmail.Size = new System.Drawing.Size(111, 37);
            this.lblUpdatedEmail.TabIndex = 29;
            this.lblUpdatedEmail.Text = "Email:";
            // 
            // lblUpdateInformation
            // 
            this.lblUpdateInformation.AutoSize = true;
            this.lblUpdateInformation.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateInformation.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdateInformation.Location = new System.Drawing.Point(672, 27);
            this.lblUpdateInformation.Name = "lblUpdateInformation";
            this.lblUpdateInformation.Size = new System.Drawing.Size(570, 53);
            this.lblUpdateInformation.TabIndex = 28;
            this.lblUpdateInformation.Text = "UPDATE INFORMATION";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPhone.Location = new System.Drawing.Point(995, 110);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(150, 39);
            this.txtPhone.TabIndex = 37;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // lblUpdatedPhoneNumber
            // 
            this.lblUpdatedPhoneNumber.AutoSize = true;
            this.lblUpdatedPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdatedPhoneNumber.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUpdatedPhoneNumber.Location = new System.Drawing.Point(739, 107);
            this.lblUpdatedPhoneNumber.Name = "lblUpdatedPhoneNumber";
            this.lblUpdatedPhoneNumber.Size = new System.Drawing.Size(241, 37);
            this.lblUpdatedPhoneNumber.TabIndex = 35;
            this.lblUpdatedPhoneNumber.Text = "Phone Number:";
            this.lblUpdatedPhoneNumber.Click += new System.EventHandler(this.lblUpdatedPhoneNumber_Click);
            // 
            // lblYourProfile
            // 
            this.lblYourProfile.AutoSize = true;
            this.lblYourProfile.BackColor = System.Drawing.Color.Transparent;
            this.lblYourProfile.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYourProfile.Location = new System.Drawing.Point(120, 27);
            this.lblYourProfile.Name = "lblYourProfile";
            this.lblYourProfile.Size = new System.Drawing.Size(381, 53);
            this.lblYourProfile.TabIndex = 38;
            this.lblYourProfile.Text = "YOUR PROFILE";
            // 
            // lblCurrentEmail
            // 
            this.lblCurrentEmail.AutoSize = true;
            this.lblCurrentEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentEmail.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentEmail.Location = new System.Drawing.Point(184, 149);
            this.lblCurrentEmail.Name = "lblCurrentEmail";
            this.lblCurrentEmail.Size = new System.Drawing.Size(111, 37);
            this.lblCurrentEmail.TabIndex = 39;
            this.lblCurrentEmail.Text = "Email:";
            // 
            // lblValueCurrentEmail
            // 
            this.lblValueCurrentEmail.AutoSize = true;
            this.lblValueCurrentEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblValueCurrentEmail.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblValueCurrentEmail.Location = new System.Drawing.Point(305, 150);
            this.lblValueCurrentEmail.Name = "lblValueCurrentEmail";
            this.lblValueCurrentEmail.Size = new System.Drawing.Size(0, 37);
            this.lblValueCurrentEmail.TabIndex = 43;
            // 
            // lblValueCurrentPhone
            // 
            this.lblValueCurrentPhone.AutoSize = true;
            this.lblValueCurrentPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblValueCurrentPhone.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblValueCurrentPhone.Location = new System.Drawing.Point(305, 99);
            this.lblValueCurrentPhone.Name = "lblValueCurrentPhone";
            this.lblValueCurrentPhone.Size = new System.Drawing.Size(0, 37);
            this.lblValueCurrentPhone.TabIndex = 45;
            // 
            // lblCurrentPhone
            // 
            this.lblCurrentPhone.AutoSize = true;
            this.lblCurrentPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPhone.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentPhone.Location = new System.Drawing.Point(55, 100);
            this.lblCurrentPhone.Name = "lblCurrentPhone";
            this.lblCurrentPhone.Size = new System.Drawing.Size(235, 37);
            this.lblCurrentPhone.TabIndex = 44;
            this.lblCurrentPhone.Text = "Phone number:";
            // 
            // lblRoleLecturer
            // 
            this.lblRoleLecturer.AutoSize = true;
            this.lblRoleLecturer.BackColor = System.Drawing.Color.Transparent;
            this.lblRoleLecturer.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRoleLecturer.Location = new System.Drawing.Point(305, 193);
            this.lblRoleLecturer.Name = "lblRoleLecturer";
            this.lblRoleLecturer.Size = new System.Drawing.Size(127, 37);
            this.lblRoleLecturer.TabIndex = 47;
            this.lblRoleLecturer.Text = "Lecturer";
            this.lblRoleLecturer.Click += new System.EventHandler(this.Lecturer_Click);
            // 
            // lblCurrentRole
            // 
            this.lblCurrentRole.AutoSize = true;
            this.lblCurrentRole.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentRole.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCurrentRole.Location = new System.Drawing.Point(205, 193);
            this.lblCurrentRole.Name = "lblCurrentRole";
            this.lblCurrentRole.Size = new System.Drawing.Size(93, 37);
            this.lblCurrentRole.TabIndex = 46;
            this.lblCurrentRole.Text = "Role:";
            // 
            // LecturerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 427);
            this.Controls.Add(this.lblRoleLecturer);
            this.Controls.Add(this.lblCurrentRole);
            this.Controls.Add(this.lblValueCurrentPhone);
            this.Controls.Add(this.lblCurrentPhone);
            this.Controls.Add(this.lblValueCurrentEmail);
            this.Controls.Add(this.lblCurrentEmail);
            this.Controls.Add(this.lblYourProfile);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblUpdatedPhoneNumber);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblUpdatedEmail);
            this.Controls.Add(this.lblUpdateInformation);
            this.Name = "LecturerProfile";
            this.Text = "LecturerProfile";
            this.Load += new System.EventHandler(this.LecturerProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblUpdatedEmail;
        private System.Windows.Forms.Label lblUpdateInformation;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblUpdatedPhoneNumber;
        private System.Windows.Forms.Label lblYourProfile;
        private System.Windows.Forms.Label lblCurrentEmail;
        private System.Windows.Forms.Label lblValueCurrentEmail;
        private System.Windows.Forms.Label lblValueCurrentPhone;
        private System.Windows.Forms.Label lblCurrentPhone;
        private System.Windows.Forms.Label lblRoleLecturer;
        private System.Windows.Forms.Label lblCurrentRole;
    }
}