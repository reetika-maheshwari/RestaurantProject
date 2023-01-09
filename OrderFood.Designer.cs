
namespace RestaurantProject
{
    partial class OrderFood
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderFood));
            this.lblOrderYourFoodHere = new System.Windows.Forms.Label();
            this.grpMenuList = new System.Windows.Forms.GroupBox();
            this.gvMenu = new System.Windows.Forms.DataGridView();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Dish_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblName = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblPerson = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.lblPayment = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.cmbPerson = new System.Windows.Forms.ComboBox();
            this.cmbTable = new System.Windows.Forms.ComboBox();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.txtContactNo = new MyControls.ListSelection();
            this.txtName = new MyControls.ListSelection();
            this.grpMenuList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderYourFoodHere
            // 
            this.lblOrderYourFoodHere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOrderYourFoodHere.AutoSize = true;
            this.lblOrderYourFoodHere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOrderYourFoodHere.Font = new System.Drawing.Font("Edwardian Script ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderYourFoodHere.ForeColor = System.Drawing.Color.Maroon;
            this.lblOrderYourFoodHere.Location = new System.Drawing.Point(262, 18);
            this.lblOrderYourFoodHere.Name = "lblOrderYourFoodHere";
            this.lblOrderYourFoodHere.Size = new System.Drawing.Size(302, 38);
            this.lblOrderYourFoodHere.TabIndex = 0;
            this.lblOrderYourFoodHere.Text = "Order Your Food Here...";
            this.lblOrderYourFoodHere.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpMenuList
            // 
            this.grpMenuList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grpMenuList.Controls.Add(this.gvMenu);
            this.grpMenuList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMenuList.ForeColor = System.Drawing.Color.Maroon;
            this.grpMenuList.Location = new System.Drawing.Point(4, 58);
            this.grpMenuList.Name = "grpMenuList";
            this.grpMenuList.Size = new System.Drawing.Size(429, 623);
            this.grpMenuList.TabIndex = 80;
            this.grpMenuList.TabStop = false;
            this.grpMenuList.Text = "Menu List";
            // 
            // gvMenu
            // 
            this.gvMenu.AllowUserToAddRows = false;
            this.gvMenu.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gvMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvMenu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Image,
            this.Dish_Name,
            this.Rate,
            this.chk,
            this.Quantity,
            this.Id});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvMenu.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvMenu.Location = new System.Drawing.Point(3, 17);
            this.gvMenu.Name = "gvMenu";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvMenu.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvMenu.RowHeadersWidth = 100;
            this.gvMenu.RowTemplate.Height = 140;
            this.gvMenu.Size = new System.Drawing.Size(423, 603);
            this.gvMenu.TabIndex = 0;
            this.gvMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMenu_CellContentClick);
            this.gvMenu.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvMenu_CellEndEdit);
            // 
            // Image
            // 
            this.Image.HeaderText = "Image";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Image.Name = "Image";
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Image.Width = 200;
            // 
            // Dish_Name
            // 
            this.Dish_Name.HeaderText = "Dish_Name";
            this.Dish_Name.Name = "Dish_Name";
            this.Dish_Name.Width = 107;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.Width = 62;
            // 
            // chk
            // 
            this.chk.HeaderText = "Select";
            this.chk.Name = "chk";
            this.chk.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.chk.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.chk.Width = 72;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Qty";
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 52;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Maroon;
            this.lblName.Location = new System.Drawing.Point(478, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 16);
            this.lblName.TabIndex = 82;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblContact
            // 
            this.lblContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.ForeColor = System.Drawing.Color.Maroon;
            this.lblContact.Location = new System.Drawing.Point(478, 80);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(74, 16);
            this.lblContact.TabIndex = 83;
            this.lblContact.Text = "Contact No";
            this.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTable
            // 
            this.lblTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTable.AutoSize = true;
            this.lblTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTable.ForeColor = System.Drawing.Color.Maroon;
            this.lblTable.Location = new System.Drawing.Point(478, 102);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(65, 16);
            this.lblTable.TabIndex = 84;
            this.lblTable.Text = "Table No";
            this.lblTable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPerson
            // 
            this.lblPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPerson.AutoSize = true;
            this.lblPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerson.ForeColor = System.Drawing.Color.Maroon;
            this.lblPerson.Location = new System.Drawing.Point(478, 125);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(91, 16);
            this.lblPerson.TabIndex = 88;
            this.lblPerson.Text = "No. Of Person";
            this.lblPerson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Maroon;
            this.lblDate.Location = new System.Drawing.Point(478, 148);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 16);
            this.lblDate.TabIndex = 90;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtDate
            // 
            this.dtDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDate.CustomFormat = "yyyy-MM-dd";
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDate.Location = new System.Drawing.Point(577, 148);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(180, 20);
            this.dtDate.TabIndex = 91;
            // 
            // lblPayment
            // 
            this.lblPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.ForeColor = System.Drawing.Color.Maroon;
            this.lblPayment.Location = new System.Drawing.Point(478, 170);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(61, 16);
            this.lblPayment.TabIndex = 92;
            this.lblPayment.Text = "Payment";
            this.lblPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(478, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 99;
            this.label1.Text = "Total Payable Amount";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnReceipt
            // 
            this.btnReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReceipt.BackColor = System.Drawing.Color.Maroon;
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReceipt.ForeColor = System.Drawing.Color.White;
            this.btnReceipt.Image = ((System.Drawing.Image)(resources.GetObject("btnReceipt.Image")));
            this.btnReceipt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReceipt.Location = new System.Drawing.Point(556, 661);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(74, 23);
            this.btnReceipt.TabIndex = 101;
            this.btnReceipt.Text = "Receipt";
            this.btnReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReceipt.UseVisualStyleBackColor = false;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click_1);
            // 
            // cmbPerson
            // 
            this.cmbPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerson.FormattingEnabled = true;
            this.cmbPerson.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbPerson.Location = new System.Drawing.Point(577, 125);
            this.cmbPerson.Name = "cmbPerson";
            this.cmbPerson.Size = new System.Drawing.Size(180, 21);
            this.cmbPerson.TabIndex = 89;
            // 
            // cmbTable
            // 
            this.cmbTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTable.FormattingEnabled = true;
            this.cmbTable.Location = new System.Drawing.Point(577, 102);
            this.cmbTable.Name = "cmbTable";
            this.cmbTable.Size = new System.Drawing.Size(180, 21);
            this.cmbTable.TabIndex = 87;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(439, 219);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(326, 436);
            this.txtResult.TabIndex = 105;
            this.txtResult.Text = "";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.Maroon;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(633, 661);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(67, 23);
            this.btnReset.TabIndex = 106;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.Maroon;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.Location = new System.Drawing.Point(703, 661);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(69, 23);
            this.btnPrint.TabIndex = 107;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cmbPayment
            // 
            this.cmbPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Location = new System.Drawing.Point(577, 170);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(180, 21);
            this.cmbPayment.TabIndex = 108;
            // 
            // txttotal
            // 
            this.txttotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txttotal.Location = new System.Drawing.Point(625, 193);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(132, 20);
            this.txttotal.TabIndex = 109;
            this.txttotal.Text = "0";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContactNo.InputType = MyControls.ListSelection.TextInputType.Phone;
            this.txtContactNo.Location = new System.Drawing.Point(577, 80);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(180, 21);
            this.txtContactNo.TabIndex = 103;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(577, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 21);
            this.txtName.TabIndex = 102;
            // 
            // OrderFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(777, 730);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.cmbPayment);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbPerson);
            this.Controls.Add(this.lblPerson);
            this.Controls.Add(this.lblOrderYourFoodHere);
            this.Controls.Add(this.cmbTable);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.grpMenuList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderFood";
            this.Text = "OrderFood";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderFood_Load);
            this.Controls.SetChildIndex(this.grpMenuList, 0);
            this.Controls.SetChildIndex(this.lblName, 0);
            this.Controls.SetChildIndex(this.lblContact, 0);
            this.Controls.SetChildIndex(this.lblTable, 0);
            this.Controls.SetChildIndex(this.cmbTable, 0);
            this.Controls.SetChildIndex(this.lblOrderYourFoodHere, 0);
            this.Controls.SetChildIndex(this.lblPerson, 0);
            this.Controls.SetChildIndex(this.cmbPerson, 0);
            this.Controls.SetChildIndex(this.lblDate, 0);
            this.Controls.SetChildIndex(this.dtDate, 0);
            this.Controls.SetChildIndex(this.lblPayment, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnReceipt, 0);
            this.Controls.SetChildIndex(this.txtName, 0);
            this.Controls.SetChildIndex(this.txtContactNo, 0);
            this.Controls.SetChildIndex(this.txtResult, 0);
            this.Controls.SetChildIndex(this.btnReset, 0);
            this.Controls.SetChildIndex(this.btnPrint, 0);
            this.Controls.SetChildIndex(this.cmbPayment, 0);
            this.Controls.SetChildIndex(this.txttotal, 0);
            this.grpMenuList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblOrderYourFoodHere;
        private System.Windows.Forms.GroupBox grpMenuList;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblPerson;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnReceipt;
        private MyControls.ListSelection txtName;
        private MyControls.ListSelection txtContactNo;
        private System.Windows.Forms.ComboBox cmbPerson;
        private System.Windows.Forms.ComboBox cmbTable;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView gvMenu;
        private System.Windows.Forms.ComboBox cmbPayment;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dish_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}