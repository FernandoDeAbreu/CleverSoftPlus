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
    public partial class frm_PDVPagamento : Form
    {
        frm_PDV insta_PDV;
        Conexao conexao = new Conexao();

        public int numgrid;
        public int idvenda;
        public int idFunc;
        public int idCliente;
        public int idMesa;

        public decimal vlrUnit;
        public decimal vlrVenda;

        public decimal vlrPago;
        public decimal vlrTroco;


        public decimal vrlDesconto = 0;

        string sqlCupom;
        public frm_PDVPagamento(frm_PDV PDV)
        {
            InitializeComponent();
            insta_PDV = PDV;
        }
        private void gravaContaReceber()
        {
            #region INSERT

            conexao.Abre_Conexao();

            for (int i = 0; i < dgv_FormaPagto.Rows.Count; i++)
            {
                // Gravar valor Extensso

                dgv_FormaPagto.Rows[i].Cells["VLREXTENSO"].Value = Conversor.EscreverExtenso(Convert.ToDecimal(dgv_FormaPagto.Rows[i].Cells["VLRTOTAL"].Value.ToString()));

                //* fim gravar valor Extensso

                    string SQLCunsultaEmpr = " INSERT INTO TBCR " +
                                                    " (TIPO                   " +
                                                    " ,PREST                " +
                                                    " ,IDVENDA              " +
                                                    " ,IDFILIAL            " +
                                                    " ,IDPARCEIRO             " +
                                                    " ,IDMOEDA                " +
                                                    " ,IDCONTA                " +
                                                    " ,IDCOBRANCA             " +
                                                    " ,IDCONTAGERENCIAL            " +
                                                    " ,HISTORICO              " +
                                                    " ,NUMDOC                 " +
                                                    " ,DTLANC                 " +
                                                    " ,DTVENC                 " +
                                                    " ,DTCOMPETENCIA          " +
                                                    " ,DTPGTO                 " +
                                                    " ,VALOR                  " +
                                                    " ,VLRDESC                " +
                                                    " ,VLRJUROS               " +
                                                    " ,VLRTOTAL               " +
                                                    " ,VLREXTENSO)              " +
                                                    " VALUES                  " +
                                                    " (@TIPO                  " +
                                                    " ,@PREST                " +
                                                    " ,@IDVENDA              " +
                                                    " ,@IDFILIAL              " +
                                                    " ,@IDPARCEIRO            " +
                                                    " ,@IDMOEDA               " +
                                                    " ,@IDCONTA               " +
                                                    " ,@IDCOBRANCA             " +
                                                    " ,@IDCONTAGERENCIAL           " +
                                                    " ,@HISTORICO             " +
                                                    " ,@NUMDOC                " +
                                                    " ,@DTLANC                " +
                                                    " ,@DTVENC                " +
                                                    " ,@DTCOMPETENCIA         " +
                                                    " ,@DTPGTO                " +
                                                    " ,@VALOR                 " +
                                                    " ,@VLRDESC               " +
                                                    " ,@VLRJUROS              " +
                                                    " ,@VLRTOTAL              " +
                                                    " ,@VLREXTENSO)           ";


                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;           
                    conexao.cmd.Parameters.AddWithValue("TIPO",          dgv_FormaPagto.Rows[i].Cells["TIPO"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("PREST",          i+1);
                    conexao.cmd.Parameters.AddWithValue("IDVENDA",       dgv_FormaPagto.Rows[i].Cells["NUMDOC"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("IDFILIAL",      dgv_FormaPagto.Rows[i].Cells["IDFILIAL"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("IDPARCEIRO",    dgv_FormaPagto.Rows[i].Cells["IDPARCEIRO"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("IDMOEDA",       dgv_FormaPagto.Rows[i].Cells["IDMOEDA"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("IDCONTA",       dgv_FormaPagto.Rows[i].Cells["IDCONTA"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("IDCOBRANCA",       dgv_FormaPagto.Rows[i].Cells["IDCOBRANCA"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("IDCONTAGERENCIAL",   dgv_FormaPagto.Rows[i].Cells["IDCONTAGERENCIAL"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("HISTORICO",     dgv_FormaPagto.Rows[i].Cells["HISTORICO"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("NUMDOC",        dgv_FormaPagto.Rows[i].Cells["NUMDOC"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("DTLANC",        dgv_FormaPagto.Rows[i].Cells["DTLANC"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("DTVENC",        dgv_FormaPagto.Rows[i].Cells["DTVENC"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("DTCOMPETENCIA", dgv_FormaPagto.Rows[i].Cells["DTCOMPETENCIA"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("DTPGTO",        dgv_FormaPagto.Rows[i].Cells["DTPGTO"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("VALOR",         dgv_FormaPagto.Rows[i].Cells["VALOR"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("VLRDESC",       dgv_FormaPagto.Rows[i].Cells["VLRDESC"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("VLRJUROS",      dgv_FormaPagto.Rows[i].Cells["VLRJUROS"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("VLRTOTAL",      dgv_FormaPagto.Rows[i].Cells["VLRTOTAL"].Value.ToString());
                    conexao.cmd.Parameters.AddWithValue("VLREXTENSO",    dgv_FormaPagto.Rows[i].Cells["VLREXTENSO"].Value.ToString());


                conexao.cmd.ExecuteNonQuery();

            }
            MessageBox.Show("Venda realizada com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conexao.Fecha_Conexao();
            
            #endregion
        }
        private void gerarCupom()
        {
            sqlCupom = " SELECT                    " +
                     "                           " +
                     "  V.ID                      " +
                     " ,V.DATA                   " +
                     " ,V.HORA                   " +
                     " ,V.VLRORIGINAL            " +
                     " ,V.VLRDESC                " +
                     " ,V.VLRPAGO                " +
                     " ,V.VLRVENDA               " +
                     " ,V.VLRTROCO               " +
                     " ,V.STATUS                 " +
                     "                           " +
                     " ,V.IDFILIAL               " +
                     " ,A.NOME AS NOMEFILIAL     " +
                     " ,A.TIPOPESSOA             " +
                     " ,A.CNPJ_CPF               " +
                     " ,A.IE_RG                  " +
                     " ,A.DTNASC                 " +
                     " ,A.CEP                    " +
                     " ,A.CIDADE                 " +
                     " ,A.UF                     " +
                     " ,A.BAIRRO                 " +
                     " ,A.ENDERECO               " +
                     " ,A.NUM                    " +
                     " ,A.COMPLEMENTO            " +
                     " ,A.CELULAR                " +
                     " ,A.TELEFONE               " +
                     " ,A.WHATSAPP               " +
                     "                           " +
                     " ,V.IDFUNC                 " +
                     " ,E.NOME AS NOMEFUNC       " +
                     " ,E.CPF                    " +
                     " ,E.USUARIO                " +
                     "                           " +
                     " ,V.IDCLIENTE              " +
                     " ,C.NOME        AS C_NOME                  " +
                     " ,C.TIPOPESSOA  AS C_TIPOPESSOA            " +
                     " ,C.CNPJ_CPF    AS C_CNPJ_CPF              " +
                     " ,C.IE_RG       AS C_IE_RG                 " +
                     " ,C.DTNASC      AS C_DTNASC                " +
                     " ,C.CEP         AS C_CEP                   " +
                     " ,C.CIDADE      AS C_CIDADE                " +
                     " ,C.UF          AS C_UF                    " +
                     " ,C.BAIRRO      AS C_BAIRRO                " +
                     " ,C.ENDERECO    AS C_ENDERECO              " +
                     " ,C.NUM         AS C_NUM                   " +
                     " ,C.COMPLEMENTO AS C_COMPLEMENTO           " +
                     " ,C.CELULAR     AS C_CELULAR               " +
                     " ,C.TELEFONE    AS C_TELEFONE              " +
                     " ,C.WHATSAPP    AS C_WHATSAPP              " +
                     " ,C.EMAIL       AS C_EMAIL                 " +
                     " ,C.SITE        AS C_SITE                   " +
                     "                           " +
                     " ,I.IDVENDA                " +
                     " ,I.SEQ                    " +
                     " ,I.CODPROD                " +
                     " ,P.DESCRICAO              " +
                     " ,P.CODAUXILIAR            " +
                     " ,P.MEDIDA                 " +
                     " ,P.PCUSTO                 " +
                     " ,P.ESTOQUE                " +
                     " ,P.PVENDA                 " +
                     " ,P.IMG                    " +
                     " ,I.QTDE                   " +
                     " ,I.PCUSTO   AS PCUSTO_UNIT              " +
                     " ,I.PUNIT                  " +
                     " ,I.PDESC                  " +
                     " ,I.PVENDA   AS PVENDA_UNIT   " +
                     " ,I.PTOTAL                 " +
                     "                           " +
                     "                           " +
                     " FROM                      " +
                     "                           " +
                     " TBVENDA          V        " +
                     " ,TBVENDA_ITENS    I       " +
                     " ,TBPRODUTO        P       " +
                     " ,TBFUNCIONARIO    E       " +
                     " ,TBFILIAL         A       " +
                     " ,TBCLIENTE        C       " +
                     "                           " +
                     " WHERE                     " +
                     "                           " +
                     " I.IDVENDA   = V.ID AND    " +
                     " I.CODPROD   = P.ID AND    " +
                     " V.IDFUNC    = E.ID AND    " +
                     " V.IDFILIAL  = A.ID AND    " +
                     " V.IDCLIENTE = C.ID AND    " +
                     " V.ID = " + idvenda;

            try
            {
                frm_Relatorio a = new frm_Relatorio();
                a.Arquivo_rdlc = "Rpv_cupom_nao_fiscal.rdlc";
                a.Sql_Relatorio1 = this.sqlCupom;
                a.Dataset_Relatorio1 = "DataSet_cupom_nao_fiscal";
                a.ShowDialog();
            }
            catch (Exception)
            {


            }
        }
        private void totalizador()
        {
            decimal totalpago = 0;
            decimal falta_troco = 0;
            lbl_troco.Text = "0,00";
            lbl_Falta.Text = "0,00";

            for (int i = 0; i < dgv_FormaPagto.RowCount; i++)
            {
                totalpago = totalpago + Convert.ToDecimal(dgv_FormaPagto.Rows[i].Cells["VALORPAGO"].Value.ToString());
                lblSomatotalPago.Text = Conversor.converterMoeda(Convert.ToString(totalpago));
            }

            lbl_vlrOriginal.Text = Conversor.converterMoeda(Convert.ToString(Convert.ToDecimal(lbl_Desconto.Text) + Convert.ToDecimal(lbl_Total.Text)));
            falta_troco = Convert.ToDecimal(lbl_Total.Text) - Convert.ToDecimal(lblSomatotalPago.Text);

            if (falta_troco < 0)
            {
                lbl_troco.Text = Convert.ToString(falta_troco * (-1));
            }
            else
            {
                lbl_Falta.Text = Convert.ToString(falta_troco);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tbox_Comandos.Focus();
            tbox_Comandos.Clear();
        }
        private void tbox_Comandos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
               this.Close();
            }
            if (e.KeyCode == Keys.F2)
            {
                if (Convert.ToDecimal(lbl_Falta.Text) > 0)
                {
                    frm_PDVMoeda a = new frm_PDVMoeda(this);
                    a.tboxVAlor.Text = this.lbl_vlrOriginal.Text;
                    a.idvenda = this.idvenda;
                    a.valortotal = Convert.ToDecimal(lbl_Falta.Text);
                    a.ShowDialog();
                    totalizador();
                }
                
            }
            if (e.KeyCode == Keys.Enter)
            {

                if (Convert.ToDecimal(lbl_Falta.Text) <= 0)
                {
                    insta_PDV.vlrdesc  = Convert.ToDecimal(Conversor.converterMoeda(lbl_Desconto.Text));
                    insta_PDV.vlrVenda = Convert.ToDecimal(Conversor.converterMoeda(lbl_Total.Text));
                    insta_PDV.vlrTroco = Convert.ToDecimal(Conversor.converterMoeda(lbl_troco.Text));
                    insta_PDV.vlrPago  = Convert.ToDecimal(Conversor.converterMoeda(lblSomatotalPago.Text));
                    insta_PDV.vlrUnit  = Convert.ToDecimal(lbl_Total.Text) + Convert.ToDecimal(lbl_Desconto.Text);

                    insta_PDV.gravaVenda();
                    insta_PDV.gravarItens();
                    gravaContaReceber();
                    RelatorioVendas a = new RelatorioVendas();
                    a.idVendaCupom = idvenda;
                    a.gerarCupom();
                    a.cupomNfiscal();
                    insta_PDV.limparCampos();
                    this.Close();
                }
             
            }
        }
        private void frm_PDVPagamento_Load(object sender, EventArgs e)
        {
            tbox_Comandos.Focus();
            totalizador();
        }
    }
}
