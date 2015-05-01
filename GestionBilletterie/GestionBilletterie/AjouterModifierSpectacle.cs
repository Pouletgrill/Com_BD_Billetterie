using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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
        List<string> IDCategorie = new List<string>();
        string ClientId = "68674e2e8d54452";
        string PosterLocalURL = null;
        bool posterOriginel = true;

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
            ButtonRefresh();
        }
        private void ButtonRefresh()
        {
            if (TB_Artiste.Text != "" &&
               TB_Titre.Text != "" &&
               CB_Categorie.SelectedIndex >= 0)
            {
                if (nouveau && PosterLocalURL != null)
                    BTN_OK.Enabled = true;
                else if (nouveau && PosterLocalURL == null)
                    BTN_OK.Enabled = false;
                else
                    BTN_OK.Enabled = true;
            }
            else
            {
                BTN_OK.Enabled = false;
            }
        }
        private void LoadCategorie()
        {
            ButtonRefresh();
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
                    IDCategorie.Add(reader.GetInt32(0).ToString());
                }
            }
            catch (Exception)
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

                reader.Read();
                categorieNum = reader.GetInt32(0).ToString();
                Categorie = reader.GetString(1);
                TB_Titre.Text = reader.GetString(2);
                TB_Artiste.Text = reader.GetString(3);
                PosterLocalURL = reader.GetString(4);
                //Remplir le picture box
                System.IO.Stream stream = WebRequest.Create(PosterLocalURL).GetResponse().GetResponseStream();
                PB_Poster.BackgroundImage = Bitmap.FromStream(stream);


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
            if (nouveau)//Insert
            {
                Inserer();
            }
            else//Update
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
                oraAjout.CommandText = "PKG_BILLETS.INSERT_SPECTACLE";
                oraAjout.CommandType = CommandType.StoredProcedure;

                //Déclaration des paramettres
                OracleParameter procCategorie = new OracleParameter("PCATEGORIE", OracleDbType.Int32);
                procCategorie.Direction = ParameterDirection.Input;
                procCategorie.Value = IDCategorie[CB_Categorie.SelectedIndex];//retourne le premier caractère du string
                oraAjout.Parameters.Add(procCategorie);

                OracleParameter procTitre = new OracleParameter("PTITRE", OracleDbType.Varchar2, 50);
                procTitre.Direction = ParameterDirection.Input;
                procTitre.Value = TB_Titre.Text;
                oraAjout.Parameters.Add(procTitre);

                OracleParameter procArtiste = new OracleParameter("PARTISTE", OracleDbType.Varchar2, 50);
                procArtiste.Direction = ParameterDirection.Input;
                procArtiste.Value = TB_Artiste.Text;
                oraAjout.Parameters.Add(procArtiste);

                OracleParameter procAffiche = new OracleParameter("PAFFICHE", OracleDbType.Varchar2, 100);
                procAffiche.Direction = ParameterDirection.Input;
                procAffiche.Value = UploadImage(PosterLocalURL);
                oraAjout.Parameters.Add(procAffiche);

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
                OracleCommand oraModif = new OracleCommand("PKG_BILLETS", conn);
                oraModif.CommandText = "PKG_BILLETS.UPDATE_SPECTACLE";
                oraModif.CommandType = CommandType.StoredProcedure;

                //Déclaration des parametres
                OracleParameter procPNUM = new OracleParameter("PNUM", OracleDbType.Int32);
                procPNUM.Direction = ParameterDirection.Input;
                procPNUM.Value = numSpectacle;//retourne le premier caractère du string
                oraModif.Parameters.Add(procPNUM);

                OracleParameter procCategorie = new OracleParameter("PCATEGORIE", OracleDbType.Int32);
                procCategorie.Direction = ParameterDirection.Input;
                procCategorie.Value = IDCategorie[CB_Categorie.SelectedIndex];//retourne le premier caractère du string
                oraModif.Parameters.Add(procCategorie);

                OracleParameter procTitre = new OracleParameter("PTITRE", OracleDbType.Varchar2, 50);
                procTitre.Direction = ParameterDirection.Input;
                procTitre.Value = TB_Titre.Text;
                oraModif.Parameters.Add(procTitre);

                OracleParameter procArtiste = new OracleParameter("PARTISTE", OracleDbType.Varchar2, 50);
                procArtiste.Direction = ParameterDirection.Input;
                procArtiste.Value = TB_Artiste.Text;
                oraModif.Parameters.Add(procArtiste);

                OracleParameter procAffiche = new OracleParameter("PAFFICHE", OracleDbType.Varchar2, 100);
                procAffiche.Direction = ParameterDirection.Input;
                if (!posterOriginel)
                {
                    PosterLocalURL = UploadImage(PosterLocalURL);
                }
                procAffiche.Value = PosterLocalURL;
                oraModif.Parameters.Add(procAffiche);

                //Execution de la requête
                oraModif.ExecuteNonQuery();
                //MessageBox.Show("Insertion réusit");
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTN_Parcourir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                    PosterLocalURL = dlg.FileName;
                    PB_Poster.BackgroundImage = Image.FromFile(PosterLocalURL);
                    posterOriginel = false;
            }
            ButtonRefresh();
        }

        public string UploadImage(string image)
        {
            WebClient w = new WebClient();
            w.Headers.Add("Authorization", "Client-ID " + ClientId);
            System.Collections.Specialized.NameValueCollection Keys = new System.Collections.Specialized.NameValueCollection();
            try
            {
                Keys.Add("image", Convert.ToBase64String(File.ReadAllBytes(image)));
                byte[] responseArray = w.UploadValues("https://api.imgur.com/3/image", Keys);
                dynamic result = Encoding.ASCII.GetString(responseArray);
                System.Text.RegularExpressions.Regex reg = new System.Text.RegularExpressions.Regex("link\":\"(.*?)\"");
                Match match = reg.Match(result);
                string url = match.ToString().Replace("link\":\"", "").Replace("\"", "").Replace("\\/", "/");
                return url;
            }
            catch (Exception s)
            {
                MessageBox.Show("Something went wrong. " + s.Message); return "Failed!";
            }
        }

        private void Titre_Artiste_TextChanged(object sender, EventArgs e)
        {
            ButtonRefresh();
        }

    }
}
