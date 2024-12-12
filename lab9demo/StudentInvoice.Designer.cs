namespace lab9demo
{
    partial class StudentInvoice
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
            this.lstPending = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstPayed = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPending
            // 
            this.lstPending.FormattingEnabled = true;
            this.lstPending.ItemHeight = 16;
            this.lstPending.Location = new System.Drawing.Point(12, 99);
            this.lstPending.Name = "lstPending";
            this.lstPending.Size = new System.Drawing.Size(199, 324);
            this.lstPending.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(249, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Invoices and Payments";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(229, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Payed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pending payment";
            // 
            // lstPayed
            // 
            this.lstPayed.FormattingEnabled = true;
            this.lstPayed.ItemHeight = 16;
            this.lstPayed.Location = new System.Drawing.Point(234, 99);
            this.lstPayed.Name = "lstPayed";
            this.lstPayed.Size = new System.Drawing.Size(199, 324);
            this.lstPayed.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(445, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Amount to be payed:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInvoice.Location = new System.Drawing.Point(644, 99);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(0, 25);
            this.lblInvoice.TabIndex = 10;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(439, 127);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(349, 40);
            this.btnPay.TabIndex = 11;
            this.btnPay.Text = "Pay amount";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // StudentInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.lblInvoice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstPayed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstPending);
            this.Name = "StudentInvoice";
            this.Text = "StudentInvoice";
            this.Load += new System.EventHandler(this.StudentInvoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPending;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstPayed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.Button btnPay;
    }
}