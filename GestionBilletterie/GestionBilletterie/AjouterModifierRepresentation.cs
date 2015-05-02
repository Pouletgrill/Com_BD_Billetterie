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
    public partial class AjouterModifierRepresentation : Form
    {
        bool nouveau;
        OracleConnection conn = null;
        string numRepresentation = null;
        string numSpectacle = null;
        List<string> IDCBSpectacle = new List<string>();
        List<string> IDCBSalle = new List<string>();

        public AjouterModifierRepresentation(OracleConnection connexion, string IDspectacle)
        {
            conn = connexion;
            nouveau = true;
            numSpectacle = IDspectacle;
            InitializeComponent();
        }
        public AjouterModifierRepresentation(OracleConnection connexion, string IDspectacle, string IDrepresentation)
        {
            conn = connexion;
            nouveau = false;
            numRepresentation = IDrepresentation;
            numSpectacle = IDspectacle;
            InitializeComponent();
        }

        private void AjouterModifierRepresentation_Load(object sender, EventArgs e)
        {
            LoadSpectacle();
            LoadSalle();
            if (!nouveau)
            {
                LoadInfo();
            }
            else
            {
                for (int i=0;i<IDCBSpectacle.Count;i++)
                {
                    if (IDCBSpectacle[i] == numSpectacle)
                    {
                        CB_Spectacle.SelectedIndex = i;
                    }
                }
            }
            ButtonRefresh();
        }

        private void LoadSpectacle()
        {
            try
            {
                OracleCommand inserer = new OracleCommand("PKG_BILLETS", conn);
                inserer.CommandText = "PKG_BILLETS.AFFICHER_Spectacle";
                inserer.CommandType = CommandType.StoredProcedure;

                OracleParameter pResultat = new OracleParameter("RESULTSET", OracleDbType.RefCursor);
                pResultat.Direction = ParameterDirection.ReturnValue;
                inserer.Parameters.Add(pResultat);

                OracleDataReader reader = inserer.ExecuteReader();

                while (reader.Read())
                {
                    CB_Spectacle.Items.Add(reader.GetString(1));
                    IDCBSpectacle.Add(reader.GetInt32(0).ToString());
                }
            }
            catch (OracleException)
            {
                MessageBox.Show("Une érreur est survenue lors de l'initialisation des spectacles");
                this.Close();
            }
        }
        private void LoadSalle()
        {
            try
            {
                OracleCommand inserer = new OracleCommand("PKG_BILLETS", conn);
                inserer.CommandText = "PKG_BILLETS.AFFICHER_SALLE";
                inserer.CommandType = CommandType.StoredProcedure;

                OracleParameter pResultat = new OracleParameter("RESULTSET", OracleDbType.RefCursor);
                pResultat.Direction = ParameterDirection.ReturnValue;
                inserer.Parameters.Add(pResultat);

                OracleDataReader reader = inserer.ExecuteReader();

                while (reader.Read())
                {
                    CB_Salle.Items.Add(reader.GetString(1));
                    IDCBSalle.Add(reader.GetInt32(0).ToString());
                }
            }
            catch (OracleException)
            {
                MessageBox.Show("Une érreur est survenue lors de l'initialisation des salles");
                this.Close();
            }
        }
        private void LoadInfo()
        {
            try
            {
                // //déclaration de OracleCommand pour appeler la fonction avec la
                //connection conn.
                OracleCommand Oracmd = new OracleCommand("PKG_BILLETS",
                conn);
                Oracmd.CommandText = "PKG_BILLETS.GET_MODIF_REPRESENTATION";
                Oracmd.CommandType = CommandType.StoredProcedure;
                // pour une fonction, le paramètre de retour doit être déclaré en
                //premier.
                OracleParameter OrapameResultat = new
                OracleParameter("RESULTSET", OracleDbType.RefCursor);
                OrapameResultat.Direction = ParameterDirection.ReturnValue;
                Oracmd.Parameters.Add(OrapameResultat);

                //Déclaration des paramettres
                OracleParameter procID = new OracleParameter("pNumRepresentation", OracleDbType.Int32);
                procID.Direction = ParameterDirection.Input;
                procID.Value = numRepresentation;
                Oracmd.Parameters.Add(procID);

                // Pour remplir le DataSet, on déclare un OracleDataAdapter pour lequel
                // on passe notre OracleCommand qui contient TOUS les paramètres.
                OracleDataReader reader = Oracmd.ExecuteReader();

                reader.Read();
                string Salle = reader.GetString(0);
                string Spectacle = reader.GetString(1);
                DTP_DateHeure.Value = reader.GetDateTime(2); 

                int i = 0;
                foreach (String spectacle in CB_Spectacle.Items)
                {
                    if (spectacle == Spectacle)
                        CB_Spectacle.SelectedIndex = i;
                    else
                        i++;
                }
                i = 0;
                foreach (String salle in CB_Salle.Items)
                {
                    if (salle == Salle)
                        CB_Salle.SelectedIndex = i;
                    else
                        i++;
                }
            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message.ToString());
            }
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            if (nouveau)
            {
                Inserer();
            }
            else
            {
                Modifier();
            }
            this.Close();
        }

        private void Inserer()
        {
            try
            {
                OracleCommand oraAjout = new OracleCommand("PKG_BILLETS", conn);
                oraAjout.CommandText = "PKG_BILLETS.INSERT_REPRESENTATION";
                oraAjout.CommandType = CommandType.StoredProcedure;

                //Déclaration des paramettres
                OracleParameter procNumSpectacle = new OracleParameter("PSPECTACLE", OracleDbType.Int32);
                procNumSpectacle.Direction = ParameterDirection.Input;
                procNumSpectacle.Value = IDCBSpectacle[CB_Spectacle.SelectedIndex];
                oraAjout.Parameters.Add(procNumSpectacle);

                OracleParameter procNumSalle = new OracleParameter("PSALLE", OracleDbType.Int32);
                procNumSalle.Direction = ParameterDirection.Input;
                procNumSalle.Value = IDCBSalle[CB_Salle.SelectedIndex];
                oraAjout.Parameters.Add(procNumSalle);

                OracleParameter procDate = new OracleParameter("PDATE", OracleDbType.TimeStamp);
                procDate.Direction = ParameterDirection.Input;
                procDate.Value = DTP_DateHeure.Value;
                oraAjout.Parameters.Add(procDate);

                //Execution de la requête
                oraAjout.ExecuteNonQuery();
                //MessageBox.Show("Insertion réusit");
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Modifier()
        {
            try
            {
                OracleCommand oraAjout = new OracleCommand("PKG_BILLETS", conn);
                oraAjout.CommandText = "PKG_BILLETS.UPDATE_REPRESENTATION";
                oraAjout.CommandType = CommandType.StoredProcedure;

                //Déclaration des paramettres
                OracleParameter procNumRepresentation = new OracleParameter("PNUMREPRESENTATION", OracleDbType.Int32);
                procNumRepresentation.Direction = ParameterDirection.Input;
                procNumRepresentation.Value = numRepresentation;
                oraAjout.Parameters.Add(procNumRepresentation);

                OracleParameter procNumSpectacle = new OracleParameter("PNUMSPECTACLE", OracleDbType.Int32);
                procNumSpectacle.Direction = ParameterDirection.Input;
                procNumSpectacle.Value = IDCBSpectacle[CB_Spectacle.SelectedIndex];
                oraAjout.Parameters.Add(procNumSpectacle);

                OracleParameter procNumSalle = new OracleParameter("PSALLE", OracleDbType.Int32);
                procNumSalle.Direction = ParameterDirection.Input;
                procNumSalle.Value = IDCBSalle[CB_Salle.SelectedIndex];
                oraAjout.Parameters.Add(procNumSalle);

                OracleParameter procDate = new OracleParameter("PDATE", OracleDbType.TimeStamp);
                procDate.Direction = ParameterDirection.Input;
                procDate.Value = DTP_DateHeure.Value;
                oraAjout.Parameters.Add(procDate);

                //Execution de la requête
                oraAjout.ExecuteNonQuery();
                //MessageBox.Show("Insertion réusit");
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonRefresh()
        {
            if (CB_Salle.SelectedIndex >=0 && CB_Spectacle.SelectedIndex >=0)
            {
                BTN_OK.Enabled = true;
            }
            else
            {
                BTN_OK.Enabled = false;
            }
        }

        private void CB_Spectacle_CB_Salle_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonRefresh();
        }
    }
}
