using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arsiv_Proje
{
    public partial class Islemler : Form
    {
        public Islemler()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Kayıtara kayitara = new Kayıtara();
            kayitara.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kayitekle kayitekle= new Kayitekle();
            kayitekle.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KayitSil kayitsil = new KayitSil();
            kayitsil.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KayitGuncelle kayitGuncelle = new KayitGuncelle();
            kayitGuncelle.Show();
            this.Hide();
        }
    }
}
