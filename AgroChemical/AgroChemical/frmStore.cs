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
    public partial class frmStore : Form
    {
        int STOREID = 0;
        string strOldName;
        DataLib dLib = new DataLib();
        public frmStore()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Control_keyDown);
            this.KeyPreview = true; 
            LoadGrid();
            txtStore.Text = "";
            ClearValue();
            txtStore.Focus();
           
        }
        private void LoadGrid()
        {
            try
            {
                string strLoad = string.Empty;
                string strCat = txtSearch.Text.Trim();
                if (strCat.Length == 0)
                {
                    strLoad = "SELECT ID,STORENAME,CITY,PHONE,STATE,ZIP FROM STORE";
                }
                else
                {
                    strLoad = "SELECT ID,STORENAME,CITY,PHONE,STATE,ZIP FROM STORE where LOWER(STORENAME) LIKE '%" + strCat.ToLower() + "%' ";
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
                string strCat = txtStore.Text.Trim();

                if (strCat.Length == 0)
                {
                    MessageBox.Show("Selcet STore");
                    txtStore.Focus();
                    return;
                }
                DialogResult dialogResult = MessageBox.Show("Are you Sure you want to delete it?", "Agro", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    if (STOREID != 0)
                    {
                        strQuery = "DELETE FROM STORE  where ID=" + STOREID;
                        dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                        txtStore.Text = "";
                        STOREID = 0;
                        txtSearch.Text = "";
                        ClearValue();
                        txtStore.Focus();
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
                STOREID = Convert.ToInt32(grdData.SelectedRows[k].Cells["ID"].Value);
                txtStore.Text = grdData.SelectedRows[k].Cells["Store"].Value.ToString();
                strOldName = txtStore.Text;
                //Get The Value
                DataTable dt = dLib.ExecuteDatTable(AgroFUN.gblConnString,"select * from Store where ID=" + STOREID);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    txtAddress.Text = dr["Address"].ToString();
                    txtCity.Text = dr["City"].ToString();
                    txtPhone.Text = dr["Phone"].ToString();
                    txtState.Text = dr["State"].ToString();
                    txtZip.Text = dr["Zip"].ToString();

                }

                txtStore.Focus();

            }
        }
        private bool CheckValidation(string vType = "ADD")
        {

            bool ckhValid = true;
            try
            {
                string strCat = txtStore.Text.Trim();
                if (strCat.Length == 0)
                {
                    MessageBox.Show("Enter Category");
                    txtStore.Focus();
                    return false;
                }


                if (vType == "ADD")
                {
                    if (dLib.CheckRecordExist(AgroFUN.gblConnString, "select ID from STORE where lower(SToreName)='" + strCat.ToLower() + "'"))
                    {
                        MessageBox.Show("Store Name allredy Exist");
                        txtStore.Focus();
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
                string strCat = txtStore.Text.Trim();

                if (STOREID == 0)
                {
                    if (CheckValidation("ADD"))
                    {
                        strQuery = "INSERT INTO STORE(StoreName,ADDRESS,CITY,State,Phone,Zip) values ('" + strCat + "','" + txtAddress.Text.Replace("'", "") + "','" + txtCity.Text + "','" + txtState.Text + "','" + txtPhone.Text + "','" + txtZip.Text + "')";
                        STOREID = dLib.ReturnID(AgroFUN.gblConnString, strQuery, "ID");
                        STOREID = 0;

                    }
                }
                else
                {
                    if (CheckValidation("EDIT"))
                    {
                        if (txtStore.Text != strOldName)
                            if (!CheckValidation("ADD"))
                                return;
                        strQuery = "UPDATE STORE set STORENAME='" + strCat + "',ADDRESS='"+txtAddress.Text.Replace("'","")+"',CITY='"+txtCity.Text+"',State='"+txtState.Text+"',Phone='"+txtPhone.Text+"',Zip ='"+txtZip.Text+"' where ID=" + STOREID;
                        dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                        STOREID = 0;
                        strOldName = "";
                    }
                }
                ClearValue();
                    txtStore.Focus();
                    txtStore.Text = "";
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
            txtStore.Text = "";
            txtState.Text = "";
            txtPhone.Text = "";
            txtCity.Text = "";
            txtAddress.Text = "";
        }
    }
}
