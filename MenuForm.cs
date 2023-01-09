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
    public partial class MenuForm : BaseForm
    {
        
        public MenuForm()
        {
            InitializeComponent();
            FormMenuObject = MenuObject.Menu;
        }



        protected override void SetControlProperty()
        {
            txtDishName.InputType = MyControls.ListSelection.TextInputType.String;
            txtCategory.InputType = MyControls.ListSelection.TextInputType.String;
            txtFoodType.InputType = MyControls.ListSelection.TextInputType.String;
            txtRate.InputType = MyControls.ListSelection.TextInputType.Numeric;

        }
        protected override void InitEntry()
        {
            base.InitEntry();

            FormID = 0;
            txtDishName.Text = "";
            txtCategory.Text = "";
            txtFoodType.Text = "";
            txtRate.Text = "";
            pbxFoodImage.Image = null;
            pbxFoodImage.Tag = "";
        }

        protected override object ControlToClass()
        {
            Menu mn = new Menu();
            mn.DishName = txtDishName.Text;
            mn.Category = txtCategory.Text;
            mn.FoodType = txtFoodType.Text;
            mn.Rate = Convert.ToInt32(txtRate.Text);
            mn.path_image = Convert.ToString(pbxFoodImage.Tag).Replace("\\", "\\\\");

            return mn;
        }

        protected override bool InputIsValid()
        {
            base.InputIsValid();
            Menu mn = objControlToClass as Menu;

            if (mn.DishName == "")
            {
                MessageBox.Show("Dish name cannot be left blank");
                txtDishName.Focus();
                return false;
            }

            if (mn.Category == "")
            {
                MessageBox.Show("Category name cannot be left blank");
                txtCategory.Focus();
                return false;
            }
            if (mn.FoodType == "")
            {
                MessageBox.Show("Food type cannot be left blank");
                txtFoodType.Focus();
                return false;
            }
            
            return true;
        }


        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Select image(*.jpg; *.png; *.Gif) | *.jpg; *.png; *.Gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbxFoodImage.Image = Image.FromFile(openFileDialog1.FileName);
                pbxFoodImage.Tag = openFileDialog1.FileName;
            }
        }

        protected override string SaveAsNew()
        {
            Menu mn = objControlToClass as Menu;

            return Connection.SetData("Insert into et_menu(Dish_Name, Category, Food_Type, Rate, path_image)" +
                " values ('" + mn.DishName + "', '" + mn.Category + "','" + mn.FoodType + "', '" + mn.Rate + "', '" + mn.path_image + "')");
        }
        protected override string Update()
        {
            Menu mn = objControlToClass as Menu;
            return Connection.SetData("Update et_menu Set Dish_Name = '" + mn.DishName + "',Category = '" + mn.Category + "', Food_Type = '" + mn.FoodType + "', Rate = '" + mn.Rate + "', path_image = '" + mn.path_image + "' where id =" + FormID);

        }


        protected override void Display()
        {
            DataSet ds = Connection.GetData("Select * from et_menu where ID = " + FormID);
            if (ds == null ||
                ds.Tables.Count <= 0 ||
                ds.Tables[0].Rows.Count <= 0)
            {
                return;
            }

            DataRow dr = ds.Tables[0].Rows[0];
            txtDishName.Text = Convert.ToString(dr["Dish_Name"]);
            txtCategory.Text = Convert.ToString(dr["Category"]);
            txtFoodType.Text = Convert.ToString(dr["Food_Type"]);
            txtRate.Text = Convert.ToString(dr["Rate"]);
            string path_image = Convert.ToString(dr["path_image"]);
            if (string.IsNullOrWhiteSpace(path_image) == false &&
                System.IO.File.Exists(path_image))
            {

                pbxFoodImage.Image = Image.FromFile(path_image);
                pbxFoodImage.Tag = path_image;
            }
        }

        protected override string Delete()
        {
            return Connection.SetData("Delete from et_menu where id = " + FormID);
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRate_KeyPress(object sender, KeyPressEventArgs e)
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

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
