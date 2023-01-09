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

//using for dailog Box

namespace RestaurantProject
{
    public partial class ListForm : Form
    {
        internal int ID = 0;
        MenuObject m_mnuObject = MenuObject.None;
        public ListForm(MenuObject mnuObject)
        {
            InitializeComponent();

            m_mnuObject = mnuObject;
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            FillGrid();
            SetGrid();

        }

        private void SetGrid()
        {
            if (m_mnuObject == MenuObject.Staff)
            {
                GeneralFunction.SetColumn(gvList, "id", "id", 0);
                GeneralFunction.SetColumn(gvList, "Emp_Name", "Name", 100);
                GeneralFunction.SetColumn(gvList, "F_Name", "Father Name", 100);
                GeneralFunction.SetColumn(gvList, "M_Name", "Mother Name", 100);
                GeneralFunction.SetColumn(gvList, "DOB", "DOB", 100);
                GeneralFunction.SetColumn(gvList, "DOJ", "DOJ", 100);
                GeneralFunction.SetColumn(gvList, "Contact", "Contact", 100);
                GeneralFunction.SetColumn(gvList, "Salary", "Salary", 100);
                GeneralFunction.SetColumn(gvList, "Gender", "Gender", 100);
                GeneralFunction.SetColumn(gvList, "Designation", "Designation", 100);
                GeneralFunction.SetColumn(gvList, "Address", "Address", 100);
            }
            else if (m_mnuObject == MenuObject.Menu)
            {
                GeneralFunction.SetColumn(gvList, "id", "id", 0);
                GeneralFunction.SetColumn(gvList, "Dish_Name", "Dish", 100);
                GeneralFunction.SetColumn(gvList, "Category", "Category", 100);
                GeneralFunction.SetColumn(gvList, "Food_Type", "Food Type", 100);
                GeneralFunction.SetColumn(gvList, "Rate", "Rate", 100);
            }
            else if (m_mnuObject == MenuObject.Table)
            {
                GeneralFunction.SetColumn(gvList, "id", "id", 0);
                GeneralFunction.SetColumn(gvList, "Table_No", "Table", 100);
                GeneralFunction.SetColumn(gvList, "Customer_Name", "Name", 100);
                GeneralFunction.SetColumn(gvList, "Contact_No", "Contact", 100);
                GeneralFunction.SetColumn(gvList, "Food_Type", "Food", 100);
            }


        }

        private void FillGrid()
        {
            DataSet ds = null;
            if (m_mnuObject == MenuObject.Staff)
            {
                ds = Connection.GetData("Select id,Emp_Name,Contact_No, Salary, Designation from mst_staff order by Emp_Name ");
            }
            else if (m_mnuObject == MenuObject.Menu)
            {
                ds = Connection.GetData("Select id, Dish_Name, Category, Food_Type, Rate from et_menu order by Dish_Name");
            }
            else if (m_mnuObject==MenuObject.Table)
            {
                ds = Connection.GetData("Select id, Table_No, Sitting_Capacity from mst_tablebook order by Table_No");
            }
            else if (m_mnuObject == MenuObject.Order)
            {
                //ds = Connection.GetData("select od.id, o.Name as customer_name, mn.Dish_Name, od.Qty, od.Rate, od.Amount, o.Total_Amoun" +
                //                    "from et_orderdetail as od" +
                //                    "left outer join et_order o on o.id = od.Parent_Id" +
                //                    "left outer join et_menu mn on mn.Id = od.Dish_Id" +
                //                    "order by od.id");
                // ds = Connection.GetData("select id,Parent_Id, Dish_Id, Rate, Qty, Amount from et_orderdetail order by id");
                ds = Connection.GetData("select o.id, o.Name as customer_name, mn.Dish_Name, od.Qty, od.Rate, od.Amount, o.Total_Amount " +
                                   " from et_order as o " +
                                   " left outer join et_orderdetail od on od.Parent_Id = o.id " +
                                   " left outer join et_menu mn on mn.Id = od.Dish_Id " +
                                   " order by o.id");

            }

                  gvList.DataSource = ds.Tables[0];
            lblTtl.Text = $"Total Record : {gvList.RowCount}";
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (gvList.SelectedRows == null ||
                gvList.SelectedRows.Count <= 0)
            {
                return;
            }

            ID = Convert.ToInt32(gvList.SelectedRows[0].Cells["id"].Value);
            if (ID == 0)
            {
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ID = 0;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void gvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
