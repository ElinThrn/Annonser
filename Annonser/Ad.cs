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
    public partial class Ad : Form
    {
        public bool isLoggedIn = false;
        public Ad()
        {
            InitializeComponent();

        }

        private void Ad_Load(object sender, EventArgs e)
        {
            using (AnnonserEntities1 db = new AnnonserEntities1())
            {
                List<Category> category = db.Categories.ToList();

                ComboBoxItem item = new ComboBoxItem();
                item.Value = 0;
                item.Text = "Alla kategorier";

                cboCategori.Items.Add(item);

                foreach (Category cat in category)
                {
                    ComboBoxItem listItem = new ComboBoxItem();
                    listItem.Value = cat.CategoryID;
                    listBox1.ValueMember = "AdID";
                    listItem.Text = cat.Categoryname;

                    cboCategori.Items.Add(listItem);
                }
            }

            cboCategori.SelectedIndex = 0;
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            string condition = txtSearch.Text;
            int categoryID = int.Parse((cboCategori.SelectedItem as ComboBoxItem).Value.ToString());
            listBox1.DataSource = null;

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
                listBox1.DisplayMember = "Title";
                listBox1.DataSource = adverts;
            }
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Login login = new Login())
            {
                login.ShowDialog();
               
            }
            if (isLoggedIn == true)
            {
                cmdEditAd.Visible = true;
                cmdMyAd.Visible = true;
            }
            this.Show();


        }

        private void cmdEditAd_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (Form editForm = new EditAd())
            {
                editForm.ShowDialog();
            }
            this.Show();
        }

        private void cmdMyAd_Click(object sender, EventArgs e)
        {

        }

        private void cboCategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (AnnonserEntities1 db = new AnnonserEntities1())
            {

                int advertID = int.Parse(listBox1.SelectedValue.ToString());

                Advert advert = db.Adverts.Where(s => s.AdID == advertID).SingleOrDefault();
              

                txtInfoDescription.Text = advert.Description;
                txtInfoTitel.Text = advert.Title;
                txtPriceInfo.Text = (advert.Price).ToString();
                txtLocationInfo.Text = advert.Location;
                

            }
        }
    }
}


 

