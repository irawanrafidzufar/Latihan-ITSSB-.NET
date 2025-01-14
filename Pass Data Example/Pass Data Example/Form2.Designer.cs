namespace Pass_Data_Example
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            fname = new Label();
            lname = new Label();
            email = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            sms = new Label();
            report = new Label();
            transaction = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(296, 46);
            label1.TabIndex = 0;
            label1.Text = "Thanks for Signup.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 90);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 1;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 145);
            label3.Name = "label3";
            label3.Size = new Size(103, 28);
            label3.TabIndex = 2;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(12, 207);
            label4.Name = "label4";
            label4.Size = new Size(134, 28);
            label4.TabIndex = 3;
            label4.Text = "Email Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(12, 263);
            label5.Name = "label5";
            label5.Size = new Size(82, 28);
            label5.TabIndex = 4;
            label5.Text = "Services";
            // 
            // fname
            // 
            fname.AutoSize = true;
            fname.Font = new Font("Segoe UI", 8F);
            fname.Location = new Point(189, 96);
            fname.Name = "fname";
            fname.Size = new Size(75, 19);
            fname.TabIndex = 5;
            fname.Text = "First Name";
            fname.Click += fname_Click;
            // 
            // lname
            // 
            lname.AutoSize = true;
            lname.Font = new Font("Segoe UI", 8F);
            lname.Location = new Point(189, 151);
            lname.Name = "lname";
            lname.Size = new Size(64, 19);
            lname.TabIndex = 6;
            lname.Text = "lastname";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 8F);
            email.Location = new Point(189, 213);
            email.Name = "email";
            email.Size = new Size(41, 19);
            email.TabIndex = 7;
            email.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8F);
            label9.Location = new Point(189, 272);
            label9.Name = "label9";
            label9.Size = new Size(110, 19);
            label9.TabIndex = 8;
            label9.Text = "SMS Notification";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8F);
            label10.Location = new Point(189, 321);
            label10.Name = "label10";
            label10.Size = new Size(56, 19);
            label10.TabIndex = 9;
            label10.Text = "Reports";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 8F);
            label11.Location = new Point(189, 376);
            label11.Name = "label11";
            label11.Size = new Size(129, 19);
            label11.TabIndex = 10;
            label11.Text = "Transaction Reports";
            // 
            // sms
            // 
            sms.AutoSize = true;
            sms.Font = new Font("Segoe UI", 20F);
            sms.Location = new Point(333, 252);
            sms.Name = "sms";
            sms.Size = new Size(36, 46);
            sms.TabIndex = 11;
            sms.Text = "x";
            sms.Click += label6_Click;
            // 
            // report
            // 
            report.AutoSize = true;
            report.Font = new Font("Segoe UI", 20F);
            report.Location = new Point(333, 300);
            report.Name = "report";
            report.Size = new Size(36, 46);
            report.TabIndex = 12;
            report.Text = "x";
            // 
            // transaction
            // 
            transaction.AutoSize = true;
            transaction.Font = new Font("Segoe UI", 20F);
            transaction.Location = new Point(333, 358);
            transaction.Name = "transaction";
            transaction.Size = new Size(36, 46);
            transaction.TabIndex = 13;
            transaction.Text = "x";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(transaction);
            Controls.Add(report);
            Controls.Add(sms);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(email);
            Controls.Add(lname);
            Controls.Add(fname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label fname;
        private Label lname;
        private Label email;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label sms;
        private Label report;
        private Label transaction;
    }
}