using System.Data;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        DataTable dtClinic = new DataTable();
        DataTable dtDoctor = new DataTable();
        DataTable dtSpecificClinicDoctor = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillClinicTable();
            FillDoctorTable();

            comboBox1.DataSource = dtClinic;
            comboBox1.DisplayMember = "CName";
        }

        private void FillClinicTable()
        {
            dtClinic.Columns.Add("CID", typeof(int));
            dtClinic.Columns.Add("CName");
            dtClinic.Columns.Add("CAddress");
            dtClinic.Columns.Add("CRating");

            dtClinic.Rows.Add(1, "Dentist Pro Clinic", "Palm Beach Florida", "7/10");
            dtClinic.Rows.Add(2, "Muhammad Ali's Clinic", "Blue Shore", "9/10");
            dtClinic.Rows.Add(3, "Suramadu Clinic", "Lombok", "8/10");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = dtClinic.Rows[comboBox1.SelectedIndex]["CName"].ToString();
            label3.Text = dtClinic.Rows[comboBox1.SelectedIndex]["CAddress"].ToString();
            label4.Text = dtClinic.Rows[comboBox1.SelectedIndex]["CRating"].ToString();

            dtSpecificClinicDoctor = dtDoctor.Select("CID = " + dtClinic.Rows[comboBox1.SelectedIndex]["CID"]).CopyToDataTable();

            comboBox2.DataSource = dtSpecificClinicDoctor;
            comboBox2.DisplayMember = "DName";
        }  

        private void FillDoctorTable()
        {
            dtDoctor.Columns.Add("CID", typeof(int));
            dtDoctor.Columns.Add("DName");
            dtDoctor.Columns.Add("DSpeciality");
            dtDoctor.Columns.Add("DContact");

            dtDoctor.Rows.Add(1, "Rahmat Abdul", "Dentist", "872639172");
            dtDoctor.Rows.Add(1, "Muhammad Ali", "Saraf Otak", "123745912");
            dtDoctor.Rows.Add(1, "Mery Irwan", "Dokter Anak", "36518293");
            dtDoctor.Rows.Add(2, "Raiden Mei", "Perawat Kecantikan", "51352134");
            dtDoctor.Rows.Add(2, "Kiana Kaslana", "Dokter Tulang", "9341773431");
            dtDoctor.Rows.Add(2, "Ferry Irwandi", "Dokter Saraf", "7431638123");
            dtDoctor.Rows.Add(3, "Muhammad Al Gaza", "Dokter Bedah", "4134314");
            dtDoctor.Rows.Add(3, "Faris Baswedan", "Doktor anak", "55381923");
            dtDoctor.Rows.Add(3, "Vivi", "Dokter Bedah", "87612347");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtdoctorname.Text = dtDoctor.Rows[comboBox2.SelectedIndex]["DName"].ToString();
            txtspeciality.Text = dtDoctor.Rows[comboBox2.SelectedIndex]["DSpeciality"].ToString();
            txtcontact.Text = dtDoctor.Rows[comboBox2.SelectedIndex]["DContact"].ToString();
        }
    }
}
