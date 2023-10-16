namespace BankProject_3
{
    partial class frm_AccountTypes
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
            this.cmb_AccountType = new System.Windows.Forms.ComboBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.gb_AccountTypeList = new System.Windows.Forms.GroupBox();
            this.dgv_AccountTypeList = new System.Windows.Forms.DataGridView();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.gb_AccountTypeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AccountTypeList)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_AccountType
            // 
            this.cmb_AccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_AccountType.FormattingEnabled = true;
            this.cmb_AccountType.Items.AddRange(new object[] {
            "Saving",
            "Current",
            "Loan",
            "FD"});
            this.cmb_AccountType.Location = new System.Drawing.Point(363, 125);
            this.cmb_AccountType.Name = "cmb_AccountType";
            this.cmb_AccountType.Size = new System.Drawing.Size(208, 24);
            this.cmb_AccountType.TabIndex = 34;
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(322, 275);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(196, 28);
            this.txt_Search.TabIndex = 40;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(234, 275);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(65, 21);
            this.lblSearch.TabIndex = 41;
            this.lblSearch.Text = "Filter :";
            // 
            // gb_AccountTypeList
            // 
            this.gb_AccountTypeList.Controls.Add(this.dgv_AccountTypeList);
            this.gb_AccountTypeList.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_AccountTypeList.Location = new System.Drawing.Point(87, 329);
            this.gb_AccountTypeList.Name = "gb_AccountTypeList";
            this.gb_AccountTypeList.Size = new System.Drawing.Size(548, 259);
            this.gb_AccountTypeList.TabIndex = 39;
            this.gb_AccountTypeList.TabStop = false;
            this.gb_AccountTypeList.Text = "Account Type List";
            // 
            // dgv_AccountTypeList
            // 
            this.dgv_AccountTypeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AccountTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AccountTypeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_AccountTypeList.Location = new System.Drawing.Point(3, 24);
            this.dgv_AccountTypeList.Name = "dgv_AccountTypeList";
            this.dgv_AccountTypeList.RowTemplate.Height = 24;
            this.dgv_AccountTypeList.Size = new System.Drawing.Size(542, 232);
            this.dgv_AccountTypeList.TabIndex = 22;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(268, 204);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(142, 47);
            this.btn_Save.TabIndex = 38;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(375, 49);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(196, 30);
            this.txtID.TabIndex = 35;
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.Location = new System.Drawing.Point(196, 127);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(119, 22);
            this.lblAccountType.TabIndex = 37;
            this.lblAccountType.Text = "Account Type";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(196, 52);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(77, 22);
            this.lblId.TabIndex = 36;
            this.lblId.Text = "Enter ID";
            // 
            // frm_AccountTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 619);
            this.Controls.Add(this.cmb_AccountType);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.gb_AccountTypeList);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.lblId);
            this.Name = "frm_AccountTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AccountTypes";
            this.gb_AccountTypeList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AccountTypeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_AccountType;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox gb_AccountTypeList;
        private System.Windows.Forms.DataGridView dgv_AccountTypeList;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.Label lblId;
    }
}