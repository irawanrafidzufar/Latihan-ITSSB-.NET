namespace Flight_Booking_App
{
    public partial class Form1 : Form
    {
        public static Boolean paspor, idcard;
        public static String from, to, startdate, enddate, fname, lname, traveldoc, docno, issuedate, expirydate, baggage;
        public Form1()
        {
            InitializeComponent();
        }

        private void dbPaspor_CheckedChanged(object sender, EventArgs e)
        {
            if (dbPaspor.Checked)
            {
                lblDocNo.Text = "Passport No:";
                lblExpiryDate.Text = "Passport Expiry Date:";
                lblIssueDate.Text = "Passport Issue Date:";

                paspor = true;
            }
        }

        private void rbIdcard_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIdcard.Checked)
            {
                lblDocNo.Text = "Id Card No:";
                lblExpiryDate.Text = "Id Card Expiry Date:";
                lblIssueDate.Text = "Id Card Issue Date:";

                idcard = true;
            }
        }

        private void issueDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = issueDate.Value;
            ExpiryDate.MinDate = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 100;
            monthCalendar1.ShowToday = true;

            numBaggage.Increment = 5;
            numBaggage.ReadOnly = true;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            
            from = txtFrom.Text;
            to = txtTo.Text;

            startdate = monthCalendar1.SelectionStart.ToString("dd MMM yyyy");
            enddate = monthCalendar1.SelectionEnd.ToString("dd MMM yyyy");

            fname = txtFname.Text;
            lname = txtLname.Text;
            
            if(paspor = true)
            {
                traveldoc = dbPaspor.Text;
            } else if(idcard = true)
            {
                traveldoc = rbIdcard.Text;
            }
            else
            {
                MessageBox.Show("Silahkan lengkapi pengisian!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            docno = txtDocNo.Text;
            issuedate = issueDate.Value.ToLongDateString();
            expirydate = ExpiryDate.Value.ToLongDateString();

            baggage = numBaggage.Value.ToString();

            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
    }
}
