using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.Model;
using Microsoft.EntityFrameworkCore;


namespace rent_a_car
{
    public partial class MusteriIslemleri : Form
    {
        public MusteriIslemleri()
        {
            InitializeComponent();
            try
            {
                dataGridView1.DataSource = (from s in db.Musteri
                                            select new
                                            {
                                                MüşteriID = s.MusteriId,
                                                TCkimlikNo = s.Tcno,
                                                s.Ad,
                                                s.Soyad,
                                                DoğumTarihi = s.DogumTarih,
                                                s.CepTel,
                                                s.EvısTel,
                                                s.Adres,
                                                s.EhliyetNo,
                                                s.EhliyetTuru,
                                                s.Notlar

                                            }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        rentacarContext db = new rentacarContext();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.ShowDialog();

            pictureBox1.ImageLocation = openFileDialog1.FileName;



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MusteriIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Musteri mst = new Musteri();
            Person per = new Person();
            try
            {
                using (db)
                {
                    mst.Ad = tbAd.Text.Trim();
                    mst.Soyad = tbAd.Text.Trim();
                    per.Tcno = Convert.ToInt32(tbTC.Text.Trim());
                    mst.DogumTarih = Convert.ToDateTime(tbDogumTarih.Text.Trim());
                    mst.CepTel = Convert.ToInt32(tbCepTel.Text.Trim());
                    mst.EvısTel = Convert.ToInt32(tbEvIsTel.Text.Trim());
                    mst.Email = tbEmail.Text.Trim();
                    mst.Adres = tbAdres.Text.Trim();
                    mst.EhliyetNo = Convert.ToInt32(tbEhliyetNo.Text.Trim());
                    mst.EhliyetTuru = tbEhliyetTuru.Text.Trim();
                    mst.Notlar = tbNotlar.Text.Trim();
                    if (tbAd.Text==null||tbSoyAd.Text==null||tbTC.Text==null||tbDogumTarih.Text==null||tbCepTel.Text==null||tbEvIsTel.Text==null||tbEmail.Text==null||tbAdres.Text==null||tbEhliyetNo.Text==null||tbEhliyetTuru.Text==null)
                    {
                        lblMesaj.Text = "Boş alanları doldurnuz.";
                        lblMesaj.ForeColor = Color.Red;
                    }
                    else
                    {
                        db.Musteri.Add(mst);
                        db.SaveChanges();
                        lblMesaj.Text = "Başarılı";
                        lblMesaj.ForeColor = Color.Green;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (ex.InnerException!=null)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
            dataGridView1.DataSource = (from s in db.Musteri
                                        select new
                                        {
                                            MüşteriID = s.MusteriId,
                                            TCkimlikNo = s.Tcno,
                                            s.Ad,
                                            s.Soyad,
                                            DoğumTarihi = s.DogumTarih,
                                            s.CepTel,
                                            s.EvısTel,
                                            s.Adres,
                                            s.EhliyetNo,
                                            s.EhliyetTuru,
                                            s.Notlar

                                        }).ToList();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAd_TextChanged(object sender, EventArgs e)
        {

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
            Ayarlar ayarlar = new  Ayarlar();
            ayarlar.Show();
        }
    }
}
