using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lavanta_Pansiyonn
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnOda101_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "101";
        }

        private void btnOda102_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "102";

        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "103";
        }

        private void btnOda104_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "104";
        }

        private void btnOda105_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "105";
        }

        private void btnOda106_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "106";
        }

        private void btnOda107_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "107";
        }

        private void btnOda108_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "108";
        }

        private void btnOda109_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "109";
        }

        private void btnDoluOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Renkli Odalar Doludur!");
        }

        private void btnBosOda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Renkli Odalar Boştur");
        }

        private void dtpCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(dtpGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(dtpCikisTarihi.Text);

            TimeSpan Sonuc;
            Sonuc = BuyukTarih - KucukTarih;

            label9.Text = Sonuc.TotalDays.ToString();
            Ucret = Convert.ToInt32(label9.Text) * 50;
            txtUcret.Text = Ucret.ToString();
        }
    }
}
