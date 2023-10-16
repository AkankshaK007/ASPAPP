namespace BankProject_3
{
    partial class frmModes
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
            this.cmb_Modes = new System.Windows.Forms.ComboBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.gb_ModeList = new System.Windows.Forms.GroupBox();
            this.dgv_ModeList = new System.Windows.Forms.DataGridView();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblPaymentMode = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.gb_ModeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ModeList)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_Modes
            // 
            this.cmb_Modes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Modes.FormattingEnabled = true;
            this.cmb_Modes.Items.AddRange(new object[] {
            "UPI",
            "Cash",
            "Credit Card",
            "debit Card"});
            this.cmb_Modes.Location = new System.Drawing.Point(404, 110);
            this.cmb_Modes.Name = "cmb_Modes";
            this.cmb_Modes.Size = new System.Drawing.Size(196, 24);
            this.cmb_Modes.TabIndex = 30;
            // 
            // txt_Search
            // 
            this.txt_Search.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Search.Location = new System.Drawing.Point(318, 293);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(196, 28);
            this.txt_Search.TabIndex = 36;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(230, 293);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(65, 21);
            this.lblSearch.TabIndex = 37;
            this.lblSearch.Text = "Filter :";
            // 
            // gb_ModeList
            // 
            this.gb_ModeList.Controls.Add(this.dgv_ModeList);
            this.gb_ModeList.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_ModeList.Location = new System.Drawing.Point(83, 347);
            this.gb_ModeList.Name = "gb_ModeList";
            this.gb_ModeList.Size = new System.Drawing.Size(548, 259);
            this.gb_ModeList.TabIndex = 35;
            this.gb_ModeList.TabStop = false;
            this.gb_ModeList.Text = "Mode List";
            // 
            // dgv_ModeList
            // 
            this.dgv_ModeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ModeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ModeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ModeList.Location = new System.Drawing.Point(3, 24);
            this.dgv_ModeList.Name = "dgv_ModeList";
            this.dgv_ModeList.RowTemplate.Height = 24;
            this.dgv_ModeList.Size = new System.Drawing.Size(542, 232);
            this.dgv_ModeList.TabIndex = 22;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(281, 192);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(142, 47);
            this.btn_Save.TabIndex = 34;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(404, 34);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(196, 30);
            this.txtID.TabIndex = 31;
            // 
            // lblPaymentMode
            // 
            this.lblPaymentMode.AutoSize = true;
            this.lblPaymentMode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMode.Location = new System.Drawing.Point(189, 112);
            this.lblPaymentMode.Name = "lblPaymentMode";
            this.lblPaymentMode.Size = new System.Drawing.Size(174, 22);
            this.lblPaymentMode.TabIndex = 33;
            this.lblPaymentMode.Text = "Enter Payment Mode";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(189, 37);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(77, 22);
            this.lblId.TabIndex = 32;
            this.lblId.Text = "Enter ID";
            // 
            // frmModes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 637);
            this.Controls.Add(this.cmb_Modes);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.gb_ModeList);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblPaymentMode);
            this.Controls.Add(this.lblId);
            this.Name = "frmModes";
            this.Text = "frmModes";
            this.gb_ModeList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ModeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Modes;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.GroupBox gb_ModeList;
        private System.Windows.Forms.DataGridView dgv_ModeList;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblPaymentMode;
        private System.Windows.Forms.Label lblId;
    }
}