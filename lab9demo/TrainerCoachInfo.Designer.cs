namespace lab9demo
{
    partial class TrainerCoachInfo
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
            this.Textbox_ModuleName = new System.Windows.Forms.TextBox();
            this.Textbox_Charge = new System.Windows.Forms.TextBox();
            this.Textbox_ClassSchedule = new System.Windows.Forms.TextBox();
            this.DataGridView_CoachInfo = new System.Windows.Forms.DataGridView();
            this.Button_Add_CoachInfo = new System.Windows.Forms.Button();
            this.Button_Update_CoachInfo = new System.Windows.Forms.Button();
            this.Button_Delete_CoachInfo = new System.Windows.Forms.Button();
            this.Button_Show_Grid_Table = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_CoachInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coaching Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(46, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Module Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(46, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Charges :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(46, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Class Schedule :";
            // 
            // Textbox_ModuleName
            // 
            this.Textbox_ModuleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Textbox_ModuleName.Location = new System.Drawing.Point(213, 80);
            this.Textbox_ModuleName.Name = "Textbox_ModuleName";
            this.Textbox_ModuleName.Size = new System.Drawing.Size(176, 27);
            this.Textbox_ModuleName.TabIndex = 4;
            // 
            // Textbox_Charge
            // 
            this.Textbox_Charge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Textbox_Charge.Location = new System.Drawing.Point(213, 123);
            this.Textbox_Charge.Name = "Textbox_Charge";
            this.Textbox_Charge.Size = new System.Drawing.Size(176, 27);
            this.Textbox_Charge.TabIndex = 5;
            // 
            // Textbox_ClassSchedule
            // 
            this.Textbox_ClassSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Textbox_ClassSchedule.Location = new System.Drawing.Point(213, 168);
            this.Textbox_ClassSchedule.Name = "Textbox_ClassSchedule";
            this.Textbox_ClassSchedule.Size = new System.Drawing.Size(176, 27);
            this.Textbox_ClassSchedule.TabIndex = 6;
            // 
            // DataGridView_CoachInfo
            // 
            this.DataGridView_CoachInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_CoachInfo.Location = new System.Drawing.Point(446, 80);
            this.DataGridView_CoachInfo.Name = "DataGridView_CoachInfo";
            this.DataGridView_CoachInfo.RowHeadersWidth = 51;
            this.DataGridView_CoachInfo.RowTemplate.Height = 24;
            this.DataGridView_CoachInfo.Size = new System.Drawing.Size(619, 358);
            this.DataGridView_CoachInfo.TabIndex = 7;
            // 
            // Button_Add_CoachInfo
            // 
            this.Button_Add_CoachInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Add_CoachInfo.Location = new System.Drawing.Point(50, 247);
            this.Button_Add_CoachInfo.Name = "Button_Add_CoachInfo";
            this.Button_Add_CoachInfo.Size = new System.Drawing.Size(113, 36);
            this.Button_Add_CoachInfo.TabIndex = 8;
            this.Button_Add_CoachInfo.Text = "Add";
            this.Button_Add_CoachInfo.UseVisualStyleBackColor = true;
            this.Button_Add_CoachInfo.Click += new System.EventHandler(this.Button_Add_CoachInfo_Click);
            // 
            // Button_Update_CoachInfo
            // 
            this.Button_Update_CoachInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Update_CoachInfo.Location = new System.Drawing.Point(169, 247);
            this.Button_Update_CoachInfo.Name = "Button_Update_CoachInfo";
            this.Button_Update_CoachInfo.Size = new System.Drawing.Size(113, 36);
            this.Button_Update_CoachInfo.TabIndex = 9;
            this.Button_Update_CoachInfo.Text = "Update";
            this.Button_Update_CoachInfo.UseVisualStyleBackColor = true;
            this.Button_Update_CoachInfo.Click += new System.EventHandler(this.Button_Update_CoachInfo_Click);
            // 
            // Button_Delete_CoachInfo
            // 
            this.Button_Delete_CoachInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Delete_CoachInfo.Location = new System.Drawing.Point(288, 247);
            this.Button_Delete_CoachInfo.Name = "Button_Delete_CoachInfo";
            this.Button_Delete_CoachInfo.Size = new System.Drawing.Size(113, 36);
            this.Button_Delete_CoachInfo.TabIndex = 10;
            this.Button_Delete_CoachInfo.Text = "Delete";
            this.Button_Delete_CoachInfo.UseVisualStyleBackColor = true;
            this.Button_Delete_CoachInfo.Click += new System.EventHandler(this.Button_Delete_CoachInfo_Click);
            // 
            // Button_Show_Grid_Table
            // 
            this.Button_Show_Grid_Table.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Show_Grid_Table.Location = new System.Drawing.Point(109, 289);
            this.Button_Show_Grid_Table.Name = "Button_Show_Grid_Table";
            this.Button_Show_Grid_Table.Size = new System.Drawing.Size(231, 36);
            this.Button_Show_Grid_Table.TabIndex = 12;
            this.Button_Show_Grid_Table.Text = "Show / Refresh Table";
            this.Button_Show_Grid_Table.UseVisualStyleBackColor = true;
            this.Button_Show_Grid_Table.Click += new System.EventHandler(this.Button_Show_Grid_Table_Click);
            // 
            // TrainerCoachInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 450);
            this.Controls.Add(this.Button_Show_Grid_Table);
            this.Controls.Add(this.Button_Delete_CoachInfo);
            this.Controls.Add(this.Button_Update_CoachInfo);
            this.Controls.Add(this.Button_Add_CoachInfo);
            this.Controls.Add(this.DataGridView_CoachInfo);
            this.Controls.Add(this.Textbox_ClassSchedule);
            this.Controls.Add(this.Textbox_Charge);
            this.Controls.Add(this.Textbox_ModuleName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TrainerCoachInfo";
            this.Text = "TrainerCoachInfo";
            this.Load += new System.EventHandler(this.TrainerCoachInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_CoachInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Textbox_ModuleName;
        private System.Windows.Forms.TextBox Textbox_Charge;
        private System.Windows.Forms.TextBox Textbox_ClassSchedule;
        private System.Windows.Forms.DataGridView DataGridView_CoachInfo;
        private System.Windows.Forms.Button Button_Add_CoachInfo;
        private System.Windows.Forms.Button Button_Update_CoachInfo;
        private System.Windows.Forms.Button Button_Delete_CoachInfo;
        private System.Windows.Forms.Button Button_Show_Grid_Table;
    }
}