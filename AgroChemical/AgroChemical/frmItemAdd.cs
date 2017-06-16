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
    public partial class frmItemAdd : Form
    {
        DataLib dLib = new DataLib();

        public frmItemAdd()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmItemAdd_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
               
                    string strQuery = string.Empty;
                    {
              //          strQuery = "insert into product(ID,ITEMID,BARCODE,PACK,PACKNAME,PACKPRICE,UNITCOST,PARENTID,SEQUENCES) values ('" + txtItemPackId.Text + "','" + txtItemId.Text + "','" +barcode +"','" + txtPackQty.Text + "','" + txtPackName.Text + "','" + txtPackPrice.Text + "','"+ UNITCOST"','" + PARENTID + "','" + SEQUENCES + "')";

                        dLib.ExecuteNonQuery(AgroFUN.gblConnString, strQuery);
                        
                    }
                
                
            }

            catch (Exception ex)
            {
                AgroFUN.SystemLog("Save:" + ex.Message.ToString());
            }
        }
    }
}
