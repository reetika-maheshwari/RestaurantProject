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
    public partial class ContactUsForm : Form
    {
        public ContactUsForm()
        {
            InitializeComponent();
        }
        private void InitEntry()
        {
            txtName.Text = "";
            txtContact.Text = "";
            txtEmail.Text = "";
            txtGender.Text = "";
            txtCity.Text = "";
            txtMessage.Text = "";
        }

        private void ContactUsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ContactForm CT = new ContactForm();

            CT.Name = txtName.Text;
            CT.Contact = txtContact.Text;
            CT.Email_Id = txtEmail.Text;
            CT.Gender = txtGender.Text;
            CT.City = txtCity.Text;
            CT.Message = txtMessage.Text;
            
           string error = Connection.SetData("Insert into mst_contactus(Name, Contact, Email_Id, Gender, City, Message) " +
                " values ('" + CT.Name + "', '" + CT.Contact + "', '" + CT.Email_Id + "', '" + CT.Gender + "', '" + CT.City + "','"+ CT.Message +"')");
            if (error == "")
            {
                MessageBox.Show("Data Save Sucessfully");
            }
            else
            {
                MessageBox.Show("Error in Saving : " + error);
            }
            InitEntry();
        }

      
    }
}
