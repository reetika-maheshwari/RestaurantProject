using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;


namespace RestaurantProject
{
    public partial class ForgotPasswordForm : Form
    {
        
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            DataSet ds = Connection.GetData("Select * FROM mst_users Where User_Name = '" + txtUserName.Text + " ' and EmailId = '" + txtEmail.Text + " '");
            if (ds == null ||
                ds.Tables.Count <= 0 ||
                ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Invalid Username or Email  , Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUserName.Text = "";
                //txtPhone.Text = "";
                txtEmail.Text = "";
                txtUserName.Focus();
            }
            else
            {
                this.Hide();
                new ChangePasswardForm(txtUserName.Text).Show();

            }

        }
    }

       
    }

