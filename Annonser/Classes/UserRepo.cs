using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Annonser.Classes
{
    public  class UserRepo
    {
        public bool login { get; set; }

        int UserID;

        public void CreateMember(string firstname, string lastname, string email, string username, string password)
        {

            SqlConnection conn = new SqlConnection();



            conn.ConnectionString = "Data Source = localhost; Initial Catalog = Annonser; Integrated Security = SSPI;";
            conn.Open();

            if (firstname != "" || email != "")
            {


                string sql = "insert into [User](Firstname,Lastname,Email,Username,Password) values (@Firstname, @Lastname, @Email, @Username, @Password)";
                sql += "Select cast(@@identity as int)";



                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Firstname", firstname);
                cmd.Parameters.AddWithValue("@Lastname", lastname);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                int newID = (int)cmd.ExecuteScalar();
                UserID = newID;

                CreateMember cm = new CreateMember();
                cm.Close();
            }
            else
            {
                MessageBox.Show("Uppgifter saknas försök igen");
            }
        }

        public bool Login(string username, string password)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Data Source = localhost; Initial Catalog = Annonser; Integrated Security = SSPI;";
                conn.Open();

                string query = "Select * from [User] Where username = '" + username + "' and password = '" + password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                DataTable dtbl = new DataTable();

                sda.Fill(dtbl);

                if (dtbl.Rows.Count == 1)
                {
                    login = true;
                }
                else
                {
                    MessageBox.Show("Inloggning misslyckades");
                    login = false;
                }
            }
            return login;

        }

    }
}

