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
    public partial class frm_PDVMoeda : Form
    {
        Conexao conexao = new Conexao();
       
        int idMoeda;
        int idCobranca;
        int idConta;
        int qtdDias = 0;
        public int numgrid;
        public int idvenda;
        public int idFunc;
        public int idCliente;
        public int idMesa;
        public decimal qtdParcela;
        public decimal valortotal;
        string valorPago;

        frm_PDVPagamento instPagamento;
        public frm_PDVMoeda(frm_PDVPagamento pagamento)
        {
            InitializeComponent();
            instPagamento = pagamento;
        }
        private void pesquisar_Registro()
        {

            conexao.Abre_Conexao();

            string SQLCunsultaEmpr = "SELECT * FROM TBCOBRANCA WHERE DTEXCLUSAO IS NULL ";



            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;


            DataTable dtResultado = new DataTable();
            dtResultado.Clear();//o ponto mais importante (limpa a table antes de preenche-la)
            cbox_moeda.DataSource = null;
            conexao.adapter.Fill(dtResultado);
            cbox_moeda.DataSource = dtResultado;
            cbox_moeda.ValueMember = "ID";
            cbox_moeda.DisplayMember = "DESCRICAO";
            cbox_moeda.SelectedItem = "";
            cbox_moeda.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.

            conexao.Fecha_Conexao();
            countLinhas();
        }
        private void countLinhas()
        {
            conexao.Abre_Conexao();

            string SQLCunsultaEmpr = "SELECT ID, DESCRICAO, IDCONTA, IDMOEDA FROM TBCOBRANCA WHERE DTEXCLUSAO IS NULL AND DESCRICAO = '" + cbox_moeda.Text + "'";



            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();

            int o = 0;


            while (conexao.dataReader.Read())
            {
                idCobranca = Convert.ToInt32(conexao.dataReader["ID"].ToString());
                idMoeda = Convert.ToInt32(conexao.dataReader["IDMOEDA"].ToString());
                idConta = Convert.ToInt32(conexao.dataReader["IDCONTA"].ToString());
                o++;
            }

            if (idCobranca == 1)
            {
                tbox_qtdeParcelas.Enabled = false;
                tboxAutorizacao.Enabled = false;
                tboxDtVenc.Enabled = false;
                tboxNumDoc.Enabled = false;
                tboxVAlor.ReadOnly = false;

                tboxAutorizacao.Clear();
                tboxDtVenc.Text = DateTime.Now.ToShortDateString();
                tbox_qtdeParcelas.Text = "1";
                tboxNumDoc.Clear();
                
            }
            else
            {
                tbox_qtdeParcelas.Enabled = true;
                tboxAutorizacao.Enabled = true;
                tboxDtVenc.Enabled = true;
                tboxNumDoc.Enabled = true;
                tboxVAlor.ReadOnly = true;
                tboxVAlor.ReadOnly = true;
            }
            totalizador();

            conexao.Fecha_Conexao();

        }
        void totalizador()
        {
            valorPago = tboxVAlor.Text;
            tbox_qtdeParcelas.Text = double.Parse(tbox_qtdeParcelas.Text).ToString();
            tboxVAlor.Text = Convert.ToString(valortotal / Convert.ToDecimal(tbox_qtdeParcelas.Text));
            tboxVAlor.Text = Conversor.converterMoeda(tboxVAlor.Text);
        }
        void finalizarPagamento()
        {
            try
            {
                tboxVAlor.Text = Conversor.converterMoeda(tboxVAlor.Text);

                for (int i = 0; i < Convert.ToInt32(tbox_qtdeParcelas.Text); i++)
                {
                    if (Convert.ToDecimal(tboxVAlor.Text) > 0)
                    {
                        instPagamento.dgv_FormaPagto.Rows.Add();
                        int l = instPagamento.dgv_FormaPagto.Rows.Count - 1;
                        instPagamento.dgv_FormaPagto.Rows[l].Cells["TIPO"].Value       = "C";
                        instPagamento.dgv_FormaPagto.Rows[l].Cells["IDFILIAL"].Value   = "1";
                        instPagamento.dgv_FormaPagto.Rows[l].Cells["IDPARCEIRO"].Value = instPagamento.idCliente;
                        instPagamento.dgv_FormaPagto.Rows[l].Cells["IDMOEDA"].Value    = idMoeda;
                        instPagamento.dgv_FormaPagto.Rows[l].Cells["MOEDA"].Value      = cbox_moeda.Text;
                        instPagamento.dgv_FormaPagto.Rows[l].Cells["IDCONTA"].Value = idConta;
                        instPagamento.dgv_FormaPagto.Rows[l].Cells["IDCONTAGERENCIAL"].Value = 1;
                        instPagamento.dgv_FormaPagto.Rows[l].Cells["NUMDOC"].Value = instPagamento.idvenda;
                        instPagamento.dgv_FormaPagto.Rows[l].Cells["DTLANC"].Value = DateTime.Now.ToShortDateString();
                        instPagamento.dgv_FormaPagto.Rows[l].Cells["DTCOMPETENCIA"].Value = tboxDtVenc.Text;
                        instPagamento.dgv_FormaPagto.Rows[l].Cells["VALORPAGO"].Value = valorPago;
                        instPagamento.dgv_FormaPagto.Rows[l].Cells["VALOR"].Value = valortotal;
                        instPagamento.dgv_FormaPagto.Rows[l].Cells["IDCOBRANCA"].Value = idCobranca;


                        if (idCobranca == 1)
                        {
                            instPagamento.dgv_FormaPagto.Rows[l].Cells["HISTORICO"].Value = "REF.: A VENDA Nº " + instPagamento.idvenda + ".";
                            instPagamento.dgv_FormaPagto.Rows[l].Cells["DTVENC"].Value = DateTime.Now.ToShortDateString();
                            instPagamento.dgv_FormaPagto.Rows[l].Cells["DTPGTO"].Value = DateTime.Now.ToShortDateString();

                            if (Convert.ToDecimal(tboxVAlor.Text) >= valortotal)
                            {
                                instPagamento.dgv_FormaPagto.Rows[l].Cells["VALOR"].Value = valortotal;
                                instPagamento.dgv_FormaPagto.Rows[l].Cells["VLRDESC"].Value = "0,00";
                                instPagamento.dgv_FormaPagto.Rows[l].Cells["VLRJUROS"].Value = "0,00";
                                instPagamento.dgv_FormaPagto.Rows[l].Cells["VLRTOTAL"].Value = valortotal;
                            }
                            else
                            {
                                instPagamento.dgv_FormaPagto.Rows[l].Cells["VALOR"].Value = tboxVAlor.Text;
                                instPagamento.dgv_FormaPagto.Rows[l].Cells["VLRDESC"].Value = "0,00";
                                instPagamento.dgv_FormaPagto.Rows[l].Cells["VLRJUROS"].Value = "0,00";
                                instPagamento.dgv_FormaPagto.Rows[l].Cells["VLRTOTAL"].Value = valortotal;
                            }


                        }
                        else
                        {
                            qtdDias = qtdDias + 30;

                            instPagamento.dgv_FormaPagto.Rows[l].Cells["HISTORICO"].Value = "REF.: A VENDA Nº " + instPagamento.idvenda + ". Parc.: 1/" + i + 1;
                            instPagamento.dgv_FormaPagto.Rows[l].Cells["DTVENC"].Value = DateTime.Now.AddDays(qtdDias);
                            instPagamento.dgv_FormaPagto.Rows[l].Cells["DTPGTO"].Value = "";
                            instPagamento.dgv_FormaPagto.Rows[l].Cells["VALOR"].Value = valortotal;
                            instPagamento.dgv_FormaPagto.Rows[l].Cells["VLRDESC"].Value = "0,00";
                            instPagamento.dgv_FormaPagto.Rows[l].Cells["VLRJUROS"].Value = "0,00";
                            instPagamento.dgv_FormaPagto.Rows[l].Cells["VLRTOTAL"].Value = valortotal;
                        }

                    }
                }
                this.Close();

            }
            catch (Exception)
            {
                throw;
            }

        }
        private void frm_PDVMoeda_Load(object sender, EventArgs e)
        {
            pesquisar_Registro();
            cbox_moeda.Focus();
        }
        private void tbox_Moeda_KeyDown(object sender, KeyEventArgs e)
        {

        }
        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                finalizarPagamento();
            }
        }
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void comboBox1_KeyUp(object sender, KeyEventArgs e)
        {
            countLinhas();

        }
        private void tboxDtVenc_Leave(object sender, EventArgs e)
        {
            try
            {
                tboxDtVenc.Text = Convert.ToDateTime(tboxDtVenc.Text).ToShortDateString();
            }
            catch (Exception)
            {
                MessageBox.Show("Data invalida.", "Clever Sistema",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                tboxDtVenc.Text = DateTime.Now.ToShortDateString();
                tboxDtVenc.Focus();

            }
        }
        private void tbox_qtdeParcelas_Leave(object sender, EventArgs e)
        {
            
            try
            {
                tbox_qtdeParcelas.Text = Conversor.converterMoeda(tbox_qtdeParcelas.Text);
                totalizador();
            }
            catch (Exception)
            {

                MessageBox.Show("Valor invalido informado", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbox_qtdeParcelas.Text = "1";
                tbox_qtdeParcelas.Focus();
                totalizador();

            }
        }
        private void tboxVAlor_Leave(object sender, EventArgs e)
        {
            try
            {
                tboxVAlor.Text = Conversor.converterMoeda(tboxVAlor.Text);
                totalizador();

            }
            catch (Exception)
            {

                MessageBox.Show("Valor invalido informado", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tboxVAlor.Text = "0,00";
                tboxVAlor.Focus();
                totalizador();

            }
        }
        private void tboxVAlor_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                totalizador();

                finalizarPagamento();
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
