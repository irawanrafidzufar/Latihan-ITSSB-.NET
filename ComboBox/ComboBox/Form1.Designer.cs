namespace ComboBox
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
            comboBox1 = new System.Windows.Forms.ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label1 = new Label();
            label6 = new Label();
            comboBox2 = new System.Windows.Forms.ComboBox();
            txtdoctorname = new Label();
            txtspeciality = new Label();
            txtcontact = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "clinic1", "clinic2", "clinic3" });
            comboBox1.Location = new Point(19, 40);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(224, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(19, 117);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 2;
            label2.Text = "Select Clinic";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(19, 155);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 3;
            label3.Text = "Select Clinic";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(19, 196);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 4;
            label4.Text = "Select Clinic";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(19, 235);
            label5.Name = "label5";
            label5.Size = new Size(93, 21);
            label5.TabIndex = 5;
            label5.Text = "Select Clinic";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(19, 16);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 0;
            label1.Text = "Select Clinic";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(408, 16);
            label6.Name = "label6";
            label6.Size = new Size(102, 21);
            label6.TabIndex = 6;
            label6.Text = "Select Doctor";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "doctor1", "doctor2", "doctor3" });
            comboBox2.Location = new Point(408, 40);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(226, 23);
            comboBox2.TabIndex = 7;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // txtdoctorname
            // 
            txtdoctorname.AutoSize = true;
            txtdoctorname.FlatStyle = FlatStyle.Flat;
            txtdoctorname.Font = new Font("Segoe UI", 12F);
            txtdoctorname.Location = new Point(408, 117);
            txtdoctorname.Name = "txtdoctorname";
            txtdoctorname.Size = new Size(102, 21);
            txtdoctorname.TabIndex = 8;
            txtdoctorname.Text = "Select Doctor";
            // 
            // txtspeciality
            // 
            txtspeciality.AutoSize = true;
            txtspeciality.FlatStyle = FlatStyle.Flat;
            txtspeciality.Font = new Font("Segoe UI", 12F);
            txtspeciality.Location = new Point(408, 155);
            txtspeciality.Name = "txtspeciality";
            txtspeciality.Size = new Size(102, 21);
            txtspeciality.TabIndex = 9;
            txtspeciality.Text = "Select Doctor";
            // 
            // txtcontact
            // 
            txtcontact.AutoSize = true;
            txtcontact.FlatStyle = FlatStyle.Flat;
            txtcontact.Font = new Font("Segoe UI", 12F);
            txtcontact.Location = new Point(408, 196);
            txtcontact.Name = "txtcontact";
            txtcontact.Size = new Size(102, 21);
            txtcontact.TabIndex = 10;
            txtcontact.Text = "Select Doctor";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(txtcontact);
            Controls.Add(txtspeciality);
            Controls.Add(txtdoctorname);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label1;
        private Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private Label txtdoctorname;
        private Label txtspeciality;
        private Label txtcontact;
    }
}
