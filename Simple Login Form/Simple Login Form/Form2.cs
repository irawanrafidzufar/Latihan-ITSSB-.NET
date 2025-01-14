using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Login_Form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                login();
            }
        }

        private void login()
        {
            String nama = textBox1.Text.ToString();
            String pass = textBox2.Text.ToString();

            String namaR = "user";
            String passR = "admin";

            if (nama.Equals(namaR) && pass.Equals(passR))
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Password atau Username Salah!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                textBox2.Select();
            }
        }
    }
}
