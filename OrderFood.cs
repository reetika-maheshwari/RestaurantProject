using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyControls;

namespace RestaurantProject
{
    public partial class OrderFood : BaseForm
    {
       
        public OrderFood()
        {
            InitializeComponent();
            FormMenuObject = MenuObject.Order;
        }
        private void OrderFood_Load(object sender, EventArgs e)
        {

        }

        private enum PaymentMode
        {
            Cash = 0,
            Online_GPay = 1,
            Online_PayTM = 2,
            Online_PhonePay = 3,
        }

        private void SetGrid()
        {
            gvMenu.Columns.Clear();
            GeneralFunction.AddColumn(gvMenu, GridColumnType.Text, "ID", "ID", 0, false);
            GeneralFunction.AddColumn(gvMenu, GridColumnType.Image, "Image", "Image", 200, false);
            GeneralFunction.AddColumn(gvMenu, GridColumnType.Text, "Name", "Dish", 150, false);
            GeneralFunction.AddColumn(gvMenu, GridColumnType.Numeric, "Qty", "Qty", 50, true);
            GeneralFunction.AddColumn(gvMenu, GridColumnType.Numeric, "Rate", "Rate", 50, false);
            GeneralFunction.AddColumn(gvMenu, GridColumnType.Numeric, "Amount", "Amount", 80, false);

            //fit image in the cell
            DataGridViewImageColumn imageColumn = (DataGridViewImageColumn)gvMenu.Columns["Image"];
            imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
            
        }
        protected override void SetControlProperty()
        {
            txtContactNo.InputType = MyControls.ListSelection.TextInputType.Phone;

            txtName.InputType = MyControls.ListSelection.TextInputType.String;
            //txttotal.InputType = MyControls.ListSelection.TextInputType.Numeric;
            cmbPayment.Items.Clear();
            cmbPayment.Items.Add(new ComboItem(PaymentMode.Cash.GetHashCode().ToString(), "Cash"));
            cmbPayment.Items.Add(new ComboItem(PaymentMode.Online_GPay.GetHashCode().ToString(), "Online - Google Pay"));
            cmbPayment.Items.Add(new ComboItem(PaymentMode.Online_PayTM.GetHashCode().ToString(), "Online - PayTM"));
            cmbPayment.Items.Add(new ComboItem(PaymentMode.Online_PhonePay.GetHashCode().ToString(), "Online - Phone Pay"));

            cmbPerson.Items.Clear();
            for(int i=1;i<=10;i++)
            {
                cmbPerson.Items.Add(new ComboItem(i.ToString(), i.ToString()));
            }

            //for connect the list show from creating control to show control

            cmbTable.DropDownStyle = ComboBoxStyle.DropDownList;
            DataSet ds = Connection.GetData("Select concat(Table_No, ' - ', Sitting_Capacity) as Name from mst_tablebook order by Table_No");
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach(DataRow dr in ds.Tables[0].Rows)
                {
                    cmbTable.Items.Add(dr["Name"]);
                }
            }

            SetGrid();
            FillGrid();
        }

        private void FillGrid()
        {
            gvMenu.Rows.Clear();
            DataSet ds = Connection.GetData("Select Id, Dish_Name, Rate, path_image from et_menu order by Dish_Name");

            if (ds == null || ds.Tables.Count <= 0 || ds.Tables[0].Rows.Count <= 0)
            {
                return;
            }
           // else if()

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                int r = gvMenu.Rows.Add();

                DataGridViewRow gridRow = gvMenu.Rows[r];

                gridRow.Cells["Id"].Value = dr["Id"];
                gridRow.Cells["Name"].Value = dr["Dish_Name"];
                gridRow.Cells["Rate"].Value = dr["Rate"];
                string path_image = Convert.ToString(dr["path_image"]);
                if (string.IsNullOrWhiteSpace(path_image) == false &&
                    System.IO.File.Exists(path_image))
                {
                    gridRow.Cells["Image"].Value = System.Drawing.Image.FromFile(path_image);
                }
            }
        }
        protected override void InitEntry()
        {
            base.InitEntry();
           
            txtName.Text = "";
            txtContactNo.Text = "";
            txttotal.Text = "";
            cmbPerson.Text = "";
            cmbTable.Text = "";
            cmbPayment.Text = "";
            //GridColumnType.Numeric, Qty = "";
        } 

        protected override object ControlToClass()
        {
            orderFood od = new orderFood();
            od.Name = txtName.Text;
            od.Contact = txtContactNo.Text;
            od.Tableno = cmbTable.Text;
            od.Noofperson = cmbPerson.Text;
            od.Total = Convert.ToInt32(txttotal.Text.ToString());
            od.Payment = cmbPayment.Text;
            od.Date = Convert.ToDateTime(dtDate.Text.ToString());
            return od;
        }

        protected override bool InputIsValid()
        {
            base.InputIsValid();
            orderFood od = objControlToClass as orderFood;

            if (od.Name == "")
            {
                MessageBox.Show("Emp name cannot be left blank");
                txtName.Focus();
                return false;
            }

            if (od.Contact == "")
            {
                MessageBox.Show("Section name cannot be left blank");
                txtContactNo.Focus();
                return false;
            }
            return true;
        }

        protected override string SaveAsNew()
        {
            orderFood od = objControlToClass as orderFood;
            //int DishId = 0;
            int DishRate = 0;
            int Quantity = 0;
            int Amount = 0;
            long lastInsertedID = 0;
            string error = Connection.SetData("INSERT INTO et_order(Name, Contact, Table_No, No_ofPerson, Date, Payment, Total_Amount) " +
                    " VALUES('" + od.Name + "', '" + od.Contact + "', '" + od.Tableno + "', '" + od.Noofperson + "', '" + od.Date.ToString("yyyy-MM-dd") + "', '" + od.Payment + "','" + od.Total + "')", out lastInsertedID);

            if (string.IsNullOrWhiteSpace(error) == false)
            {
                return error;
            }

            foreach (DataGridViewRow row in gvMenu.Rows)
            {
                DishRate = MyConvert.ToInt(row.Cells["Rate"].Value);
                Quantity = MyConvert.ToInt(row.Cells["Qty"].Value);
                Amount = DishRate * Quantity;

                if (Quantity != 0)
                {
                    error = Connection.SetData("INSERT INTO et_orderdetail (Parent_Id, Dish_Id, Rate, Qty, Amount) " +
                                " VALUES(" + lastInsertedID + ", " + MyConvert.ToInt(row.Cells["Id"].Value) + ", '" + DishRate + "', '" + Quantity + "', '" + Amount + "') ");
                    if (string.IsNullOrWhiteSpace(error) == false)
                    {
                        return error;
                    }
                }
            }

            return "";
        }

        protected override string Update()
        {
            orderFood od = objControlToClass as orderFood;
            return Connection.SetData("Update et_order Set Name = '" + od.Name + "',Contact_No = '" + od.Contact + "'where id =" + FormID);
        }

        protected override void Display()
        {
            //DataSet ds = Connection.GetData("select od.id, o.Name as customer_name, mn.Dish_Name, od.Qty, od.Rate, od.Amount, o.Total_Amoun" +
            //                        "from et_orderdetail as od" +
            //                        "left outer join et_order o on o.id = od.Parent_Id" +
            //                        "left outer join et_menu mn on mn.Id = od.Dish_Id" +
            //                        "where id = " + FormID);

            DataSet ds = Connection.GetData("select * from et_order where id = " + FormID);



            if (ds == null ||
                ds.Tables.Count <= 0 ||
                ds.Tables[0].Rows.Count <= 0)
            {
                return;
            }

            DataRow dr = ds.Tables[0].Rows[0];
            txtName.Text = Convert.ToString(dr["Name"]);
            txtContactNo.Text = Convert.ToString(dr["Contact"]);
            cmbTable.Text = Convert.ToString(dr["Table_No"]);
            cmbPerson.Text = Convert.ToString(dr["No_ofPerson"]);
            cmbPayment.Text = Convert.ToString(dr["Payment"]);
            txttotal.Text = Convert.ToString(dr["Total_Amount"]);
        }
        protected override string Delete()
        {
            return Connection.SetData("Delete from et_order where id = " + FormID);
        }





        private void gvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
               

        }
        private void btnReceipt_Click_1(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtResult.Text += "*******************************************************\n";
            txtResult.Text+= "**                   Order Payment Receipt            **\n";
            txtResult.Text += "*******************************************************\n";
            txtResult.Text += "Date :" + DateTime.Now + "\n\n";

            txtResult.Text += "Customer Name        : " + txtName.Text + "\n\n";
            txtResult.Text += "Contact No           : " + txtContactNo.Text + "\n\n";
            txtResult.Text += "Table No             : " + cmbTable.Text + "\n\n";
            txtResult.Text += "No of Person         : " + cmbPerson .Text + "\n\n";
            txtResult.Text += "Payment Mode         : " + cmbPayment.Text + "\n\n";
            txtResult.Text += "Total Payble Amount  : " + txttotal.Text + "\n\n";
           // txtResult.Text += "Dish Name            : " + gvMenu.Rows[e.RowIndex].Cells["Dish"].Value + "\n\n";    

            txtResult.Text += "\n                                                 Signature";            

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtContactNo.Text = "";
            cmbTable.Text = "";
            cmbPerson.Text = "";
            cmbPayment.Text = "";
            txttotal.Text = "";
            txtResult.Text = "";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtResult.Text, new Font("Microsoft Sans Serif", 24, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void gvMenu_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (gvMenu.Columns[e.ColumnIndex].Name == "Qty")
            {
                gvMenu.Rows[e.RowIndex].Cells["Amount"].Value = Convert.ToDouble(gvMenu.Rows[e.RowIndex].Cells["Qty"].Value) * Convert.ToDouble(gvMenu.Rows[e.RowIndex].Cells["Rate"].Value);
                DoTotal();
            }
        }   
        private void DoTotal()
        {
            double sum = 0;
            for(int i=0; i<gvMenu.Rows.Count; i++)
            {
                if (Convert.ToBoolean(gvMenu.Rows[i].Cells["Amount"].Value) == true)
                {
                    sum += double.Parse(gvMenu.Rows[i].Cells["Amount"].Value.ToString());
                }

            }
            txttotal.Text = sum.ToString();

        }


    }
}



