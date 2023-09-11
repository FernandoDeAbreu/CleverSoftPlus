using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverSoft
{
    class ConexaoLicenca
    {
        public OleDbConnection conexao = new OleDbConnection();
        public OleDbCommand cmd;
        public OleDbDataAdapter adapter = new OleDbDataAdapter();
        public OleDbDataReader dataReader;
        public DataSet dataSet = new DataSet();
        public DataTable dataTable = new DataTable();

        public void Abre_Conexao()
        {
            try
            {
                conexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source= " + Application.StartupPath + @"\Microsoft.MLICM.dll;Persist Security Info=False;");
                cmd = conexao.CreateCommand();
                conexao.Open();
                cmd = conexao.CreateCommand();
            }
            catch (Exception)
            {

                MessageBox.Show("Licença Corrompida entre em contato com o suporte.", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
           

        }
        public void Fecha_Conexao()
        {
            try
            {
                conexao.Close();
                conexao.Dispose();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
