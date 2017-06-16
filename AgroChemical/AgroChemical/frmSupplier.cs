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
    public partial class frmSupplier : Form
    {
        int SUPPLIERID = 0;
        string strSupplierName;
        DataLib dLib = new DataLib();
        public frmSupplier()
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
                    strLoad = "SELECT ID,FNAME,CITY,STATE,ZIP,COMPNAME,HOMEPHONE FROM SUPPLIER";
                }
                else
                {
                    strLoad = "SELECT ID,FNAME,CITY,STATE,ZIP,COMPNAME,HOMEPHONE FROM SUPPLIER where (LOWER(FNAME) LIKE '%" + strCat.ToLower() + "%' or LOWER(LNAME) LIKE '%" + strCat.ToLower() + "%' or LOWER(COMPNAME) LIKE '%" + strCat.ToLower() + "%' ) ";
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
                    MessageBox.Show("Select SUPPLIER");
                    txtFName.Focus();
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Are you Sure you want to delete it?", "Agro", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    if (SUPPLIERID != 0)
                    {
                        strQuery = "DELETE FROM SUPPLIER  where ID=" + SUPPLIERID;
                        dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                        txtFName.Text = "";
                        SUPPLIERID = 0;
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
                SUPPLIERID = Convert.ToInt32(grdData.SelectedRows[k].Cells["ID"].Value);
                txtFName.Text = grdData.SelectedRows[k].Cells["FNAME"].Value.ToString();
                strSupplierName = txtFName.Text;
                //Get The Value
                DataTable dt = dLib.ExecuteDatTable(AgroFUN.gblConnString, "select * from SUPPLIER where ID=" + SUPPLIERID);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    txtAddress.Text = dr["Address"].ToString();
                    txtLName.Text = dr["LName"].ToString();
                    txtCity.Text = dr["City"].ToString();
                    txtPhone.Text = dr["HomePhone"].ToString();
                    txtState.Text = dr["State"].ToString();
                    txtZip.Text = dr["Zip"].ToString();
                    txtCompName.Text = dr["COMPNAME"].ToString();
                    txtSecodPhone.Text = dr["SECONDPHONE"].ToString();

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
                    if (dLib.CheckRecordExist(AgroFUN.gblConnString, "select ID from SUPPLIER where lower(FNAME)='" + strCat.ToLower() + "'"))
                    {
                        MessageBox.Show("SUPPLIER Name allredy Exist");
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

                if (SUPPLIERID == 0)
                {
                    if (CheckValidation("ADD"))
                    {
                        strQuery = "INSERT INTO SUPPLIER(FNAME,LNAME,COMPNAME,ADDRESS,CITY,State,HomePhone,SecondPhone,Zip) values ('" + strCat + "','" + txtLName.Text.Replace("'", "") + "','" + txtCompName.Text.Replace("'", "") + "','" + txtAddress.Text.Replace("'", "") + "','" + txtCity.Text + "','" + txtState.Text + "','" + txtPhone.Text + "','"+txtSecodPhone.Text+"','" + txtZip.Text + "')";
                        SUPPLIERID = dLib.ReturnID(AgroFUN.gblConnString, strQuery, "ID");
                        SUPPLIERID = 0;

                    }
                }
                else
                {
                    if (CheckValidation("EDIT"))
                    {
                        if (txtFName.Text != strSupplierName)
                            if (!CheckValidation("ADD"))
                                return;
                        strQuery = "UPDATE SUPPLIER set FNAME='" + strCat + "',LNAME='" + txtLName.Text.Replace("'", "") + "',COMPNAME='"+txtCompName.Text.Replace("'","")+"',ADDRESS='" + txtAddress.Text.Replace("'", "") + "',CITY='" + txtCity.Text + "',State='" + txtState.Text + "',HomePhone='" + txtPhone.Text + "',SecondPhone='"+txtSecodPhone.Text+"',Zip ='" + txtZip.Text + "' where ID=" + SUPPLIERID;
                        dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                        SUPPLIERID = 0;
                        strSupplierName = "";
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
            txtSecodPhone.Text = "";
            txtCompName.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtState.Text = "";
            txtPhone.Text = "";
            txtCity.Text = "";
            txtAddress.Text = "";
        }

        private void grdData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
