namespace GestionBilletterie
{
   partial class GestionSpectacle
   {
      /// <summary>
      /// Variable nécessaire au concepteur.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Nettoyage des ressources utilisées.
      /// </summary>
      /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Code généré par le Concepteur Windows Form

      /// <summary>
      /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
      /// le contenu de cette méthode avec l'éditeur de code.
      /// </summary>
      private void InitializeComponent()
      {
         this.splitContainer1 = new System.Windows.Forms.SplitContainer();
         this.DGV_Spectacle = new System.Windows.Forms.DataGridView();
         this.GB_Spectacle = new System.Windows.Forms.GroupBox();
         this.BTN_Supprimer_Spectacle = new System.Windows.Forms.Button();
         this.BTN_Modifier_Spectacle = new System.Windows.Forms.Button();
         this.BTN_Ajouter_Spectacle = new System.Windows.Forms.Button();
         this.DGV_Representation = new System.Windows.Forms.DataGridView();
         this.GB_Representation = new System.Windows.Forms.GroupBox();
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.button3 = new System.Windows.Forms.Button();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.editionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.rienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.rienNonPlusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.vaVoirEditionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
         this.splitContainer1.Panel1.SuspendLayout();
         this.splitContainer1.Panel2.SuspendLayout();
         this.splitContainer1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.DGV_Spectacle)).BeginInit();
         this.GB_Spectacle.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.DGV_Representation)).BeginInit();
         this.GB_Representation.SuspendLayout();
         this.menuStrip1.SuspendLayout();
         this.SuspendLayout();
         // 
         // splitContainer1
         // 
         this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.splitContainer1.Location = new System.Drawing.Point(1, 27);
         this.splitContainer1.Name = "splitContainer1";
         // 
         // splitContainer1.Panel1
         // 
         this.splitContainer1.Panel1.Controls.Add(this.DGV_Spectacle);
         this.splitContainer1.Panel1.Controls.Add(this.GB_Spectacle);
         this.splitContainer1.Panel1MinSize = 254;
         // 
         // splitContainer1.Panel2
         // 
         this.splitContainer1.Panel2.Controls.Add(this.DGV_Representation);
         this.splitContainer1.Panel2.Controls.Add(this.GB_Representation);
         this.splitContainer1.Panel2MinSize = 260;
         this.splitContainer1.Size = new System.Drawing.Size(518, 397);
         this.splitContainer1.SplitterDistance = 254;
         this.splitContainer1.TabIndex = 0;
         // 
         // DGV_Spectacle
         // 
         this.DGV_Spectacle.AllowUserToAddRows = false;
         this.DGV_Spectacle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.DGV_Spectacle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.DGV_Spectacle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.DGV_Spectacle.Location = new System.Drawing.Point(3, 61);
         this.DGV_Spectacle.MultiSelect = false;
         this.DGV_Spectacle.Name = "DGV_Spectacle";
         this.DGV_Spectacle.ReadOnly = true;
         this.DGV_Spectacle.RowHeadersVisible = false;
         this.DGV_Spectacle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.DGV_Spectacle.ShowEditingIcon = false;
         this.DGV_Spectacle.Size = new System.Drawing.Size(250, 333);
         this.DGV_Spectacle.TabIndex = 1;
         // 
         // GB_Spectacle
         // 
         this.GB_Spectacle.Controls.Add(this.BTN_Supprimer_Spectacle);
         this.GB_Spectacle.Controls.Add(this.BTN_Modifier_Spectacle);
         this.GB_Spectacle.Controls.Add(this.BTN_Ajouter_Spectacle);
         this.GB_Spectacle.Location = new System.Drawing.Point(3, 3);
         this.GB_Spectacle.Name = "GB_Spectacle";
         this.GB_Spectacle.Size = new System.Drawing.Size(250, 52);
         this.GB_Spectacle.TabIndex = 0;
         this.GB_Spectacle.TabStop = false;
         this.GB_Spectacle.Text = "Spectacle";
         // 
         // BTN_Supprimer_Spectacle
         // 
         this.BTN_Supprimer_Spectacle.Location = new System.Drawing.Point(169, 20);
         this.BTN_Supprimer_Spectacle.Name = "BTN_Supprimer_Spectacle";
         this.BTN_Supprimer_Spectacle.Size = new System.Drawing.Size(75, 23);
         this.BTN_Supprimer_Spectacle.TabIndex = 2;
         this.BTN_Supprimer_Spectacle.Text = "Supprimer";
         this.BTN_Supprimer_Spectacle.UseVisualStyleBackColor = true;
         // 
         // BTN_Modifier_Spectacle
         // 
         this.BTN_Modifier_Spectacle.Location = new System.Drawing.Point(88, 19);
         this.BTN_Modifier_Spectacle.Name = "BTN_Modifier_Spectacle";
         this.BTN_Modifier_Spectacle.Size = new System.Drawing.Size(75, 23);
         this.BTN_Modifier_Spectacle.TabIndex = 1;
         this.BTN_Modifier_Spectacle.Text = "Modifier";
         this.BTN_Modifier_Spectacle.UseVisualStyleBackColor = true;
         // 
         // BTN_Ajouter_Spectacle
         // 
         this.BTN_Ajouter_Spectacle.Location = new System.Drawing.Point(7, 20);
         this.BTN_Ajouter_Spectacle.Name = "BTN_Ajouter_Spectacle";
         this.BTN_Ajouter_Spectacle.Size = new System.Drawing.Size(75, 23);
         this.BTN_Ajouter_Spectacle.TabIndex = 0;
         this.BTN_Ajouter_Spectacle.Text = "Ajouter";
         this.BTN_Ajouter_Spectacle.UseVisualStyleBackColor = true;
         // 
         // DGV_Representation
         // 
         this.DGV_Representation.AllowUserToAddRows = false;
         this.DGV_Representation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.DGV_Representation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
         this.DGV_Representation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.DGV_Representation.Location = new System.Drawing.Point(3, 61);
         this.DGV_Representation.MultiSelect = false;
         this.DGV_Representation.Name = "DGV_Representation";
         this.DGV_Representation.ReadOnly = true;
         this.DGV_Representation.RowHeadersVisible = false;
         this.DGV_Representation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.DGV_Representation.ShowEditingIcon = false;
         this.DGV_Representation.Size = new System.Drawing.Size(254, 333);
         this.DGV_Representation.TabIndex = 2;
         // 
         // GB_Representation
         // 
         this.GB_Representation.Controls.Add(this.button1);
         this.GB_Representation.Controls.Add(this.button2);
         this.GB_Representation.Controls.Add(this.button3);
         this.GB_Representation.Location = new System.Drawing.Point(3, 3);
         this.GB_Representation.Name = "GB_Representation";
         this.GB_Representation.Size = new System.Drawing.Size(254, 52);
         this.GB_Representation.TabIndex = 3;
         this.GB_Representation.TabStop = false;
         this.GB_Representation.Text = "Représentation";
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(169, 20);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(75, 23);
         this.button1.TabIndex = 2;
         this.button1.Text = "Supprimer";
         this.button1.UseVisualStyleBackColor = true;
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(88, 19);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(75, 23);
         this.button2.TabIndex = 1;
         this.button2.Text = "Modifier";
         this.button2.UseVisualStyleBackColor = true;
         // 
         // button3
         // 
         this.button3.Location = new System.Drawing.Point(7, 20);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(75, 23);
         this.button3.TabIndex = 0;
         this.button3.Text = "Ajouter";
         this.button3.UseVisualStyleBackColor = true;
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.editionToolStripMenuItem});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(521, 24);
         this.menuStrip1.TabIndex = 1;
         this.menuStrip1.Text = "menuStrip1";
         // 
         // fichierToolStripMenuItem
         // 
         this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vaVoirEditionToolStripMenuItem});
         this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
         this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
         this.fichierToolStripMenuItem.Text = "Fichier";
         // 
         // editionToolStripMenuItem
         // 
         this.editionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rienToolStripMenuItem,
            this.rienNonPlusToolStripMenuItem});
         this.editionToolStripMenuItem.Name = "editionToolStripMenuItem";
         this.editionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
         this.editionToolStripMenuItem.Text = "Edition";
         // 
         // rienToolStripMenuItem
         // 
         this.rienToolStripMenuItem.Name = "rienToolStripMenuItem";
         this.rienToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.rienToolStripMenuItem.Text = "rien";
         // 
         // rienNonPlusToolStripMenuItem
         // 
         this.rienNonPlusToolStripMenuItem.Name = "rienNonPlusToolStripMenuItem";
         this.rienNonPlusToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.rienNonPlusToolStripMenuItem.Text = "rien non plus";
         // 
         // vaVoirEditionToolStripMenuItem
         // 
         this.vaVoirEditionToolStripMenuItem.Name = "vaVoirEditionToolStripMenuItem";
         this.vaVoirEditionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
         this.vaVoirEditionToolStripMenuItem.Text = "va voir Edition";
         // 
         // GestionSpectacle
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(521, 425);
         this.Controls.Add(this.splitContainer1);
         this.Controls.Add(this.menuStrip1);
         this.MainMenuStrip = this.menuStrip1;
         this.MinimumSize = new System.Drawing.Size(537, 149);
         this.Name = "GestionSpectacle";
         this.Text = "Gestion spectacle";
         this.Load += new System.EventHandler(this.Form1_Load);
         this.splitContainer1.Panel1.ResumeLayout(false);
         this.splitContainer1.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
         this.splitContainer1.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.DGV_Spectacle)).EndInit();
         this.GB_Spectacle.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.DGV_Representation)).EndInit();
         this.GB_Representation.ResumeLayout(false);
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.SplitContainer splitContainer1;
      private System.Windows.Forms.GroupBox GB_Spectacle;
      private System.Windows.Forms.Button BTN_Supprimer_Spectacle;
      private System.Windows.Forms.Button BTN_Modifier_Spectacle;
      private System.Windows.Forms.Button BTN_Ajouter_Spectacle;
      private System.Windows.Forms.GroupBox GB_Representation;
      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.MenuStrip menuStrip1;
      private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem editionToolStripMenuItem;
      private System.Windows.Forms.DataGridView DGV_Spectacle;
      private System.Windows.Forms.DataGridView DGV_Representation;
      private System.Windows.Forms.ToolStripMenuItem vaVoirEditionToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem rienToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem rienNonPlusToolStripMenuItem;
   }
}

