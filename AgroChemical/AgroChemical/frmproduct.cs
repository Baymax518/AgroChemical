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
    public partial class frmproduct : Form
    {
        //int PRODUCTID = 0;
        string strDateTime = DateTime.Now.Date.ToString("MM") + "-" + DateTime.Now.Date.ToString("dd") + "-" + DateTime.Now.Date.Year.ToString();
        DataLib dLib = new DataLib();

        public frmproduct()
        {
            InitializeComponent();
            this.KeyPreview = true;
            LoadGrid();


        }
      
        public void CloseChild()
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
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


        private void LoadGrid()
        {
            try
            {
                string strLoad = string.Empty;
                string strCat = txtSearch.Text.Trim();

                if (strCat.Length == 0)
                {
                    strLoad = "SELECT P.ID,P.PRODUCTNAME,C.CATNAME,P.TYPE,P.UNITCOST,P.BARCODE,P.UNITPRICE,P.PACKQTY,P.SELLQTY,P.TAX1,P.TAX2,P.QTYONHAND,P.SUPPID,P.ISTOREID,P.CREATEDATE,P.UPDATEDATE FROM PRODUCT AS P LEFT JOIN CATEGORY AS C ON P.CATID = C.ID";
                }
                else
                {
                    //  strLoad = "SELECT P.ID,P.PRODUCTNAME,C.CATNAME,P.TYPE,P.UNITCOST,P.BARCODE,P.UNITPRICE,P.PACKQTY,P.SELLQTY,P.TAX1,P.TAX2,P.QTYONHAND,P.SUPPID,P.ISTOREID,P.CREATEDATE,P.UPDATEDATE FROM PRODUCT AS P LEFT JOIN CATEGORY AS C ON P.CATID = C.ID WHERE P.PRODUCTNAME='"+strCat+"'";
                    strLoad = "SELECT P.ID,P.PRODUCTNAME,C.CATNAME,P.TYPE,P.UNITCOST,P.BARCODE,P.UNITPRICE,P.PACKQTY,P.SELLQTY,P.TAX1,P.TAX2,P.QTYONHAND,P.SUPPID,P.ISTOREID,P.CREATEDATE,P.UPDATEDATE FROM PRODUCT AS P LEFT JOIN CATEGORY AS C ON P.CATID = C.ID WHERE P.PRODUCTNAME LIKE '%" + strCat + "%' OR P.CREATEDATE LIKE'%"+strCat+ "' OR P.UPDATEDATE LIKE'%" + strCat + "'";

                }

                DataTable dt = dLib.ExecuteDatTable(AgroFUN.gblConnString, strLoad);
                datagrd.DataSource = dt;
            }
            catch (Exception ex)
            {
                AgroFUN.SystemLog("CAT LOAD ERR" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           frmProductAdd FRMUNIT = new frmProductAdd();
            FRMUNIT.MdiParent = this.MdiParent;
            FRMUNIT.Dock = DockStyle.Fill;
            FRMUNIT.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strCat = string.Empty;
            strCat = txtSearch.Text;
            string datecheck=CheckDate(strCat).ToString();
            try
            {
                if (strCat.Length == 0)
                {
                    MessageBox.Show("Please enter Product Name OR Date to search");
                }
                else
                {
                    if (datecheck == "True")
                    {
                        string strLoad = string.Empty;
                        strLoad = "SELECT P.ID,P.PRODUCTNAME,C.CATNAME,P.TYPE,P.UNITCOST,P.BARCODE,P.UNITPRICE,P.PACKQTY,P.SELLQTY,P.TAX1,P.TAX2,P.QTYONHAND,P.SUPPID,P.ISTOREID,P.CREATEDATE,P.UPDATEDATE FROM PRODUCT AS P LEFT JOIN CATEGORY AS C ON P.CATID = C.ID WHERE P.CREATEDATE='" + txtSearch.Text + "' OR P.UPDATEDATE= '" + txtSearch.Text + "'";
                        DataTable dt = dLib.ExecuteDatTable(AgroFUN.gblConnString, strLoad);
                        datagrd.DataSource = dt.DefaultView;
                    }
                    else
                    {
                        string strLoad = string.Empty;
                        strLoad = "SELECT P.ID,P.PRODUCTNAME,C.CATNAME,P.TYPE,P.UNITCOST,P.BARCODE,P.UNITPRICE,P.PACKQTY,P.SELLQTY,P.TAX1,P.TAX2,P.QTYONHAND,P.SUPPID,P.ISTOREID,P.CREATEDATE,P.UPDATEDATE FROM PRODUCT AS P LEFT JOIN CATEGORY AS C ON P.CATID = C.ID WHERE P.PRODUCTNAME='" + strCat + "'";
                        DataTable dt = dLib.ExecuteDatTable(AgroFUN.gblConnString, strLoad);
                        datagrd.DataSource = dt.DefaultView;
                  
                    }
                  

                }
            }
            catch (Exception ex)
            {
                AgroFUN.SystemLog("CAT LOAD ERR" + ex.Message);
            }
    }

        private bool CheckDate(String strCat)
        {
            try
            {
                DateTime dt = DateTime.Parse(strCat);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void frmproduct_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            frmProductAdd FRMUNIT = new frmProductAdd();
            FRMUNIT.MdiParent = this.MdiParent;
            FRMUNIT.Dock = DockStyle.Fill;
            FRMUNIT.Show();

        }

        private void btnSearchtxt_Click(object sender, EventArgs e)
        {
            string strCat = string.Empty;
            strCat = txtSearch.Text;
            string datecheck = CheckDate(strCat).ToString();
            try
            {
                if (strCat.Length == 0)
                {
                    MessageBox.Show("Please enter Product Name OR Date to search");
                }
                else
                {
                    if (datecheck == "True")
                    {
                        string strLoad = string.Empty;
                        strLoad = "SELECT P.ID,P.PRODUCTNAME,C.CATNAME,P.TYPE,P.UNITCOST,P.BARCODE,P.UNITPRICE,P.PACKQTY,P.SELLQTY,P.TAX1,P.TAX2,P.QTYONHAND,P.SUPPID,P.ISTOREID,P.CREATEDATE,P.UPDATEDATE FROM PRODUCT AS P LEFT JOIN CATEGORY AS C ON P.CATID = C.ID WHERE P.CREATEDATE='" + txtSearch.Text + "' OR P.UPDATEDATE= '" + txtSearch.Text + "'";
                        DataTable dt = dLib.ExecuteDatTable(AgroFUN.gblConnString, strLoad);
                        datagrd.DataSource = dt.DefaultView;
                    }
                    else
                    {
                        string strLoad = string.Empty;
                        strLoad = "SELECT P.ID,P.PRODUCTNAME,C.CATNAME,P.TYPE,P.UNITCOST,P.BARCODE,P.UNITPRICE,P.PACKQTY,P.SELLQTY,P.TAX1,P.TAX2,P.QTYONHAND,P.SUPPID,P.ISTOREID,P.CREATEDATE,P.UPDATEDATE FROM PRODUCT AS P LEFT JOIN CATEGORY AS C ON P.CATID = C.ID WHERE P.PRODUCTNAME='" + strCat + "'";
                        DataTable dt = dLib.ExecuteDatTable(AgroFUN.gblConnString, strLoad);
                        datagrd.DataSource = dt.DefaultView;

                    }


                }
            }
            catch (Exception ex)
            {
                AgroFUN.SystemLog("CAT LOAD ERR" + ex.Message);
            }
        }

        private void datagrd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void datagrd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProductAdd FRMUNIT = new frmProductAdd();
            FRMUNIT.txtPId.Text = this.datagrd.CurrentRow.Cells[0].Value.ToString();
            FRMUNIT.txtPName.Text = this.datagrd.CurrentRow.Cells[1].Value.ToString();
            FRMUNIT.cmbCatId.Text = this.datagrd.CurrentRow.Cells[2].Value.ToString();
            FRMUNIT.cmbTyp.Text = this.datagrd.CurrentRow.Cells[3].Value.ToString();
            FRMUNIT.txtUnitCost.Text = this.datagrd.CurrentRow.Cells[4].Value.ToString();
            FRMUNIT.txtBarcode.Text = this.datagrd.CurrentRow.Cells[5].Value.ToString();
            FRMUNIT.txtUnitPrice.Text = this.datagrd.CurrentRow.Cells[6].Value.ToString();
            FRMUNIT.txtPacketQty.Text = this.datagrd.CurrentRow.Cells[7].Value.ToString();
            FRMUNIT.txtSellQty.Text = this.datagrd.CurrentRow.Cells[8].Value.ToString();
         //   FRMUNIT.txtTax1.Text = this.datagrd.CurrentRow.Cells[9].Value.ToString();
          //  FRMUNIT.txtTax2.Text = this.datagrd.CurrentRow.Cells[10].Value.ToString();
            FRMUNIT.txtQtyOnHand.Text = this.datagrd.CurrentRow.Cells[11].Value.ToString();
            FRMUNIT.cmbSupplId.Text = this.datagrd.CurrentRow.Cells[12].Value.ToString();
            FRMUNIT.txtStoreId.Text = this.datagrd.CurrentRow.Cells[13].Value.ToString();
            if (this.datagrd.CurrentRow.Cells[9].Value.ToString().Length > 0)
            {
                FRMUNIT.tax1.Checked = true;
            }
            if (this.datagrd.CurrentRow.Cells[10].Value.ToString().Length > 0)
            {
                FRMUNIT.tax2.Checked = true;
            }

            FRMUNIT.MdiParent = this.MdiParent;
            FRMUNIT.Dock = DockStyle.Fill;
            FRMUNIT.Show();
        }
    }
}


     

  
