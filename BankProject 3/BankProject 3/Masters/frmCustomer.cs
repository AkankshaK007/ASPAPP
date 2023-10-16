using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProject_3
{
    public partial class frmCustomer : Form
    {
        dbHelper db = new dbHelper();  //Create connection. // database connection zal  //jeva form open hoil teva connection hoil

        public frmCustomer()
        {
            InitializeComponent();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {

            try
            {
                

                txtName.BackColor = System.Drawing.Color.White;  
                 txtEmail.BackColor = System.Drawing.Color.White;
                 txtMobileNo.BackColor = System.Drawing.Color.White;

                 if (string.IsNullOrWhiteSpace(txtName.Text)) 
                 {
                     MessageBox.Show("Name is mandetory");
                     txtName.Focus();
                     txtName.BackColor = System.Drawing.Color.Red; 
                     return;
                 }

                 if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z]+$"))
                 {
                     MessageBox.Show(" Invalid Name");
                     txtName.Focus();
                     txtName.BackColor = System.Drawing.Color.Red;
                     return;
                 }

                 if (string.IsNullOrWhiteSpace(txtEmail.Text))
                 {
                     MessageBox.Show("Email is mandetory");
                     txtEmail.Focus();
                     txtEmail.BackColor = System.Drawing.Color.Red;
                     return;
                 }

                 if (Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$") == false) 
                 {
                     MessageBox.Show(" Invalid Email");
                     txtEmail.Focus();
                     txtEmail.BackColor = System.Drawing.Color.Red;
                     return;
                 }

                 if (string.IsNullOrWhiteSpace(txtMobileNo.Text))
                 {
                     MessageBox.Show("MobileNo is mandetory");
                     txtMobileNo.BackColor = System.Drawing.Color.Red;
                     txtMobileNo.Focus();
                     return;
                 }


                 if (!Regex.IsMatch(txtMobileNo.Text, @"\d{10}")) 
                 {
                     MessageBox.Show("Mobile No must Contains only 10 digit.");
                     txtMobileNo.Focus();
                     txtMobileNo.BackColor = System.Drawing.Color.Red;
                     return;
                 }

                 if (!chk_Cricket.Checked && !chk_Reading.Checked && !chk_Swimming.Checked && !chk_Voliball.Checked) 
                 {
                     MessageBox.Show("Atleast one hobbie should be selected.");
                     return;
                 }

                 if (cmb_Qualification.SelectedIndex == -1)
                 {
                     MessageBox.Show("Please select Qualification");
                     return;
                 }

                 if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z]+$"))
                 {
                     MessageBox.Show(" Invalid Name");
                     txtName.Focus();
                     txtName.BackColor = System.Drawing.Color.Red;
                     return;
                 }

                 if (!Regex.IsMatch(txtPanCard.Text, @"[A-Z]{5}\d{4}[A-Z]{1}"))
                 {
                     MessageBox.Show(" Invalid Pan Card");
                     txtPanCard.Focus();
                     txtPanCard.BackColor = System.Drawing.Color.Red;
                     return;
                 }

                string gender = "Male";
                if (rbFemale.Checked)
                {
                    gender = "Female";
                }

                bool active = false;
                if (rdo_Active.Checked)
                {
                    active = true;
                }

                List<string> hList = new List<string>();

                if (chk_Cricket.Checked)
                {
                    hList.Add("Cricket");
                }

                if (chk_Reading.Checked)
                {
                    hList.Add("Reading");
                }

                if (chk_Voliball.Checked)
                {
                    hList.Add("Voliball");

                }

                if (chk_Swimming.Checked)
                {
                    hList.Add("Swimming");
                }

                string Hobbies = string.Join(",", hList);

                dbHelper db = new dbHelper();

                string sql = "";

                if (SellId == 0)
                {
                     sql = string.Format("Insert into tblCustomer(Name,Email,MobileNo,Pancard,CreatedOn,BirthDate,Gender,Status,Hobbies,QualificationId)Values('{0}','{1}','{2}','{3}',GETDATE(),'{4}','{5}','{6}','{7}','{8}')",
                   txtName.Text, txtEmail.Text, txtMobileNo.Text, txtPanCard.Text, dtpDOB.Text, gender, active, Hobbies,cmb_Qualification.SelectedValue); //SelectedValue:select kelelya item chi int value bhetnar.//selectedText suddha use karu shakto string value sathi
                }
                else
                {
                     sql = string.Format("Update tblCustomer Set Name = '{0}',Email= '{1}',MobileNo= '{2}',Pancard= '{3}' ,BirthDate = '{4}',Gender= '{5}',Status = '{6}',Hobbies = '{7}',QualificationId = '{9}' where Id = '{8}'",
                   txtName.Text, txtEmail.Text, txtMobileNo.Text, txtPanCard.Text, dtpDOB.Text, gender, active, Hobbies,SellId,cmb_Qualification.SelectedValue);
                }

               
                db.DoUpdate(sql); //baherun query pathvnar

                db.CloseConnection(); //Close Connection

                MessageBox.Show("Saved");
                LoadData();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }




        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            //ya code madhe database madhil data ha cmb means dropdown la assign kela//jevdhe dropdown astil tevdya vela code repete hoil
            dbHelper db = new dbHelper();
            cmb_Qualification.DataSource = db.GetDataSet("Select Id,Name from tbl_Qualification").Tables[0];//tblQualification madhun Id and Name sagle column select kele
                                                                                                            //Cmb chya datasourcse la aapn datatable attach kel
            cmb_Qualification.DisplayMember = "Name"; //cmb madhe name column madhil value disnar //name column display hoil aani Id coloumn select hoil.

            cmb_Qualification.ValueMember = "Id";

            db.CloseConnection();
            LoadData();
        }

        private void LoadData()
        {
            dbHelper db = new dbHelper();
            
            dgv_CustomerList.DataSource = null;
            dgv_CustomerList.DataSource = db.GetDataSet("Select C.Id,C.Name,C.Email,C.MobileNo,C.Pancard,C.CreatedOn,C.BirthDate,C.Gender,C.Status,C.Hobbies,Q.Name as Qualification from tblCustomer as C,tbl_Qualification as Q where Q.Id = C.QualificationId").Tables[0]; //.Table chya agorvh sagl ds ch ahe //join use kel ->//ya query madhe Customer table madhle sagle coumn pahijet Qualification id Sodun aani qualification table madhil fakt Name colum pahije
            db.CloseConnection();
        }
        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            dbHelper db = new dbHelper();
            dgv_CustomerList.DataSource = null;
            dgv_CustomerList.DataSource = db.GetDataSet("Select C.Id,C.Name,C.Email,C.MobileNo,C.Pancard,C.CreatedOn,C.BirthDate,C.Gender,C.Status,C.Hobbies,Q.Name as Qualification from tblCustomer as C,tbl_Qualification as Q where Q.Id = C.QualificationId and C.Name Like '%" + txt_Search.Text + "%'").Tables[0];
            db.CloseConnection();
            
        }

        int SellId = 0;
        private void Dgv_CustomerList_CellContextMenuStripNeeded(object sender, DataGridViewCellContextMenuStripNeededEventArgs e)
        {
            try
            {
                SellId = Convert.ToInt32(dgv_CustomerList.Rows[e.RowIndex].Cells[0].Value);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);

            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (SellId > 0)
                {
                    dbHelper db = new dbHelper();
                    db.DoUpdate("Delete from tblCustomer where Id = " + SellId + "");

                    db.CloseConnection();

                    SellId = 0;
                    MessageBox.Show("Record Deleted");
                    LoadData();


                }
            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SellId > 0)
            {
                dbHelper db = new dbHelper();

                var dr = db.GetDataReader("Select Id,Name,Email,MobileNo,Pancard,CreatedOn, isNull(BirthDate,GetDate()) as BirthDate,isNull(Gender, 'Male') as Gender,isNull(Status,0)as Status,isNull(Hobbies,'') as Hobbies from tblCustomer where Id = " + SellId);

                if (dr.Read())
                {
                    txtID.Text = dr["Id"].ToString();
                    txtName.Text = dr["Name"].ToString();
                    txtMobileNo.Text = dr["MobileNo"].ToString();
                    txtEmail.Text = dr["Email"].ToString();
                    txtPanCard.Text = dr["Pancard"].ToString();
                    dtpDOB.Text = dr["BirthDate"].ToString();

                    if (dr["Gender"].ToString() == "Male")
                    {
                        rbMale.Checked = true;
                    }
                    else
                    {
                        rbFemale.Checked = true;
                    }

                    if (Convert.ToBoolean(dr["Status"]) == true)
                    {
                        rdo_Active.Checked = true;
                    }
                    else
                    {
                        rdo_Inactive.Checked = true;
                    }

                    var harray = dr["Hobbies"].ToString().Split(',');

                    chk_Cricket.Checked = false;
                    chk_Voliball.Checked = false;
                    chk_Reading.Checked = false;
                    chk_Swimming.Checked = false;

                    foreach (var item in harray)
                    {
                        if (item == "Cricket")
                            chk_Cricket.Checked = true;

                        if (item == "Voliball")
                            chk_Voliball.Checked = true;

                        if (item == "Reading")
                            chk_Reading.Checked = true;

                        if (item == "Swimming")
                            chk_Swimming.Checked = true;


                    }

                }
            }
        }

        private void Btn_OpenCustomer_Click(object sender, EventArgs e)
        {
            frm_Employee obj = new frm_Employee();
            //obj.Show(); //employee form show hoil
            obj.ShowDialog(); //employee form top la yenar mhnje to form sodun customer form vr click krta yenar nahi same as messagebox
        }
    }
}
