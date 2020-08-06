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
    public partial class LoginForm : Form
    {
        private odevFormAppEntities1 ctx = new odevFormAppEntities1();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = userNameTb.Text;
            string password = passwordTb.Text;

            LoginUser user = ctx.LoginUserSet.Where(l => l.UserName.Equals(userName) && l.Password.Equals(password)).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Kullanıcı Adı veya şifre hatalı.");
            }
            else
            {
                Program.onlineUser = user;
                if (user.IsAdmin)
                {
                    MessageBox.Show("Admin hoşgeldin");
                    var form2 = new AdminForm();
                    form2.FormClosed += delegate
                    {
                        this.Close();
                    };
                    this.Hide();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Hoşgeldiniz");
                    var form2 = new Personel();
                    form2.FormClosed += delegate
                    {
                        this.Close();
                    };
                    this.Hide();
                    form2.Show();
                }
                
            }

        }
    }
}
