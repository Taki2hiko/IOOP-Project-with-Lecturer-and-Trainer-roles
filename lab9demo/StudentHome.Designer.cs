namespace lab9demo
{
    partial class StudentHome
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
            this.btnViewinvoice = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnRequests = new System.Windows.Forms.Button();
            this.btnTimetable = new System.Windows.Forms.Button();
            this.lblIdentity = new System.Windows.Forms.Label();
            this.adminhomepage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnViewinvoice
            // 
            this.btnViewinvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewinvoice.Location = new System.Drawing.Point(253, 367);
            this.btnViewinvoice.Name = "btnViewinvoice";
            this.btnViewinvoice.Size = new System.Drawing.Size(306, 44);
            this.btnViewinvoice.TabIndex = 12;
            this.btnViewinvoice.Text = "View invoice";
            this.btnViewinvoice.UseVisualStyleBackColor = true;
            this.btnViewinvoice.Click += new System.EventHandler(this.Viewinvoice_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProfile.Location = new System.Drawing.Point(253, 170);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(306, 44);
            this.btnProfile.TabIndex = 11;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnRequests
            // 
            this.btnRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRequests.Location = new System.Drawing.Point(253, 304);
            this.btnRequests.Name = "btnRequests";
            this.btnRequests.Size = new System.Drawing.Size(306, 41);
            this.btnRequests.TabIndex = 10;
            this.btnRequests.Text = "Requests";
            this.btnRequests.UseVisualStyleBackColor = true;
            this.btnRequests.Click += new System.EventHandler(this.Requests_Click);
            // 
            // btnTimetable
            // 
            this.btnTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTimetable.Location = new System.Drawing.Point(253, 240);
            this.btnTimetable.Name = "btnTimetable";
            this.btnTimetable.Size = new System.Drawing.Size(306, 44);
            this.btnTimetable.TabIndex = 9;
            this.btnTimetable.Text = "Timetable";
            this.btnTimetable.UseVisualStyleBackColor = true;
            this.btnTimetable.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblIdentity
            // 
            this.lblIdentity.AutoSize = true;
            this.lblIdentity.Location = new System.Drawing.Point(232, 107);
            this.lblIdentity.Name = "lblIdentity";
            this.lblIdentity.Size = new System.Drawing.Size(0, 16);
            this.lblIdentity.TabIndex = 8;
            // 
            // adminhomepage
            // 
            this.adminhomepage.AutoSize = true;
            this.adminhomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminhomepage.Location = new System.Drawing.Point(198, 40);
            this.adminhomepage.Name = "adminhomepage";
            this.adminhomepage.Size = new System.Drawing.Size(468, 46);
            this.adminhomepage.TabIndex = 7;
            this.adminhomepage.Text = "STUDENT HOMEPAGE";
            // 
            // StudentHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnViewinvoice);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnRequests);
            this.Controls.Add(this.btnTimetable);
            this.Controls.Add(this.lblIdentity);
            this.Controls.Add(this.adminhomepage);
            this.Name = "StudentHome";
            this.Text = "StudentHome";
            this.Load += new System.EventHandler(this.StudentHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnViewinvoice;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnRequests;
        private System.Windows.Forms.Button btnTimetable;
        private System.Windows.Forms.Label lblIdentity;
        private System.Windows.Forms.Label adminhomepage;
    }
}