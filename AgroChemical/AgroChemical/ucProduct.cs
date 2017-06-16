using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgroChemical
{


    // frmProductAdd otherform = new frmProductAdd();
    public partial class ucProduct : UserControl
    {

        int PRODUCTID = 0;
        string strDateTime = DateTime.Now.Date.ToString("MM") + "-" + DateTime.Now.Date.ToString("dd") + "-" + DateTime.Now.Date.Year.ToString();
        DataLib dLib = new DataLib();
        public ucProduct()
        {
            InitializeComponent();
            LoadGrid();
        }
        private void LoadGrid()
        {
            try
            {
                string strLoad = string.Empty;
                strLoad = "SELECT P.ID,P.PRODUCTNAME,C.CATNAME,P.TYPE,P.UNITCOST,P.BARCODE,P.UNITPRICE,P.PACKQTY,P.SELLQTY,P.TAX1,P.TAX2,P.QTYONHAND,P.SUPPID,P.ISTOREID,P.CREATEDATE,P.UPDATEDATE FROM PRODUCT AS P LEFT JOIN CATEGORY AS C ON P.CATID = C.ID";


                DataTable dt = dLib.ExecuteDatTable(AgroFUN.gblConnString, strLoad);
               // datagrd.DataSource = dt;
            }
            catch (Exception ex)
            {
                AgroFUN.SystemLog("CAT LOAD ERR" + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTyp.Text == "Lot Matrix")
                {
                    frmItemAdd FRMUNIT=new frmItemAdd();
                    FRMUNIT.Show();
                }
                else
                {
                    if (PRODUCTID == 0)
                    {
                        string strQuery = string.Empty;
                        {
                            strQuery = "insert into product(ID,PRODUCTNAME,CATID,TYPE,UNITCOST,BARCODE,UNITPRICE,PACKQTY,SELLQTY,TAX1,TAX2,QTYONHAND,SUPPID,ISTOREID,CREATEDATE) values ('" + txtPId.Text + "','" + txtPName.Text + "','" + cmbCatId.Text + "','" + cmbTyp.Text + "','" + txtUnitCost.Text + "','" + txtBarcode.Text + "','" + txtUnitPrice.Text + "','" + txtPacketQty.Text + "','" + txtSellQty.Text + "','" + txtTax1.Text + "','" + txtTax2.Text + "','" + txtQtyOnHand.Text + "','" + cmbSupplId.Text + "','" + txtStoreId.Text + "','" + strDateTime + "')";

                            dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                            LoadGrid();
                        }
                    }
                }
                ClearValue();
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
            txtTax1.Text = "";
            txtTax2.Text = "";
            txtQtyOnHand.Text = "";
            cmbSupplId.Text = "";
            txtStoreId.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
                            strQuery = "update PRODUCT set PRODUCTNAME='" + txtPName.Text + "',CATID='" + cmbCatId.Text + "',TYPE='" + cmbTyp.Text + "',UNITCOST='" + txtUnitCost.Text + "',BARCODE='" + txtBarcode.Text + "',UNITPRICE='" + txtBarcode.Text + "',PACKQTY='" + txtPacketQty.Text + "',SELLQTY='" + txtSellQty.Text + "',TAX1='" + txtTax1.Text + "',TAX2='" + txtTax2.Text + "',QTYONHAND='" + txtQtyOnHand.Text + "',SUPPID='" + cmbSupplId.Text + "',ISTOREID='" + txtStoreId.Text + "',UPDATEDATE='" + strDateTime + "' where ID='" + txtPId.Text + "'  ";
                            dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                            LoadGrid();
                        }
                    }
                }
                ClearValue();
            }

            catch (Exception ex)
            {
                AgroFUN.SystemLog("Save:" + ex.Message.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
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

        private void ucProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {


            frmproduct FRMUNIT = new frmproduct();
     //       FRMUNIT.MdiParent = this.MdiParent;
            FRMUNIT.Dock = DockStyle.Fill;
            FRMUNIT.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtPName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbSupplId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbCatId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtStoreId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTyp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSellQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTax1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTax2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQtyOnHand_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUnitCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPacketQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPId_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtPName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtPacketQty_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtUnitCost_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtQtyOnHand_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtTax2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtTax1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtSellQty_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cmbTyp_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtBarcode_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtUnitPrice_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtStoreId_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cmbCatId_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cmbSupplId_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }
    }
    }
    
