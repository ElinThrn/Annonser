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
using Annonser.Classes;

namespace Annonser
{
    public partial class frmUserDetails : Form
    {

        USer user = new USer();
        UserRepo ur = new UserRepo();
        AdvertRepo ar = new AdvertRepo();
        public int UserID;
        public frmUserDetails()
        {
            InitializeComponent();
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            using (AnnonserEntities1 db = new AnnonserEntities1())
            {
                List<Advert> advert = db.Adverts.Where(s => s.UserID == this.UserID).ToList();
                listboxmyad.DisplayMember = "Title";
                foreach (Advert ad in advert)
                {
                    listboxmyad.Items.Add(ad);
                }
            }
            using (AnnonserEntities1 db = new AnnonserEntities1())
            {
                List<Category> category = db.Categories.ToList();

                ComboBoxItem item = new ComboBoxItem();
                item.Value = 0;
                item.Text = "Alla kategorier";

                cboCategory.Items.Add(item);

                foreach (Category cat in category)
                {
                    ComboBoxItem listItem = new ComboBoxItem();

                    listItem.Value = cat.CategoryID;
                    listboxmyad.ValueMember = "AdID";
                    listItem.Text = cat.Categoryname;

                    cboCategory.Items.Add(listItem);
                }
                cboCategory.SelectedIndex = 0;
            }
        }

        private void listboxmyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (listboxmyad.SelectedItem != null)
            {
                Advert selectedad = (Advert)(listboxmyad.SelectedItem);
                using (AnnonserEntities1 db = new AnnonserEntities1())
                {
                    Advert advert = db.Adverts.Where(s => s.AdID == selectedad.AdID).FirstOrDefault();

                    txtAdInfo.Text = advert.Description;
                    txtAdTitel.Text = advert.Title;
                    txtPrice.Text = (advert.Price).ToString();
                    txtLocation.Text = advert.Location;
                    cboCategory.Text = ar.GetCategoryName(advert.CategoryID);
                    
                }


            }

        }

        private void cmdDeleteAd_Click(object sender, EventArgs e)
        {
            Advert selectedad = (Advert)(listboxmyad.SelectedItem);

            using (AnnonserEntities1 db = new AnnonserEntities1())
            {

                //Här görs databasanrop dvs en command med en sql fråga som läser ut just denna leverantören
                Advert advert = db.Adverts.Where(s => s.AdID == selectedad.AdID).FirstOrDefault();

                db.Adverts.Remove(advert);
                db.SaveChanges();
                MessageBox.Show("Annons borttagen");

            }
        }

        private void cmdCreateNew_Click(object sender, EventArgs e)
        {
            using (AnnonserEntities1 db = new AnnonserEntities1())
            {
                Advert advert = new Advert();
                advert.Title = txtAdTitel.Text;
                advert.Description = txtAdInfo.Text;
                advert.Price = Convert.ToInt32(txtPrice.Text);
                advert.Location = txtLocation.Text;
                advert.AdvertDate = DateTime.Now;
                advert.CategoryID = cboCategory.SelectedIndex;
                advert.UserID = this.UserID;

                db.Adverts.Add(advert);
                db.SaveChanges();
                MessageBox.Show("Annons sparad");
            }
        }

        private void cmdUpdateAd_Click(object sender, EventArgs e)
        {
            Advert selectedad = (Advert)(listboxmyad.SelectedItem);

            using (AnnonserEntities1 db = new AnnonserEntities1())
            {
                //Här görs databasanrop dvs en command med en sql fråga som läser ut just denna leverantören
                Advert advert = db.Adverts.Where(s => s.AdID == selectedad.AdID).FirstOrDefault();

                advert.Title = txtAdTitel.Text;
                advert.Description = txtAdInfo.Text;
                advert.Price = Convert.ToInt32(txtPrice.Text);
                advert.Location = txtLocation.Text;
                advert.AdvertDate = DateTime.Now;
                advert.CategoryID = cboCategory.SelectedIndex;
                db.SaveChanges();
                MessageBox.Show("Annons uppdaterad");
            }
        }
    }

}
