using Microsoft.Data.SqlClient;

namespace Database_Project
{
    public partial class Form1 : Form
    {
        DBAccess db = new DBAccess();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = txtName.Text;
            String email = txtEmail.Text;
            String password = txtPass.Text;
            String Country = cbCountry.Text;

            if (username.Equals("") && email.Equals("") && password.Equals("") && Country.Equals(""))
            {
                MessageBox.Show("Silahkan Masukkan kredensial dengan lengkap!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand insertcommand = new SqlCommand("Insert into users(name, email, password, country) Values (@username, @email, @password, @country);");

                insertcommand.Parameters.AddWithValue("username", username);
                insertcommand.Parameters.AddWithValue("email", email);
                insertcommand.Parameters.AddWithValue("password", password);
                insertcommand.Parameters.AddWithValue("country", Country);

                int row = db.executeQuery(insertcommand);

                if (row == 1)
                {
                    MessageBox.Show("Akun berhasil ditambahkan.");
                    Form2 form = new Form2();
                    form.Show();
                    this.Hide();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignIn form = new SignIn();
            form.Show();
            this.Hide();
        }
    }
}
