namespace AgroChemical
{
    partial class frmProductAdd
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datagrdItemPack = new System.Windows.Forms.DataGridView();
            this.datagrditem = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtItemPackId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtPackPrice = new System.Windows.Forms.TextBox();
            this.txtPackName = new System.Windows.Forms.TextBox();
            this.txtPackQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbTextSelect = new System.Windows.Forms.GroupBox();
            this.tax1 = new System.Windows.Forms.CheckBox();
            this.tax2 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbSupplId = new System.Windows.Forms.ComboBox();
            this.cmbCatId = new System.Windows.Forms.ComboBox();
            this.txtStoreId = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.cmbTyp = new System.Windows.Forms.ComboBox();
            this.txtSellQty = new System.Windows.Forms.TextBox();
            this.txtQtyOnHand = new System.Windows.Forms.TextBox();
            this.txtUnitCost = new System.Windows.Forms.TextBox();
            this.txtPacketQty = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtPId = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdItemPack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrditem)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbTextSelect.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 66);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2547, 1096);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lot Matrix";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.datagrdItemPack);
            this.groupBox1.Controls.Add(this.datagrditem);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2541, 1090);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ITEM PACK DETAILS";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(903, 390);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(220, 54);
            this.label20.TabIndex = 14;
            this.label20.Text = "PACK DATA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(894, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 54);
            this.label1.TabIndex = 13;
            this.label1.Text = "PRODUCT DATA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // datagrdItemPack
            // 
            this.datagrdItemPack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrdItemPack.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagrdItemPack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrdItemPack.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrdItemPack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrdItemPack.Location = new System.Drawing.Point(903, 461);
            this.datagrdItemPack.Name = "datagrdItemPack";
            this.datagrdItemPack.RowTemplate.Height = 46;
            this.datagrdItemPack.Size = new System.Drawing.Size(1568, 626);
            this.datagrdItemPack.TabIndex = 12;
            this.datagrdItemPack.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrdItemPack_CellContentClick);
            // 
            // datagrditem
            // 
            this.datagrditem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagrditem.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagrditem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrditem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrditem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrditem.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagrditem.Location = new System.Drawing.Point(903, 101);
            this.datagrditem.Name = "datagrditem";
            this.datagrditem.RowTemplate.Height = 46;
            this.datagrditem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrditem.Size = new System.Drawing.Size(1568, 262);
            this.datagrditem.TabIndex = 11;
            this.datagrditem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.txtItemPackId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnAddItem);
            this.panel1.Controls.Add(this.txtPackPrice);
            this.panel1.Controls.Add(this.txtPackName);
            this.panel1.Controls.Add(this.txtPackQty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(89, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 796);
            this.panel1.TabIndex = 10;
            // 
            // txtItemPackId
            // 
            this.txtItemPackId.Location = new System.Drawing.Point(303, 47);
            this.txtItemPackId.Name = "txtItemPackId";
            this.txtItemPackId.Size = new System.Drawing.Size(378, 61);
            this.txtItemPackId.TabIndex = 19;
            this.txtItemPackId.TextChanged += new System.EventHandler(this.txtItemPackId_TextChanged_1);
            this.txtItemPackId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemPackId_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 54);
            this.label5.TabIndex = 18;
            this.label5.Text = "Pack ID";
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.Lime;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.Location = new System.Drawing.Point(162, 544);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(395, 97);
            this.btnAddItem.TabIndex = 17;
            this.btnAddItem.Text = "ADD ITEM PACK";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click_1);
            // 
            // txtPackPrice
            // 
            this.txtPackPrice.Location = new System.Drawing.Point(303, 423);
            this.txtPackPrice.Name = "txtPackPrice";
            this.txtPackPrice.Size = new System.Drawing.Size(378, 61);
            this.txtPackPrice.TabIndex = 16;
            this.txtPackPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPackPrice_KeyPress);
            // 
            // txtPackName
            // 
            this.txtPackName.Location = new System.Drawing.Point(303, 298);
            this.txtPackName.Name = "txtPackName";
            this.txtPackName.Size = new System.Drawing.Size(378, 61);
            this.txtPackName.TabIndex = 15;
            // 
            // txtPackQty
            // 
            this.txtPackQty.Location = new System.Drawing.Point(303, 173);
            this.txtPackQty.Name = "txtPackQty";
            this.txtPackQty.Size = new System.Drawing.Size(378, 61);
            this.txtPackQty.TabIndex = 14;
            this.txtPackQty.TextChanged += new System.EventHandler(this.txtPackQty_TextChanged);
            this.txtPackQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPackQty_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 54);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pack Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 54);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pack Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 54);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pack QTY";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 66);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(2547, 1096);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Product";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbTextSelect);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.cmbSupplId);
            this.panel2.Controls.Add(this.cmbCatId);
            this.panel2.Controls.Add(this.txtStoreId);
            this.panel2.Controls.Add(this.txtUnitPrice);
            this.panel2.Controls.Add(this.txtBarcode);
            this.panel2.Controls.Add(this.cmbTyp);
            this.panel2.Controls.Add(this.txtSellQty);
            this.panel2.Controls.Add(this.txtQtyOnHand);
            this.panel2.Controls.Add(this.txtUnitCost);
            this.panel2.Controls.Add(this.txtPacketQty);
            this.panel2.Controls.Add(this.txtPName);
            this.panel2.Controls.Add(this.txtPId);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2541, 1090);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // gbTextSelect
            // 
            this.gbTextSelect.Controls.Add(this.tax1);
            this.gbTextSelect.Controls.Add(this.tax2);
            this.gbTextSelect.ForeColor = System.Drawing.Color.White;
            this.gbTextSelect.Location = new System.Drawing.Point(1730, 263);
            this.gbTextSelect.Name = "gbTextSelect";
            this.gbTextSelect.Size = new System.Drawing.Size(630, 249);
            this.gbTextSelect.TabIndex = 66;
            this.gbTextSelect.TabStop = false;
            this.gbTextSelect.Text = "Tax Select";
            this.gbTextSelect.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tax1
            // 
            this.tax1.AutoSize = true;
            this.tax1.Location = new System.Drawing.Point(94, 72);
            this.tax1.Name = "tax1";
            this.tax1.Size = new System.Drawing.Size(42, 41);
            this.tax1.TabIndex = 64;
            this.tax1.UseVisualStyleBackColor = true;
            this.tax1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tax2
            // 
            this.tax2.AutoSize = true;
            this.tax2.Location = new System.Drawing.Point(94, 167);
            this.tax2.Name = "tax2";
            this.tax2.Size = new System.Drawing.Size(42, 41);
            this.tax2.TabIndex = 65;
            this.tax2.UseVisualStyleBackColor = true;
            this.tax2.CheckedChanged += new System.EventHandler(this.tax2_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(1378, 722);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 54);
            this.label14.TabIndex = 63;
            this.label14.Text = "Store ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(1378, 617);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(220, 54);
            this.label13.TabIndex = 62;
            this.label13.Text = "Supplier ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1324, 521);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(346, 54);
            this.label12.TabIndex = 61;
            this.label12.Text = "Quantity On Hand";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1378, 417);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 54);
            this.label11.TabIndex = 59;
            this.label11.Text = "Tax-2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1378, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 54);
            this.label10.TabIndex = 57;
            this.label10.Text = "Tax-1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1378, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(249, 54);
            this.label9.TabIndex = 55;
            this.label9.Text = "Sell Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1378, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(301, 54);
            this.label8.TabIndex = 53;
            this.label8.Text = "Packet Quantity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(110, 731);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 54);
            this.label7.TabIndex = 60;
            this.label7.Text = "Unit Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(110, 624);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 54);
            this.label6.TabIndex = 58;
            this.label6.Text = "Barcode";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(110, 517);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(187, 54);
            this.label15.TabIndex = 56;
            this.label15.Text = "Unit Cost";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(110, 410);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 54);
            this.label16.TabIndex = 54;
            this.label16.Text = "Type";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(101, 303);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(233, 54);
            this.label17.TabIndex = 52;
            this.label17.Text = "Category ID";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(110, 196);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(277, 54);
            this.label18.TabIndex = 51;
            this.label18.Text = "Product Name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(110, 89);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(211, 54);
            this.label19.TabIndex = 50;
            this.label19.Text = "Product ID";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(1461, 842);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(347, 87);
            this.btnDelete.TabIndex = 47;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(1011, 842);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(347, 87);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(555, 842);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(347, 87);
            this.btnAdd.TabIndex = 49;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // cmbSupplId
            // 
            this.cmbSupplId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplId.FormattingEnabled = true;
            this.cmbSupplId.Items.AddRange(new object[] {
            "Fertilisers",
            "Pesticides",
            "Seeds"});
            this.cmbSupplId.Location = new System.Drawing.Point(1730, 624);
            this.cmbSupplId.Name = "cmbSupplId";
            this.cmbSupplId.Size = new System.Drawing.Size(630, 62);
            this.cmbSupplId.TabIndex = 45;
            this.cmbSupplId.SelectedIndexChanged += new System.EventHandler(this.cmbSupplId_SelectedIndexChanged);
            // 
            // cmbCatId
            // 
            this.cmbCatId.FormattingEnabled = true;
            this.cmbCatId.Items.AddRange(new object[] {
            "Fertilzers",
            "Pesticides",
            "Seeds"});
            this.cmbCatId.Location = new System.Drawing.Point(437, 303);
            this.cmbCatId.Name = "cmbCatId";
            this.cmbCatId.Size = new System.Drawing.Size(630, 62);
            this.cmbCatId.TabIndex = 35;
            this.cmbCatId.SelectedIndexChanged += new System.EventHandler(this.cmbCatId_SelectedIndexChanged);
            // 
            // txtStoreId
            // 
            this.txtStoreId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStoreId.Location = new System.Drawing.Point(1730, 732);
            this.txtStoreId.Name = "txtStoreId";
            this.txtStoreId.Size = new System.Drawing.Size(630, 61);
            this.txtStoreId.TabIndex = 46;
            this.txtStoreId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStoreId_KeyPress);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.Location = new System.Drawing.Point(437, 732);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(630, 61);
            this.txtUnitPrice.TabIndex = 39;
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            // 
            // txtBarcode
            // 
            this.txtBarcode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarcode.Location = new System.Drawing.Point(437, 625);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(630, 61);
            this.txtBarcode.TabIndex = 38;
            this.txtBarcode.TextChanged += new System.EventHandler(this.txtBarcode_TextChanged);
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // cmbTyp
            // 
            this.cmbTyp.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTyp.FormattingEnabled = true;
            this.cmbTyp.Items.AddRange(new object[] {
            "Standard",
            "Lot Matrix"});
            this.cmbTyp.Location = new System.Drawing.Point(437, 410);
            this.cmbTyp.Name = "cmbTyp";
            this.cmbTyp.Size = new System.Drawing.Size(630, 62);
            this.cmbTyp.TabIndex = 36;
            // 
            // txtSellQty
            // 
            this.txtSellQty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellQty.Location = new System.Drawing.Point(1730, 196);
            this.txtSellQty.Name = "txtSellQty";
            this.txtSellQty.Size = new System.Drawing.Size(630, 61);
            this.txtSellQty.TabIndex = 41;
            this.txtSellQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSellQty_KeyPress);
            // 
            // txtQtyOnHand
            // 
            this.txtQtyOnHand.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtyOnHand.Location = new System.Drawing.Point(1730, 518);
            this.txtQtyOnHand.Name = "txtQtyOnHand";
            this.txtQtyOnHand.Size = new System.Drawing.Size(630, 61);
            this.txtQtyOnHand.TabIndex = 44;
            this.txtQtyOnHand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtyOnHand_KeyPress);
            // 
            // txtUnitCost
            // 
            this.txtUnitCost.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitCost.Location = new System.Drawing.Point(437, 518);
            this.txtUnitCost.Name = "txtUnitCost";
            this.txtUnitCost.Size = new System.Drawing.Size(630, 61);
            this.txtUnitCost.TabIndex = 37;
            this.txtUnitCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitCost_KeyPress);
            // 
            // txtPacketQty
            // 
            this.txtPacketQty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPacketQty.Location = new System.Drawing.Point(1730, 89);
            this.txtPacketQty.Name = "txtPacketQty";
            this.txtPacketQty.Size = new System.Drawing.Size(630, 61);
            this.txtPacketQty.TabIndex = 40;
            this.txtPacketQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPacketQty_KeyPress);
            // 
            // txtPName
            // 
            this.txtPName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPName.Location = new System.Drawing.Point(437, 196);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(630, 61);
            this.txtPName.TabIndex = 34;
            // 
            // txtPId
            // 
            this.txtPId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPId.Location = new System.Drawing.Point(437, 89);
            this.txtPId.Name = "txtPId";
            this.txtPId.Size = new System.Drawing.Size(630, 61);
            this.txtPId.TabIndex = 33;
            this.txtPId.TextChanged += new System.EventHandler(this.txtPId_TextChanged);
            this.txtPId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPId_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2555, 1166);
            this.tabControl1.TabIndex = 0;
            // 
            // frmProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2555, 1166);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProductAdd";
            this.Text = "frmProductAdd";
            this.Load += new System.EventHandler(this.frmProductAdd_Load);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrdItemPack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagrditem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbTextSelect.ResumeLayout(false);
            this.gbTextSelect.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.ComboBox cmbCatId;
        public System.Windows.Forms.TextBox txtUnitPrice;
        public System.Windows.Forms.TextBox txtBarcode;
        public System.Windows.Forms.ComboBox cmbTyp;
        public System.Windows.Forms.TextBox txtUnitCost;
        public System.Windows.Forms.TextBox txtPName;
        public System.Windows.Forms.TextBox txtPId;
        public System.Windows.Forms.ComboBox cmbSupplId;
        public System.Windows.Forms.TextBox txtStoreId;
        public System.Windows.Forms.TextBox txtSellQty;
        public System.Windows.Forms.TextBox txtQtyOnHand;
        public System.Windows.Forms.TextBox txtPacketQty;
        public System.Windows.Forms.CheckBox tax1;
        public System.Windows.Forms.CheckBox tax2;
        private System.Windows.Forms.GroupBox gbTextSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtItemPackId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtPackPrice;
        private System.Windows.Forms.TextBox txtPackName;
        private System.Windows.Forms.TextBox txtPackQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView datagrditem;
        private System.Windows.Forms.DataGridView datagrdItemPack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
    }
}