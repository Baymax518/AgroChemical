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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datagrd = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNITCOST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BARCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNITPRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PACKQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SELLQTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAX1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAX2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTYONHAND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUPPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CREATEDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPDATEDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISTOREID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnaddnew = new System.Windows.Forms.Button();
            this.btnSearchtxt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrd)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.datagrd);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Location = new System.Drawing.Point(3, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(2420, 1254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // datagrd
            // 
            this.datagrd.AllowUserToAddRows = false;
            this.datagrd.AllowUserToDeleteRows = false;
            this.datagrd.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.datagrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagrd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.PNAME,
            this.CATNAME,
            this.TYPE,
            this.UNITCOST,
            this.BARCODE,
            this.UNITPRICE,
            this.PACKQTY,
            this.SELLQTY,
            this.TAX1,
            this.TAX2,
            this.QTYONHAND,
            this.SUPPID,
            this.CREATEDATE,
            this.UPDATEDATE,
            this.ISTOREID});
            this.datagrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrd.Location = new System.Drawing.Point(3, 57);
            this.datagrd.MultiSelect = false;
            this.datagrd.Name = "datagrd";
            this.datagrd.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrd.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrd.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.datagrd.RowTemplate.Height = 46;
            this.datagrd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrd.Size = new System.Drawing.Size(2414, 1194);
            this.datagrd.TabIndex = 0;
            this.datagrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrd_CellContentClick);
            this.datagrd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrd_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // PNAME
            // 
            this.PNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PNAME.DataPropertyName = "PRODUCTNAME";
            this.PNAME.HeaderText = "PRODUCT NAME";
            this.PNAME.Name = "PNAME";
            this.PNAME.ReadOnly = true;
            this.PNAME.Width = 353;
            // 
            // CATNAME
            // 
            this.CATNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CATNAME.DataPropertyName = "CATNAME";
            this.CATNAME.HeaderText = "CATEGORY NAME";
            this.CATNAME.Name = "CATNAME";
            this.CATNAME.ReadOnly = true;
            this.CATNAME.Width = 80;
            // 
            // TYPE
            // 
            this.TYPE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TYPE.DataPropertyName = "TYPE";
            this.TYPE.HeaderText = "PRODUCT TYPE";
            this.TYPE.Name = "TYPE";
            this.TYPE.ReadOnly = true;
            this.TYPE.Width = 75;
            // 
            // UNITCOST
            // 
            this.UNITCOST.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UNITCOST.DataPropertyName = "UNITCOST";
            this.UNITCOST.HeaderText = "UNIT COST";
            this.UNITCOST.Name = "UNITCOST";
            this.UNITCOST.ReadOnly = true;
            this.UNITCOST.Width = 70;
            // 
            // BARCODE
            // 
            this.BARCODE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BARCODE.DataPropertyName = "BARCODE";
            this.BARCODE.HeaderText = "BARCODE";
            this.BARCODE.Name = "BARCODE";
            this.BARCODE.ReadOnly = true;
            this.BARCODE.Width = 260;
            // 
            // UNITPRICE
            // 
            this.UNITPRICE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UNITPRICE.DataPropertyName = "UNITPRICE";
            this.UNITPRICE.HeaderText = "UNIT PRICE";
            this.UNITPRICE.Name = "UNITPRICE";
            this.UNITPRICE.ReadOnly = true;
            this.UNITPRICE.Width = 70;
            // 
            // PACKQTY
            // 
            this.PACKQTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PACKQTY.DataPropertyName = "PACKQTY";
            this.PACKQTY.HeaderText = "PACKET QUANTITY";
            this.PACKQTY.Name = "PACKQTY";
            this.PACKQTY.ReadOnly = true;
            this.PACKQTY.Width = 80;
            // 
            // SELLQTY
            // 
            this.SELLQTY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SELLQTY.DataPropertyName = "SELLQTY";
            this.SELLQTY.HeaderText = "SELL QUANTITY";
            this.SELLQTY.Name = "SELLQTY";
            this.SELLQTY.ReadOnly = true;
            this.SELLQTY.Width = 80;
            // 
            // TAX1
            // 
            this.TAX1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TAX1.DataPropertyName = "TAX1";
            this.TAX1.HeaderText = "TAX1";
            this.TAX1.Name = "TAX1";
            this.TAX1.ReadOnly = true;
            this.TAX1.Width = 50;
            // 
            // TAX2
            // 
            this.TAX2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TAX2.DataPropertyName = "TAX2";
            this.TAX2.HeaderText = "TAX2";
            this.TAX2.Name = "TAX2";
            this.TAX2.ReadOnly = true;
            this.TAX2.Width = 50;
            // 
            // QTYONHAND
            // 
            this.QTYONHAND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.QTYONHAND.DataPropertyName = "QTYONHAND";
            this.QTYONHAND.HeaderText = "QUANTITY ON HAND";
            this.QTYONHAND.Name = "QTYONHAND";
            this.QTYONHAND.ReadOnly = true;
            this.QTYONHAND.Width = 80;
            // 
            // SUPPID
            // 
            this.SUPPID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SUPPID.DataPropertyName = "SUPPID";
            this.SUPPID.HeaderText = "SUPPLIER ID";
            this.SUPPID.Name = "SUPPID";
            this.SUPPID.ReadOnly = true;
            this.SUPPID.Width = 70;
            // 
            // CREATEDATE
            // 
            this.CREATEDATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CREATEDATE.DataPropertyName = "CREATEDATE";
            this.CREATEDATE.HeaderText = "CREATE DATE";
            this.CREATEDATE.Name = "CREATEDATE";
            this.CREATEDATE.ReadOnly = true;
            this.CREATEDATE.Width = 90;
            // 
            // UPDATEDATE
            // 
            this.UPDATEDATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UPDATEDATE.DataPropertyName = "UPDATEDATE";
            this.UPDATEDATE.HeaderText = "UPDATE DATE";
            this.UPDATEDATE.Name = "UPDATEDATE";
            this.UPDATEDATE.ReadOnly = true;
            this.UPDATEDATE.Width = 90;
            // 
            // ISTOREID
            // 
            this.ISTOREID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ISTOREID.DataPropertyName = "ISTOREID";
            this.ISTOREID.HeaderText = "STORE ID";
            this.ISTOREID.Name = "ISTOREID";
            this.ISTOREID.ReadOnly = true;
            this.ISTOREID.Width = 50;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnaddnew);
            this.panel1.Controls.Add(this.btnSearchtxt);
            this.panel1.Location = new System.Drawing.Point(-9, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2272, 250);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(32, 84);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(760, 61);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // btnaddnew
            // 
            this.btnaddnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnaddnew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddnew.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnaddnew.Location = new System.Drawing.Point(1633, 53);
            this.btnaddnew.Name = "btnaddnew";
            this.btnaddnew.Size = new System.Drawing.Size(533, 145);
            this.btnaddnew.TabIndex = 7;
            this.btnaddnew.Text = "ADD NEW \r\nPRODUCT";
            this.btnaddnew.UseVisualStyleBackColor = false;
            this.btnaddnew.Click += new System.EventHandler(this.btnaddnew_Click);
            // 
            // btnSearchtxt
            // 
            this.btnSearchtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearchtxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSearchtxt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchtxt.Location = new System.Drawing.Point(958, 53);
            this.btnSearchtxt.Name = "btnSearchtxt";
            this.btnSearchtxt.Size = new System.Drawing.Size(533, 145);
            this.btnSearchtxt.TabIndex = 6;
            this.btnSearchtxt.Text = "SEARCH \r\nPRODUCT";
            this.btnSearchtxt.UseVisualStyleBackColor = false;
            this.btnSearchtxt.Click += new System.EventHandler(this.btnSearchtxt_Click);
            // 
            // frmproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2435, 1520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmproduct";
            this.Text = "frmproduct";
            this.Load += new System.EventHandler(this.frmproduct_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView datagrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNITCOST;
        private System.Windows.Forms.DataGridViewTextBoxColumn BARCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UNITPRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PACKQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn SELLQTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTYONHAND;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUPPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CREATEDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPDATEDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISTOREID;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnaddnew;
        private System.Windows.Forms.Button btnSearchtxt;
    }
}