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
    public partial class frmItem : Form
    {
        public frmItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmItemAdd FRMUNIT = new frmItemAdd();
            FRMUNIT.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTest FRMUNIT = new frmTest();
            FRMUNIT.MdiParent = this.MdiParent;
            FRMUNIT.Dock = DockStyle.Fill;
            FRMUNIT.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
