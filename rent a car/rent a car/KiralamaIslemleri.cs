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
using Microsoft.EntityFrameworkCore;

namespace rent_a_car
{
    public partial class KiralamaIslemleri : Form
    {
        public KiralamaIslemleri()
        {
            InitializeComponent();
            dataGridView1.DataSource = (from s in db.Musteri
                                        select new
                                        {
                                            MüşteriID = s.MusteriId,
                                            TCkimlikNo = s.Tcno,
                                            s.Ad,
                                            s.Soyad,
                                            s.CepTel
                                        }).ToList();
            dataGridView2.DataSource = (from s in db.Araba
                                        select new
                                        {
                                            s.Plaka,
                                            s.Marka,
                                            s.Model,
                                            s.Yıl
                                        }).ToList();
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
        Araba car = new Araba();
        rentacarContext db = new rentacarContext();
        Musteri mst = new Musteri();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                car.Plaka=tbPlaka.Text.Trim();
                car.Model = tbModel.Text.Trim();
                car.Marka = tbMarka.Text.Trim();
                car.Yıl = Convert.ToInt32(tbYıl.Text.Trim());

                mst.Ad = tbAd.Text.Trim();
                //mst.Tcno=tbTC.Text.Trim();
                mst.Soyad = tbSoyad.Text.Trim();
                mst.CepTel = Convert.ToInt32(tbCeptel.Text.Trim());
                if (tbPlaka.Text==null || tbModel.Text == null || tbMarka.Text == null || tbAd.Text == null || tbSoyad.Text == null || tbCeptel.Text == null)
                {
                    lblMessage.Text = "Lütfen Boş yerleri giriniz";
                    lblMessage.ForeColor = Color.Red;
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void KiralamaIslemleri_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            tbAd.Text= dataGridView1.Rows[sec].Cells[0].Value.ToString();
            tbSoyad.Text= dataGridView1.Rows[sec].Cells[1].Value.ToString();
            tbTC.Text= dataGridView1.Rows[sec].Cells[2].Value.ToString();
            tbCeptel.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();

            
            
            tbPlaka.Text = dataGridView2.Rows[sec].Cells[0].Value.ToString();
            tbMarka.Text = dataGridView2.Rows[sec].Cells[1].Value.ToString();
            tbModel.Text = dataGridView2.Rows[sec].Cells[2].Value.ToString();
            tbYıl.Text = dataGridView2.Rows[sec].Cells[3].Value.ToString();


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
