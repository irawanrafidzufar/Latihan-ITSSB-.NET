namespace Pass_Data_Example
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
            label3 = new Label();
            checkBox1 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            groupBox1 = new GroupBox();
            fname = new TextBox();
            lname = new TextBox();
            email = new TextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 168);
            label3.Name = "label3";
            label3.Size = new Size(134, 28);
            label3.TabIndex = 2;
            label3.Text = "Email Address";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(154, 41);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 21);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "SMS Notification";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox3.Location = new Point(154, 101);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(146, 21);
            checkBox3.TabIndex = 6;
            checkBox3.Text = "Transaction Reports";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox2.Location = new Point(154, 71);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(76, 21);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "Reports";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 220);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(533, 146);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Services";
            // 
            // fname
            // 
            fname.Location = new Point(160, 56);
            fname.Name = "fname";
            fname.Size = new Size(385, 27);
            fname.TabIndex = 8;
            // 
            // lname
            // 
            lname.Location = new Point(160, 112);
            lname.Name = "lname";
            lname.Size = new Size(385, 27);
            lname.TabIndex = 9;
            // 
            // email
            // 
            email.Location = new Point(160, 172);
            email.Name = "email";
            email.Size = new Size(385, 27);
            email.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(12, 394);
            button1.Name = "button1";
            button1.Size = new Size(533, 52);
            button1.TabIndex = 11;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 458);
            Controls.Add(button1);
            Controls.Add(email);
            Controls.Add(lname);
            Controls.Add(fname);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox checkBox1;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private GroupBox groupBox1;
        private TextBox fname;
        private TextBox lname;
        private TextBox email;
        private Button button1;
    }
}
