namespace lab9demo
{
    partial class StudentTimetable
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
            this.datagridTimetable = new System.Windows.Forms.DataGridView();
            this.adminhomepage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTimetable)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridTimetable
            // 
            this.datagridTimetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridTimetable.Location = new System.Drawing.Point(12, 76);
            this.datagridTimetable.Name = "datagridTimetable";
            this.datagridTimetable.RowHeadersWidth = 51;
            this.datagridTimetable.RowTemplate.Height = 24;
            this.datagridTimetable.Size = new System.Drawing.Size(776, 362);
            this.datagridTimetable.TabIndex = 0;
            this.datagridTimetable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // adminhomepage
            // 
            this.adminhomepage.AutoSize = true;
            this.adminhomepage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminhomepage.Location = new System.Drawing.Point(158, 9);
            this.adminhomepage.Name = "adminhomepage";
            this.adminhomepage.Size = new System.Drawing.Size(468, 46);
            this.adminhomepage.TabIndex = 8;
            this.adminhomepage.Text = "STUDENT HOMEPAGE";
            // 
            // StudentTimetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.adminhomepage);
            this.Controls.Add(this.datagridTimetable);
            this.Name = "StudentTimetable";
            this.Text = "StudentCoachingInfo";
            ((System.ComponentModel.ISupportInitialize)(this.datagridTimetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridTimetable;
        private System.Windows.Forms.Label adminhomepage;
    }
}