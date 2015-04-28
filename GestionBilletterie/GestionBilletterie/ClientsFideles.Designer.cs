namespace GestionBilletterie
{
    partial class ClientsFideles
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
            this.DGV_Fideles = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Fideles)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Fideles
            // 
            this.DGV_Fideles.AllowUserToAddRows = false;
            this.DGV_Fideles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Fideles.Location = new System.Drawing.Point(12, 12);
            this.DGV_Fideles.Name = "DGV_Fideles";
            this.DGV_Fideles.ReadOnly = true;
            this.DGV_Fideles.RowHeadersVisible = false;
            this.DGV_Fideles.Size = new System.Drawing.Size(260, 238);
            this.DGV_Fideles.TabIndex = 0;
            // 
            // ClientsFideles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.DGV_Fideles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClientsFideles";
            this.Text = "ClientsFideles";
            this.Load += new System.EventHandler(this.ClientsFideles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Fideles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Fideles;
    }
}