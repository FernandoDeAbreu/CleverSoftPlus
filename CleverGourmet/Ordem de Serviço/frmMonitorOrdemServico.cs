using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverSoft.Ordem_de_Serviço
{
    public partial class frmMonitorOrdemServico : Padrao
    {
        public int idFunc ;
        public string nomeFunc ;
        public string codParceiro ;
        string SQLCunsultaEmpr;
        Conexao conexao = new Conexao();
        public frmMonitorOrdemServico()
        {
            InitializeComponent();
        }

        private void pesquisarOrdemServico()
        {
            conexao.Abre_Conexao();
            dgv_resultado_pesquisa.Rows.Clear();

            string numOs;
            string cliente;

            if (tboxNumPedido.Text == "")
            {
                numOs = " not null ";
            }
            else
            {
                numOs = " = " + tboxNumPedido.Text;
            }

            if (codParceiro == null)
            {
                cliente = " not null ";
            }
            else
            {
                cliente = " = '" + codParceiro + "'";
            }



             SQLCunsultaEmpr =
                                " SELECT               " +
                                "  O.IDOS              " +
                                " ,O.NUMDOC           " +
                                " ,O.IDFUNCLANC        " +
                                " ,E.NOME              " +
                                " ,O.DTLANC            " +
                                " ,O.IDCLIENTE         " +
                                " ,C.RAZAOSOCIAL      " +
                                " ,C.CONDOMINIO         " +
                                " ,O.PRAZO             " +
                                " ,O.DTMEDICAO         " +
                                " ,O.DTFABRICACAO      " +
                                " ,O.DTART             " +
                                " ,O.DTINSTALACAO      " +
                                " ,O.DTFINALIZADO      " +
                                " ,O.OBS               " +
                                " FROM                 " +
                                " TBOS O,              " +
                                " TBFUNCIONARIO E,      " +
                                " TBCLIENTE C         " +
                                " WHERE                " +
                                " O.IDFUNCLANC = E.ID  AND" +
                                " C.ID = O.IDCLIENTE   AND" +
                                " O.IDOS   " + numOs + "  AND "+
                                " O.IDCLIENTE  " + cliente + " AND  "+
                                " O.DTLANC  BETWEEN '" + Convert.ToDateTime(tboxDtini.Text).ToString("yyyy-MM-dd") + 
                                           "'  AND  '" + Convert.ToDateTime(tboxDtfim.Text).ToString("yyyy-MM-dd") + "'";

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
                dgv_resultado_pesquisa.Rows[o].Cells["IDOS"].Value         = conexao.dataReader["IDOS"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["NUMDOC"].Value       = conexao.dataReader["NUMDOC"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["IDFUNCLANC"].Value   = conexao.dataReader["IDFUNCLANC"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["NOME"].Value         = conexao.dataReader["NOME"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["CONDOMINIO"].Value   = conexao.dataReader["CONDOMINIO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["DTLANC"].Value       = Convert.ToDateTime(conexao.dataReader["DTLANC"].ToString()).ToShortDateString();
                dgv_resultado_pesquisa.Rows[o].Cells["IDCLIENTE"].Value    = conexao.dataReader["IDCLIENTE"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["RAZAOSOCIAL"].Value    = conexao.dataReader["RAZAOSOCIAL"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["PRAZO"].Value        = conexao.dataReader["PRAZO"].ToString();
                try
                {
                    dgv_resultado_pesquisa.Rows[o].Cells["DTMEDICAO"].Value = Convert.ToDateTime(conexao.dataReader["DTMEDICAO"].ToString()).ToShortDateString();
                }
                catch (Exception)
                {}
                try
                {
                    dgv_resultado_pesquisa.Rows[o].Cells["DTFABRICACAO"].Value = Convert.ToDateTime(conexao.dataReader["DTFABRICACAO"].ToString()).ToShortDateString();
                }
                catch (Exception)
                {}
                try
                {
                    dgv_resultado_pesquisa.Rows[o].Cells["DTART"].Value = Convert.ToDateTime(conexao.dataReader["DTART"].ToString()).ToShortDateString();

                }
                catch (Exception)
                {}

                try
                {
                    dgv_resultado_pesquisa.Rows[o].Cells["DTINSTALACAO"].Value = Convert.ToDateTime(conexao.dataReader["DTINSTALACAO"].ToString()).ToShortDateString();
                }
                catch (Exception)
                {}

                try
                {
                    dgv_resultado_pesquisa.Rows[o].Cells["DTFINALIZADO"].Value = Convert.ToDateTime(conexao.dataReader["DTFINALIZADO"].ToString()).ToShortDateString();
                }
                catch (Exception)
                {}
                dgv_resultado_pesquisa.Rows[o].Cells["OBS"].Value          = conexao.dataReader["OBS"].ToString();
              

                dgv_resultado_pesquisa.DefaultCellStyle.ForeColor = Color.Black;

                o++;
            }
            if (o == 0)
            {
                MessageBox.Show("Nenhum produto cadastrado com os dados informados", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            conexao.Fecha_Conexao();
        }
        private void frmMonitorOrdemServico_Load(object sender, EventArgs e)
        {
            // iniciarForm();
            tboxDtini.Text = Convert.ToString(Convert.ToDateTime(tboxDtini.Text).AddDays(-7));
            pesquisarOrdemServico();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja iniciar nova Ordem de serviço", "Clever Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmOrdemServico a = new frmOrdemServico();
                a.lbl_Funcionario.Text = Convert.ToString(idFunc) + " - " + nomeFunc;
                a.idFunc = idFunc;
                a.novoEditar = "Novo";
                a.ShowDialog();
                pesquisarOrdemServico();
            }
           
        }
        private void dgv_resultado_pesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmOrdemServico a = new frmOrdemServico();
            a.lbl_Funcionario.Text = Convert.ToString(idFunc) + " - " + nomeFunc;
            a.idFunc = idFunc;
            a.novoEditar = "Editar";
            a.tboxNumOS.Text  = dgv_resultado_pesquisa.CurrentRow.Cells["IDOS"].Value.ToString();
            a.tboxNumDoc.Text  = dgv_resultado_pesquisa.CurrentRow.Cells["NUMDOC"].Value.ToString();
            a.tboxDtLanc.Text     = Convert.ToDateTime(dgv_resultado_pesquisa.CurrentRow.Cells["DTLANC"].Value.ToString()).ToShortDateString();
            a.tboxPrazo.Text      = dgv_resultado_pesquisa.CurrentRow.Cells["PRAZO"].Value.ToString();
            a.codParceiro         = dgv_resultado_pesquisa.CurrentRow.Cells["IDCLIENTE"].Value.ToString();
            a.tboxParceiro.Text   = dgv_resultado_pesquisa.CurrentRow.Cells["IDCLIENTE"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["RAZAOSOCIAL"].Value.ToString();

            if (dgv_resultado_pesquisa.CurrentRow.Cells["DTMEDICAO"].Value != null)
            {
                a.dtMedicao = Convert.ToDateTime(dgv_resultado_pesquisa.CurrentRow.Cells["DTMEDICAO"].Value.ToString()).ToString("yyyy-MM-dd");
                a.tboxDtMedicao.Text = dgv_resultado_pesquisa.CurrentRow.Cells["DTMEDICAO"].Value.ToString();
                a.cboxMedicao.Checked = true;

            }

            if (dgv_resultado_pesquisa.CurrentRow.Cells["DTFABRICACAO"].Value != null)
            {
                a.dtFabricao = Convert.ToDateTime(dgv_resultado_pesquisa.CurrentRow.Cells["DTFABRICACAO"].Value.ToString()).ToString("yyyy-MM-dd");
                a.tboxDtFabricacao.Text = dgv_resultado_pesquisa.CurrentRow.Cells["DTFABRICACAO"].Value.ToString();
                a.cboxFabricacao.Checked = true;
            }

            if (dgv_resultado_pesquisa.CurrentRow.Cells["DTART"].Value != null)
            {
                a.dtART = Convert.ToDateTime(dgv_resultado_pesquisa.CurrentRow.Cells["DTART"].Value.ToString()).ToString("yyyy-MM-dd");
                a.tboxDtArt.Text = dgv_resultado_pesquisa.CurrentRow.Cells["DTART"].Value.ToString();
                a.cboxART.Checked = true;
            }

            if (dgv_resultado_pesquisa.CurrentRow.Cells["DTINSTALACAO"].Value != null)
            {
                a.dtInstalacao = Convert.ToDateTime(dgv_resultado_pesquisa.CurrentRow.Cells["DTINSTALACAO"].Value.ToString()).ToString("yyyy-MM-dd");
                a.tboxDtInstalacao.Text = dgv_resultado_pesquisa.CurrentRow.Cells["DTINSTALACAO"].Value.ToString();
                a.cboxInstalacao.Checked = true;
            }
            if (dgv_resultado_pesquisa.CurrentRow.Cells["DTFINALIZADO"].Value != null)
            {
                a.dtFinalizado = Convert.ToDateTime(dgv_resultado_pesquisa.CurrentRow.Cells["DTFINALIZADO"].Value.ToString()).ToString("yyyy-MM-dd");
                a.tboxDtFinalizacao.Text = dgv_resultado_pesquisa.CurrentRow.Cells["DTFINALIZADO"].Value.ToString();
                a.cboxFinalizado.Checked = true;
            }

            a.ShowDialog();
            pesquisarOrdemServico();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisarOrdemServico();
        }
        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.RotinaOrigem = "PESQUISAR CLIENTE";
            a.ShowDialog();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Abre_Conexao();
                string SQLCunsultaEmpr = " DELETE FROM TBOS_ITENS WHERE IDPEDIDO = @IDPEDIDO ";
                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;
                conexao.cmd.Parameters.AddWithValue("IDPEDIDO", dgv_resultado_pesquisa.CurrentRow.Cells["IDOS"].Value.ToString());

                conexao.cmd.ExecuteNonQuery();

                conexao.Fecha_Conexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                conexao.Abre_Conexao();
                string SQLCunsultaEmpr = " DELETE FROM TBOS WHERE IDOS = @IDOS ";
                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;
                conexao.cmd.Parameters.AddWithValue("IDOS", dgv_resultado_pesquisa.CurrentRow.Cells["IDOS"].Value.ToString());

                conexao.cmd.ExecuteNonQuery();

                conexao.Fecha_Conexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                conexao.Abre_Conexao();
                string SQLCunsultaEmpr = " DELETE FROM TBCP WHERE IDOS = @IDOS ";
                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;
                conexao.cmd.Parameters.AddWithValue("IDOS", dgv_resultado_pesquisa.CurrentRow.Cells["IDOS"].Value.ToString());

                conexao.cmd.ExecuteNonQuery();

                conexao.Fecha_Conexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                conexao.Abre_Conexao();
                string SQLCunsultaEmpr = " DELETE FROM TBCR WHERE IDOS = @IDOS ";
                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;
                conexao.cmd.Parameters.AddWithValue("IDOS", dgv_resultado_pesquisa.CurrentRow.Cells["IDOS"].Value.ToString());

                conexao.cmd.ExecuteNonQuery();

                conexao.Fecha_Conexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                conexao.Abre_Conexao();
                string SQLCunsultaEmpr = " DELETE FROM TBOS_PENDENCIA WHERE IDOS = @IDOS ";
                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;
                conexao.cmd.Parameters.AddWithValue("IDOS", dgv_resultado_pesquisa.CurrentRow.Cells["IDOS"].Value.ToString());

                conexao.cmd.ExecuteNonQuery();

                conexao.Fecha_Conexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            pesquisarOrdemServico();
        }
        private void btnPendencia_Click(object sender, EventArgs e)
        {
            Ordem_de_Serviço.frmLancaPendencia a = new frmLancaPendencia();
            a.tboxNumPedido.Text = dgv_resultado_pesquisa.CurrentRow.Cells["IDOS"].Value.ToString();
            a.tboxNumDoc.Text = dgv_resultado_pesquisa.CurrentRow.Cells["NUMDOC"].Value.ToString();
            a.incluirEditar = "Novo";
            a.ShowDialog();
        }
        private void btnListaPendencia_Click(object sender, EventArgs e)
        {
            Ordem_de_Serviço.frmPendencia a = new frmPendencia();
            a.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           string sqlOs =
                                " SELECT               " +
                                "  O.IDOS              " +
                                " ,O.NUMDOC            " +
                                " ,O.IDFUNCLANC        " +
                                " ,E.NOME              " +
                                " ,O.DTLANC            " +
                                " ,O.IDCLIENTE         " +
                                " ,C.RAZAOSOCIAL       " +
                                " ,C.CONDOMINIO        " +
                                " ,O.PRAZO             " +
                                " ,O.DTMEDICAO         " +
                                " ,O.DTFABRICACAO      " +
                                " ,O.DTART             " +
                                " ,O.DTINSTALACAO      " +
                                " ,O.DTFINALIZADO      " +
                                " ,O.OBS               " +
                                " FROM                 " +
                                " TBOS O,              " +
                                " TBFUNCIONARIO E,      " +
                                " TBCLIENTE C         " +
                                " WHERE                " +
                                " O.IDFUNCLANC = E.ID  AND" +
                                " C.ID = O.IDCLIENTE   AND" +
                                " O.IDOS  = " +  dgv_resultado_pesquisa.CurrentRow.Cells["IDOS"].Value.ToString();

            string sqlItens = "SELECT           " +
                           "  I.SEQ       " +
                           " ,I.IDPEDIDO  " +
                           " ,I.CODPROD   " +
                           " ,P.DESCRICAO " +
                           " ,P.CODAUXILIAR " +
                           " ,P.MEDIDA " +
                           " ,I.QTDE      " +
                           " ,I.PCUSTO    " +
                           " ,I.DESCONTO  " +
                           " ,I.TOTAL     " +
                            " FROM          " +
                           " TBOS_ITENS I,     " +
                           " TBPRODUTO  P      " +
                           "WHERE       " +
                           " I.CODPROD = P.ID AND " +
                           " I.IDPEDIDO =  " + dgv_resultado_pesquisa.CurrentRow.Cells["IDOS"].Value.ToString();

            string sqlContaReceber = " SELECT                    " +
                                   "  F.IDMOEDA               " +
                                   " ,M.MOEDA                 " +
                                   " ,F.IDCONTA               " +
                                   " ,C.DESCRICAO AS CONTA    " +
                                   " ,F.DTVENC                " +
                                   " ,F.VLRTOTAL              " +
                                   " ,F.VLREXTENSO            " +
                                   " FROM                     " +
                                   " TBCR              F,     " +
                                   " TBCONTAGERENCIAL  G,     " +
                                   " TBCONTA           C,     " +
                                   " TBMOEDA           M,     " +
                                   " TBFILIAL          E,     " +
                                   " TBCLIENTE          P     " +
                                   " WHERE                    " +
                                   " F.IDCONTAGERENCIAL = G.ID  AND" +
                                   " F.IDFILIAL    = E.ID  AND" +
                                   " F.IDCONTA = C.ID      AND" +
                                   " F.IDMOEDA = M.ID      AND" +
                                   " F.IDPARCEIRO = P.ID   AND" +
                                   " F.TIPO =  'C'         AND IDOS = " + dgv_resultado_pesquisa.CurrentRow.Cells["IDOS"].Value.ToString();


           string sqlDespesasAdicionais = " SELECT                    " +
                                    " F.IDPARCEIRO            " +
                                    " ,P.RAZAOSOCIAL           " +
                                    " ,F.IDCONTAGERENCIAL      " +
                                    " ,G.CONTAGERENCIAL        " +
                                    " ,F.DTLANC                " +
                                    " ,F.DTVENC                " +
                                    " ,F.DTCOMPETENCIA         " +
                                    " ,F.DTPGTO                " +
                                    " ,F.VLRTOTAL              " +
                                    " FROM                     " +
                                    " TBCP              F,     " +
                                    " TBCONTAGERENCIAL  G,     " +
                                    " TBCONTA           C,     " +
                                    " TBMOEDA           M,     " +
                                    " TBFILIAL          E,     " +
                                    " TBFORNECEDOR       P     " +
                                    " WHERE                    " +
                                    " F.IDCONTAGERENCIAL = G.ID  AND" +
                                    " F.IDFILIAL    = E.ID  AND" +
                                    " F.IDCONTA = C.ID      AND" +
                                    " F.IDMOEDA = M.ID      AND" +
                                    " F.IDPARCEIRO = P.ID   AND" +
                                    " F.STATUS IS NULL      AND" +
                                    " F.TIPO =  'D'      AND IDOS = " + dgv_resultado_pesquisa.CurrentRow.Cells["IDOS"].Value.ToString();


            frm_Relatorio a = new frm_Relatorio();
                a.Arquivo_rdlc   = "Rpv_OrdemServico.rdlc";
                a.Sql_Relatorio1  = sqlOs;
                a.Sql_Relatorio2 = sqlItens;
                a.Sql_Relatorio3 = sqlContaReceber;
                a.Sql_Relatorio4 = sqlDespesasAdicionais;
                
                a.Dataset_Relatorio1 = "DataSet_OsCabecalho";
                a.Dataset_Relatorio2 = "DataSet_OsItens";
                a.Dataset_Relatorio3 = "DataSet_OsContaReceber";
                a.Dataset_Relatorio4 = "DataSet_OsDespesasAdicionais";
                a.ShowDialog();
            
        }
    }
}
