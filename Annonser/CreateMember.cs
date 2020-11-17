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

namespace Annonser
{
    public partial class CreateMember : Form
    {

        private int UserID;
        public CreateMember()
        {
            InitializeComponent();
        }

        public void cmdReg_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source = localhost; Initial Catalog = Annonser; Integrated Security = SSPI;";
            conn.Open();

            string sql = "insert into [User](Firstname,Lastname,Email,Username,Password) values (@Firstname, @Lastname, @Email, @Username, @Password)";
            sql += "Select cast(@@identity as int)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Firstname", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@Lastname", txtLastName.Text);
            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@Username", txtUserName.Text);
            cmd.Parameters.AddWithValue("@Password", txtPassWord.Text);

            int newID = (int)cmd.ExecuteScalar();
            UserID = newID;
        }
    }
}
