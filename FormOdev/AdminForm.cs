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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnYeniUser_Click(object sender, EventArgs e)
        {
            new NewUserForm().Show();
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            new Personel().Show();
        }
    }
}
