using System;
using System.Data;
using System.Windows.Forms;

namespace CleverSoft.Igreja
{
    public partial class frmNovaContribuicao : Form
    {
        private Conexao conexao = new Conexao();
        private Conversor converter = new Conversor();
        public string codFilial = "1";
        public string codParceiro;
        private string codContaGerencial;
        private string codMoeda;
        private string codConta;
        private string codCobranca;
        private string contribuicaoId;

        public frmNovaContribuicao()
        {
            InitializeComponent();
        }

        private void CarregarCombox_Contribuicao()
        {
            conexao.Abre_Conexao();

            string SQLCunsultaEmpr = "SELECT * FROM TBCONTRIBUICAO";

            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;

            DataTable dtResultado = new DataTable();
            dtResultado.Clear();//o ponto mais importante (limpa a table antes de preenche-la)
            cboxContribuicao.DataSource = null;
            conexao.adapter.Fill(dtResultado);
            cboxContribuicao.DataSource = dtResultado;
            cboxContribuicao.ValueMember = "ID";
            cboxContribuicao.DisplayMember = "DESCRICAO";
            cboxContribuicao.SelectedItem = "";
            cboxContribuicao.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.

            conexao.Fecha_Conexao();

        }

        private void ObterContribuicaoId()
        {
            conexao.Abre_Conexao();

            string sql = "SELECT * FROM TBCONTRIBUICAO WHERE DESCRICAO = '" + cboxContribuicao.Text + "'";

            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = sql;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();

            while (conexao.dataReader.Read())
            {
                contribuicaoId = conexao.dataReader["ID"].ToString();
            }

            conexao.Fecha_Conexao();
        }

        private void CarregarCombox_FormaPagamento()
        {
            conexao.Abre_Conexao();

            string SQLCunsultaEmpr = "SELECT * FROM TBCOBRANCA WHERE DTEXCLUSAO IS NULL ";

            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;

            DataTable dtResultado = new DataTable();
            dtResultado.Clear();//o ponto mais importante (limpa a table antes de preenche-la)
            cboxFormaPagamento.DataSource = null;
            conexao.adapter.Fill(dtResultado);
            cboxFormaPagamento.DataSource = dtResultado;
            cboxFormaPagamento.ValueMember = "ID";
            cboxFormaPagamento.DisplayMember = "DESCRICAO";
            cboxFormaPagamento.SelectedItem = "";
            cboxFormaPagamento.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.

            conexao.Fecha_Conexao();
        }

        private void ObterFormaPagamento()
        {
            conexao.Abre_Conexao();

            string sql = "SELECT * FROM TBCOBRANCA WHERE DESCRICAO = '" + cboxFormaPagamento.Text + "'";

            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = sql;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();

            while (conexao.dataReader.Read())
            {
                codCobranca = conexao.dataReader["ID"].ToString();
                codMoeda = conexao.dataReader["IDMOEDA"].ToString();
                codConta = conexao.dataReader["IDCONTA"].ToString();
            }

            conexao.Fecha_Conexao();
        }

        private void Gravar_Registro()
        {
            ObterFormaPagamento();
            ObterContribuicaoId();

            if (Convert.ToDecimal(tboxValor.Text) <= 0)
            {
                MessageBox.Show("Não é possivel lançar o valor informado", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string valor_Extenso = Conversor.EscreverExtenso(Convert.ToDecimal(tboxValor.Text));

            try
            {
                #region INSERT

                conexao.Abre_Conexao();
                string SQLCunsultaEmpr = " INSERT INTO TBFINANCEIRO " +
                                                " (TIPO                   " +
                                                " ,IDFILIAL            " +
                                                " ,IDPARCEIRO             " +
                                                " ,IDMOEDA                " +
                                                " ,IDCONTA                " +
                                                " ,IDCOBRANCA               " +
                                                " ,IDCONTAGERENCIAL            " +
                                                " ,IDCONTRIBUICAO         " +
                                                " ,HISTORICO              " +
                                                " ,NUMDOC                 " +
                                                " ,DTLANC                 " +
                                                " ,DTVENC                 " +
                                                " ,DTPGTO              " +
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
                                                " ,@IDCOBRANCA            " +
                                                " ,@IDCONTAGERENCIAL      " +
                                                " ,@IDCONTRIBUICAO        " +
                                                " ,@HISTORICO             " +
                                                " ,@NUMDOC                " +
                                                " ,@DTLANC                " +
                                                " ,@DTVENC                " +
                                                " ,@DTPGTO                " +
                                                " ,@DTCOMPETENCIA         " +
                                                " ,@VALOR                 " +
                                                " ,@VLRDESC               " +
                                                " ,@VLRJUROS              " +
                                                " ,@VLRTOTAL              " +
                                                " ,@VLREXTENSO)             ";

                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;
                conexao.cmd.Parameters.AddWithValue("TIPO", "R");
                conexao.cmd.Parameters.AddWithValue("IDFILIAL", codFilial);
                conexao.cmd.Parameters.AddWithValue("IDPARCEIRO", codParceiro);
                conexao.cmd.Parameters.AddWithValue("IDMOEDA", codMoeda);
                conexao.cmd.Parameters.AddWithValue("IDCONTA", codConta);
                conexao.cmd.Parameters.AddWithValue("IDCOBRANCA", codConta);
                conexao.cmd.Parameters.AddWithValue("IDCONTAGERENCIAL", codContaGerencial);
                conexao.cmd.Parameters.AddWithValue("IDCONTRIBUICAO", contribuicaoId);
                conexao.cmd.Parameters.AddWithValue("HISTORICO", "REF.: A CONTRIBUIÇÃO VOLUNTÁRIA (" + cboxContribuicao.Text + ")");
                conexao.cmd.Parameters.AddWithValue("NUMDOC", "0000");
                conexao.cmd.Parameters.AddWithValue("DTLANC", Conversor.converterDataUS(tboxDtLanc.Text));
                conexao.cmd.Parameters.AddWithValue("DTVENC", Conversor.converterDataUS(tboxDtLanc.Text));
                conexao.cmd.Parameters.AddWithValue("DTCOMPETENCIA", Conversor.converterDataUS(tboxDtLanc.Text));
                conexao.cmd.Parameters.AddWithValue("DTPGTO", Conversor.converterDataUS(tboxDtLanc.Text));
                conexao.cmd.Parameters.AddWithValue("VALOR", Conversor.converterMoeda(tboxValor.Text));
                conexao.cmd.Parameters.AddWithValue("VLRDESC", Conversor.converterMoeda("0,00"));
                conexao.cmd.Parameters.AddWithValue("VLRJUROS", Conversor.converterMoeda("0,00"));
                conexao.cmd.Parameters.AddWithValue("VLRTOTAL", Conversor.converterMoeda(tboxValor.Text));
                conexao.cmd.Parameters.AddWithValue("VLREXTENSO", valor_Extenso);

                conexao.cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Fecha_Conexao();

                #endregion INSERT

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Relatorio()
        {
            try
            {
                string SQLCunsultaEmpr = " SELECT                    " +
                                          "  F.ID                    " +
                                          " ,F.IDFILIAL              " +
                                          " ,E.UF                    " +
                                          " ,E.CIDADE                " +
                                          " ,F.TIPO                  " +
                                          " ,F.IDPARCEIRO            " +
                                          " ,P.RAZAOSOCIAL           " +
                                          " ,F.IDMOEDA               " +
                                          " ,M.MOEDA                 " +
                                          " ,F.IDCONTA               " +
                                          " ,C.DESCRICAO AS CONTA    " +
                                          " ,F.IDCONTAGERENCIAL      " +
                                          " ,G.CONTAGERENCIAL        " +
                                          " ,F.HISTORICO             " +
                                          " ,F.NUMDOC                " +
                                          " ,F.DTLANC                " +
                                          " ,F.DTVENC                " +
                                          " ,F.DTCOMPETENCIA         " +
                                          " ,F.DTPGTO                " +
                                          " ,F.VALOR                 " +
                                          " ,F.VLRDESC               " +
                                          " ,F.VLRJUROS              " +
                                          " ,F.VLRTOTAL              " +
                                          " ,F.VLREXTENSO            " +
                                          " ,F.IDVENDA               " +
                                          " FROM                     " +
                                          " TBFINANCEIRO       F,    " +
                                          " TBCONTAGERENCIAL   G,    " +
                                          " TBCONTA            C,    " +
                                          " TBMOEDA            M,    " +
                                          " TBFILIAL           E,    " +
                                          " TBCLIENTE          P     " +
                                          " WHERE                    " +
                                          " F.IDCONTAGERENCIAL = G.ID  AND" +
                                          " F.IDFILIAL    = E.ID  AND" +
                                          " F.IDCONTA = C.ID      AND" +
                                          " F.IDMOEDA = M.ID      AND" +
                                          " F.IDPARCEIRO = P.ID   AND" +
                                          " F.STATUS IS NULL      AND" +
                                          " F.TIPO = 'R'  AND P.ID = " + codParceiro + " AND F.ID = (SELECT MAX(ID)FROM TBFINANCEIRO)";

                frm_PDVComprovante a = new frm_PDVComprovante();
                a.Arquivo_rdlc = "Rpv_Recibo_Dizimo.rdlc";
                a.Sql_Relatorio1 = SQLCunsultaEmpr;

                a.Dataset_Relatorio1 = "DataSet_CR";

                a.ShowDialog();
            }
            catch (Exception)
            {
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNovaContribuicao_Load(object sender, EventArgs e)
        {
            CarregarCombox_Contribuicao();
            CarregarCombox_FormaPagamento();
            converter.Moeda(tboxValor);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja confirmar lançamento?", "Clever Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Gravar_Registro();
                Relatorio();
            }
        }

        private void tboxValor_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(tboxValor.Text) <= 0)
                {
                    return;
                }

                if (e.KeyCode == Keys.Enter)
                {
                    if (MessageBox.Show("Deseja confirmar lançamento?", "Clever Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Gravar_Registro();
                        Relatorio();
                    }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}