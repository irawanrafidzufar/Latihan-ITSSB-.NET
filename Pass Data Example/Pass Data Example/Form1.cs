namespace Pass_Data_Example
{
    public partial class Form1 : Form
    {
        public static String firstname, lastname, emailaddress;
        public static Boolean sms, report, transaction;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstname = fname.Text.ToString();
            lastname = lname.Text.ToString();
            emailaddress = email.Text.ToString();

            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                sms = true;
            }
            else
            {
                sms = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                report = true;
            }
            else
            {
                report = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                transaction = true;
            }
            else
            {
                transaction = false;
            }
        }
    }
}
