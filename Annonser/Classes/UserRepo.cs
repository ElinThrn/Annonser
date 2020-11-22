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
        public static string conn = "Data Source=localhost;Initial Catalog=Annonser;Integrated Security=SSPI;";

        public int LoggedUserID { get; set; }
        public bool login { get; set; }

        int UserID;

        public void CreateMember(User ur)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source = localhost; Initial Catalog = Annonser; Integrated Security = SSPI;";
            conn.Open();

            if (ur.FirstName != "" || ur.Email != "")
            {
                string sql = "insert into [User](Firstname,Lastname,Email,Username,Password) values (@Firstname, @Lastname, @Email, @Username, @Password)";
                sql += "Select cast(@@identity as int)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Firstname", ur.FirstName);
                cmd.Parameters.AddWithValue("@Lastname", ur.LastName);
                cmd.Parameters.AddWithValue("@Email", ur.Email);
                cmd.Parameters.AddWithValue("@Username", ur.Username);
                cmd.Parameters.AddWithValue("@Password", ur.Password);

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

        public int Login(string username, string password)
        {
            using (AnnonserEntities1 db = new AnnonserEntities1())
            {
                USer user = db.USers.Where(x => x.Username == username && x.Password == password).SingleOrDefault();

                if (user != null)
                {
                    return user.UserID;

                }
                else
                {
                    MessageBox.Show("Inloggning misslyckades");
                    return 0;
                }
            }

        }
        public int GetUSerID(string username, string password)
        {
            using (AnnonserEntities1 db = new AnnonserEntities1())
            {
                USer user = db.USers.Where(x => x.Username == username && x.Password == password).SingleOrDefault();

                if (user != null)
                {
                    return user.UserID;
                }
                else
                {
                    
                    MessageBox.Show("User not found.");
                    return 0;
                }
            }
        }
        public string GetUsername(int userId)
        {
            using (AnnonserEntities1 db = new AnnonserEntities1())
            {
                USer user = db.USers.Where(x => x.UserID == userId).SingleOrDefault();

                if (user != null)
                {
                    return $"{user.Firstname} {user.Lastname}";
                }
                else
                {
                    return "";
                }
            }
        }
    }
}

