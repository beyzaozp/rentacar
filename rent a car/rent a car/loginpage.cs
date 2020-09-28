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
    public partial class loginpage : Form
    {
        public loginpage()
        {
            InitializeComponent();
        }
        rentacarContext db = new rentacarContext();

        HomePageMANAGER h;
        HomePageOfficer hmn;
        ArabaİslemleriCleaner car;

        Officer of1 = new Officer();
        Officer of2 = new Officer();

        Manager mng1 = new Manager();
        Manager mng2 = new Manager();

        Temizlikçi tmz1 = new Temizlikçi();
        Temizlikçi tmz2 = new Temizlikçi();
        private void button1_Click(object sender, EventArgs e)
        {
            

            if (txtbxEmail.Text.Trim() == null || txtbxSifre.Text.Trim() == null)
            {
                lblMessage.Text = "Boş alanları doldurunuz!";
                lblMessage.ForeColor = Color.Red;
            }
            else
            {
                string email = txtbxEmail.Text.Trim();
                string sifre = txtbxSifre.Text.Trim();
                
                try
                {
                    if (txtbxEmail.Text.Contains("@manager.com"))
                    {
                        mng1 = db.Manager.First(ee => ee.Email == email);
                        mng2 = db.Manager.First(s => s.Sifre == sifre);
                    }
                    else if(txtbxEmail.Text.Contains("@officer.com")){
                        of1 = db.Officer.First(ee => ee.Email == email);
                        of2 = db.Officer.First(s => s.Sifre == sifre);
                    }

                    else if (txtbxEmail.Text.Contains("@cleaner.com"))
                    {
                        tmz1 = db.Temizlikçi.First(ee => ee.Email == email);
                        tmz2 = db.Temizlikçi.First(s => s.Sifre == sifre);
                    }
                    
                    
                    if (txtbxEmail.Text.Contains("@manager.com")&& mng1.Email == email && mng2.Sifre == sifre)
                        {
                            if (h == null || h.IsDisposed)
                            {
                                h = new HomePageMANAGER();
                                h.Show();
                                this.Hide();
                            }
                        }
                    

                    else if (txtbxEmail.Text.Contains("@officer.com") && of1.Email == email && of2.Sifre == sifre)
                    {
                        if (hmn == null || h.IsDisposed)
                        {
                            hmn = new HomePageOfficer();
                            hmn.Show();
                            this.Hide();
                        }

                    }
                    else if (txtbxEmail.Text.Contains("@cleaner.com") && tmz1.Email == email && tmz2.Sifre == sifre)
                    {
                        if (car == null || car.IsDisposed)
                        {
                            car = new ArabaİslemleriCleaner();
                            car.Show();
                            this.Hide();
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
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {

        }
        ŞifreHatırlatma r;
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (r == null || r.IsDisposed)
            {
                r = new ŞifreHatırlatma();
                r.ShowDialog();
            }
        }

        private void loginpage_Load(object sender, EventArgs e)
        {

        }
    }
}
