using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Arsiv_Proje
{
    public partial class KayitSil : Form
    {
        public KayitSil()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=305-08;Initial Catalog=Arsiv;Persist Security Info=True;User ID=WebMobile_302; Password=webmobile.302");

        public void getDats(string veri)
        {
            SqlDataAdapter da = new SqlDataAdapter(veri, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void sql_kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("delete from Evrak where Evrak_ID=@id",baglanti);
            kmt.Parameters.AddWithValue("@id", text_ID.Text);
            kmt.ExecuteNonQuery();
            baglanti.Close();
            getDats("select * from Evrak ");

        }

        private void geri_gel_Click(object sender, EventArgs e)
        {
            Islemler islm= new Islemler();
            islm.Show();
            this.Hide();
        }

        private void KayitSil_Load(object sender, EventArgs e)
        {
            getDats("select * from Evrak ");
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("select * from Evrak", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(kmt);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox_evrakAd.ValueMember = "Evrak_ID";
            comboBox_evrakAd.DisplayMember = "Evrak_Ad";
            comboBox_evrakAd.DataSource = dt;
            baglanti.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            text_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox_evrakAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox_dosyaID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox_klasorID.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox_rafID.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox_bolumID.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox_odaID.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
