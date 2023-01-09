
using System;

namespace RestaurantProject
{
    partial class StaffForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panalStaff = new System.Windows.Forms.Panel();
            this.txtAddress = new MyControls.ListSelection();
            this.txtSalary = new MyControls.ListSelection();
            this.txtMName = new MyControls.ListSelection();
            this.txtFName = new MyControls.ListSelection();
            this.txtEmpName = new MyControls.ListSelection();
            this.txtContact = new MyControls.ListSelection();
            this.dtDOJ = new System.Windows.Forms.DateTimePicker();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panalStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panalStaff
            // 
            this.panalStaff.Controls.Add(this.txtAddress);
            this.panalStaff.Controls.Add(this.txtSalary);
            this.panalStaff.Controls.Add(this.txtMName);
            this.panalStaff.Controls.Add(this.txtFName);
            this.panalStaff.Controls.Add(this.txtEmpName);
            this.panalStaff.Controls.Add(this.txtContact);
            this.panalStaff.Controls.Add(this.dtDOJ);
            this.panalStaff.Controls.Add(this.dtDOB);
            this.panalStaff.Controls.Add(this.cmbDesignation);
            this.panalStaff.Controls.Add(this.cmbGender);
            this.panalStaff.Controls.Add(this.label13);
            this.panalStaff.Controls.Add(this.label10);
            this.panalStaff.Controls.Add(this.label11);
            this.panalStaff.Controls.Add(this.label8);
            this.panalStaff.Controls.Add(this.label9);
            this.panalStaff.Controls.Add(this.label6);
            this.panalStaff.Controls.Add(this.label7);
            this.panalStaff.Controls.Add(this.label4);
            this.panalStaff.Controls.Add(this.label5);
            this.panalStaff.Controls.Add(this.label2);
            this.panalStaff.Controls.Add(this.pictureBox1);
            this.panalStaff.Controls.Add(this.label1);
            this.panalStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panalStaff.Location = new System.Drawing.Point(0, 15);
            this.panalStaff.Name = "panalStaff";
            this.panalStaff.Size = new System.Drawing.Size(748, 455);
            this.panalStaff.TabIndex = 4;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(126, 282);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(0);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(606, 21);
            this.txtAddress.TabIndex = 29;
            // 
            // txtSalary
            // 
            this.txtSalary.InputType = MyControls.ListSelection.TextInputType.Numeric;
            this.txtSalary.Location = new System.Drawing.Point(494, 209);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(238, 21);
            this.txtSalary.TabIndex = 28;
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(494, 135);
            this.txtMName.Name = "txtMName";
            this.txtMName.Size = new System.Drawing.Size(238, 21);
            this.txtMName.TabIndex = 27;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(126, 137);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(238, 21);
            this.txtFName.TabIndex = 26;
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(126, 99);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(606, 21);
            this.txtEmpName.TabIndex = 25;
            // 
            // txtContact
            // 
            this.txtContact.InputType = MyControls.ListSelection.TextInputType.Phone;
            this.txtContact.Location = new System.Drawing.Point(126, 210);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(238, 21);
            this.txtContact.TabIndex = 6;
            // 
            // dtDOJ
            // 
            this.dtDOJ.CustomFormat = "yyyy-MM-dd";
            this.dtDOJ.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDOJ.Location = new System.Drawing.Point(494, 173);
            this.dtDOJ.Name = "dtDOJ";
            this.dtDOJ.Size = new System.Drawing.Size(238, 20);
            this.dtDOJ.TabIndex = 5;
            // 
            // dtDOB
            // 
            this.dtDOB.CustomFormat = "yyyy-MM-dd";
            this.dtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDOB.Location = new System.Drawing.Point(126, 173);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(238, 20);
            this.dtDOB.TabIndex = 4;
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.BackColor = System.Drawing.SystemColors.Info;
            this.cmbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Location = new System.Drawing.Point(494, 244);
            this.cmbDesignation.MaxDropDownItems = 10;
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(238, 21);
            this.cmbDesignation.TabIndex = 9;
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.White;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGender.ForeColor = System.Drawing.Color.Black;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(126, 246);
            this.cmbGender.MaxDropDownItems = 5;
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(238, 21);
            this.cmbGender.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 282);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 15);
            this.label13.TabIndex = 24;
            this.label13.Text = "Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(412, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Designation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(22, 248);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 20;
            this.label11.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(412, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Salary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(22, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "Contact No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(412, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "DOJ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "M_Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "F_Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Emp_Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(256, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(312, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Staff Enrollment System";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(748, 510);
            this.Controls.Add(this.panalStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StaffForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.Controls.SetChildIndex(this.panalStaff, 0);
            this.panalStaff.ResumeLayout(false);
            this.panalStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panalStaff;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtDOJ;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label label13;
        private MyControls.ListSelection txtContact;
        private MyControls.ListSelection txtEmpName;
        private MyControls.ListSelection txtAddress;
        private MyControls.ListSelection txtSalary;
        private MyControls.ListSelection txtMName;
        private MyControls.ListSelection txtFName;
    }
}



