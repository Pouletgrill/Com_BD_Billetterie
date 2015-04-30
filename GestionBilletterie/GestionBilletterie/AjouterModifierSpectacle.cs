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
      string ClientId = "68674e2e8d54452";
      string PosterURL;

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
            //Remplir le picture box
            System.IO.Stream stream = WebRequest.Create(reader.GetString(4)).GetResponse().GetResponseStream();
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
         this.Close();
      }

      private void BTN_Parcourir_Click(object sender, EventArgs e)
      {
         OpenFileDialog dlg = new OpenFileDialog();
         if (dlg.ShowDialog() == DialogResult.OK)
         {
            PosterURL = UploadImage(dlg.FileName);
            PB_Poster.BackgroundImage = Image.FromFile(dlg.FileName);
         }
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
         catch (Exception s) { MessageBox.Show("Something went wrong. " + s.Message); return "Failed!"; 
         } 
      }

   }
}
