namespace lab9demo
{
    partial class AdminIncomeReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(216, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monthly Income Report";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.5F);
            this.label2.Location = new System.Drawing.Point(132, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Income :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.5F);
            this.label3.Location = new System.Drawing.Point(159, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Profit :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.5F);
            this.label4.Location = new System.Drawing.Point(96, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Expenses :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.5F);
            this.label5.Location = new System.Drawing.Point(307, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 35);
            this.label5.TabIndex = 6;
            this.label5.Text = "assign label for expenses";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.5F);
            this.label6.Location = new System.Drawing.Point(307, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(322, 35);
            this.label6.TabIndex = 5;
            this.label6.Text = "assign label the profits";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.5F);
            this.label7.Location = new System.Drawing.Point(307, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(299, 35);
            this.label7.TabIndex = 4;
            this.label7.Text = "assign label for profit";
            // 
            // AdminIncomeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdminIncomeReport";
            this.Text = "AdminIncomeReport";
            this.Load += new System.EventHandler(this.AdminIncomeReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}