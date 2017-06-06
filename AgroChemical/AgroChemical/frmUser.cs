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
    public partial class frmUser : Form
    {
        int USERID = 0;
        string strUserName;
        DataLib dLib = new DataLib();
        public frmUser()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Control_keyDown);
            this.KeyPreview = true;
            LoadGrid();
            txtFName.Text = "";
            ClearValue();
            txtFName.Focus();
            cmbUserType.Text = "General";
        }
        private void LoadGrid()
        {
            try
            {
                string strLoad = string.Empty;
                string strCat = txtSearch.Text.Trim();
                if (strCat.Length == 0)
                {
                    strLoad = "SELECT ID,FNAME,LNAME,LOGINNAME,USERTYPE FROM USERS";
                }
                else
                {
                    strLoad = "SELECT ID,FNAME,LNAME,LOGINNAME,USERTYPE FROM USERS where (LOWER(FNAME) LIKE '%" + strCat.ToLower() + "%' or LOWER(LNAME) LIKE '%" + strCat.ToLower() + "%' ) ";
                }
                DataTable dt = dLib.ExecuteDatTable(AgroFUN.gblConnString, strLoad);
                grdData.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                AgroFUN.SystemLog("CAT LOAD ERR" + ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string strQuery = string.Empty;
                string strCat = txtFName.Text.Trim();

                if (strCat.Length == 0)
                {
                    MessageBox.Show("Select USER");
                    txtFName.Focus();
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Are you Sure you want to delete it?", "Agro", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    if (USERID != 0)
                    {
                        strQuery = "DELETE FROM USERS  where ID=" + USERID;
                        dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                        txtFName.Text = "";
                        USERID = 0;
                        txtSearch.Text = "";
                        ClearValue();
                        txtFName.Focus();
                    }
                    LoadGrid();
                }
            }
            catch (Exception ex)
            {
                AgroFUN.SystemLog("DELETE:" + ex.Message.ToString());
            }
        }
        System.Windows.Forms.Timer SearchTextBoxTimer;
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (SearchTextBoxTimer != null)
            {
                SearchTextBoxTimer.Interval += 250;
            }
            else
            {
                SearchTextBoxTimer = new System.Windows.Forms.Timer();
                SearchTextBoxTimer.Tick += new EventHandler(SearchTextBoxTimer_Tick);
                SearchTextBoxTimer.Interval = 500;
                SearchTextBoxTimer.Start();
            }

        }
        private void SearchTextBoxTimer_Tick(object sender, EventArgs e)
        {
            SearchTextBoxTimer.Stop();
            SearchTextBoxTimer = null;
            LoadGrid();

        }
        private void grdUnit_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            for (int k = 0; k < grdData.SelectedRows.Count; k++)
            {
                USERID = Convert.ToInt32(grdData.SelectedRows[k].Cells["ID"].Value);
                txtFName.Text = grdData.SelectedRows[k].Cells["FNAME"].Value.ToString();
                strUserName = txtFName.Text;
                //Get The Value
                DataTable dt = dLib.ExecuteDatTable(AgroFUN.gblConnString, "select * from USERS where ID=" + USERID);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                   
                    txtLName.Text = dr["LName"].ToString();
                    txtLoginName.Text = dr["LOGINNAME"].ToString();
                   
                    txtPassword.Text =AgroFUN.DecodePassword(dr["Password"].ToString());
                    cmbUserType.Text = dr["UserType"].ToString();

                }

                txtFName.Focus();

            }
        }
        private bool CheckValidation(string vType = "ADD")
        {

            bool ckhValid = true;
            try
            {
                string strCat = txtFName.Text.Trim();
                if (strCat.Length == 0)
                {
                    MessageBox.Show("Enter Firstname");
                    txtFName.Focus();
                    return false;
                }


                if (vType == "ADD")
                {
                    if (dLib.CheckRecordExist(AgroFUN.gblConnString, "select ID from USERS where lower(FNAME)='" + strCat.ToLower() + "'"))
                    {
                        MessageBox.Show("USER Name allredy Exist");
                        txtFName.Focus();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                AgroFUN.SystemLog("CHEK CAT:" + ex.Message.ToString());
            }

            return ckhValid;
        }
        private void Control_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || (e.KeyCode == Keys.Return))
            {
                //this.SelectNextControl(this.ActiveControl, true, true, true, true);
                SendKeys.Send("{TAB}");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string strQuery = string.Empty;
                string strCat = txtFName.Text.Trim();

                if (USERID == 0)
                {
                    if (CheckValidation("ADD"))
                    {
                        strQuery = "INSERT INTO USERS(FNAME,LNAME,LOGINNAME,PASSWORD,USERTYPE,CREATEDATE) values ('" + strCat + "','" + txtLName.Text.Replace("'", "") + "', '" + txtLoginName.Text + "','" + AgroFUN.EncodePassword(txtPassword.Text) + "','"+cmbUserType.Text+"','"+DateTime.Now.ToString("dd-MM-yyyy")+"')";
                        USERID = dLib.ReturnID(AgroFUN.gblConnString, strQuery, "ID");
                        USERID = 0;

                    }
                }
                else
                {
                    if (CheckValidation("EDIT"))
                    {
                        if (txtFName.Text != strUserName)
                            if (!CheckValidation("ADD"))
                                return;
                        strQuery = "UPDATE USERS set FNAME='" + strCat + "',LNAME='" + txtLName.Text.Replace("'", "") + "',LOGINNAME='" + txtLoginName.Text + "',Password ='" +AgroFUN.EncodePassword(txtPassword.Text) + "',UserType='"+cmbUserType.Text+"',UpdateDate='"+DateTime.Now.ToString("dd-MM-yyyy")+"' where ID=" + USERID;
                        dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                        USERID = 0;
                        strUserName = "";
                    }
                }
                ClearValue();
                txtFName.Focus();
                txtFName.Text = "";
                LoadGrid();

            }
            catch (Exception ex)
            {
                AgroFUN.SystemLog("Save:" + ex.Message.ToString());
            }

        }
        private void ClearValue()
        {
            txtPassword.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";       
            txtLoginName.Text = "";
           
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
