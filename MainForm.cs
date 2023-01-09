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
    public partial class MainForm : Form
    {
       
        public MainForm()
        {
            
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            mainDashboardUI1.Visible = false;
            StaffForm frm = new StaffForm();
            frm.MdiParent = GeneralFunction.mdiForm;
            frm.Show();
           

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainDashboardUI1.Visible = false;
            Report frm = new Report();
            frm.MdiParent = GeneralFunction.mdiForm;
            frm.Show();
        }

    

      
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //HomeNew frm = new HomeNew();
            //frm.MdiParent = GeneralFunction.mdiForm;
            //frm.Show();
              mainDashboardUI1.Visible = true;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            mainDashboardUI1.Visible = false;
            MenuForm frm = new MenuForm();
            frm.MdiParent = GeneralFunction.mdiForm;
            frm.Show();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            mainDashboardUI1.Visible = false;
            AboutForm frm = new AboutForm();
            frm.MdiParent = GeneralFunction.mdiForm;
            frm.Show();

        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            mainDashboardUI1.Visible = false;
            ContactUsForm frm = new ContactUsForm();
            frm.MdiParent = GeneralFunction.mdiForm;
            frm.Show();


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
             
        }
        public void SearchData(string ValueToSearch)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            mainDashboardUI1.Visible = false;
            OrderFood frm = new OrderFood();
            frm.MdiParent = GeneralFunction.mdiForm;
            frm.Show(); 
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            mainDashboardUI1.Visible = false;
            TableForm frm = new TableForm();
            frm.MdiParent = GeneralFunction.mdiForm;
            frm.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            new LogInForm().Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.whatsapp.com/");
        }

        private void picInsta_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/");
        }

        private void picFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void picTwitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/");
        
        }

        private void picLinkedIn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://in.linkedin.com/");
        }

        private void mainDashboardUI1_Load(object sender, EventArgs e)
        {

        }
    }
}
