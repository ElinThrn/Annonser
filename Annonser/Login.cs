using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Annonser.Classes;

namespace Annonser
{
    public partial class Login : Form
    {
        UserRepo ur;
        public Login()
        {
            InitializeComponent();
            ur = new UserRepo();
        }

        private void cmdMemberLogin_Click(object sender, EventArgs e)
        {
            int UserID = ur.Login(txtUsername.Text, txtPassword.Text);
            if (UserID > 0)
            {
                Ad ad = new Ad();
                ad.Show();
                ad.Ad_Show();
                ad.SetUser(UserID);
                this.Close();
            }

        }

        private void cmdCreateAccount_Click(object sender, EventArgs e)
        {
            CreateMember createmember = new CreateMember();
            createmember.Show();
        }
    }
}
