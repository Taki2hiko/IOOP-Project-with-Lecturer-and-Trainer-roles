namespace lab9demo
{
    partial class TrainerFeedback
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
            this.Textbox_Feedback = new System.Windows.Forms.TextBox();
            this.Button_Send_Feedback = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feedback";
            // 
            // Textbox_Feedback
            // 
            this.Textbox_Feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Textbox_Feedback.Location = new System.Drawing.Point(19, 119);
            this.Textbox_Feedback.Name = "Textbox_Feedback";
            this.Textbox_Feedback.Size = new System.Drawing.Size(553, 38);
            this.Textbox_Feedback.TabIndex = 2;
            // 
            // Button_Send_Feedback
            // 
            this.Button_Send_Feedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Send_Feedback.Location = new System.Drawing.Point(19, 181);
            this.Button_Send_Feedback.Name = "Button_Send_Feedback";
            this.Button_Send_Feedback.Size = new System.Drawing.Size(123, 43);
            this.Button_Send_Feedback.TabIndex = 3;
            this.Button_Send_Feedback.Text = "Send";
            this.Button_Send_Feedback.UseVisualStyleBackColor = true;
            this.Button_Send_Feedback.Click += new System.EventHandler(this.Button_Send_Feedback_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(519, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "If you have any concern, please let the administrator know!";
            // 
            // TrainerFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 246);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Button_Send_Feedback);
            this.Controls.Add(this.Textbox_Feedback);
            this.Controls.Add(this.label1);
            this.Name = "TrainerFeedback";
            this.Text = "TrainerFeedbacks";
            this.Load += new System.EventHandler(this.TrainerFeedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Textbox_Feedback;
        private System.Windows.Forms.Button Button_Send_Feedback;
        private System.Windows.Forms.Label label2;
    }
}