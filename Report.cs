using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MyControls;

namespace RestaurantProject
{
    public partial class Report : Form
    {
        
        public Report()
        {
            InitializeComponent();
        }

        ReportFilter filter = null;
        private void Report_Load(object sender, EventArgs e)
        {
            filter = new ReportFilter();
            filter.from_date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            filter.to_date = DateTime.Now;

            cmbReport.Items.Clear();
            cmbReport.Items.Add(new ComboItem(ReportType.StaffReport.GetHashCode().ToString(), "Staff Report"));
            cmbReport.Items.Add(new ComboItem(ReportType.SalesReport.GetHashCode().ToString(), "Sales Report"));
            cmbReport.Items.Add(new ComboItem(ReportType.ItemReport.GetHashCode().ToString(), "Item Report"));
            cmbReport.SelectedIndex = 0;

        }
         
        private void ShowReport()
        {
            ComboItem SelectedItem = cmbReport.SelectedItem as ComboItem;
            if(SelectedItem == null)
            {
                return;
            }

            ReportType rpt_type = (ReportType)Convert.ToInt32(SelectedItem.ID);
            if(rpt_type == ReportType.None)
            {
                return;
            }

            string query = "";
            string crit = "";

            switch (rpt_type)
            {
                case ReportType.StaffReport:
                    if (string.IsNullOrWhiteSpace(filter.name_like) == false)
                    {
                        crit += " And Emp_Name like '%" + filter.name_like + "%'";
                    }

                    query = "Select * from mst_staff Where 1=1 " + crit;
                    break;

                case ReportType.SalesReport:
                    crit += " And Date >= '" + filter.from_date.ToString("yyyy-MM-dd") + "'";
                    crit += " And Date <= '" + filter.to_date.ToString("yyyy-MM-dd") + "'";
                    if (string.IsNullOrWhiteSpace(filter.name_like) == false)
                    {
                        crit += " And Name like '%" + filter.name_like + "%'";
                    }

                    query = "Select * from et_order Where 1=1 " + crit;
                    break;

                case ReportType.ItemReport:
                    if (string.IsNullOrWhiteSpace(filter.name_like) == false)
                    {
                        crit += " And Dish_Name like '%" + filter.name_like + "%'";
                    }
                    query = "Select Id, Dish_Name, Category, Food_Type, Rate from et_menu Where 1=1 " + crit;
                    break;
            }

            DataSet ds = Connection.GetData(query);
            gvReport.DataSource = ds.Tables[0];
            lblTotal.Text = $"Total Records: {gvReport.RowCount}";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ShowReport();
        }  

        private void cmbReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowReport();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Files(2010)|*.xls|Excel Files(2007)|*.xlsx";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);
                //change properties of the workbook
                ExcelApp.Columns.ColumnWidth = 20;
                //storing hearder part in excel
                for(int i =1; i < gvReport.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = gvReport.Columns[i - 1].HeaderText;
                }
                //storing each row and column value to excel sheet
                for(int i = 0; i < gvReport.Rows.Count; i++)
                {
                    for(int j = 0; j < gvReport.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = gvReport.Rows[i].Cells[j].Value.ToString();
                    }
                }
                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }
        }
        
        private void gvReport_SortStringChanged(object sender, EventArgs e)
        {
            // gvReport.DataSource = gvReport.SortString;
            //DataSet ds = Connection.GetData("Select * from mst_staff");
            //gvReport.DataSource = ds.Tables[0];
            //this.gvReport.DataSource = this.gvReport.SortString;
            


        }

        private void gvReport_FilterStringChanged(object sender, EventArgs e)
        {
            //gvReport.DataSource = gvReport.FilterString;
           //DataSet ds = Connection.GetData("Select * from mst_staff");
           // gvReport.DataSource = ds.Tables[0];
           // this.gvReport.DataSource = this.gvReport.FilterString;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ComboItem SelectedItem = cmbReport.SelectedItem as ComboItem;
            if (SelectedItem == null)
            {
                return;
            }

            ReportType rpt_type = (ReportType)Convert.ToInt32(SelectedItem.ID);
            if (rpt_type == ReportType.None)
            {
                return;
            }

            ReportFilterForm form = new ReportFilterForm(rpt_type, filter);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ShowReport();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
    

