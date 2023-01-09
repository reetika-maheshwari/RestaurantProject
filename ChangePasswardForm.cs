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
    public partial class ChangePasswardForm : Form
    {
        string m_user_name = "";

        public ChangePasswardForm()
        {
        }

        public ChangePasswardForm(string user_name)
        {
            InitializeComponent();
            m_user_name = user_name;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text == txtConfirmNewPass.Text)
            {

                String error = Connection.SetData("Update mst_users set Passward='" + txtConfirmNewPass.Text + "'where User_Name='"+m_user_name+"'");
                txtNewPassword.Text = "";
                txtConfirmNewPass.Text = "";
                txtNewPassword.Focus();

                MessageBox.Show("Passward Reset Successfully...");
            }
            else
            {
                MessageBox.Show("The new password do not match so try again....");
            }
            this.Hide();
            new LogInForm().Show();
        }

       
    }
}

