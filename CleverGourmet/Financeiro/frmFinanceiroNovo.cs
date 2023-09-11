using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverSoft.Financeiro
{
    public partial class frmFinanceiroNovo : Padrao
    {

        Conexao conexao = new Conexao();

        public string pagarReceber;
        public string codParceiro;
        public string codBancoConta;
        public string codMoeda;
        public string codCategoria;
        public string codFilial = "1";

        string tipo;
        string tbParceiro;
        string SQLCunsultaEmpr;
        string limite;

        public frmFinanceiroNovo()
        {
            InitializeComponent();
        }

        private void gravar_Registro()
        {

            if (Convert.ToDecimal(tboxTotal.Text) == 0 )
            {
                MessageBox.Show("Informe o valor total da duplicata.", "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tboxTotal.Focus();
                return;
            }

            if (tboxParceiro.Text == "")
            {
                MessageBox.Show("Campo Parceiro é obrigatorio.", "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tboxParceiro.Focus();
                return;
            }

            if (tboxBancoConta.Text == "")
            {
                MessageBox.Show("Campo Banco / conta é obrigatorio.", "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tboxBancoConta.Focus();
                return;
            }

            if (tboxMoeda.Text == "")
            {
                MessageBox.Show("Campo Moeda é obrigatorio.", "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tboxMoeda.Focus();
                return;
            }

            if (tboxCategoria.Text == "")
            {
                MessageBox.Show("Campo Categoria é obrigatorio.", "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tboxCategoria.Focus();
                return;
            }


            // Gravar valor Extensso
           
              string  valor_Extenso = Conversor.EscreverExtenso(Convert.ToDecimal(tboxTotal.Text));
           
            //* fim gravar valor Extensso

            try
            {
                if (tboxlanc.Text == "")
                {
                    #region INSERT
                    conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = " INSERT INTO TBFINANCEIRO " +
                                                    " (TIPO                   " +
                                                    " ,IDFILIAL            " +
                                                    " ,IDPARCEIRO             " +
                                                    " ,IDMOEDA                " +
                                                    " ,IDCONTA                " +
                                                    " ,IDCONTAGERENCIAL            " +
                                                    " ,HISTORICO              " +
                                                    " ,NUMDOC                 " +
                                                    " ,DTLANC                 " +
                                                    " ,DTVENC                 " +
                                                    " ,DTCOMPETENCIA          " +
                                                    " ,VALOR                  " +
                                                    " ,VLRDESC                " +
                                                    " ,VLRJUROS               " +
                                                    " ,VLRTOTAL               " +
                                                    " ,VLREXTENSO)              " +
                                                    " VALUES                  " +
                                                    " (@TIPO                  " +
                                                    " ,@IDFILIAL              " +
                                                    " ,@IDPARCEIRO            " +
                                                    " ,@IDMOEDA               " +
                                                    " ,@IDCONTA               " +
                                                    " ,@IDCONTAGERENCIAL           " +
                                                    " ,@HISTORICO             " +
                                                    " ,@NUMDOC                " +
                                                    " ,@DTLANC                " +
                                                    " ,@DTVENC                " +
                                                    " ,@DTCOMPETENCIA         " +
                                                    " ,@VALOR                 " +
                                                    " ,@VLRDESC               " +
                                                    " ,@VLRJUROS              " +
                                                    " ,@VLRTOTAL              " +
                                                    " ,@VLREXTENSO)             ";


                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;           
                    conexao.cmd.Parameters.AddWithValue("TIPO",          tipo);
                    conexao.cmd.Parameters.AddWithValue("IDFILIAL",      codFilial);
                    conexao.cmd.Parameters.AddWithValue("IDPARCEIRO",    codParceiro);
                    conexao.cmd.Parameters.AddWithValue("IDMOEDA",       codMoeda);
                    conexao.cmd.Parameters.AddWithValue("IDCONTA",       codBancoConta);
                    conexao.cmd.Parameters.AddWithValue("IDCONTAGERENCIAL",   codCategoria);
                    conexao.cmd.Parameters.AddWithValue("HISTORICO",     tboxHistorico.Text);
                    conexao.cmd.Parameters.AddWithValue("NUMDOC",        tboxNumDoc.Text);
                    conexao.cmd.Parameters.AddWithValue("DTLANC",        Conversor.converterDataUS(DateTime.Now.ToShortDateString()));
                    conexao.cmd.Parameters.AddWithValue("DTVENC",        Conversor.converterDataUS(tboxDtVenc.Text));
                    conexao.cmd.Parameters.AddWithValue("DTCOMPETENCIA", Conversor.converterDataUS(tboxCompetencia.Text));
                    conexao.cmd.Parameters.AddWithValue("VALOR",         Conversor.converterMoeda(tboxValor.Text));
                    conexao.cmd.Parameters.AddWithValue("VLRDESC",       Conversor.converterMoeda(tboxDesconto.Text));
                    conexao.cmd.Parameters.AddWithValue("VLRJUROS",      Conversor.converterMoeda(tboxJuros.Text));
                    conexao.cmd.Parameters.AddWithValue("VLRTOTAL",      Conversor.converterMoeda(tboxTotal.Text));
                    conexao.cmd.Parameters.AddWithValue("VLREXTENSO",    valor_Extenso);


                    conexao.cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro realizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conexao.Fecha_Conexao();
                    #endregion
                }
                else
                {
                    #region UPDATE
                    conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = " UPDATE TBFINANCEIRO SET " +
                                                       "  TIPO           = @TIPO         " +
                                                       " ,IDFILIAL       = @IDFILIAL   " +
                                                       " ,IDPARCEIRO     = @IDPARCEIRO   " +
                                                       " ,IDMOEDA        = @IDMOEDA      " +
                                                       " ,IDCONTA        = @IDCONTA      " +
                                                       " ,IDCONTAGERENCIAL    = @IDCONTAGERENCIAL  " +
                                                       " ,HISTORICO      = @HISTORICO    " +
                                                       " ,NUMDOC         = @NUMDOC       " +
                                                       " ,DTLANC         = @DTLANC       " +
                                                       " ,DTVENC         = @DTVENC       " +
                                                       " ,DTCOMPETENCIA  = @DTCOMPETENCIA" +
                                                       " ,VALOR          = @VALOR        " +
                                                       " ,VLRDESC        = @VLRDESC      " +
                                                       " ,VLRJUROS       = @VLRJUROS     " +
                                                       " ,VLRTOTAL       = @VLRTOTAL    " +
                                                       " ,VLREXTENSO       = @VLREXTENSO    " +
                                                       " WHERE ID =  " + tboxlanc.Text;
                                                    


                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;           
                    conexao.cmd.Parameters.AddWithValue("TIPO",             tipo);
                    conexao.cmd.Parameters.AddWithValue("IDFILIAL",         codFilial);
                    conexao.cmd.Parameters.AddWithValue("IDPARCEIRO",       codParceiro);
                    conexao.cmd.Parameters.AddWithValue("IDMOEDA",          codMoeda);
                    conexao.cmd.Parameters.AddWithValue("IDCONTA",          codBancoConta);
                    conexao.cmd.Parameters.AddWithValue("IDCONTAGERENCIAL", codCategoria);
                    conexao.cmd.Parameters.AddWithValue("HISTORICO",        tboxHistorico.Text);
                    conexao.cmd.Parameters.AddWithValue("NUMDOC",           tboxNumDoc.Text);
                    conexao.cmd.Parameters.AddWithValue("DTLANC",           Conversor.converterDataUS(tboxDtLanc.Text));
                    conexao.cmd.Parameters.AddWithValue("DTVENC",           Conversor.converterDataUS(tboxDtVenc.Text));
                    conexao.cmd.Parameters.AddWithValue("DTCOMPETENCIA",    Conversor.converterDataUS(tboxCompetencia.Text));
                    conexao.cmd.Parameters.AddWithValue("VALOR",            Conversor.converterMoeda(tboxValor.Text));
                    conexao.cmd.Parameters.AddWithValue("VLRDESC",          Conversor.converterMoeda(tboxDesconto.Text));
                    conexao.cmd.Parameters.AddWithValue("VLRJUROS",         Conversor.converterMoeda(tboxJuros.Text));
                    conexao.cmd.Parameters.AddWithValue("VLRTOTAL",         Conversor.converterMoeda(tboxTotal.Text));
                    conexao.cmd.Parameters.AddWithValue("VLREXTENSO",       valor_Extenso);

                    conexao.cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro Atualizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conexao.Fecha_Conexao();

                    #endregion
                }
                limpar_Campos();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }




        }
        private void limpar_Campos()
        {
            tboxlanc.Text = "";
            codParceiro = "";
            tboxParceiro.Text = "";
            codMoeda = "";
            tboxMoeda.Text = "";
            codBancoConta = "";
            tboxBancoConta.Text = "";
            codCategoria = "";
            tboxCategoria.Text = "";
            tboxHistorico.Text = "";
            tboxNumDoc.Text = "";
            tboxDtLanc.Text = DateTime.Now.ToShortDateString();
            tboxDtVenc.Text = "";
            tboxCompetencia.Text = "";
            tboxPagamento.Text = "";
            tboxValor.Text = "0,00";
            tboxDesconto.Text = "0,00";
            tboxJuros.Text = "0,00";
            tboxTotal.Text = "0,00";


        }
        private void calcularTotal()
        {
            double valor = double.Parse(tboxValor.Text);
            double desconto = double.Parse(tboxDesconto.Text);
            double juros = double.Parse(tboxJuros.Text);
            double total;

            total = valor + juros - desconto;

            tboxTotal.Text = Convert.ToString(total);
            tboxTotal.Text = Conversor.converterMoeda(tboxTotal.Text);
        }

        private void btnPesquisarParceiro_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            if (pagarReceber == "CONTAS À PAGAR")
            {
                a.Text = "PESQUISAR FORNECEDOR";
                a.RotinaOrigem = "PESQUISAR FORNECEDOR";
            }

            if (pagarReceber == "CONTAS À RECEBER")
            {
                a.Text = "PESQUISAR CLIENTE";
                a.RotinaOrigem = "PESQUISAR CLIENTE";
            }

            a.ShowDialog();
        }
        private void btn_PesquisarCategoria_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR CONTA GERENCIAL";
            a.RotinaOrigem = "PESQUISAR CONTA GERENCIAL";
            a.ShowDialog();
        }
        private void btn_PesquisarMoeda_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR MOEDA";
            a.RotinaOrigem = "PESQUISAR MOEDA";
            a.ShowDialog();
        }
        private void btn_PesquisarBanco_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR BANCO";
            a.RotinaOrigem = "PESQUISAR BANCO";
            a.ShowDialog();
        }
        private void tboxValor_Leave(object sender, EventArgs e)
        {
            Conversor.converterMoeda(tboxValor.Text);
            calcularTotal();
        }
        private void tboxDesconto_Leave(object sender, EventArgs e)
        {
            Conversor.converterMoeda(tboxDesconto.Text);
            calcularTotal();
        }
        private void tboxJuros_Leave(object sender, EventArgs e)
        {
            Conversor.converterMoeda(tboxJuros.Text);
            calcularTotal();
        }
        private void tboxTotal_Leave(object sender, EventArgs e)
        {
            Conversor.converterMoeda(tboxTotal.Text);
            calcularTotal();
        }

        private void frmFinanceiroNovo_Load(object sender, EventArgs e)
        {
            this.Text = pagarReceber;
            lbl_NomeRotina.Text = pagarReceber;

            if (pagarReceber == "CONTAS À PAGAR")
            {
                tipo = "D";
                tbParceiro = "TBFORNECEDOR";
            }

            if (pagarReceber == "CONTAS À RECEBER")
            {
                tipo = "R";
                tbParceiro = "TBCLIENTE";
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar ação?","Clever Sistema",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            gravar_Registro();
        }
    }
}
