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
    public partial class BaseForm : Form
    {
        internal int FormID = 0;
        internal object objControlToClass = null;
        internal MenuObject FormMenuObject = MenuObject.None;
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            FormSetup();

            btnSave.Enabled = true;
            btnOpen.Enabled = true;
            btnCancel.Enabled = true;
            btnDelete.Enabled = false;
            btnExit.Enabled = true;
        }

        private void FormSetup()
        {
            SetControlProperty();
            InitEntry();
        }

        virtual protected void SetControlProperty()
        {
        }

        virtual protected void InitEntry()
        {
            FormID = 0;
        }

        virtual protected bool InputIsValid()
        {
            objControlToClass = ControlToClass();
            return true;
        }

        virtual protected object ControlToClass()
        {
            return null;
        }

        private bool Save()
        {
            objControlToClass = ControlToClass();

            string error = "";

            if (FormID == 0)
            {
                error = SaveAsNew();
            }
            else
            {
                error = Update();
            }

            if (error == "")
            {
                MessageBox.Show("Save sucessfully");
                return true;
            }
            else
            {
                MessageBox.Show("Error in saving : " + error);
                return false;
            }

        }

        virtual protected string SaveAsNew()
        {

            return "";
        }

        virtual protected string Update()
        {

            return "";
        }


        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (InputIsValid() == false)
            {
                return;
            }

            if (Save() == false)
            {
                return;
            }

            if (FormID == 0)//New Mode
            {
                InitEntry();

                btnSave.Enabled = true;
                btnOpen.Enabled = true;
                btnCancel.Enabled = true;
                btnDelete.Enabled = false;
                btnExit.Enabled = true;
            }
            else
            {
                InitEntry();
                OpenList();
            }
        }

        private void OpenList()
        {
            ListForm frm = new ListForm(FormMenuObject);
            frm.StartPosition = FormStartPosition.CenterScreen;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                InitEntry();
                FormID = frm.ID;
                Display();


                btnSave.Enabled = true;
                btnOpen.Enabled = false;
                btnCancel.Enabled = true;
                btnDelete.Enabled = true;
                btnExit.Enabled = true;
            }
            else
            {
                btnSave.Enabled = true;
                btnOpen.Enabled = true;
                btnCancel.Enabled = true;
                btnDelete.Enabled = false;
                btnExit.Enabled = true;
            }
        }

        private void btnOpen_Click_1(object sender, EventArgs e)
        {
            OpenList();
        }

        virtual protected void Display()
        {

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            if (FormID == 0)
            {
                InitEntry();
            }
            else
            {
                InitEntry();
                OpenList();
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult iCancel;
            iCancel = MessageBox.Show("Confirm you want to exit the System", "Table ordering system", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iCancel == DialogResult.Yes)
            {
                this.Close();
            }

        }

        virtual protected string Delete()
        {
            return "";
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (FormID == 0)
            {
                return;
            }

            string error = Delete(); 
            if (error == "")
            {
                MessageBox.Show("Delete successfully");
                InitEntry();
                OpenList();
            }
            else
            {
                MessageBox.Show("Error in delete: " + error);
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
