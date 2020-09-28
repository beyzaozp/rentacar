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
    public partial class ŞifreHatırlatma : Form
    {
        public ŞifreHatırlatma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rentacarContext db = new rentacarContext();
            var ara = textBox1.Text.Trim();
            /*using (db)
            {
                var query = from a in db
                            where Email == "Bill"
                            select st;

                
            }*/
            var ara1 = Convert.ToString(db.Manager.Where(b => b.Email == ara).FirstOrDefault());
            var ara2 = Convert.ToString(db.Officer.Where(b => b.Email == ara).FirstOrDefault());
            var ara3 = Convert.ToString(db.Temizlikçi.Where(b => b.Email == ara).FirstOrDefault());
            if (textBox1.Text.Contains("@manager"))
            {
                lblMessage.Text = Convert.ToString(ara1);
            }
            
            else if (textBox1.Text.Contains("@officer"))
            {
                lblMessage.Text = Convert.ToString(ara2);
            }

            else if (textBox1.Text.Contains("@Temizlikçi"))
            {
                lblMessage.Text = Convert.ToString(ara3);
            }

        }

        private void ŞifreHatırlatma_Load(object sender, EventArgs e)
        {

        }
    }
}
