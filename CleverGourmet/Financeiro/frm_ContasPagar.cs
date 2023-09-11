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
    public partial class frm_ContasPagar : Modelo
    {
        Conexao conexao = new Conexao();

        public string codParceiro;
        public string codBancoConta;
        public string codMoeda;
        public string codCategoria;
        public string codFilial = "1";

        public string codParceirop;
        public string codBancoContaP;
        public string codMoedaP;
        public string codCategoriaP;

        string SQLCunsultaEmpr;

        public frm_ContasPagar()
        {
            InitializeComponent();
        }

        private void Iniciar_Form()
        {
            tboxDtLanc.Text = DateTime.Now.ToShortDateString();
            tboxTipoData.Text = " ";

            

            #region MONTAR GRID CONSULTA

            dgv_resultado_pesquisa.ContextMenuStrip = this.contextMenuStrip1;

            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.Name = "ID";
            col_ID.HeaderText = "LANÇAMENTO";
            col_ID.Width = 100;
            dgv_resultado_pesquisa.Columns.Add(col_ID);

            DataGridViewTextBoxColumn col_TIPO = new DataGridViewTextBoxColumn();
            col_TIPO.Name = "TIPO";
            col_TIPO.HeaderText = "TIPO";
            col_TIPO.Width = 70;
            dgv_resultado_pesquisa.Columns.Add(col_TIPO);

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

            DataGridViewTextBoxColumn col_DTLANC = new DataGridViewTextBoxColumn();
            col_DTLANC.Name = "DTLANC";
            col_DTLANC.HeaderText = "DT. LANC.";
            col_DTLANC.Width = 180;
            dgv_resultado_pesquisa.Columns.Add(col_DTLANC);

            DataGridViewTextBoxColumn col_DTVENC = new DataGridViewTextBoxColumn();
            col_DTVENC.Name = "DTVENC";
            col_DTVENC.HeaderText = "DT. VENC.";
            col_DTVENC.Width = 180;
            dgv_resultado_pesquisa.Columns.Add(col_DTVENC);

            DataGridViewTextBoxColumn col_DTCOMPETENCIA = new DataGridViewTextBoxColumn();
            col_DTCOMPETENCIA.Name = "DTCOMPETENCIA";
            col_DTCOMPETENCIA.HeaderText = "COMPETÊNCIA";
            col_DTCOMPETENCIA.Width = 180;
            dgv_resultado_pesquisa.Columns.Add(col_DTCOMPETENCIA);

            DataGridViewTextBoxColumn col_DTPGTO = new DataGridViewTextBoxColumn();
            col_DTPGTO.Name = "DTPGTO";
            col_DTPGTO.HeaderText = "DT. PGTO";
            col_DTPGTO.Width = 180;
            dgv_resultado_pesquisa.Columns.Add(col_DTPGTO);

            DataGridViewTextBoxColumn col_IDVENDA = new DataGridViewTextBoxColumn();
            col_IDVENDA.Name = "IDVENDA";
            col_IDVENDA.HeaderText = "IDVENDA";
            col_IDVENDA.Visible = false;
            dgv_resultado_pesquisa.Columns.Add(col_IDVENDA);

            #endregion

            Relatorio1ToolStripMenuItem.Text = "Relatório simples";
            Relatorio1ToolStripMenuItem.Visible = true;

            Relatorio2ToolStripMenuItem.Text = "Relatório Detalhado";
            Relatorio2ToolStripMenuItem.Visible = true;

            Relatorio3ToolStripMenuItem.Text = "Recibo";
            Relatorio3ToolStripMenuItem.Visible = true;
        }
        public override void pesquisar_Registro()
        {
            tabControl1.SelectedTab = tabPage2;
            conexao.Abre_Conexao();
            dgv_resultado_pesquisa.Rows.Clear();


            string parceiro  = "";
            string banco     = "";
            string moeda     = "";
            string contagerencial = "";
            string historico = "";
            string numdoc    = "";
            string tipodata = "";

            if (codParceirop != null)
            {
                parceiro = " = " + codParceirop;
            }
            else
            {
                parceiro = " IS NOT NULL";
            }

            if (codBancoContaP != null)
            {
                banco = " = " + codBancoContaP;
            }
            else
            {
                banco = " IS NOT NULL";
            }

            if (codMoedaP != null)
            {
                moeda = " = " + codMoedaP;
            }
            else
            {
                moeda = " IS NOT NULL";
            }

            if (codCategoriaP != null)
            {
                contagerencial = " = " + codCategoriaP;
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


            if (tboxTipoData.Text == " ")
            {
                tipodata = "DTLANC IS NOT NULL";
            }

            if (tboxTipoData.Text == "VENCIMENTO")
            {
                tipodata = " DTVENC BETWEEN '" + tboxDTIni.Text + "' AND '" + tboxDtFim.Text + "'";
            }
            if (tboxTipoData.Text == "LANÇAMENTO")
            {
                tipodata = "DTLANC BETWEEN '" + tboxDTIni.Text + "' AND '" + tboxDtFim.Text + "'";
            }
            if (tboxTipoData.Text == "COMPETÊNCIA")
            {
                tipodata = "DTCOMPETENCIA BETWEEN '" + tboxDTIni.Text + "' AND '" + tboxDtFim.Text + "'";
            }
            if (tboxTipoData.Text == "PAGAMENTO")
            {
                tipodata = "DTPGTO BETWEEN '" + tboxDTIni.Text + "' AND '" + tboxDtFim.Text + "'";
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
                                     " ,F.IDVENDA             " +
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
                                     " F.TIPO =  'D'         AND" +
                                     " " +  dtPagamento +
                                     " F.IDPARCEIRO " + parceiro + " AND" +
                                     " F.IDMOEDA " + moeda + " AND" +
                                     " F.IDCONTA " + banco + " AND" +
                                     " F.IDCONTAGERENCIAL " + contagerencial + " AND " +
                                     " F.HISTORICO " + historico + " AND " +
                                     " F.NUMDOC " + numdoc + " AND " +
                                     " F."+ tipodata ;
             

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
                dgv_resultado_pesquisa.Rows[o].Cells["ID"].Value             = conexao.dataReader["ID"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["TIPO"].Value           = conexao.dataReader["TIPO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["IDPARCEIRO"].Value     = conexao.dataReader["IDPARCEIRO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["PARCEIRO"].Value       = conexao.dataReader["RAZAOSOCIAL"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["IDMOEDA"].Value        = conexao.dataReader["IDMOEDA"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["MOEDA"].Value          = conexao.dataReader["MOEDA"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["IDBANCOCONTA"].Value   = conexao.dataReader["IDCONTA"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["BANCOCONTA"].Value     = conexao.dataReader["CONTA"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["IDCONTAGERENCIAL"].Value    = conexao.dataReader["IDCONTAGERENCIAL"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["CONTAGERENCIAL"].Value      = conexao.dataReader["CONTAGERENCIAL"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["HISTORICO"].Value      = conexao.dataReader["HISTORICO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["NUMDOC"].Value         = conexao.dataReader["NUMDOC"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["DTLANC"].Value         = conexao.dataReader["DTLANC"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["DTVENC"].Value         = conexao.dataReader["DTVENC"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["DTCOMPETENCIA"].Value  = conexao.dataReader["DTCOMPETENCIA"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["DTPGTO"].Value         = conexao.dataReader["DTPGTO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["VALOR"].Value          = Conversor.converterMoeda(conexao.dataReader["VALOR"].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["VLRDESC"].Value        = Conversor.converterMoeda(conexao.dataReader["VLRDESC"].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["VLRJUROS"].Value       = Conversor.converterMoeda(conexao.dataReader["VLRJUROS"].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["VLRTOTAL"].Value       = Conversor.converterMoeda(conexao.dataReader["VLRTOTAL"].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["VLREXTENSO"].Value     = conexao.dataReader["VLREXTENSO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["IDVENDA"].Value = conexao.dataReader["IDVENDA"].ToString();
                dgv_resultado_pesquisa.DefaultCellStyle.ForeColor = Color.Black;



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

                textBox1.Text = "Total R$: " + Convert.ToString(total);
                textBox2.Text = "Valor R$: " + Convert.ToString(valor);
                textBox3.Text = "Desconto R$: " + Convert.ToString(desconto);
                textBox4.Text = "Juros R$: " + Convert.ToString(juros);
            }


            conexao.Fecha_Conexao();

        }
        public override void gravar_Registro()
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
                    string SQLCunsultaEmpr = " INSERT INTO TBCP " +
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
                    conexao.cmd.Parameters.AddWithValue("TIPO",          "D");
                    conexao.cmd.Parameters.AddWithValue("IDFILIAL",      codFilial);
                    conexao.cmd.Parameters.AddWithValue("IDPARCEIRO",    codParceiro);
                    conexao.cmd.Parameters.AddWithValue("IDMOEDA",       codMoeda);
                    conexao.cmd.Parameters.AddWithValue("IDCONTA",       codBancoConta);
                    conexao.cmd.Parameters.AddWithValue("IDCONTAGERENCIAL",   codCategoria);
                    conexao.cmd.Parameters.AddWithValue("HISTORICO",     tboxHistorico.Text);
                    conexao.cmd.Parameters.AddWithValue("NUMDOC",        tboxNumDoc.Text);
                    conexao.cmd.Parameters.AddWithValue("DTLANC",        tboxDtLanc.Text);
                    conexao.cmd.Parameters.AddWithValue("DTVENC",        tboxDtVenc.Text);
                    conexao.cmd.Parameters.AddWithValue("DTCOMPETENCIA", tboxCompetencia.Text);
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
                    string SQLCunsultaEmpr = " UPDATE TBCP SET " +
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
                    conexao.cmd.Parameters.AddWithValue("TIPO",          "D");
                    conexao.cmd.Parameters.AddWithValue("IDFILIAL",      codFilial);
                    conexao.cmd.Parameters.AddWithValue("IDPARCEIRO",    codParceiro);
                    conexao.cmd.Parameters.AddWithValue("IDMOEDA",       codMoeda);
                    conexao.cmd.Parameters.AddWithValue("IDCONTA",       codBancoConta);
                    conexao.cmd.Parameters.AddWithValue("IDCONTAGERENCIAL",   codCategoria);
                    conexao.cmd.Parameters.AddWithValue("HISTORICO",     tboxHistorico.Text);
                    conexao.cmd.Parameters.AddWithValue("NUMDOC",        tboxNumDoc.Text);
                    conexao.cmd.Parameters.AddWithValue("DTLANC",        tboxDtLanc.Text);
                    conexao.cmd.Parameters.AddWithValue("DTVENC",        tboxDtVenc.Text);
                    conexao.cmd.Parameters.AddWithValue("DTCOMPETENCIA", tboxCompetencia.Text);
                    conexao.cmd.Parameters.AddWithValue("VALOR",         Conversor.converterMoeda(tboxValor.Text));
                    conexao.cmd.Parameters.AddWithValue("VLRDESC",       Conversor.converterMoeda(tboxDesconto.Text));
                    conexao.cmd.Parameters.AddWithValue("VLRJUROS",      Conversor.converterMoeda(tboxJuros.Text));
                    conexao.cmd.Parameters.AddWithValue("VLRTOTAL",      Conversor.converterMoeda(tboxTotal.Text));
                    conexao.cmd.Parameters.AddWithValue("VLREXTENSO",    valor_Extenso);

                    conexao.cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro Atualizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conexao.Fecha_Conexao();

                    #endregion
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }




        }
        public override void editar_Registro()
        {
            //if (dgv_resultado_pesquisa.CurrentRow.Cells["IDVENDA"].Value.ToString() != "")
            //{
            //    MessageBox.Show("O Registro selecionado está vinculado a outros registros, não será possivel editar ou extornar atraves dessa rotina.", "Clever Sistema",MessageBoxButtons.OK);
            //    return;
            //}
            try
            {
               
                       tboxlanc.Text        =  dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
                       codParceiro          =  dgv_resultado_pesquisa.CurrentRow.Cells["IDPARCEIRO"].Value.ToString();
                       tboxParceiro.Text    = dgv_resultado_pesquisa.CurrentRow.Cells["IDPARCEIRO"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["PARCEIRO"].Value.ToString();
                       codMoeda             = dgv_resultado_pesquisa.CurrentRow.Cells["IDMOEDA"].Value.ToString();
                       tboxMoeda.Text       = dgv_resultado_pesquisa.CurrentRow.Cells["IDMOEDA"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["MOEDA"].Value.ToString();
                       codBancoConta        = dgv_resultado_pesquisa.CurrentRow.Cells["IDBANCOCONTA"].Value.ToString();
                       tboxBancoConta.Text  = dgv_resultado_pesquisa.CurrentRow.Cells["IDBANCOCONTA"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["BANCOCONTA"].Value.ToString();
                       codCategoria         = dgv_resultado_pesquisa.CurrentRow.Cells["IDCONTAGERENCIAL"].Value.ToString();
                       tboxCategoria.Text   = dgv_resultado_pesquisa.CurrentRow.Cells["IDCONTAGERENCIAL"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["CONTAGERENCIAL"].Value.ToString();
                       tboxHistorico.Text   = dgv_resultado_pesquisa.CurrentRow.Cells["HISTORICO"].Value.ToString();
                       tboxNumDoc.Text      = dgv_resultado_pesquisa.CurrentRow.Cells["NUMDOC"].Value.ToString();
                       tboxDtLanc.Text      =  dgv_resultado_pesquisa.CurrentRow.Cells["DTLANC"].Value.ToString();
                       tboxDtVenc.Text      = dgv_resultado_pesquisa.CurrentRow.Cells["DTVENC"].Value.ToString();
                       tboxCompetencia.Text = dgv_resultado_pesquisa.CurrentRow.Cells["DTCOMPETENCIA"].Value.ToString();
                       tboxPagamento.Text   = dgv_resultado_pesquisa.CurrentRow.Cells["DTPGTO"].Value.ToString();
                       tboxValor.Text       = dgv_resultado_pesquisa.CurrentRow.Cells["VALOR"].Value.ToString();
                       tboxDesconto.Text    = dgv_resultado_pesquisa.CurrentRow.Cells["VLRDESC"].Value.ToString();
                       tboxJuros.Text       = dgv_resultado_pesquisa.CurrentRow.Cells["VLRJUROS"].Value.ToString();
                       tboxTotal.Text       = dgv_resultado_pesquisa.CurrentRow.Cells["VLRTOTAL"].Value.ToString();

                        tabControl1.SelectedTab = tabPage1;
                
              
            }
            catch (Exception)
            {


            }

        }
        public override void excluir_Registro()
        {
            try
            {
                if (dgv_resultado_pesquisa.CurrentRow.Cells["IDVENDA"].Value.ToString() != "")
                {
                    MessageBox.Show("O Registro selecionado está vinculado a outros registros, não será possivel editar ou extornar atraves dessa rotina.", "Clever Sistema", MessageBoxButtons.OK);
                    return;
                }

                if (MessageBox.Show("Realmente deseje excluir o item selecionado?", "Clever Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    if (tabControl1.SelectedTab == tabPage1)
                    {
                        id_registro = Convert.ToInt32(tboxlanc.Text);
                    }
                    else
                    {
                        id_registro = Convert.ToInt32(dgv_resultado_pesquisa.CurrentRow.Cells[0].Value.ToString());
                    }
                    conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = "INSERT INTO TBCP_ex ( TIPO, IDFILIAL, IDPARCEIRO, IDMOEDA, IDCONTA, IDCONTAGERENCIAL, HISTORICO, NUMDOC, DTLANC, DTVENC, DTCOMPETENCIA, DTPGTO, VALOR, VLRDESC, VLRJUROS, VLRTOTAL, VLREXTENSO, IDVENDA, STATUS)" +
                                             "SELECT TIPO, IDFILIAL, IDPARCEIRO, IDMOEDA, IDCONTA, IDCONTAGERENCIAL, HISTORICO, NUMDOC, DTLANC, DTVENC, DTCOMPETENCIA, DTPGTO, VALOR, VLRDESC, VLRJUROS, VLRTOTAL, VLREXTENSO, IDVENDA, STATUS " +
                                             "FROM TBCP WHERE ID = " + id_registro;



                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();

                    SQLCunsultaEmpr = "DELETE FROM TBCP WHERE ID = " + id_registro;



                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro Extornado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conexao.Fecha_Conexao();
                    pesquisar_Registro();

                }
            }
            catch (Exception)
            {


            }
        }

        public override void limpar_Campos()
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

        public override void relatorio1()
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

        public override void relatorio2()
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

        public override void relatorio3()
        {
            try
            {
                frm_Relatorio a = new frm_Relatorio();
                a.Arquivo_rdlc = "Rpv_CP_Recibo.rdlc";
                a.Sql_Relatorio1 = this.SQLCunsultaEmpr;
                a.Dataset_Relatorio1 = "DataSet_CP";
                a.ShowDialog();
            }
            catch (Exception)
            {


            }
        }

        private void frm_Financeiro_Load(object sender, EventArgs e)
        {

            Iniciar_Form();

           

        }

        private void btnPesquisarParceiro_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR FORNECEDOR";
            a.RotinaOrigem = lbl_NomeRotina.Text;
            a.ShowDialog();
        }

        private void btn_PesquisarBanco_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR BANCO / CONTA";
            a.RotinaOrigem = lbl_NomeRotina.Text;
            a.ShowDialog();
        }

        private void btn_PesquisarMoeda_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR MOEDA";
            a.RotinaOrigem = lbl_NomeRotina.Text;
            a.ShowDialog();
        }

        private void btn_PesquisarCategoria_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR CONTA GERENCIAL";
            a.RotinaOrigem = lbl_NomeRotina.Text;
            a.ShowDialog();
        }

        private void btn_pesquisarParceiroP_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR FORNECEDOR";
            a.RotinaOrigem = lbl_NomeRotina.Text;
            a.ShowDialog();
        }

        private void btn_pesquisarBancoConta_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR BANCO / CONTA";
            a.RotinaOrigem = lbl_NomeRotina.Text;
            a.ShowDialog();
        }

        private void btn_pesquisarMoedaP_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR MOEDA";
            a.RotinaOrigem = lbl_NomeRotina.Text;
            a.ShowDialog();
        }

        private void btn_pesquisarCategoriaP_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR CONTA GERENCIAL";
            a.RotinaOrigem = lbl_NomeRotina.Text;
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

        private void tboxParceiroP_KeyDown(object sender, KeyEventArgs e)
        {
            tboxParceiroP.Clear();

        }

        private void tboxBancoContaP_KeyDown(object sender, KeyEventArgs e)
        {
            tboxBancoContaP.Clear();
        }

        private void tboxMoedaP_KeyDown(object sender, KeyEventArgs e)
        {
            tboxMoedaP.Clear();
        }

        private void tboxCategoriaP_KeyDown(object sender, KeyEventArgs e)
        {
            tboxCategoriaP.Clear();
        }

        private void tboxTipoData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void informarPagamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_FinanceiroPagto a = new frm_FinanceiroPagto();
            a.rotina = "CP";
            a.idlancamento = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            a.tboxValor.Text = dgv_resultado_pesquisa.CurrentRow.Cells["VALOR"].Value.ToString();
            a.tboxDesconto.Text = dgv_resultado_pesquisa.CurrentRow.Cells["VLRDESC"].Value.ToString();
            a.tboxJuros.Text = dgv_resultado_pesquisa.CurrentRow.Cells["VLRJUROS"].Value.ToString();
            a.tboxTotal.Text = dgv_resultado_pesquisa.CurrentRow.Cells["VLRTOTAL"].Value.ToString();
            a.ShowDialog();
            pesquisar_Registro();
        }
    }
}
