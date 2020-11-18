using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annonser.Classes
{
   public class AdvertRepo
    {


        public void Search(string textSearch, ComboBox category, ListBox listBox)
        {
            USer user = new USer();
            UserID = user.UserID;
            string condition = textSearch;
            int categoryID = int.Parse((category.SelectedItem as ComboBoxItem).Value.ToString());
            listBox.DataSource = null;

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
                listBox.DisplayMember = "Title";
                listBox.DataSource = adverts;
            }
        }

        public void AdLoad(ComboBox categori, ListBox listBox)
        {
            using (AnnonserEntities1 db = new AnnonserEntities1())
            {
                List<Category> category = db.Categories.ToList();

                ComboBoxItem item = new ComboBoxItem();
                item.Value = 0;
                item.Text = "Alla kategorier";

                categori.Items.Add(item);

                foreach (Category cat in category)
                {
                    ComboBoxItem listItem = new ComboBoxItem();
                    listItem.Value = cat.CategoryID;
                    listBox.ValueMember = "AdID";
                    listItem.Text = cat.Categoryname;

                    categori.Items.Add(listItem);
                }
            }

            categori.SelectedIndex = 0;
        }

        public void ListBoxSelect(ListBox listBox, TextBox description, TextBox titel, TextBox price, TextBox location)
        {
            using (AnnonserEntities1 db = new AnnonserEntities1())
            {

                int advertID = int.Parse(listBox.SelectedValue.ToString());

                Advert advert = db.Adverts.Where(s => s.AdID == advertID).SingleOrDefault();


                description.Text = advert.Description;
                titel.Text = advert.Title;
                price.Text = (advert.Price).ToString();
                location.Text = advert.Location;


            }
        }
    }
}
