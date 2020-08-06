using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormOdev
{
    public partial class PersonelAyrinti : Form
    {
        odevFormAppEntities1 ctx;
     

        public PersonelAyrinti()
        {
            InitializeComponent();
       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PersonelAyrinti_Load(object sender, EventArgs e)
        {
            fillEmployeList();
        }

        private void fillEmployeList()
        {
           
            ctx = new odevFormAppEntities1();
            dataGridView1.DataSource = ctx.Employee.ToList();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {            
            frmPersonel a=new frmPersonel();
            a.lblID.Text= dataGridView1.CurrentRow.Cells["EmployeeID"].Value.ToString();
            a.dtIstenCikma.Enabled = true;
            a.tbxTC.Text= dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
            a.tbxName.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            a.tbxSurname.Text = dataGridView1.CurrentRow.Cells["Surname"].Value.ToString();
            a.dtDogumTarihi.Text = dataGridView1.CurrentRow.Cells["BDate"].Value.ToString();
            a.dtIseGirme.Text = dataGridView1.CurrentRow.Cells["WDate"].Value.ToString();
            a.cbxKanGrubu.Text = dataGridView1.CurrentRow.Cells["KanGrubu"].Value.ToString();
            a.txtAdress.Text = dataGridView1.CurrentRow.Cells["Address"].Value.ToString();
            a.tbxNetMaas.Text = dataGridView1.CurrentRow.Cells["NetMaas"].Value.ToString();
            a.pictureBox1.ImageLocation = dataGridView1.CurrentRow.Cells["FYolu"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["WCikmaDate"].Value== null)
            {
               // a.dtIstenCikma.Value = ;
            }
            //a.dtIstenCikma. = (DateTime)dataGridView1.CurrentRow.Cells["WCikmaDate"].Value;
            a.Show();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            var tc = Convert.ToInt64(tbxTcNo.Text);
            dataGridView1.DataSource = ctx.Employee.Where(x => x.TC == tc).ToList();
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            fillEmployeList();
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["EmployeeID"].Value);

            DialogResult result = MessageBox.Show(id + " id li personel kalıcı olarak silinecektir! Devam Edilsin mi?", "Uyarı!" , MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Employee silinecek = ctx.Employee.Where(p => p.EmployeeID == id).FirstOrDefault();
                ctx.Employee.Attach(silinecek);
                ctx.Employee.Remove(silinecek);
                ctx.SaveChanges();
                fillEmployeList();
            }
 
        }
    }
}
