using System.Data;
using Microsoft.Data.SqlClient;

namespace Econtact
{
    public partial class Form1 : Form
    {
        DBAccess db = new DBAccess();
        DataTable dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filldata();

            int count = (dt.Rows.Count) + 1;

            txtid.Text = count.ToString();
        }

        private void txtadd_Click(object sender, EventArgs e)
        {
            String id = txtid.Text;
            String fname = txtfname.Text;
            String lname = txtlname.Text;
            String contactNo = txtno.Text;
            String address = txtaddress.Text;
            String gender = cbGender.Text;

            if (id.Equals("") && fname.Equals("") && lname.Equals("") && contactNo.Equals("") && address.Equals("") && gender.Equals(""))
            {
                MessageBox.Show("Data tidak lengkap! Harap lengkapi data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String query = "INSERT INTO contact(contactID, firstName, lastName, contactNo, address, gender) VALUES (@contactID, @firstname, @lastname, @contactNo, @address, @gender)";

                SqlCommand cmd = new SqlCommand(query);

                cmd.Parameters.AddWithValue("contactID", id);
                cmd.Parameters.AddWithValue("firstname", fname);
                cmd.Parameters.AddWithValue("lastname", lname);
                cmd.Parameters.AddWithValue("contactNo", contactNo);
                cmd.Parameters.AddWithValue("address", address);
                cmd.Parameters.AddWithValue("gender", gender);

                db.executeQuery(cmd);

                filldata();
            }
        }

        private void filldata()
        {
            String query = "SELECT * FROM contact";

            dt.Clear();

            db.readDataThroughAdapter(query, dt);

            dataGridView1.DataSource = dt;

            db.closedCon();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah Anda Yakin?", "Peringatan", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                String query = "DELETE FROM contact WHERE contactID = '" + txtid.Text + "'";

                SqlCommand cmd = new SqlCommand(query);

                db.executeQuery(cmd);

                filldata();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow currentRow = dataGridView1.CurrentRow;

            txtid.Text = currentRow.Cells["contactID"].Value.ToString();
            txtfname.Text = currentRow.Cells["firstname"].Value.ToString();
            txtlname.Text = currentRow.Cells["lastname"].Value.ToString();
            txtno.Text = currentRow.Cells["contactNo"].Value.ToString();
            txtaddress.Text = currentRow.Cells["address"].Value.ToString();
            String gender = currentRow.Cells["gender"].Value.ToString();

            if (gender.Equals("Male"))
            {
                cbGender.SelectedIndex = 0;
            }
            else if (gender.Equals("Female"))
            {
                cbGender.SelectedIndex = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String id = txtid.Text;
            String fname = txtfname.Text;
            String lname = txtlname.Text;
            String contactNo = txtno.Text;
            String address = txtaddress.Text;
            String gender = cbGender.Text;

            if (id.Equals("") && fname.Equals("") && lname.Equals("") && contactNo.Equals("") && address.Equals("") && gender.Equals(""))
            {
                MessageBox.Show("Data tidak lengkap! Harap lengkapi data!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String query = "UPDATE contact SET firstname = '" + fname + "', lastname = '" + lname + "', contactNo = '" + contactNo + "', address = '" + address + "', gender = '" + gender + "' WHERE contactID = '" + id + "'";

                SqlCommand cmd = new SqlCommand(query);

                db.executeQuery(cmd);

                filldata();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtlname.Text = "";
            txtfname.Text = "";
            txtno.Text = "";
            txtaddress.Text = "";
            cbGender.Text = "";

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            String query = "SELECT * FROM contact WHERE firstname LIKE '%"+txtsearch.Text+"%' OR lastname LIKE '%"+txtsearch.Text+"%'";

            dt.Clear();

            db.readDataThroughAdapter(query, dt);

            dataGridView1.DataSource = dt;

            db.closedCon();
        }
    }
}
