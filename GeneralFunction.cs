using System;
using System.Collections.Generic;
//Creating by sir for connect child page on Main Parent Page
using System.Windows.Forms;



namespace RestaurantProject
{
    public enum MenuObject
    {
        None = 0,
        Staff = 1,
        Menu = 2,
        Table = 3,
        Order = 4,
        Report = 5,
        Contactus = 6,


    }
    public enum Gender
    {
        Male = 0,
        Female = 1,
    }

    public enum GridColumnType
    {
        Text = 0,
        Numeric = 1,
        Date = 2,
        Image = 4,
        CheckBox = 5
    }
    //public enum ImageLayout
    //{
    //    None = 0,
    //    Tile = 1,
    //    Center = 2,
    //    Stretch = 3,
    //    Zoom = 4
    //}

    internal enum ReportType
    {
        None,
        StaffReport,
        SalesReport,
        ItemReport
    }

    internal class ReportFilter
    {
        internal DateTime from_date;
        internal DateTime to_date;
        internal string name_like;
    }
    internal static class GeneralFunction
    {
        internal static Form mdiForm = null;

        internal static void SetColumn(DataGridView gvList, string name, string caption, int width)
        {
            if (gvList.Columns.Contains(name) == false)
            {
                return;
            }
            gvList.Columns[name].HeaderText = caption;
            gvList.Columns[name].Width = width;
            if (width == 0)
            {
                gvList.Columns[name].Visible = false;
            }
        }

        internal static void AddColumn(DataGridView gvList, GridColumnType ColumnType, string name, string caption, int width, bool Editable)
        {
            
            if (gvList.Columns.Contains(name))
            {
                return;
            }

            DataGridViewColumn col = null;
            if (ColumnType == GridColumnType.Image)
            {
               
                col = new DataGridViewImageColumn();
                DataGridViewImageColumn Image = new DataGridViewImageColumn();
                Image.ImageLayout = DataGridViewImageCellLayout.Stretch;
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }
            else if (ColumnType == GridColumnType.CheckBox)
            {
                col = new DataGridViewCheckBoxColumn();
            }
            else if (ColumnType == GridColumnType.Numeric)
            {
                col = new DataGridViewTextBoxColumn();
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            else
            {
                col = new DataGridViewTextBoxColumn();
            }

            col.Name = name;
            col.HeaderText = caption;
            col.Width = width;
            col.Visible = width > 0;
            col.ReadOnly = !Editable;


            gvList.Columns.Add(col);
        }
    
    }

    internal static class MyConvert
    {
        internal static string ToString(object val)
        {
            if (val == null)
            {
                return "";
            }

            return Convert.ToString(val);
        }

        internal static int ToInt(object val)
        {
            if (val == null)
            {
                return 0;
            }

            return Convert.ToInt32(val);
        }

        internal static double ToDouble(object val)
        {
            if (val == null)
            {
                return 0;
            }

            return Convert.ToDouble(val);
        }
    }

   internal class Staff
    {
       internal int id;
       internal String EmpName;
       internal String FName;
       internal String MName;
       internal DateTime DOB;
       internal DateTime DOJ;
       internal String contact;
       internal String salary;
       internal String Gender;
       internal String designation;
       internal String Address;

        
    }
    internal class Menu
    {
        
        internal String DishName;
        internal String Category;
        internal String FoodType;
        internal int Rate;
        internal String path_image;
    }
    internal class ContactForm
    {
        
        internal String Name;
        internal string Contact;
        internal String Email_Id;
        internal String Gender;
        internal String City;
        internal String Message;
    }
    internal class TableBook
    {
        internal string Table_No;
        internal string Sitting_Capacity;
        
    }

    internal class orderFood
    {
        internal string Name;
        internal string Contact;
        internal string Tableno;
        internal string Noofperson;
        internal string Payment;
        internal int Total;
        internal DateTime Date;
        internal List<orderFoodDetail> Detail;

        internal orderFood()
        {
            Detail = new List<orderFoodDetail>();
        }
    }

    internal class orderFoodDetail
    {
        internal int DishID;
        internal double Rate;
        internal double Qty;
        internal double Amount;
    }

    internal class user
    {
        internal String UserName;
        internal String Passward;
        internal String ContactNo;
        internal String EmailId;

    }

    internal class orderdetail
    {
        internal int Parent_Id;
        internal int Dish_Id;
        internal int Rate;
        internal int Qty;
        internal int Amount;
    }

}







