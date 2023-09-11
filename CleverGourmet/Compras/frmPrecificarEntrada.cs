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
    public partial class frmPrecificarEntrada : Padrao
    {
        Conexao conexao = new Conexao();
        public frmPrecificarEntrada()
        {
            InitializeComponent();
        }
        private void pesquisar_Compra()
        {
           
            conexao.Abre_Conexao();

            try
            {
                dgv_resultado_Entradas.Rows.Clear();
                dgv_ItensVenda.Rows.Clear();
                string numVenda = "";

                if (tboxNumDoc.Text == "")
                {
                    numVenda = "IS NOT NULL";
                }
                else
                {
                    numVenda = " = " + tboxNumDoc.Text;
                }

                string SQLCunsultaEmpr = " SELECT                 " +
                                         " P.ID,                  " +
                                         " P.IDFUNC,              " +
                                         " E.NOME,                " +
                                         " P.IDFORNEC,            " +
                                         " F.RAZAOSOCIAL,          " +
                                         " P.DTLANC             " +
                                         " FROM                   " +
                                         " TBPEDIDO         P,    " +
                                         " TBFUNCIONARIO    E,    " +
                                         " TBFORNECEDOR     F     " +
                                         " WHERE                  " +
                                         " P.IDFUNC   = E.ID AND  " +
                                         " P.IDFORNEC = F.ID AND   " +
                                         " P.STATUS IS NULL  AND   " +
                                         "  P.ID " + numVenda + " AND P.DTLANC BETWEEN '" + Convert.ToDateTime(tboxDtini.Text).ToString("yyyy-MM-dd") + "' AND '" + Convert.ToDateTime(tboxDtFim.Text).ToString("yyyy-MM-dd") + "'";



                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;

                conexao.cmd.ExecuteNonQuery();
                conexao.adapter.SelectCommand = conexao.cmd;
                conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
                conexao.dataReader = conexao.cmd.ExecuteReader();

                int o = 0;


                while (conexao.dataReader.Read())
                {
                    dgv_resultado_Entradas.Rows.Add();
                    dgv_resultado_Entradas.Rows[o].Cells["IDENTRADA"].Value = conexao.dataReader["ID"].ToString();
                    dgv_resultado_Entradas.Rows[o].Cells["FORNECEDOR"].Value = conexao.dataReader["RAZAOSOCIAL"].ToString();
                    dgv_resultado_Entradas.Rows[o].Cells["DATA"].Value = Convert.ToDateTime(conexao.dataReader["DTLANC"].ToString()).ToShortDateString();

                    o++;
                }
            }
            catch (Exception)
            {

            }


    conexao.Fecha_Conexao();

        }
        private void pesquisar_Itens()
        {
            conexao.Abre_Conexao();

            try
            {
            dgv_ItensVenda.Rows.Clear();
            string SQLCunsultaEmpr = 
                               " SELECT           " +
                               " I.IDPEDIDO,      " +
                               " I.SEQ,           " +
                               " I.CODPROD,       " +
                               " P.DESCRICAO,     " +
                               " P.CODAUXILIAR,   " +
                               " P.MEDIDA,        " +
                               " I.QTDE,          " +
                               " I.PCUSTO,        " +
                               " I.IPI,           " +
                               " I.OUTROCUSTO,    " +
                               " I.DESCONTO,      " +
                               " I.TOTALUNT,      " +
                               " I.TOTAL,          " +
                               " P.PVENDA          " +
                               " FROM             " +
                               " TBPEDIDO_ITENS I," +
                               " TBPRODUTO      P " +
                               " WHERE            " +
                               " I.CODPROD = P.ID AND " +
                                   "  I.IDPEDIDO  = " + dgv_resultado_Entradas.CurrentRow.Cells["IDENTRADA"].Value.ToString();



            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();

            int o = 0;


            while (conexao.dataReader.Read())
            {
                dgv_ItensVenda.Rows.Add();
                dgv_ItensVenda.Rows[o].Cells["ITEM"].Value       = conexao.dataReader["SEQ"].ToString();
                dgv_ItensVenda.Rows[o].Cells["CODPROD"].Value    = conexao.dataReader["CODPROD"].ToString();
                dgv_ItensVenda.Rows[o].Cells["DESCRICAO"].Value  = conexao.dataReader["DESCRICAO"].ToString();
                dgv_ItensVenda.Rows[o].Cells["CODBARRA"].Value   = conexao.dataReader["CODAUXILIAR"].ToString();
                dgv_ItensVenda.Rows[o].Cells["QTDE"].Value       = conexao.dataReader["QTDE"].ToString();
                dgv_ItensVenda.Rows[o].Cells["CUSTO"].Value      = conexao.dataReader["PCUSTO"].ToString();
                dgv_ItensVenda.Rows[o].Cells["PVENDA"].Value     = Conversor.converterMoeda(conexao.dataReader["PVENDA"].ToString());
                o++;
                dgv_ItensVenda.DefaultCellStyle.ForeColor = Color.Black;
            }

            }
            catch (Exception ex)
            {
            }
             conexao.Fecha_Conexao();


        }
        private void calcularLucro()
        {
            decimal custo;
            decimal venda;
            decimal lucroP;
            decimal lucroR;
          
            for (int i = 0; i < dgv_ItensVenda.Rows.Count; i++)
            {
                try
                {
                    
                    dgv_ItensVenda.Rows[i].Cells["PVENDA"].Value = Conversor.converterMoeda(dgv_ItensVenda.Rows[i].Cells["PVENDA"].Value.ToString());

                    custo = Convert.ToDecimal(dgv_ItensVenda.Rows[i].Cells["CUSTO"].Value);
                    venda = Convert.ToDecimal(dgv_ItensVenda.Rows[i].Cells["PVENDA"].Value);
                   
                    lucroR = venda - custo;

                    lucroP = (venda * 100 / custo) - 100;

                    if (venda != 0)
                    {
                        dgv_ItensVenda.Rows[i].Cells["LUCROP"].Value = Conversor.converterMoeda(Convert.ToString(lucroP));
                        dgv_ItensVenda.Rows[i].Cells["LUCROR"].Value = Conversor.converterMoeda(Convert.ToString(lucroR));
                    }
                  
                }
                catch (Exception)
                {
                    dgv_ItensVenda.Rows[i].Cells["PVENDA"].Value = "0,00";
                }

            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar_Compra();
        }
        private void dgv_resultado_Entradas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                //pesquisar_Itens();
                //calcularLucro();
            }
            catch (Exception)
            {
            }
        }
        private void dgv_resultado_Entradas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pesquisar_Itens();
            calcularLucro();
        }
        private void dgv_ItensVenda_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            calcularLucro();
        }
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            decimal custo;
            decimal venda;
            decimal lucroP;

            for (int i = 0; i < dgv_ItensVenda.Rows.Count; i++)
            {
                try
                {
                    lucroP = Convert.ToDecimal(tboxMargem.Text);
                    custo  = Convert.ToDecimal(dgv_ItensVenda.Rows[i].Cells["CUSTO"].Value);

                    venda = custo + (custo * lucroP / 100);

                    string VALOR = venda.ToString("N2");

                    if (textBox1.Text != "")
                    {
                        StringBuilder sb = new StringBuilder(VALOR);      // Instancia o StringBuilder

                        int qtdLetras = VALOR.Length;

                        sb.Remove(qtdLetras - 1, 1);                                    // Remove 1 (um) caracter a partir do índice 0 (zero)

                        sb.Insert(qtdLetras - 1, textBox1.Text);                    // Insere o caracter na posição 0 (zero)

                        VALOR = sb.ToString();                    // Obtém a string modificada
                    }


                    dgv_ItensVenda.Rows[i].Cells["PVENDA"].Value = VALOR;


                    calcularLucro();


                }
                catch (Exception)
                {
                    dgv_ItensVenda.Rows[i].Cells["PVENDA"].Value = "0,00";
                }

            }
        }
        private void tboxMargem_Leave(object sender, EventArgs e)
        {
            tboxMargem.Text = Conversor.converterMoeda(tboxMargem.Text);
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            //try
            //{
            //    textBox1.Text = Convert.ToInt32(textBox1.Text);
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (textBox1.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void tboxMargem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (textBox1.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
        private void tboxMargem_Enter(object sender, EventArgs e)
        {
            if (tboxMargem.Text == "0,00")
            {
                tboxMargem.Clear();
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgv_ItensVenda.Rows.Count; i++)
            {
                if (dgv_ItensVenda.Rows[i].Cells["PVENDA"].Value.ToString() == "")
                {
                    MessageBox.Show("Existe um ou mais produtos com preço de vendas zerado. Não será possivel continuar.", "Clever Sistemas",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return;
                }

                try
                {
                    conexao.Abre_Conexao();

                    string SQLCunsultaEmpr = "UPDATE TBPRODUTO SET " +
                                                      " PVENDA      = @PVENDA        " +
                                                      " WHERE  ID = " + dgv_ItensVenda.Rows[i].Cells["CODPROD"].Value.ToString();



                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.Parameters.AddWithValue("PVENDA",  dgv_ItensVenda.Rows[i].Cells["PVENDA"].Value.ToString());
                    conexao.cmd.ExecuteNonQuery();

                    conexao.Fecha_Conexao();
                }

                catch (Exception ex)
                {
                        MessageBox.Show(ex.Message, "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            MessageBox.Show("Cadastro Atualizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void btnTabelaPreco_Click(object sender, EventArgs e)
        {
            try
            {
                string SQLCunsultaEmpr = " SELECT              " +
                                    " P.ID,               " +
                                    " P.DESCRICAO,        " +
                                    " P.CODAUXILIAR,      " +
                                    " P.MEDIDA,           " +
                                    " P.PCUSTO,           " +
                                    " P.ESTOQUE,          " +
                                    " P.PVENDA,           " +
                                    " P.IMG,              " +
                                    " S.IDDEPTO,          " +
                                    " D.DEPARTAMENTO,     " +
                                    " P.IDSECAO,          " +
                                    " S.SECAO,             " +
                                    " P.TIPO,             " +
                                    " P.NS,               " +
                                    " P.OBS               " +
                                    "                     " +
                                    " FROM                " +
                                    " TBPRODUTO P,        " +
                                    " TBDEPTO   D,        " +
                                    " TBSECAO S           " +
                                    "                     " +
                                    " WHERE               " +
                                    "                     " +
                                    " P.IDSECAO = S.ID AND" +
                                    " S.IDDEPTO = D.ID  AND P.ID IN ( SELECT CODPROD FROM TBPEDIDO_ITENS WHERE IDPEDIDO = " + dgv_resultado_Entradas.CurrentRow.Cells["IDENTRADA"].Value.ToString() + " )";

                frm_Relatorio a = new frm_Relatorio();
                a.Arquivo_rdlc = "Rpv_Produto_Tabela_Preco.rdlc";
                a.Sql_Relatorio1 = SQLCunsultaEmpr;
                a.Dataset_Relatorio1 = "DataSet_Produto";
                a.ShowDialog();

            }
            catch (Exception)
            {
            }
              
        }

       
    }
}
