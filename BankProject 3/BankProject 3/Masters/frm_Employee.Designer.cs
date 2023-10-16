namespace BankProject_3
{
    partial class frm_Employee
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
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.gb_EmployeeList = new System.Windows.Forms.GroupBox();
            this.dgv_EmployeeList = new System.Windows.Forms.DataGridView();
            this.gb_EmpDetails = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdo_Inactive = new System.Windows.Forms.RadioButton();
            this.rdo_Active = new System.Windows.Forms.RadioButton();
            this.btn_Save = new System.Windows.Forms.Button();
            this.dtpSalaryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lbl_SalaryDate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMobNo = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.gb_EmployeeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EmployeeList)).BeginInit();
            this.gb_EmpDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(822, 108);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(196, 28);
            this.txt_Search.TabIndex = 30;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(734, 108);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(65, 21);
            this.lblSearch.TabIndex = 31;
            this.lblSearch.Text = "Filter :";
            // 
            // gb_EmployeeList
            // 
            this.gb_EmployeeList.Controls.Add(this.dgv_EmployeeList);
            this.gb_EmployeeList.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_EmployeeList.Location = new System.Drawing.Point(526, 164);
            this.gb_EmployeeList.Name = "gb_EmployeeList";
            this.gb_EmployeeList.Size = new System.Drawing.Size(902, 521);
            this.gb_EmployeeList.TabIndex = 29;
            this.gb_EmployeeList.TabStop = false;
            this.gb_EmployeeList.Text = "Employee List";
            // 
            // dgv_EmployeeList
            // 
            this.dgv_EmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_EmployeeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_EmployeeList.Location = new System.Drawing.Point(3, 24);
            this.dgv_EmployeeList.Name = "dgv_EmployeeList";
            this.dgv_EmployeeList.RowTemplate.Height = 24;
            this.dgv_EmployeeList.Size = new System.Drawing.Size(896, 494);
            this.dgv_EmployeeList.TabIndex = 22;
            // 
            // gb_EmpDetails
            // 
            this.gb_EmpDetails.BackColor = System.Drawing.Color.AntiqueWhite;
            this.gb_EmpDetails.Controls.Add(this.groupBox1);
            this.gb_EmpDetails.Controls.Add(this.groupBox2);
            this.gb_EmpDetails.Controls.Add(this.btn_Save);
            this.gb_EmpDetails.Controls.Add(this.dtpSalaryDate);
            this.gb_EmpDetails.Controls.Add(this.dtpDOB);
            this.gb_EmpDetails.Controls.Add(this.txtAmount);
            this.gb_EmpDetails.Controls.Add(this.txtEmail);
            this.gb_EmpDetails.Controls.Add(this.txtMobileNo);
            this.gb_EmpDetails.Controls.Add(this.txtName);
            this.gb_EmpDetails.Controls.Add(this.txtID);
            this.gb_EmpDetails.Controls.Add(this.lblAmount);
            this.gb_EmpDetails.Controls.Add(this.lblStatus);
            this.gb_EmpDetails.Controls.Add(this.lbl_SalaryDate);
            this.gb_EmpDetails.Controls.Add(this.lblGender);
            this.gb_EmpDetails.Controls.Add(this.lblEmail);
            this.gb_EmpDetails.Controls.Add(this.lblMobNo);
            this.gb_EmpDetails.Controls.Add(this.lblDOB);
            this.gb_EmpDetails.Controls.Add(this.lblName);
            this.gb_EmpDetails.Controls.Add(this.lblId);
            this.gb_EmpDetails.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_EmpDetails.Location = new System.Drawing.Point(39, 59);
            this.gb_EmpDetails.Name = "gb_EmpDetails";
            this.gb_EmpDetails.Size = new System.Drawing.Size(443, 626);
            this.gb_EmpDetails.TabIndex = 28;
            this.gb_EmpDetails.TabStop = false;
            this.gb_EmpDetails.Text = "Employee Details";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFemale);
            this.groupBox1.Controls.Add(this.rbMale);
            this.groupBox1.Location = new System.Drawing.Point(212, 366);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 49);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(111, 13);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(80, 23);
            this.rbFemale.TabIndex = 10;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(6, 13);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(65, 23);
            this.rbMale.TabIndex = 9;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_Inactive);
            this.groupBox2.Controls.Add(this.rdo_Active);
            this.groupBox2.Location = new System.Drawing.Point(195, 493);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 51);
            this.groupBox2.TabIndex = 34;
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
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(89, 559);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(142, 47);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // dtpSalaryDate
            // 
            this.dtpSalaryDate.Location = new System.Drawing.Point(212, 313);
            this.dtpSalaryDate.Name = "dtpSalaryDate";
            this.dtpSalaryDate.Size = new System.Drawing.Size(200, 27);
            this.dtpSalaryDate.TabIndex = 6;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(212, 150);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 27);
            this.dtpDOB.TabIndex = 3;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(212, 438);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(196, 27);
            this.txtAmount.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(212, 263);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 27);
            this.txtEmail.TabIndex = 5;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(212, 207);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(196, 27);
            this.txtMobileNo.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(212, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(196, 27);
            this.txtName.TabIndex = 2;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(212, 46);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(196, 27);
            this.txtID.TabIndex = 11111;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(37, 441);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(63, 19);
            this.lblAmount.TabIndex = 29;
            this.lblAmount.Text = "Amount";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(37, 506);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 19);
            this.lblStatus.TabIndex = 28;
            this.lblStatus.Text = "Status";
            // 
            // lbl_SalaryDate
            // 
            this.lbl_SalaryDate.AutoSize = true;
            this.lbl_SalaryDate.Location = new System.Drawing.Point(36, 313);
            this.lbl_SalaryDate.Name = "lbl_SalaryDate";
            this.lbl_SalaryDate.Size = new System.Drawing.Size(87, 19);
            this.lbl_SalaryDate.TabIndex = 27;
            this.lbl_SalaryDate.Text = "Salary Date";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(33, 379);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(59, 19);
            this.lblGender.TabIndex = 26;
            this.lblGender.Text = "Gender";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(33, 263);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(90, 19);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "Enter Email";
            // 
            // lblMobNo
            // 
            this.lblMobNo.AutoSize = true;
            this.lblMobNo.Location = new System.Drawing.Point(33, 210);
            this.lblMobNo.Name = "lblMobNo";
            this.lblMobNo.Size = new System.Drawing.Size(125, 19);
            this.lblMobNo.TabIndex = 23;
            this.lblMobNo.Text = "Enter Mobile No";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(33, 150);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(85, 19);
            this.lblDOB.TabIndex = 22;
            this.lblDOB.Text = "Enter DOB";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(90, 19);
            this.lblName.TabIndex = 21;
            this.lblName.Text = "Enter Name";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(33, 49);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(67, 19);
            this.lblId.TabIndex = 20;
            this.lblId.Text = "Enter ID";
            // 
            // frm_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 745);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.gb_EmployeeList);
            this.Controls.Add(this.gb_EmpDetails);
            this.Name = "frm_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Employee";
            this.gb_EmployeeList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_EmployeeList)).EndInit();
            this.gb_EmpDetails.ResumeLayout(false);
            this.gb_EmpDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox gb_EmployeeList;
        private System.Windows.Forms.DataGridView dgv_EmployeeList;
        private System.Windows.Forms.GroupBox gb_EmpDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdo_Inactive;
        private System.Windows.Forms.RadioButton rdo_Active;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DateTimePicker dtpSalaryDate;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lbl_SalaryDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMobNo;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblId;
    }
}