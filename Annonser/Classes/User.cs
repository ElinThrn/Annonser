using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annonser.Classes
{
   public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public int UserID { get; set; }

        public User()
        {

        }
        public User(string firstname, string lastname, string email, string username, string password)
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Username = username;
            Password = password;
            
        }


    }
}
