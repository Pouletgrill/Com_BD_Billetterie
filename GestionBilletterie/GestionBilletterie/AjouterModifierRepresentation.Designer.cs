namespace GestionBilletterie
{
   partial class AjouterModifierRepresentation
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
            this.CB_Spectacle = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_Salle = new System.Windows.Forms.ComboBox();
            this.DTP_DateHeure = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CB_Spectacle
            // 
            this.CB_Spectacle.FormattingEnabled = true;
            this.CB_Spectacle.Location = new System.Drawing.Point(86, 12);
            this.CB_Spectacle.Name = "CB_Spectacle";
            this.CB_Spectacle.Size = new System.Drawing.Size(121, 21);
            this.CB_Spectacle.TabIndex = 0;
            this.CB_Spectacle.SelectedIndexChanged += new System.EventHandler(this.CB_Spectacle_CB_Salle_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Spectacle :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salle :";
            // 
            // CB_Salle
            // 
            this.CB_Salle.FormattingEnabled = true;
            this.CB_Salle.Location = new System.Drawing.Point(86, 39);
            this.CB_Salle.Name = "CB_Salle";
            this.CB_Salle.Size = new System.Drawing.Size(121, 21);
            this.CB_Salle.TabIndex = 2;
            this.CB_Salle.SelectedIndexChanged += new System.EventHandler(this.CB_Spectacle_CB_Salle_SelectedIndexChanged);
            // 
            // DTP_DateHeure
            // 
            this.DTP_DateHeure.CustomFormat = "yyyy-MM-dd HH:mm";
            this.DTP_DateHeure.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTP_DateHeure.Location = new System.Drawing.Point(86, 66);
            this.DTP_DateHeure.Name = "DTP_DateHeure";
            this.DTP_DateHeure.Size = new System.Drawing.Size(121, 20);
            this.DTP_DateHeure.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date et heure :";
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(39, 92);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(80, 23);
            this.BTN_Cancel.TabIndex = 11;
            this.BTN_Cancel.Text = "Annuler";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // BTN_OK
            // 
            this.BTN_OK.Location = new System.Drawing.Point(125, 92);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(80, 23);
            this.BTN_OK.TabIndex = 10;
            this.BTN_OK.Text = "OK";
            this.BTN_OK.UseVisualStyleBackColor = true;
            this.BTN_OK.Click += new System.EventHandler(this.BTN_OK_Click);
            // 
            // AjouterModifierRepresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 124);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DTP_DateHeure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CB_Salle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CB_Spectacle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AjouterModifierRepresentation";
            this.Text = "Representation";
            this.Load += new System.EventHandler(this.AjouterModifierRepresentation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ComboBox CB_Spectacle;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.ComboBox CB_Salle;
      private System.Windows.Forms.DateTimePicker DTP_DateHeure;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button BTN_Cancel;
      private System.Windows.Forms.Button BTN_OK;
   }
}