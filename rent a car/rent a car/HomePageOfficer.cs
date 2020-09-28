using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rent_a_car
{
    public partial class HomePageOfficer : Form
    {
        public HomePageOfficer()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MusteriIslemleri musteriislemleri = new MusteriIslemleri();
            musteriislemleri.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AracIslemleri aracislemleri = new AracIslemleri();
            aracislemleri.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            KiralamaIslemleri kiralamaIslemleri = new KiralamaIslemleri();
            kiralamaIslemleri.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hakkında hakkında = new Hakkında();
            hakkında.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Raporlar raporlar = new Raporlar();
            raporlar.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.Show();
        }

        private void HomePageOfficer_Load(object sender, EventArgs e)
        {

        }
    }
}
