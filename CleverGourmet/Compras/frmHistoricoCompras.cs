using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverSoft.Compras
{
    public partial class frmHistoricoCompras : Padrao
    {
        Conexao conexao = new Conexao();

        public string historicoCancelamento;

        string SQLCunsultaEmpr;
        public frmHistoricoCompras()
        {
            InitializeComponent();
        }
        private void montaGridPedido()
        {
            #region MONTAR GRID CONSULTA

            DataGridViewTextBoxColumn col_ITEM = new DataGridViewTextBoxColumn();
            col_ITEM.Name = "ITEM";
            col_ITEM.HeaderText = "Entrada";
            col_ITEM.Width = 60;
            dgv_resultado_pesquisa.Columns.Add(col_ITEM);

            DataGridViewTextBoxColumn col_IDFUNC = new DataGridViewTextBoxColumn();
            col_IDFUNC.Name = "IDFUNC";
            col_IDFUNC.HeaderText = "Cód.Func.";
            col_IDFUNC.Width = 90;
            col_IDFUNC.Visible = false;
            dgv_resultado_pesquisa.Columns.Add(col_IDFUNC);

            DataGridViewTextBoxColumn col_NOME = new DataGridViewTextBoxColumn();
            col_NOME.Name = "NOME";
            col_NOME.HeaderText = "Usuário";
            col_NOME.Width = 250;
            dgv_resultado_pesquisa.Columns.Add(col_NOME);

            DataGridViewTextBoxColumn col_IDFORNEC = new DataGridViewTextBoxColumn();
            col_IDFORNEC.Name = "IDFORNEC";
            col_IDFORNEC.HeaderText = "Cód. Fornec.";
            col_IDFORNEC.Width = 100;
            dgv_resultado_pesquisa.Columns.Add(col_IDFORNEC);

            DataGridViewTextBoxColumn col_RAZAOSOCIAL = new DataGridViewTextBoxColumn();
            col_RAZAOSOCIAL.Name = "RAZAOSOCIAL";
            col_RAZAOSOCIAL.HeaderText = "Razão Social";
            col_RAZAOSOCIAL.Width = 400;
            dgv_resultado_pesquisa.Columns.Add(col_RAZAOSOCIAL);

            DataGridViewTextBoxColumn col_DTLANC = new DataGridViewTextBoxColumn();
            col_DTLANC.Name = "DTLANC";
            col_DTLANC.HeaderText = "Data";
            col_DTLANC.Width = 150;
            dgv_resultado_pesquisa.Columns.Add(col_DTLANC);

            #endregion
        }
        private void montarGridItens()
        {
            #region MONTAR GRID CONSULTA

            DataGridViewTextBoxColumn col_ITEM = new DataGridViewTextBoxColumn();
            col_ITEM.Name = "ITEM";
            col_ITEM.HeaderText = "Item";
            col_ITEM.Width = 45;
            dgv_ItensVenda.Columns.Add(col_ITEM);

            DataGridViewTextBoxColumn col_CODPROD = new DataGridViewTextBoxColumn();
            col_CODPROD.Name = "CODPROD";
            col_CODPROD.HeaderText = "Código";
            col_CODPROD.Width = 90;
            dgv_ItensVenda.Columns.Add(col_CODPROD);

            DataGridViewTextBoxColumn col_DESCRICAO = new DataGridViewTextBoxColumn();
            col_DESCRICAO.Name = "DESCRICAO";
            col_DESCRICAO.HeaderText = "Descrição";
            col_DESCRICAO.Width = 350;
            dgv_ItensVenda.Columns.Add(col_DESCRICAO);

            DataGridViewTextBoxColumn col_CODBARRA = new DataGridViewTextBoxColumn();
            col_CODBARRA.Name = "CODBARRA";
            col_CODBARRA.HeaderText = "Cód. Auxiliar";
            col_CODBARRA.Width = 150;
            dgv_ItensVenda.Columns.Add(col_CODBARRA);

            DataGridViewTextBoxColumn col_UND = new DataGridViewTextBoxColumn();
            col_UND.Name = "UND";
            col_UND.HeaderText = "Und";
            col_UND.Width = 90;
            dgv_ItensVenda.Columns.Add(col_UND);

            DataGridViewTextBoxColumn col_QTDE = new DataGridViewTextBoxColumn();
            col_QTDE.Name = "QTDE";
            col_QTDE.HeaderText = "Qtde";
            col_QTDE.Width = 90;
            dgv_ItensVenda.Columns.Add(col_QTDE);

            DataGridViewTextBoxColumn col_PCUSTO = new DataGridViewTextBoxColumn();
            col_PCUSTO.Name = "PCUSTO";
            col_PCUSTO.HeaderText = "P. Custo";
            col_PCUSTO.Width = 90;
            dgv_ItensVenda.Columns.Add(col_PCUSTO);

            DataGridViewTextBoxColumn col_IPI = new DataGridViewTextBoxColumn();
            col_IPI.Name = "IPI";
            col_IPI.HeaderText = "IPI";
            col_IPI.Width = 90;
            dgv_ItensVenda.Columns.Add(col_IPI);

            DataGridViewTextBoxColumn col_OUTROSCUSTO = new DataGridViewTextBoxColumn();
            col_OUTROSCUSTO.Name = "OUTROCUSTO";
            col_OUTROSCUSTO.HeaderText = "O. Custos";
            col_OUTROSCUSTO.Width = 90;
            dgv_ItensVenda.Columns.Add(col_OUTROSCUSTO);

            DataGridViewTextBoxColumn col_DESCONTO = new DataGridViewTextBoxColumn();
            col_DESCONTO.Name = "DESCONTO";
            col_DESCONTO.HeaderText = "Desconto";
            col_DESCONTO.Width = 90;
            dgv_ItensVenda.Columns.Add(col_DESCONTO);

            DataGridViewTextBoxColumn col_TOTALUNT = new DataGridViewTextBoxColumn();
            col_TOTALUNT.Name = "TOTALUNT";
            col_TOTALUNT.HeaderText = "Total Unt";
            col_TOTALUNT.Width = 90;
            dgv_ItensVenda.Columns.Add(col_TOTALUNT);

            DataGridViewTextBoxColumn col_TOTAL = new DataGridViewTextBoxColumn();
            col_TOTAL.Name = "TOTAL";
            col_TOTAL.HeaderText = "TOTAL";
            col_TOTAL.Width = 90;
            dgv_ItensVenda.Columns.Add(col_TOTAL);


            #endregion

        }
        private void montarGridContaPagar()
        {
            #region MONTAR GRID CONSULTA

            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.Name = "ID";
            col_ID.HeaderText = "LANÇAMENTO";
            col_ID.Width = 100;
            dgv_formaPagto.Columns.Add(col_ID);

            DataGridViewTextBoxColumn col_TIPO = new DataGridViewTextBoxColumn();
            col_TIPO.Name = "TIPO";
            col_TIPO.HeaderText = "TIPO";
            col_TIPO.Width = 70;
            dgv_formaPagto.Columns.Add(col_TIPO);

            DataGridViewTextBoxColumn col_HISTORICO = new DataGridViewTextBoxColumn();
            col_HISTORICO.Name = "HISTORICO";
            col_HISTORICO.HeaderText = "HISTÓRICO";
            col_HISTORICO.Width = 270;
            dgv_formaPagto.Columns.Add(col_HISTORICO);

            DataGridViewTextBoxColumn col_VALOR = new DataGridViewTextBoxColumn();
            col_VALOR.Name = "VALOR";
            col_VALOR.HeaderText = "VALOR";
            col_VALOR.Width = 100;
            dgv_formaPagto.Columns.Add(col_VALOR);

            DataGridViewTextBoxColumn col_VLRDESC = new DataGridViewTextBoxColumn();
            col_VLRDESC.Name = "VLRDESC";
            col_VLRDESC.HeaderText = "DESCONTO";
            col_VLRDESC.Width = 100;
            dgv_formaPagto.Columns.Add(col_VLRDESC);

            DataGridViewTextBoxColumn col_VLRJUROS = new DataGridViewTextBoxColumn();
            col_VLRJUROS.Name = "VLRJUROS";
            col_VLRJUROS.HeaderText = "JUROS";
            col_VLRJUROS.Width = 100;
            dgv_formaPagto.Columns.Add(col_VLRJUROS);

            DataGridViewTextBoxColumn col_VLRTOTAL = new DataGridViewTextBoxColumn();
            col_VLRTOTAL.Name = "VLRTOTAL";
            col_VLRTOTAL.HeaderText = "TOTAL";
            col_VLRTOTAL.Width = 100;
            dgv_formaPagto.Columns.Add(col_VLRTOTAL);

            DataGridViewTextBoxColumn col_VLREXTENSO = new DataGridViewTextBoxColumn();
            col_VLREXTENSO.Name = "VLREXTENSO";
            col_VLREXTENSO.HeaderText = "VLREXTENSO";
            col_VLREXTENSO.Visible = false;
            dgv_formaPagto.Columns.Add(col_VLREXTENSO);


            DataGridViewTextBoxColumn col_IDPARCEIRO = new DataGridViewTextBoxColumn();
            col_IDPARCEIRO.Name = "IDPARCEIRO";
            col_IDPARCEIRO.HeaderText = "CÓD. PARC";
            col_IDPARCEIRO.Width = 120;
            dgv_formaPagto.Columns.Add(col_IDPARCEIRO);

            DataGridViewTextBoxColumn col_PARCEIRO = new DataGridViewTextBoxColumn();
            col_PARCEIRO.Name = "PARCEIRO";
            col_PARCEIRO.HeaderText = "PARCEIRO";
            col_PARCEIRO.Width = 250;
            dgv_formaPagto.Columns.Add(col_PARCEIRO);

            DataGridViewTextBoxColumn col_IDMOEDA = new DataGridViewTextBoxColumn();
            col_IDMOEDA.Name = "IDMOEDA";
            col_IDMOEDA.HeaderText = "CÓD MOEDA";
            col_IDMOEDA.Width = 120;
            dgv_formaPagto.Columns.Add(col_IDMOEDA);

            DataGridViewTextBoxColumn col_MOEDA = new DataGridViewTextBoxColumn();
            col_MOEDA.Name = "MOEDA";
            col_MOEDA.HeaderText = "MOEDA";
            col_MOEDA.Width = 180;
            dgv_formaPagto.Columns.Add(col_MOEDA);

            DataGridViewTextBoxColumn col_IDBANCOCONTA = new DataGridViewTextBoxColumn();
            col_IDBANCOCONTA.Name = "IDBANCOCONTA";
            col_IDBANCOCONTA.HeaderText = "CÓD BANCO";
            col_IDBANCOCONTA.Width = 120;
            dgv_formaPagto.Columns.Add(col_IDBANCOCONTA);

            DataGridViewTextBoxColumn col_BANCOCONTA = new DataGridViewTextBoxColumn();
            col_BANCOCONTA.Name = "BANCOCONTA";
            col_BANCOCONTA.HeaderText = "BANCO / CONTA";
            col_BANCOCONTA.Width = 180;
            dgv_formaPagto.Columns.Add(col_BANCOCONTA);

            DataGridViewTextBoxColumn col_IDCONTAGERENCIAL = new DataGridViewTextBoxColumn();
            col_IDCONTAGERENCIAL.Name = "IDCONTAGERENCIAL";
            col_IDCONTAGERENCIAL.HeaderText = "CÓD CONTA G.";
            col_IDCONTAGERENCIAL.Width = 120;
            dgv_formaPagto.Columns.Add(col_IDCONTAGERENCIAL);

            DataGridViewTextBoxColumn col_CONTAGERENCIAL = new DataGridViewTextBoxColumn();
            col_CONTAGERENCIAL.Name = "CONTAGERENCIAL";
            col_CONTAGERENCIAL.HeaderText = "CONTA GERENCIAL";
            col_CONTAGERENCIAL.Width = 180;
            dgv_formaPagto.Columns.Add(col_CONTAGERENCIAL);

            DataGridViewTextBoxColumn col_NUMDOC = new DataGridViewTextBoxColumn();
            col_NUMDOC.Name = "NUMDOC";
            col_NUMDOC.HeaderText = "Nº DOCUMENTO";
            col_NUMDOC.Width = 180;
            dgv_formaPagto.Columns.Add(col_NUMDOC);

            DataGridViewTextBoxColumn col_DTLANC = new DataGridViewTextBoxColumn();
            col_DTLANC.Name = "DTLANC";
            col_DTLANC.HeaderText = "DT. LANC.";
            col_DTLANC.Width = 180;
            dgv_formaPagto.Columns.Add(col_DTLANC);

            DataGridViewTextBoxColumn col_DTVENC = new DataGridViewTextBoxColumn();
            col_DTVENC.Name = "DTVENC";
            col_DTVENC.HeaderText = "DT. VENC.";
            col_DTVENC.Width = 180;
            dgv_formaPagto.Columns.Add(col_DTVENC);

            DataGridViewTextBoxColumn col_DTCOMPETENCIA = new DataGridViewTextBoxColumn();
            col_DTCOMPETENCIA.Name = "DTCOMPETENCIA";
            col_DTCOMPETENCIA.HeaderText = "COMPETÊNCIA";
            col_DTCOMPETENCIA.Width = 180;
            dgv_formaPagto.Columns.Add(col_DTCOMPETENCIA);

            DataGridViewTextBoxColumn col_DTPGTO = new DataGridViewTextBoxColumn();
            col_DTPGTO.Name = "DTPGTO";
            col_DTPGTO.HeaderText = "DT. PGTO";
            col_DTPGTO.Width = 180;
            dgv_formaPagto.Columns.Add(col_DTPGTO);

            #endregion

        }
        private void pesquisar_Compra()
        {

            conexao.Abre_Conexao();
            dgv_resultado_pesquisa.Rows.Clear();
            dgv_ItensVenda.Rows.Clear();
            dgv_formaPagto.Rows.Clear();

            tabControl1.SelectedIndex = 0;

            string numVenda = "";

            if (tboxNumDoc.Text == "")
            {
                numVenda = "IS NOT NULL";
            }
            else
            {
                numVenda = " = " + tboxNumDoc.Text;
            }

            SQLCunsultaEmpr = " SELECT                 " +
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
                                   "  P.ID " + numVenda + " AND P.DTLANC BETWEEN '" + Convert.ToDateTime(tbox_DtIni.Text).ToString("yyyy-MM-dd") + "' AND '" + Convert.ToDateTime(tbox_DtFim.Text).ToString("yyyy-MM-dd") + "'";



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
                dgv_resultado_pesquisa.Rows[o].Cells["ITEM"].Value = conexao.dataReader["ID"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["IDFUNC"].Value = conexao.dataReader["IDFUNC"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["NOME"].Value = conexao.dataReader["NOME"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["IDFORNEC"].Value = conexao.dataReader["IDFORNEC"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["RAZAOSOCIAL"].Value = conexao.dataReader["RAZAOSOCIAL"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["DTLANC"].Value = Convert.ToDateTime(conexao.dataReader["DTLANC"].ToString()).ToShortDateString();

                o++;
                dgv_resultado_pesquisa.DefaultCellStyle.ForeColor = Color.Black;
            }


            conexao.Fecha_Conexao();

        }
        private void pesquisar_Itens()
        {
            try
            {
                conexao.Abre_Conexao();
                dgv_ItensVenda.Rows.Clear();


                SQLCunsultaEmpr = " SELECT           " +
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
                                   " I.TOTAL          " +
                                   " FROM             " +
                                   " TBPEDIDO_ITENS I," +
                                   " TBPRODUTO      P " +
                                   " WHERE            " +
                                   " I.CODPROD = P.ID AND " +
                                       "  I.IDPEDIDO  = " + dgv_resultado_pesquisa.CurrentRow.Cells["ITEM"].Value.ToString();



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
                    dgv_ItensVenda.Rows[o].Cells["ITEM"].Value = conexao.dataReader["SEQ"].ToString();
                    dgv_ItensVenda.Rows[o].Cells["CODPROD"].Value = conexao.dataReader["CODPROD"].ToString();
                    dgv_ItensVenda.Rows[o].Cells["DESCRICAO"].Value = conexao.dataReader["DESCRICAO"].ToString();
                    dgv_ItensVenda.Rows[o].Cells["CODBARRA"].Value = conexao.dataReader["CODAUXILIAR"].ToString();
                    dgv_ItensVenda.Rows[o].Cells["UND"].Value = conexao.dataReader["MEDIDA"].ToString();
                    dgv_ItensVenda.Rows[o].Cells["QTDE"].Value = conexao.dataReader["QTDE"].ToString();
                    dgv_ItensVenda.Rows[o].Cells["PCUSTO"].Value = conexao.dataReader["PCUSTO"].ToString();
                    dgv_ItensVenda.Rows[o].Cells["IPI"].Value = conexao.dataReader["IPI"].ToString();
                    dgv_ItensVenda.Rows[o].Cells["OUTROCUSTO"].Value = conexao.dataReader["OUTROCUSTO"].ToString();
                    dgv_ItensVenda.Rows[o].Cells["DESCONTO"].Value = conexao.dataReader["DESCONTO"].ToString();
                    dgv_ItensVenda.Rows[o].Cells["TOTALUNT"].Value = conexao.dataReader["TOTALUNT"].ToString();
                    dgv_ItensVenda.Rows[o].Cells["TOTAL"].Value = conexao.dataReader["TOTAL"].ToString();
                    o++;
                    dgv_ItensVenda.DefaultCellStyle.ForeColor = Color.Black;
                }


                conexao.Fecha_Conexao();
            }
            catch (Exception)
            {


            }


        }
        private void pesquisar_ContaPagar()
        {
            try
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
                                         " FROM                     " +
                                         " TBFINANCEIRO              F,     " +
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
                                         " F.TIPO =  'D'         AND F.IDVENDA = " + dgv_resultado_pesquisa.CurrentRow.Cells["ITEM"].Value.ToString();



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
                    dgv_formaPagto.Rows[o].Cells["ID"].Value = conexao.dataReader["ID"].ToString();
                    dgv_formaPagto.Rows[o].Cells["TIPO"].Value = conexao.dataReader["TIPO"].ToString();
                    dgv_formaPagto.Rows[o].Cells["IDPARCEIRO"].Value = conexao.dataReader["IDPARCEIRO"].ToString();
                    dgv_formaPagto.Rows[o].Cells["PARCEIRO"].Value = conexao.dataReader["RAZAOSOCIAL"].ToString();
                    dgv_formaPagto.Rows[o].Cells["IDMOEDA"].Value = conexao.dataReader["IDMOEDA"].ToString();
                    dgv_formaPagto.Rows[o].Cells["MOEDA"].Value = conexao.dataReader["MOEDA"].ToString();
                    dgv_formaPagto.Rows[o].Cells["IDBANCOCONTA"].Value = conexao.dataReader["IDCONTA"].ToString();
                    dgv_formaPagto.Rows[o].Cells["BANCOCONTA"].Value = conexao.dataReader["CONTA"].ToString();
                    dgv_formaPagto.Rows[o].Cells["IDCONTAGERENCIAL"].Value = conexao.dataReader["IDCONTAGERENCIAL"].ToString();
                    dgv_formaPagto.Rows[o].Cells["CONTAGERENCIAL"].Value = conexao.dataReader["CONTAGERENCIAL"].ToString();
                    dgv_formaPagto.Rows[o].Cells["HISTORICO"].Value = conexao.dataReader["HISTORICO"].ToString();
                    dgv_formaPagto.Rows[o].Cells["NUMDOC"].Value = conexao.dataReader["NUMDOC"].ToString();
                    dgv_formaPagto.Rows[o].Cells["DTLANC"].Value = conexao.dataReader["DTLANC"].ToString();
                    dgv_formaPagto.Rows[o].Cells["DTVENC"].Value = conexao.dataReader["DTVENC"].ToString();
                    dgv_formaPagto.Rows[o].Cells["DTCOMPETENCIA"].Value = conexao.dataReader["DTCOMPETENCIA"].ToString();
                    dgv_formaPagto.Rows[o].Cells["DTPGTO"].Value = conexao.dataReader["DTPGTO"].ToString();
                    dgv_formaPagto.Rows[o].Cells["VALOR"].Value = Conversor.converterMoeda(conexao.dataReader["VALOR"].ToString());
                    dgv_formaPagto.Rows[o].Cells["VLRDESC"].Value = Conversor.converterMoeda(conexao.dataReader["VLRDESC"].ToString());
                    dgv_formaPagto.Rows[o].Cells["VLRJUROS"].Value = Conversor.converterMoeda(conexao.dataReader["VLRJUROS"].ToString());
                    dgv_formaPagto.Rows[o].Cells["VLRTOTAL"].Value = Conversor.converterMoeda(conexao.dataReader["VLRTOTAL"].ToString());
                    dgv_formaPagto.Rows[o].Cells["VLREXTENSO"].Value = conexao.dataReader["VLREXTENSO"].ToString();



                    o++;
                }
                //decimal total = 0;
                //decimal valor = 0;
                //decimal desconto = 0;
                //decimal juros = 0;
                //for (int i = 0; i < dgv_resultado_pesquisa.RowCount; i++)
                //{
                //    total = total + Convert.ToDecimal(dgv_resultado_pesquisa.Rows[i].Cells["VLRTOTAL"].Value.ToString());
                //    valor = valor + Convert.ToDecimal(dgv_resultado_pesquisa.Rows[i].Cells["VALOR"].Value.ToString());
                //    desconto = desconto + Convert.ToDecimal(dgv_resultado_pesquisa.Rows[i].Cells["VLRDESC"].Value.ToString());
                //    juros = juros + Convert.ToDecimal(dgv_resultado_pesquisa.Rows[i].Cells["VLRJUROS"].Value.ToString());

                //    textBox1.Text = "Total R$: " + Convert.ToString(total);
                //    textBox2.Text = "Valor R$: " + Convert.ToString(valor);
                //    textBox3.Text = "Desconto R$: " + Convert.ToString(desconto);
                //    textBox4.Text = "Juros R$: " + Convert.ToString(juros);
                //}


                conexao.Fecha_Conexao();
            }
            catch (Exception)
            {


            }


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

            for (int i = 0; i < dgv_ItensVenda.Rows.Count; i++)
            {
                qtdeTotal += i;
                pcustoTotal += Convert.ToDecimal(dgv_ItensVenda.Rows[i].Cells["PCUSTO"].Value.ToString());
                ipiTotal += Convert.ToDecimal(dgv_ItensVenda.Rows[i].Cells["IPI"].Value.ToString());
                outroCustoTotal += Convert.ToDecimal(dgv_ItensVenda.Rows[i].Cells["OUTROCUSTO"].Value.ToString());
                descontoTotal += Convert.ToDecimal(dgv_ItensVenda.Rows[i].Cells["DESCONTO"].Value.ToString());
                pliquidTotal += Convert.ToDecimal(dgv_ItensVenda.Rows[i].Cells["TOTALUNT"].Value.ToString());
                totalTotal += Convert.ToDecimal(dgv_ItensVenda.Rows[i].Cells["TOTAL"].Value.ToString());
                dgv_ItensVenda.DefaultCellStyle.ForeColor = Color.Black;
                dgv_ItensVenda.Rows[i].Cells["ITEM"].Value = i + 1;
            }
            tboxQtdeTotal.Text = Convert.ToString(qtdeTotal);
            tboxIPItotal.Text = Convert.ToString(ipiTotal);
            tboxOutrosCustoTotal.Text = Convert.ToString(outroCustoTotal);
            tboxDescontoTotal.Text = Convert.ToString(descontoTotal);
            tboxTotalTotal.Text = Convert.ToString(totalTotal);
            textBox1.Text = Convert.ToString(totalTotal);
        }
        private void cancelarVenda()
        {
            try
            {
                conexao.Abre_Conexao();
                string SQLCunsultaEmpr = " UPDATE TBPEDIDO SET " +
                                                   "  HISTORICO  = @HISTORICO,  " +
                                                   "  STATUS  = @STATUS         " +
                                                   " WHERE ID =  " + dgv_resultado_pesquisa.CurrentRow.Cells["ITEM"].Value.ToString();

                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;
                conexao.cmd.Parameters.AddWithValue("STATUS", "CANCELADA");
                conexao.cmd.Parameters.AddWithValue("HISTORICO", "Venda cancelada");

                conexao.cmd.ExecuteNonQuery();


                conexao.Fecha_Conexao();
                ajustarEstoque();
                cancelarContaPagar();
                MessageBox.Show("Venda Cancelada com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Não foi possível cancelar o pedido, Selecione o pedido e tente novamente", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                pesquisar_Compra();
            }


        }
        private void ajustarEstoque()
        {
            conexao.Abre_Conexao();
            try
            {
                for (int i = 0; i < dgv_ItensVenda.Rows.Count; i++)
                {
                    string SQLCunsultaEmpr = " UPDATE TBPRODUTO SET " +
                                                                "  ESTOQUE  = ESTOQUE - '" + dgv_ItensVenda.Rows[i].Cells["QTDE"].Value.ToString() + "'" +
                                                                " WHERE ID =  " + dgv_ItensVenda.Rows[i].Cells["CODPROD"].Value.ToString();

                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;

                    conexao.cmd.ExecuteNonQuery();

                }

                MessageBox.Show("Estoque Atualizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

            }

            conexao.Fecha_Conexao();
        }
        private void cancelarContaPagar()
        {
            conexao.Abre_Conexao();
            try
            {
                string SQLCunsultaEmpr = " DELETE FROM TBFINANCEIRO  " +
                                              " WHERE IDVENDA =  " + dgv_resultado_pesquisa.CurrentRow.Cells["ITEM"].Value.ToString();

                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;

                conexao.cmd.ExecuteNonQuery();

                MessageBox.Show("Contas a Pagar Atualizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

            }



            conexao.Fecha_Conexao();
        }
        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            pesquisar_Compra();
        }
        private void frmHistoricoCompras_Load(object sender, EventArgs e)
        {
            montaGridPedido();
            montarGridItens();
            montarGridContaPagar();
        }
        private void dgv_resultado_pesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pesquisar_Itens();
            calcularTotalPedido();
            pesquisar_ContaPagar();
        }
        private void dgv_resultado_pesquisa_Click(object sender, EventArgs e)
        {
            pesquisar_Itens();
            calcularTotalPedido();
            pesquisar_ContaPagar();
        }
        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente deseja cancelar a Entrada selecionada.", "Clever Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                cancelarVenda();
                pesquisar_Compra();
            }
        }
    }
}
