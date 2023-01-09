using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantProject
{
    public partial class HomeNew : Form
    {
        public HomeNew()
        {
            InitializeComponent();
        }

        private void btnTablebook_Click(object sender, EventArgs e)
        {
            TableForm frm = new TableForm();
          
            frm.Show();
        }

        private void btnContactUs2_Click(object sender, EventArgs e)
        {
            ContactUsForm frm = new ContactUsForm();
            
            frm.Show();
        }

        private void btnOurMenu_Click(object sender, EventArgs e)
        {
            MenuForm frm = new MenuForm();

            frm.Show();
        }
    }
}
