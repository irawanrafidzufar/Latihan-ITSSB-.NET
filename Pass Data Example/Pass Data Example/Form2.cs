using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass_Data_Example
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void fname_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fname.Text = Form1.firstname;
            lname.Text = Form1.lastname;
            email.Text = Form1.emailaddress;

            if (Form1.sms)
            {
                sms.Text = "✓";
            }

            if (Form1.report)
            {
                report.Text = "✓";
            }

            if (Form1.transaction)
            {
                transaction.Text = "✓";
            }
        }
    }
}
