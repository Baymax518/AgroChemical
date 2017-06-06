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
    public partial class frmCategory : Form
    {
        int CATID = 0;
        string strOldName;
        DataLib dLib = new DataLib();
        public frmCategory()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(Control_keyDown);
            this.KeyPreview = true;
            txtCategory.Text = "";
            txtCategory.Focus();
            LoadGrid();
        }
        private void LoadGrid()
        {
            try
            {
                string strLoad = string.Empty;
                string strCat=txtSearch.Text.Trim();
                if (strCat.Length == 0)
                {
                    strLoad = "SELECT ID,CATNAME FROM CATEGORY";
                }
                else
                {
                    strLoad = "SELECT ID,CATNAME FROM CATEGORY where LOWER(CATNAME) LIKE '%" + strCat.ToLower() + "%' ";
                }
                DataTable dt = dLib.ExecuteDatTable(AgroFUN.gblConnString,strLoad);
                grdData.DataSource = dt.DefaultView;
            }
            catch (Exception ex)
            {
                AgroFUN.SystemLog("CAT LOAD ERR" + ex.Message);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            CATID = 0;
            txtCategory.Text = "";
            txtCategory.Focus();
        }
        private bool CheckValidation(string vType = "ADD")
        {

            bool ckhValid = true;
            try
            {
                string strCat = txtCategory.Text.Trim();
                if (strCat.Length == 0)
                {
                    MessageBox.Show("Enter Category");
                    txtCategory.Focus();
                    return false;
                }

                
                if (vType == "ADD")
                {
                    if (dLib.CheckRecordExist(AgroFUN.gblConnString, "select ID from Category where lower(CatName)='" + strCat.ToLower() + "'"))
                    {
                        MessageBox.Show("Category Name allredy Exist");
                        txtCategory.Focus();
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string strQuery = string.Empty;
                string strCat=txtCategory.Text.Trim();
                
                if (CATID == 0)
                {
                    if (CheckValidation("ADD"))
                    {
                        strQuery = "INSERT INTO CATEGORY(CatName) values ('" + strCat + "')";
                        CATID = dLib.ReturnID(AgroFUN.gblConnString, strQuery, "ID");
                        CATID = 0;
                    }
                }
                else
                {
                    if (CheckValidation("EDIT"))
                    {
                        if (txtCategory.Text != strOldName)
                            if (!CheckValidation("ADD"))
                                return;
                        strQuery = "UPDATE CATEGORY set CatName='" + strCat + "' where ID=" + CATID;
                        dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                        CATID = 0;
                        strOldName = "";
                    }
                }
                txtCategory.Focus();
                txtCategory.Text = "";
                LoadGrid();
            }
            catch (Exception ex)
            {
                AgroFUN.SystemLog("Save:" + ex.Message.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string strQuery = string.Empty;
                string strCat = txtCategory.Text.Trim();

                if (strCat.Length == 0)
                {
                    MessageBox.Show("Selcet Category");
                    txtCategory.Focus();
                    return;
                }
                 DialogResult dialogResult = MessageBox.Show("Are you Sure you want to delete it?", "Agro", MessageBoxButtons.YesNo);
                 if (dialogResult == DialogResult.Yes)
                 {

                     if (CATID != 0)
                     {
                         strQuery = "DELETE FROM CATEGORY  where ID=" + CATID;
                         dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                         txtCategory.Text = "";
                         CATID = 0;
                         txtSearch.Text = "";
                         txtCategory.Focus();
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
                CATID = Convert.ToInt32(grdData.SelectedRows[k].Cells["ID"].Value);
                txtCategory.Text = grdData.SelectedRows[k].Cells["CategoryName"].Value.ToString();
                strOldName = txtCategory.Text;
                txtCategory.Focus();

            }
        }
        private void Control_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || (e.KeyCode == Keys.Return))
            {
                //this.SelectNextControl(this.ActiveControl, true, true, true, true);
                SendKeys.Send("{TAB}");
            }
        }   
    }
}
