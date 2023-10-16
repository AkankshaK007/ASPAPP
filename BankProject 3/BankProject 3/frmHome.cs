using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankProject_3
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer obj = new frmCustomer();
            obj.MdiParent = this;//this means current object //mhnje frmCustomer la frmHome ha tyacha parent ahe mhanun sangitla mhnje customer ha parent chya baher janar nahi.
            obj.Show();
        }

        private void EmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Employee obj = new frm_Employee();
            obj.MdiParent = this;
            obj.Show();
        }

        private void QualificationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Masters.frm_Qualification obj = new Masters.frm_Qualification();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
