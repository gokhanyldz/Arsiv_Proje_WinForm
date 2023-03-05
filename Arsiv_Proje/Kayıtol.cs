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
    public partial class Kayıtol : Form
    {
        public Kayıtol()
        {
            InitializeComponent();
        }
        SqlConnection baglanti =  new SqlConnection("Data Source=305-08;Initial Catalog=Arsiv;Persist Security Info=True;User ID=WebMobile_302; Password=webmobile.302");
        SqlCommand kmt;
        SqlDataReader dr;

        private void btn_kayıtol_kayıtol_Click(object sender, EventArgs e)
        {
            if (txt_sifretekrari_kayitol.Text != String.Empty || txt_sifre_kayitol.Text != String.Empty || txt_kullaniciadi_kayitol.Text != String.Empty)
            {
                if (txt_sifre_kayitol.Text == txt_sifretekrari_kayitol.Text)
                {
                    kmt = new SqlCommand("select * from Kullanici where Kullanici_Adi='" + txt_kullaniciadi_kayitol.Text + "'", baglanti);
                    dr = kmt.ExecuteReader();

                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("zaten bu isim var lütfen baska isim gir", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {
                        dr.Close();

                        kmt = new SqlCommand("insert into Kullanici values(@username,@password)", baglanti);
                        kmt.Parameters.AddWithValue("@username", txt_kullaniciadi_kayitol.Text);
                        kmt.Parameters.AddWithValue("@password", txt_sifre_kayitol.Text);
                        kmt.ExecuteReader();

                        MessageBox.Show(" tebrıkler hesabınız olstruldu", "TAMAMLANDI", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }

                }
                else
                {
                    MessageBox.Show(" şifreler birbiri ile aynı olmak zorunda", "HATA!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show(" butun alanları doldurunuz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linklbl_geridon_kayitol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ArsivProjesi arsvprj = new ArsivProjesi();
            arsvprj.Show();
            this.Hide();
        }

        private void Kayıtol_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=305-08;Initial Catalog=Arsiv;Persist Security Info=True;User ID=WebMobile_302; Password=webmobile.302");
            baglanti.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GirisYap lgn = new GirisYap();

            lgn.Show();
            this.Hide();
        }
    }
}
