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
    public partial class frmOrdemServico : Padrao
    {

        Conexao conexao = new Conexao();
        Produto.Produto produto = new Produto.Produto();
        public string novoEditar;
        string SQLCunsultaEmpr;
        public int idFunc;
        public string codFornec;
        public string codFilial = "1";
        public string codParceiro;
        public string codContaGerencial;
        public string codBancoConta;
        public string codMoeda;
        

        public string codParceirop;
        public string codBancoContaP;
        public string codMoedaP;
        public string codCategoriaP;
        public string dtOrcamento;
        public string dtMedicao;
        public string dtFabricao;
        public string dtART;
        public string dtInstalacao;
        public string dtFinalizado;
        decimal qtdeUnt;
        decimal pcustoUnt;
        decimal ipiUnt;
        decimal descontoUnt;
        decimal outroCustoUnt;
        decimal pliquidoUnt;
        decimal totalUnit;
        int idMoeda = 1;

        int idConta = 1;
        public frmOrdemServico()
        {
            InitializeComponent();
        }
        private void iniciarForm()
        {
            #region MONTAR GRID ITENS

            DataGridViewTextBoxColumn col_ITEM = new DataGridViewTextBoxColumn();
            col_ITEM.Name = "ITEM";
            col_ITEM.HeaderText = "Item";
            col_ITEM.Width = 45;
            dgv_resultado_pesquisa.Columns.Add(col_ITEM);

            DataGridViewTextBoxColumn col_CODPROD = new DataGridViewTextBoxColumn();
            col_CODPROD.Name = "CODPROD";
            col_CODPROD.HeaderText = "Código";
            col_CODPROD.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_CODPROD);

            DataGridViewTextBoxColumn col_DESCRICAO = new DataGridViewTextBoxColumn();
            col_DESCRICAO.Name = "DESCRICAO";
            col_DESCRICAO.HeaderText = "Descrição";
            col_DESCRICAO.Width = 350;
            dgv_resultado_pesquisa.Columns.Add(col_DESCRICAO);

            DataGridViewTextBoxColumn col_CODBARRA = new DataGridViewTextBoxColumn();
            col_CODBARRA.Name = "CODBARRA";
            col_CODBARRA.HeaderText = "Cód. Auxiliar";
            col_CODBARRA.Width = 150;
            dgv_resultado_pesquisa.Columns.Add(col_CODBARRA);

            DataGridViewTextBoxColumn col_CODFABRICA = new DataGridViewTextBoxColumn();
            col_CODFABRICA.Name = "CODFABRICA";
            col_CODFABRICA.HeaderText = "Cód. Fab.";
            col_CODFABRICA.Width = 150;
            col_CODFABRICA.Visible = false;
            dgv_resultado_pesquisa.Columns.Add(col_CODFABRICA);

            DataGridViewTextBoxColumn col_UND = new DataGridViewTextBoxColumn();
            col_UND.Name = "UND";
            col_UND.HeaderText = "Und";
            col_UND.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_UND);

            DataGridViewTextBoxColumn col_QTDE = new DataGridViewTextBoxColumn();
            col_QTDE.Name = "QTDE";
            col_QTDE.HeaderText = "Qtde";
            col_QTDE.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_QTDE);

            DataGridViewTextBoxColumn col_PCUSTO = new DataGridViewTextBoxColumn();
            col_PCUSTO.Name = "PCUSTO";
            col_PCUSTO.HeaderText = "P. Custo";
            col_PCUSTO.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_PCUSTO);

            DataGridViewTextBoxColumn col_IPI = new DataGridViewTextBoxColumn();
            col_IPI.Name = "IPI";
            col_IPI.HeaderText = "IPI";
            col_IPI.Width = 90;
            col_IPI.Visible = false;
            dgv_resultado_pesquisa.Columns.Add(col_IPI);

            DataGridViewTextBoxColumn col_OUTROSCUSTO = new DataGridViewTextBoxColumn();
            col_OUTROSCUSTO.Name = "OUTROCUSTO";
            col_OUTROSCUSTO.HeaderText = "O. Custos";
            col_OUTROSCUSTO.Width = 90;
            col_OUTROSCUSTO.Visible = false;

            dgv_resultado_pesquisa.Columns.Add(col_OUTROSCUSTO);

            DataGridViewTextBoxColumn col_DESCONTO = new DataGridViewTextBoxColumn();
            col_DESCONTO.Name = "DESCONTO";
            col_DESCONTO.HeaderText = "Desconto";
            col_DESCONTO.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_DESCONTO);

            DataGridViewTextBoxColumn col_TOTALUNT = new DataGridViewTextBoxColumn();
            col_TOTALUNT.Name = "TOTALUNT";
            col_TOTALUNT.HeaderText = "Total Unt";
            col_TOTALUNT.Width = 90;
            col_TOTALUNT.Visible = false;
            dgv_resultado_pesquisa.Columns.Add(col_TOTALUNT);

            DataGridViewTextBoxColumn col_TOTAL = new DataGridViewTextBoxColumn();
            col_TOTAL.Name = "TOTAL";
            col_TOTAL.HeaderText = "TOTAL";
            col_TOTAL.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_TOTAL);


            #endregion

            #region MONTAR GRID CONTAS A RECEBER

            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.Name = "ID";
            col_ID.HeaderText = "ID";
            col_ID.Width = 100;
            dgv_formaPagto.Columns.Add(col_ID);

            DataGridViewTextBoxColumn col_VALOR = new DataGridViewTextBoxColumn();
            col_VALOR.Name = "VALOR";
            col_VALOR.HeaderText = "VALOR";
            col_VALOR.Width = 100;
            dgv_formaPagto.Columns.Add(col_VALOR);

            DataGridViewTextBoxColumn col_DTVENC = new DataGridViewTextBoxColumn();
            col_DTVENC.Name = "VENCIMENTO";
            col_DTVENC.HeaderText = "VENCIMENTO";
            col_DTVENC.Width = 100;
            dgv_formaPagto.Columns.Add(col_DTVENC);

            DataGridViewTextBoxColumn col_DTPGTO = new DataGridViewTextBoxColumn();
            col_DTPGTO.Name = "PAGAMENTO";
            col_DTPGTO.HeaderText = "PAGAMENTO";
            col_DTPGTO.Width = 100;
            dgv_formaPagto.Columns.Add(col_DTPGTO);

            DataGridViewTextBoxColumn col_VLREXTENSO = new DataGridViewTextBoxColumn();
            col_VLREXTENSO.Name = "VLREXTENSO";
            col_VLREXTENSO.HeaderText = "VLREXTENSO";
            col_VLREXTENSO.Visible = false;
            dgv_formaPagto.Columns.Add(col_VLREXTENSO);


            DataGridViewTextBoxColumn col_IDMOEDA = new DataGridViewTextBoxColumn();
            col_IDMOEDA.Name = "IDMOEDA";
            col_IDMOEDA.HeaderText = "CÓD MOEDA";
            col_IDMOEDA.Width = 90;
            dgv_formaPagto.Columns.Add(col_IDMOEDA);

            DataGridViewTextBoxColumn col_MOEDA = new DataGridViewTextBoxColumn();
            col_MOEDA.Name = "MOEDA";
            col_MOEDA.HeaderText = "MOEDA";
            col_MOEDA.Width = 180;
            dgv_formaPagto.Columns.Add(col_MOEDA);


            DataGridViewTextBoxColumn col_IDBANCOCONTA = new DataGridViewTextBoxColumn();
            col_IDBANCOCONTA.Name = "IDBANCOCONTA";
            col_IDBANCOCONTA.HeaderText = "CÓD BANCO";
            col_IDBANCOCONTA.Width = 90;
            dgv_formaPagto.Columns.Add(col_IDBANCOCONTA);

            DataGridViewTextBoxColumn col_BANCOCONTA = new DataGridViewTextBoxColumn();
            col_BANCOCONTA.Name = "BANCOCONTA";
            col_BANCOCONTA.HeaderText = "BANCOCONTA";
            col_BANCOCONTA.Width = 180;
            dgv_formaPagto.Columns.Add(col_BANCOCONTA);

          

            #endregion

            #region MONTAR GRID CONTA A PAGAR

         

            DataGridViewTextBoxColumn col_ID1 = new DataGridViewTextBoxColumn();
            col_ID1.Name = "ID";
            col_ID1.HeaderText = "LANÇAMENTO";
            col_ID1.Width = 100;
            dgv_Contas_Pagar.Columns.Add(col_ID1);

          
            DataGridViewTextBoxColumn col_VALOR1 = new DataGridViewTextBoxColumn();
            col_VALOR1.Name = "VALOR1";
            col_VALOR1.HeaderText = "VALOR";
            col_VALOR1.Width = 100;
            dgv_Contas_Pagar.Columns.Add(col_VALOR1);

            DataGridViewTextBoxColumn col_VLRDESC = new DataGridViewTextBoxColumn();
            col_VLRDESC.Name = "VLRDESC";
            col_VLRDESC.HeaderText = "DESCONTO";
            col_VLRDESC.Width = 100;
            dgv_Contas_Pagar.Columns.Add(col_VLRDESC);

            DataGridViewTextBoxColumn col_VLRJUROS = new DataGridViewTextBoxColumn();
            col_VLRJUROS.Name = "VLRJUROS";
            col_VLRJUROS.HeaderText = "JUROS";
            col_VLRJUROS.Width = 100;
            dgv_Contas_Pagar.Columns.Add(col_VLRJUROS);

            DataGridViewTextBoxColumn col_VLRTOTAL = new DataGridViewTextBoxColumn();
            col_VLRTOTAL.Name = "VLRTOTAL";
            col_VLRTOTAL.HeaderText = "TOTAL";
            col_VLRTOTAL.Width = 100;
            dgv_Contas_Pagar.Columns.Add(col_VLRTOTAL);

            DataGridViewTextBoxColumn col_IDPARCEIRO = new DataGridViewTextBoxColumn();
            col_IDPARCEIRO.Name = "IDPARCEIRO";
            col_IDPARCEIRO.HeaderText = "CÓD. PARC";
            col_IDPARCEIRO.Width = 120;
            dgv_Contas_Pagar.Columns.Add(col_IDPARCEIRO);

            DataGridViewTextBoxColumn col_PARCEIRO = new DataGridViewTextBoxColumn();
            col_PARCEIRO.Name = "PARCEIRO";
            col_PARCEIRO.HeaderText = "PARCEIRO";
            col_PARCEIRO.Width = 250;
            dgv_Contas_Pagar.Columns.Add(col_PARCEIRO);



            #endregion

          
          
        }
        private void pesquisarProduto()
        {
            conexao.Abre_Conexao();
            SQLCunsultaEmpr = "SELECT * FROM TBPRODUTO WHERE DTEXCLUSAO IS NULL AND CODAUXILIAR = '" + tboxLocalizarProduto.Text + "'";



            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;
            
            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();

            int o = 0;


            while (conexao.dataReader.Read())
            {
                tboxCodigo.Text = conexao.dataReader["ID"].ToString();
                tboxDescricao.Text = conexao.dataReader["DESCRICAO"].ToString();
                tboxCodAuxiliar.Text = conexao.dataReader["CODAUXILIAR"].ToString();
                tboxUnd.Text = conexao.dataReader["MEDIDA"].ToString();
                tboxPCusto.Text = conexao.dataReader["PVENDA"].ToString();

                dgv_resultado_pesquisa.DefaultCellStyle.ForeColor = Color.Black;

                o++;
            }
            if (o == 0)
            {
                MessageBox.Show("Nenhum produto cadastrado com os dados informados","Clever Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            conexao.Fecha_Conexao();
        }
        private void calcularPreçoItem()
        {
            qtdeUnt       = Convert.ToDecimal(tboxQtde.Text);
            pcustoUnt     = Convert.ToDecimal(tboxPCusto.Text);
            descontoUnt   = Convert.ToDecimal(tboxDesconto.Text); ;

            ipiUnt = (ipiUnt * pcustoUnt / 100);

            totalUnit = ((pcustoUnt + ipiUnt + outroCustoUnt) - descontoUnt) * qtdeUnt;
            pliquidoUnt = ((pcustoUnt + ipiUnt + outroCustoUnt) - descontoUnt);


            tboxTotal.Text     = Conversor.converterMoeda(Convert.ToString(totalUnit));

        }
        private void calcularTotalPedido()
        {
            decimal qtdeTotal = 0;
            decimal pcustoTotal = 0;
            decimal descontoTotal = 0;
            decimal totalTotal = 0;

        

            for (int i = 0; i < dgv_resultado_pesquisa.Rows.Count; i++)
            {
                qtdeTotal       += i;
                pcustoTotal     += Convert.ToDecimal(dgv_resultado_pesquisa.Rows[i].Cells["PCUSTO"].Value.ToString());
                descontoTotal   += Convert.ToDecimal(dgv_resultado_pesquisa.Rows[i].Cells["DESCONTO"].Value.ToString());
                totalTotal      += Convert.ToDecimal(dgv_resultado_pesquisa.Rows[i].Cells["TOTAL"].Value.ToString());


                dgv_formaPagto.DefaultCellStyle.ForeColor = Color.Black;
                dgv_resultado_pesquisa.Rows[i].Cells["ITEM"].Value = i + 1;
            }

        
            tboxQtdeTotal.Text        = Convert.ToString(dgv_resultado_pesquisa.Rows.Count);
            tboxDescontoTotal.Text    = Convert.ToString(descontoTotal);
            tboxTotalTotal.Text       = Convert.ToString(totalTotal);
            tbox_TotalFinal.Text      = Convert.ToString(totalTotal);
        }
        private void calcularTotalParcelas()
        {
            decimal totalPedido = 0;

            for (int i = 0; i < dgv_formaPagto.Rows.Count; i++)
            {
                totalPedido += Convert.ToDecimal(dgv_formaPagto.Rows[i].Cells["VALOR"].Value.ToString());
               // dgv_formaPagto.Rows[i].Cells["SEQ"].Value = i + 1;
                dgv_formaPagto.DefaultCellStyle.ForeColor = Color.Black;
            }

            tbox_TotalParcelas.Text = Convert.ToString(totalPedido);
        }
        private void limparCamposProduto()
        {
            tboxItem.Clear();
            tboxCodigo.Text = "";
            tboxNumDoc.Text = "";
            tboxDescricao.Text = "";
            tboxCodAuxiliar.Text = "";
            tboxUnd.Text = "";
            tboxQtde.Text = "0,00";
            tboxPCusto.Text = "0,00";
            tboxDesconto.Text = "0,00";
            tboxTotal.Text = "0,00";
            btnRemover.Enabled = false;
            tboxLocalizarProduto.Focus();
            tboxLocalizarProduto.Clear();
        }
        private void gravarPedido()
        {
            string numPed = null;

            if (tboxNumDoc.Text != "")
            {
                numPed = tboxNumDoc.Text;
            }
            conexao.Abre_Conexao();
            string SQLCunsultaEmpr = " INSERT INTO TBOS(  " +
                                         " IDFUNCLANC        " +
                                         " ,NUMDOC           " +
                                         " ,DTLANC           " +
                                         " ,IDCLIENTE        " +
                                         " ,PRAZO            " +
                                         " ,DTMEDICAO        " +
                                         " ,DTFABRICACAO     " +
                                         " ,DTART            " +
                                         " ,DTINSTALACAO     " +
                                         " ,DTFINALIZADO     " +
                                         " ,OBS )            " +
                                      " VALUES (             " +
                                         "  @IDFUNCLANC      " +
                                         " ,@NUMDOC          " +
                                         " ,@DTLANC          " +
                                         " ,@IDCLIENTE       " +
                                         " ,@PRAZO           " +
                                         " ,@DTMEDICAO       " +
                                         " ,@DTFABRICACAO    " +
                                         " ,@DTART           " +
                                         " ,@DTINSTALACAO    " +
                                         " ,@DTFINALIZADO    " +
                                         " ,@OBS )           ";


            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;
            conexao.cmd.Parameters.AddWithValue("IDFUNCLANC",   idFunc);
            conexao.cmd.Parameters.AddWithValue("NUMDOC",       numPed);
            conexao.cmd.Parameters.AddWithValue("DTLANC",       Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd"));
            conexao.cmd.Parameters.AddWithValue("IDCLIENTE",    1);
            conexao.cmd.Parameters.AddWithValue("PRAZO",        tboxPrazo.Text);
            conexao.cmd.Parameters.AddWithValue("DTMEDICAO",    dtMedicao);
            conexao.cmd.Parameters.AddWithValue("DTFABRICACAO", dtFabricao);
            conexao.cmd.Parameters.AddWithValue("DTART",        dtART);
            conexao.cmd.Parameters.AddWithValue("DTINSTALACAO", dtInstalacao);
            conexao.cmd.Parameters.AddWithValue("DTFINALIZADO", dtFinalizado);
            conexao.cmd.Parameters.AddWithValue("OBS",          "");

            conexao.cmd.ExecuteNonQuery();
            retornaUltimoPedido();

        }
        private void atualizarPedido()
        {
            try
            {
                conexao.Abre_Conexao();
                string SQLCunsultaEmpr = " UPDATE  TBOS SET " +
                                             "  IDCLIENTE    =  @IDCLIENTE      " +
                                             " ,NUMDOC       =  @NUMDOC         " +
                                             " ,PRAZO        =  @PRAZO          " +
                                             " ,DTMEDICAO    =  @DTMEDICAO      " +
                                             " ,DTFABRICACAO =  @DTFABRICACAO   " +
                                             " ,DTART        =  @DTART          " +
                                             " ,DTINSTALACAO =  @DTINSTALACAO   " +
                                             " ,DTFINALIZADO =  @DTFINALIZADO   " +
                                             " ,OBS         =  @OBS           " +
                                             " WHERE    IDOS = " + tboxNumOS.Text;


                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;
                conexao.cmd.Parameters.AddWithValue("IDCLIENTE", codParceiro);
                conexao.cmd.Parameters.AddWithValue("PRAZO", tboxPrazo.Text);
                conexao.cmd.Parameters.AddWithValue("NUMDOC", tboxNumDoc.Text);
                //Convert.ToDateTime(tboxDtMedicao.Value.ToShortDateString()).ToString("yyyy-MM-dd")
                //dtMedicao = Convert.ToDateTime(tboxDtMedicao.Value.ToShortDateString()).ToString("yyyy-MM-dd");
                conexao.cmd.Parameters.AddWithValue("DTMEDICAO", dtMedicao);
                conexao.cmd.Parameters.AddWithValue("DTFABRICACAO", dtFabricao);
                conexao.cmd.Parameters.AddWithValue("DTART", dtART);
                conexao.cmd.Parameters.AddWithValue("DTINSTALACAO", dtInstalacao);
                conexao.cmd.Parameters.AddWithValue("DTFINALIZADO", dtFinalizado);
                conexao.cmd.Parameters.AddWithValue("OBS", "");

                conexao.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string frase = ex.Message;
                string palavra = "UNIQUE";

                if (frase.Contains(palavra))
                {
                    MessageBox.Show("Pedido já cadastrado", "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
           

        }
        private void retornaUltimoPedido()
        {
            conexao.Abre_Conexao();
            SQLCunsultaEmpr = "SELECT MAX(IDOS) FROM TBOS";



            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();



            while (conexao.dataReader.Read())
            {
                tboxNumOS.Text = conexao.dataReader[0].ToString();
            }
            conexao.Fecha_Conexao();

        }
        private void gravarItens()
        {
              conexao.Abre_Conexao();

           
                string SQLCunsultaEmpr = "INSERT INTO TBOS_ITENS " +
                                          " (SEQ       " +
                                          " ,IDPEDIDO   " +
                                          " ,CODPROD   " +
                                          " ,QTDE      " +
                                          " ,PCUSTO    " +
                                          " ,DESCONTO  " +
                                          " ,TOTAL)     " +
                                         " VALUES       " +
                                          " (@SEQ       " +
                                          " ,@IDPEDIDO  " +
                                          " ,@CODPROD   " +
                                          " ,@QTDE      " +
                                          " ,@PCUSTO    " +
                                          " ,@DESCONTO  " +
                                          " ,@TOTAL)     ";


                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;
                conexao.cmd.Parameters.AddWithValue("SEQ",        1);
                conexao.cmd.Parameters.AddWithValue("IDPEDIDO",    tboxNumOS.Text);
                conexao.cmd.Parameters.AddWithValue("CODPROD",    tboxCodigo.Text);
                conexao.cmd.Parameters.AddWithValue("QTDE",       tboxQtde.Text);
                conexao.cmd.Parameters.AddWithValue("PCUSTO",     tboxPCusto.Text);
                conexao.cmd.Parameters.AddWithValue("DESCONTO",   tboxDesconto.Text);
                conexao.cmd.Parameters.AddWithValue("TOTAL",      tboxTotal.Text);
                conexao.cmd.ExecuteNonQuery();
            
        }
        private void pequisarItens()
        {

            dgv_resultado_pesquisa.Rows.Clear();
            conexao.Abre_Conexao();

            string SQLCunsultaEmpr =    "SELECT           " +
                                        "  I.SEQ       " +
                                        " ,I.IDPEDIDO  " +
                                        " ,I.CODPROD   " +
                                        " ,P.DESCRICAO " +
                                        " ,P.CODAUXILIAR " +
                                        " ,P.MEDIDA "   +
                                        " ,I.QTDE      " +
                                        " ,I.PCUSTO    " +
                                        " ,I.DESCONTO  " +
                                        " ,I.TOTAL     " +
                                       " FROM          " +
                                        " TBOS_ITENS I,     " +
                                        " TBPRODUTO  P      " +
                                        "WHERE       " +
                                        " I.CODPROD = P.ID AND " +
                                        " I.IDPEDIDO = @IDPEDIDO ";
                                        


                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;
               conexao.cmd.Parameters.AddWithValue("IDPEDIDO", tboxNumOS.Text);
                conexao.cmd.ExecuteNonQuery();


            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();

            int o = 0;


            while (conexao.dataReader.Read())
            {
                dgv_resultado_pesquisa.Rows.Add();
                
                dgv_resultado_pesquisa.Rows[o].Cells["ITEM"].Value = o + 1;
                dgv_resultado_pesquisa.Rows[o].Cells["CODPROD"].Value   = conexao.dataReader["CODPROD"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["DESCRICAO"].Value = conexao.dataReader["DESCRICAO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["CODBARRA"].Value  = conexao.dataReader["CODAUXILIAR"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["UND"].Value       = conexao.dataReader["MEDIDA"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["QTDE"].Value      = Conversor.converterMoeda(conexao.dataReader["QTDE"].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["PCUSTO"].Value    = Conversor.converterMoeda(conexao.dataReader["PCUSTO"].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["DESCONTO"].Value  = Conversor.converterMoeda(conexao.dataReader["DESCONTO"].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["TOTAL"].Value     = Conversor.converterMoeda(conexao.dataReader["TOTAL"].ToString());
                o++;
            }
        }
        public void ajustarEstoque()
        {

            conexao.Abre_Conexao();

            for (int i = 0; i < dgv_resultado_pesquisa.Rows.Count; i++)
            {


                string SQLCunsultaEmpr = "UPDATE TBPRODUTO SET ESTOQUE = (ESTOQUE + @QTDE), PCUSTO = @PCUSTO WHERE ID =  " + dgv_resultado_pesquisa.Rows[i].Cells["CODPROD"].Value.ToString();



                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;
                conexao.cmd.Parameters.AddWithValue("QTDE", dgv_resultado_pesquisa.Rows[i].Cells["QTDE"].Value.ToString());
                conexao.cmd.Parameters.AddWithValue("PCUSTO", dgv_resultado_pesquisa.Rows[i].Cells["PCUSTO"].Value.ToString());

                conexao.cmd.ExecuteNonQuery();

            }



            conexao.Fecha_Conexao();

        }
        private void gravar_ContasReceber()
        {

            if (Convert.ToDecimal(tboxValor.Text) == 0 )
            {
                MessageBox.Show("Informe o valor total da duplicata.", "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tboxValor.Focus();
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

            // Gravar valor Extensso
           
              string  valor_Extenso = Conversor.EscreverExtenso(Convert.ToDecimal(tboxValor.Text));
           
            //* fim gravar valor Extensso

            try
            {
                
                    #region INSERT
                    conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = " INSERT INTO TBCR " +
                                                    " (TIPO                   " +
                                                    " ,IDFILIAL               " +
                                                    " ,IDPARCEIRO             " +
                                                    " ,IDMOEDA                " +
                                                    " ,IDCONTA                " +
                                                    " ,IDCONTAGERENCIAL       " +
                                                    " ,HISTORICO              " +
                                                    " ,NUMDOC                 " +
                                                    " ,DTLANC                 " +
                                                    " ,DTVENC                 " +
                                                    " ,DTCOMPETENCIA          " +
                                                    " ,VALOR                  " +
                                                    " ,VLRDESC                " +
                                                    " ,VLRJUROS               " +
                                                    " ,VLRTOTAL               " +
                                                    " ,IDOS                   " +
                                                    " ,VLREXTENSO)            " +
                                                    " VALUES                  " +
                                                    " (@TIPO                  " +
                                                    " ,@IDFILIAL              " +
                                                    " ,@IDPARCEIRO            " +
                                                    " ,@IDMOEDA               " +
                                                    " ,@IDCONTA               " +
                                                    " ,@IDCONTAGERENCIAL      " +
                                                    " ,@HISTORICO             " +
                                                    " ,@NUMDOC                " +
                                                    " ,@DTLANC                " +
                                                    " ,@DTVENC                " +
                                                    " ,@DTCOMPETENCIA         " +
                                                    " ,@VALOR                 " +
                                                    " ,@VLRDESC               " +
                                                    " ,@VLRJUROS              " +
                                                    " ,@VLRTOTAL              " +
                                                    " ,@IDOS                  " +
                                                    " ,@VLREXTENSO)           ";


                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;           
                    conexao.cmd.Parameters.AddWithValue("TIPO",             "C");
                    conexao.cmd.Parameters.AddWithValue("IDFILIAL",         codFilial);
                    conexao.cmd.Parameters.AddWithValue("IDPARCEIRO",       codParceiro);
                    conexao.cmd.Parameters.AddWithValue("IDMOEDA",          codMoeda);
                    conexao.cmd.Parameters.AddWithValue("IDCONTA",          codBancoConta);
                    conexao.cmd.Parameters.AddWithValue("IDCONTAGERENCIAL", 3);
                    conexao.cmd.Parameters.AddWithValue("HISTORICO",       "REF.: A DUPLICATAS DA OS: " + tboxNumOS.Text);
                    conexao.cmd.Parameters.AddWithValue("NUMDOC",           tboxNumDoc.Text);
                    conexao.cmd.Parameters.AddWithValue("DTLANC",           tboxDtLanc.Text);
                    conexao.cmd.Parameters.AddWithValue("DTVENC",           tbox_DtVenc.Text);
                    conexao.cmd.Parameters.AddWithValue("DTCOMPETENCIA",    tbox_DtVenc.Text);
                    conexao.cmd.Parameters.AddWithValue("VALOR",            Conversor.converterMoeda(tboxValor.Text));
                    conexao.cmd.Parameters.AddWithValue("VLRDESC",          Conversor.converterMoeda("0,00"));
                    conexao.cmd.Parameters.AddWithValue("VLRJUROS",         Conversor.converterMoeda("0,00"));
                    conexao.cmd.Parameters.AddWithValue("VLRTOTAL",         Conversor.converterMoeda(tboxValor.Text));
                    conexao.cmd.Parameters.AddWithValue("IDOS",             tboxNumOS.Text); 
                    conexao.cmd.Parameters.AddWithValue("VLREXTENSO",       valor_Extenso);


                    conexao.cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro realizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conexao.Fecha_Conexao();
                    #endregion

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }




        }
        private void pesquisar_ContasReceber()
        {
           
            conexao.Abre_Conexao();
            dgv_formaPagto.Rows.Clear();



            SQLCunsultaEmpr = " SELECT                    " +
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
                                     " ,F.IDVENDA              " +
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
                                     " F.TIPO =  'C'         AND IDOS = " + tboxNumOS.Text;
                                   
             

            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();

            int o = 0;


            while (conexao.dataReader.Read())
            {
                dgv_formaPagto.Rows.Add();
                dgv_formaPagto.Rows[o].Cells["ID"].Value                 = conexao.dataReader["ID"].ToString();
                dgv_formaPagto.Rows[o].Cells["IDMOEDA"].Value             = conexao.dataReader["IDMOEDA"].ToString();
                dgv_formaPagto.Rows[o].Cells["MOEDA"].Value               = conexao.dataReader["MOEDA"].ToString();
                dgv_formaPagto.Rows[o].Cells["IDBANCOCONTA"].Value        = conexao.dataReader["IDCONTA"].ToString();
                dgv_formaPagto.Rows[o].Cells["BANCOCONTA"].Value          = conexao.dataReader["CONTA"].ToString();
                dgv_formaPagto.Rows[o].Cells["VENCIMENTO"].Value           = conexao.dataReader["DTVENC"].ToString();
                dgv_formaPagto.Rows[o].Cells["PAGAMENTO"].Value              = conexao.dataReader["DTPGTO"].ToString();
                dgv_formaPagto.Rows[o].Cells["VALOR"].Value               =  Conversor.converterMoeda(conexao.dataReader["VALOR"].ToString());
                dgv_formaPagto.DefaultCellStyle.ForeColor = Color.Black;

               
                o++;
            }
            decimal total = 0;
            decimal valor = 0;
            decimal desconto = 0;
            decimal juros = 0;
            for (int i = 0; i < dgv_formaPagto.RowCount; i++)
            {
                //total = total + Convert.ToDecimal(dgv_formaPagto.Rows[i].Cells["VLRTOTAL"].Value.ToString());
                //valor = valor + Convert.ToDecimal(dgv_formaPagto.Rows[i].Cells["VALOR"].Value.ToString());
                //desconto = desconto + Convert.ToDecimal(dgv_formaPagto.Rows[i].Cells["VLRDESC"].Value.ToString());
                //juros = juros + Convert.ToDecimal(dgv_formaPagto.Rows[i].Cells["VLRJUROS"].Value.ToString());

                //    textBox1.Text = "Total R$: " + Convert.ToString(total);
                //    textBox2.Text = "Valor R$: " + Convert.ToString(valor);
                //    textBox3.Text = "Desconto R$: " + Convert.ToString(desconto);
                //    textBox4.Text = "Juros R$: " + Convert.ToString(juros);
                //}

            }
            conexao.Fecha_Conexao();

        }
        private void Excluir_ContaReceber()
        {

            try
            {

                conexao.Abre_Conexao();
                string SQLCunsultaEmpr = " DELETE FROM TBCR WHERE ID  = @ID ";



                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;
                conexao.cmd.Parameters.AddWithValue("ID", dgv_formaPagto.CurrentRow.Cells["ID"].Value.ToString());



                conexao.cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro removido com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Fecha_Conexao();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void gravar_ContaAdicinais()
        {

            if (Convert.ToDecimal(tboxTotalDespesa.Text) == 0)
            {
                MessageBox.Show("Informe o valor total da duplicata.", "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tboxTotal.Focus();
                return;
            }

            if (tboxFornecedor.Text == "")
            {
                MessageBox.Show("Campo Parceiro é obrigatorio.", "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tboxParceiro.Focus();
                return;
            }

            // Gravar valor Extensso

            string valor_Extenso = Conversor.EscreverExtenso(Convert.ToDecimal(tboxTotalDespesa.Text));

            //* fim gravar valor Extensso

            try
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
                                                " ,IDOS                  " +
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
                                                " ,@IDOS              " +
                                                " ,@VLREXTENSO)             ";


                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;
                conexao.cmd.Parameters.AddWithValue("TIPO", "D");
                conexao.cmd.Parameters.AddWithValue("IDFILIAL", codFilial);
                conexao.cmd.Parameters.AddWithValue("IDPARCEIRO", codFornec);
                conexao.cmd.Parameters.AddWithValue("IDMOEDA", 1);
                conexao.cmd.Parameters.AddWithValue("IDCONTA", 1);
                conexao.cmd.Parameters.AddWithValue("IDCONTAGERENCIAL", codContaGerencial);
                conexao.cmd.Parameters.AddWithValue("HISTORICO", "DESPESA COMPLEMENTAR DA OS: " + tboxNumOS.Text);
                conexao.cmd.Parameters.AddWithValue("NUMDOC",        tboxNumDoc.Text);
                conexao.cmd.Parameters.AddWithValue("DTLANC",        tboxDtLanc.Text);
                conexao.cmd.Parameters.AddWithValue("DTVENC",        tboxDtVenc.Text);
                conexao.cmd.Parameters.AddWithValue("DTCOMPETENCIA", tboxDtVenc.Text);
                conexao.cmd.Parameters.AddWithValue("VALOR",         Conversor.converterMoeda(tboxValorDespesa.Text));
                conexao.cmd.Parameters.AddWithValue("VLRDESC",       Conversor.converterMoeda(tboxDescontoDespesa.Text));
                conexao.cmd.Parameters.AddWithValue("VLRJUROS",      Conversor.converterMoeda(tboxJurosDespesa.Text));
                conexao.cmd.Parameters.AddWithValue("VLRTOTAL",      Conversor.converterMoeda(tboxTotalDespesa.Text));
                conexao.cmd.Parameters.AddWithValue("VLREXTENSO",    valor_Extenso);
                conexao.cmd.Parameters.AddWithValue("IDOS",          tboxNumOS.Text);


                conexao.cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Fecha_Conexao();
                #endregion


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }




        }
        private void pesquisar_ContaAdicinais()
        {
            conexao.Abre_Conexao();
            dgv_Contas_Pagar.Rows.Clear();


            SQLCunsultaEmpr = " SELECT                    " +
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
                                     " F.TIPO =  'D'      AND IDOS = " + tboxNumOS.Text;



            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();

            int o = 0;


            while (conexao.dataReader.Read())
            {
                dgv_Contas_Pagar.Rows.Add();
                dgv_Contas_Pagar.Rows[o].Cells["ID"].Value = conexao.dataReader["ID"].ToString();
                dgv_Contas_Pagar.Rows[o].Cells["IDPARCEIRO"].Value = conexao.dataReader["IDPARCEIRO"].ToString();
                dgv_Contas_Pagar.Rows[o].Cells["PARCEIRO"].Value = conexao.dataReader["RAZAOSOCIAL"].ToString();
                dgv_Contas_Pagar.Rows[o].Cells["VALOR1"].Value = Conversor.converterMoeda(conexao.dataReader["VALOR"].ToString());
                dgv_Contas_Pagar.Rows[o].Cells["VLRDESC"].Value = Conversor.converterMoeda(conexao.dataReader["VLRDESC"].ToString());
                dgv_Contas_Pagar.Rows[o].Cells["VLRJUROS"].Value = Conversor.converterMoeda(conexao.dataReader["VLRJUROS"].ToString());
                dgv_Contas_Pagar.Rows[o].Cells["VLRTOTAL"].Value = Conversor.converterMoeda(conexao.dataReader["VLRTOTAL"].ToString());

                o++;
            }
            decimal total = 0;
            decimal valor = 0;
            decimal desconto = 0;
            decimal juros = 0;
            for (int i = 0; i < dgv_Contas_Pagar.RowCount; i++)
            {
                total = total + Convert.ToDecimal(dgv_Contas_Pagar.Rows[i].Cells["VLRTOTAL"].Value.ToString());
                valor = valor + Convert.ToDecimal(dgv_Contas_Pagar.Rows[i].Cells["VALOR1"].Value.ToString());
                desconto = desconto + Convert.ToDecimal(dgv_Contas_Pagar.Rows[i].Cells["VLRDESC"].Value.ToString());
                juros = juros + Convert.ToDecimal(dgv_Contas_Pagar.Rows[i].Cells["VLRJUROS"].Value.ToString());

                //textBox1.Text = "Total R$: " + Convert.ToString(total);
                //textBox2.Text = "Valor R$: " + Convert.ToString(valor);
                //textBox3.Text = "Desconto R$: " + Convert.ToString(desconto);
                //textBox4.Text = "Juros R$: " + Convert.ToString(juros);
            }


            conexao.Fecha_Conexao();

        }
        private void Excluir_ContaAdicinais()
        {

            try
            {
              
                conexao.Abre_Conexao();
                string SQLCunsultaEmpr = " DELETE FROM TBCP WHERE ID  = @ID ";



                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;
                conexao.cmd.Parameters.AddWithValue("ID", dgv_Contas_Pagar.CurrentRow.Cells["ID"].Value.ToString());



                conexao.cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro removido com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Fecha_Conexao();
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void CalcularDespesas()
        {
            decimal valorDespesa;
            decimal descontoDespesa;
            decimal jurosDespesa;
            decimal totalDespesa;

            valorDespesa = Convert.ToDecimal(tboxValorDespesa.Text);
            descontoDespesa = Convert.ToDecimal(tboxDescontoDespesa.Text);
            jurosDespesa = Convert.ToDecimal(tboxJurosDespesa.Text);
            totalDespesa = (valorDespesa + jurosDespesa) - descontoDespesa;

            tboxTotalDespesa.Text = Convert.ToString(totalDespesa);

        }
        private void gravarContasPagar()
        {
            conexao.Abre_Conexao();
            for (int i = 0; i < dgv_formaPagto.RowCount; i++)
            {

                 string SQLCunsultaEmpr = " INSERT INTO TBCP " +
                                                    " (TIPO                   " +
                                                    " ,IDFILIAL               " +
                                                    " ,IDPARCEIRO             " +
                                                    " ,IDMOEDA                " +
                                                    " ,IDCONTA                " +
                                                    " ,IDCONTAGERENCIAL       " +
                                                    " ,HISTORICO              " +
                                                    " ,NUMDOC                 " +
                                                    " ,DTLANC                 " +
                                                    " ,DTVENC                 " +
                                                    " ,DTCOMPETENCIA          " +
                                                    " ,VALOR                  " +
                                                    " ,VLRDESC                " +
                                                    " ,VLRJUROS               " +
                                                    " ,VLRTOTAL               " +
                                                    " ,IDVENDA                " +
                                                    " ,VLREXTENSO)            " +
                                                    " VALUES                  " +
                                                    " (@TIPO                  " +
                                                    " ,@IDFILIAL              " +
                                                    " ,@IDPARCEIRO            " +
                                                    " ,@IDMOEDA               " +
                                                    " ,@IDCONTA               " +
                                                    " ,@IDCONTAGERENCIAL      " +
                                                    " ,@HISTORICO             " +
                                                    " ,@NUMDOC                " +
                                                    " ,@DTLANC                " +
                                                    " ,@DTVENC                " +
                                                    " ,@DTCOMPETENCIA         " +
                                                    " ,@VALOR                 " +
                                                    " ,@VLRDESC               " +
                                                    " ,@VLRJUROS              " +
                                                    " ,@VLRTOTAL              " +
                                                    " ,@IDVENDA               " +
                                                    " ,@VLREXTENSO)           ";


                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;           
                    conexao.cmd.Parameters.AddWithValue("TIPO",          "D");
                    conexao.cmd.Parameters.AddWithValue("IDFILIAL",      codFilial);
                    conexao.cmd.Parameters.AddWithValue("IDPARCEIRO",    codFornec);
                    conexao.cmd.Parameters.AddWithValue("IDMOEDA",       "1");
                    conexao.cmd.Parameters.AddWithValue("IDCONTA",       "1");
                    conexao.cmd.Parameters.AddWithValue("IDCONTAGERENCIAL",   "12");
                    conexao.cmd.Parameters.AddWithValue("HISTORICO",    "Ref.: A COMPRA DE MERCADORIA PARA A REVENDA NOTA : " + tboxNumOS.Text);
                    conexao.cmd.Parameters.AddWithValue("NUMDOC",        tboxNumDoc.Text);
                    conexao.cmd.Parameters.AddWithValue("DTLANC",        DateTime.Now.ToShortDateString());
                    conexao.cmd.Parameters.AddWithValue("DTVENC",        null); 
                    conexao.cmd.Parameters.AddWithValue("DTCOMPETENCIA", dgv_formaPagto.Rows[i].Cells["DTVENC"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("VALOR",         dgv_formaPagto.Rows[i].Cells["VALOR"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("VLRDESC",       "0,00");
                    conexao.cmd.Parameters.AddWithValue("VLRJUROS",      "0,00");
                    conexao.cmd.Parameters.AddWithValue("VLRTOTAL",       dgv_formaPagto.Rows[i].Cells["VALOR"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("IDVENDA",        tboxNumOS.Text);
                    conexao.cmd.Parameters.AddWithValue("VLREXTENSO",     dgv_formaPagto.Rows[i].Cells["VLREXTENSO"].Value.ToString());

                    conexao.cmd.ExecuteNonQuery();

             }
                    conexao.Fecha_Conexao();
        }
        private void btn_Incluir_Click(object sender, EventArgs e)
        {
             if (Convert.ToDecimal(tboxTotal.Text) <= 0)
            {
                return;
            }
         
            if (tboxCodigo.Text == "")
            {
                return;
            }
            gravarItens();
            pequisarItens();
            calcularTotalPedido();
            limparCamposProduto();
        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {

                conexao.Abre_Conexao();
                string SQLCunsultaEmpr = " DELETE FROM TBOS_ITENS WHERE CODPROD = @CODPROD AND IDPEDIDO = @IDPEDIDO ";

                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;
                conexao.cmd.Parameters.AddWithValue("CODPROD", dgv_resultado_pesquisa.CurrentRow.Cells["CODPROD"].Value.ToString());
                conexao.cmd.Parameters.AddWithValue("IDPEDIDO", tboxNumOS.Text);



                conexao.cmd.ExecuteNonQuery();


                conexao.Fecha_Conexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            pequisarItens();

        }
        private void tboxLocalizarProduto_Enter(object sender, EventArgs e)
        {
            limparCamposProduto();
        }
        private void frmOrdemServico_Load(object sender, EventArgs e)
        {
            iniciarForm();
           

            if (novoEditar == "Novo")
            {
                gravarPedido();
                retornaUltimoPedido();
            }
            else if( novoEditar == "Editar")
            {
                pequisarItens();
                pesquisar_ContaAdicinais();
                pesquisar_ContasReceber();
                atualizarPedido();
                CalcularDespesas();
                calcularPreçoItem();
                calcularTotalParcelas();
                calcularTotalPedido();
            }

        }
        private void tboxPrazo_Leave(object sender, EventArgs e)
        {
            try
            {
                tboxPrazo.Text = Convert.ToString(Convert.ToInt32(tboxPrazo.Text));
                atualizarPedido();
            }
            catch (Exception)
            {

                tboxPrazo.Text = "0";
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (tboxLocalizarProduto.Text != "")
            {
                pesquisarProduto();
            }
        }
        private void tboxLocalizarProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tboxLocalizarProduto.Text != "")
                {
                    pesquisarProduto();
                }
            }
        }
        private void btnI_incluirContasPagar_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(tboxValor.Text) <= 0)
            {
                return;
            }
            if (Convert.ToDecimal(tbox_TotalParcelas.Text) > Convert.ToDecimal(tbox_TotalFinal.Text))
            {
                MessageBox.Show("O VAlor das parcelas não pode ser maior que o valor do pedido");
            }

            for (int i = 0; i < Convert.ToDouble(tboxQtdeParcelar.Text); i++)
            {
                gravar_ContasReceber();
                tbox_DtVenc.Value.Date.AddDays(30);

            }
            pesquisar_ContasReceber();
            calcularTotalParcelas();
        }
        private void tboxQtde_Leave(object sender, EventArgs e)
        {
            tboxQtde.Text = Conversor.converterMoeda(tboxQtde.Text);
            calcularPreçoItem();
        }
        private void tboxPCusto_Leave(object sender, EventArgs e)
        {
            tboxPCusto.Text = Conversor.converterMoeda(tboxPCusto.Text);
            calcularPreçoItem();
        }
        private void tboxDesconto_Leave(object sender, EventArgs e)
        {
            tboxDesconto.Text = Conversor.converterMoeda(tboxDesconto.Text);
            calcularPreçoItem();
        }
        private void tboxTotal_Leave(object sender, EventArgs e)
        {
            tboxTotal.Text = Conversor.converterMoeda(tboxTotal.Text);
            calcularPreçoItem();
        }
        private void btnPesquisarParceiro_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.RotinaOrigem = "PESQUISAR CLIENTE";
            a.ShowDialog();
            atualizarPedido();
        }
        private void btnGravar_Click(object sender, EventArgs e)
        {
            atualizarPedido();
            this.Close();
        }
        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            frm_ProdutoConsultar a = new frm_ProdutoConsultar(this);
            a.lbl_NomeRotina.Text = "PESQUISAR PRODUTOS";
            a.ShowDialog();
            pesquisarProduto();
        }
        private void cboxMedicao_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxMedicao.Checked == true)
            {
                try
                {
                    tboxDtMedicao.Enabled = true;
                    dtMedicao = Convert.ToDateTime(tboxDtMedicao.Text).ToString("yyyy-MM-dd");
                    atualizarPedido();
                }
                catch (Exception)
                {
                }
               
            }
            if (cboxMedicao.Checked == false)
            {
                tboxDtMedicao.Enabled = false;
                dtMedicao = null;
                atualizarPedido();
            }
        }
        private void cboxFabricacao_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxFabricacao.Checked == true)
            {
                try
                {
                    tboxDtFabricacao.Enabled = true;
                    dtFabricao = Convert.ToDateTime(tboxDtFabricacao.Text).ToString("yyyy-MM-dd");
                    atualizarPedido();

                }
                catch (Exception)
                {
                }
               

            }
            if (cboxFabricacao.Checked == false)
            {
                tboxDtFabricacao.Enabled = false;
                dtFabricao = null;
                atualizarPedido();

            }
        }
        private void cboxART_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxART.Checked == true)
            {
                try
                {
                    tboxDtArt.Enabled = true;
                    dtART = Convert.ToDateTime(tboxDtArt.Text).ToString("yyyy-MM-dd");
                    atualizarPedido();
                }
                catch (Exception)
                {
                }
               

            }
            if (cboxART.Checked == false)
            {
                tboxDtArt.Enabled = false;
                dtART = null;
                atualizarPedido();


            }
        }
        private void cboxInstalacao_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxInstalacao.Checked == true)
            {
                try
                {
                    tboxDtInstalacao.Enabled = true;
                    dtInstalacao = Convert.ToDateTime(tboxDtInstalacao.Text).ToString("yyyy-MM-dd");
                    atualizarPedido();

                }
                catch (Exception)
                {
                }
                
            }
            if (cboxInstalacao.Checked == false)
            {
                tboxDtInstalacao.Enabled = false;
                dtInstalacao = null;
                atualizarPedido();

            }
        }
        private void cboxFinalizado_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxFinalizado.Checked == true)
            {
                try
                {
                    tboxDtFinalizacao.Enabled = true;
                    dtFinalizado = Convert.ToDateTime(tboxDtFinalizacao.Text).ToString("yyyy-MM-dd");
                    atualizarPedido();
                }
                catch (Exception)
                {
                }

            }
            if (cboxFinalizado.Checked == false)
            {
                tboxDtFinalizacao.Enabled = false;
                dtFinalizado = null;
                atualizarPedido();

            }
        }
        private void tboxDtMedicao_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtMedicao = Convert.ToDateTime(tboxDtMedicao.Text).ToString();
                atualizarPedido();
            }
            catch (Exception)
            {

            }
           

        }
        private void tboxDtFabricacao_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtFabricao = Convert.ToDateTime(tboxDtFabricacao.Text).ToString("yyyy-MM-dd");
                atualizarPedido();
            }
            catch (Exception)
            {
            }
           

        }
        private void tboxDtArt_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtART = Convert.ToDateTime(tboxDtArt.Text).ToString("yyyy-MM-dd");
                atualizarPedido();
            }
            catch (Exception)
            {
            }
           

        }
        private void tboxDtInstalacao_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtInstalacao = Convert.ToDateTime(tboxDtInstalacao.Text).ToString("yyyy-MM-dd");
                atualizarPedido();
            }
            catch (Exception)
            {
            }
            

        }
        private void tboxDtFinalizacao_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                dtFinalizado = Convert.ToDateTime(tboxDtFinalizacao.Text).ToString("yyyy-MM-dd");
                atualizarPedido();
            }
            catch (Exception)
            {
            }
           

        }

        //***** DESPESAS ADICIONAIS ********//
        private void btnPesquisarFornecedor_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.RotinaOrigem = "PESQUISAR FORNECEDOR";
            a.ShowDialog();
        }
        private void btn_PesquisarCategoria_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.RotinaOrigem = "PESQUISAR CONTA GERENCIAL";
            a.ShowDialog();
        }
        private void tboxValorDespesa_Leave(object sender, EventArgs e)
        {
            tboxValorDespesa.Text = Conversor.converterMoeda(tboxValorDespesa.Text);
            CalcularDespesas();
        }
        private void tboxDescontoDespesa_Leave(object sender, EventArgs e)
        {
            tboxDescontoDespesa.Text = Conversor.converterMoeda(tboxDescontoDespesa.Text);
            CalcularDespesas();
        }
        private void tboxJurosDespesa_Leave(object sender, EventArgs e)
        {
            tboxJurosDespesa.Text = Conversor.converterMoeda(tboxJurosDespesa.Text);
            CalcularDespesas();
        }
        private void tboxTotalDespesa_Leave(object sender, EventArgs e)
        {
            tboxTotalDespesa.Text = Conversor.converterMoeda(tboxTotalDespesa.Text);
            CalcularDespesas();
        }
        private void btnInclurirContaAdicinal_Click(object sender, EventArgs e)
        {
            gravar_ContaAdicinais();
            pesquisar_ContaAdicinais();
        }
        private void btnRemoverDespesa_Click(object sender, EventArgs e)
        {
            Excluir_ContaAdicinais();
        }
        private void tboxParceiro_TextChanged(object sender, EventArgs e)
        {
            atualizarPedido();
        }
        private void btn_PesquisarBanco_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.RotinaOrigem = "PESQUISAR BANCO";
            a.ShowDialog();
        }
        private void btn_PesquisarMoeda_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.RotinaOrigem = "PESQUISAR MOEDA";
            a.ShowDialog();
        }
        private void btnRemoverContaReceber_Click(object sender, EventArgs e)
        {
            Excluir_ContaReceber();
            pesquisar_ContasReceber();
            calcularTotalParcelas();
        }
        private void tboxQtdeParcelar_Leave(object sender, EventArgs e)
        {
            try
            {
                tboxQtdeParcelar.Text = Convert.ToString(Convert.ToInt32(tboxQtdeParcelar.Text));

            }
            catch (Exception)
            {
                MessageBox.Show("Valor Invalida");
                tboxQtdeParcelar.Text = "1";
            }
            tboxQtdeParcelar.Text = Conversor.converterMoeda(tboxQtdeParcelar.Text);
        }
        private void tboxValor_Leave(object sender, EventArgs e)
        {
            tboxValor.Text = Conversor.converterMoeda(tboxValor.Text);

        }
    }
}
