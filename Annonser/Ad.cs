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
        public bool isLoggedIn = false;

        Database db;
        public Ad()
        {
            InitializeComponent();
            db = new Database();


        }

        private void Ad_Load(object sender, EventArgs e)
        {
            db.AdLoad(cboCategori, listBox1);
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            db.Search(txtSearch.Text, cboCategori, listBox1);

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            using(Login loginWindow = new Login())
            {
                loginWindow.ShowDialog();
            }
            cmdMyAd.Visible = true;
            cmdEditAd.Visible = true;



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
            db.ListBoxSelect(listBox1, txtInfoDescription, txtInfoTitel, txtPriceInfo, txtLocationInfo);
        }

        private void Ad_Show(object sender, EventArgs e)
        {
            if (db.login == true)
            {
                cmdMyAd.Visible = true;
                cmdEditAd.Visible = true;
            }
            else
            {
                cmdMyAd.Visible = false;
                cmdEditAd.Visible = false;
            }
        }
    }
}




