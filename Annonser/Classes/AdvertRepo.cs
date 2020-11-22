using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Annonser.Classes;
using System.Windows.Forms;
using System.Data;

namespace Annonser.Classes
{
    public class AdvertRepo
    {
        UserRepo ur = new UserRepo();
        int UserID;
        public static string connectionString = "Data Source=localhost;Initial Catalog=Annonser;Integrated Security=SSPI;";
        public void Search(string textSearch, ComboBox cb, ListBox lb)
        {

            USer user = new USer();
            UserID = user.UserID;
            string condition = textSearch;
            int categoryID = int.Parse((cb.SelectedItem as ComboBoxItem).Value.ToString());
            lb.DataSource = null;
            using (AnnonserEntities1 db = new AnnonserEntities1())
            {
                List<Advert> adverts;

                if (categoryID == 0)
                {
                    adverts = db.Adverts.Where(a => a.Title.Contains(condition)).ToList();

                }
                else
                {
                   
                    adverts = db.Adverts.Where(a => a.Title.Contains(condition) && a.CategoryID == categoryID).ToList();
                }

                lb.DisplayMember = "Title";
                lb.DataSource = adverts;
            }
        }
        public static DataTable GetData()
        {
            try
            {
                using (SqlConnection db = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("GetAd", db);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter Adpt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    Adpt.Fill(dt);
                    return dt;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void ListBoxSelect(ListBox lb, TextBox description, TextBox titel, TextBox price, TextBox location, TextBox seller)
        {
            
            if (lb.SelectedValue != null)
            {
                string firstname = seller.Text;

                using (AnnonserEntities1 db = new AnnonserEntities1())
                {
                    int advertID = int.Parse(lb.SelectedValue.ToString());

                    Advert advert = db.Adverts.Where(s => s.AdID == advertID).SingleOrDefault();

                    description.Text = advert.Description;
                    titel.Text = advert.Title;
                    price.Text = (advert.Price).ToString();
                    location.Text = advert.Location;
                    seller.Text = ur.GetUsername(advert.UserID);



                }
            }

        }
        public string GetCategoryName(int? categoryId)
        {
            using (AnnonserEntities1 db = new AnnonserEntities1())
            {
                Category category = db.Categories.Where(x => x.CategoryID == categoryId).SingleOrDefault();
                if(category != null)
                {
                    return category.Categoryname;
                }
                else
                {
                    return "";
                }
            }
        }
    }
}


