namespace AgroChemical
{
    partial class frmproduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTyp = new System.Windows.Forms.ComboBox();
            this.txtPId = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtPacketQty = new System.Windows.Forms.TextBox();
            this.txtUnitCost = new System.Windows.Forms.TextBox();
            this.txtQtyOnHand = new System.Windows.Forms.TextBox();
            this.txtTax2 = new System.Windows.Forms.TextBox();
            this.txtTax1 = new System.Windows.Forms.TextBox();
            this.txtSellQty = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtStoreId = new System.Windows.Forms.TextBox();
            this.cmbCatId = new System.Windows.Forms.ComboBox();
            this.cmbSupplId = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(3, 942);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2420, 582);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.cmbSupplId);
            this.groupBox2.Controls.Add(this.cmbCatId);
            this.groupBox2.Controls.Add(this.txtStoreId);
            this.groupBox2.Controls.Add(this.txtUnitPrice);
            this.groupBox2.Controls.Add(this.txtBarcode);
            this.groupBox2.Controls.Add(this.cmbTyp);
            this.groupBox2.Controls.Add(this.txtSellQty);
            this.groupBox2.Controls.Add(this.txtTax1);
            this.groupBox2.Controls.Add(this.txtTax2);
            this.groupBox2.Controls.Add(this.txtQtyOnHand);
            this.groupBox2.Controls.Add(this.txtUnitCost);
            this.groupBox2.Controls.Add(this.txtPacketQty);
            this.groupBox2.Controls.Add(this.txtPName);
            this.groupBox2.Controls.Add(this.txtPId);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Location = new System.Drawing.Point(3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(2420, 946);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cmbTyp
            // 
            this.cmbTyp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTyp.FormattingEnabled = true;
            this.cmbTyp.Items.AddRange(new object[] {
            "Fertilisers",
            "Pesticides",
            "Seeds"});
            this.cmbTyp.Location = new System.Drawing.Point(431, 381);
            this.cmbTyp.Name = "cmbTyp";
            this.cmbTyp.Size = new System.Drawing.Size(630, 62);
            this.cmbTyp.TabIndex = 10;
            this.cmbTyp.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtPId
            // 
            this.txtPId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPId.Location = new System.Drawing.Point(431, 60);
            this.txtPId.Name = "txtPId";
            this.txtPId.Size = new System.Drawing.Size(630, 61);
            this.txtPId.TabIndex = 0;
            this.txtPId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPName
            // 
            this.txtPName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.Location = new System.Drawing.Point(431, 167);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(630, 61);
            this.txtPName.TabIndex = 1;
            this.txtPName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPacketQty
            // 
            this.txtPacketQty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPacketQty.Location = new System.Drawing.Point(1724, 60);
            this.txtPacketQty.Name = "txtPacketQty";
            this.txtPacketQty.Size = new System.Drawing.Size(630, 61);
            this.txtPacketQty.TabIndex = 3;
            this.txtPacketQty.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitCost.Location = new System.Drawing.Point(431, 489);
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.Size = new System.Drawing.Size(630, 61);
            this.txtUnitCost.TabIndex = 4;
            this.txtUnitCost.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtQtyOnHand
            // 
            this.txtQtyOnHand.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtyOnHand.Location = new System.Drawing.Point(1724, 489);
            this.txtQtyOnHand.Name = "txtQtyOnHand";
            this.txtQtyOnHand.Size = new System.Drawing.Size(630, 61);
            this.txtQtyOnHand.TabIndex = 6;
            this.txtQtyOnHand.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // txtTax2
            // 
            this.txtTax2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax2.Location = new System.Drawing.Point(1724, 381);
            this.txtTax2.Name = "txtTax2";
            this.txtTax2.Size = new System.Drawing.Size(630, 61);
            this.txtTax2.TabIndex = 7;
            this.txtTax2.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtTax1
            // 
            this.txtTax1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTax1.Location = new System.Drawing.Point(1724, 274);
            this.txtTax1.Name = "txtTax1";
            this.txtTax1.Size = new System.Drawing.Size(630, 61);
            this.txtTax1.TabIndex = 8;
            this.txtTax1.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // txtSellQty
            // 
            this.txtSellQty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellQty.Location = new System.Drawing.Point(1724, 167);
            this.txtSellQty.Name = "txtSellQty";
            this.txtSellQty.Size = new System.Drawing.Size(630, 61);
            this.txtSellQty.TabIndex = 9;
            this.txtSellQty.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(431, 596);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(630, 61);
            this.txtBarcode.TabIndex = 11;
            this.txtBarcode.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(431, 703);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(630, 61);
            this.txtUnitPrice.TabIndex = 12;
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // txtStoreId
            // 
            this.txtStoreId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStoreId.Location = new System.Drawing.Point(1724, 703);
            this.txtStoreId.Name = "txtStoreId";
            this.txtStoreId.Size = new System.Drawing.Size(630, 61);
            this.txtStoreId.TabIndex = 13;
            this.txtStoreId.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // cmbCatId
            // 
            this.cmbCatId.FormattingEnabled = true;
            this.cmbCatId.Location = new System.Drawing.Point(431, 274);
            this.cmbCatId.Name = "cmbCatId";
            this.cmbCatId.Size = new System.Drawing.Size(630, 62);
            this.cmbCatId.TabIndex = 14;
            // 
            // cmbSupplId
            // 
            this.cmbSupplId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplId.FormattingEnabled = true;
            this.cmbSupplId.Items.AddRange(new object[] {
            "Fertilisers",
            "Pesticides",
            "Seeds"});
            this.cmbSupplId.Location = new System.Drawing.Point(1724, 595);
            this.cmbSupplId.Name = "cmbSupplId";
            this.cmbSupplId.Size = new System.Drawing.Size(630, 62);
            this.cmbSupplId.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Location = new System.Drawing.Point(549, 813);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(347, 87);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Location = new System.Drawing.Point(1005, 813);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(347, 87);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(1455, 813);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(347, 87);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 54);
            this.label1.TabIndex = 19;
            this.label1.Text = "Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 54);
            this.label2.TabIndex = 20;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 54);
            this.label3.TabIndex = 21;
            this.label3.Text = "Category ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 54);
            this.label4.TabIndex = 22;
            this.label4.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 54);
            this.label5.TabIndex = 23;
            this.label5.Text = "Unit Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 595);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 54);
            this.label6.TabIndex = 24;
            this.label6.Text = "Barcode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(104, 702);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 54);
            this.label7.TabIndex = 25;
            this.label7.Text = "Unit Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1372, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(301, 54);
            this.label8.TabIndex = 26;
            this.label8.Text = "Packet Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1372, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(249, 54);
            this.label9.TabIndex = 27;
            this.label9.Text = "Sell Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1372, 277);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 54);
            this.label10.TabIndex = 28;
            this.label10.Text = "Tax-1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1372, 388);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 54);
            this.label11.TabIndex = 29;
            this.label11.Text = "Tax-2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1318, 492);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(346, 54);
            this.label12.TabIndex = 30;
            this.label12.Text = "Quantity On Hand";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1372, 588);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(220, 54);
            this.label13.TabIndex = 31;
            this.label13.Text = "Supplier ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1372, 693);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 54);
            this.label14.TabIndex = 32;
            this.label14.Text = "Store ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 46;
            this.dataGridView1.Size = new System.Drawing.Size(2390, 406);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2435, 1520);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmproduct";
            this.Text = "frmproduct";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtStoreId;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.ComboBox cmbTyp;
        private System.Windows.Forms.TextBox txtSellQty;
        private System.Windows.Forms.TextBox txtTax1;
        private System.Windows.Forms.TextBox txtTax2;
        private System.Windows.Forms.TextBox txtQtyOnHand;
        private System.Windows.Forms.TextBox txtUnitCost;
        private System.Windows.Forms.TextBox txtPacketQty;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtPId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbSupplId;
        private System.Windows.Forms.ComboBox cmbCatId;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}