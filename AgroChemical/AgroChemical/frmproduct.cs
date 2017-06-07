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
        int PRODUCTID = 0;
        string strDateTime = DateTime.Now.Date.ToString("MM") + "-" + DateTime.Now.Date.ToString("dd") + "-" + DateTime.Now.Date.Year.ToString();
        DataLib dLib = new DataLib();
        public frmproduct()
        {
            InitializeComponent();
            // MessageBox.Show(strDateTime + "todays date");
            //LoadGrid();

        }
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (PRODUCTID == 0)
                {
                    string strQuery = string.Empty;
                    {
                        strQuery = "insert into product(ID,PRODUCTNAME,CATID,TYPE,UNITCOST,BARCODE,UNITPRICE,PACKQTY,SELLQTY,TAX1,TAX2,QTYONHAND,SUPPID,ISTOREID,CREATEDATE) values ('" + txtPId.Text + "','" + txtPName.Text + "','" + cmbCatId.Text + "','" + cmbTyp.Text + "','" + txtUnitCost.Text + "','" + txtBarcode.Text + "','" + txtUnitPrice.Text + "','" + txtPacketQty.Text + "','" + txtSellQty.Text + "','" + txtTax1.Text + "','" + txtTax2.Text + "','" + txtQtyOnHand.Text + "','" + cmbSupplId.Text + "','" + txtStoreId.Text + "','" + strDateTime + "')";
                          
                        dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                      //  LoadGrid();
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
                          //  LoadGrid();
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

    } 
    }

