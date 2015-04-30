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
    public partial class AjouterModifierSpectacle : Form
    {
        bool nouveau;
        OracleConnection conn = null;
        string numSpectacle = null;
        string categorieNum = null;
        public AjouterModifierSpectacle(OracleConnection connection)
        {
            conn = connection;
            nouveau = true;
            InitializeComponent();
        }
        public AjouterModifierSpectacle(OracleConnection connection, string ID)
        {
            conn = connection;
            numSpectacle = ID;
            nouveau = false;
            InitializeComponent();
        }

        private void AjouterModifierSpectacle_Load(object sender, EventArgs e)
        {
            LoadCategorie();
            if (!nouveau)//modification
            {
                LoadInfo();

            }
        }

        private void LoadCategorie()
        {
            try
            {
                OracleCommand inserer = new OracleCommand("INSERTION", conn);
                inserer.CommandText = "PKG_BILLETS.AFFICHER_CATEGORIE";
                inserer.CommandType = CommandType.StoredProcedure;

                OracleParameter pResultat = new OracleParameter("RESULTSET", OracleDbType.RefCursor);
                pResultat.Direction = ParameterDirection.ReturnValue;
                inserer.Parameters.Add(pResultat);

                OracleDataReader reader = inserer.ExecuteReader();

                while (reader.Read())
                {
                    CB_Categorie.Items.Add(reader.GetString(1));//.Items.Add(reader.GetString(0));
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Une érreur est survenue lors de l'initialisation des catégories");
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
                Oracmd.CommandText = "PKG_BILLETS.GET_MODIF_SPECTACLE";
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
                OracleDataReader reader = Oracmd.ExecuteReader();
                String Categorie = null;
                while (reader.Read())
                {
                    categorieNum = reader.GetInt32(0).ToString();
                    Categorie = reader.GetString(1);
                    TB_Titre.Text = reader.GetString(2);
                    TB_Artiste.Text = reader.GetString(3);
                } 
                int i = 0;
                    foreach (String categorie in CB_Categorie.Items)
                    {
                        if (categorie == Categorie)
                            CB_Categorie.SelectedIndex = i;
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
            //sauvegarde tout
            this.Close();
        }
    }
}
