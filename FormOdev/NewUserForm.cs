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
    public partial class NewUserForm : Form
    {
        private odevFormAppEntities1 ctx = new odevFormAppEntities1();
        public NewUserForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string userName = userNameTb.Text;
            string password = passwordTb.Text;

            if(userName.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş. Lütfen doldurunuz.");
                return;
            }

            LoginUser user = ctx.LoginUserSet.Where(l => l.UserName.Equals(userName)).FirstOrDefault();
            if (user != null)
            {
                MessageBox.Show("Aynı kullanıcı adı zaten mevcut. Liütfen kullanıcı adını değiştiriniz");
            }
            else
            {
                LoginUser newUser = new LoginUser { UserName = userName, Password = password, IsAdmin = false};
                ctx.Entry(newUser).State = EntityState.Added;
                ctx.SaveChanges();

                MessageBox.Show("Kullanıcı başarı ile eklendi");
            }


        }
    }
}
