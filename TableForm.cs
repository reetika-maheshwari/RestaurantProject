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
    public partial class TableForm : BaseForm
    {
        public TableForm()
        {
            InitializeComponent();
            FormMenuObject = MenuObject.Table;
        }
        protected override void SetControlProperty()
        {
            txtTable.InputType = MyControls.ListSelection.TextInputType.Numeric;
            txtSitting.InputType = MyControls.ListSelection.TextInputType.Numeric;

        }
        protected override void InitEntry()
        {

            txtTable.Text = "";
            txtSitting.Text = "";
            
            
        }

        protected override object ControlToClass()
        {
            TableBook tb = new TableBook();
            tb.Table_No = txtTable.Text;
            tb.Sitting_Capacity = txtSitting.Text;
            

            return tb;
        }

        protected override bool InputIsValid()
        {
            base.InputIsValid();
            TableBook tb = objControlToClass as TableBook;

            if (tb.Table_No == "")
            {
                MessageBox.Show("Dish name cannot be left blank");
                txtTable.Focus();
                return false;
            }

            if (tb.Sitting_Capacity == "")
            {
                MessageBox.Show("Category name cannot be left blank");
                txtSitting.Focus();
                return false;
            }
             return true;
        }

        protected override string SaveAsNew()
        {
            TableBook tb = objControlToClass as TableBook;


            return Connection.SetData("Insert into mst_tablebook(Table_No, Sitting_Capacity)" +
                " values ('" + tb.Table_No + "', '" + tb.Sitting_Capacity + "')");
        }
        protected override string Update()
        {
            TableBook tb = objControlToClass as TableBook;
            return Connection.SetData("Update mst_tablebook Set Table_No = '" + tb.Table_No + "',Sitting_Capacity = '" + tb.Sitting_Capacity + "', where id =" + FormID);

        }


        protected override void Display()
        {
            DataSet ds = Connection.GetData("Select * from mst_tablebook where ID = " + FormID);
            if (ds == null ||
                ds.Tables.Count <= 0 ||
                ds.Tables[0].Rows.Count <= 0)
            {
                return;
            }

            DataRow dr = ds.Tables[0].Rows[0];
            txtTable.Text = Convert.ToString(dr["Table_No"]);
            txtSitting.Text = Convert.ToString(dr["Sitting_Capacity"]);
           
          }

        protected override string Delete()
        {
            return Connection.SetData("Delete from mst_tablebook where id = " + FormID);
        }

        private void txtTable_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch))
            {
                e.Handled = false;

            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtSitting_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (Char.IsDigit(ch))
            {
                e.Handled = false;

            }
            else if (ch == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TableForm_Load(object sender, EventArgs e)
        {

        }
    }
}
