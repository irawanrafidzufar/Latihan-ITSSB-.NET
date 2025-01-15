using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Database_Project
{
    public partial class CommandBuilderForm : Form
    {
        DBAccess db = new DBAccess();
        DataTable tb = new DataTable();
        public CommandBuilderForm()
        {
            InitializeComponent();
        }

        private void CommandBuilderForm_Load(object sender, EventArgs e)
        {
            String query = "SELECT * FROM users";

            db.readDataThroughAdapter(query, tb);

            dataGridView1.DataSource = tb;

            db.closeCon();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM users";

            int change = db.executeDataAdapter(tb, query);

            MessageBox.Show("Change = " + change);
        }
    }
}
