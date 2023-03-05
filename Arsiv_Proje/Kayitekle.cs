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
    public partial class Kayitekle : Form
    {
        public Kayitekle()
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
            SqlConnection baglanti = new SqlConnection("Data Source=305-08;Initial Catalog=Arsiv;Persist Security Info=True;User ID=WebMobile_302; Password=webmobile.302");
            SqlCommand kmt = new SqlCommand("insert into Evrak(Evrak_Ad, Dosya_ID, Klasor_ID, Raf_ID, Bolum_ID, Oda_ID,[Dosya Adı],[Klasör Adı],[Raf Adı],[Bölüm Adı],[Oda Adı]) " +
                "values (@evrakadi,@dosyaıd,@klasorıd,@rafıd,@bolumıd,@odaıd,@dosyaadi,@klasoradi,@rafadi,@bolumadi,@odaadi");
            
            
            baglanti.Open();
            string kayit = "insert into Evrak(Evrak_Ad,Dosya_ID,Klasor_ID,Raf_ID,Bolum_ID,Oda_ID) " +
                "values (@evrakadi,@dosyaıd,@klasorıd,@rafıd,@bolumıd,@odaıd)";
            
            SqlCommand komut = new SqlCommand(kayit, baglanti);
            
            komut.Parameters.AddWithValue("@evrakadi", yenievrakadi.Text);
            komut.Parameters.AddWithValue("@dosyaıd", comboBox_dosyaID.Text);
            komut.Parameters.AddWithValue("@klasorıd", comboBox_klasorID.Text);
            komut.Parameters.AddWithValue("@rafıd", comboBox_rafID.Text);
            komut.Parameters.AddWithValue("@bolumıd", comboBox_bolumID.Text);
            komut.Parameters.AddWithValue("@odaıd", comboBox_odaID.Text);


            
            komut.ExecuteNonQuery();
            
            baglanti.Close();
            DialogResult sonuc = MessageBox.Show("Kayıt İşlemi Gerçekleşmiştir.", "Kaydedildi", MessageBoxButtons.OKCancel);
            getDats("Select * from Evrak");

        }

        private void yeniodanumarasi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void geri_gel_Click(object sender, EventArgs e)
        {
            Islemler islm = new Islemler();
            islm.Show();
            this.Hide();
        }

        private void Kayitekle_Load(object sender, EventArgs e)
        {
            getDats("Select * from Evrak");
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            text_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            yenievrakadi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox_dosyaID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox_klasorID.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox_rafID.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBox_bolumID.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox_odaID.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
