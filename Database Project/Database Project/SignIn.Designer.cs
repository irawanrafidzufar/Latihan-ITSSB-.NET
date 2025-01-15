namespace Database_Project
{
    partial class SignIn
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
            txtemail = new TextBox();
            txtpass = new TextBox();
            label3 = new Label();
            btnlogin = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(143, 62);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(22, 109);
            label2.Name = "label2";
            label2.Size = new Size(59, 28);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 14F);
            txtemail.Location = new Point(27, 140);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(341, 39);
            txtemail.TabIndex = 2;
            // 
            // txtpass
            // 
            txtpass.Font = new Font("Segoe UI", 14F);
            txtpass.Location = new Point(27, 233);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(341, 39);
            txtpass.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(22, 202);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // btnlogin
            // 
            btnlogin.Location = new Point(261, 345);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(107, 43);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(152, 294);
            label4.Name = "label4";
            label4.Size = new Size(216, 28);
            label4.TabIndex = 6;
            label4.Text = "Don't have an account?";
            label4.Click += label4_Click;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 403);
            Controls.Add(label4);
            Controls.Add(btnlogin);
            Controls.Add(txtpass);
            Controls.Add(label3);
            Controls.Add(txtemail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SignIn";
            Text = "SignIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtemail;
        private TextBox txtpass;
        private Label label3;
        private Button btnlogin;
        private Label label4;
    }
}