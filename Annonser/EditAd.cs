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

namespace Annonser
{
    public partial class EditAd : Form
    {
        public EditAd()
        {
            InitializeComponent();
        }

        private void EditAd_Load(object sender, EventArgs e)
        {
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
                    listItem.Text = cat.Categoryname;

                    cboCategory.Items.Add(listItem);
                }
            }
        }

        private void cmdSaveAd_Click(object sender, EventArgs e)
        {
            //using (AnnonserEntities1 db = new AnnonserEntities1())
            //{
            //    USer user = new USer();

                
            //    Advert advert = new Advert();
            //    advert.Description = txtAdInfo.Text;
            //    advert.Price = int.Parse(txtPrice.Text);
            //    advert.Title = txtAdTitel.Text;
            //    advert.Location = txtLocation.Text;
                

            //    db.Adverts.Add(advert);
            //    db.SaveChanges()
         }
      
     }
 }


