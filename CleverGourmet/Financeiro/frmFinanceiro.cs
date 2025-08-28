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
    public partial class frmFinanceiro : Padrao
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
        public frmFinanceiro()
        {
            InitializeComponent();
            this.Text = pagarReceber;
        }
        private void Iniciar_Form()
        {
            this.Text = pagarReceber;
            lbl_NomeRotina.Text = pagarReceber;
            tboxTipoData.Text = "VENCIMENTO";

            if (pagarReceber == "DESPESAS")
            {
                tipo = "D";
                tbParceiro = "TBFORNECEDOR";
            }

            if (pagarReceber == "RECEITAS")
            {
                tipo = "R";
                tbParceiro = "TBCLIENTE";
            }

            #region MONTAR GRID CONSULTA


            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.Name = "ID";
            col_ID.HeaderText = "LANÇAMENTO";
            col_ID.Width = 100;
            dgv_resultado_pesquisa.Columns.Add(col_ID);

            DataGridViewTextBoxColumn col_DTLANC = new DataGridViewTextBoxColumn();
            col_DTLANC.Name = "DTLANC";
            col_DTLANC.HeaderText = "DT. LANC.";
            col_DTLANC.Width = 100;
            dgv_resultado_pesquisa.Columns.Add(col_DTLANC);

            DataGridViewTextBoxColumn col_DTVENC = new DataGridViewTextBoxColumn();
            col_DTVENC.Name = "DTVENC";
            col_DTVENC.HeaderText = "DT. VENC.";
            col_DTVENC.Width = 100;
            dgv_resultado_pesquisa.Columns.Add(col_DTVENC);

            DataGridViewTextBoxColumn col_TIPO = new DataGridViewTextBoxColumn();
            col_TIPO.Name = "TIPO";
            col_TIPO.HeaderText = "TIPO";
            col_TIPO.Width = 70;
            dgv_resultado_pesquisa.Columns.Add(col_TIPO);

            DataGridViewTextBoxColumn col_IDPARCEIRO = new DataGridViewTextBoxColumn();
            col_IDPARCEIRO.Name = "IDPARCEIRO";
            col_IDPARCEIRO.HeaderText = "CÓD. PARC";
            col_IDPARCEIRO.Width = 120;
            dgv_resultado_pesquisa.Columns.Add(col_IDPARCEIRO);

            DataGridViewTextBoxColumn col_PARCEIRO = new DataGridViewTextBoxColumn();
            col_PARCEIRO.Name = "PARCEIRO";
            col_PARCEIRO.HeaderText = "PARCEIRO";
            col_PARCEIRO.Width = 250;
            dgv_resultado_pesquisa.Columns.Add(col_PARCEIRO);

            DataGridViewTextBoxColumn col_HISTORICO = new DataGridViewTextBoxColumn();
            col_HISTORICO.Name = "HISTORICO";
            col_HISTORICO.HeaderText = "HISTÓRICO";
            col_HISTORICO.Width = 270;
            dgv_resultado_pesquisa.Columns.Add(col_HISTORICO);

            DataGridViewTextBoxColumn col_VALOR = new DataGridViewTextBoxColumn();
            col_VALOR.Name = "VALOR";
            col_VALOR.HeaderText = "VALOR";
            col_VALOR.Width = 100;
            dgv_resultado_pesquisa.Columns.Add(col_VALOR);

            DataGridViewTextBoxColumn col_VLRDESC = new DataGridViewTextBoxColumn();
            col_VLRDESC.Name = "VLRDESC";
            col_VLRDESC.HeaderText = "DESCONTO";
            col_VLRDESC.Width = 100;
            dgv_resultado_pesquisa.Columns.Add(col_VLRDESC);

            DataGridViewTextBoxColumn col_VLRJUROS = new DataGridViewTextBoxColumn();
            col_VLRJUROS.Name = "VLRJUROS";
            col_VLRJUROS.HeaderText = "JUROS";
            col_VLRJUROS.Width = 100;
            dgv_resultado_pesquisa.Columns.Add(col_VLRJUROS);

            DataGridViewTextBoxColumn col_VLRTOTAL = new DataGridViewTextBoxColumn();
            col_VLRTOTAL.Name = "VLRTOTAL";
            col_VLRTOTAL.HeaderText = "TOTAL";
            col_VLRTOTAL.Width = 100;
            dgv_resultado_pesquisa.Columns.Add(col_VLRTOTAL);

            DataGridViewTextBoxColumn col_VLREXTENSO = new DataGridViewTextBoxColumn();
            col_VLREXTENSO.Name = "VLREXTENSO";
            col_VLREXTENSO.HeaderText = "VLREXTENSO";
            col_VLREXTENSO.Visible = false;
            dgv_resultado_pesquisa.Columns.Add(col_VLREXTENSO);

            DataGridViewTextBoxColumn col_DTPGTO = new DataGridViewTextBoxColumn();
            col_DTPGTO.Name = "DTPGTO";
            col_DTPGTO.HeaderText = "DT. PGTO";
            col_DTPGTO.Width = 100;
            dgv_resultado_pesquisa.Columns.Add(col_DTPGTO);

            DataGridViewTextBoxColumn col_IDMOEDA = new DataGridViewTextBoxColumn();
            col_IDMOEDA.Name = "IDMOEDA";
            col_IDMOEDA.HeaderText = "CÓD MOEDA";
            col_IDMOEDA.Width = 120;
            dgv_resultado_pesquisa.Columns.Add(col_IDMOEDA);

            DataGridViewTextBoxColumn col_MOEDA = new DataGridViewTextBoxColumn();
            col_MOEDA.Name = "MOEDA";
            col_MOEDA.HeaderText = "MOEDA";
            col_MOEDA.Width = 180;
            dgv_resultado_pesquisa.Columns.Add(col_MOEDA);

            DataGridViewTextBoxColumn col_IDBANCOCONTA = new DataGridViewTextBoxColumn();
            col_IDBANCOCONTA.Name = "IDBANCOCONTA";
            col_IDBANCOCONTA.HeaderText = "CÓD BANCO";
            col_IDBANCOCONTA.Width = 120;
            dgv_resultado_pesquisa.Columns.Add(col_IDBANCOCONTA);

            DataGridViewTextBoxColumn col_BANCOCONTA = new DataGridViewTextBoxColumn();
            col_BANCOCONTA.Name = "BANCOCONTA";
            col_BANCOCONTA.HeaderText = "BANCO / CONTA";
            col_BANCOCONTA.Width = 180;
            dgv_resultado_pesquisa.Columns.Add(col_BANCOCONTA);

            DataGridViewTextBoxColumn col_IDCONTAGERENCIAL = new DataGridViewTextBoxColumn();
            col_IDCONTAGERENCIAL.Name = "IDCONTAGERENCIAL";
            col_IDCONTAGERENCIAL.HeaderText = "CÓD CONTA G.";
            col_IDCONTAGERENCIAL.Width = 120;
            dgv_resultado_pesquisa.Columns.Add(col_IDCONTAGERENCIAL);

            DataGridViewTextBoxColumn col_CONTAGERENCIAL = new DataGridViewTextBoxColumn();
            col_CONTAGERENCIAL.Name = "CONTAGERENCIAL";
            col_CONTAGERENCIAL.HeaderText = "CONTA GERENCIAL";
            col_CONTAGERENCIAL.Width = 180;
            dgv_resultado_pesquisa.Columns.Add(col_CONTAGERENCIAL);

            DataGridViewTextBoxColumn col_NUMDOC = new DataGridViewTextBoxColumn();
            col_NUMDOC.Name = "NUMDOC";
            col_NUMDOC.HeaderText = "Nº DOCUMENTO";
            col_NUMDOC.Width = 180;
            dgv_resultado_pesquisa.Columns.Add(col_NUMDOC);

            DataGridViewTextBoxColumn col_DTCOMPETENCIA = new DataGridViewTextBoxColumn();
            col_DTCOMPETENCIA.Name = "DTCOMPETENCIA";
            col_DTCOMPETENCIA.HeaderText = "COMPETÊNCIA";
            col_DTCOMPETENCIA.Width = 100;
            dgv_resultado_pesquisa.Columns.Add(col_DTCOMPETENCIA);

            DataGridViewTextBoxColumn col_IDVENDA = new DataGridViewTextBoxColumn();
            col_IDVENDA.Name = "IDVENDA";
            col_IDVENDA.HeaderText = "IDVENDA";
            col_IDVENDA.Visible = false;
            dgv_resultado_pesquisa.Columns.Add(col_IDVENDA);

            #endregion

        }
        private void pesquisar_Registro()
        {
            conexao.Abre_Conexao();
            dgv_resultado_pesquisa.Rows.Clear();

            string parceiro  = "";
            string banco     = "";
            string moeda     = "";
            string contagerencial = "";
            string historico = "";
            string numdoc    = "";
            string tipodata = "";
            string numLanc = "";


            if (tboxNumLanc.Text != "")
            {
                numLanc = " = '" + tboxNumLanc.Text + "'";
            }
            else
            {
                numLanc = " IS NOT NULL";
            }

            if (codParceiro != null)
            {
                parceiro = " = " + codParceiro;
            }
            else
            {
                parceiro = " IS NOT NULL";
            }

            if (codBancoConta != null)
            {
                banco = " = " + codBancoConta;
            }
            else
            {
                banco = " IS NOT NULL";
            }

            if (codMoeda != null)
            {
                moeda = " = " + codMoeda;
            }
            else
            {
                moeda = " IS NOT NULL";
            }

            if (codCategoria != null)
            {
                contagerencial = " = " + codCategoria;
            }
            else
            {
                contagerencial = " IS NOT NULL";
            }

            if (tboxHistoricoP.Text != "")
            {
                historico = " LIKE '%" + tboxHistoricoP.Text + "%'";
            }
            else
            {
                historico = " IS NOT NULL";
            }

            if (tboxNumDocP.Text != "")
            {
                numdoc = " = '" + tboxNumDocP.Text + "'";
            }
            else
            {
                numdoc = " IS NOT NULL";
            }


            if (tboxTipoData.Text == "TODOS")
            {
                tipodata = "DTLANC IS NOT NULL";
            }

            if (tboxTipoData.Text == "VENCIMENTO")
            {
                tipodata = " DTVENC BETWEEN '" + Conversor.converterDataUS(tboxDTIni.Text) + "' AND '" + Conversor.converterDataUS(tboxDtFim.Text) + "'";
            }
            if (tboxTipoData.Text == "LANÇAMENTO")
            {
                tipodata = "DTLANC BETWEEN '" + Conversor.converterDataUS(tboxDTIni.Text) + "' AND '" + Conversor.converterDataUS(tboxDtFim.Text) + "'";
            }
            if (tboxTipoData.Text == "COMPETÊNCIA")
            {
                tipodata = "DTCOMPETENCIA BETWEEN '" + Conversor.converterDataUS(tboxDTIni.Text) + "' AND '" + Conversor.converterDataUS(tboxDtFim.Text) + "'";
            }
            if (tboxTipoData.Text == "PAGAMENTO")
            {
                tipodata = "DTPGTO BETWEEN '" + Conversor.converterDataUS(tboxDTIni.Text) + "' AND '" + Conversor.converterDataUS(tboxDtFim.Text) + "'";
            }

            string dtPagamento = "";

            if (rbtnEmAberto.Checked == true)
            {
                dtPagamento = " F.DTPGTO  IS null AND ";
            }
            if (rbtn_Pagas.Checked == true)
            {
                dtPagamento = " F.DTPGTO is not null AND ";
            }
            if (rbtnTodas.Checked == true)
            {
                dtPagamento = " ";
            }

            SQLCunsultaEmpr =       " SELECT                    " +
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
                                     " TBFINANCEIRO       F,   " +
                                     " TBCONTAGERENCIAL   G,   " +
                                     " TBCONTA            C,   " +
                                     " TBMOEDA            M,   " +
                                     " TBFILIAL           E,   " +
                                     ""+ tbParceiro + "   P   " +
                                     " WHERE                    " +
                                     " F.IDCONTAGERENCIAL = G.ID  AND" +
                                     " F.IDFILIAL    = E.ID  AND" +
                                     " F.IDCONTA = C.ID      AND" +
                                     " F.IDMOEDA = M.ID      AND" +
                                     " F.IDPARCEIRO = P.ID   AND" +
                                     " F.STATUS IS NULL      AND" +
                                     " F.TIPO = '"+ tipo + "'  AND" +
                                     " " +  dtPagamento +
                                     " F.IDPARCEIRO " + parceiro + " AND" +
                                     " F.ID " + numLanc + " AND" +
                                     " F.IDMOEDA " + moeda + " AND" +
                                     " F.IDCONTA " + banco + " AND" +
                                     " F.IDCONTAGERENCIAL " + contagerencial + " AND " +
                                     " F.HISTORICO " + historico + " AND " +
                                     " F.NUMDOC " + numdoc + " AND " +
                                     " F."+ tipodata + limite;
             

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
                dgv_resultado_pesquisa.Rows[o].Cells["ID"].Value               = conexao.dataReader["ID"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["TIPO"].Value             = conexao.dataReader["TIPO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["IDPARCEIRO"].Value       = conexao.dataReader["IDPARCEIRO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["PARCEIRO"].Value         = conexao.dataReader["RAZAOSOCIAL"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["IDMOEDA"].Value          = conexao.dataReader["IDMOEDA"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["MOEDA"].Value            = conexao.dataReader["MOEDA"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["IDBANCOCONTA"].Value     = conexao.dataReader["IDCONTA"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["BANCOCONTA"].Value       = conexao.dataReader["CONTA"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["IDCONTAGERENCIAL"].Value = conexao.dataReader["IDCONTAGERENCIAL"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["CONTAGERENCIAL"].Value   = conexao.dataReader["CONTAGERENCIAL"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["HISTORICO"].Value        = conexao.dataReader["HISTORICO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["NUMDOC"].Value           = conexao.dataReader["NUMDOC"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["DTLANC"].Value           = Conversor.converterDataBR(conexao.dataReader["DTLANC"].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["DTVENC"].Value           = Conversor.converterDataBR(conexao.dataReader["DTVENC"].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["DTCOMPETENCIA"].Value    = Conversor.converterDataBR(conexao.dataReader["DTCOMPETENCIA"].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["DTPGTO"].Value           = Conversor.converterDataBR(conexao.dataReader["DTPGTO"].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["VALOR"].Value            = Conversor.converterMoeda(conexao.dataReader["VALOR"].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["VLRDESC"].Value          = Conversor.converterMoeda(conexao.dataReader["VLRDESC"].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["VLRJUROS"].Value         = Conversor.converterMoeda(conexao.dataReader["VLRJUROS"].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["VLRTOTAL"].Value         = Conversor.converterMoeda(conexao.dataReader["VLRTOTAL"].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["VLREXTENSO"].Value       = conexao.dataReader["VLREXTENSO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["IDVENDA"].Value          = conexao.dataReader["IDVENDA"].ToString();
                dgv_resultado_pesquisa.DefaultCellStyle.ForeColor              = Color.Black;



                o++;
            }
            decimal total = 0;
            decimal valor = 0;
            decimal desconto = 0;
            decimal juros = 0;
            for (int i = 0; i < dgv_resultado_pesquisa.RowCount; i++)
            {
                total = total + Convert.ToDecimal(dgv_resultado_pesquisa.Rows[i].Cells["VLRTOTAL"].Value.ToString());
                valor = valor + Convert.ToDecimal(dgv_resultado_pesquisa.Rows[i].Cells["VALOR"].Value.ToString());
                desconto = desconto + Convert.ToDecimal(dgv_resultado_pesquisa.Rows[i].Cells["VLRDESC"].Value.ToString());
                juros = juros + Convert.ToDecimal(dgv_resultado_pesquisa.Rows[i].Cells["VLRJUROS"].Value.ToString());

                textBox1.Text = Convert.ToString(total);
                textBox2.Text = Convert.ToString(valor);
                textBox3.Text = Convert.ToString(desconto);
                textBox4.Text = Convert.ToString(juros);
            }


            conexao.Fecha_Conexao();

        }
        private void excluir_Registro()
        {
            
                int id_registro;
                if (dgv_resultado_pesquisa.CurrentRow.Cells["IDVENDA"].Value.ToString() != "")
                {
                    MessageBox.Show("O Registro selecionado está vinculado a outros registros, não será possivel editar ou extornar atraves dessa rotina.", "Clever Sistema", MessageBoxButtons.OK);
                    return;
                }

                if (MessageBox.Show("Realmente deseje excluir o item selecionado?", "Clever Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                   
                    id_registro = Convert.ToInt32(dgv_resultado_pesquisa.CurrentRow.Cells[0].Value.ToString());
                  
                    conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = "INSERT INTO TBFINANC_EX ( TIPO, IDFILIAL, IDPARCEIRO, IDMOEDA, IDCONTA, IDCONTAGERENCIAL, HISTORICO, NUMDOC, DTLANC, DTVENC, DTCOMPETENCIA, DTPGTO, VALOR, VLRDESC, VLRJUROS, VLRTOTAL, VLREXTENSO, IDVENDA, STATUS, DTEXCLUSAO)" +
                                             "SELECT TIPO, IDFILIAL, IDPARCEIRO, IDMOEDA, IDCONTA, IDCONTAGERENCIAL, HISTORICO, NUMDOC, DTLANC, DTVENC, DTCOMPETENCIA, DTPGTO, VALOR, VLRDESC, VLRJUROS, VLRTOTAL, VLREXTENSO, IDVENDA, STATUS, DATE('NOW') " +
                                             "FROM TBFINANCEIRO WHERE ID = " + id_registro;



                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();

                    SQLCunsultaEmpr = "DELETE FROM TBFINANCEIRO WHERE ID = " + id_registro;



                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro Extornado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conexao.Fecha_Conexao();
                    pesquisar_Registro();

                }
           
        }
        private void frmFinanceiro_Load(object sender, EventArgs e)
        {
            Iniciar_Form();
            tboxDtFim.Text = Convert.ToDateTime(DateTime.Now.AddDays(1)).ToShortDateString();
            tboxDTIni.Text = Convert.ToDateTime(DateTime.Now.AddDays(-7)).ToShortDateString();

            limite = " LIMIT 25";
            pesquisar_Registro();
        }
        private void btn_pesquisarParceiro_Click(object sender, EventArgs e)
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
        private void btn_pesquisarBancoConta_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR BANCO";
            a.RotinaOrigem = "PESQUISAR BANCO";
            a.ShowDialog();
        }
        private void btn_pesquisarMoeda_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR MOEDA";
            a.RotinaOrigem = "PESQUISAR MOEDA";
            a.ShowDialog();
        }
        private void btn_pesquisarContaGerencial_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR CONTA GERENCIAL";
            a.RotinaOrigem = "PESQUISAR CONTA GERENCIAL";
            a.ShowDialog();
        }
        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Relatorio a = new frm_Relatorio();
                a.Arquivo_rdlc = "Rpv_CP_Simples.rdlc";
                a.Sql_Relatorio1 = this.SQLCunsultaEmpr;
                a.Dataset_Relatorio1 = "DataSet_CP";
                a.ShowDialog();
            }
            catch (Exception)
            {


            }
        }
        private void btnImprimirFicha_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Relatorio a = new frm_Relatorio();
                a.Arquivo_rdlc = "Rpv_CP_Detalhado.rdlc";
                a.Sql_Relatorio1 = this.SQLCunsultaEmpr;
                a.Dataset_Relatorio1 = "DataSet_CP";
                a.ShowDialog();
            }
            catch (Exception)
            {


            }
        }
        private void btnRecibo_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Relatorio a = new frm_Relatorio();
                a.Arquivo_rdlc = "Rpv_Recibo_Dizimo.rdlc";
                a.Sql_Relatorio1 = this.SQLCunsultaEmpr;
                a.Dataset_Relatorio1 = "DataSet_CR";
                a.ShowDialog();
            }
            catch (Exception)
            {


            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            limite = "";
            pesquisar_Registro();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluir_Registro();
        }
        private void btnBaixrTitulo_Click(object sender, EventArgs e)
        {
            frm_FinanceiroPagto a = new frm_FinanceiroPagto();
            a.rotina = pagarReceber;
            a.idlancamento = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            a.tboxValor.Text = dgv_resultado_pesquisa.CurrentRow.Cells["VALOR"].Value.ToString();
            a.tboxDesconto.Text = dgv_resultado_pesquisa.CurrentRow.Cells["VLRDESC"].Value.ToString();
            a.tboxJuros.Text = dgv_resultado_pesquisa.CurrentRow.Cells["VLRJUROS"].Value.ToString();
            a.tboxTotal.Text = dgv_resultado_pesquisa.CurrentRow.Cells["VLRTOTAL"].Value.ToString();
            a.ShowDialog();
            pesquisar_Registro();
        }
        private void tboxParceiro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                tboxParceiro.Clear();
                codParceiro = null;
            }
        }
        private void tboxBancoConta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                tboxBancoConta.Clear();
                codBancoConta = null;
            }
        }
        private void tboxMoeda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                tboxMoeda.Clear();
                codMoeda = null;
            }
        }
        private void tboxCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                tboxCategoria.Clear();
                codCategoria = null;
            }
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            Financeiro.frmFinanceiroNovo a = new frmFinanceiroNovo();
            a.pagarReceber = this.pagarReceber;
            a.Text = "INCLUIR " + this.pagarReceber;
            a.ShowDialog();

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //try
            //{
                Financeiro.frmFinanceiroNovo a = new frmFinanceiroNovo();
                a.pagarReceber = this.pagarReceber;
                a.Text = "EDITAR " + this.pagarReceber;
                a.tboxlanc.Text        =  dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
                a.codParceiro          =  dgv_resultado_pesquisa.CurrentRow.Cells["IDPARCEIRO"].Value.ToString();
                a.tboxParceiro.Text    = dgv_resultado_pesquisa.CurrentRow.Cells["IDPARCEIRO"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["PARCEIRO"].Value.ToString();
                a.codMoeda             = dgv_resultado_pesquisa.CurrentRow.Cells["IDMOEDA"].Value.ToString();
                a.tboxMoeda.Text       = dgv_resultado_pesquisa.CurrentRow.Cells["IDMOEDA"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["MOEDA"].Value.ToString();
                a.codBancoConta        = dgv_resultado_pesquisa.CurrentRow.Cells["IDBANCOCONTA"].Value.ToString();
                a.tboxBancoConta.Text  = dgv_resultado_pesquisa.CurrentRow.Cells["IDBANCOCONTA"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["BANCOCONTA"].Value.ToString();
                a.codCategoria         = dgv_resultado_pesquisa.CurrentRow.Cells["IDCONTAGERENCIAL"].Value.ToString();
                a.tboxCategoria.Text   = dgv_resultado_pesquisa.CurrentRow.Cells["IDCONTAGERENCIAL"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["CONTAGERENCIAL"].Value.ToString();
                a.tboxHistorico.Text   = dgv_resultado_pesquisa.CurrentRow.Cells["HISTORICO"].Value.ToString();
                a.tboxNumDoc.Text      = dgv_resultado_pesquisa.CurrentRow.Cells["NUMDOC"].Value.ToString();
                a.tboxDtLanc.Text      = Conversor.converterDataBR(dgv_resultado_pesquisa.CurrentRow.Cells["DTLANC"].Value.ToString());
                a.tboxDtVenc.Text      = Conversor.converterDataBR(dgv_resultado_pesquisa.CurrentRow.Cells["DTVENC"].Value.ToString());
                a.tboxCompetencia.Text = Conversor.converterDataBR(dgv_resultado_pesquisa.CurrentRow.Cells["DTCOMPETENCIA"].Value.ToString());
                a.tboxPagamento.Text   = Conversor.converterDataBR(dgv_resultado_pesquisa.CurrentRow.Cells["DTPGTO"].Value.ToString());
                a.tboxValor.Text       = dgv_resultado_pesquisa.CurrentRow.Cells["VALOR"].Value.ToString();
                a.tboxDesconto.Text    = dgv_resultado_pesquisa.CurrentRow.Cells["VLRDESC"].Value.ToString();
                a.tboxJuros.Text       = dgv_resultado_pesquisa.CurrentRow.Cells["VLRJUROS"].Value.ToString();
                a.tboxTotal.Text       = dgv_resultado_pesquisa.CurrentRow.Cells["VLRTOTAL"].Value.ToString();
                a.ShowDialog();

            //}
            //catch (Exception)
            //{


            //}
        }
    }
}
