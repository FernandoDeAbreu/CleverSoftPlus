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
    public partial class frm_PDV : Form
    {
        Conexao conexao = new Conexao();

        public int numgrid = 0;
        public int idvenda = 0;
        public int idFunc;
        public int idCliente = 1;
        public int idMesa = 1;
        int idCaixa = 0;
               int cont;

        public decimal vlrUnit;
        public decimal vlrVenda;

        public decimal vlrPago;
        public decimal vlrTroco;
        public decimal vlrdesc;


        public frm_PDV()
        {
            InitializeComponent();
        }
        private void AbrirCaixaDia()
        {
            conexao.Abre_Conexao();

            string SQLCunsultaEmpr = "SELECT * FROM TBCAIXA WHERE STATUS = 'ABERTO' AND IDFUNC = '"  + idFunc + "' AND DATA = '" + Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd") + "'";
                       
            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();

            int o = 0;

            while (conexao.dataReader.Read())
            {
                idCaixa = Convert.ToInt32(conexao.dataReader["ID"].ToString());
                
                o++;
            }

            if (o == 0)
            {
                frmAbrirCaixa a = new frmAbrirCaixa();
                a.idFunc = idFunc;
                a.tboxParceiro.Text = lbl_Funcionario.Text;
                a.ShowDialog();
               
            }

            conexao.Fecha_Conexao();
        }
        private void abrirVenda()
        {
            conexao.Abre_Conexao();
            try
            {
                string SQLCunsultaEmpr = " INSERT INTO TBVENDA (" +
                                           " DATA                 " +
                                           " ,HORA                " +
                                           " ,IDFUNC              " +
                                           " ,IDCLIENTE           " +
                                           " ,IDCAIXA             " +
                                           " ,IDMESA              " +
                                           " ,VLRORIGINAL         " +
                                           " ,VLRDESC             " +
                                           " ,VLRPAGO             " +
                                           " ,VLRVENDA            " +
                                           " ,VLRTROCO            " +
                                           " ,STATUS)             " +
                                           " VALUES(              " +
                                           "  @DATA               " +
                                           " ,@HORA               " +
                                           " ,@IDFUNC             " +
                                           " ,@IDCLIENTE          " +
                                           " ,@IDCAIXA            " +
                                           " ,@IDMESA             " +
                                           " ,@VLRORIGINAL        " +
                                           " ,@VLRDESC            " +
                                           " ,@VLRPAGO            " +
                                           " ,@VLRVENDA           " +
                                           " ,@VLRTROCO           " +
                                           " ,@STATUS)            ";


                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;
                conexao.cmd.Parameters.AddWithValue("DATA",        Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd"));
                conexao.cmd.Parameters.AddWithValue("HORA",        DateTime.Now.ToLongTimeString());
                conexao.cmd.Parameters.AddWithValue("IDFUNC",      idFunc);
                conexao.cmd.Parameters.AddWithValue("IDCLIENTE",   idCliente);
                conexao.cmd.Parameters.AddWithValue("IDCAIXA",     idCaixa);
                conexao.cmd.Parameters.AddWithValue("IDMESA",      idMesa);
                conexao.cmd.Parameters.AddWithValue("VLRORIGINAL", vlrUnit);
                conexao.cmd.Parameters.AddWithValue("VLRDESC",     "0,00");
                conexao.cmd.Parameters.AddWithValue("VLRPAGO",     vlrPago);
                conexao.cmd.Parameters.AddWithValue("VLRVENDA",    vlrVenda);
                conexao.cmd.Parameters.AddWithValue("VLRTROCO",    vlrTroco);
                conexao.cmd.Parameters.AddWithValue("STATUS",      "ABERTA");


                conexao.cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro no metodo de gravar a venda.  >> " + e, "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conexao.Fecha_Conexao();
            retornaUltimaVenda();
        }
        private void retornaUltimaVenda()
        {
            conexao.Abre_Conexao();
           
                string SQLCunsultaEmpr = "SELECT MAX(ID) FROM TBVENDA";



                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;

                conexao.cmd.ExecuteNonQuery();
                conexao.adapter.SelectCommand = conexao.cmd;
                conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
                conexao.dataReader = conexao.cmd.ExecuteReader();

                int o = 0;

                while (conexao.dataReader.Read())
                {
                    idvenda = Convert.ToInt32(conexao.dataReader[0].ToString());
                    lblNnumVenda.Text = "Venda Nº " + conexao.dataReader[0].ToString();
                    lblDescricao.Text = "CAIXA ABERTO";
                    o++;
                }


                      
            conexao.Fecha_Conexao();

        }
        public void gravaVenda()
        {
  
        conexao.Abre_Conexao();
            try
            {
                string SQLCunsultaEmpr =   " UPDATE TBVENDA SET " +
                                           "  DATA        = @DATA        " +
                                           " ,HORA        = @HORA        " +
                                           " ,IDCLIENTE   = @IDCLIENTE   " +
                                           " ,IDMESA      = @IDMESA      " +
                                           " ,VLRORIGINAL = @VLRORIGINAL " +
                                           " ,VLRDESC     = @VLRDESC     " +
                                           " ,VLRPAGO     = @VLRPAGO     " +
                                           " ,VLRVENDA    = @VLRVENDA    " +
                                           " ,VLRTROCO    = @VLRTROCO    " +
                                           " ,STATUS      = @STATUS      " +
                                           "  WHERE ID = " + idvenda ;
                                         

                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;
                conexao.cmd.Parameters.AddWithValue("DATA",        Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd"));
                conexao.cmd.Parameters.AddWithValue("HORA",        DateTime.Now.ToLongTimeString());
                conexao.cmd.Parameters.AddWithValue("IDCLIENTE",   idCliente);
                conexao.cmd.Parameters.AddWithValue("IDMESA",      idMesa);
                conexao.cmd.Parameters.AddWithValue("VLRORIGINAL", Conversor.converterMoeda(Convert.ToString(vlrUnit)));
                conexao.cmd.Parameters.AddWithValue("VLRDESC",     Conversor.converterMoeda(Convert.ToString(vlrdesc)));
                conexao.cmd.Parameters.AddWithValue("VLRPAGO",     Conversor.converterMoeda(Convert.ToString(vlrPago)));
                conexao.cmd.Parameters.AddWithValue("VLRVENDA",    Conversor.converterMoeda(Convert.ToString(vlrVenda)));
                conexao.cmd.Parameters.AddWithValue("VLRTROCO",    Conversor.converterMoeda(Convert.ToString(vlrTroco)));
                conexao.cmd.Parameters.AddWithValue("STATUS",      "FECHADA");


                conexao.cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro no metodo de gravar a venda.  >> " + e, "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            conexao.Fecha_Conexao();
        }
        public void gravarItens()
        {
            #region INSERT

            conexao.Abre_Conexao();

            for (int i = 0; i < dgv_Itens_Venda.Rows.Count; i++)
            {

                string SQLCunsultaEmpr = " INSERT INTO TBVENDA_ITENS" +
                                                " (IDVENDA        " +
                                                " ,SEQ            " +
                                                " ,CODPROD        " +
                                                " ,QTDE           " +
                                                " ,PCUSTO         " +
                                                " ,PUNIT          " +
                                                " ,PDESC          " +
                                                " ,PVENDA         " +
                                                " ,PTOTAL         " +
                                                " ,TOTALDESC )    " +
                                                " VALUES          " +
                                                " (@IDVENDA       " +
                                                " ,@SEQ           " +
                                                " ,@CODPROD       " +
                                                " ,@QTDE          " +
                                                " ,@PCUSTO        " +
                                                " ,@PUNIT         " +
                                                " ,@PDESC         " +
                                                " ,@PVENDA        " +
                                                " ,@PTOTAL        " +
                                                " ,@TOTALDESC)    ";
                                                 


                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;           
                    conexao.cmd.Parameters.AddWithValue("IDVENDA",   idvenda);
                    conexao.cmd.Parameters.AddWithValue("SEQ",       dgv_Itens_Venda.Rows[i].Cells["SEQ"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("CODPROD",   dgv_Itens_Venda.Rows[i].Cells["CODPROD"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("QTDE",      Conversor.converterMoeda(dgv_Itens_Venda.Rows[i].Cells["QTDE"].Value.ToString()));
                    conexao.cmd.Parameters.AddWithValue("PCUSTO",    Conversor.converterMoeda(dgv_Itens_Venda.Rows[i].Cells["PCUSTO"].Value.ToString()));
                    conexao.cmd.Parameters.AddWithValue("PUNIT",     Conversor.converterMoeda(dgv_Itens_Venda.Rows[i].Cells["PUNIT"].Value.ToString()));
                    conexao.cmd.Parameters.AddWithValue("PDESC",     Conversor.converterMoeda(dgv_Itens_Venda.Rows[i].Cells["PDESC"].Value.ToString()));
                    conexao.cmd.Parameters.AddWithValue("PVENDA",    Conversor.converterMoeda(dgv_Itens_Venda.Rows[i].Cells["PVENDA"].Value.ToString()));
                    conexao.cmd.Parameters.AddWithValue("PTOTAL",    Conversor.converterMoeda(dgv_Itens_Venda.Rows[i].Cells["PTOTAL"].Value.ToString()));
                    conexao.cmd.Parameters.AddWithValue("TOTALDESC", Conversor.converterMoeda(dgv_Itens_Venda.Rows[i].Cells["TOTALDESC"].Value.ToString()));
                  

                conexao.cmd.ExecuteNonQuery();
                conexao.cmd.Parameters.Clear();


            }
            conexao.Fecha_Conexao();
            baixarEstoque();

            #endregion
        }
        public void baixarEstoque()
        {
           
                conexao.Abre_Conexao();
         
                for (int i = 0; i < dgv_Itens_Venda.Rows.Count; i++)
                {
           

                string SQLCunsultaEmpr = "UPDATE TBPRODUTO SET ESTOQUE = (ESTOQUE - @QTDE) WHERE ID =  " + dgv_Itens_Venda.Rows[i].Cells["CODPROD"].Value.ToString();



                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;
                conexao.cmd.Parameters.AddWithValue("QTDE", dgv_Itens_Venda.Rows[i].Cells["QTDE"].Value.ToString());
              
                conexao.cmd.ExecuteNonQuery();
            
                }

            
           
            conexao.Fecha_Conexao();

        }
        private void pesquisar_Produto()
        {
           

            conexao.Abre_Conexao();
           
            string SQLCunsultaEmpr = "SELECT * FROM TBPRODUTO WHERE DTEXCLUSAO IS NULL  AND CODAUXILIAR = '" + tboxLocalizarProduto.Text + "'";



            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();

            int o = 0;

            while (conexao.dataReader.Read())
            {
                numgrid = dgv_Itens_Venda.Rows.Count;

                dgv_Itens_Venda.Rows.Add();
                dgv_Itens_Venda.Rows[numgrid].Cells["SEQ"].Value         = numgrid + 1;
                dgv_Itens_Venda.Rows[numgrid].Cells["CODPROD"].Value     = conexao.dataReader["ID"].ToString();
                dgv_Itens_Venda.Rows[numgrid].Cells["DESCRICAO"].Value   = conexao.dataReader["DESCRICAO"].ToString();
                dgv_Itens_Venda.Rows[numgrid].Cells["CODAUXILIAR"].Value = conexao.dataReader["CODAUXILIAR"].ToString();
                dgv_Itens_Venda.Rows[numgrid].Cells["QTDE"].Value        = Conversor.converterMoeda(tbox_Qtde.Text);
                dgv_Itens_Venda.Rows[numgrid].Cells["PDESC"].Value       = Conversor.converterMoeda("0,00");
                dgv_Itens_Venda.Rows[numgrid].Cells["TOTALDESC"].Value   = Conversor.converterMoeda("0,00");
                dgv_Itens_Venda.Rows[numgrid].Cells["PCUSTO"].Value    = Conversor.converterMoeda(conexao.dataReader["PCUSTO"].ToString());
                dgv_Itens_Venda.Rows[numgrid].Cells["PUNIT"].Value     = Conversor.converterMoeda(conexao.dataReader["PVENDA"].ToString());
                dgv_Itens_Venda.Rows[numgrid].Cells["PVENDA"].Value    = Conversor.converterMoeda(conexao.dataReader["PVENDA"].ToString());
                dgv_Itens_Venda.Rows[numgrid].Cells["PTOTAL"].Value    = Convert.ToDecimal(dgv_Itens_Venda.Rows[numgrid].Cells["QTDE"].Value.ToString()) * Convert.ToDecimal(dgv_Itens_Venda.Rows[numgrid].Cells["PUNIT"].Value.ToString());

                lblDescricao.Text = conexao.dataReader["DESCRICAO"].ToString();
          
                numgrid++;
                o++;
            }
            totalizador();

            if (o == 0)
            {
                MessageBox.Show("Produto não localizado!", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           

            conexao.Fecha_Conexao();

            tboxLocalizarProduto.Clear();
            tboxLocalizarProduto.Focus();
            tbox_Qtde.Text = "1,00";


        }
        public void limparCampos()
        {
            idvenda = 0;
            lblNnumVenda.Text = "Caixa Livre";
            lblDescricao.Text = "OBRIGADO, VOLTE SEMPRE!";
            lbl_QtdeItens.Text = "0,00";
            lbl_vrlDesconto.Text = "0,00";
            lbl_vlrOriginal.Text = "0,00";

            numgrid = 0;
            dgv_Itens_Venda.Rows.Clear();
            lbl_Funcionario.Text = " 1 - CONSUMIDOR FINAL";
            idCliente = 1;
            idMesa = 1;
            idCaixa = 0;
        }
        private void totalizador()
        {
            decimal valorVenda = 0;
            decimal vlrDesconto = 0;
            lbl_QtdeItens.Text = "0,00";
            lbl_vlrOriginal.Text = "0,00";
            lbl_vrlDesconto.Text = "0,00";

            for (int i = 0; i < dgv_Itens_Venda.RowCount; i++)
            {

                dgv_Itens_Venda.Rows[i].Cells["SEQ"].Value = i + 1;
                dgv_Itens_Venda.Rows[i].Cells["EXIBIRTOTAL"].Value = double.Parse(dgv_Itens_Venda.Rows[i].Cells["PTOTAL"].Value.ToString()).ToString("N2"); //COLUNA APENAS PARA EXIBIR VALOR EM N2


                dgv_Itens_Venda.Rows[i].Cells["PTOTAL"].Value = Convert.ToDecimal(dgv_Itens_Venda.Rows[i].Cells["QTDE"].Value) * Convert.ToDecimal(double.Parse(dgv_Itens_Venda.Rows[i].Cells["PVENDA"].Value.ToString()).ToString("N4"));

                dgv_Itens_Venda.Rows[i].Cells["PDESC"].Value = double.Parse(dgv_Itens_Venda.Rows[i].Cells["PDESC"].Value.ToString()).ToString("N4");

                dgv_Itens_Venda.Rows[i].Cells["TOTALDESC"].Value = Convert.ToDecimal(dgv_Itens_Venda.Rows[i].Cells["PDESC"].Value.ToString()) * Convert.ToDecimal(dgv_Itens_Venda.Rows[i].Cells["QTDE"].Value.ToString());

                vlrDesconto = vlrDesconto + Convert.ToDecimal(dgv_Itens_Venda.Rows[i].Cells["TOTALDESC"].Value.ToString());

                valorVenda = valorVenda + Convert.ToDecimal(double.Parse(dgv_Itens_Venda.Rows[i].Cells["PTOTAL"].Value.ToString()).ToString("N4"));



                lbl_QtdeItens.Text =   Conversor.converterMoeda(Convert.ToString(i+1));
                lbl_vlrOriginal.Text = Conversor.converterMoeda(Convert.ToString(valorVenda));
                lbl_vrlDesconto.Text = Conversor.converterMoeda(Convert.ToString(vlrDesconto));
            }
        }
        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void frm_PDV_Load(object sender, EventArgs e)
        {
            
            AbrirCaixaDia();
            pboxImagemSistema.ImageLocation = Application.StartupPath + @"\ofertas-mobile.png";
            tboxLocalizarProduto.Focus();
        }
        private void tboxLocalizarProduto_KeyDown(object sender, KeyEventArgs e)
        {

            AbrirCaixaDia();
            if (idCaixa == 0)
            {
                if (MessageBox.Show("O Movimento do caixa ainda não foi iniciado, deseja Abrir o caixa?", "Clever Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    AbrirCaixaDia();
                }
                return;
            }

            if (e.KeyCode == Keys.A)
            {
               
                tboxLocalizarProduto.Clear();
                if (idvenda == 0)                     
                {
                    if (MessageBox.Show("Deseja abrir nova venda?", "Clever Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        retornaUltimaVenda();
                        abrirVenda();
                    }
                }
                else
                {
                    MessageBox.Show("Venda já está aberta.", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }

            if (e.KeyCode == Keys.T)
            {
                frm_PDVAtalhos a = new frm_PDVAtalhos();
                a.ShowDialog();

            }

            if (e.KeyCode == Keys.F10) //CADASTRAR PRODUTO
            {
                frm_Produto a = new frm_Produto();
                a.panel4.Visible = false;
                a.idSecao = "1";
                a.idDepto = "1";
                a.ShowDialog();
            }

            if (e.KeyCode == Keys.F11) //CADASTRAR CLIENTE
            {
                Cliente.frmCadastrarCliente a = new Cliente.frmCadastrarCliente();
                a.ShowDialog();
            }

            if (e.KeyCode == Keys.F12) // RESUMO DE VENDAS
            {
                frm_HistoricoVendas a = new frm_HistoricoVendas();
                a.ShowDialog();

            }

            if (e.KeyCode == Keys.Home)
            {
                frm_Configuracao a = new frm_Configuracao();
                a.ShowDialog();
            } //tela de configuração

            if (idvenda != 0)                         // Funções com venda aberta.
            {
                if (e.KeyCode == Keys.Enter)
                {
                    pesquisar_Produto();
                }

                if (e.KeyCode == Keys.Multiply)
                {
                    try
                    {
                        if (tboxLocalizarProduto.Text == "")
                        {
                            tbox_Qtde.Text = Conversor.converterMoeda("1,00");
                            tboxLocalizarProduto.Clear();
                            tboxLocalizarProduto.Focus();

                        }
                        else
                        {
                            tbox_Qtde.Text = Conversor.converterMoeda(tboxLocalizarProduto.Text);
                            tboxLocalizarProduto.Clear();
                            tboxLocalizarProduto.Focus();
                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Quantidade informada invalida!", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tboxLocalizarProduto.Focus();

                    }
                }

                if (e.KeyCode == Keys.Delete)
                {
                    try
                    {
                        dgv_Itens_Venda.Rows.RemoveAt(Convert.ToInt32(tboxLocalizarProduto.Text) - 1);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Produto não localizado no indice informado.", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    totalizador();
                }

                if (e.KeyCode == Keys.F2)
                {
                    if (Convert.ToDecimal(lbl_vlrOriginal.Text) > 0)
                    {
                        lblDescricao.Text = "FINALIZAR VENDA";

                        frm_PDVPagamento a = new frm_PDVPagamento(this);
                        a.lbl_Desconto.Text = this.lbl_vrlDesconto.Text;
                        a.lbl_Total.Text = this.lbl_vlrOriginal.Text;
                        a.idCliente = this.idCliente;
                        a.idvenda = this.idvenda;
                        a.ShowDialog();

                    }

                }

                if (e.KeyCode == Keys.C)
                {
                    frm_PDVPesquisarCliente a = new frm_PDVPesquisarCliente(this);
                    a.label1.Text = "Pesquisar Cliente";
                    a.ShowDialog();
                }


                if (e.KeyCode == Keys.D)
                {
                    if (Convert.ToDecimal(lbl_vlrOriginal.Text) > 0)
                    {
                        frm_PDVDesconto a = new frm_PDVDesconto(this);
                        a.ShowDialog();
                        tboxLocalizarProduto.Clear();
                        tboxLocalizarProduto.Focus();
                        totalizador();
                    }
                }
                
                if (e.KeyCode == Keys.P)
                {
                    frm_ProdutoConsultar a = new frm_ProdutoConsultar(this);
                    a.lbl_NomeRotina.Text = "PESQUISAR PRODUTOS";
                    a.ShowDialog();
                }
            }
          
        }
        private void tboxLocalizarProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)
            {
                e.Handled = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToLongTimeString();

            if (cont > 30)
            {
                if (lblDescricao.Text == "OBRIGADO, VOLTE SEMPRE!")                       
                {
                    lblDescricao.Text = "CAIXA LIVRE";
                }
             cont = 0;
            }
            cont++;
        }
        private void lbl_TelaFuncoes_Click(object sender, EventArgs e)
        {
            frm_PDVAtalhos a = new frm_PDVAtalhos();
            a.ShowDialog();
        }
    }
}
