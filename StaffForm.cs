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
    public partial class StaffForm : BaseForm
    {
        public StaffForm()
        {
            InitializeComponent();
            FormMenuObject = MenuObject.Staff;
        }
        protected override void SetControlProperty()
        {
            txtEmpName.InputType = MyControls.ListSelection.TextInputType.String;
            txtFName.InputType = MyControls.ListSelection.TextInputType.String;
            txtMName.InputType = MyControls.ListSelection.TextInputType.String;
            txtContact.InputType = MyControls.ListSelection.TextInputType.Phone;
            txtAddress.InputType = MyControls.ListSelection.TextInputType.String;


            cmbDesignation.Items.AddRange(new object[] {
            "Restaurant Manager",
            "Server",
            "Host",
            "Busser",
            "Runner",
            "Account Executive",
            "Dishwasher",
            "Chef",
            "IT Executive",
            "Clerk",
            "CEO"});
                      
            
        }

        protected override void InitEntry()
        {
            base.InitEntry();

            txtEmpName.Text = "";
            txtFName.Text = "";
            txtMName.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            cmbDesignation.Text = "";
            cmbGender.Text = "";
            txtSalary.Text = "";
        }


        protected override object ControlToClass()
        {
            Staff st = new Staff();
            st.EmpName = txtEmpName.Text;
            st.DOB = Convert.ToDateTime(dtDOB.Text.ToString());
            st.DOJ = Convert.ToDateTime(dtDOJ.Text.ToString());
            st.FName = txtFName.Text;
            st.MName = txtMName.Text;
            st.contact = txtContact.Text;
            st.Address = txtAddress.Text;
            st.designation = cmbDesignation.Text;
            st.Gender = cmbGender.Text;

            st.salary = txtSalary.Text; 

            return st;
        }


        protected override bool InputIsValid()
        {
            base.InputIsValid();
            Staff st = objControlToClass as Staff;

            if (st.EmpName == "")
            {
                MessageBox.Show("Emp name cannot be left blank");
                txtEmpName.Focus();
                return false;
            }

            if (st.FName == "")
            {
                MessageBox.Show("Section name cannot be left blank");
                txtFName.Focus();
                return false;
            }
            if (st.MName == "")
            {
                MessageBox.Show("Section name cannot be left blank");
                txtMName.Focus();
                return false;
            }
           if (st.contact ==  "")
           {
                MessageBox.Show("Section name cannot be left blank");
                txtContact.Focus();
                return false;
            }
            if (st.Address == "")
            {
                MessageBox.Show("Section name cannot be left blank");
                txtAddress.Focus();
                return false;
            }

            return true;
        }

        protected override string SaveAsNew()
        {
            Staff st = objControlToClass as Staff;

            return Connection.SetData("Insert into mst_staff(Emp_Name, F_Name, M_Name, DOB, DOJ, Salary, Gender, Designation, Address, Contact_No) " +
            " values ('" + st.EmpName + "', '" + st.FName + "', '" + st.MName + "', '" + st.DOB.ToString("yyyy-MM-dd") + "', '" + st.DOJ.ToString("yyyy-MM-dd") + "','" + st.salary + "', '" + st.Gender + "', '" + st.designation + "', '" + st.Address + "', '" + st.contact + "')") ;
        }

        protected override string Update()
        {
            Staff st = objControlToClass as Staff;
            return Connection.SetData("Update mst_staff Set Emp_Name = '" + st.EmpName + "',F_Name = '" + st.FName + "', M_Name = '" + st.MName + "', DOB = '" + st.DOB.ToString("yyyy-MM-dd") + "',DOJ = '" + st.DOJ.ToString("yyyy-MM-dd") + "', Salary = '" + st.salary + "', Gender =  '" + st.Gender + "', Designation = '" + st.designation + "' , Address = '" + st.Address + "', Contact_No = '" + st.contact + "'where id =" + FormID);
        }

        protected override void Display()
        {
            DataSet ds = Connection.GetData("Select * from mst_staff where id = " + FormID);
            if (ds == null ||
                ds.Tables.Count <= 0 ||
                ds.Tables[0].Rows.Count <= 0)
            {
                return;
            }

            DataRow dr = ds.Tables[0].Rows[0];
            txtEmpName.Text = Convert.ToString(dr["Emp_Name"]);
            txtFName.Text = Convert.ToString(dr["F_Name"]);
            txtMName.Text = Convert.ToString(dr["M_Name"]);
            txtFName.Text = Convert.ToString(dr["F_Name"]);
            // dtDOB.Text = Convert.ToString(dr["DOB"]);
            //dtDOJ.Text = Convert.ToString(dr["DOJ"]);
            txtSalary.Text = Convert.ToString(dr["Salary"]);
            cmbGender.Text = Convert.ToString(dr["Gender"]);
            cmbDesignation.Text = Convert.ToString(dr["Designation"]);
            txtAddress.Text = Convert.ToString(dr["Address"]);
            txtContact.Text = Convert.ToString(dr["Contact_No"]);
        }

        protected override string Delete()
        {
            return Connection.SetData("Delete from mst_staff where id = " + FormID);
        }

        private void txtContact_KeyPress(object sender, KeyPressEventArgs e)
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

       

        

       
        private void StaffForm_Load(object sender, EventArgs e)
        {

        }
    }
    }



