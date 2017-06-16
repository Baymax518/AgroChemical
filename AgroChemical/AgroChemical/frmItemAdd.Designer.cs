namespace AgroChemical
{
    partial class frmItemAdd
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtPackPrice = new System.Windows.Forms.TextBox();
            this.txtPackName = new System.Windows.Forms.TextBox();
            this.txtPackQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.txtItemPackId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtItemPackId);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnAddItem);
            this.panel1.Controls.Add(this.txtPackPrice);
            this.panel1.Controls.Add(this.txtPackName);
            this.panel1.Controls.Add(this.txtPackQty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtItemId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 764);
            this.panel1.TabIndex = 9;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.Lime;
            this.btnAddItem.Location = new System.Drawing.Point(158, 630);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(395, 97);
            this.btnAddItem.TabIndex = 17;
            this.btnAddItem.Text = "ADD ITEM PACK";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtPackPrice
            // 
            this.txtPackPrice.Location = new System.Drawing.Point(299, 509);
            this.txtPackPrice.Name = "txtPackPrice";
            this.txtPackPrice.Size = new System.Drawing.Size(378, 61);
            this.txtPackPrice.TabIndex = 16;
            // 
            // txtPackName
            // 
            this.txtPackName.Location = new System.Drawing.Point(299, 384);
            this.txtPackName.Name = "txtPackName";
            this.txtPackName.Size = new System.Drawing.Size(378, 61);
            this.txtPackName.TabIndex = 15;
            // 
            // txtPackQty
            // 
            this.txtPackQty.Location = new System.Drawing.Point(299, 259);
            this.txtPackQty.Name = "txtPackQty";
            this.txtPackQty.Size = new System.Drawing.Size(378, 61);
            this.txtPackQty.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 54);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pack Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 54);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pack Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 54);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pack QTY";
            // 
            // txtItemId
            // 
            this.txtItemId.Location = new System.Drawing.Point(299, 138);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(378, 61);
            this.txtItemId.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 54);
            this.label1.TabIndex = 9;
            this.label1.Text = "Item ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 54);
            this.label5.TabIndex = 18;
            this.label5.Text = "Pack ID";
            // 
            // txtItemPackId
            // 
            this.txtItemPackId.Location = new System.Drawing.Point(299, 19);
            this.txtItemPackId.Name = "txtItemPackId";
            this.txtItemPackId.Size = new System.Drawing.Size(378, 61);
            this.txtItemPackId.TabIndex = 19;
            // 
            // frmItemAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(288F, 288F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(764, 797);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(800, 900);
            this.MinimumSize = new System.Drawing.Size(800, 900);
            this.Name = "frmItemAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmItemAdd";
            this.Load += new System.EventHandler(this.frmItemAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtPackPrice;
        private System.Windows.Forms.TextBox txtPackName;
        private System.Windows.Forms.TextBox txtPackQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItemPackId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}