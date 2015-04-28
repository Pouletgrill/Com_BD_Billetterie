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
    public partial class ImprimerBillets : Form
    {
        OracleConnection connection;
        DataSet dataSet = new DataSet();

        public ImprimerBillets(OracleConnection conn)
        {
            InitializeComponent();
            connection = conn;
        }

        private void ImprimerBillets_Load(object sender, EventArgs e)
        {
            AfficherBillets();
        }

        private void AfficherBillets()
        {
            OracleCommand cmd = new OracleCommand("LISTER", connection);
            cmd.CommandText = "PKG_BILLETS.LISTER_BILLETS";
            cmd.CommandType = CommandType.StoredProcedure;
            OracleParameter pResultat = new OracleParameter("PRESULTAT", OracleDbType.RefCursor);
            pResultat.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(pResultat);

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);

            if (dataSet.Tables.Contains("BILLETS"))
                dataSet.Tables["BILLETS"].Clear();

            adapter.Fill(dataSet, "BILLETS");
            adapter.Dispose();

            DGV_Billets.DataSource = new BindingSource(dataSet, "BILLETS");
        }
    }
}
