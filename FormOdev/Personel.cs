using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormOdev
{
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        private void btnYeniPerGirisi_Click(object sender, EventArgs e)
        {
           new frmPersonel().Show();
        }

        private void btnPerGor_Click(object sender, EventArgs e)
        {
            new PersonelAyrinti().Show();
        }

        private void Personel_Load(object sender, EventArgs e)
        {

        }
    }
}
