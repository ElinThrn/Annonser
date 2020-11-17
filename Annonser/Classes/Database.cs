using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Annonser.Classes
{
    class Database
    {
        DataTable dt;
        SqlDataReader dataReader;
        SqlConnection cn;
        SqlCommand command;
        string cnString;
        public int number { get; set; }


        public Database()
        {
            dt = new DataTable();
            command = new SqlCommand();
            cnString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Gustaf\source\repos\Annonser\Annonser\DataBase.mdf;Integrated Security=True";
            cn = new SqlConnection(cnString);
        }
        public void Login(string username, string password)
        {
            cn.Open();
            command = new SqlCommand("Select Username, Password from Accounts", cn);
            dataReader = command.ExecuteReader();
            dt.Load(dataReader);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr.Field<string>("Username") == username && dr.Field<string>("Password") == password)
                {
                    frmUserDetails fmd = new frmUserDetails();
                    fmd.Show();
                }
                else
                {
                    MessageBox.Show("Inloggningen misslyckades!");
                }
            }
            cn.Close();
        }



        public void CreateMember(string firstname, string lastname, string email, string username, string password)
        {

            SqlConnection conn = new SqlConnection();
            
            

            conn.ConnectionString = "Data Source = localhost; Initial Catalog = Annonser; Integrated Security = SSPI;";
            conn.Open();

            string sql = "insert into [User](Firstname,Lastname,Email,Username,Password) values (@Firstname, @Lastname, @Email, @Username, @Password)";
            sql += "Select cast(@@identity as int)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Firstname", firstname);
            cmd.Parameters.AddWithValue("@Lastname", lastname);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Username", username);
            cmd.Parameters.AddWithValue("@Password", password);

            int newID = (int)cmd.ExecuteScalar();
            //UserID = newID;
        }

    }
}
