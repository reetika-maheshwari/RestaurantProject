
namespace RestaurantProject
{
    partial class ContactUsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactUsForm));
            this.picContactUs = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtName = new MyControls.ListSelection();
            this.txtContact = new MyControls.ListSelection();
            this.txtEmail = new MyControls.ListSelection();
            this.txtGender = new MyControls.ListSelection();
            this.txtCity = new MyControls.ListSelection();
            this.txtMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picContactUs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picContactUs
            // 
            this.picContactUs.Image = ((System.Drawing.Image)(resources.GetObject("picContactUs.Image")));
            this.picContactUs.Location = new System.Drawing.Point(162, 24);
            this.picContactUs.Name = "picContactUs";
            this.picContactUs.Size = new System.Drawing.Size(115, 40);
            this.picContactUs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picContactUs.TabIndex = 0;
            this.picContactUs.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :- ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contact :- ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email Id :- ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender :- ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "City :- ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Message :-";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Maroon;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(209, 357);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(106, 31);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 466);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 15);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(437, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 15);
            this.panel2.TabIndex = 51;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(149, 78);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(270, 29);
            this.txtName.TabIndex = 52;
            // 
            // txtContact
            // 
            this.txtContact.InputType = MyControls.ListSelection.TextInputType.Phone;
            this.txtContact.Location = new System.Drawing.Point(149, 113);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(270, 21);
            this.txtContact.TabIndex = 53;
            // 
            // txtEmail
            // 
            this.txtEmail.InputType = MyControls.ListSelection.TextInputType.Email;
            this.txtEmail.Location = new System.Drawing.Point(149, 146);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(270, 21);
            this.txtEmail.TabIndex = 54;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(149, 181);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(270, 21);
            this.txtGender.TabIndex = 55;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(149, 216);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(270, 21);
            this.txtCity.TabIndex = 56;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(149, 257);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(270, 94);
            this.txtMessage.TabIndex = 12;
            // 
            // ContactUsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(738, 481);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picContactUs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ContactUsForm";
            this.Text = "ContactUsForm";
            this.Load += new System.EventHandler(this.ContactUsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picContactUs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picContactUs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private MyControls.ListSelection txtName;
        private MyControls.ListSelection txtContact;
        private MyControls.ListSelection txtEmail;
        private MyControls.ListSelection txtGender;
        private MyControls.ListSelection txtCity;
        private System.Windows.Forms.TextBox txtMessage;
    }
}