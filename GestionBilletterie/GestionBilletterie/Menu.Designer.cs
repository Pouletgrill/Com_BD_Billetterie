namespace GestionBilletterie
{
   partial class Menu
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
         this.button1 = new System.Windows.Forms.Button();
         this.button2 = new System.Windows.Forms.Button();
         this.statusStrip1 = new System.Windows.Forms.StatusStrip();
         this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
         this.LB_ConnexionStatus = new System.Windows.Forms.ToolStripStatusLabel();
         this.button3 = new System.Windows.Forms.Button();
         this.button4 = new System.Windows.Forms.Button();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.statusStrip1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(12, 183);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(123, 23);
         this.button1.TabIndex = 0;
         this.button1.Text = "Gestion Spectacle";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // button2
         // 
         this.button2.Location = new System.Drawing.Point(141, 183);
         this.button2.Name = "button2";
         this.button2.Size = new System.Drawing.Size(123, 23);
         this.button2.TabIndex = 1;
         this.button2.Text = "Achats par catégorie";
         this.button2.UseVisualStyleBackColor = true;
         this.button2.Click += new System.EventHandler(this.button2_Click);
         // 
         // statusStrip1
         // 
         this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
         this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.LB_ConnexionStatus});
         this.statusStrip1.Location = new System.Drawing.Point(0, 245);
         this.statusStrip1.Name = "statusStrip1";
         this.statusStrip1.Size = new System.Drawing.Size(274, 22);
         this.statusStrip1.SizingGrip = false;
         this.statusStrip1.TabIndex = 3;
         this.statusStrip1.Text = "statusStrip1";
         // 
         // toolStripStatusLabel1
         // 
         this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
         this.toolStripStatusLabel1.Size = new System.Drawing.Size(119, 17);
         this.toolStripStatusLabel1.Text = "Status de connexion :";
         // 
         // LB_ConnexionStatus
         // 
         this.LB_ConnexionStatus.Name = "LB_ConnexionStatus";
         this.LB_ConnexionStatus.Size = new System.Drawing.Size(58, 17);
         this.LB_ConnexionStatus.Text = "Connecté";
         // 
         // button3
         // 
         this.button3.Location = new System.Drawing.Point(12, 212);
         this.button3.Name = "button3";
         this.button3.Size = new System.Drawing.Size(123, 23);
         this.button3.TabIndex = 4;
         this.button3.Text = "Clients les plus fidèles";
         this.button3.UseVisualStyleBackColor = true;
         this.button3.Click += new System.EventHandler(this.button3_Click);
         // 
         // button4
         // 
         this.button4.Location = new System.Drawing.Point(141, 212);
         this.button4.Name = "button4";
         this.button4.Size = new System.Drawing.Size(123, 23);
         this.button4.TabIndex = 5;
         this.button4.Text = "Billets à imprimer";
         this.button4.UseVisualStyleBackColor = true;
         this.button4.Click += new System.EventHandler(this.button4_Click);
         // 
         // pictureBox1
         // 
         this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
         this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
         this.pictureBox1.Location = new System.Drawing.Point(12, 12);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(252, 165);
         this.pictureBox1.TabIndex = 6;
         this.pictureBox1.TabStop = false;
         // 
         // Menu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(221)))), ((int)(((byte)(237)))));
         this.ClientSize = new System.Drawing.Size(274, 267);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.button4);
         this.Controls.Add(this.button3);
         this.Controls.Add(this.statusStrip1);
         this.Controls.Add(this.button2);
         this.Controls.Add(this.button1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.MaximizeBox = false;
         this.Name = "Menu";
         this.Text = "Menu";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
         this.Load += new System.EventHandler(this.Menu_Load);
         this.statusStrip1.ResumeLayout(false);
         this.statusStrip1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button button1;
      private System.Windows.Forms.Button button2;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
      private System.Windows.Forms.ToolStripStatusLabel LB_ConnexionStatus;
      private System.Windows.Forms.Button button3;
      private System.Windows.Forms.Button button4;
      private System.Windows.Forms.PictureBox pictureBox1;
   }
}