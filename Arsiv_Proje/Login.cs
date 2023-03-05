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
    public partial class GirisYap : Form
    {
        public GirisYap()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=305-08;Initial Catalog=Arsiv;Persist Security Info=True;User ID=WebMobile_302; Password=webmobile.302");
        SqlCommand kmt;
        SqlDataReader dr;
        private void GirisYap_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=305-08;Initial Catalog=Arsiv;Persist Security Info=True;User ID=WebMobile_302; Password=webmobile.302");
            baglanti.Open();
        }

        private void btn_girisyap_girisyap_Click(object sender, EventArgs e)
        {
            if (txt_kullaniciadi_girisyap.Text != String.Empty || txt_sifre_girisyap.Text != String.Empty)
            {
                kmt = new SqlCommand("select * from Kullanici where Kullanici_Adi='" + txt_kullaniciadi_girisyap.Text + "' and Kullanici_Sifre='" + txt_sifre_girisyap.Text + "'", baglanti);
                dr = kmt.ExecuteReader();

                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();

                    MenuArsiv mnarsv = new MenuArsiv();

                    mnarsv.Show();
                    this.Hide();


                }
                else
                {
                    dr.Close();
                    MessageBox.Show("kullanıcı ve şifre ile Giriş Yapılamadı!!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }



            }
            else
            {
                MessageBox.Show("tum alanları dogru bir sekılde doldurunuz ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
