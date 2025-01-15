using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Project
{
    public partial class SignIn : Form
    {
        //insialisasi class dbaccess untuk mengakses database
        DBAccess db = new DBAccess();
        DataTable dt = new DataTable();

        public static String id, name, emaill, pass, country;
        public SignIn()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String email = txtemail.Text;
            String password = txtpass.Text;

            if (email.Equals("") && password.Equals(""))
            {
                MessageBox.Show("Mohon lengkapi kredensial yang masih kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String query = "SELECT * FROM users WHERE email = '" + email + "' AND password = '" + password + "'";

                db.readDataThroughAdapter(query, dt);

                if (dt.Rows.Count == 1)
                {
                    id = dt.Rows[0]["id"].ToString();
                    name = dt.Rows[0]["name"].ToString();
                    emaill = dt.Rows[0]["email"].ToString();
                    pass = dt.Rows[0]["password"].ToString();

                    MessageBox.Show("Kamu berhasil Login.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form2 form = new Form2();
                    form.Show();
                    this.Hide();
                }
                else if (dt.Rows.Count > 1)
                {
                    MessageBox.Show("Terjadi duplikasi Akun. Pastikan akun anda berbeda dari yang lain!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtemail.Text = "";
                    txtpass.Text = "";
                }
                else
                {
                    MessageBox.Show("Akun tidak ditemukan. Pastikan kredensial benar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtemail.Text = "";
                    txtpass.Text = "";
                }

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
