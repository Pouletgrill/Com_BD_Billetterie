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
    public partial class ClientsFideles : Form
    {
        OracleConnection connection;
        DataSet dataSet = new DataSet();

        public ClientsFideles(OracleConnection conn)
        {
            InitializeComponent();
            connection = conn;
        }

        private void ClientsFideles_Load(object sender, EventArgs e)
        {
            ListerClientsFideles();
        }

        private void ListerClientsFideles()
        {
            OracleCommand cmd = new OracleCommand("LISTER", connection);
            cmd.CommandText = "PKG_BILLETS.LISTER_FIDELES";
            cmd.CommandType = CommandType.StoredProcedure;
            OracleParameter pResultat = new OracleParameter("PRESULTAT", OracleDbType.RefCursor);
            pResultat.Direction = ParameterDirection.ReturnValue;
            cmd.Parameters.Add(pResultat);

            OracleDataAdapter adapter = new OracleDataAdapter(cmd);

            if (dataSet.Tables.Contains("FIDELES"))
                dataSet.Tables["FIDELES"].Clear();

            adapter.Fill(dataSet, "FIDELES");
            adapter.Dispose();

            DGV_Fideles.DataSource = new BindingSource(dataSet, "FIDELES");
            int dgvwidth = (int)(DGV_Fideles.Width * 0.33f);
            DGV_Fideles.Columns[0].Width = DGV_Fideles.Columns[1].Width = DGV_Fideles.Columns[2].Width = dgvwidth;
            DGV_Fideles.Columns[0].DefaultCellStyle.Alignment = DGV_Fideles.Columns[1].DefaultCellStyle.Alignment = DGV_Fideles.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV_Fideles.Sort(DGV_Fideles.Columns[2], ListSortDirection.Descending);
        }
    }
}
