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
    public partial class ArsivProjesi : Form
    {
        public ArsivProjesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=305-08;Initial Catalog=Arsiv;Persist Security Info=True;User ID=WebMobile_302; Password=webmobile.302");
        SqlCommand kmt;
        SqlDataReader dr;

        private void btn_girisyap_Click(object sender, EventArgs e)
        {
            this.Hide();
            GirisYap login = new GirisYap();
            login.Show();
        }

        private void btn_kayitol_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kayıtol registration = new Kayıtol();
            registration.ShowDialog();
        }
    }
}
