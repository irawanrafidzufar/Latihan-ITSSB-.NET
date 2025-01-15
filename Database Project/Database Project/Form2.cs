using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Database_Project
{
    public partial class Form2 : Form
    {
        DBAccess db = new DBAccess();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtName.Text = SignIn.name;
            txtEmail.Text = SignIn.emaill;
            txtPass.Text = SignIn.pass;
            cbCountry.Text = SignIn.country;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nameUpdate = txtName.Text;
            String emailUpdate = txtEmail.Text;
            String passUpdate = txtPass.Text;
            String countryUpdate = cbCountry.Text;

            if (nameUpdate.Equals("") && emailUpdate.Equals("") && passUpdate.Equals("") && countryUpdate.Equals(""))
            {
                MessageBox.Show("Silahkan Lengkapi Kredensial Terlebih Dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String query = "UPDATE users SET name = '" + @nameUpdate + "', email = '" + @emailUpdate + "', password = '" + @passUpdate + "', country = '" + @countryUpdate + "' WHERE id = '" + SignIn.id + "'";

                SqlCommand update = new SqlCommand(query);

                update.Parameters.AddWithValue("nameUpdate", nameUpdate);
                update.Parameters.AddWithValue("emailUpdate", emailUpdate);
                update.Parameters.AddWithValue("passUpdate", passUpdate);
                update.Parameters.AddWithValue("countryUpdate", countryUpdate);

                int row = db.executeQuery(update);

                if (row == 1)
                {
                    MessageBox.Show("Berhasil Update Akun!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    SignIn form = new SignIn();
                    form.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Tidak Berhasil Mengupdate Akun. Terjadi Kesalahan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah anda yakin?", "Peringatan", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                String query = "DELETE FROM users WHERE id = '" + SignIn.id + "'";

                SqlCommand delete = new SqlCommand(query);

                int row = db.executeQuery(delete);
                if (row == 1)
                {
                    MessageBox.Show("Berhasil Menghapus Akun!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tidak Berhasil Mendelete Akun. Terjadi Kesalahan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
