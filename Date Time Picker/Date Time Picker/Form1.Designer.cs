namespace Date_Time_Picker
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
            dateTimePicker1 = new DateTimePicker();
            lbldatetime = new Label();
            lbldate = new Label();
            lbl3dateday = new Label();
            lbl4time = new Label();
            lbltimesecond = new Label();
            set = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 12F);
            dateTimePicker1.Location = new Point(48, 20);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(705, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // lbldatetime
            // 
            lbldatetime.AutoSize = true;
            lbldatetime.Font = new Font("Segoe UI", 20F);
            lbldatetime.Location = new Point(48, 79);
            lbldatetime.Name = "lbldatetime";
            lbldatetime.Size = new Size(109, 46);
            lbldatetime.TabIndex = 1;
            lbldatetime.Text = "label1";
            // 
            // lbldate
            // 
            lbldate.AutoSize = true;
            lbldate.Font = new Font("Segoe UI", 20F);
            lbldate.Location = new Point(48, 143);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(109, 46);
            lbldate.TabIndex = 2;
            lbldate.Text = "label1";
            // 
            // lbl3dateday
            // 
            lbl3dateday.AutoSize = true;
            lbl3dateday.Font = new Font("Segoe UI", 20F);
            lbl3dateday.Location = new Point(48, 213);
            lbl3dateday.Name = "lbl3dateday";
            lbl3dateday.Size = new Size(109, 46);
            lbl3dateday.TabIndex = 3;
            lbl3dateday.Text = "label1";
            // 
            // lbl4time
            // 
            lbl4time.AutoSize = true;
            lbl4time.Font = new Font("Segoe UI", 20F);
            lbl4time.Location = new Point(48, 283);
            lbl4time.Name = "lbl4time";
            lbl4time.Size = new Size(109, 46);
            lbl4time.TabIndex = 4;
            lbl4time.Text = "label1";
            // 
            // lbltimesecond
            // 
            lbltimesecond.AutoSize = true;
            lbltimesecond.Font = new Font("Segoe UI", 20F);
            lbltimesecond.Location = new Point(48, 353);
            lbltimesecond.Name = "lbltimesecond";
            lbltimesecond.Size = new Size(109, 46);
            lbltimesecond.TabIndex = 5;
            lbltimesecond.Text = "label1";
            // 
            // set
            // 
            set.Location = new Point(642, 405);
            set.Name = "set";
            set.Size = new Size(146, 48);
            set.TabIndex = 6;
            set.Text = "Set";
            set.UseVisualStyleBackColor = true;
            set.Click += set_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 465);
            Controls.Add(set);
            Controls.Add(lbltimesecond);
            Controls.Add(lbl4time);
            Controls.Add(lbl3dateday);
            Controls.Add(lbldate);
            Controls.Add(lbldatetime);
            Controls.Add(dateTimePicker1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label lbldatetime;
        private Label lbldate;
        private Label lbl3dateday;
        private Label lbl4time;
        private Label lbltimesecond;
        private Button set;
    }
}
