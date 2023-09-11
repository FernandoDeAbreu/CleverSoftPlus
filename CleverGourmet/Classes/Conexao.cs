using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace CleverSoft
{
    class Conexao
    {
        public SQLiteConnection conexao = new SQLiteConnection();
        public SQLiteCommand cmd;
        public SQLiteDataAdapter adapter = new SQLiteDataAdapter();
        public SQLiteDataReader dataReader;
        public DataSet dataSet = new DataSet();
        public DataTable dataTable = new DataTable();

        public void Abre_Conexao()
        {
            conexao = new SQLiteConnection("Data Source= " + Application.StartupPath + @"\CleverDB.s3db;");
            cmd = conexao.CreateCommand();
            conexao.Open();
            cmd = conexao.CreateCommand();

        }

        public void Fecha_Conexao()
        {
            try
            {
               

                conexao.Close();
              //  conexao.Dispose();
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
