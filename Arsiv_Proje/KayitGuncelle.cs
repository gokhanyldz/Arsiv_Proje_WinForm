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
    public partial class KayitGuncelle : Form
    {
        public KayitGuncelle()
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
        private void geri_gel_Click(object sender, EventArgs e)
        {
            Islemler islm = new Islemler();
            islm.Show();
            this.Hide();
        }

        private void sql_guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("update Evrak set Evrak_Ad=@a1,Dosya_ID=@a2,Klasor_ID=@a3,Raf_ID=@a4,Bolum_ID=@a5,Oda_ID=@a6 where Evrak_ID=@id", baglanti);
            kmt.Parameters.AddWithValue("@id", text_evrakID.Text);
            kmt.Parameters.AddWithValue("@a1", yenievrakadi.Text);
            kmt.Parameters.AddWithValue("@a2", combobox_dosyaID.Text);
            kmt.Parameters.AddWithValue("@a3", combobox_klasorID.Text);
            kmt.Parameters.AddWithValue("@a4", combobox_rafID.Text);
            kmt.Parameters.AddWithValue("@a5", combobox_bolumID.Text);
            kmt.Parameters.AddWithValue("@a6", combobox_odaID.Text);

            kmt.ExecuteNonQuery();
            baglanti.Close();
        }

        private void KayitGuncelle_Load(object sender, EventArgs e)
        {
            getDats("select * from Evrak ");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            text_evrakID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            yenievrakadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            combobox_dosyaID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            combobox_klasorID.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            combobox_rafID.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            combobox_bolumID.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            combobox_odaID.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();



        }
    }
}
