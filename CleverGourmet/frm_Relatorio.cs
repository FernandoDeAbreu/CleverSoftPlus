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
    public partial class frm_Relatorio : Form
    {
        Conexao conexao = new Conexao();
        public string Arquivo_rdlc = ""; // Rpv_Funcionario_Lista.rdlc

        public string Sql_Relatorio1     = ""; // SQL Para relatorio
        public string Sql_Relatorio2     = ""; // SQL Para relatorio
        public string Sql_Relatorio3     = ""; // SQL Para relatorio
        public string Sql_Relatorio4     = ""; // SQL Para relatorio

        public string Dataset_Relatorio1 = ""; // DataSet_Funcionario_Lista
        public string Dataset_Relatorio2 = ""; // DataSet_Funcionario_Lista
        public string Dataset_Relatorio3 = ""; // DataSet_Funcionario_Lista
        public string Dataset_Relatorio4 = ""; // DataSet_Funcionario_Lista


        public string dtIni;
        public string dtFim;
       
        public string saldoAtual;
        public string saldoAnterior;

        public frm_Relatorio()
        {
            InitializeComponent();
        }
        public void carregar()
        {
            conexao.Abre_Conexao();

           

           // Rpv_Relatorios.LocalReport.ReportPath = @"C:\Users\ferna\OneDrive\Documentos\Clever\CleverSoft Igreja\CleverGourmet\Relatórios\" + Arquivo_rdlc;
           Rpv_Relatorios.LocalReport.ReportPath = Application.StartupPath + @"\Relatórios\" + Arquivo_rdlc;

            try
            {
                Rpv_Relatorios.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dtIni", dtIni));
                Rpv_Relatorios.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dtFim", dtFim));
            }
            catch (Exception)
            {
            }
            try
            {
                Rpv_Relatorios.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("saldoAtual", saldoAtual));
                Rpv_Relatorios.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("saldoAnterior",  saldoAnterior));
            }
            catch (Exception)
            {
            }

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

           
            
            conexao.dataReader.Close();

            conexao.Fecha_Conexao();

        

            this.Rpv_Relatorios.RefreshReport();
            Rpv_Relatorios.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            Rpv_Relatorios.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
        }
        private void Exporta_Report(string _Extensao)
        {
            RenderingExtension Extensao_Arquivo = null;
            string ext = string.Empty;
            switch (_Extensao)
            {
                case "PDF":
                    Extensao_Arquivo = Rpv_Relatorios.LocalReport.ListRenderingExtensions()[3];
                    ext = ".pdf";
                    break;
                case "CSV":
                    ext = ".csv";
                    break;
                case "XLSX":
                    Extensao_Arquivo = Rpv_Relatorios.LocalReport.ListRenderingExtensions()[1];
                    ext = ".xlsx";
                    break;
                case "MHTML":
                    ext = ".mhtml";
                    break;
                case "IMAGE":
                    ext = ".tif";
                    break;
                case "XML":
                    ext = ".xml";
                    break;
                case "DOCX":
                    Extensao_Arquivo = Rpv_Relatorios.LocalReport.ListRenderingExtensions()[5];
                    ext = ".docx";
                    break;
                case "HTML4.0":
                    ext = ".html";
                    break;
            }

            string _Ext = "*" + _Extensao.ToUpper() + " files (*." + _Extensao.ToLower() + ")|*." + _Extensao.ToLower();

            SaveFileDialog Arquivo = new SaveFileDialog();
            Arquivo.Filter = _Ext;
            Arquivo.FilterIndex = 2;
            Arquivo.RestoreDirectory = true;

            DialogResult msgbox = MessageBox.Show("Somente visualizar arquivo ? ", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (msgbox == DialogResult.Yes)
            {
              //  Arquivo.FileName = Application.StartupPath + @"\Relatórios\" + Arquivo_rdlc;
               Arquivo.FileName = Application.StartupPath  + @"\Temp\" + Path.GetFileName(Rpv_Relatorios.LocalReport.ReportPath).Replace(".rdlc", "") + "_" + DateTime.Now.ToShortDateString().Replace(@"/", "").Replace(":", "") + DateTime.Now.Millisecond.ToString() + "." + _Extensao.ToLower();

                Rpv_Relatorios.ExportDialog(Extensao_Arquivo, "", Arquivo.FileName);

                System.Diagnostics.Process.Start(Arquivo.FileName);
            }
            else
            {
                Arquivo.FileName = Path.GetFileName(Rpv_Relatorios.LocalReport.ReportPath).Replace(".rdlc", "");

                if (Arquivo.ShowDialog() == DialogResult.OK)
                    Rpv_Relatorios.ExportDialog(Extensao_Arquivo, "", Arquivo.FileName);
            }
        }

        private void frm_Relatorio_Load(object sender, EventArgs e)
        {
            carregar();
            //this.Rpv_Relatorios.RefreshReport();
        }

        private void bt_Imprimir_Click(object sender, EventArgs e)
        {
            Rpv_Relatorios.PrintDialog();
        }

        private void bt_Exporta_PDF_Click(object sender, EventArgs e)
        {
            Exporta_Report("PDF");
        }

        private void bt_Exporta_DOC_Click(object sender, EventArgs e)
        {
            Exporta_Report("DOCX");
        }

        private void bt_Exporta_XLS_Click(object sender, EventArgs e)
        {
            Exporta_Report("XLSX");

        }

        private void bt_Sair_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
