using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight_Booking_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtName.Text = (Form1.fname) + " " + (Form1.lname);
            txtDeparture.Text = Form1.from;
            txtDestination.Text = Form1.to;
            txtTripDate.Text = (Form1.startdate) + " to " + (Form1.enddate);
            txtDocNo.Text = Form1.docno;
            txtIssue.Text = Form1.issuedate;
            txtExpiry.Text = Form1.expirydate;
            txtBaggage.Text = Form1.baggage;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
