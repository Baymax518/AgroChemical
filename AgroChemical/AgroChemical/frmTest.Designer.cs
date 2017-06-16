namespace AgroChemical
{
    partial class frmTest
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
            this.ucProduct1 = new AgroChemical.ucProduct();
            this.SuspendLayout();
            // 
            // ucProduct1
            // 
            this.ucProduct1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ucProduct1.Location = new System.Drawing.Point(12, 21);
            this.ucProduct1.Name = "ucProduct1";
            this.ucProduct1.Size = new System.Drawing.Size(2450, 950);
            this.ucProduct1.TabIndex = 0;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2310, 1153);
            this.Controls.Add(this.ucProduct1);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.ResumeLayout(false);

        }

        #endregion

        private ucProduct ucProduct1;
    }
}