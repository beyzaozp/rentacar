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
    public partial class ÇalısanEkle : Form
    {
        rentacarContext db;
        public ÇalısanEkle()
        {
            InitializeComponent();
            db = new rentacarContext();
        }

        
        Temizlikçi tmz2 = new Temizlikçi();
        Person per = new Person();
        private void btnkayıtet_Click(object sender, EventArgs e)
        {
           
            try
            {
                using (db)
                {
                    Manager mng = new Manager();

                    if (rdiobtnKadın.Checked)
                    {
                        mng.Cinsiyet = "Kadın";
                        rdioBtnErkek.Checked = false;
                    }

                    if (rdioBtnErkek.Checked)
                    {
                        mng.Cinsiyet = "Erkek";
                        rdiobtnKadın.Checked = false;
                    }
                    mng.Ad = txtbxAd.Text.Trim();
                    mng.Soyad = txtbxSoyad.Text.Trim();
                    mng.Email = txtbxEmail.Text.Trim();
                    mng.Sifre = txtbxSifre.Text.Trim();
                    per.Tcno = Convert.ToInt32(txtbxTCNo.Text.Trim());
                    mng.DogumTarih = Convert.ToDateTime(txtbxDogumTarih.Text.Trim());
                    mng.CepTel = Convert.ToInt32(txtbxCepTel.Text.Trim());
                    mng.EvısTel = Convert.ToInt32(txtbxEvIsTel.Text.Trim());
                    mng.Adres = txtbxAdres.Text.Trim();

                    Officer off = new Officer();
                    if (rdiobtnKadın.Checked)
                    {
                        off.Cinsiyet = "Kadın";
                        rdioBtnErkek.Checked = false;
                    }

                    if (rdioBtnErkek.Checked)
                    {
                        off.Cinsiyet = "Erkek";
                        rdiobtnKadın.Checked = false;
                    }

                    off.Ad = txtbxAd.Text.Trim();
                    off.Soyad = txtbxSoyad.Text.Trim();
                    off.Email = txtbxEmail.Text.Trim();
                    off.Sifre = txtbxSifre.Text.Trim();
                    per.Tcno = Convert.ToInt32(txtbxTCNo.Text.Trim());
                    off.DogumTarih = Convert.ToDateTime(txtbxDogumTarih.Text.Trim());
                    off.CepTel = Convert.ToInt32(txtbxCepTel.Text.Trim());
                    off.EvısTel = Convert.ToInt32(txtbxEvIsTel.Text.Trim());
                    off.Adres = txtbxAdres.Text.Trim();

                    Temizlikçi tmz = new Temizlikçi();

                    if (rdiobtnKadın.Checked)
                    {
                        tmz.Cinsiyet = "Kadın";
                        rdioBtnErkek.Checked = false;
                    }

                    if (rdioBtnErkek.Checked)
                    {
                        tmz.Cinsiyet = "Erkek";
                        rdiobtnKadın.Checked = false;
                    }

                    tmz.Ad = txtbxAd.Text.Trim();
                    tmz.Soyad = txtbxSoyad.Text.Trim();
                    tmz.Email = txtbxEmail.Text.Trim();
                    tmz.Sifre = txtbxSifre.Text.Trim();
                    per.Tcno = Convert.ToInt32(txtbxTCNo.Text.Trim());
                    tmz.DogumTarih = Convert.ToDateTime(txtbxDogumTarih.Text.Trim());
                    tmz.CepTel = Convert.ToInt32(txtbxCepTel.Text.Trim());
                    tmz.EvısTel = Convert.ToInt32(txtbxEvIsTel.Text.Trim());
                    tmz.Adres = txtbxAdres.Text.Trim();

                    if (txtbxEmail.Text == null || txtbxSifre.Text == null)
                    {
                        lblMessage.Text = "Lütfen Boş yerleri giriniz";
                        lblMessage.ForeColor = Color.Red;
                    }



                    else
                    {
                           
                        if (cbxDepartman.SelectedIndex == 1)
                            {


                                db.Manager.Add(mng);
                            db.SaveChanges();

                                txtbxAd.Text = "";
                                txtbxSoyad.Text = "";
                                txtbxEmail.Text = "@manager.com";
                                txtbxSifre.Text = "";
                                txtbxEvIsTel.Text = "";
                                txtbxTCNo.Text = "";
                                txtbxDogumTarih.Text = "";
                                txtbxCepTel.Text = " ";
                                txtbxAdres.Text = " ";
                                rdioBtnErkek.Checked = false;
                                rdiobtnKadın.Checked = false;   

                                lblMessage.Text = "Yönetici Eklendi";
                                lblMessage.ForeColor = Color.Green;

                        }
                         else if (cbxDepartman.SelectedIndex == 2)
                            {

                                db.Officer.Add(off);
                                db.SaveChanges();

                                txtbxAd.Text = "";
                                txtbxSoyad.Text = "";
                                txtbxEmail.Text = "@officer.com";
                                txtbxSifre.Text = "";
                                txtbxEvIsTel.Text = "";
                                txtbxTCNo.Text = "";
                                txtbxDogumTarih.Text = "";
                                txtbxCepTel.Text = " ";
                                txtbxAdres.Text = " ";
                                

                                lblMessage.Text = "Memur Eklindi";
                                lblMessage.ForeColor = Color.Green;
                            }
                            else if (cbxDepartman.SelectedIndex == 3)
                            {


                                db.Temizlikçi.Add(tmz);
                            db.SaveChanges();

                                txtbxAd.Text = "";
                                txtbxSoyad.Text = "";
                                txtbxEmail.Text = "@cleaner.com";
                                txtbxSifre.Text = "";
                                txtbxEvIsTel.Text = "";
                                txtbxTCNo.Text = "";
                                txtbxDogumTarih.Text = "";
                                txtbxCepTel.Text = " ";
                                txtbxAdres.Text = " ";

                                lblMessage.Text = "Temizlikçi Eklendi";
                                lblMessage.ForeColor = Color.Green;
                            }


                        

                        

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
            

        }



        private void ÇalısanEkle_Load(object sender, EventArgs e)
        {
            
        }

        private void cbxDepartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDepartman.SelectedIndex == 1)
            {
                txtbxEmail.Text = "@manager.com";
                

            }
            else if (cbxDepartman.SelectedIndex == 2)
            {
                txtbxEmail.Text = "@officer.com";
                
            }
            else if (cbxDepartman.SelectedIndex == 3)
            {
                txtbxEmail.Text = "@cleaner.com";
               
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void txtbxAdres_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdioBtnErkek_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdiobtnKadın_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtbxTCNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtbxEvIsTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxCepTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxDogumTarih_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtbxSoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtbxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbxSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSifre_Click(object sender, EventArgs e)
        {

        }
    }
}
