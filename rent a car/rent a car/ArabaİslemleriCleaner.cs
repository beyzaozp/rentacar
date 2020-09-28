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
    public partial class ArabaİslemleriCleaner : Form
    {
        public ArabaİslemleriCleaner()
        {
            InitializeComponent();

            rentacarContext db = new rentacarContext();
            dataGridView1.DataSource = (from t in db.Araba
                                        select new
                                        {
                                            ArabaID = t.ArabaId,
                                            t.Plaka,
                                            t.Marka,
                                            t.Model,
                                            t.Yıl,
                                            t.Kilometre
                                        }).ToList();
        }

        private void ArabaİslemleriCleaner_Load(object sender, EventArgs e)
        {
            rentacarContext db = new rentacarContext();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tbArabaID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            tbPlaka.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tbMarka.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            tbModel.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString(); 
            tbYıl.Text= dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            tbKM.Text= dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }
    }
}
