using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Annonser.Classes;

namespace Annonser
{
    public partial class CreateMember : Form
    {

        UserRepo ur;
       

        public CreateMember()
        {
            InitializeComponent();
            ur = new UserRepo();
        }
        public void cmdReg_Click(object sender, EventArgs e)
        {
            ur.CreateMember(new User(txtFirstName.Text,txtLastName.Text,txtEmail.Text,txtUserName.Text,txtPassWord.Text));
            
        }
    }
}
