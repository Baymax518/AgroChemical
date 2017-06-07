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
    public partial class frmTax : Form
    {
        string TAXCODE = "0";
        string strTaxCode;
        DataLib dLib = new DataLib();
        public frmTax()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Control_keyDown);
            this.KeyPreview = true;
            LoadGrid();
            txtCode.Text = "";
            ClearValue();
            txtCode.Focus();
            
        }
        private void LoadGrid()
        {
            try
            {
                string strLoad = string.Empty;
                string strCat = txtSearch.Text.Trim();
                if (strCat.Length == 0)
                {
                    strLoad = "SELECT CODE,TAXTYPE,RATE FROM STORETAX";
                }
                else
                {
                    strLoad = "SELECT CODE,TAXTYPE,RATE FROM STORETAX where (LOWER(TAXTYPE) LIKE '%" + strCat.ToLower() + "%') ";
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
                string strCat = txtCode.Text.Trim();

                if (strCat.Length == 0)
                {
                    MessageBox.Show("Select Tax");
                    txtCode.Focus();
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Are you Sure you want to delete it?", "Agro", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    if (TAXCODE != "0")
                    {
                        strQuery = "DELETE FROM STORETAX  where CODE='" + TAXCODE + "'";
                        dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                        txtCode.Text = "";
                        TAXCODE = "0";
                        txtSearch.Text = "";
                        ClearValue();
                        txtCode.Focus();
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
                TAXCODE = (grdData.SelectedRows[k].Cells["CODE"].Value).ToString();
                txtCode.Text = grdData.SelectedRows[k].Cells["CODE"].Value.ToString();
                strTaxCode = txtCode.Text;
                //Get The Value
                DataTable dt = dLib.ExecuteDatTable(AgroFUN.gblConnString, "select * from STORETAX where CODE='" + TAXCODE+"'");
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    txtType.Text = dr["TAXTYPE"].ToString();
                    txtRate.Text = dr["RATE"].ToString();
                }

                txtCode.Focus();

            }
        }
        private bool CheckValidation(string vType = "ADD")
        {

            bool ckhValid = true;
            try
            {
                string strCat = txtCode.Text.Trim();
                if (strCat.Length == 0)
                {
                    MessageBox.Show("Enter Code");
                    txtCode.Focus();
                    return false;
                }


                if (vType == "ADD")
                {
                    if (dLib.CheckRecordExist(AgroFUN.gblConnString, "select CODE from STORETAX where lower(CODE)='" + strCat.ToLower() + "'"))
                    {
                        MessageBox.Show("Tax Code allredy Exist");
                        txtCode.Focus();
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
                string strCat = txtCode.Text.Trim();

                if (TAXCODE == "0")
                {
                    if (CheckValidation("ADD"))
                    {
                        strQuery = "INSERT INTO STORETAX(CODE,TAXTYPE,RATE) values ('" + strCat + "','" + txtType.Text + "','"+txtRate.Text+"')";
                        //TAXCODE = dLib.ReturnID(AgroFUN.gblConnString, strQuery, "ID");
                        dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                        TAXCODE = "0";

                    }
                }
                else
                {
                    if (CheckValidation("EDIT"))
                    {
                        if (txtCode.Text != strTaxCode)
                            if (!CheckValidation("ADD"))
                                return;
                        strQuery = "UPDATE STORETAX set RATE ='"+txtRate.Text+"',TAXTYPE='" +txtType.Text
                            + "' where CODE='" + TAXCODE+"'";
                        dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                        TAXCODE = "0";
                        strTaxCode = "";
                    }
                }
                ClearValue();
                txtCode.Focus();
                txtCode.Text = "";
                LoadGrid();

            }
            catch (Exception ex)
            {
                AgroFUN.SystemLog("Save:" + ex.Message.ToString());
            }

        }
        private void ClearValue()
        {

            txtCode.Text = "";
            txtRate.Text = "";
            txtType.Text = "";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTax_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
