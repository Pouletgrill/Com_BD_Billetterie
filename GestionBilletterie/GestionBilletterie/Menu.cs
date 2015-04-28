using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionBilletterie
{
   public partial class Menu : Form
   {
      public OracleConnection connection;

      private static String orclUser = "brosseau";
      private static string orclPass = "ORACLE2";
      public String connectionString = "Data Source=(DESCRIPTION="
                             + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                             + "(HOST=205.237.244.251)(PORT=1521)))"
                             + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)));"
                             + "User Id=" + orclUser + ";Password=" + orclPass;
      public Menu()
      {
         InitializeComponent();
      }

      private void Menu_Load(object sender, EventArgs e)
      {
         Connecter();
      }

      private void Connecter()
      {
         connection = new OracleConnection(connectionString);
         connection.ConnectionString = connectionString;

         try
         {
            connection.Open();
            LB_ConnexionStatus.Text = "Connecté";
            LB_ConnexionStatus.ForeColor = System.Drawing.Color.Green;
         }
         catch (Exception ex)
         {
            LB_ConnexionStatus.Text = "Erreur";
            LB_ConnexionStatus.ForeColor = System.Drawing.Color.Red;
         }
      }

      private void Menu_FormClosing(object sender, FormClosingEventArgs e)
      {
         connection.Close();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         GestionSpectacle dlg = new GestionSpectacle(connection);
         dlg.ShowDialog();
      }

      private void button2_Click(object sender, EventArgs e)
      {
          AchatsCategorie dlg = new AchatsCategorie(connection);
          dlg.ShowDialog();
      }

      private void button3_Click(object sender, EventArgs e)
      {
          ClientsFideles dlg = new ClientsFideles(connection);
          dlg.ShowDialog();
      }

      private void button4_Click(object sender, EventArgs e)
      {
          ImprimerBillets dlg = new ImprimerBillets(connection);
          dlg.ShowDialog();
      }
   }
}
