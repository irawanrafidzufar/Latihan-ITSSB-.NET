using System.Data;

namespace Course_App
{
    public partial class Form1 : Form
    {
        //Menginisialisasikan Data Table dtCourse
        private DataTable dtCourse = new DataTable();
        private DataTable SelectedCourse = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        //Memeberikan nilai kepada DataTable dtCourse
        private void FillCourse()
        {
            dtCourse.Columns.Add("CourseID", typeof(int));
            dtCourse.Columns.Add("CourseName");
            dtCourse.Columns.Add("CourseDuration");

            dtCourse.Rows.Add(1, "Informatika", "90 Jam");
            dtCourse.Rows.Add(2, "Machine Learning", "150 Jam");
            dtCourse.Rows.Add(3, "Deep Learning", "210 Jam");
            dtCourse.Rows.Add(4, "Pemrograman Web", "45 Jam");
            dtCourse.Rows.Add(5, "Cyber Security", "120 Jam");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillCourse();
            SelectedCourseTable();

            listBox1.DataSource = dtCourse;
            listBox1.DisplayMember = "CourseName";
            listBox2.DataSource = SelectedCourse;
            listBox2.DisplayMember = "CourseName";
        }

        //Menginisialisasikan nilai SelectedCourse DataTable
        private void SelectedCourseTable()
        {
            SelectedCourse.Columns.Add("CourseId", typeof(int));
            SelectedCourse.Columns.Add("CourseName");
            SelectedCourse.Columns.Add("CourseDuration");
        }

        //Button Add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                SelectedCourse.ImportRow(dtCourse.Rows[listBox1.SelectedIndex]);
                dtCourse.Rows[listBox1.SelectedIndex].Delete();
            }
        }

        //Button Remove
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                dtCourse.ImportRow(SelectedCourse.Rows[listBox2.SelectedIndex]);
                SelectedCourse.Rows[listBox2.SelectedIndex].Delete();
            }
        }

        //Add All Button
        private void btnAddAll_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                int count = dtCourse.Rows.Count;

                for (int i = count - 1; i >= 0; i--)
                {
                    SelectedCourse.ImportRow(dtCourse.Rows[listBox1.SelectedIndex]);
                    dtCourse.Rows[listBox1.SelectedIndex].Delete();
                }
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                int count = SelectedCourse.Rows.Count;

                for (int i = count - 1; i >= 0; i--)
                {
                    dtCourse.ImportRow(SelectedCourse.Rows[listBox2.SelectedIndex]);
                    SelectedCourse.Rows[listBox2.SelectedIndex].Delete();
                }
            }
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Apakah kamu yakin ingin mengambil Kursus ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                if(listBox2.Items.Count > 0)
                {
                    dataGridView1.DataSource = SelectedCourse;

                    dataGridView1.Enabled = false;
                    dataGridView1.Columns[0].Visible = false;
                    dataGridView1.RowHeadersVisible = false;

                    dataGridView1.Columns[1].Width = 400;
                    dataGridView1.Columns[2].Width = 400;
                }
                else
                {
                    MessageBox.Show("Tolong pilih kursus terlebih dahulu", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
