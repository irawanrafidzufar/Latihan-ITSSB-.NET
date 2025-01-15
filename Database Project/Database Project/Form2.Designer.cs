namespace Database_Project
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
            cbCountry = new ComboBox();
            label5 = new Label();
            txtPass = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // cbCountry
            // 
            cbCountry.Font = new Font("Segoe UI", 12F);
            cbCountry.FormattingEnabled = true;
            cbCountry.Items.AddRange(new object[] { "USA", "UK", "FRANCE", "GERMANY", "RUSSIA", "ITALY", "SAUDI ARABIA", "NETHERLAND" });
            cbCountry.Location = new Point(121, 278);
            cbCountry.Margin = new Padding(3, 4, 3, 4);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(311, 36);
            cbCountry.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(20, 278);
            label5.Name = "label5";
            label5.Size = new Size(82, 28);
            label5.TabIndex = 15;
            label5.Text = "Country";
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 12F);
            txtPass.Location = new Point(121, 216);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(311, 34);
            txtPass.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(20, 216);
            label4.Name = "label4";
            label4.Size = new Size(93, 28);
            label4.TabIndex = 13;
            label4.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(121, 155);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(311, 34);
            txtEmail.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(20, 155);
            label3.Name = "label3";
            label3.Size = new Size(59, 28);
            label3.TabIndex = 11;
            label3.Text = "Email";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(121, 100);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(311, 34);
            txtName.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(20, 100);
            label2.Name = "label2";
            label2.Size = new Size(64, 28);
            label2.TabIndex = 9;
            label2.Text = "Name";
            // 
            // button1
            // 
            button1.Location = new Point(210, 340);
            button1.Name = "button1";
            button1.Size = new Size(222, 41);
            button1.TabIndex = 17;
            button1.Text = "Update User Info";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21F);
            label1.Location = new Point(20, 26);
            label1.Name = "label1";
            label1.Size = new Size(412, 47);
            label1.TabIndex = 18;
            label1.Text = "Change Account Settings";
            // 
            // button2
            // 
            button2.Location = new Point(20, 340);
            button2.Name = "button2";
            button2.Size = new Size(184, 41);
            button2.TabIndex = 19;
            button2.Text = "Delete My Account";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 411);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(cbCountry);
            Controls.Add(label5);
            Controls.Add(txtPass);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtName);
            Controls.Add(label2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbCountry;
        private Label label5;
        private TextBox txtPass;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtName;
        private Label label2;
        private Button button1;
        private Label label1;
        private Button button2;
    }
}