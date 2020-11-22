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
    public partial class Ad : Form
    {
        AdvertRepo ar = new AdvertRepo();
        public bool isLoggedIn = false;
        public int UserID = 0;

        public Ad()
        {
            InitializeComponent();
        }

        private void Ad_Load(object sender, EventArgs e)
        {
            //db.AdLoad(cboCategori, listBox1);
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
                cboCategori.SelectedIndex = 0;
            }
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {

            listBox1.DataSource = null;
            if (txtSearch.Text == "")
            {
                listBox1.DataSource = AdvertRepo.GetData();
            }
            AdvertRepo search = new AdvertRepo();
            search.Search(txtSearch.Text, cboCategori, listBox1);
        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            using(Login loginWindow = new Login())
            {
                loginWindow.ShowDialog();
            }
            cmdMyAd.Visible = true;
            
        }

        public void SetUser(int userId)
        {
            this.UserID = userId;
        }

        private void cmdMyAd_Click(object sender, EventArgs e)
        {
            frmUserDetails ud = new frmUserDetails();
            ud.UserID = this.UserID;
            ud.Show();
            
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ar.ListBoxSelect(listBox1, txtInfoDescription, txtInfoTitel, txtPriceInfo, txtLocationInfo, txtSeller);
        }

        public void Ad_Show()
        {
                cmdMyAd.Visible = true;
        }

        private void cmdSortByDate_Click(object sender, EventArgs e)
        {
            USer user = new USer();
            UserID = user.UserID;
            listBox1.DataSource = null;
            using (AnnonserEntities1 db = new AnnonserEntities1())
            {
                List<Advert> adverts;

                //adverts = (List<Advert>)db.Adverts.GroupBy(x => x.AdvertDate).ToList();
                adverts = db.Adverts.Where(a => a.Title.Contains(txtSearch.Text)).OrderByDescending(a => a.AdvertDate).ToList();



                listBox1.DisplayMember = "Title";
                listBox1.DataSource = adverts;
            }
        }

        private void cmdSortByPrice_Click(object sender, EventArgs e)
        {
            USer user = new USer();
            UserID = user.UserID;
            listBox1.DataSource = null;
            using (AnnonserEntities1 db = new AnnonserEntities1())
            {
                List<Advert> adverts;

                adverts = db.Adverts.Where(a => a.Title.Contains(txtSearch.Text)).OrderByDescending(a => a.Price).ToList();

                listBox1.DisplayMember = "Title";
                listBox1.DataSource = adverts;
            }
        }
    }
}




