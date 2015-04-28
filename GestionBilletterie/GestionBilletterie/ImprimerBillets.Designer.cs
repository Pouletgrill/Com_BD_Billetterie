namespace GestionBilletterie
{
    partial class ImprimerBillets
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
            this.DGV_Billets = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Billets)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Billets
            // 
            this.DGV_Billets.AllowUserToAddRows = false;
            this.DGV_Billets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Billets.Location = new System.Drawing.Point(12, 12);
            this.DGV_Billets.Name = "DGV_Billets";
            this.DGV_Billets.ReadOnly = true;
            this.DGV_Billets.RowHeadersVisible = false;
            this.DGV_Billets.Size = new System.Drawing.Size(1042, 238);
            this.DGV_Billets.TabIndex = 0;
            // 
            // ImprimerBillets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 262);
            this.Controls.Add(this.DGV_Billets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ImprimerBillets";
            this.Text = "ImprimerBillets";
            this.Load += new System.EventHandler(this.ImprimerBillets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Billets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Billets;
    }
}