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
    public partial class frmUserDetails : Form
    {
        USer userIn = new USer();
        public frmUserDetails(USer user)
        {
            InitializeComponent();
            userIn = user;
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
