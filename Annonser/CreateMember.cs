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

        private int UserID;
        Database db;
       

        public CreateMember()
        {
            InitializeComponent();
            db = new Database();
        }

        public void cmdReg_Click(object sender, EventArgs e)
        {
            db.CreateMember(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtUserName.Text, txtPassWord.Text);
        }
    }
}
