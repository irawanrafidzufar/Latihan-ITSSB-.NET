namespace Date_Time_Picker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void set_Click(object sender, EventArgs e)
        {
            lbldatetime.Text = dateTimePicker1.Value.ToString();
            lbldate.Text = dateTimePicker1.Value.ToShortDateString();
            lbl3dateday.Text = dateTimePicker1.Value.ToLongDateString();
            lbl4time.Text = dateTimePicker1.Value.ToShortTimeString();
            lbltimesecond.Text = dateTimePicker1.Value.ToLongTimeString();
        }
    }
}
