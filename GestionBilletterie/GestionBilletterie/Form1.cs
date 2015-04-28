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
   public partial class Form1 : Form
   {
      DataSet dataSet = new DataSet();
      OracleConnection conn;
      public Form1(OracleConnection connection)
      {         
         InitializeComponent();
         conn = connection;
      }

      private void Form1_Load(object sender, EventArgs e)
      {

      }
      public void RefreshDGVSpectacle()
      {
         try
         {
            // //déclaration de OracleCommand pour appeler la fonction avec la
            //connection conn.
            OracleCommand Oracmd = new OracleCommand("PKG_GESTION",
            conn);
            Oracmd.CommandText = "PKG_GESTION.AFFICHERQUESTION";
            Oracmd.CommandType = CommandType.StoredProcedure;
            // pour une fonction, le paramètre de retour doit être déclaré en
            //premier.
            OracleParameter OrapameResultat = new
            OracleParameter("CURSORGESTION", OracleDbType.RefCursor);
            OrapameResultat.Direction = ParameterDirection.ReturnValue;
            Oracmd.Parameters.Add(OrapameResultat);

            // Pour remplir le DataSet, on déclare un OracleDataAdapter pour lequel
            // on passe notre OracleCommand qui contient TOUS les paramètres.

            OracleDataAdapter orAdater = new OracleDataAdapter(Oracmd);
            if (dataSet.Tables.Contains("Question"))
            {
               dataSet.Tables["Question"].Clear();
            }
            orAdater.Fill(dataSet, "Question");
            Oracmd.Dispose();
            BindingSource bindingSource;
            bindingSource = new BindingSource(dataSet, "Question");
             DGV_Spectacle.DataSource = bindingSource;
             DGV_Spectacle.Columns[2].Visible = false;
         }
         catch (Exception se)
         {
            MessageBox.Show(se.Message.ToString());
         }
      }
   }
}
