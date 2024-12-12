namespace lab9demo
{
    partial class LecturerRequests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerRequests));
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.lblRequests = new System.Windows.Forms.Label();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.cmbModules = new System.Windows.Forms.ComboBox();
            this.lblStudents = new System.Windows.Forms.Label();
            this.lblModules = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbStudents
            // 
            this.cmbStudents.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(254, 231);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(216, 45);
            this.cmbStudents.TabIndex = 2;
            this.cmbStudents.SelectedIndexChanged += new System.EventHandler(this.cmbStudents_SelectedIndexChanged);
            // 
            // lblRequests
            // 
            this.lblRequests.AutoSize = true;
            this.lblRequests.BackColor = System.Drawing.Color.Transparent;
            this.lblRequests.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRequests.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRequests.Location = new System.Drawing.Point(400, 65);
            this.lblRequests.Name = "lblRequests";
            this.lblRequests.Size = new System.Drawing.Size(257, 68);
            this.lblRequests.TabIndex = 6;
            this.lblRequests.Text = "Requests";
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnApprove.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApprove.Location = new System.Drawing.Point(253, 343);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(217, 59);
            this.btnApprove.TabIndex = 23;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDecline.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecline.Location = new System.Drawing.Point(563, 343);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(216, 59);
            this.btnDecline.TabIndex = 24;
            this.btnDecline.Text = "Decline";
            this.btnDecline.UseVisualStyleBackColor = false;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // cmbModules
            // 
            this.cmbModules.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbModules.FormattingEnabled = true;
            this.cmbModules.Location = new System.Drawing.Point(563, 231);
            this.cmbModules.Name = "cmbModules";
            this.cmbModules.Size = new System.Drawing.Size(216, 45);
            this.cmbModules.TabIndex = 25;
            this.cmbModules.SelectedIndexChanged += new System.EventHandler(this.cmbModules_SelectedIndexChanged);
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.BackColor = System.Drawing.Color.Transparent;
            this.lblStudents.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStudents.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStudents.Location = new System.Drawing.Point(273, 165);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(157, 46);
            this.lblStudents.TabIndex = 26;
            this.lblStudents.Text = "Students";
            // 
            // lblModules
            // 
            this.lblModules.AutoSize = true;
            this.lblModules.BackColor = System.Drawing.Color.Transparent;
            this.lblModules.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblModules.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblModules.Location = new System.Drawing.Point(585, 165);
            this.lblModules.Name = "lblModules";
            this.lblModules.Size = new System.Drawing.Size(159, 46);
            this.lblModules.TabIndex = 27;
            this.lblModules.Text = "Modules";
            // 
            // LecturerRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1106, 603);
            this.Controls.Add(this.lblModules);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.cmbModules);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.lblRequests);
            this.Controls.Add(this.cmbStudents);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "LecturerRequests";
            this.Text = "LecturerRequests";
            this.Load += new System.EventHandler(this.LecturerRequests_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.Label lblRequests;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.ComboBox cmbModules;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Label lblModules;
    }
}