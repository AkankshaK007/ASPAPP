namespace BankProject_3
{
    partial class frmCustomer
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
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.gb_CustomerList = new System.Windows.Forms.GroupBox();
            this.dgv_CustomerList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_CustomerDetails = new System.Windows.Forms.GroupBox();
            this.cmb_Qualification = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_Swimming = new System.Windows.Forms.CheckBox();
            this.chk_Voliball = new System.Windows.Forms.CheckBox();
            this.chk_Reading = new System.Windows.Forms.CheckBox();
            this.chk_Cricket = new System.Windows.Forms.CheckBox();
            this.lbl_Hobbies = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdo_Inactive = new System.Windows.Forms.RadioButton();
            this.rdo_Active = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.dtpCteatedOn = new System.Windows.Forms.DateTimePicker();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtPanCard = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblPanCard = new System.Windows.Forms.Label();
            this.lbl_CreatedOn = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMobNo = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btn_OpenCustomer = new System.Windows.Forms.Button();
            this.gb_CustomerList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gb_CustomerDetails.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(795, 75);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(196, 28);
            this.txt_Search.TabIndex = 28;
            this.txt_Search.TextChanged += new System.EventHandler(this.Txt_Search_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(707, 75);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(65, 21);
            this.lblSearch.TabIndex = 29;
            this.lblSearch.Text = "Filter :";
            // 
            // gb_CustomerList
            // 
            this.gb_CustomerList.Controls.Add(this.dgv_CustomerList);
            this.gb_CustomerList.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_CustomerList.Location = new System.Drawing.Point(520, 137);
            this.gb_CustomerList.Name = "gb_CustomerList";
            this.gb_CustomerList.Size = new System.Drawing.Size(902, 515);
            this.gb_CustomerList.TabIndex = 27;
            this.gb_CustomerList.TabStop = false;
            this.gb_CustomerList.Text = "Customer List";
            // 
            // dgv_CustomerList
            // 
            this.dgv_CustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CustomerList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_CustomerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CustomerList.Location = new System.Drawing.Point(3, 24);
            this.dgv_CustomerList.Name = "dgv_CustomerList";
            this.dgv_CustomerList.RowTemplate.Height = 24;
            this.dgv_CustomerList.Size = new System.Drawing.Size(896, 488);
            this.dgv_CustomerList.TabIndex = 22;
            this.dgv_CustomerList.CellContextMenuStripNeeded += new System.Windows.Forms.DataGridViewCellContextMenuStripNeededEventHandler(this.Dgv_CustomerList_CellContextMenuStripNeeded);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 52);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // gb_CustomerDetails
            // 
            this.gb_CustomerDetails.BackColor = System.Drawing.Color.AntiqueWhite;
            this.gb_CustomerDetails.Controls.Add(this.cmb_Qualification);
            this.gb_CustomerDetails.Controls.Add(this.label1);
            this.gb_CustomerDetails.Controls.Add(this.chk_Swimming);
            this.gb_CustomerDetails.Controls.Add(this.chk_Voliball);
            this.gb_CustomerDetails.Controls.Add(this.chk_Reading);
            this.gb_CustomerDetails.Controls.Add(this.chk_Cricket);
            this.gb_CustomerDetails.Controls.Add(this.lbl_Hobbies);
            this.gb_CustomerDetails.Controls.Add(this.groupBox2);
            this.gb_CustomerDetails.Controls.Add(this.groupBox1);
            this.gb_CustomerDetails.Controls.Add(this.lblStatus);
            this.gb_CustomerDetails.Controls.Add(this.btn_Save);
            this.gb_CustomerDetails.Controls.Add(this.dtpCteatedOn);
            this.gb_CustomerDetails.Controls.Add(this.dtpDOB);
            this.gb_CustomerDetails.Controls.Add(this.txtPanCard);
            this.gb_CustomerDetails.Controls.Add(this.txtEmail);
            this.gb_CustomerDetails.Controls.Add(this.txtMobileNo);
            this.gb_CustomerDetails.Controls.Add(this.txtName);
            this.gb_CustomerDetails.Controls.Add(this.txtID);
            this.gb_CustomerDetails.Controls.Add(this.lblPanCard);
            this.gb_CustomerDetails.Controls.Add(this.lbl_CreatedOn);
            this.gb_CustomerDetails.Controls.Add(this.lblGender);
            this.gb_CustomerDetails.Controls.Add(this.lblEmail);
            this.gb_CustomerDetails.Controls.Add(this.lblMobNo);
            this.gb_CustomerDetails.Controls.Add(this.lblDOB);
            this.gb_CustomerDetails.Controls.Add(this.lblName);
            this.gb_CustomerDetails.Controls.Add(this.lblId);
            this.gb_CustomerDetails.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_CustomerDetails.Location = new System.Drawing.Point(10, 30);
            this.gb_CustomerDetails.Name = "gb_CustomerDetails";
            this.gb_CustomerDetails.Size = new System.Drawing.Size(489, 726);
            this.gb_CustomerDetails.TabIndex = 26;
            this.gb_CustomerDetails.TabStop = false;
            this.gb_CustomerDetails.Text = "Customer Details";
            // 
            // cmb_Qualification
            // 
            this.cmb_Qualification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Qualification.FormattingEnabled = true;
            this.cmb_Qualification.Items.AddRange(new object[] {
            "Saving",
            "Current",
            "Loan",
            "FD"});
            this.cmb_Qualification.Location = new System.Drawing.Point(178, 617);
            this.cmb_Qualification.Name = "cmb_Qualification";
            this.cmb_Qualification.Size = new System.Drawing.Size(208, 27);
            this.cmb_Qualification.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 625);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "Qualification";
            // 
            // chk_Swimming
            // 
            this.chk_Swimming.AutoSize = true;
            this.chk_Swimming.Location = new System.Drawing.Point(292, 567);
            this.chk_Swimming.Name = "chk_Swimming";
            this.chk_Swimming.Size = new System.Drawing.Size(103, 23);
            this.chk_Swimming.TabIndex = 38;
            this.chk_Swimming.Text = "Swimming";
            this.chk_Swimming.UseVisualStyleBackColor = true;
            // 
            // chk_Voliball
            // 
            this.chk_Voliball.AutoSize = true;
            this.chk_Voliball.Location = new System.Drawing.Point(292, 538);
            this.chk_Voliball.Name = "chk_Voliball";
            this.chk_Voliball.Size = new System.Drawing.Size(84, 23);
            this.chk_Voliball.TabIndex = 37;
            this.chk_Voliball.Text = "Voliball";
            this.chk_Voliball.UseVisualStyleBackColor = true;
            // 
            // chk_Reading
            // 
            this.chk_Reading.AutoSize = true;
            this.chk_Reading.Location = new System.Drawing.Point(178, 567);
            this.chk_Reading.Name = "chk_Reading";
            this.chk_Reading.Size = new System.Drawing.Size(86, 23);
            this.chk_Reading.TabIndex = 36;
            this.chk_Reading.Text = "Reading";
            this.chk_Reading.UseVisualStyleBackColor = true;
            // 
            // chk_Cricket
            // 
            this.chk_Cricket.AutoSize = true;
            this.chk_Cricket.Location = new System.Drawing.Point(178, 538);
            this.chk_Cricket.Name = "chk_Cricket";
            this.chk_Cricket.Size = new System.Drawing.Size(82, 23);
            this.chk_Cricket.TabIndex = 35;
            this.chk_Cricket.Text = "Cricket";
            this.chk_Cricket.UseVisualStyleBackColor = true;
            // 
            // lbl_Hobbies
            // 
            this.lbl_Hobbies.AutoSize = true;
            this.lbl_Hobbies.Location = new System.Drawing.Point(29, 554);
            this.lbl_Hobbies.Name = "lbl_Hobbies";
            this.lbl_Hobbies.Size = new System.Drawing.Size(66, 19);
            this.lbl_Hobbies.TabIndex = 34;
            this.lbl_Hobbies.Text = "Hobbies";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_Inactive);
            this.groupBox2.Controls.Add(this.rdo_Active);
            this.groupBox2.Location = new System.Drawing.Point(178, 467);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 51);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // rdo_Inactive
            // 
            this.rdo_Inactive.AutoSize = true;
            this.rdo_Inactive.Checked = true;
            this.rdo_Inactive.Location = new System.Drawing.Point(114, 14);
            this.rdo_Inactive.Name = "rdo_Inactive";
            this.rdo_Inactive.Size = new System.Drawing.Size(93, 23);
            this.rdo_Inactive.TabIndex = 10;
            this.rdo_Inactive.TabStop = true;
            this.rdo_Inactive.Text = "In-Active";
            this.rdo_Inactive.UseVisualStyleBackColor = true;
            // 
            // rdo_Active
            // 
            this.rdo_Active.AutoSize = true;
            this.rdo_Active.Location = new System.Drawing.Point(22, 14);
            this.rdo_Active.Name = "rdo_Active";
            this.rdo_Active.Size = new System.Drawing.Size(74, 23);
            this.rdo_Active.TabIndex = 9;
            this.rdo_Active.Text = "Active";
            this.rdo_Active.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Location = new System.Drawing.Point(190, 361);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 51);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(114, 14);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(80, 23);
            this.rbFemale.TabIndex = 10;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(22, 14);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(65, 23);
            this.rbMale.TabIndex = 9;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(29, 485);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 19);
            this.lblStatus.TabIndex = 29;
            this.lblStatus.Text = "Status";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(135, 662);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(142, 47);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // dtpCteatedOn
            // 
            this.dtpCteatedOn.Location = new System.Drawing.Point(195, 317);
            this.dtpCteatedOn.Name = "dtpCteatedOn";
            this.dtpCteatedOn.Size = new System.Drawing.Size(200, 27);
            this.dtpCteatedOn.TabIndex = 6;
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "DD-MMM-YYYY";
            this.dtpDOB.Location = new System.Drawing.Point(195, 145);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 27);
            this.dtpDOB.TabIndex = 3;
            // 
            // txtPanCard
            // 
            this.txtPanCard.Location = new System.Drawing.Point(190, 431);
            this.txtPanCard.Name = "txtPanCard";
            this.txtPanCard.Size = new System.Drawing.Size(196, 27);
            this.txtPanCard.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(195, 260);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 27);
            this.txtEmail.TabIndex = 5;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(195, 204);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(196, 27);
            this.txtMobileNo.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(195, 95);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 27);
            this.txtName.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(195, 39);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(196, 27);
            this.txtID.TabIndex = 1111;
            // 
            // lblPanCard
            // 
            this.lblPanCard.AutoSize = true;
            this.lblPanCard.Location = new System.Drawing.Point(20, 434);
            this.lblPanCard.Name = "lblPanCard";
            this.lblPanCard.Size = new System.Drawing.Size(66, 19);
            this.lblPanCard.TabIndex = 28;
            this.lblPanCard.Text = "PanCard";
            // 
            // lbl_CreatedOn
            // 
            this.lbl_CreatedOn.AutoSize = true;
            this.lbl_CreatedOn.Location = new System.Drawing.Point(20, 317);
            this.lbl_CreatedOn.Name = "lbl_CreatedOn";
            this.lbl_CreatedOn.Size = new System.Drawing.Size(86, 19);
            this.lbl_CreatedOn.TabIndex = 27;
            this.lbl_CreatedOn.Text = "Created On";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(20, 378);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(59, 19);
            this.lblGender.TabIndex = 26;
            this.lblGender.Text = "Gender";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(16, 260);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(90, 19);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Enter Email";
            // 
            // lblMobNo
            // 
            this.lblMobNo.AutoSize = true;
            this.lblMobNo.Location = new System.Drawing.Point(16, 207);
            this.lblMobNo.Name = "lblMobNo";
            this.lblMobNo.Size = new System.Drawing.Size(125, 19);
            this.lblMobNo.TabIndex = 23;
            this.lblMobNo.Text = "Enter Mobile No";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(16, 151);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(85, 19);
            this.lblDOB.TabIndex = 22;
            this.lblDOB.Text = "Enter DOB";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 19);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Enter Name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(16, 42);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(67, 19);
            this.lblId.TabIndex = 20;
            this.lblId.Text = "Enter ID";
            // 
            // btn_OpenCustomer
            // 
            this.btn_OpenCustomer.Location = new System.Drawing.Point(1213, 30);
            this.btn_OpenCustomer.Name = "btn_OpenCustomer";
            this.btn_OpenCustomer.Size = new System.Drawing.Size(144, 41);
            this.btn_OpenCustomer.TabIndex = 30;
            this.btn_OpenCustomer.Text = "Open Customer";
            this.btn_OpenCustomer.UseVisualStyleBackColor = true;
            this.btn_OpenCustomer.Click += new System.EventHandler(this.Btn_OpenCustomer_Click);
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 786);
            this.Controls.Add(this.btn_OpenCustomer);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.gb_CustomerList);
            this.Controls.Add(this.gb_CustomerDetails);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            this.gb_CustomerList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CustomerList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gb_CustomerDetails.ResumeLayout(false);
            this.gb_CustomerDetails.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox gb_CustomerList;
        private System.Windows.Forms.DataGridView dgv_CustomerList;
        private System.Windows.Forms.GroupBox gb_CustomerDetails;
        private System.Windows.Forms.ComboBox cmb_Qualification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_Swimming;
        private System.Windows.Forms.CheckBox chk_Voliball;
        private System.Windows.Forms.CheckBox chk_Reading;
        private System.Windows.Forms.CheckBox chk_Cricket;
        private System.Windows.Forms.Label lbl_Hobbies;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdo_Inactive;
        private System.Windows.Forms.RadioButton rdo_Active;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DateTimePicker dtpCteatedOn;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtPanCard;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblPanCard;
        private System.Windows.Forms.Label lbl_CreatedOn;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMobNo;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button btn_OpenCustomer;
    }
}

