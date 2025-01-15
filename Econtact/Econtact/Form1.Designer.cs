namespace Econtact
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
            txtid = new TextBox();
            txtfname = new TextBox();
            label2 = new Label();
            txtlname = new TextBox();
            label3 = new Label();
            txtno = new TextBox();
            label4 = new Label();
            txtaddress = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cbGender = new ComboBox();
            txtadd = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            txtsearch = new TextBox();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F);
            label1.Location = new Point(12, 70);
            label1.Name = "label1";
            label1.Size = new Size(75, 19);
            label1.TabIndex = 0;
            label1.Text = "Contact ID";
            // 
            // txtid
            // 
            txtid.Font = new Font("Segoe UI", 8F);
            txtid.Location = new Point(104, 67);
            txtid.Name = "txtid";
            txtid.Size = new Size(165, 25);
            txtid.TabIndex = 1;
            // 
            // txtfname
            // 
            txtfname.Font = new Font("Segoe UI", 8F);
            txtfname.Location = new Point(104, 108);
            txtfname.Name = "txtfname";
            txtfname.Size = new Size(165, 25);
            txtfname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F);
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(75, 19);
            label2.TabIndex = 2;
            label2.Text = "First Name";
            // 
            // txtlname
            // 
            txtlname.Font = new Font("Segoe UI", 8F);
            txtlname.Location = new Point(104, 151);
            txtlname.Name = "txtlname";
            txtlname.Size = new Size(165, 25);
            txtlname.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F);
            label3.Location = new Point(12, 154);
            label3.Name = "label3";
            label3.Size = new Size(74, 19);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            // 
            // txtno
            // 
            txtno.Font = new Font("Segoe UI", 8F);
            txtno.Location = new Point(104, 191);
            txtno.Name = "txtno";
            txtno.Size = new Size(165, 25);
            txtno.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F);
            label4.Location = new Point(12, 194);
            label4.Name = "label4";
            label4.Size = new Size(79, 19);
            label4.TabIndex = 6;
            label4.Text = "Contact No";
            // 
            // txtaddress
            // 
            txtaddress.Font = new Font("Segoe UI", 8F);
            txtaddress.Location = new Point(104, 238);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(165, 133);
            txtaddress.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8F);
            label5.Location = new Point(12, 241);
            label5.Name = "label5";
            label5.Size = new Size(58, 19);
            label5.TabIndex = 8;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 8F);
            label6.Location = new Point(12, 391);
            label6.Name = "label6";
            label6.Size = new Size(54, 19);
            label6.TabIndex = 10;
            label6.Text = "Gender";
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(104, 391);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(165, 28);
            cbGender.TabIndex = 11;
            // 
            // txtadd
            // 
            txtadd.Location = new Point(12, 434);
            txtadd.Name = "txtadd";
            txtadd.Size = new Size(116, 50);
            txtadd.TabIndex = 12;
            txtadd.Text = "Add";
            txtadd.UseVisualStyleBackColor = true;
            txtadd.Click += txtadd_Click;
            // 
            // button2
            // 
            button2.Location = new Point(134, 434);
            button2.Name = "button2";
            button2.Size = new Size(115, 50);
            button2.TabIndex = 13;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(255, 434);
            button3.Name = "button3";
            button3.Size = new Size(118, 50);
            button3.TabIndex = 14;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(379, 434);
            button4.Name = "button4";
            button4.Size = new Size(123, 50);
            button4.TabIndex = 15;
            button4.Text = "Clear";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(285, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(503, 311);
            dataGridView1.TabIndex = 16;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Segoe UI", 8F);
            txtsearch.Location = new Point(340, 64);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(402, 25);
            txtsearch.TabIndex = 18;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8F);
            label7.Location = new Point(285, 70);
            label7.Name = "label7";
            label7.Size = new Size(49, 19);
            label7.TabIndex = 17;
            label7.Text = "Search";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F);
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(154, 46);
            label8.TabIndex = 19;
            label8.Text = "EContact";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 496);
            Controls.Add(label8);
            Controls.Add(txtsearch);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(txtadd);
            Controls.Add(cbGender);
            Controls.Add(label6);
            Controls.Add(txtaddress);
            Controls.Add(label5);
            Controls.Add(txtno);
            Controls.Add(label4);
            Controls.Add(txtlname);
            Controls.Add(label3);
            Controls.Add(txtfname);
            Controls.Add(label2);
            Controls.Add(txtid);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtid;
        private TextBox txtfname;
        private Label label2;
        private TextBox txtlname;
        private Label label3;
        private TextBox txtno;
        private Label label4;
        private TextBox txtaddress;
        private Label label5;
        private Label label6;
        private ComboBox cbGender;
        private Button txtadd;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dataGridView1;
        private TextBox txtsearch;
        private Label label7;
        private Label label8;
    }
}
