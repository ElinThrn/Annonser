using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annonser.Classes
{
    public  class UserRepo
    {

        public static USer LogIn(string username, string password)
        {
            USer user = new USer();
            
            using (AnnonserEntities1 db = new AnnonserEntities1())
            {
                var loggedUser = db.USers.SingleOrDefault(l => l.Username == username && l.Password == password);
                if (loggedUser != null)
                {
                   
                    user.Username = username;
                    user.Password = password;
                    user.UserID = (from x in db.USers
                                   where x.Username == username
                                   select x.UserID).FirstOrDefault();                    

                }
                else
                {
                    user = null;
                    
                }
                return user;
                
            }

        }


        //public static USer CreateUser(string firstname, string lastname, string email, string username, string password)
        //{
        //    using (AnnonserEntities1 db = new AnnonserEntities1())
        //    {
        //        USer user = new USer();



        //    }
        //}



    }
}

