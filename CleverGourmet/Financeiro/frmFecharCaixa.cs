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
    public partial class frmFecharCaixa : Padrao
    {
        Conexao conexao = new Conexao();
        public string codParceiro;
        string sql;
        public frmFecharCaixa()
        {
            InitializeComponent();
         }
        private void pesquisar_Venda()
        {
           
            conexao.Abre_Conexao();
            dgv_Resultado_vendas.Rows.Clear();
            tboxValorTotal.Text = "0,00";
            tboxQtdeVendas.Text = "0,00";



             sql = 
            " SELECT                    " +
            " V.ID     NUMVENDA,        " +
            " F.ID     NUMPREST,        " +
            " F.NUMDOC,                 " +
            " F.PREST,                  " +
            " V.IDCLIENTE,              " +
            " C.RAZAOSOCIAL,            " +
            " F.VALOR,                  " +
            " F.VLRDESC,                " +
            " F.VLRJUROS,               " +
            " F.VLRTOTAL,               " +
            " F.DTLANC,                 " +
            " F.DTVENC,                 " +
            " F.IDCOBRANCA,             " +
            " M.DESCRICAO,              " +
            " V.DATA,                   " +
            " V.HORA,                   " +
            " V.IDFUNC,                 " +
            " E.NOME,                   " +
            " V.IDCAIXA,                " +
            " X.ID     IDCAIXA,         " +
            " X.DATA,                   " +
            " X.SUPRIMENTO,             " +
            " X.STATUS                  " +
            "                           " +
            " FROM                      " +
            " TBFINANCEIRO      F,      " +
            " TBCLIENTE C,              " +
            " TBFUNCIONARIO E,          " +
            " TBCOBRANCA   M,           " +
            " TBCAIXA X                 " +
            "                           " +
            " WHERE                     " +
            "                           " +
             " F.IDVENDA = V.ID AND      " +
            " F.IDPARCEIRO = C.ID AND   " +
            " F.IDCOBRANCA = M.ID AND       " +
            " V.IDCAIXA = X.ID  /*AND  X.STATUS = 'ABERTO'*/ AND X.DATA = '"  +  Convert.ToDateTime(tboxDtini.Text).ToString("yyyy-MM-dd") + "' AND X.IDFUNC = " + codParceiro;

            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = sql;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();

            int o = 0;


            while (conexao.dataReader.Read())
            {
                dgv_Resultado_vendas.Rows.Add();
                dgv_Resultado_vendas.Rows[o].Cells["NUMVENDA"].Value     = conexao.dataReader["NUMVENDA"].ToString();
                dgv_Resultado_vendas.Rows[o].Cells["NUMPREST"].Value     = conexao.dataReader["NUMPREST"].ToString();
                dgv_Resultado_vendas.Rows[o].Cells["NUMDOC"].Value       = conexao.dataReader["NUMDOC"].ToString();
                dgv_Resultado_vendas.Rows[o].Cells["PREST"].Value        = conexao.dataReader["PREST"].ToString();
                dgv_Resultado_vendas.Rows[o].Cells["IDCLIENTE"].Value    = conexao.dataReader["IDCLIENTE"].ToString();
                dgv_Resultado_vendas.Rows[o].Cells["RAZAOSOCIAL"].Value  = conexao.dataReader["RAZAOSOCIAL"].ToString();
                dgv_Resultado_vendas.Rows[o].Cells["VLRTOTAL"].Value     = conexao.dataReader["VLRTOTAL"].ToString();
                dgv_Resultado_vendas.Rows[o].Cells["DTLANC"].Value       = conexao.dataReader["DTLANC"].ToString();
                dgv_Resultado_vendas.Rows[o].Cells["DTVENC"].Value       = conexao.dataReader["DTVENC"].ToString();
                dgv_Resultado_vendas.Rows[o].Cells["IDCOBRANCA"].Value      = conexao.dataReader["IDCOBRANCA"].ToString();
                dgv_Resultado_vendas.Rows[o].Cells["COBRANCA"].Value        = conexao.dataReader["DESCRICAO"].ToString();
                dgv_Resultado_vendas.Rows[o].Cells["STATUS"].Value       = conexao.dataReader["STATUS"].ToString();


                o++;
                dgv_Resultado_vendas.DefaultCellStyle.ForeColor = Color.Black;
            }
            decimal total = 0;
         
            for (int i = 0; i < dgv_Resultado_vendas.RowCount; i++)
            {
                total = total + Convert.ToDecimal(dgv_Resultado_vendas.Rows[i].Cells["VLRTOTAL"].Value.ToString());
               
                tboxValorTotal.Text = Conversor.converterMoeda(Convert.ToString(total));
                tboxQtdeVendas.Text = Conversor.converterMoeda(Convert.ToString(i + 1));
            }


            conexao.Fecha_Conexao();

        }
        private void btnPesquisarParceiro_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR FUNCIONÁRIO";
            a.RotinaOrigem = lbl_NomeRotina.Text;
            a.ShowDialog();
        }
        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            if (tboxParceiro.Text == "")
            {
                return;
            }
            pesquisar_Venda();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja fecha o caixa?", "Clever Sistemas",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    conexao.Abre_Conexao();

                    string SQLCunsultaEmpr = "UPDATE TBCAIXA SET " +
                                                      " STATUS = 'FECHADO'        " +
                                                      " WHERE  IDFUNC = " + codParceiro + " AND DATA = '" + Convert.ToDateTime(tboxDtini.Text).ToString("yyyy-MM-dd") + "'";

                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();

                    conexao.Fecha_Conexao();
                    if (MessageBox.Show("Caixa Fechado com Suscesso, Deseja imprimir o Relatório","Clever Sistemas",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                    }
                  pesquisar_Venda();
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ocorreu um erro no processo, favor entrar em contato com o suporte.  " + ex);
                }
            }
           
           
        }
        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                string sqli =
                     " SELECT                                       " +
                     " F.IDCOBRANCA,                                " +
                     " M.DESCRICAO,                                 " +
                     " V.IDFUNC,                                    " +
                     " C.NOME,                                      " +
                     " X.DATA,                                      " +
                     " COUNT(distinct(V.ID)) as QTDE,               " +
                     " SUM(REPLACE(F.VLRTOTAL, ',', '.')) as TOTAL  " +
                     "                                              " +
                     "                                              " +
                     " FROM                                         " +
                     " TBVENDA   V,                                 " +
                     " TBFINANCEIRO        F,                               " +
                     " TBFUNCIONARIO C,                                 " +
                     " TBCOBRANCA M,                                " +
                     " TBCAIXA     X                                " +
                     "                                              " +
                     " WHERE                                        " +
                     "                                              " +
                     "                                              " +
                     " F.IDVENDA = V.ID AND                         " +
                     " F.IDPARCEIRO = C.ID AND                      " +
                     " F.IDCOBRANCA = M.ID AND                      " +
                     " V.IDCAIXA = X.ID    /* AND  X.STATUS = 'ABERTO' */ AND X.DATA = '" + Convert.ToDateTime(tboxDtini.Text).ToString("yyyy-MM-dd") + "' AND X.IDFUNC = " + codParceiro +
                     "                                              " +
                     "                                              " +
                     " GROUP BY                                     " +
                     " F.IDCOBRANCA,                                " +
                     " M.DESCRICAO ,                                 " +
                     " V.IDFUNC ,                                   " +
                     " C.NOME,                                       " +
                     " X.DATA                                        ";



                frm_Relatorio a = new frm_Relatorio();
                a.Arquivo_rdlc = "Rpv_FechamentoCaixa.rdlc";

                a.Sql_Relatorio1 = sqli;
                a.Dataset_Relatorio1 = "DataSet_FecharCaixaResumo";



                a.ShowDialog();
            }
            catch (Exception)
            {
                              
            }
              
            
        }
    }
}
