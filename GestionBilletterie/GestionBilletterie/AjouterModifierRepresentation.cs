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
            MessageBox.Show(numSpectacle);
            if (!nouveau)
            {
                MessageBox.Show(numRepresentation);
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

        }

        private void Modifier()
        {

        }

        private void ButtonRefresh()
        {
            
        }
    }
}
