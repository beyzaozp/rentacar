using DAL.Model;
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
    public partial class AracIslemleri : Form
    {
        public AracIslemleri()
        {
            InitializeComponent();
        }

        private void AracIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.ShowDialog();

            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            rentacarContext db = new rentacarContext();
            Araba car = new Araba();
            car.Plaka = tbPlaka.Text.Trim();
            car.Marka = tbMarka.Text.Trim ();
            car.Model = tbModel.Text.Trim();
            car.Kilometre = tbKM.Text.Trim();
            if (cbYakıt.SelectedIndex==0)
            {
                car.Yakıt = "Benzin";
            }
            else if (cbYakıt.SelectedIndex == 1)
            {
                car.Yakıt = "LPG";

            }
            else if (cbYakıt.SelectedIndex == 2)
            {
                car.Yakıt = "IPG";
            }
            else
            {
                car.Yakıt = "Hibrit";
            }

            if (cbVites.SelectedIndex == 0)
            {
                car.Vites = "Otomatik";
            }
            else
            {
                car.Vites = "Manuel";
            }

          
            if (cbMotor.SelectedIndex == 0)
            {
                car.MotorGücü = "1000CC";
            }
            else if (cbMotor.SelectedIndex == 1)
            {
                car.MotorGücü = "2000CC";
            }
            else if (cbMotor.SelectedIndex == 2)
            {
                car.MotorGücü = "3000CC";
            }
            else if (cbMotor.SelectedIndex == 3)
            {
                car.MotorGücü = "4000CC";
            }
            else 
            {
                car.MotorGücü = ">5000CC";
            }


            if (cbkapı.SelectedIndex == 0)
            {
                car.Kapı = "4 kapı standart";
            }
            else
            {
                car.Kapı = "Tek kapı";
            }

            if (cbHasar.SelectedIndex==0)
            {

                car.Renk = "Beyaz";
             }
            if (cbHasar.SelectedIndex == 1)
            {

                car.Renk = "Siyah";
            }
            if (cbHasar.SelectedIndex == 2)
            {

                car.Renk = "Kırmızı";
            }
            if (cbHasar.SelectedIndex == 3)
            {

                car.Renk = "Sarı";
            }
            if (cbHasar.SelectedIndex == 4)
            {

                car.Renk = "Lacivert";
            }
            else
            {
                car.Renk = "Gri";
            }


        }

        private void cbVites_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
