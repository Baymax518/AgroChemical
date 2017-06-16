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
    public partial class frmProductAdd : Form
    {
        DataLib dLib = new DataLib();
        string strDateTime = DateTime.Now.Date.ToString("MM") + "-" + DateTime.Now.Date.ToString("dd") + "-" + DateTime.Now.Date.Year.ToString();
        int TAX_1, TAX_2,CatId,SupplId;

        public frmProductAdd()
        {
            InitializeComponent();
            SelectTax();
            ComboBoxLoad();
            LoadGrid();
            LoadPackGrid();
        }
        private void LoadPackGrid()
        {
            try
            {
                string strLoad = string.Empty;
                strLoad = "SELECT * FROM ITEMPACKDETAIL";
                DataTable dt = dLib.ExecuteDatTable(AgroFUN.gblConnString, strLoad);
                datagrdItemPack.DataSource = dt;
            }
            catch (Exception ex)
            {
                AgroFUN.SystemLog("CAT LOAD ERR" + ex.Message);
            }
        }

        private void ucProduct1_Load(object sender, EventArgs e)
        {

        }

        private void ucProduct1_Load_1(object sender, EventArgs e)
        {

        }

        private void frmProductAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void ucProduct1_Load_2(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadGrid()
        {
            try
            {
                string strLoad = string.Empty;
                strLoad = "SELECT * FROM PRODUCT WHERE ID='"+txtPId.Text+"'";
                DataTable dt = dLib.ExecuteDatTable(AgroFUN.gblConnString, strLoad);
                datagrditem.DataSource = dt;
            }
            catch (Exception ex)
            {
                AgroFUN.SystemLog("CAT LOAD ERR" + ex.Message);
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbTyp.Text == "Lot Matrix")
                {
                    string strQuery = string.Empty;
                    {
                        SelectTax();
                        strQuery = "insert into PRODUCT(ID,PRODUCTNAME,CATID,TYPE,UNITCOST,BARCODE,UNITPRICE,PACKQTY,SELLQTY,TAX1,TAX2,QTYONHAND,SUPPID,ISTOREID,CREATEDATE) values ('" + txtPId.Text + "','" + txtPName.Text + "','" + CatId + "','" + cmbTyp.Text + "','" + txtUnitCost.Text + "','" + txtBarcode.Text + "','" + txtUnitPrice.Text + "','" + txtPacketQty.Text + "','" + txtSellQty.Text + "','" + TAX_1+ "','" + TAX_2 + "','" + txtQtyOnHand.Text + "','" + SupplId+ "','" + txtStoreId.Text + "','" + strDateTime + "')";
                        dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                        LoadGrid();
                    }
                    tabControl1.SelectedTab = tabPage2;
                }
                else
                {
                   
                        string strQuery = string.Empty;
                        {
                        SelectTax();
                        strQuery = "insert into PRODUCT(ID,PRODUCTNAME,CATID,TYPE,UNITCOST,BARCODE,UNITPRICE,PACKQTY,SELLQTY,TAX1,TAX2,QTYONHAND,SUPPID,ISTOREID,CREATEDATE) values ('" + txtPId.Text + "','" + txtPName.Text + "','" + CatId + "','" + cmbTyp.Text + "','" + txtUnitCost.Text + "','" + txtBarcode.Text + "','" + txtUnitPrice.Text + "','" + txtPacketQty.Text + "','" + txtSellQty.Text + "','" + TAX_1 + "','" + TAX_2 + "','" + txtQtyOnHand.Text + "','" + SupplId + "','" + txtStoreId.Text + "','" + strDateTime + "')";
                            dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                            
                        ClearValue();
                    }

                }
              //  ClearValue();
            }

            catch (Exception ex)
            {
                AgroFUN.SystemLog("Save:" + ex.Message.ToString());
            }
        }
        public void ClearValue()
        {
            txtPId.Text = "";
            txtPName.Text = "";
            cmbCatId.Text = "";
            cmbTyp.Text = "";
            txtUnitCost.Text = "";
            txtPacketQty.Text = "";
            txtBarcode.Text = "";
            txtUnitPrice.Text = "";
            txtSellQty.Text = "";
            tax1.Checked = false;
            tax2.Checked = false;
            //txtTax1.Text = "";
            //txtTax2.Text = "";
            txtQtyOnHand.Text = "";
            cmbSupplId.Text = "";
            txtStoreId.Text = "";
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Are you Sure you want to Update the Product Details?", "Agro", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    {
                        string insQuery = string.Empty;
                        string strQuery = string.Empty;
                        {
                            SelectTax();
                            strQuery = "update PRODUCT set PRODUCTNAME='" + txtPName.Text + "',CATID='" + CatId + "',TYPE='" + cmbTyp.Text + "',UNITCOST='" + txtUnitCost.Text + "',BARCODE='" + txtBarcode.Text + "',UNITPRICE='" + txtBarcode.Text + "',PACKQTY='" + txtPacketQty.Text + "',SELLQTY='" + txtSellQty.Text + "',TAX1='" + TAX_1 + "',TAX2='" + TAX_2 + "',QTYONHAND='" + txtQtyOnHand.Text + "',SUPPID='" + SupplId + "',ISTOREID='" + txtStoreId.Text + "',UPDATEDATE='" + strDateTime + "' where ID='" + txtPId.Text + "'  ";
                            dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                            
                            
                            ClearValue();
                        }
                    }
                }
            }
                

            catch (Exception ex)
            {
                AgroFUN.SystemLog("Save:" + ex.Message.ToString());
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

            string strQuery = string.Empty;
            string strCat = txtPId.Text;

            if (strCat.Length == 0)
            {
                MessageBox.Show("Please Enter the product ID to delete the product ");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Are you Sure you want to delete Product Details?", "Agro", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                {
                    strQuery = "DELETE FROM PRODUCT  where ID=" + txtPId.Text;
                    dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                }
            }
            ClearValue();
        }
      

        private void txtItemPackId_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbCatId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string txtCatId = cmbCatId.SelectedValue.ToString();
                CatId = Convert.ToInt32(txtCatId);
            }
            catch (Exception ex)
            {
                AgroFUN.SystemLog("CAT LOAD ERR" + ex.Message);
            }

        }

        private void txtPId_TextChanged(object sender, EventArgs e)
        {
          

        }

        
        public void SelectTax()
        {
          
            if(tax1.Checked==true )
            {
                string tx1 = "TAX1";
                string strquery="select RATE from STORETAX where TAXTYPE='"+tx1+"'";
                DataTable dt = dLib.ExecuteDatTable(AgroFUN.gblConnString, strquery);
                DataRow dr = dt.Rows[0];
                string stx1 = dr["RATE"].ToString();
                TAX_1 = Convert.ToInt32(stx1);
            }
            if (tax2.Checked == true)
            {
                string tx2 = "TAX2";
                string strquery = "select RATE from STORETAX where TAXTYPE='" + tx2 + "'";
                DataTable dt = dLib.ExecuteDatTable(AgroFUN.gblConnString, strquery);
                DataRow dr = dt.Rows[0];
                string stx2 = dr["RATE"].ToString();
                TAX_2 = Convert.ToInt32(stx2);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void ProductAddValidate()
        {

            string pid = txtPId.Text;
            string pname = txtPName.Text;
            string catid = cmbCatId.Text;
            string type = cmbTyp.Text;
            string ucost = txtUnitCost.Text;
            string barcode = txtBarcode.Text;
            string uprice = txtUnitPrice.Text;
            string pqty = txtPacketQty.Text;
            string sqty = txtSellQty.Text;
            string tax1 = TAX_1.ToString();
            string tax2 = TAX_2.ToString();
            string qtyonhand = txtQtyOnHand.Text;
            string storeid = txtStoreId.Text;


            if (string.IsNullOrEmpty(storeid))
            {
                MessageBox.Show("Please enter STOREID");
            }
            if (string.IsNullOrEmpty(qtyonhand))
            {
                MessageBox.Show("Please enter QUANTITY ON HAND");
            }
            //if (string.IsNullOrEmpty(tax2))
            //{
            //    MessageBox.Show("Please Select TAX");
            //}
            //if (string.IsNullOrEmpty(tax1))
            //{
            //    MessageBox.Show("Please Select TAX");
            //}
            if (string.IsNullOrEmpty(sqty))
            {
                MessageBox.Show("Please enter SELL QUANTITY");
            }
            if (string.IsNullOrEmpty(pqty))
            {
                MessageBox.Show("Please enter PACKET QUANTITY");
            }
            if (string.IsNullOrEmpty(uprice))
            {
                MessageBox.Show("Please enter UNIT PRICE");
            }
            if (string.IsNullOrEmpty(barcode))
            {
                MessageBox.Show("Please enter BARCODE");
            }
            if (string.IsNullOrEmpty(ucost))
            {
                MessageBox.Show("Please enter UNIT COST");
            }
            if (string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Please Select TYPE");
            }
            if (string.IsNullOrEmpty(catid))
            {
                MessageBox.Show("Please Select CATEGORYID");
            }
            if (string.IsNullOrEmpty(pid))
            {
                MessageBox.Show("Please enter PRODUCTID");
            }
            if (string.IsNullOrEmpty(pname))
            {
                MessageBox.Show("Please enter PRODUCT NAME");
            }
        }

        private void cmbSupplId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string txtSupplId = cmbSupplId.SelectedValue.ToString();
                SupplId = Convert.ToInt32(txtSupplId);
            }
           
                 catch (Exception ex)
            {
                AgroFUN.SystemLog("CAT LOAD ERR" + ex.Message);
            }
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddItem_Click_1(object sender, EventArgs e)
        {
            string strQuery = string.Empty;
            {
                strQuery = "INSERT INTO ITEMPACKDETAIL (ID, ITEMID, BARCODE, PACK, PACKNAME, PACKPRICE, UNITCOST, PARENTID, SEQUENCES) VALUES('" + txtItemPackId.Text + "','" + txtPId.Text + "','" + txtBarcode.Text + "','" + txtPacketQty.Text + "','" + txtPackName.Text + "','" + txtPackPrice.Text + "','" + txtUnitCost.Text + "',1,0)";
                //  strQuery = "INSERT INTO ITEMPACKDETAIL(ID,ITEMID) VALUES('"+txtItemPackId.Text+"','"+txtPId.Text+"')";
                dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                txtItemPackId.Text = "";
                txtPacketQty.Text = "";
                txtPackName.Text = "";
                txtPackPrice.Text = "";
                LoadGrid();
                LoadPackGrid();

            }

            tabControl1.SelectedTab = tabPage1;

            ClearValue();
        }

        private void txtPId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
           // LoadGrid();
        }

        private void tax2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtUnitCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPacketQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtSellQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtQtyOnHand_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtStoreId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtItemPackId_TextChanged_1(object sender, EventArgs e)
        {
           // KeyValidationMethod();
        }

        private void txtPackQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItemPackId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPackQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPackPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void datagrdItemPack_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void ComboBoxLoad()
        {
            string strquery = "select ID,CATNAME from CATEGORY";
            DataTable dt = dLib.ExecuteDatTable(AgroFUN.gblConnString, strquery);
            //DataRow dr = dt.Rows[0];
            cmbCatId.DataSource = dt;
            cmbCatId.DisplayMember = "CATNAME";
            cmbCatId.ValueMember = "ID";
            
            string strqueryy = "select ID,COMPNAME from SUPPLIER";
            DataTable dtt= dLib.ExecuteDatTable(AgroFUN.gblConnString, strqueryy);
            cmbSupplId.DataSource = dtt;
            cmbSupplId.DisplayMember = "COMPNAME";
            cmbSupplId.ValueMember = "ID";
            
        }

        public void KeyValidationMethod()
        {
          //  e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
    }


