using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverSoft
{
    public partial class frmDigitaPedidoCompras : Padrao
    {
        Conexao conexao = new Conexao();
        Produto.Produto produto = new Produto.Produto();

        string SQLCunsultaEmpr;
        public int idFunc;
        public string codFornec;
        public string codFilial = "1";

        decimal qtdeUnt;
        decimal pcustoUnt;
        decimal ipiUnt;
        decimal outroCustoUnt;
        decimal descontoUnt;
        decimal pliquidoUnt;
        decimal totalUnit;
        int idMoeda = 1;

        int idConta = 1;

        public frmDigitaPedidoCompras()
        {
            InitializeComponent();
        }
        private void iniciarForm()
        {
            #region MONTAR GRID CONSULTA

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
            dgv_resultado_pesquisa.Columns.Add(col_IPI);

            DataGridViewTextBoxColumn col_OUTROSCUSTO = new DataGridViewTextBoxColumn();
            col_OUTROSCUSTO.Name = "OUTROCUSTO";
            col_OUTROSCUSTO.HeaderText = "O. Custos";
            col_OUTROSCUSTO.Width = 90;
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
            dgv_resultado_pesquisa.Columns.Add(col_TOTALUNT);

            DataGridViewTextBoxColumn col_TOTAL = new DataGridViewTextBoxColumn();
            col_TOTAL.Name = "TOTAL";
            col_TOTAL.HeaderText = "TOTAL";
            col_TOTAL.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_TOTAL);


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
            ipiUnt        = Convert.ToDecimal(tboxIPI.Text);
            outroCustoUnt = Convert.ToDecimal(tboxOutrosCusto.Text);
            descontoUnt   = Convert.ToDecimal(tboxDesconto.Text); ;
            pliquidoUnt   = Convert.ToDecimal(tboxTotalUnit.Text);

            ipiUnt = (ipiUnt * pcustoUnt / 100);

            totalUnit = ((pcustoUnt + ipiUnt + outroCustoUnt) - descontoUnt) * qtdeUnt;
            pliquidoUnt = ((pcustoUnt + ipiUnt + outroCustoUnt) - descontoUnt);


            tboxTotal.Text     = Conversor.converterMoeda(Convert.ToString(totalUnit));
            tboxTotalUnit.Text = Conversor.converterMoeda(Convert.ToString(pliquidoUnt));

        }
        private void calcularTotalPedido()
        {
            decimal qtdeTotal = 0;
            decimal pcustoTotal = 0;
            decimal ipiTotal = 0;
            decimal outroCustoTotal = 0;
            decimal descontoTotal = 0;
            decimal pliquidTotal = 0;
            decimal totalTotal = 0;
            decimal qtde = 0;

        

            for (int i = 0; i < dgv_resultado_pesquisa.Rows.Count; i++)
            {
                qtdeTotal       += i;
                pcustoTotal     += Convert.ToDecimal(dgv_resultado_pesquisa.Rows[i].Cells["PCUSTO"].Value.ToString());
                ipiTotal        += Convert.ToDecimal(dgv_resultado_pesquisa.Rows[i].Cells["IPI"].Value.ToString());
                outroCustoTotal += Convert.ToDecimal(dgv_resultado_pesquisa.Rows[i].Cells["OUTROCUSTO"].Value.ToString());
                descontoTotal   += Convert.ToDecimal(dgv_resultado_pesquisa.Rows[i].Cells["DESCONTO"].Value.ToString());
                pliquidTotal    += Convert.ToDecimal(dgv_resultado_pesquisa.Rows[i].Cells["TOTALUNT"].Value.ToString());
                totalTotal      += Convert.ToDecimal(dgv_resultado_pesquisa.Rows[i].Cells["TOTAL"].Value.ToString());


                dgv_formaPagto.DefaultCellStyle.ForeColor = Color.Black;
                dgv_resultado_pesquisa.Rows[i].Cells["ITEM"].Value = i + 1;
            }

        
            tboxQtdeTotal.Text        = Convert.ToString(dgv_resultado_pesquisa.Rows.Count);
            tboxIPItotal.Text         = Convert.ToString(ipiTotal);
            tboxOutrosCustoTotal.Text = Convert.ToString(outroCustoTotal);
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
                dgv_formaPagto.Rows[i].Cells["SEQ"].Value = i + 1;
                dgv_formaPagto.DefaultCellStyle.ForeColor = Color.Black;
            }

            tbox_TotalParcelas.Text = Convert.ToString(totalPedido);
        }
        private void limparCamposProduto()
        {
            tboxItem.Clear();
            tboxCodigo.Text = "";
            tboxDescricao.Text = "";
            tboxCodAuxiliar.Text = "";
            tboxUnd.Text = "";
            tboxQtde.Text = "0,00";
            tboxPCusto.Text = "0,00";
            tboxIPI.Text = "0,00";
            tboxOutrosCusto.Text = "0,00";
            tboxDesconto.Text = "0,00";
            tboxTotalUnit.Text = "0,00";
            tboxTotal.Text = "0,00";
            btnRemover.Enabled = false;
            tboxLocalizarProduto.Focus();
            tboxLocalizarProduto.Clear();
        }
        private void gravarPedido()
        {
            conexao.Abre_Conexao();
            string SQLCunsultaEmpr = "INSERT INTO TBPEDIDO " +
                                         "(IDFUNC,         " +
                                         " IDFORNEC,       " +
                                         " DTLANC )        " +
                                         " VALUES          " +
                                         "(@IDFUNC,        " +
                                         " @IDFORNEC,      " +
                                         " @DTLANC )       ";


            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;
            conexao.cmd.Parameters.AddWithValue("IDFUNC",   idFunc);
            conexao.cmd.Parameters.AddWithValue("IDFORNEC", codFornec);
            conexao.cmd.Parameters.AddWithValue("DTLANC", Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd"));
            conexao.cmd.ExecuteNonQuery();
            retornaUltimoPedido();

        }
        private void retornaUltimoPedido()
        {
            conexao.Abre_Conexao();
            SQLCunsultaEmpr = "SELECT MAX(ID) FROM TBPEDIDO";



            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();



            while (conexao.dataReader.Read())
            {
                tboxNumPedido.Text = conexao.dataReader[0].ToString();
            }
            conexao.Fecha_Conexao();

        }
        private void gravarItens()
        {
            conexao.Abre_Conexao();

            for (int i = 0; i < dgv_resultado_pesquisa.RowCount; i++)
            {
                string SQLCunsultaEmpr = "INSERT INTO TBPEDIDO_ITENS " +
                                          " (SEQ       " +
                                          " ,IDPEDIDO   " +
                                          " ,CODPROD   " +
                                          " ,QTDE      " +
                                          " ,PCUSTO    " +
                                          " ,IPI       " +
                                          " ,OUTROCUSTO" +
                                          " ,DESCONTO  " +
                                          " ,TOTALUNT  " +
                                          " ,TOTAL)     " +
                                         " VALUES       " +
                                          " (@SEQ       " +
                                          " ,@IDPEDIDO  " +
                                          " ,@CODPROD   " +
                                          " ,@QTDE      " +
                                          " ,@PCUSTO    " +
                                          " ,@IPI       " +
                                          " ,@OUTROCUSTO" +
                                          " ,@DESCONTO  " +
                                          " ,@TOTALUNT  " +
                                          " ,@TOTAL)     ";


                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;
                conexao.cmd.Parameters.AddWithValue("SEQ",        dgv_resultado_pesquisa.Rows[i].Cells["ITEM"].Value.ToString());
                conexao.cmd.Parameters.AddWithValue("IDPEDIDO",    tboxNumPedido.Text);
                conexao.cmd.Parameters.AddWithValue("CODPROD",    dgv_resultado_pesquisa.Rows[i].Cells["CODPROD"].Value.ToString());
                conexao.cmd.Parameters.AddWithValue("QTDE",       dgv_resultado_pesquisa.Rows[i].Cells["QTDE"].Value.ToString());
                conexao.cmd.Parameters.AddWithValue("PCUSTO",     dgv_resultado_pesquisa.Rows[i].Cells["PCUSTO"].Value.ToString());
                conexao.cmd.Parameters.AddWithValue("IPI",        dgv_resultado_pesquisa.Rows[i].Cells["IPI"].Value.ToString());
                conexao.cmd.Parameters.AddWithValue("OUTROCUSTO", dgv_resultado_pesquisa.Rows[i].Cells["OUTROCUSTO"].Value.ToString());
                conexao.cmd.Parameters.AddWithValue("TOTALUNT",   dgv_resultado_pesquisa.Rows[i].Cells["TOTALUNT"].Value.ToString());
                conexao.cmd.Parameters.AddWithValue("DESCONTO",   dgv_resultado_pesquisa.Rows[i].Cells["DESCONTO"].Value.ToString());
                conexao.cmd.Parameters.AddWithValue("TOTAL",      dgv_resultado_pesquisa.Rows[i].Cells["TOTAL"].Value.ToString());
                conexao.cmd.ExecuteNonQuery();
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
        private void gravarContasPagar()
        {
            conexao.Abre_Conexao();
            for (int i = 0; i < dgv_formaPagto.RowCount; i++)
            {

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
                                                    " ,IDVENDA               " +
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
                                                    " ,@IDVENDA               " +
                                                    " ,@VLREXTENSO)             ";


                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;           
                    conexao.cmd.Parameters.AddWithValue("TIPO",          "D");
                    conexao.cmd.Parameters.AddWithValue("IDFILIAL",      codFilial);
                    conexao.cmd.Parameters.AddWithValue("IDPARCEIRO",    codFornec);
                    conexao.cmd.Parameters.AddWithValue("IDMOEDA",       "1");
                    conexao.cmd.Parameters.AddWithValue("IDCONTA",       "1");
                    conexao.cmd.Parameters.AddWithValue("IDCONTAGERENCIAL",   "12");
                    conexao.cmd.Parameters.AddWithValue("HISTORICO",    "Ref.: A COMPRA DE MERCADORIA PARA A REVENDA NOTA : " + tboxNumPedido.Text);
                    conexao.cmd.Parameters.AddWithValue("NUMDOC",        tboxNumPedido.Text);
                    conexao.cmd.Parameters.AddWithValue("DTLANC",        Conversor.converterDataUS(DateTime.Now.ToShortDateString()));
                    conexao.cmd.Parameters.AddWithValue("DTVENC",        Conversor.converterDataUS(dgv_formaPagto.Rows[i].Cells["DTVENC"].Value.ToString()));
                    conexao.cmd.Parameters.AddWithValue("DTCOMPETENCIA", Conversor.converterDataUS(dgv_formaPagto.Rows[i].Cells["DTVENC"].Value.ToString()));
                    conexao.cmd.Parameters.AddWithValue("VALOR",         dgv_formaPagto.Rows[i].Cells["VALOR"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("VLRDESC",       "0,00");
                    conexao.cmd.Parameters.AddWithValue("VLRJUROS",      "0,00");
                    conexao.cmd.Parameters.AddWithValue("VLRTOTAL",       dgv_formaPagto.Rows[i].Cells["VALOR"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("IDVENDA",        tboxNumPedido.Text);
                    conexao.cmd.Parameters.AddWithValue("VLREXTENSO",     dgv_formaPagto.Rows[i].Cells["VLREXTENSO"].Value.ToString());

                    conexao.cmd.ExecuteNonQuery();

             }
                    conexao.Fecha_Conexao();
        }
        private void carregarXML()
        {
            string arquivo = "";
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "XML|*.XML";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    arquivo = file.FileName;
                }
            }
            catch (Exception)
            {
                                
            }

            try
            {
                if (arquivo == "")
                {
                    return;
                }
                dgv_resultado_pesquisa.Rows.Clear();
                int cont = 0;
                string FileName = arquivo;
                List<string> ListaItens = new List<string>();
                XmlDocument doc = new XmlDocument();
                doc.Load(FileName);

                var emitente = doc.GetElementsByTagName("emit");
                foreach (XmlElement nodo in emitente)
                {
                    //**ESPAÇO PARA CADASTRAR O FORNECEDOR**//
                    //lbl_razaoSocial.Text = nodo.GetElementsByTagName("xNome")[0].InnerText.Trim();
                    //tbox_CNPJ.Text = nodo.GetElementsByTagName("CNPJ")[0].InnerText.Trim();


                }

                var proditens = doc.GetElementsByTagName("det");
                var Impostositens = doc.GetElementsByTagName("ISPI");

                foreach (XmlElement nodo in proditens)
                {

                    dgv_resultado_pesquisa.Rows.Add();
                    dgv_resultado_pesquisa.Rows[cont].Cells["ITEM"].Value           = cont + 1;
                    dgv_resultado_pesquisa.Rows[cont].Cells["CODPROD"].Value        = "";
                    dgv_resultado_pesquisa.Rows[cont].Cells["CODBARRA"].Value       = nodo.GetElementsByTagName("cEAN")[0].InnerText.Trim();
                    dgv_resultado_pesquisa.Rows[cont].Cells["CODFABRICA"].Value     = nodo.GetElementsByTagName("cProd")[0].InnerText.Trim();
                    dgv_resultado_pesquisa.Rows[cont].Cells["DESCRICAO"].Value      = nodo.GetElementsByTagName("xProd")[0].InnerText.Trim();
                    dgv_resultado_pesquisa.Rows[cont].Cells["UND"].Value            = nodo.GetElementsByTagName("uCom")[0].InnerText.Trim();
                    dgv_resultado_pesquisa.Rows[cont].Cells["QTDE"].Value           = Conversor.converterMoeda(nodo.GetElementsByTagName("qCom")[0].InnerText.Trim().Replace(".",","));
                    dgv_resultado_pesquisa.Rows[cont].Cells["PCUSTO"].Value         = Conversor.converterMoeda(nodo.GetElementsByTagName("vUnCom")[0].InnerText.Trim().Replace(".", ","));
                    dgv_resultado_pesquisa.Rows[cont].Cells["OUTROCUSTO"].Value     = "0,00"; 
                    dgv_resultado_pesquisa.Rows[cont].Cells["DESCONTO"].Value       = "0,00"; 
                
                    try
                    {
                        dgv_resultado_pesquisa.Rows[cont].Cells["IPI"].Value = Conversor.converterMoeda(nodo.GetElementsByTagName("pIPI")[0].InnerText.Trim().Replace(".", ","));
                    }
                    catch (Exception)
                    {
                        dgv_resultado_pesquisa.Rows[cont].Cells["IPI"].Value = "0,00";
                    }

                   
                    cont++;

                }

                for (int i = 0; i < dgv_resultado_pesquisa.Rows.Count; i++)
                {
                    try
                    {
                        decimal qtde = Convert.ToDecimal(dgv_resultado_pesquisa.Rows[i].Cells["QTDE"].Value.ToString());
                        decimal pcustoTotal = Convert.ToDecimal(dgv_resultado_pesquisa.Rows[i].Cells["PCUSTO"].Value.ToString());
                        decimal ipiTotal = Convert.ToDecimal(dgv_resultado_pesquisa.Rows[i].Cells["IPI"].Value.ToString());
                        decimal outroCustoTotal = Convert.ToDecimal(dgv_resultado_pesquisa.Rows[i].Cells["OUTROCUSTO"].Value.ToString());
                        decimal descontoTotal = Convert.ToDecimal(dgv_resultado_pesquisa.Rows[i].Cells["DESCONTO"].Value.ToString());
                        decimal pliquidTotal = 0;

                        ipiTotal = ipiTotal * pcustoTotal / 100;
                        pliquidTotal = ((pcustoTotal + ipiTotal + outroCustoTotal) - descontoTotal);

                        dgv_resultado_pesquisa.Rows[i].Cells["TOTALUNT"].Value = Conversor.converterMoeda(Convert.ToString(pliquidTotal));


                        dgv_resultado_pesquisa.Rows[i].Cells["TOTAL"].Value = Conversor.converterMoeda(Convert.ToString(pliquidTotal * qtde));
                    }
                    catch (Exception)
                    {
                    }
                }
            }
            
            catch (Exception ex)
            {

                MessageBox.Show("Ocorreu um erro ao ler o arquivo" + ex.Message, "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            cadastrarProduto();
            calcularTotalPedido();

        }
        private void cadastrarProduto()
        {
            int o = 0;
            for (int i = 0; i < dgv_resultado_pesquisa.Rows.Count; i++)
            {
               
                // VERIFICA SE O PRODUTO É CADASTRADO
                #region Consultar 
                conexao.Abre_Conexao();
                produto.CODAUXILIAR = dgv_resultado_pesquisa.Rows[i].Cells["CODBARRA"].Value.ToString();
                produto.select();
                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = produto.sqlProduto;

                conexao.cmd.ExecuteNonQuery();
                conexao.adapter.SelectCommand = conexao.cmd;
                conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
                conexao.dataReader = conexao.cmd.ExecuteReader();

                while (conexao.dataReader.Read())
                {
                    o++;
                }
                conexao.Fecha_Conexao();
                #endregion 
                //*******
                
                if (o == 0)
                {
                    produto.DESCRICAO   = dgv_resultado_pesquisa.Rows[i].Cells["DESCRICAO"].Value.ToString();
                    produto.CODAUXILIAR = dgv_resultado_pesquisa.Rows[i].Cells["CODBARRA"].Value.ToString();
                    produto.MEDIDA      = dgv_resultado_pesquisa.Rows[i].Cells["UND"].Value.ToString();
                    produto.IDSECAO     = "1";
                    produto.TIPO        = "Produto";
                    produto.OBS         = "Cadastrado através do XML";
                    produto.insert();
                }
                else
                {
                    #region Consultar 
                    conexao.Abre_Conexao();
                    produto.CODAUXILIAR = dgv_resultado_pesquisa.Rows[i].Cells["CODBARRA"].Value.ToString();
                    produto.select();
                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = produto.sqlProduto;

                    conexao.cmd.ExecuteNonQuery();
                    conexao.adapter.SelectCommand = conexao.cmd;
                    conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
                    conexao.dataReader = conexao.cmd.ExecuteReader();

                    while (conexao.dataReader.Read())
                    {
                        dgv_resultado_pesquisa.Rows[i].Cells["CODPROD"].Value = conexao.dataReader["ID"].ToString();
                    }
                    conexao.Fecha_Conexao();
                    #endregion
                }

            }
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

            if (tboxItem.Text == "")
            {
                int i = dgv_resultado_pesquisa.Rows.Count;

                dgv_resultado_pesquisa.Rows.Add();

                dgv_resultado_pesquisa.Rows[i].Cells["ITEM"].Value       = i + 1;
                dgv_resultado_pesquisa.Rows[i].Cells["CODPROD"].Value    = tboxCodigo.Text;
                dgv_resultado_pesquisa.Rows[i].Cells["DESCRICAO"].Value  = tboxDescricao.Text;
                dgv_resultado_pesquisa.Rows[i].Cells["CODBARRA"].Value   = tboxCodAuxiliar.Text;
                dgv_resultado_pesquisa.Rows[i].Cells["UND"].Value        = tboxUnd.Text;
                dgv_resultado_pesquisa.Rows[i].Cells["QTDE"].Value       = tboxQtde.Text;
                dgv_resultado_pesquisa.Rows[i].Cells["PCUSTO"].Value     = tboxPCusto.Text;
                dgv_resultado_pesquisa.Rows[i].Cells["IPI"].Value        = tboxIPI.Text;
                dgv_resultado_pesquisa.Rows[i].Cells["OUTROCUSTO"].Value = tboxOutrosCusto.Text;
                dgv_resultado_pesquisa.Rows[i].Cells["DESCONTO"].Value   = tboxDesconto.Text;
                dgv_resultado_pesquisa.Rows[i].Cells["TOTALUNT"].Value   = tboxTotalUnit.Text;
                dgv_resultado_pesquisa.Rows[i].Cells["TOTAL"].Value      = tboxTotal.Text;
            }
            else
            {
                for (int i = 0; i < dgv_resultado_pesquisa.Rows.Count; i++)
                {
                    if (dgv_resultado_pesquisa.Rows[i].Cells["ITEM"].Value.ToString() == tboxItem.Text)
                    {
                       // dgv_resultado_pesquisa.Rows[i].Cells["ITEM"].Value       = i + 1;
                        dgv_resultado_pesquisa.Rows[i].Cells["CODPROD"].Value    = tboxCodigo.Text;
                        dgv_resultado_pesquisa.Rows[i].Cells["DESCRICAO"].Value  = tboxDescricao.Text;
                        dgv_resultado_pesquisa.Rows[i].Cells["CODBARRA"].Value   = tboxCodAuxiliar.Text;
                        dgv_resultado_pesquisa.Rows[i].Cells["UND"].Value        = tboxUnd.Text;
                        dgv_resultado_pesquisa.Rows[i].Cells["QTDE"].Value       = tboxQtde.Text;
                        dgv_resultado_pesquisa.Rows[i].Cells["PCUSTO"].Value     = tboxPCusto.Text;
                        dgv_resultado_pesquisa.Rows[i].Cells["IPI"].Value        = tboxIPI.Text;
                        dgv_resultado_pesquisa.Rows[i].Cells["OUTROCUSTO"].Value = tboxOutrosCusto.Text;
                        dgv_resultado_pesquisa.Rows[i].Cells["DESCONTO"].Value   = tboxDesconto.Text;
                        dgv_resultado_pesquisa.Rows[i].Cells["TOTALUNT"].Value   = tboxTotalUnit.Text;
                        dgv_resultado_pesquisa.Rows[i].Cells["TOTAL"].Value      = tboxTotal.Text;
                    }
                }
            }

            calcularTotalPedido();
            limparCamposProduto();
        }
        private void dgv_resultado_pesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tboxItem.Text        = dgv_resultado_pesquisa.CurrentRow.Cells["ITEM"].Value.ToString();
                tboxCodigo.Text      = dgv_resultado_pesquisa.CurrentRow.Cells["CODPROD"].Value.ToString();
                tboxDescricao.Text   = dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                tboxCodAuxiliar.Text = dgv_resultado_pesquisa.CurrentRow.Cells["CODBARRA"].Value.ToString();
                tboxQtde.Text        = dgv_resultado_pesquisa.CurrentRow.Cells["QTDE"].Value.ToString();
                tboxUnd.Text         = dgv_resultado_pesquisa.CurrentRow.Cells["UND"].Value.ToString();
                tboxPCusto.Text      = dgv_resultado_pesquisa.CurrentRow.Cells["PCUSTO"].Value.ToString();
                tboxIPI.Text         = dgv_resultado_pesquisa.CurrentRow.Cells["IPI"].Value.ToString();
                tboxOutrosCusto.Text = dgv_resultado_pesquisa.CurrentRow.Cells["OUTROCUSTO"].Value.ToString();
                tboxDesconto.Text    = dgv_resultado_pesquisa.CurrentRow.Cells["DESCONTO"].Value.ToString();
                tboxTotalUnit.Text   = dgv_resultado_pesquisa.CurrentRow.Cells["TOTALUNT"].Value.ToString();
                tboxTotal.Text       = dgv_resultado_pesquisa.CurrentRow.Cells["TOTAL"].Value.ToString();
                btnRemover.Enabled   = true;
                calcularTotalPedido();
                calcularPreçoItem();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao ler o arquivo" + ex.Message, "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
        private void btnRemover_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_resultado_pesquisa.Rows.Count; i++)
            {
                if (dgv_resultado_pesquisa.Rows[i].Cells["ITEM"].Value.ToString() == tboxItem.Text)
                {
                    dgv_resultado_pesquisa.Rows.RemoveAt(Convert.ToInt32(tboxItem.Text) - 1);
                    calcularTotalPedido();
                    limparCamposProduto();
                }
            }
        }
        private void tboxPessquisar_Enter(object sender, EventArgs e)
        {
            limparCamposProduto();
        }
        private void frmDigitaPedidoCompras_Load(object sender, EventArgs e)
        {
            iniciarForm();
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
            if (Convert.ToDecimal(tboxQtdeParcelas.Text) <= 0)
            {
                return;
            }

            for (int i = 0; i < Convert.ToInt32(tboxQtdeParcelas.Text); i++)
            {
                string valor_Extenso = Conversor.EscreverExtenso(Convert.ToDecimal(tboxQtdeParcelas.Text));
                dgv_formaPagto.Rows.Add();

                dgv_formaPagto.Rows[i].Cells["SEQ"].Value = i + 1;
                dgv_formaPagto.Rows[i].Cells["VALOR"].Value = tboxQtdeParcelas.Text;
                dgv_formaPagto.Rows[i].Cells["VLREXTENSO"].Value = valor_Extenso;
                dgv_formaPagto.Rows[i].Cells["CODMOEDA"].Value = idMoeda;
                dgv_formaPagto.Rows[i].Cells["IDBANCOCONTA"].Value = idConta;
             //   dgv_formaPagto.Rows[i].Cells["DTVENC"].Value = tbox_DtVenc.Text;
                calcularTotalParcelas();
            }
            
        }
        #region Leave
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
        private void tboxIPI_Leave(object sender, EventArgs e)
        {

            tboxIPI.Text = Conversor.converterMoeda(tboxIPI.Text);

            calcularPreçoItem();
        }
        private void tboxOutrosCusto_Leave(object sender, EventArgs e)
        {

            tboxOutrosCusto.Text = Conversor.converterMoeda(tboxOutrosCusto.Text);

            calcularPreçoItem();

        }
        private void tboxDesconto_Leave(object sender, EventArgs e)
        {

            tboxDesconto.Text = Conversor.converterMoeda(tboxDesconto.Text);

            calcularPreçoItem();


        }
        private void tboxTotalUnit_Leave(object sender, EventArgs e)
        {

            tboxTotalUnit.Text = Conversor.converterMoeda(tboxTotalUnit.Text);

            calcularPreçoItem();


        }
        private void tboxTotal_Leave(object sender, EventArgs e)
        {

            tboxTotalUnit.Text = Conversor.converterMoeda(tboxTotalUnit.Text);

            calcularPreçoItem();


        }
        private void tboxPessquisar_Leave(object sender, EventArgs e)
        {
            if (tboxLocalizarProduto.Text != "")
            {
                pesquisarProduto();
            }
        }
        private void tboxValor_Leave(object sender, EventArgs e)
        {

            tboxQtdeParcelas.Text = Conversor.converterMoeda(tboxQtdeParcelas.Text);

        }


        #endregion
        private void btnPesquisarParceiro_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR FORNECEDOR";
            a.RotinaOrigem = lbl_NomeRotina.Text;
            a.ShowDialog();
        }
        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            frm_ProdutoConsultar a = new frm_ProdutoConsultar(this);
            a.lbl_NomeRotina.Text = "PESQUISAR PRODUTOS";
            a.ShowDialog();
            pesquisarProduto();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbox_TotalFinal.Text == "0,00")
            {
                return;
            }

            if (tboxParceiro.Text == "")
            {
                MessageBox.Show("Fornecedor não Informado", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbox_TotalFinal.Text != tbox_TotalParcelas.Text)
            {
                MessageBox.Show("O Valor Total das parcelas diverge do valor total do pedido.", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Deseja Gravar o Pedido?", "Clever Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                gravarPedido();
                gravarItens();
                ajustarEstoque();
                gravarContasPagar();
                MessageBox.Show("Pedido gravado com sucesso. A rotina será fechada em seguida", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
        }
        private void btnImportarXML_Click(object sender, EventArgs e)
        {
            carregarXML();
        }
        private void tboxValor_Leave_1(object sender, EventArgs e)
        {
            try
            {
                tboxQtdeParcelas.Text = Convert.ToString(Convert.ToInt32(tboxQtdeParcelas.Text));
            }
            catch (Exception)
            {
                tboxQtdeParcelas.Text = "1";
            }
        }
    }
}
