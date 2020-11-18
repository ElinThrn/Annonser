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
           if(ur.Login(txtUsername.Text, txtPassword.Text))
            {
                Ad ad = new Ad();
                ad.Show();

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
