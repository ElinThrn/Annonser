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
        public Login()
        {
            InitializeComponent();

        }

        private void cmdMemberLogin_Click(object sender, EventArgs e)
        {

            USer uSer = UserRepo.LogIn(txtUsername.Text, txtPassword.Text);
            USer user = new USer();
            frmUserDetails userdeta = new frmUserDetails(user);
            userdeta.Show();

        }

        private void cmdCreateAccount_Click(object sender, EventArgs e)
        {
            CreateMember createmember = new CreateMember();
            createmember.Show();
            
            

        }
    }
}
