using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverSoft.Igreja
{
    public partial class frmRelatorioSede : Padrao
    {

        Conexao conexao = new Conexao();
        Conversor converter = new Conversor();
        public frmRelatorioSede()
        {
            InitializeComponent();
        }
        private void pesquisar_Receita()
        {
            conexao.Abre_Conexao();
            dgv_resultado_pesquisa.Rows.Clear();


            string SQLCunsultaEmpr =
                                "SELECT                 " +
                                "F.DTLANC,              " +
                                "F.IDPARCEIRO,    " +
                                "C.RAZAOSOCIAL,      " +
                                "SUM(CAST(REPLACE(F.VLRTOTAL, ',', '.') AS FLOAT)) as TOTAL " +
                                "FROM                             " +
                                "TBFINANCEIRO F,                  " +
                                "TBCLIENTE C               " +
                                "WHERE                            " +
                                "F.IDPARCEIRO = C.ID AND    " +
                                "F.DTPGTO IS NOT NULL AND    " +
                                "F.TIPO = 'R' AND DTLANC BETWEEN  '" + Conversor.converterDataUS(tboxDTIni.Text) + "' AND '" + Conversor.converterDataUS(tboxDtFim.Text) + "' " +
                                "GROUP BY                         " +
                                "F.DTLANC,                        " +
                                "F.IDPARCEIRO,                    " +
                                "C.RAZAOSOCIAL                    " +
                                "order by F.DTLANC                ";

            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();

            int o = 0;


            while (conexao.dataReader.Read())
            {
                dgv_resultado_pesquisa.Rows.Add();
                dgv_resultado_pesquisa.Rows[o].Cells["DTLANC"].Value           = Conversor.converterDataBR(conexao.dataReader["DTLANC"].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["CONTAGERENCIAL"].Value   = conexao.dataReader["RAZAOSOCIAL"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["VALOR"].Value            = Conversor.converterMoeda(conexao.dataReader["TOTAL"].ToString());
             //   dgv_resultado_pesquisa.DefaultCellStyle.ForeColor              = Color.Black;

                o++;
            }
            decimal valor = 0;
           
            for (int i = 0; i < dgv_resultado_pesquisa.RowCount; i++)
            {
                valor = valor + Convert.ToDecimal(dgv_resultado_pesquisa.Rows[i].Cells["VALOR"].Value.ToString());
             
                tboxTotalEntradas.Text = Double.Parse(Convert.ToString(valor)).ToString("N2");
            }


            conexao.Fecha_Conexao();

        }
        private void pesquisar_Despesa()
        {
            conexao.Abre_Conexao();
            dataGridView1.Rows.Clear();


            string SQLCunsultaEmpr =
                                "SELECT                 " +
                                "F.DTLANC,              " +
                                "F.IDCONTAGERENCIAL,    " +
                                "C.CONTAGERENCIAL,      " +
                                "SUM(CAST(REPLACE(F.VLRTOTAL, ',', '.') AS FLOAT)) as TOTAL " +
                                "FROM                             " +
                                "TBFINANCEIRO F,                  " +
                                "TBCONTAGERENCIAL C               " +
                                "WHERE                            " +
                                "F.IDCONTAGERENCIAL = C.ID AND    " +
                                "F.DTPGTO IS NOT NULL AND    " +
                                "F.TIPO = 'D' AND DTLANC BETWEEN  '" + Conversor.converterDataUS(tboxDTIni.Text) + "' AND '" + Conversor.converterDataUS(tboxDtFim.Text) + "' " +
                                "GROUP BY                         " +
                                "F.DTLANC,                        " +
                                "F.IDCONTAGERENCIAL,              " +
                                "C.CONTAGERENCIAL                 " +
                                "order by F.DTLANC                ";

            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();

            int o = 0;


            while (conexao.dataReader.Read())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[o].Cells["DTLANC_R"].Value           = Conversor.converterDataBR(conexao.dataReader["DTLANC"].ToString());
                dataGridView1.Rows[o].Cells["CONTAGERENCIAL_R"].Value   = conexao.dataReader["CONTAGERENCIAL"].ToString();
                dataGridView1.Rows[o].Cells["VALOR_R"].Value            = Conversor.converterMoeda(conexao.dataReader["TOTAL"].ToString());
             //   dgv_resultado_pesquisa.DefaultCellStyle.ForeColor              = Color.Black;

                o++;
            }
            decimal valor = 0;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                valor = valor + Convert.ToDecimal(dataGridView1.Rows[i].Cells["VALOR_R"].Value.ToString());

                tboxTotalSaida.Text = Double.Parse(Convert.ToString(valor)).ToString("N2");
            }


            conexao.Fecha_Conexao();

        }
        private void pesquisar_SaldoAtual()
        {
            conexao.Abre_Conexao();


            string SQLCunsultaEmpr =
                       "select * from vwSALDOATUAL";

            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();



            while (conexao.dataReader.Read())
            {
                tboxSaldoAtual.Text = conexao.dataReader[0].ToString();
            }
          
            conexao.Fecha_Conexao();

        }
        private void calcular_SaldoAnterior()
        {
            decimal entrada    = Convert.ToDecimal(tboxTotalEntradas.Text);
            decimal saida      = Convert.ToDecimal(tboxTotalSaida.Text);
            decimal saldoAtual = Convert.ToDecimal(tboxSaldoAtual.Text);
            decimal saldoAnterior ;

            saldoAnterior = saldoAtual - (entrada - saida);

            tboxSaldoAnterio.Text = Convert.ToString(saldoAnterior);
        }
        private void frmRelatorioSede_Load(object sender, EventArgs e)
        {
            pesquisar_Receita(); 
            pesquisar_Despesa();
            pesquisar_SaldoAtual();
            calcular_SaldoAnterior();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            tboxSaldoAnterio.Text = "0,00";
            tboxSaldoAtual.Text = "0,00";
            tboxTotalEntradas.Text = "0,00";
            tboxTotalSaida.Text = "0,00";


            pesquisar_Receita();
            pesquisar_Despesa();
            pesquisar_SaldoAtual();
            calcular_SaldoAnterior();
        }
        private void btn_Imprimir_Click(object sender, EventArgs e)
        {

                string SQLCunsultaEmpr =
                                "SELECT                 " +
                                "F.DTLANC,              " +
                                "F.TIPO,              " +
                                "F.IDCONTAGERENCIAL,    " +
                                "C.CONTAGERENCIAL,      " +
                                "SUM(CAST(REPLACE(F.VLRTOTAL, ',', '.') AS FLOAT)) as VLRTOTAL " +
                                "FROM                             " +
                                "TBFINANCEIRO F,                  " +
                                "TBCONTAGERENCIAL C               " +
                                "WHERE                            " +
                                "F.IDCONTAGERENCIAL = C.ID AND    " +
                                "F.DTPGTO IS NOT NULL AND    " +
                                "F.DTLANC BETWEEN  '" + Conversor.converterDataUS(tboxDTIni.Text) + "' AND '" + Conversor.converterDataUS(tboxDtFim.Text) + "' " +
                                "GROUP BY                         " +
                                "F.DTLANC,                        " +
                                "F.IDCONTAGERENCIAL,              " +
                                "C.CONTAGERENCIAL                 " +
                                "order by F.TIPO ASC, F.DTLANC        ";

                frm_Relatorio a = new frm_Relatorio();
                a.Arquivo_rdlc = "Rpv_RelatorioSede.rdlc";
                a.Sql_Relatorio1 = SQLCunsultaEmpr;
                a.Dataset_Relatorio1 = "DataSet_Relatorio_Sede";
                a.dtIni = tboxDTIni.Text;
                a.dtFim = tboxDtFim.Text;
                a.saldoAtual = tboxSaldoAtual.Text;
                a.saldoAnterior = tboxSaldoAnterio.Text;
                a.ShowDialog();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string SQLCunsultaEmpr =

            " SELECT * FROM vwRELATORIO_SEDE WHERE DTLANC BETWEEN  '" + Conversor.converterDataUS(tboxDTIni.Text) + "' AND '" + Conversor.converterDataUS(tboxDtFim.Text) + "' ";
          

            frm_Relatorio a = new frm_Relatorio();
            a.Arquivo_rdlc = "Rpv_RelatorioSede.rdlc";
            a.Sql_Relatorio1 = SQLCunsultaEmpr;
            a.Dataset_Relatorio1 = "DataSet_Relatorio_Sede";
            a.dtIni = tboxDTIni.Text;
            a.dtFim = tboxDtFim.Text;
            a.saldoAtual = tboxSaldoAtual.Text;
            a.saldoAnterior = tboxSaldoAnterio.Text;
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string SQLCunsultaEmpr =

          " SELECT * FROM vwRELATORIO_SEDE WHERE TIPO = 'R' AND DTLANC BETWEEN  '" + Conversor.converterDataUS(tboxDTIni.Text) + "' AND '" + Conversor.converterDataUS(tboxDtFim.Text) + "' ORDER BY RAZAOSOCIAL ";


            frm_Relatorio a = new frm_Relatorio();
            a.Arquivo_rdlc = "Rpv_RelatorioSede2.rdlc";
            a.Sql_Relatorio1 = SQLCunsultaEmpr;
            a.Dataset_Relatorio1 = "DataSet_Relatorio_Sede";
            a.dtIni = tboxDTIni.Text;
            a.dtFim = tboxDtFim.Text;
            a.saldoAtual = tboxSaldoAtual.Text;
            a.saldoAnterior = tboxSaldoAnterio.Text;
            a.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string SQLCunsultaEmpr =

         " SELECT * FROM vwRELATORIO_SEDE WHERE TIPO = 'R' AND DTLANC BETWEEN  '" + Conversor.converterDataUS(tboxDTIni.Text) + "' AND '" + Conversor.converterDataUS(tboxDtFim.Text) + "' ORDER BY RAZAOSOCIAL ";


            frm_Relatorio a = new frm_Relatorio();
            a.Arquivo_rdlc = "Rpv_RelatorioSede3.rdlc";
            a.Sql_Relatorio1 = SQLCunsultaEmpr;
            a.Dataset_Relatorio1 = "DataSet_Relatorio_Sede";
            a.dtIni = tboxDTIni.Text;
            a.dtFim = tboxDtFim.Text;
            a.saldoAtual = tboxSaldoAtual.Text;
            a.saldoAnterior = tboxSaldoAnterio.Text;
            a.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string SQLCunsultaEmpr =

            " SELECT * FROM vwRELATORIO_SEDE WHERE TIPO = 'R' AND DTLANC BETWEEN  '" + Conversor.converterDataUS(tboxDTIni.Text) + "' AND '" + Conversor.converterDataUS(tboxDtFim.Text) + "' ORDER BY RAZAOSOCIAL ";


            frm_Relatorio a = new frm_Relatorio();
            a.Arquivo_rdlc = "Rpv_RelatorioSede4.rdlc";
            a.Sql_Relatorio1 = SQLCunsultaEmpr;
            a.Dataset_Relatorio1 = "DataSet_Relatorio_Sede";
            a.dtIni = tboxDTIni.Text;
            a.dtFim = tboxDtFim.Text;
            a.saldoAtual = tboxSaldoAtual.Text;
            a.saldoAnterior = tboxSaldoAnterio.Text;
            a.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string SQLCunsultaEmpr =

           " SELECT * FROM vwRELATORIO_SEDE WHERE TIPO = 'R' AND DTLANC BETWEEN  '" + Conversor.converterDataUS(tboxDTIni.Text) + "' AND '" + Conversor.converterDataUS(tboxDtFim.Text) + "' ORDER BY RAZAOSOCIAL ";


            frm_Relatorio a = new frm_Relatorio();
            a.Arquivo_rdlc = "Rpv_RelatorioSede5.rdlc";
            a.Sql_Relatorio1 = SQLCunsultaEmpr;
            a.Dataset_Relatorio1 = "DataSet_Relatorio_Sede";
            a.dtIni = tboxDTIni.Text;
            a.dtFim = tboxDtFim.Text;
            a.saldoAtual = tboxSaldoAtual.Text;
            a.saldoAnterior = tboxSaldoAnterio.Text;
            a.ShowDialog();
        }
    }
}
