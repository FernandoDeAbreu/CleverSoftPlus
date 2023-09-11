using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CleverSoft
{
    public partial class frm_HistoricoVendas : ModeloSimples
    {
        Conexao conexao = new Conexao();
        public string historicoCancelamento;
        string SQLCunsultaEmpr;

        public frm_HistoricoVendas()
        {
            InitializeComponent();
        }
        private void pesquisar_Venda()
        {
           
            conexao.Abre_Conexao();
            dgv_Resultado_vendas.Rows.Clear();

            string numVenda = "";
           
            if (tboxNumDoc.Text == "")
            {
                numVenda = "IS NOT NULL";
            }
            else
            {
                numVenda = " = " + tboxNumDoc.Text;
            }

            SQLCunsultaEmpr = " SELECT * FROM vwRESUMO_VENDAS  " +
                                   " WHERE ID " + numVenda + " AND DATA BETWEEN '" + Convert.ToDateTime(tbox_DtIni.Text).ToString("yyyy-MM-dd") + "' AND '" + Convert.ToDateTime(tbox_DtFim.Text).ToString("yyyy-MM-dd") + "'";

            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();

            int o = 0;


            while (conexao.dataReader.Read())
            {
                dgv_Resultado_vendas.Rows.Add();
                dgv_Resultado_vendas.Rows[o].Cells["ID"].Value            = conexao.dataReader["ID"].ToString();
                dgv_Resultado_vendas.Rows[o].Cells["IDFILIAL"].Value      = conexao.dataReader["IDFILIAL"].ToString();
                dgv_Resultado_vendas.Rows[o].Cells["DATA"].Value          = Convert.ToDateTime(conexao.dataReader["DATA"].ToString()).ToShortDateString();
                dgv_Resultado_vendas.Rows[o].Cells["HORA"].Value          = Convert.ToDateTime(conexao.dataReader["HORA"].ToString()).ToLongTimeString();
                dgv_Resultado_vendas.Rows[o].Cells["IDFUNC"].Value        = conexao.dataReader["IDFUNC"].ToString();
                dgv_Resultado_vendas.Rows[o].Cells["IDCLIENTE"].Value     = conexao.dataReader["IDCLIENTE"].ToString();
                dgv_Resultado_vendas.Rows[o].Cells["CLIENTE"].Value       = conexao.dataReader["RAZAOSOCIAL:1"].ToString();
                dgv_Resultado_vendas.Rows[o].Cells["VLRORIGINAL"].Value   = Conversor.converterMoeda(conexao.dataReader["VLRORIGINAL"].ToString());
                dgv_Resultado_vendas.Rows[o].Cells["VLRDESC"].Value       = Conversor.converterMoeda(conexao.dataReader["VLRDESC"].ToString());
                dgv_Resultado_vendas.Rows[o].Cells["VLRPAGO"].Value       = Conversor.converterMoeda(conexao.dataReader["VLRPAGO"].ToString());
                dgv_Resultado_vendas.Rows[o].Cells["VLRVENDA"].Value      = Conversor.converterMoeda(conexao.dataReader["VLRVENDA"].ToString());
                dgv_Resultado_vendas.Rows[o].Cells["VLRTROCO"].Value      = Conversor.converterMoeda(conexao.dataReader["VLRTROCO"].ToString());
                dgv_Resultado_vendas.Rows[o].Cells["STATUS"].Value = conexao.dataReader["STATUS"].ToString();
                

                o++;
                dgv_Resultado_vendas.DefaultCellStyle.ForeColor = Color.Black;
            }
            decimal total = 0;
            decimal valor = 0;
            decimal desconto = 0;
            decimal juros = 0;
            for (int i = 0; i < dgv_Resultado_vendas.RowCount; i++)
            {
                total = total + Convert.ToDecimal(dgv_Resultado_vendas.Rows[i].Cells["VLRORIGINAL"].Value.ToString());
                valor = valor + Convert.ToDecimal(dgv_Resultado_vendas.Rows[i].Cells["VLRVENDA"].Value.ToString());
                desconto = desconto + Convert.ToDecimal(dgv_Resultado_vendas.Rows[i].Cells["VLRDESC"].Value.ToString());
                juros = juros + Convert.ToDecimal(dgv_Resultado_vendas.Rows[i].Cells["VLRTROCO"].Value.ToString());

                tboxValorTotal.Text   = Conversor.converterMoeda(Convert.ToString(total));
                tboxValorLiquido.Text = Conversor.converterMoeda(Convert.ToString(valor));
                tboxDesconto.Text     = Conversor.converterMoeda(Convert.ToString(desconto));
                tboxTroco.Text        = Conversor.converterMoeda(Convert.ToString(juros));
                tboxQtdeVendas.Text   = Conversor.converterMoeda(Convert.ToString(i+1));
            }


            conexao.Fecha_Conexao();

        }
        private void pesquisar_Itens()
        {
            try
            {
                 conexao.Abre_Conexao();
            dgv_ItensVenda.Rows.Clear();



            SQLCunsultaEmpr = " SELECT          " +
                                   " I.IDVENDA,      " +
                                   " I.SEQ,          " +
                                   " I.CODPROD,      " +
                                   " P.DESCRICAO,    " +
                                   " P.CODAUXILIAR,  " +
                                   " P.MEDIDA,       " +
                                   " I.QTDE,         " +
                                   " I.PCUSTO,       " +
                                   " I.PUNIT,        " +
                                   " I.PDESC,        " +
                                   " I.PVENDA,       " +
                                   " I.PTOTAL,       " +
                                   " I.TOTALDESC     " +
                                   " FROM            " +
                                   " TBVENDA_ITENS I," +
                                   " TBPRODUTO     P " +
                                   " WHERE           " +
                                   " I.CODPROD = P.ID AND IDVENDA = " + dgv_Resultado_vendas.CurrentRow.Cells["ID"].Value.ToString();

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
                dgv_ItensVenda.Rows[o].Cells["IDVENDA"].Value        = conexao.dataReader["IDVENDA"].ToString();
                dgv_ItensVenda.Rows[o].Cells["SEQ"].Value            = conexao.dataReader["SEQ"].ToString();
                dgv_ItensVenda.Rows[o].Cells["CODPROD"].Value        = conexao.dataReader["CODPROD"].ToString();
                dgv_ItensVenda.Rows[o].Cells["DESCRICAO"].Value      = conexao.dataReader["DESCRICAO"].ToString();
                dgv_ItensVenda.Rows[o].Cells["CODAUXILIAR"].Value    = conexao.dataReader["CODAUXILIAR"].ToString();
                dgv_ItensVenda.Rows[o].Cells["MEDIDA"].Value         = conexao.dataReader["MEDIDA"].ToString();
                    dgv_ItensVenda.Rows[o].Cells["QTDE"].Value       = Conversor.converterMoeda(conexao.dataReader["QTDE"].ToString());
                    dgv_ItensVenda.Rows[o].Cells["PCUSTO"].Value     = Conversor.converterMoeda(conexao.dataReader["PCUSTO"].ToString());
                    dgv_ItensVenda.Rows[o].Cells["PUNIT"].Value      = Conversor.converterMoeda(conexao.dataReader["PUNIT"].ToString());
                    dgv_ItensVenda.Rows[o].Cells["PDESC"].Value      = Conversor.converterMoeda(conexao.dataReader["PDESC"].ToString());
                    dgv_ItensVenda.Rows[o].Cells["PVENDA"].Value     = Conversor.converterMoeda(conexao.dataReader["PVENDA"].ToString());
                    dgv_ItensVenda.Rows[o].Cells["PTOTAL"].Value     = Conversor.converterMoeda(conexao.dataReader["PTOTAL"].ToString());
                    dgv_ItensVenda.Rows[o].Cells["TOTALDESC"].Value  = Conversor.converterMoeda(conexao.dataReader["TOTALDESC"].ToString());



                o++;
                dgv_ItensVenda.DefaultCellStyle.ForeColor = Color.Black;

            }
            decimal total = 0;
            decimal valor = 0;
            decimal desconto = 0;
           
            for (int i = 0; i < dgv_ItensVenda.RowCount; i++)
            {
                total = total + Convert.ToDecimal(dgv_ItensVenda.Rows[i].Cells["PTOTAL"].Value.ToString());
                valor = valor + Convert.ToDecimal(dgv_ItensVenda.Rows[i].Cells["PVENDA"].Value.ToString());
                desconto = desconto + Convert.ToDecimal(dgv_ItensVenda.Rows[i].Cells["PDESC"].Value.ToString());

                tboxTotalLiquiVenda.Text =  Convert.ToString(total);
                tboxTotaVenda.Text       =  Convert.ToString(valor + desconto);
                tboxDescontoVenda.Text   = Convert.ToString(desconto);
            }


            conexao.Fecha_Conexao();
            }
            catch (Exception)
            {

                
            }
           

        }
        private void pesquisar_FormaPgto()
        {
            try
            {
                conexao.Abre_Conexao();
                dgv_formaPagto.Rows.Clear();

                SQLCunsultaEmpr = " SELECT            " +
                                  " F.ID,             " +
                                  " F.IDMOEDA,        " +
                                  " M.MOEDA,      " +
                                  " F.DTLANC,         " +
                                  " F.DTVENC,         " +
                                  " F.VLRTOTAL        " +
                                  "                   " +
                                  " FROM              " +
                                  " TBCR F,    " +
                                  " TBMOEDA M  " +
                                  " WHERE             " +
                                  " F.IDMOEDA = M.ID AND F.IDVENDA = " + dgv_Resultado_vendas.CurrentRow.Cells["ID"].Value.ToString() + "";

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
                    dgv_formaPagto.Rows[o].Cells["NLANC"].Value    = conexao.dataReader["ID"].ToString();
                    dgv_formaPagto.Rows[o].Cells["IDMOEDA"].Value  = conexao.dataReader["IDMOEDA"].ToString();
                    dgv_formaPagto.Rows[o].Cells["DTLANC"].Value   = Convert.ToDateTime(conexao.dataReader["DTLANC"].ToString()).ToShortDateString();
                    dgv_formaPagto.Rows[o].Cells["MOEDA"].Value    = conexao.dataReader["MOEDA"].ToString();
                    dgv_formaPagto.Rows[o].Cells["DTVENC"].Value   = Convert.ToDateTime(conexao.dataReader["DTVENC"].ToString()).ToShortDateString();
                    dgv_formaPagto.Rows[o].Cells["VLRTOTAL"].Value = Conversor.converterMoeda(conexao.dataReader["VLRTOTAL"].ToString());

                    o++;
                    dgv_formaPagto.DefaultCellStyle.ForeColor = Color.Black;
                }


                conexao.Fecha_Conexao();
            }
            catch (Exception)
            {

            }
           
        }
        private void pesquisar_VendidosNoPeriodo()
        {

            decimal custo = 0;
            decimal venda = 0;
            decimal lucro = 0;

            try
            {
            conexao.Abre_Conexao();
            dataGridView1.Rows.Clear();



                SQLCunsultaEmpr =
                           " SELECT                      " +
                           " I.CODPROD,                  " +
                           " P.DESCRICAO,                " +
                           " P.CODAUXILIAR,              " +
                           " COUNT(I.QTDE)   AS QTDE,     " +
                           " SUM(CAST(REPLACE (I.PCUSTO,',','.') AS  DECIMAL(10, 4))) AS CUSTO, " +
                           " SUM(CAST(REPLACE(I.PVENDA, ',', '.') AS  DECIMAL(10, 4))) AS VENDA " +
                           " FROM                        " +
                           " TBVENDA V,                  " +
                           " TBVENDA_ITENS I,            " +
                           " TBPRODUTO P                 " +
                           " WHERE                       " +
                           " I.IDVENDA = V.ID AND        " +
                           " I.CODPROD = P.ID            " +
                           " AND V.DATA BETWEEN '" + tbox_DtIni.Text + "' AND '" + tbox_DtFim.Text + "'" +
                           " GROUP BY                    " +
                           " I.CODPROD,                  " +
                           " P.DESCRICAO,                " +
                           " P.CODAUXILIAR               " +
                           "                             " +
                           " ORDER BY QTDE DESC ";


            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();

            int o = 0;


            while (conexao.dataReader.Read())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[o].Cells["CODPROD3"].Value      = conexao.dataReader["CODPROD"].ToString();
                dataGridView1.Rows[o].Cells["DESCRICAO3"].Value    = conexao.dataReader["DESCRICAO"].ToString();
                dataGridView1.Rows[o].Cells["CODAUXILIAR3"].Value  = conexao.dataReader["CODAUXILIAR"].ToString();
                dataGridView1.Rows[o].Cells["QTDE3"].Value         = Conversor.converterMoeda(conexao.dataReader["QTDE"].ToString());
                dataGridView1.Rows[o].Cells["CUSTO3"].Value        = Conversor.converterMoeda(conexao.dataReader["CUSTO"].ToString());
                dataGridView1.Rows[o].Cells["VENDA3"].Value        = Conversor.converterMoeda(conexao.dataReader["VENDA"].ToString());
               

                o++;
                    dataGridView1.DefaultCellStyle.ForeColor = Color.Black;


                    custo +=  Convert.ToDecimal(conexao.dataReader["CUSTO"].ToString());
                    venda += Convert.ToDecimal(conexao.dataReader["VENDA"].ToString());


                    lucro = venda - custo;

                    tboxLucroRS.Text = Conversor.converterMoeda(Convert.ToString(lucro));
                    tboxLucroPorc.Text = Conversor.converterMoeda(Convert.ToString((venda*100/ custo) - 100));
                }

            conexao.Fecha_Conexao();

               
            }
            catch (Exception)
            {

                
            }
           

        }
        private void cancelarContaReceber()
        {
            conexao.Abre_Conexao();
            string SQLCunsultaEmpr = " UPDATE TBCR SET " +
                                               "  HISTORICO  = @HISTORICO,         " +
                                               "  STATUS  = @STATUS         " +
                                               " WHERE IDVENDA =  " + dgv_Resultado_vendas.CurrentRow.Cells["ID"].Value.ToString();

            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;
            conexao.cmd.Parameters.AddWithValue("STATUS", "CANCELADA");
            conexao.cmd.Parameters.AddWithValue("HISTORICO", "Venda cancelada");

            conexao.cmd.ExecuteNonQuery();

            MessageBox.Show("Contas a receber Atualizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexao.Fecha_Conexao();
        }
        private void cancelarVenda()
        {
            conexao.Abre_Conexao();
            string SQLCunsultaEmpr = " UPDATE TBVENDA SET " +
                                               "  HISTORICO  = @HISTORICO,  " +
                                               "  STATUS  = @STATUS         " +
                                               " WHERE ID =  " + dgv_Resultado_vendas.CurrentRow.Cells["ID"].Value.ToString();

            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;
            conexao.cmd.Parameters.AddWithValue("STATUS", "CANCELADA");
            conexao.cmd.Parameters.AddWithValue("HISTORICO", "Venda cancelada");

            conexao.cmd.ExecuteNonQuery();


            conexao.Fecha_Conexao();
            ajustarEstoque();
            cancelarContaReceber();
            MessageBox.Show("Venda Cancelada com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void ajustarEstoque()
        {
            conexao.Abre_Conexao();

            for (int i = 0; i < dgv_ItensVenda.Rows.Count; i++)
            {
                string SQLCunsultaEmpr = " UPDATE TBPRODUTO SET " +
                                                            "  ESTOQUE  = ESTOQUE + '" + dgv_ItensVenda.Rows[i].Cells["QTDE"].Value.ToString() +"'" +
                                                            " WHERE ID =  " + dgv_ItensVenda.Rows[i].Cells["CODPROD"].Value.ToString();

                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;

                conexao.cmd.ExecuteNonQuery();

                MessageBox.Show("Estoque Atualizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         

            conexao.Fecha_Conexao();
        }
        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            pesquisar_Venda();
            pesquisar_VendidosNoPeriodo();
        }
        private void tbox_DtIni_ValueChanged(object sender, EventArgs e)
        {
        }
        private void tbox_DtFim_ValueChanged(object sender, EventArgs e)
        {
        }
        private void dgv_resultado_pesquisa_Click(object sender, EventArgs e)
        {
            pesquisar_Itens();
            pesquisar_FormaPgto();
        }
        private void frm_HistoricoVendas_Load(object sender, EventArgs e)
        {
            Relatorio1ToolStripMenuItem.Visible = true;
            Relatorio1ToolStripMenuItem.Text = "Comprovante A4";

            Relatorio2ToolStripMenuItem.Visible = true;
            Relatorio2ToolStripMenuItem.Text = "Cupom não Fiscal";
        }
        private void Relatorio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RelatorioVendas a = new RelatorioVendas();
                a.idVendaCupom = Convert.ToInt32(dgv_Resultado_vendas.CurrentRow.Cells["ID"].Value.ToString());
                a.gerarCupom();
                a.cupomA4();
            }
            catch (Exception)
            {

              
            }
           
        }
        private void Relatorio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                RelatorioVendas a = new RelatorioVendas();
                a.idVendaCupom = Convert.ToInt32(dgv_Resultado_vendas.CurrentRow.Cells["ID"].Value.ToString());
                a.gerarCupom();
                a.cupomNfiscal();
            }
            catch (Exception)
            {

             
            }
        }
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (dgv_ItensVenda.Rows.Count == 0)
            {
                MessageBox.Show("Selecione uma venda para ser cancelada.", "Clever Sistema",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (dgv_formaPagto.Rows.Count == 0)
            {
                MessageBox.Show("Selecione uma venda para ser cancelada.", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Realmente deseja cancelar a venda selecionada.", "Clever Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cancelarVenda();
                pesquisar_Venda();
            }
          
        }
        private void dgv_Resultado_vendas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tabControl1.SelectedIndex = 1;
            }
            catch (Exception)
            {

            }
        }
    }
}
