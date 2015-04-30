namespace GestionBilletterie
{
    partial class AjouterModifierSpectacle
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
            this.CB_Categorie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Titre = new System.Windows.Forms.TextBox();
            this.TB_Artiste = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Parcourir = new System.Windows.Forms.Button();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.PN_Poster = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // CB_Categorie
            // 
            this.CB_Categorie.FormattingEnabled = true;
            this.CB_Categorie.Location = new System.Drawing.Point(76, 6);
            this.CB_Categorie.Name = "CB_Categorie";
            this.CB_Categorie.Size = new System.Drawing.Size(121, 21);
            this.CB_Categorie.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Catégorie :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Titre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Artiste :";
            // 
            // TB_Titre
            // 
            this.TB_Titre.Location = new System.Drawing.Point(76, 33);
            this.TB_Titre.Name = "TB_Titre";
            this.TB_Titre.Size = new System.Drawing.Size(121, 20);
            this.TB_Titre.TabIndex = 4;
            // 
            // TB_Artiste
            // 
            this.TB_Artiste.Location = new System.Drawing.Point(76, 59);
            this.TB_Artiste.Name = "TB_Artiste";
            this.TB_Artiste.Size = new System.Drawing.Size(121, 20);
            this.TB_Artiste.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Affiche :";
            // 
            // BTN_Parcourir
            // 
            this.BTN_Parcourir.Location = new System.Drawing.Point(76, 85);
            this.BTN_Parcourir.Name = "BTN_Parcourir";
            this.BTN_Parcourir.Size = new System.Drawing.Size(121, 23);
            this.BTN_Parcourir.TabIndex = 7;
            this.BTN_Parcourir.Text = "Parcourir";
            this.BTN_Parcourir.UseVisualStyleBackColor = true;
            // 
            // BTN_OK
            // 
            this.BTN_OK.Location = new System.Drawing.Point(117, 119);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(80, 23);
            this.BTN_OK.TabIndex = 8;
            this.BTN_OK.Text = "OK";
            this.BTN_OK.UseVisualStyleBackColor = true;
            this.BTN_OK.Click += new System.EventHandler(this.BTN_OK_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(31, 119);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(80, 23);
            this.BTN_Cancel.TabIndex = 9;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // PN_Poster
            // 
            this.PN_Poster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PN_Poster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PN_Poster.Location = new System.Drawing.Point(203, 6);
            this.PN_Poster.Name = "PN_Poster";
            this.PN_Poster.Size = new System.Drawing.Size(99, 136);
            this.PN_Poster.TabIndex = 10;
            // 
            // AjouterModifierSpectacle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 154);
            this.Controls.Add(this.PN_Poster);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.BTN_Parcourir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_Artiste);
            this.Controls.Add(this.TB_Titre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Categorie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AjouterModifierSpectacle";
            this.Text = "AjouterModifierSpectacle";
            this.Load += new System.EventHandler(this.AjouterModifierSpectacle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Categorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Titre;
        private System.Windows.Forms.TextBox TB_Artiste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTN_Parcourir;
        private System.Windows.Forms.Button BTN_OK;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Panel PN_Poster;
    }
}