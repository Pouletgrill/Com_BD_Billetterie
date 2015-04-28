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
                             + "User Id=" + orclUser + ";Password="+orclPass;
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
         }
         catch (Exception ex)
         {
            MessageBox.Show("Erreur de connexion");
         }
      }

      private void Menu_FormClosing(object sender, FormClosingEventArgs e)
      {
         try
         {
            connection.Close();
         }
         catch (Exception ex)
         {
            MessageBox.Show("Erreur de deconnexion");
         }
      }

      private void button1_Click(object sender, EventArgs e)
      {
         Form1 dlg = new Form1(connection);
         dlg.ShowDialog();
      }
   }
}
