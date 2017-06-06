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
    public partial class frmStoreSetting : Form
    {
        string STORESETTINGNAME = "0";
        string strSTORESETTINGNAME;
        DataLib dLib = new DataLib();
        public frmStoreSetting()
        {
            InitializeComponent();
            this.KeyPreview = true;
            LoadGrid();
            txtSettingName.Text = "";
            ClearValue();
            txtSettingName.Focus();
        }
        private void LoadGrid()
        {
            try
            {
                string strLoad = string.Empty;
                string strCat = txtSearch.Text.Trim();
                if (strCat.Length == 0)
                {
                    strLoad = "SELECT SETTINGNAME,SETTINGVALUE FROM SETTING";
                }
                else
                {
                    strLoad = "SELECT SETTINGNAME,SETTINGVALUE FROM SETTING where (LOWER(SETTINGNAME) LIKE '%" + strCat.ToLower() + "%') ";
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
                string strCat = txtSettingName.Text.Trim();

                if (strCat.Length == 0)
                {
                    MessageBox.Show("Select Tax");
                    txtSettingName.Focus();
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Are you Sure you want to delete it?", "Agro", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    if (STORESETTINGNAME != "0")
                    {
                        strQuery = "DELETE FROM SETTING  where SETTINGNAME='" + STORESETTINGNAME + "'";
                        dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                        txtSettingName.Text = "";
                        STORESETTINGNAME = "0";
                        txtSearch.Text = "";
                        ClearValue();
                        txtSettingName.Focus();
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
                STORESETTINGNAME = (grdData.SelectedRows[k].Cells["SETTINGNAME"].Value).ToString();
                txtSettingName.Text = grdData.SelectedRows[k].Cells["SETTINGNAME"].Value.ToString();
                strSTORESETTINGNAME = txtSettingName.Text;

                //Get The Value
                DataTable dt = dLib.ExecuteDatTable(AgroFUN.gblConnString, "select * from SETTING where SETTINGNAME='" + STORESETTINGNAME + "'");
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    txtSettingName.ReadOnly = true;
                    txtSettingValue.Text = dr["SETTINGVALUE"].ToString();
                    txtSettingValue.Focus();
                }

               // txtSettingName.Focus();

            }
        }
        private bool CheckValidation(string vType = "ADD")
        {

            bool ckhValid = true;
            try
            {
                string strCat = txtSettingName.Text.Trim();
                if (strCat.Length == 0)
                {
                    MessageBox.Show("Enter Code");
                    txtSettingName.Focus();
                    return false;
                }


                if (vType == "ADD")
                {
                    if (dLib.CheckRecordExist(AgroFUN.gblConnString, "select SETTINGNAME from SETTING where lower(SETTINGNAME)='" + strCat.ToLower() + "'"))
                    {
                        MessageBox.Show("Tax Code allredy Exist");
                        txtSettingName.Focus();
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
                string strCat = txtSettingName.Text.Trim();

                if (STORESETTINGNAME == "0")
                {
                    if (CheckValidation("ADD"))
                    {
                        strQuery = "INSERT INTO SETTING(SETTINGNAME,SETTINGVALUE) values ('" + strCat + "','" + txtSettingValue.Text + "')";
                        //STORESETTINGNAME = dLib.ReturnID(AgroFUN.gblConnString, strQuery, "ID");
                        dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                        STORESETTINGNAME = "0";

                    }
                }
                else
                {
                    if (CheckValidation("EDIT"))
                    {
                        if (txtSettingName.Text != strSTORESETTINGNAME)
                            if (!CheckValidation("ADD"))
                                return;
                        strQuery = "UPDATE SETTING set SETTINGVALUE='" + txtSettingValue.Text
                            + "' where SETTINGNAME='" + STORESETTINGNAME + "'";
                        dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                        STORESETTINGNAME = "0";
                        strSTORESETTINGNAME = "";
                    }
                }
                ClearValue();
                txtSettingName.ReadOnly = false;
                txtSettingName.Focus();
                txtSettingName.Text = "";
                LoadGrid();

            }
            catch (Exception ex)
            {
                AgroFUN.SystemLog("Save:" + ex.Message.ToString());
            }

        }
        private void ClearValue()
        {
            txtSettingName.Text = "";            
            txtSettingValue.Text = "";
            txtSettingName.ReadOnly = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
