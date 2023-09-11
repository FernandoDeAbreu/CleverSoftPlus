using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverSoft
{
    public partial class frm_ExtratoConta : ModeloSimples
    {
        Conexao conexao = new Conexao();
        public string codBancoConta;
        string SQLCunsultaEmpr;
        string SQLCunsultaEmpr2;
        public frm_ExtratoConta()
        {
            InitializeComponent();
        }
        private void pesqusiar()
        {

             SQLCunsultaEmpr =      " SELECT                                                        " +
                                    " IDCONTA,                                                      " +
                                    " C.AGENCIA,                                                    " +
                                    " C.CODBANCO,                                                   " +
                                    " C.CONTA,                                                      " +
                                    " C.DESCRICAO,                                                  " +
                                    " DTLANC,                                                       " +
                                    " DTPGTO,                                                       " +
                                    " NUMDOC,                                                       " +
                                    " HISTORICO,                                                    " +
                                    " VLRTOTAL,                                                     " +
                                    " TIPO                                                          " +
                                    " FROM                                                          " +
                                    "  TBCR R,                                                      " +
                                    "  TBCONTA C                                                    " +
                                    " WHERE                                                         " +
                                    " R.IDCONTA = C.ID AND                                          " +
                                    " C.ID =   "+ codBancoConta +"   AND    " +
                                    " DTPGTO <> '' AND DTPGTO BETWEEN '" + tbox_dtIni.Text + "' AND '"+ tbox_dtFim.Text +"' " +
                                    "                                                               " +
                                    " UNION                                                         " +
                                    "                                                               " +
                                    " SELECT                                                        " +
                                    " IDCONTA,                                                      " +
                                    " C.AGENCIA,                                                    " +
                                    " C.CODBANCO,                                                   " +
                                    " C.CONTA,                                                      " +
                                    " C.DESCRICAO,                                                  " +
                                    " DTLANC,                                                       " +
                                    " DTPGTO,                                                       " +
                                    " NUMDOC,                                                       " +
                                    " HISTORICO,                                                    " +
                                    " VLRTOTAL,                                                     " +
                                    " TIPO                                                          " +
                                    " FROM                                                          " +
                                    "  TBCP P,                                                      " +
                                    "  TBCONTA C                                                    " +
                                    " WHERE                                                         " +
                                    " P.IDCONTA = C.ID AND                                          " +
                                    " C.ID =   "+ codBancoConta +"   AND    " +
                                    " DTPGTO <> ''  AND DTPGTO BETWEEN '" + tbox_dtIni.Text + "' AND '" + tbox_dtFim.Text + "' ";

             SQLCunsultaEmpr2 =     " SELECT                  " +
                                    " C.DESCRICAO,            " +
                                    " sum(VLRTOTAL) AS TOTAL, " +
                                    " TIPO   AS TIPOT         " +
                                    " FROM                    " +
                                    "  TBCR R,                " +
                                    "  TBCONTA C              " +
                                    " WHERE                   " +
                                    " R.IDCONTA = C.ID AND    " +
                                    " C.ID =   "+ codBancoConta +"   AND    " +
                                    " DTPGTO<> ''             " +
                                    "                         " +
                                    " UNION                   " +
                                    "                         " +
                                    " SELECT                  " +
                                    " C.DESCRICAO,            " +
                                    " sum(VLRTOTAL) AS TOTAL, " +
                                    " TIPO  AS TIPOT          " +
                                    " FROM                    " +
                                    "  TBCP P,                " +
                                    "  TBCONTA C              " +
                                    " WHERE                   " +
                                    " P.IDCONTA = C.ID AND    " +
                                    " C.ID =   "+ codBancoConta +"   AND    " +
                                    " DTPGTO <> ''            ";

        }

        private void btn_PesquisarBanco_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR BANCO / CONTA";
            a.RotinaOrigem = lbl_NomeRotina.Text;
            a.ShowDialog();
        }

        private void btn_pesquisar1_Click(object sender, EventArgs e)
        {
            pesqusiar();
            try
            {
                frm_Relatorio a = new frm_Relatorio();
                a.dtIni = this.tbox_dtIni.Text;
                a.dtFim = this.tbox_dtFim.Text;
                a.Arquivo_rdlc = "Rpv_ExtratoConta.rdlc";
                a.Sql_Relatorio1 = this.SQLCunsultaEmpr;
                a.Sql_Relatorio2 = this.SQLCunsultaEmpr2;
                a.Dataset_Relatorio1 = "DataSet_ExtratoConta";
                a.Dataset_Relatorio2 = "DataSet_SaldoConta";
                a.ShowDialog();
            }
            catch (Exception)
            {


            }
        }
    }
}
