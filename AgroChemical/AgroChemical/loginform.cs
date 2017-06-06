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
    public partial class loginform : Form
    {

        DataLib dLib = new DataLib();

        public loginform()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            string str = AgroFUN.getConnectionString();

        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string uname = unametxt.Text;
      
            string password = passtxt.Text;

            if(string.IsNullOrEmpty(uname))
            {
                MessageBox.Show("Please enter UserName");
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter Password");
            }
        


            else
            {
                DataTable dt = dLib.ExecuteDatTable(AgroFUN.gblConnString, "select * from USERS where LOGINNAME='" + uname + "' and PASSWORD='" + AgroFUN.EncodePassword(password) + "'");

                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    MessageBox.Show("LogIn Successful");
                    frmMain fm = new frmMain();
                    fm.Show();
                    this.Hide();

                }

                else
                {

                    MessageBox.Show("invalid  login details");
                    cleardata();

                }
            }

        }

        public void cleardata()
        {

            unametxt.Text = "";
            passtxt.Text = "";

        }

        public void validate()
        {



        }
    }



}
