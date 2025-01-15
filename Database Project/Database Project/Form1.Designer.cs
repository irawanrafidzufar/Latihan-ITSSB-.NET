namespace Database_Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtName = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtPass = new TextBox();
            label5 = new Label();
            cbCountry = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F);
            label1.Location = new Point(24, 24);
            label1.Name = "label1";
            label1.Size = new Size(163, 54);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(24, 128);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(118, 128);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(251, 34);
            txtName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(24, 200);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(118, 200);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(251, 34);
            txtEmail.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(24, 275);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 12F);
            txtPass.Location = new Point(118, 275);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(251, 34);
            txtPass.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(24, 353);
            label5.Name = "label5";
            label5.Size = new Size(82, 28);
            label5.TabIndex = 7;
            label5.Text = "Country";
            // 
            // cbCountry
            // 
            cbCountry.Font = new Font("Segoe UI", 12F);
            cbCountry.FormattingEnabled = true;
            cbCountry.Items.AddRange(new object[] { "USA", "UK", "FRANCE", "GERMANY", "RUSSIA", "ITALY", "SAUDI ARABIA", "NETHERLAND" });
            cbCountry.Location = new Point(118, 353);
            cbCountry.Margin = new Padding(3, 4, 3, 4);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(251, 36);
            cbCountry.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(237, 428);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(133, 49);
            button1.TabIndex = 9;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(98, 428);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(133, 49);
            button2.TabIndex = 10;
            button2.Text = "Sign In";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 493);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(cbCountry);
            Controls.Add(label5);
            Controls.Add(txtPass);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtPass;
        private Label label5;
        private ComboBox cbCountry;
        private Button button1;
        private Button button2;
    }
}
