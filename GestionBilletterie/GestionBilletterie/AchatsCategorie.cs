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
    public partial class AchatsCategorie : Form
    {
        OracleConnection connection;
        DataSet dataSet = new DataSet();

        public AchatsCategorie(OracleConnection conn)
        {
            InitializeComponent();
            connection = conn;
        }

        private void LierTextBox()
        {
            TB_Nom.DataBindings.Add("text", dataSet, "CLIENTS.NOM");
            TB_Prenom.DataBindings.Add("text", dataSet, "CLIENTS.PRENOM");
            TB_Adresse.DataBindings.Add("text", dataSet, "CLIENTS.ADRESSE");
            TB_Telephone.DataBindings.Add("text", dataSet, "CLIENTS.TELEPHONE");
            TB_Email.DataBindings.Add("text", dataSet, "CLIENTS.EMAIL");
        }

        private void Dissocier()
        {
            TB_Nom.DataBindings.Clear();
            TB_Nom.Clear();
            TB_Prenom.DataBindings.Clear();
            TB_Prenom.Clear();
            TB_Adresse.DataBindings.Clear();
            TB_Adresse.Clear();
            TB_Telephone.DataBindings.Clear();
            TB_Telephone.Clear();
            TB_Email.DataBindings.Clear();
            TB_Email.Clear();
        }

        private void UpdateControls()
        {
            BTN_Suivant.Enabled = (this.BindingContext[dataSet, "CLIENTS"].Position + 1) < this.BindingContext[dataSet, "CLIENTS"].Count;
            BTN_Precedent.Enabled = this.BindingContext[dataSet, "CLIENTS"].Position > 0;

            AfficherNavigation();
        }

        private void AfficherNavigation()
        {
            LBL_Navigation.Text = (this.BindingContext[dataSet, "CLIENTS"].Position + 1).ToString()
                + " / " + this.BindingContext[dataSet, "CLIENTS"].Count.ToString();
        }

        private void Suivant()
        {
            this.BindingContext[dataSet, "CLIENTS"].Position += 1;
        }

        private void Precedent()
        {
            this.BindingContext[dataSet, "CLIENTS"].Position -= 1;
        }

        private void RechercherClient()
        {
            OracleCommand cmd = new OracleCommand("RECHERCHER", connection);
            cmd.CommandText = "PKG_BILLETS.AFFICHER_CLIENT";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter pResultat = new OracleParameter("PRESULTAT", OracleDbType.RefCursor);
            pResultat.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(pResultat);

            OracleParameter pNom = new OracleParameter("PNOM", OracleDbType.NVarchar2);
            pNom.Direction = ParameterDirection.Input;
            pNom.Value = TB_Nom.Text;
            cmd.Parameters.Add(pNom);

            OracleParameter pPrenom = new OracleParameter("PPRENOM", OracleDbType.NVarchar2);
            pPrenom.Direction = ParameterDirection.Input;
            pPrenom.Value = TB_Prenom.Text;
            cmd.Parameters.Add(pPrenom);

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);

            if (dataSet.Tables.Contains("CLIENTS"))
                dataSet.Tables["CLIENTS"].Clear();

            adapter.Fill(dataSet, "CLIENTS");
            adapter.Dispose();

            LierTextBox();
            AfficherCategories();
        }

        private void AfficherCategories()
        {
            OracleCommand cmd = new OracleCommand("AFFICHER", connection);
            cmd.CommandText = "PKG_BILLETS.LISTER_CATEGORIES";
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter pResultat = new OracleParameter("PRESULTAT", OracleDbType.RefCursor);
            pResultat.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(pResultat);

            OracleParameter pClient = new OracleParameter("PCLIENT", OracleDbType.NVarchar2);
            pClient.Direction = ParameterDirection.Input;
            pClient.Value = TB_Email.Text;
            cmd.Parameters.Add(pClient);

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);

            if (dataSet.Tables.Contains("CATEGORIES"))
                dataSet.Tables["CATEGORIES"].Clear();

            adapter.Fill(dataSet, "CATEGORIES");
            adapter.Dispose();

            DGV_Categories.DataSource = new BindingSource(dataSet, "CATEGORIES");
        }

        //------ ÉVÈNEMENTS ---------------------------------------------------------------------------------

        private void BTN_Recherche_Click(object sender, EventArgs e)
        {
            Dissocier();
            RechercherClient();
            UpdateControls();
        }

        private void BTN_Precedent_Click(object sender, EventArgs e)
        {
            Precedent();
            AfficherCategories();
        }

        private void BTN_Suivant_Click(object sender, EventArgs e)
        {
            Suivant();
            AfficherCategories();
        }
    }
}
