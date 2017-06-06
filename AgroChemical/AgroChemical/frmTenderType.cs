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
    public partial class frmTenderType : Form
    {
        int TENDERID = 0;
        string strTenderName;
        DataLib dLib = new DataLib();
        public frmTenderType()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Control_keyDown);
            this.KeyPreview = true;
            LoadGrid();
            txtTenderName.Text = "";
            ClearValue();
            txtTenderName.Focus();
            cmbTenderStatus.Text = "Active";
        }
        private void LoadGrid()
        {
            try
            {
                string strLoad = string.Empty;
                string strCat = txtSearch.Text.Trim();
                if (strCat.Length == 0)
                {
                    strLoad = "SELECT ID,TENDERNAME,TENDERSTATUS FROM TENDERTYPE";
                }
                else
                {
                    strLoad = "SELECT ID,TENDERNAME,TENDERSTATUS FROM TENDERTYPE where (LOWER(TENDERNAME) LIKE '%" + strCat.ToLower() + "%') ";
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
                string strCat = txtTenderName.Text.Trim();

                if (strCat.Length == 0)
                {
                    MessageBox.Show("Select USER");
                    txtTenderName.Focus();
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Are you Sure you want to delete it?", "Agro", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    if (TENDERID != 0)
                    {
                        strQuery = "DELETE FROM TENDERTYPE  where ID=" + TENDERID;
                        dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                        txtTenderName.Text = "";
                        TENDERID = 0;
                        txtSearch.Text = "";
                        ClearValue();
                        txtTenderName.Focus();
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
                TENDERID = Convert.ToInt32(grdData.SelectedRows[k].Cells["ID"].Value);
                txtTenderName.Text = grdData.SelectedRows[k].Cells["TENDERNAME"].Value.ToString();
                strTenderName = txtTenderName.Text;
                //Get The Value
                DataTable dt = dLib.ExecuteDatTable(AgroFUN.gblConnString, "select * from TENDERTYPE where ID=" + TENDERID);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];

                   
                    cmbTenderStatus.Text = dr["TenderStatus"].ToString();

                }

                txtTenderName.Focus();

            }
        }
        private bool CheckValidation(string vType = "ADD")
        {

            bool ckhValid = true;
            try
            {
                string strCat = txtTenderName.Text.Trim();
                if (strCat.Length == 0)
                {
                    MessageBox.Show("Enter Firstname");
                    txtTenderName.Focus();
                    return false;
                }


                if (vType == "ADD")
                {
                    if (dLib.CheckRecordExist(AgroFUN.gblConnString, "select ID from TENDERTYPE where lower(FNAME)='" + strCat.ToLower() + "'"))
                    {
                        MessageBox.Show("USER Name allredy Exist");
                        txtTenderName.Focus();
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
                string strCat = txtTenderName.Text.Trim();

                if (TENDERID == 0)
                {
                    if (CheckValidation("ADD"))
                    {
                        strQuery = "INSERT INTO TENDERTYPE(TENDERNAME,TENDERSTATUS) values ('" + strCat + "','" + cmbTenderStatus.Text + "')";
                        TENDERID = dLib.ReturnID(AgroFUN.gblConnString, strQuery, "ID");
                        TENDERID = 0;

                    }
                }
                else
                {
                    if (CheckValidation("EDIT"))
                    {
                        if (txtTenderName.Text != strTenderName)
                            if (!CheckValidation("ADD"))
                                return;
                        strQuery = "UPDATE TENDERTYPE set TENDERNAME='" + strCat + "',TenderStatus='" + cmbTenderStatus.Text + "' where ID=" + TENDERID;
                        dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                        TENDERID = 0;
                        strTenderName = "";
                    }
                }
                ClearValue();
                txtTenderName.Focus();
                txtTenderName.Text = "";
                LoadGrid();

            }
            catch (Exception ex)
            {
                AgroFUN.SystemLog("Save:" + ex.Message.ToString());
            }

        }
        private void ClearValue()
        {
            
            txtTenderName.Text = "";
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
