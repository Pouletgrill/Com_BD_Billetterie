namespace GestionBilletterie
{
    partial class AchatsCategorie
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
            this.LBL_Nom = new System.Windows.Forms.Label();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.LBL_Prenom = new System.Windows.Forms.Label();
            this.TB_Prenom = new System.Windows.Forms.TextBox();
            this.BTN_Recherche = new System.Windows.Forms.Button();
            this.LBL_Adresse = new System.Windows.Forms.Label();
            this.TB_Adresse = new System.Windows.Forms.TextBox();
            this.TB_Telephone = new System.Windows.Forms.TextBox();
            this.LBL_Telephone = new System.Windows.Forms.Label();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.LBL_Email = new System.Windows.Forms.Label();
            this.BTN_Precedent = new System.Windows.Forms.Button();
            this.BTN_Suivant = new System.Windows.Forms.Button();
            this.LBL_Navigation = new System.Windows.Forms.Label();
            this.DGV_Categories = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Categories)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Nom
            // 
            this.LBL_Nom.AutoSize = true;
            this.LBL_Nom.Location = new System.Drawing.Point(12, 17);
            this.LBL_Nom.Name = "LBL_Nom";
            this.LBL_Nom.Size = new System.Drawing.Size(29, 13);
            this.LBL_Nom.TabIndex = 0;
            this.LBL_Nom.Text = "Nom";
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(47, 14);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(170, 20);
            this.TB_Nom.TabIndex = 1;
            // 
            // LBL_Prenom
            // 
            this.LBL_Prenom.AutoSize = true;
            this.LBL_Prenom.Location = new System.Drawing.Point(223, 17);
            this.LBL_Prenom.Name = "LBL_Prenom";
            this.LBL_Prenom.Size = new System.Drawing.Size(43, 13);
            this.LBL_Prenom.TabIndex = 2;
            this.LBL_Prenom.Text = "Prénom";
            // 
            // TB_Prenom
            // 
            this.TB_Prenom.Location = new System.Drawing.Point(272, 14);
            this.TB_Prenom.Name = "TB_Prenom";
            this.TB_Prenom.Size = new System.Drawing.Size(170, 20);
            this.TB_Prenom.TabIndex = 3;
            // 
            // BTN_Recherche
            // 
            this.BTN_Recherche.Location = new System.Drawing.Point(455, 12);
            this.BTN_Recherche.Name = "BTN_Recherche";
            this.BTN_Recherche.Size = new System.Drawing.Size(75, 23);
            this.BTN_Recherche.TabIndex = 4;
            this.BTN_Recherche.Text = "Recherche";
            this.BTN_Recherche.UseVisualStyleBackColor = true;
            this.BTN_Recherche.Click += new System.EventHandler(this.BTN_Recherche_Click);
            // 
            // LBL_Adresse
            // 
            this.LBL_Adresse.AutoSize = true;
            this.LBL_Adresse.Location = new System.Drawing.Point(12, 43);
            this.LBL_Adresse.Name = "LBL_Adresse";
            this.LBL_Adresse.Size = new System.Drawing.Size(45, 13);
            this.LBL_Adresse.TabIndex = 5;
            this.LBL_Adresse.Text = "Adresse";
            // 
            // TB_Adresse
            // 
            this.TB_Adresse.Location = new System.Drawing.Point(63, 40);
            this.TB_Adresse.Name = "TB_Adresse";
            this.TB_Adresse.ReadOnly = true;
            this.TB_Adresse.Size = new System.Drawing.Size(143, 20);
            this.TB_Adresse.TabIndex = 6;
            // 
            // TB_Telephone
            // 
            this.TB_Telephone.Location = new System.Drawing.Point(276, 40);
            this.TB_Telephone.Name = "TB_Telephone";
            this.TB_Telephone.ReadOnly = true;
            this.TB_Telephone.Size = new System.Drawing.Size(100, 20);
            this.TB_Telephone.TabIndex = 8;
            // 
            // LBL_Telephone
            // 
            this.LBL_Telephone.AutoSize = true;
            this.LBL_Telephone.Location = new System.Drawing.Point(212, 43);
            this.LBL_Telephone.Name = "LBL_Telephone";
            this.LBL_Telephone.Size = new System.Drawing.Size(58, 13);
            this.LBL_Telephone.TabIndex = 7;
            this.LBL_Telephone.Text = "Téléphone";
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(430, 40);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.ReadOnly = true;
            this.TB_Email.Size = new System.Drawing.Size(100, 20);
            this.TB_Email.TabIndex = 10;
            // 
            // LBL_Email
            // 
            this.LBL_Email.AutoSize = true;
            this.LBL_Email.Location = new System.Drawing.Point(382, 43);
            this.LBL_Email.Name = "LBL_Email";
            this.LBL_Email.Size = new System.Drawing.Size(42, 13);
            this.LBL_Email.TabIndex = 9;
            this.LBL_Email.Text = "Courriel";
            // 
            // BTN_Precedent
            // 
            this.BTN_Precedent.Location = new System.Drawing.Point(12, 66);
            this.BTN_Precedent.Name = "BTN_Precedent";
            this.BTN_Precedent.Size = new System.Drawing.Size(75, 23);
            this.BTN_Precedent.TabIndex = 11;
            this.BTN_Precedent.Text = "Précedent";
            this.BTN_Precedent.UseVisualStyleBackColor = true;
            this.BTN_Precedent.Click += new System.EventHandler(this.BTN_Precedent_Click);
            // 
            // BTN_Suivant
            // 
            this.BTN_Suivant.Location = new System.Drawing.Point(455, 66);
            this.BTN_Suivant.Name = "BTN_Suivant";
            this.BTN_Suivant.Size = new System.Drawing.Size(75, 23);
            this.BTN_Suivant.TabIndex = 12;
            this.BTN_Suivant.Text = "Suivant";
            this.BTN_Suivant.UseVisualStyleBackColor = true;
            this.BTN_Suivant.Click += new System.EventHandler(this.BTN_Suivant_Click);
            // 
            // LBL_Navigation
            // 
            this.LBL_Navigation.AutoSize = true;
            this.LBL_Navigation.Location = new System.Drawing.Point(232, 76);
            this.LBL_Navigation.Name = "LBL_Navigation";
            this.LBL_Navigation.Size = new System.Drawing.Size(24, 13);
            this.LBL_Navigation.TabIndex = 13;
            this.LBL_Navigation.Text = "0/0";
            // 
            // DGV_Categories
            // 
            this.DGV_Categories.AllowUserToAddRows = false;
            this.DGV_Categories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Categories.Location = new System.Drawing.Point(12, 95);
            this.DGV_Categories.Name = "DGV_Categories";
            this.DGV_Categories.ReadOnly = true;
            this.DGV_Categories.RowHeadersVisible = false;
            this.DGV_Categories.Size = new System.Drawing.Size(518, 307);
            this.DGV_Categories.TabIndex = 14;
            // 
            // AchatsCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 414);
            this.Controls.Add(this.DGV_Categories);
            this.Controls.Add(this.LBL_Navigation);
            this.Controls.Add(this.BTN_Suivant);
            this.Controls.Add(this.BTN_Precedent);
            this.Controls.Add(this.TB_Email);
            this.Controls.Add(this.LBL_Email);
            this.Controls.Add(this.TB_Telephone);
            this.Controls.Add(this.LBL_Telephone);
            this.Controls.Add(this.TB_Adresse);
            this.Controls.Add(this.LBL_Adresse);
            this.Controls.Add(this.BTN_Recherche);
            this.Controls.Add(this.TB_Prenom);
            this.Controls.Add(this.LBL_Prenom);
            this.Controls.Add(this.TB_Nom);
            this.Controls.Add(this.LBL_Nom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AchatsCategorie";
            this.Text = "AchatsCategorie";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Categories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Nom;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.Label LBL_Prenom;
        private System.Windows.Forms.TextBox TB_Prenom;
        private System.Windows.Forms.Button BTN_Recherche;
        private System.Windows.Forms.Label LBL_Adresse;
        private System.Windows.Forms.TextBox TB_Adresse;
        private System.Windows.Forms.TextBox TB_Telephone;
        private System.Windows.Forms.Label LBL_Telephone;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.Label LBL_Email;
        private System.Windows.Forms.Button BTN_Precedent;
        private System.Windows.Forms.Button BTN_Suivant;
        private System.Windows.Forms.Label LBL_Navigation;
        private System.Windows.Forms.DataGridView DGV_Categories;

    }
}