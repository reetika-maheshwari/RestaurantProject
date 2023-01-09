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
using System.Windows.Forms.DataVisualization.Charting;

namespace RestaurantProject
{
    public partial class MainDashboardUI : UserControl
    {
        

        public MainDashboardUI()
        {
            InitializeComponent();
        }
        

       
        
        private void FillChart()
        {
            DataSet ds = Connection.GetData("select Sale_Month,Sale_Amount from order_sale");
            chart1.DataSource = ds;
            chart1.Series["Sales"].XValueMember = "Sale_Month";
            chart1.Series["Sales"].YValueMembers = "Sale_Amount";
            chart1.Titles.Add("Order Sales");
        }

        private void MainDashboardUI_Load(object sender, EventArgs e)
        {
            FillChart();
            //used to display images on dashboard images slider
           // Sliderpbx.ImageLocation = string.Format(@"D:\project\RestaurantProject\Images\" + ImageNumber + ".jpg");
            //cb1.Checked = true;
                 
            //Design UI show count of records in their UI
            DataSet ds = Connection.GetData("Select Count(*) from mst_staff");
            Int32 rows_count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            lbltotalStaff.Text = rows_count.ToString();


            DataSet ds1 = Connection.GetData("Select Count(*) from et_order");
            Int32 rows_count1 = Convert.ToInt32(ds1.Tables[0].Rows[0][0]);
            lblTotalOrders.Text = rows_count1.ToString();


            DataSet ds2 = Connection.GetData("Select Count(*) from mst_contactus");
            Int32 rows_count2 = Convert.ToInt32(ds2.Tables[0].Rows[0][0]);
            lblTotalVisitors.Text = rows_count2.ToString();


            DataSet ds3 = Connection.GetData("Select Count(*) from et_menu");
            Int32 rows_count3 = Convert.ToInt32(ds3.Tables[0].Rows[0][0]);
            lblTotalItems.Text = rows_count3.ToString();          
                        
        }
                   
         private void btnBar_Click(object sender, EventArgs e)
        {
            chart1.Series["Sales"].ChartType = SeriesChartType.Bar;
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            chart1.Series["Sales"].ChartType = SeriesChartType.Area;
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            chart1.Series["Sales"].ChartType = SeriesChartType.Line;
        }

        private void btnPie_Click(object sender, EventArgs e)
        {
            chart1.Series["Sales"].ChartType = SeriesChartType.Pie;

        }

        private void btnContactUs2_Click(object sender, EventArgs e)
        {
            ContactUsForm form = new ContactUsForm();
            form.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        
    }
}
