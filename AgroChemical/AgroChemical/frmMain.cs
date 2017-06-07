using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgroChemical
{
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
            lblDay.Text = DateTime.Now.ToString("dddd");
            string str = AgroFUN.getConnectionString();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChild();

            frmCategory FRMUNIT = new frmCategory();
            FRMUNIT.MdiParent = this;
            FRMUNIT.Dock = DockStyle.Fill;
            FRMUNIT.Show();
        }
        public void CloseChild()
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolstipExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolbtnCategory_Click(object sender, EventArgs e)
        {
            CloseChild();

            frmCategory FRMUNIT = new frmCategory();
            FRMUNIT.MdiParent = this;
            FRMUNIT.Dock = DockStyle.Fill;
            FRMUNIT.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            string strDateTime = DateTime.Now.Date.ToString("MM") + "-" + DateTime.Now.Date.ToString("dd") + "-" + DateTime.Now.Date.Year.ToString();
            String time = "";
            time = DateTime.Now.ToString("hh:mm:ss");  
            strDateTime = strDateTime + " " + time ;
            statusLabel.Text = strDateTime;
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChild();

            frmSupplier FRMUNIT = new frmSupplier();
            FRMUNIT.MdiParent = this;
            FRMUNIT.Dock = DockStyle.Fill;
            FRMUNIT.Show();
        }

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChild();

            frmStore FRMUNIT = new frmStore();
            FRMUNIT.MdiParent = this;
            FRMUNIT.Dock = DockStyle.Fill;
            FRMUNIT.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChild();

            frmCustomer FRMUNIT = new frmCustomer();
            FRMUNIT.MdiParent = this;
            FRMUNIT.Dock = DockStyle.Fill;
            FRMUNIT.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChild();

            frmUser FRMUNIT = new frmUser();
            FRMUNIT.MdiParent = this;
            FRMUNIT.Dock = DockStyle.Fill;
            FRMUNIT.Show();
        }

        private void tenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTenderType FRMUNIT = new frmTenderType();
            FRMUNIT.ShowDialog();
        }

        private void taxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTax FRMUNIT = new frmTax();
            FRMUNIT.ShowDialog();
        }

        private void storeSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStoreSetting FRMUNIT = new frmStoreSetting();
            FRMUNIT.ShowDialog();
        }

        private void mnuMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseChild();

            frmproduct FRMUNIT = new frmproduct();
            FRMUNIT.MdiParent = this;
            FRMUNIT.Dock = DockStyle.Fill;
            FRMUNIT.Show();
        }
    }
}
