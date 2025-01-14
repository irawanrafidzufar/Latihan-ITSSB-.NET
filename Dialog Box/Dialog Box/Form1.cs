namespace Dialog_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to purchase this services?", "Attention", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                label1.Text = "You have purchase this service!";
            }
            else if (dr == DialogResult.No)
            {
                label1.Text = "Good Bye!";
            } else if( dr == DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
