namespace Flight_Booking_App
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
            txtTo = new TextBox();
            txtFrom = new TextBox();
            monthCalendar1 = new MonthCalendar();
            txtFname = new TextBox();
            label3 = new Label();
            txtLname = new TextBox();
            label4 = new Label();
            dbPaspor = new RadioButton();
            rbIdcard = new RadioButton();
            label5 = new Label();
            txtDocNo = new TextBox();
            lblDocNo = new Label();
            lblIssueDate = new Label();
            issueDate = new DateTimePicker();
            lblExpiryDate = new Label();
            ExpiryDate = new DateTimePicker();
            label9 = new Label();
            numBaggage = new NumericUpDown();
            label10 = new Label();
            btnBook = new Button();
            ((System.ComponentModel.ISupportInitialize)numBaggage).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 38);
            label1.Name = "label1";
            label1.Size = new Size(36, 23);
            label1.TabIndex = 0;
            label1.Text = "To: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(433, 38);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 1;
            label2.Text = "From:";
            // 
            // txtTo
            // 
            txtTo.Location = new Point(78, 37);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(203, 27);
            txtTo.TabIndex = 2;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(493, 37);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(203, 27);
            txtFrom.TabIndex = 3;
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(2, 1);
            monthCalendar1.Location = new Point(115, 76);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.SelectionRange = new SelectionRange(new DateTime(2025, 1, 1, 0, 0, 0, 0), new DateTime(2025, 1, 7, 0, 0, 0, 0));
            monthCalendar1.TabIndex = 4;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(136, 320);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(203, 27);
            txtFname.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(36, 320);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(97, 23);
            label3.TabIndex = 5;
            label3.Text = "First Name:";
            // 
            // txtLname
            // 
            txtLname.Location = new Point(493, 320);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(203, 27);
            txtLname.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(394, 320);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(95, 23);
            label4.TabIndex = 7;
            label4.Text = "Last Name:";
            // 
            // dbPaspor
            // 
            dbPaspor.AutoSize = true;
            dbPaspor.Location = new Point(191, 370);
            dbPaspor.Name = "dbPaspor";
            dbPaspor.Size = new Size(80, 24);
            dbPaspor.TabIndex = 10;
            dbPaspor.TabStop = true;
            dbPaspor.Text = "Passpor";
            dbPaspor.UseVisualStyleBackColor = true;
            dbPaspor.CheckedChanged += dbPaspor_CheckedChanged;
            // 
            // rbIdcard
            // 
            rbIdcard.AutoSize = true;
            rbIdcard.Location = new Point(277, 369);
            rbIdcard.Name = "rbIdcard";
            rbIdcard.Size = new Size(80, 24);
            rbIdcard.TabIndex = 11;
            rbIdcard.TabStop = true;
            rbIdcard.Text = "ID Card";
            rbIdcard.UseVisualStyleBackColor = true;
            rbIdcard.CheckedChanged += rbIdcard_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(36, 370);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(140, 23);
            label5.TabIndex = 9;
            label5.Text = "Travel Document";
            // 
            // txtDocNo
            // 
            txtDocNo.Location = new Point(493, 366);
            txtDocNo.Name = "txtDocNo";
            txtDocNo.Size = new Size(203, 27);
            txtDocNo.TabIndex = 13;
            // 
            // lblDocNo
            // 
            lblDocNo.AutoSize = true;
            lblDocNo.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDocNo.Location = new Point(369, 370);
            lblDocNo.Name = "lblDocNo";
            lblDocNo.RightToLeft = RightToLeft.No;
            lblDocNo.Size = new Size(118, 23);
            lblDocNo.TabIndex = 12;
            lblDocNo.Text = "Document No";
            // 
            // lblIssueDate
            // 
            lblIssueDate.AutoSize = true;
            lblIssueDate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIssueDate.Location = new Point(36, 418);
            lblIssueDate.Name = "lblIssueDate";
            lblIssueDate.RightToLeft = RightToLeft.No;
            lblIssueDate.Size = new Size(178, 23);
            lblIssueDate.TabIndex = 14;
            lblIssueDate.Text = "Document Issue Date:";
            // 
            // issueDate
            // 
            issueDate.Location = new Point(220, 418);
            issueDate.Name = "issueDate";
            issueDate.Size = new Size(250, 27);
            issueDate.TabIndex = 15;
            issueDate.ValueChanged += issueDate_ValueChanged;
            // 
            // lblExpiryDate
            // 
            lblExpiryDate.AutoSize = true;
            lblExpiryDate.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpiryDate.Location = new Point(36, 465);
            lblExpiryDate.Name = "lblExpiryDate";
            lblExpiryDate.RightToLeft = RightToLeft.No;
            lblExpiryDate.Size = new Size(188, 23);
            lblExpiryDate.TabIndex = 16;
            lblExpiryDate.Text = "Document Expiry Date:";
            // 
            // ExpiryDate
            // 
            ExpiryDate.Location = new Point(230, 462);
            ExpiryDate.Name = "ExpiryDate";
            ExpiryDate.Size = new Size(250, 27);
            ExpiryDate.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(36, 514);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(77, 23);
            label9.TabIndex = 18;
            label9.Text = "Baggage";
            // 
            // numBaggage
            // 
            numBaggage.Location = new Point(121, 514);
            numBaggage.Name = "numBaggage";
            numBaggage.Size = new Size(150, 27);
            numBaggage.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(280, 514);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.No;
            label10.Size = new Size(37, 23);
            label10.TabIndex = 20;
            label10.Text = "Kgs";
            // 
            // btnBook
            // 
            btnBook.Location = new Point(36, 562);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(660, 52);
            btnBook.TabIndex = 21;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = true;
            btnBook.Click += btnBook_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 623);
            Controls.Add(btnBook);
            Controls.Add(label10);
            Controls.Add(numBaggage);
            Controls.Add(label9);
            Controls.Add(ExpiryDate);
            Controls.Add(lblExpiryDate);
            Controls.Add(issueDate);
            Controls.Add(lblIssueDate);
            Controls.Add(txtDocNo);
            Controls.Add(lblDocNo);
            Controls.Add(rbIdcard);
            Controls.Add(dbPaspor);
            Controls.Add(label5);
            Controls.Add(txtLname);
            Controls.Add(label4);
            Controls.Add(txtFname);
            Controls.Add(label3);
            Controls.Add(monthCalendar1);
            Controls.Add(txtFrom);
            Controls.Add(txtTo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numBaggage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTo;
        private TextBox txtFrom;
        private MonthCalendar monthCalendar1;
        private TextBox txtFname;
        private Label label3;
        private TextBox txtLname;
        private Label label4;
        private RadioButton dbPaspor;
        private RadioButton rbIdcard;
        private Label label5;
        private TextBox txtDocNo;
        private Label lblDocNo;
        private Label lblIssueDate;
        private DateTimePicker issueDate;
        private Label lblExpiryDate;
        private DateTimePicker ExpiryDate;
        private Label label9;
        private NumericUpDown numBaggage;
        private Label label10;
        private Button btnBook;
    }
}
