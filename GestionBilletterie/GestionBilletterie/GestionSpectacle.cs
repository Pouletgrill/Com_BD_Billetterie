using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace GestionBilletterie
{
   public partial class GestionSpectacle : Form
   {
      DataSet dataSet = new DataSet();
      OracleConnection conn;
      public GestionSpectacle(OracleConnection connection)
      {         
         InitializeComponent();
         conn = connection;
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         RefreshDGVSpectacle();
      }
      public void RefreshDGVSpectacle()
      {
         try
         {
            // //déclaration de OracleCommand pour appeler la fonction avec la
            //connection conn.
            OracleCommand Oracmd = new OracleCommand("PKG_BILLETS",
            conn);
            Oracmd.CommandText = "PKG_BILLETS.AFFICHER_SPECTACLE";
            Oracmd.CommandType = CommandType.StoredProcedure;
            // pour une fonction, le paramètre de retour doit être déclaré en
            //premier.
            OracleParameter OrapameResultat = new
            OracleParameter("RESULTSET", OracleDbType.RefCursor);
            OrapameResultat.Direction = ParameterDirection.ReturnValue;
            Oracmd.Parameters.Add(OrapameResultat);

            // Pour remplir le DataSet, on déclare un OracleDataAdapter pour lequel
            // on passe notre OracleCommand qui contient TOUS les paramètres.

            OracleDataAdapter orAdater = new OracleDataAdapter(Oracmd);
            if (dataSet.Tables.Contains("Spectacle"))
            {
               dataSet.Tables["Spectacle"].Clear();
            }
            orAdater.Fill(dataSet, "Spectacle");
            Oracmd.Dispose();
            BindingSource bindingSource;
            bindingSource = new BindingSource(dataSet, "Spectacle");
             DGV_Spectacle.DataSource = bindingSource;
             DGV_Spectacle.Columns[0].Visible = false;
         }
         catch (Exception se)
         {
            MessageBox.Show(se.Message.ToString());
         }
      }
   }
}
