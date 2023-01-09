using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace RestaurantProject
{
    public partial class LogInForm : Form
    {
        public int logAttempt = 0;

        public LogInForm()
        {
            InitializeComponent();
            Init_Data();
        }
               

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            
            //String error = Connection.SetData("Select * FROM mst_users Where User_Name='" + txtUserName.Text + "',Passward='" + txtPassward.Text + "'");

            DataSet ds = Connection.GetData("Select * FROM mst_users Where User_Name='" + txtUserName.Text + "' and Passward='" + txtPassward.Text + "'");
            Save_Data();
            if (ds == null ||  ds.Tables.Count <= 0 || ds.Tables[0].Rows.Count <= 0)
                
            {

                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();
                //txtUserName.Text = "";
                //txtPassward.Text = "";
               // txtUserName.Focus();
                logAttempt += 1;
                if (logAttempt == 3)
                {
                    MessageBox.Show("you have exceeded the maximum number of login attemts", "login failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtUserName.Enabled = false;
                    txtPassward.Enabled = false;
                    btnLogIn.Enabled = false;

                }
                
            }
            else
            {
               
                this.Hide();

                GeneralFunction.mdiForm = new MainForm();

                GeneralFunction.mdiForm.Show();

            }
         
            

        }
        public void Reset()
        {
            txtUserName.Text = string.Empty;
            txtPassward.Text = string.Empty;

        }

      
        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                txtPassward.PasswordChar = '\0';
            }
            else
            {
                txtPassward.PasswordChar = '*';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new FrmRegister().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.Cancel;
            Application.Exit();
        }

        private void lblForgotPass_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm fp = new ForgotPasswordForm();
            this.Hide();
            fp.Show();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Enter Your Name")
            {
                txtUserName.Text = "";

                txtUserName.ForeColor = Color.LightCoral;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                txtUserName.Text = "Enter Your Name";

                txtUserName.ForeColor = Color.LightCoral;
            }
        }

        private void txtPassward_Enter(object sender, EventArgs e)
        {
            if (txtPassward.Text == "Enter Your Passward")
            {
                txtPassward.Text = "";

                txtPassward.ForeColor = Color.LightCoral;
            }
        }

        private void txtPassward_Leave(object sender, EventArgs e)
        {
            if (txtPassward.Text == "")
            {
                txtPassward.Text = "Enter Your Passward";

                txtPassward.ForeColor = Color.LightCoral;
            }
        }
        private void Init_Data()
        {
            if (Properties.Settings.Default.UserName != string.Empty)
            {
                if (Properties.Settings.Default.Remme == "yes")
                {
                    txtUserName.Text = Properties.Settings.Default.UserName;
                    txtPassward.Text = Properties.Settings.Default.Password;
                    chkRememberMe.Checked = true;
                }
                else
                {
                    txtUserName.Text = Properties.Settings.Default.UserName;
                    txtPassward.Text = Properties.Settings.Default.Password;
                }
                
            }
        }

        private void Save_Data()
        {
            if (chkRememberMe.Checked)
            {
                Properties.Settings.Default.UserName = txtUserName.Text;
                Properties.Settings.Default.Password = txtPassward.Text;
                Properties.Settings.Default.Remme = "yes";
                Properties.Settings.Default.Save();
            }
            else
            {

                Properties.Settings.Default.UserName = txtUserName.Text;
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remme = "no";
                Properties.Settings.Default.Save();
            }
        }


    }
}
