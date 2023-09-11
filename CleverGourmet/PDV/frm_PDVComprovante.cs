using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.OleDb;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace CleverSoft
{
    public partial class frm_PDVComprovante : Form
    {
        Conexao conexao = new Conexao();
        public string Arquivo_rdlc = ""; // Rpv_Funcionario_Lista.rdlc

        public string Sql_Relatorio1 = ""; // SQL Para relatorio
        public string Sql_Relatorio2 = ""; // SQL Para relatorio
        public string Sql_Relatorio3 = ""; // SQL Para relatorio
        public string Sql_Relatorio4 = ""; // SQL Para relatorio

        public string Dataset_Relatorio1 = ""; // DataSet_Funcionario_Lista
        public string Dataset_Relatorio2 = ""; // DataSet_Funcionario_Lista
        public string Dataset_Relatorio3 = ""; // DataSet_Funcionario_Lista
        public string Dataset_Relatorio4 = ""; // DataSet_Funcionario_Lista


        public string dtIni = "";
        public string dtFim = "";
        public frm_PDVComprovante()
        {
            InitializeComponent();
        }
        public void carregar()
        {
            conexao.Abre_Conexao();


         //  Rpv_Relatorios.LocalReport.ReportPath = @"C:\Users\ferna\OneDrive\Documentos\Clever\CleverGourmet\CleverGourmet\Relatórios\" + Arquivo_rdlc;
            Rpv_Relatorios.LocalReport.ReportPath = Application.StartupPath + @"\Relatórios\" + Arquivo_rdlc;


            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = Sql_Relatorio1;
            conexao.cmd.CommandType = CommandType.Text;
            conexao.dataReader = conexao.cmd.ExecuteReader();
            conexao.dataTable.Load(conexao.dataReader);
            ReportDataSource dataSource1 = new ReportDataSource(Dataset_Relatorio1, conexao.dataTable);


            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = Sql_Relatorio2;
            conexao.cmd.CommandType = CommandType.Text;
            conexao.dataReader = conexao.cmd.ExecuteReader();
            conexao.dataTable.Load(conexao.dataReader);
            ReportDataSource dataSource2 = new ReportDataSource(Dataset_Relatorio2, conexao.dataTable);


            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = Sql_Relatorio3;
            conexao.cmd.CommandType = CommandType.Text;
            conexao.dataReader = conexao.cmd.ExecuteReader();
            conexao.dataTable.Load(conexao.dataReader);
            ReportDataSource dataSource3 = new ReportDataSource(Dataset_Relatorio3, conexao.dataTable);

            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = Sql_Relatorio4;
            conexao.cmd.CommandType = CommandType.Text;
            conexao.dataReader = conexao.cmd.ExecuteReader();
            conexao.dataTable.Load(conexao.dataReader);
            ReportDataSource dataSource4 = new ReportDataSource(Dataset_Relatorio4, conexao.dataTable);



            Rpv_Relatorios.LocalReport.DataSources.Add(dataSource1);
            Rpv_Relatorios.LocalReport.DataSources.Add(dataSource2);
            Rpv_Relatorios.LocalReport.DataSources.Add(dataSource3);
            Rpv_Relatorios.LocalReport.DataSources.Add(dataSource4);

            Rpv_Relatorios.Clear();

            try
            {
                Rpv_Relatorios.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dtIni", dtIni));
                Rpv_Relatorios.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dtFim", dtFim));
            }
            catch (Exception)
            {
            }
            
            conexao.dataReader.Close();

            conexao.Fecha_Conexao();

        

            this.Rpv_Relatorios.RefreshReport();
            Rpv_Relatorios.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            Rpv_Relatorios.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
        }
      
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frm_PDVComprovante_Load(object sender, EventArgs e)
        {
            btn_Confirmar.Focus();

            carregar();
            btn_Confirmar.Focus();

        }
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                Rpv_Relatorios.PrintDialog();
                this.Close();
            }
            catch (Exception)
            {

              //  throw;
            }
           
        }
    }
}
