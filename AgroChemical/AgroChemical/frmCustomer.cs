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
    public partial class frmCustomer : Form
    {
        int CUSTOMERID = 0;
        string strCustomerName;
        DataLib dLib = new DataLib();
        public frmCustomer()
        {
            InitializeComponent();           
            this.KeyDown += new KeyEventHandler(Control_keyDown);
            this.KeyPreview = true;
            LoadGrid();
            txtFName.Text = "";
            ClearValue();
            txtFName.Focus();
        }
        private void LoadGrid()
        {
            try
            {
                string strLoad = string.Empty;
                string strCat = txtSearch.Text.Trim();
                if (strCat.Length == 0)
                {
                    strLoad = "SELECT ID,FNAME,CITY,PHONE,STATE,ZIP,DEBITAMOUNT,CREDITAMOUNT FROM CUSTOMER";
                }
                else
                {
                    strLoad = "SELECT ID,FNAME,CITY,PHONE,STATE,ZIP,DEBITAMOUNT,CREDITAMOUNT FROM CUSTOMER where (LOWER(FNAME) LIKE '%" + strCat.ToLower() + "%' or LOWER(LNAME) LIKE '%" + strCat.ToLower() + "%' ) ";
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
                    MessageBox.Show("Select CUSTOMER");
                    txtFName.Focus();
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Are you Sure you want to delete it?", "Agro", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    if (CUSTOMERID != 0)
                    {
                        strQuery = "DELETE FROM CUSTOMER  where ID=" + CUSTOMERID;
                        dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                        txtFName.Text = "";
                        CUSTOMERID = 0;
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
                CUSTOMERID = Convert.ToInt32(grdData.SelectedRows[k].Cells["ID"].Value);
                txtFName.Text = grdData.SelectedRows[k].Cells["FNAME"].Value.ToString();
                strCustomerName = txtFName.Text;
                //Get The Value
                DataTable dt = dLib.ExecuteDatTable(AgroFUN.gblConnString, "select * from Customer where ID=" + CUSTOMERID);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    txtAddress.Text = dr["Address"].ToString();
                    txtLName.Text = dr["LName"].ToString();
                    txtCity.Text = dr["City"].ToString();
                    txtPhone.Text = dr["Phone"].ToString();
                    txtState.Text = dr["State"].ToString();
                    txtZip.Text = dr["Zip"].ToString();

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
                    if (dLib.CheckRecordExist(AgroFUN.gblConnString, "select ID from CUSTOMER where lower(FNAME)='" + strCat.ToLower() + "'"))
                    {
                        MessageBox.Show("Customer Name allredy Exist");
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

                if (CUSTOMERID == 0)
                {
                    if (CheckValidation("ADD"))
                    {
                        strQuery = "INSERT INTO CUSTOMER(FNAME,LNAME,ADDRESS,CITY,State,Phone,Zip) values ('" + strCat + "','"+txtLName.Text.Replace("'","")+"','" + txtAddress.Text.Replace("'", "") + "','" + txtCity.Text + "','" + txtState.Text + "','" + txtPhone.Text + "','" + txtZip.Text + "')";
                        CUSTOMERID = dLib.ReturnID(AgroFUN.gblConnString, strQuery, "ID");
                        CUSTOMERID = 0;

                    }
                }
                else
                {
                    if (CheckValidation("EDIT"))
                    {
                        if (txtFName.Text != strCustomerName)
                            if (!CheckValidation("ADD"))
                                return;
                        strQuery = "UPDATE CUSTOMER set FNAME='" + strCat + "',LNAME='" + txtLName.Text.Replace("'", "") + "',ADDRESS='" + txtAddress.Text.Replace("'", "") + "',CITY='" + txtCity.Text + "',State='" + txtState.Text + "',Phone='" + txtPhone.Text + "',Zip ='" + txtZip.Text + "' where ID=" + CUSTOMERID;
                        dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                        CUSTOMERID = 0;
                        strCustomerName = "";
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
            txtZip.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtState.Text = "";
            txtPhone.Text = "";
            txtCity.Text = "";
            txtAddress.Text = "";
        }
    }
}
