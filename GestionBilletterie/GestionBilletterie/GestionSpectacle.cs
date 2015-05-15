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
      DataSet dataSetRep = new DataSet();
      OracleConnection conn;
      public GestionSpectacle(OracleConnection connection)
      {
         InitializeComponent();
         conn = connection;
      }

      private void Form1_Load(object sender, EventArgs e)
      {
         RefreshDGVSpectacle();
         DGV_Spectacle.Rows[0].Selected = false;
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
         DGV_Representation.DataSource = null;
         DGV_Representation.Refresh();
         BTN_Modifier_Spectacle.Enabled = false;
         BTN_Supprimer_Spectacle.Enabled = false;
         BTN_Modifier_Representation.Enabled = false;
         BTN_Supprimer_Representation.Enabled = false;
         BTN_Ajouter_Representation.Enabled = false;
      }
      public void RefreshDGVRepresentation(string numSpectacle)
      {
         try
         {
            // //déclaration de OracleCommand pour appeler la fonction avec la
            //connection conn.
            OracleCommand Oracmd = new OracleCommand("PKG_BILLETS",
            conn);
            Oracmd.CommandText = "PKG_BILLETS.AFFICHER_REPRESENTATION";
            Oracmd.CommandType = CommandType.StoredProcedure;
            // pour une fonction, le paramètre de retour doit être déclaré en
            //premier.
            OracleParameter OrapameResultat = new
            OracleParameter("RESULTSET", OracleDbType.RefCursor);
            OrapameResultat.Direction = ParameterDirection.ReturnValue;
            Oracmd.Parameters.Add(OrapameResultat);

            //Déclaration des paramettres
            OracleParameter procID = new OracleParameter("pNumSpectacle", OracleDbType.Int32);
            procID.Direction = ParameterDirection.Input;
            procID.Value = numSpectacle;
            Oracmd.Parameters.Add(procID);

            // Pour remplir le DataSet, on déclare un OracleDataAdapter pour lequel
            // on passe notre OracleCommand qui contient TOUS les paramètres.

            OracleDataAdapter orAdater = new OracleDataAdapter(Oracmd);
            if (dataSetRep.Tables.Contains("Spectacle"))
            {
               dataSetRep.Tables["Spectacle"].Clear();
            }
            orAdater.Fill(dataSetRep, "Spectacle");
            Oracmd.Dispose();
            BindingSource bindingSource;
            bindingSource = new BindingSource(dataSetRep, "Spectacle");
            DGV_Representation.DataSource = bindingSource;
            DGV_Representation.Columns[0].Visible = false;
            DGV_Representation.Sort(DGV_Representation.Columns[2], ListSortDirection.Ascending);
         }
         catch (Exception se)
         {
            MessageBox.Show(se.Message.ToString());
         }
      }

      private void DGV_Spectacle_CellClick(object sender, DataGridViewCellEventArgs e)
      {         
         if (DGV_Spectacle.SelectedRows.Count > 0)
         {
            RefreshDGVRepresentation(DGV_Spectacle.Rows[DGV_Spectacle.CurrentRow.Index].Cells[0].Value.ToString());
            BTN_Modifier_Spectacle.Enabled = true;
            BTN_Supprimer_Spectacle.Enabled = true;
            BTN_Modifier_Representation.Enabled = false;
            BTN_Supprimer_Representation.Enabled = false;
            BTN_Ajouter_Representation.Enabled = true;
         }
         if (DGV_Representation.Rows.Count > 0)
            DGV_Representation.Rows[0].Selected = false;
      }

      private void BTN_Ajouter_Spectacle_Click(object sender, EventArgs e)
      {
         AjouterModifierSpectacle dlg = new AjouterModifierSpectacle(conn);
         dlg.ShowDialog();
         RefreshDGVSpectacle();
      }

      private void BTN_Modifier_Spectacle_Click(object sender, EventArgs e)
      {
         AjouterModifierSpectacle dlg = new AjouterModifierSpectacle(conn, DGV_Spectacle.Rows[DGV_Spectacle.CurrentRow.Index].Cells[0].Value.ToString());
         dlg.ShowDialog();
         RefreshDGVSpectacle();
      }

      private void DGV_Representation_CellClick(object sender, DataGridViewCellEventArgs e)
      {
         if (DGV_Representation.SelectedRows.Count > 0)
         {
            BTN_Modifier_Representation.Enabled = true;
            BTN_Supprimer_Representation.Enabled = true;
         }
      }

      private void BTN_Ajouter_Representation_Click(object sender, EventArgs e)
      {
         AjouterModifierRepresentation dlg = new AjouterModifierRepresentation(conn, DGV_Spectacle.Rows[DGV_Spectacle.CurrentRow.Index].Cells[0].Value.ToString());
         dlg.ShowDialog();
      }

      private void BTN_Modifier_Representation_Click(object sender, EventArgs e)
      {
         AjouterModifierRepresentation dlg = new AjouterModifierRepresentation(conn, DGV_Spectacle.Rows[DGV_Spectacle.CurrentRow.Index].Cells[0].Value.ToString(), DGV_Representation.Rows[DGV_Representation.CurrentRow.Index].Cells[0].Value.ToString());
         dlg.ShowDialog();
      }
   }
}
