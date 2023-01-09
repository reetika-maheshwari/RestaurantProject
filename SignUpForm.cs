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
    public partial class FrmRegister : Form
    {
       
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
                       
            if (txtUserName.Text=="" && txtPassward.Text=="" && txtConfirmPassward.Text=="" && txtContactNo.Text=="" && txtEmailId.Text=="")
            {
                MessageBox.Show("Fields are empty", "SignUp Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassward.Text==txtConfirmPassward.Text)
            {
                String error = Connection.SetData("Insert into mst_users(User_Name, Passward, ContactNo, EmailId) values ('" + txtUserName.Text + "','" + txtPassward.Text + "','" + txtContactNo.Text + "','" + txtEmailId.Text + "')");


                MessageBox.Show("Your Account has been suceessfully created", "SignUp Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtUserName.Text = "";
                txtPassward.Text = "";
                txtConfirmPassward.Text = "";
                txtContactNo.Text = "";
                txtEmailId.Text = "";
                                  
            }
            else
            {
                MessageBox.Show("Password does not match, Please Re-enter", "Sign Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassward.Text = "";
                txtConfirmPassward.Text = "";
                txtPassward.Focus(); 
            }

        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                txtPassward.PasswordChar = '\0';
                txtConfirmPassward.PasswordChar = '\0';
            }
            else
            {
                txtPassward.PasswordChar = '*';
                txtConfirmPassward.PasswordChar = '*';
            }
        }

           
        private void lblBacktoLogin_Click(object sender, EventArgs e)
        {
            new LogInForm().Show();
            this.Hide();
        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
