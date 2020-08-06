using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormOdev
{
    public partial class frmPersonel : Form
    {
        odevFormAppEntities1 ctx =new odevFormAppEntities1();
        private bool picture = false;
        private string filePath = "";
        
        public frmPersonel()
        {
            InitializeComponent();
            
        }

        private void btnFotoSec_Click(object sender, EventArgs e)
        {
            picture = false;
            try
            {
                openFileDialog1.ShowDialog();
                filePath = openFileDialog1.FileName;
                Image img = Image.FromFile(filePath);
                pictureBox1.Image = img;
                picture = true;
            }
            catch (Exception)
            {
                picture = false;
            }
            
        }

        private void btnFotoKaldir_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
         
            if (tbxTC.Text == "" || tbxName.Text == "" || tbxSurname.Text == "" 
                || txtAdress.Text == "" || tbxNetMaas.Text == "" || dtIseGirme.Value.ToString()==""
            ||dtDogumTarihi.Value.ToString() == "" || !picture)
            {
                MessageBox.Show("Gerekli alanları doldurun!");
            }
            else
            {
                long tc = long.Parse(tbxTC.Text);
                var _employee = ctx.Employee.Where(p => p.TC == tc).FirstOrDefault();
                if (_employee != null)
                {
                    MessageBox.Show("Aynı Tc noya sahip personel mevcuttur!");
                }
                else
                {
                    string newFilePath = "resimler/" + tc.ToString();
                    if (filePath.EndsWith(".jpg") || filePath.EndsWith(".jpeg"))
                    {
                        newFilePath += ".jpg";
                        pictureBox1.Image.Save(newFilePath, ImageFormat.Jpeg);

                    }
                    else if (filePath.EndsWith(".png"))
                    {
                        newFilePath += ".png";
                        pictureBox1.Image.Save(newFilePath, ImageFormat.Png);
                    }


                    Employee _employeee = new Employee();
                    _employeee.Name = tbxName.Text.ToString();
                    _employeee.Surname = tbxSurname.Text.ToString();
                    _employeee.TC = tc;
                    _employeee.BDate = (DateTime)dtDogumTarihi.Value;
                    _employeee.WDate = dtIseGirme.Value;
                    _employeee.NetMaas = tbxNetMaas.Text.ToString();
                    _employeee.Address = txtAdress.Text.ToString();
                    _employeee.FYolu = newFilePath;

                    _employeee.KanGrubu = cbxKanGrubu.SelectedItem.ToString();
                    ctx.Entry(_employeee).State = EntityState.Added;
                    ctx.SaveChanges();

                    if (filePath.EndsWith(".jpg") || filePath.EndsWith(".jpeg"))
                    {
                        pictureBox1.Image.Save("resimler/" + tc.ToString() + ".jpg", ImageFormat.Jpeg);

                    }
                    else if (filePath.EndsWith(".png"))
                    {
                        pictureBox1.Image.Save("resimler/"+tc.ToString() + ".png", ImageFormat.Png);
                    }
                    

                    MessageBox.Show("Kayıt Başarı ile Eklendi");
                }
            }
        }

        private void tbxTC_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbxTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
            
            if (tbxTC.Text == "" || tbxName.Text == "" || tbxSurname.Text == ""
                || txtAdress.Text == "" || tbxNetMaas.Text == "" || dtIseGirme.Value.ToString() == ""
                || dtDogumTarihi.Value.ToString() == "")
            {
                MessageBox.Show("Gerekli alanları doldurun!");
            }
            else
            {
                var tc = Convert.ToInt64(tbxTC.Text);
                int id =Convert.ToInt32(lblID.Text);
                var _employee = ctx.Employee.Where(p => p.EmployeeID == id).First();
                if (_employee != null)
                {
                    _employee.Name = tbxName.Text.ToString();
                    _employee.Surname = tbxSurname.Text.ToString();
                    _employee.TC = long.Parse(tbxTC.Text);
                    _employee.BDate = (DateTime)dtDogumTarihi.Value;
                    
                    _employee.KanGrubu = cbxKanGrubu.Text;
                    _employee.WDate = dtIseGirme.Value;
                    _employee.WCikmaDate = dtIstenCikma.Value;
                    _employee.NetMaas = tbxNetMaas.Text.ToString();
                    _employee.Address = txtAdress.Text.ToString();
                    if (!"openFileDialog1".Equals(((FormOdev.frmPersonel)pictureBox1.TopLevelControl).openFileDialog1.FileName))
                    {
                        _employee.FYolu = filePath;
                    }
                    ctx.Entry(_employee).State = EntityState.Modified;
                    ctx.SaveChanges();
                    MessageBox.Show("Kayıt Başarı ile Güncellendi");
                }
                else
                {
                    MessageBox.Show("Bulunamadı");
                }
            }
           
        }

        private void cbxKanGrubu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmPersonel_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'odevFormAppDataSet.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter.Fill(this.odevFormAppDataSet.Employee);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
