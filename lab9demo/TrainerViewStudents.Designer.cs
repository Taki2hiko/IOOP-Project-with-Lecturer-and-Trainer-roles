namespace lab9demo
{
    partial class TrainerViewStudents
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
            this.DataGridView_Students = new System.Windows.Forms.DataGridView();
            this.Button_Show_Students = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Students)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(252, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Students Enrolled";
            // 
            // DataGridView_Students
            // 
            this.DataGridView_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_Students.Location = new System.Drawing.Point(12, 66);
            this.DataGridView_Students.Name = "DataGridView_Students";
            this.DataGridView_Students.RowHeadersWidth = 51;
            this.DataGridView_Students.RowTemplate.Height = 24;
            this.DataGridView_Students.Size = new System.Drawing.Size(776, 345);
            this.DataGridView_Students.TabIndex = 1;
            // 
            // Button_Show_Students
            // 
            this.Button_Show_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Show_Students.Location = new System.Drawing.Point(233, 431);
            this.Button_Show_Students.Name = "Button_Show_Students";
            this.Button_Show_Students.Size = new System.Drawing.Size(328, 42);
            this.Button_Show_Students.TabIndex = 2;
            this.Button_Show_Students.Text = "Show / Refresh Table";
            this.Button_Show_Students.UseVisualStyleBackColor = true;
            this.Button_Show_Students.Click += new System.EventHandler(this.Button_Show_Students_Click);
            // 
            // TrainerViewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.Button_Show_Students);
            this.Controls.Add(this.DataGridView_Students);
            this.Controls.Add(this.label1);
            this.Name = "TrainerViewStudents";
            this.Text = "TrainerViewStudents";
            this.Load += new System.EventHandler(this.TrainerViewStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_Students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DataGridView_Students;
        private System.Windows.Forms.Button Button_Show_Students;
    }
}