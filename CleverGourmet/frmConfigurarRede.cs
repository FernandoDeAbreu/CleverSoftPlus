using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace CleverSoft
{
    public partial class frmConfigurarRede : Padrao
    {
        public SQLiteCommand cmd;
        public SQLiteDataAdapter adapter = new SQLiteDataAdapter();
        public SQLiteDataReader dataReader;
        public DataSet dataSet = new DataSet();
        public DataTable dataTable = new DataTable();
         //  Rpv_Relatorios.LocalReport.ReportPath = @"C:\Users\ferna\OneDrive\Documentos\Clever\CleverGourmet\CleverGourmet\Relatórios\" + Arquivo_rdlc;
         // string diretorioDB = Application.StartupPath + @"\CleverDB.s3db;";
        public frmConfigurarRede()
        {
            InitializeComponent();
        }

        public SQLiteConnection conexao = new SQLiteConnection();
     
        public void Abre_Conexao()
        {
            conexao = new SQLiteConnection("Data Source= "  + textBox1.Text.Trim() + @"\CleverDB.s3db;");
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

        private void button1_Click(object sender, EventArgs e)
        {
   
            string SQLCunsultaEmpr;
            try
            {
                Abre_Conexao();

                SQLCunsultaEmpr = "SELECT COUNT(ID) FROM TBVENDA";
                cmd.Connection = conexao;
                cmd.CommandText = SQLCunsultaEmpr;
                cmd.ExecuteNonQuery();
                adapter.SelectCommand = cmd;
                adapter.Fill(dataSet, "PCPRODUT");
                dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    label2.Text = dataReader[0].ToString();
                }

                Fecha_Conexao();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao conectar ao Banco de dados");
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"net use Y: \\192.168.0.3\CleverSoft Plus");
        }
                  /*
                  -- Compartilha a pasta
                  net share "CleverSoft Plus=C:\CleverSoft Plus"
                  
                  -- Permitir Acesso
                  cacls "C:\CleverSoft Plus" /E /P Todos:C
                  
                  
                  -- Criar o Mapeamento de Rede
                  net use P: "\\192.168.0.3\CleverSoft Plus"
                  */
        private void frmConfigurarRede_Load(object sender, EventArgs e)
        {

            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {

                if (ip.AddressFamily == AddressFamily.Unspecified)
                {
                    textBox2.Text = ip.ToString();
                }
            }

        }
    }
}
