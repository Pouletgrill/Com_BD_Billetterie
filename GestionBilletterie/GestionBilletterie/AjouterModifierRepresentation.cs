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
      public AjouterModifierRepresentation(OracleConnection connexion, string ID)
      {
         conn = connexion;
         nouveau = true;
         InitializeComponent();
      }
      public AjouterModifierRepresentation(OracleConnection connexion, string IDspectacle, string IDrepresentation )
      {
         conn = connexion;
         nouveau = false;
         numRepresentation = IDrepresentation;
         numSpectacle = IDspectacle;
         InitializeComponent();
      }
   }
}
