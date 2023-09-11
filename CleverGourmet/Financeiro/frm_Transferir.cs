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
    public partial class frm_Transferir : ModeloSimples
    {
        Conexao conexao = new Conexao();

        public string codBancoConta;
        public string codBancoConta1;
        public string origemDestino;
        public string codMoeda;
        public string codMoeda1;


        public frm_Transferir()
        {
            InitializeComponent();
        }

        private void gravarCR()
        {
            string valor_Extenso = Conversor.EscreverExtenso(Convert.ToDecimal(tbox_Valor.Text));

            conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = " INSERT INTO TBCR " +
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
                                                    " ,DTPGTO                 " +
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
                                                    " ,@DTPGTO                 " +
                                                    " ,@DTCOMPETENCIA         " +
                                                    " ,@VALOR                 " +
                                                    " ,@VLRDESC               " +
                                                    " ,@VLRJUROS              " +
                                                    " ,@VLRTOTAL              " +
                                                    " ,@VLREXTENSO)             ";
            

                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;           
                    conexao.cmd.Parameters.AddWithValue("TIPO",          "C");
                    conexao.cmd.Parameters.AddWithValue("IDFILIAL",      "1");
                    conexao.cmd.Parameters.AddWithValue("IDPARCEIRO",    "2");
                    conexao.cmd.Parameters.AddWithValue("IDMOEDA",       codMoeda1);
                    conexao.cmd.Parameters.AddWithValue("IDCONTA",       codBancoConta1);
                    conexao.cmd.Parameters.AddWithValue("IDCONTAGERENCIAL",  "2");
                    conexao.cmd.Parameters.AddWithValue("HISTORICO",     "TRANSFERÊNCIA DA CONTA (" + tboxBancoConta.Text + ") PARA (" + tboxBancoConta1.Text + ")");
                    conexao.cmd.Parameters.AddWithValue("NUMDOC",        tbox_NumDoc.Text);
                    conexao.cmd.Parameters.AddWithValue("DTLANC",        tbox_Data.Text);
                    conexao.cmd.Parameters.AddWithValue("DTVENC",        tbox_Data.Text);
                    conexao.cmd.Parameters.AddWithValue("DTPGTO",        tbox_Data.Text);
                    conexao.cmd.Parameters.AddWithValue("DTCOMPETENCIA", tbox_Data.Text);
                    conexao.cmd.Parameters.AddWithValue("VALOR",         Conversor.converterMoeda(tbox_Valor.Text));
                    conexao.cmd.Parameters.AddWithValue("VLRDESC",       Conversor.converterMoeda("0,00"));
                    conexao.cmd.Parameters.AddWithValue("VLRJUROS",      Conversor.converterMoeda("0,00"));
                    conexao.cmd.Parameters.AddWithValue("VLRTOTAL",      Conversor.converterMoeda(tbox_Valor.Text));
                    conexao.cmd.Parameters.AddWithValue("VLREXTENSO",    valor_Extenso);


                    conexao.cmd.ExecuteNonQuery();


                    conexao.Fecha_Conexao();
          
        }

        private void gravarCP()
        {
            string valor_Extenso = Conversor.EscreverExtenso(Convert.ToDecimal(tbox_Valor.Text));

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
                                                    " ,DTPGTO                 " +
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
                                                    " ,@DTPGTO                 " +
                                                    " ,@DTCOMPETENCIA         " +
                                                    " ,@VALOR                 " +
                                                    " ,@VLRDESC               " +
                                                    " ,@VLRJUROS              " +
                                                    " ,@VLRTOTAL              " +
                                                    " ,@VLREXTENSO)             ";
            

                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;           
                    conexao.cmd.Parameters.AddWithValue("TIPO",          "D");
                    conexao.cmd.Parameters.AddWithValue("IDFILIAL",      "1");
                    conexao.cmd.Parameters.AddWithValue("IDPARCEIRO",    "2");
                    conexao.cmd.Parameters.AddWithValue("IDMOEDA",       codMoeda);
                    conexao.cmd.Parameters.AddWithValue("IDCONTA",       codBancoConta);
                    conexao.cmd.Parameters.AddWithValue("IDCONTAGERENCIAL",  "2");
                    conexao.cmd.Parameters.AddWithValue("HISTORICO",     "TRANSFERÊNCIA DA CONTA (" + tboxBancoConta.Text + ") PARA (" + tboxBancoConta1.Text + ")");
                    conexao.cmd.Parameters.AddWithValue("NUMDOC",        tbox_NumDoc.Text);
                    conexao.cmd.Parameters.AddWithValue("DTLANC",        tbox_Data.Text);
                    conexao.cmd.Parameters.AddWithValue("DTVENC",        tbox_Data.Text);
                    conexao.cmd.Parameters.AddWithValue("DTPGTO",        tbox_Data.Text);
                    conexao.cmd.Parameters.AddWithValue("DTCOMPETENCIA", tbox_Data.Text);
                    conexao.cmd.Parameters.AddWithValue("VALOR",         Conversor.converterMoeda(tbox_Valor.Text));
                    conexao.cmd.Parameters.AddWithValue("VLRDESC",       Conversor.converterMoeda("0,00"));
                    conexao.cmd.Parameters.AddWithValue("VLRJUROS",      Conversor.converterMoeda("0,00"));
                    conexao.cmd.Parameters.AddWithValue("VLRTOTAL",      Conversor.converterMoeda(tbox_Valor.Text));
                    conexao.cmd.Parameters.AddWithValue("VLREXTENSO",    valor_Extenso);


                    conexao.cmd.ExecuteNonQuery();
            conexao.Fecha_Conexao();

            gravarCR();
            limparCampor();
            MessageBox.Show("Transferência realizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void limparCampor()
        {
            codBancoConta = null;
            codBancoConta1 = null;
            origemDestino = null;
            codMoeda = null;
            codMoeda1 = null;

            tboxBancoConta.Clear();
            tboxMoeda.Clear();
            tboxBancoConta1.Clear();
            tboxMoeda1.Clear();
            tboxBancoConta.Clear();
            tboxBancoConta.Clear();
            tbox_Data.Text = DateTime.Now.ToShortDateString();
            tbox_Valor.Text = "0,00";
            tbox_NumDoc.Clear();
            tbox_NumIndent.Clear();

        }
        private void btn_PesquisarBanco_Click(object sender, EventArgs e)
        {
            origemDestino = "Origem";
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR BANCO / CONTA";
            a.RotinaOrigem = lbl_NomeRotina.Text;
            a.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            origemDestino = "Destino";
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR BANCO / CONTA";
            a.RotinaOrigem = lbl_NomeRotina.Text;
            a.ShowDialog();
        }

        private void btn_PesquisarMoeda_Click(object sender, EventArgs e)
        {
            origemDestino = "Origem";
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR MOEDA";
            a.RotinaOrigem = lbl_NomeRotina.Text + " - MOEDA";
            a.ShowDialog();
        }

        private void btn_PesquisarMoeda1_Click(object sender, EventArgs e)
        {
            origemDestino = "Destino";
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR MOEDA";
            a.RotinaOrigem = lbl_NomeRotina.Text + " - MOEDA";
            a.ShowDialog();
        }

        private void tbox_Valor_Leave(object sender, EventArgs e)
        {
            try
            {
                tbox_Valor.Text = Conversor.converterMoeda(tbox_Valor.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Valor informado invalido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                tbox_Valor.Text = "0,00";
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (tboxBancoConta.Text == "")
            {
                MessageBox.Show("Informe o banco de Origem", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tboxBancoConta1.Text == "")
            {
                MessageBox.Show("Informe o banco de Destino", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tboxMoeda.Text == "")
            {
                MessageBox.Show("Informe o Moeda de origem", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tboxMoeda1.Text == "")
            {
                MessageBox.Show("Informe o Moeda de Destino", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbox_NumDoc.Text == "")
            {
                MessageBox.Show("Informe o Número do documento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tbox_Valor.Text == "0,00")
            {
                MessageBox.Show("Informe o valor da transferência.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            gravarCP();
            
        }
    }
}
