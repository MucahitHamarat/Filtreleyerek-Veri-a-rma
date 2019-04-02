using EFCF1.Data.Context;
using EFCF1.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCF1
{
    public partial class Form1 : Form
    {//Güncellemede bir hata veriyor//Güncellemede bir hata veriyor//Güncellemede bir hata veriyor
        CFDbContext db = new CFDbContext();//Güncellemede bir hata veriyor
        public Form1()//Güncellemede bir hata veriyor
        {//Güncellemede bir hata veriyor
            InitializeComponent();
        }

        private void BtnIslemDep_Click(object sender, EventArgs e)
        {
            if (BtnIslemDep.Text == "EKLE") db.departmans.Add(new Departman { Ad = txtDep.Text });
            else
            {
                int id = Convert.ToInt32(DaGriVieDep.CurrentRow.Cells[0].Value);
                Departman dep = db.departmans.Where(w => w.ID == id).First();
                dep.Ad = txtDep.Text;
                BtnIslemDep.Text = "EKLE";
            }
            db.SaveChanges();
            txtDep.Clear();
            Yukle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            DaGriVieDep.DataSource = db.departmans.ToList();
            DaGriVieDep.Columns[0].Visible = false;
            DatGriViePer.DataSource = db.personels.Select(w => new { ID = w.ID, PersonelName = w.Ad, PersonelSurname = w.Soyad, Departmanı = w.departman.Ad }).ToList();
            DatGriViePer.Columns[0].Visible = false;
            cmbDep.DataSource = DaGriVieDep.DataSource;
        }

        private void DaGriVieDep_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = Convert.ToInt32(DaGriVieDep.CurrentRow.Cells[0].Value);
            Departman dep = db.departmans.Where(w => w.ID == id).First();
            txtDep.Text = dep.Ad;
            BtnIslemDep.Text = "GÜNCELLE";
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DaGriVieDep.CurrentRow.Cells[0].Value);
            Departman dep = db.departmans.Where(w => w.ID == id).First();
            db.departmans.Remove(dep);
            db.SaveChanges();
            Yukle();

        }

        private void btnIslemPer_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cmbDep.SelectedValue);
            if (btnIslemPer.Text == "EKLE") db.personels.Add(new Personel { Ad = txtPerAd.Text, Soyad = txtPerSoyad.Text, DepartmanID = id });
            else
            {

                Personel per = db.personels.Where(w => w.ID == id).First();
                per.Ad = txtPerAd.Text;
                per.Soyad = txtPerSoyad.Text;
                per.DepartmanID = id;
                btnIslemPer.Text = "EKLE";
            }
            db.SaveChanges();//Güncellemede bir hata veriyor
            txtPerAd.Clear();
            txtPerSoyad.Clear();
            Yukle();

        }

       
        private void DatGriViePer_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int id = Convert.ToInt32(DatGriViePer.CurrentRow.Cells[0].Value);
            Personel per = db.personels.Where(w => w.ID == id).First();
            txtPerAd.Text = per.Ad;
            txtPerSoyad.Text = per.Soyad;
            id = per.DepartmanID;
            btnIslemPer.Text = "GÜNCELLE";
        }

        private void silPerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(DatGriViePer.CurrentRow.Cells[0].Value);
            Personel per = db.personels.Where(w => w.ID == id).First();
            db.personels.Remove(per);
            db.SaveChanges();
            Yukle();
        }

      

        private void btnAra_Click_1(object sender, EventArgs e)
        {
            switch (cmbAra.Text)
            {
                case "Adına Göre":
                    DatGriViePer.DataSource = db.personels.Where(w => w.Ad.Contains(txtPerAra.Text)).Select(s => new { ID = s.ID, Ad = s.Ad, Soyad = s.Soyad, Departmanı = s.departman.Ad }).ToList();
                    break;
                case "Soyadına Göre":
                    DatGriViePer.DataSource = db.personels.Where(w => w.Soyad.Contains(txtPerAra.Text)).Select(s => new { ID = s.ID, Ad = s.Ad, Soyad = s.Soyad, Departmanı = s.departman.Ad }).ToList();
                    break;
                case "Departmanına Göre":
                    DatGriViePer.DataSource = db.personels.Where(w => w.departman.Ad.Contains(txtPerAra.Text)).Select(s => new { ID = s.ID, Ad = s.Ad, Soyad = s.Soyad, Departmanı = s.departman.Ad }).ToList();
                    break;
                default:
                    db.personels.Select(s => new { ID = s.ID, Ad = s.Ad, Soyad = s.Soyad, Departmanı = s.departman.Ad }).ToList();
                    break;
            }
        }

   
    }
}
