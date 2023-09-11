using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverSoft.Ordem_de_Serviço
{
    public partial class frmPendencia : Padrao
    {
        Conexao conexao = new Conexao();
        public int idFunc;
        public string nomeFunc;
        public string codParceiro;
        public frmPendencia()
        {
            InitializeComponent();
        }

        private void pesquisarOrdemServico()
        {
            conexao.Abre_Conexao();
            dgv_resultado_pesquisa.Rows.Clear();

            string numOs;
            string numPed;
            string cliente;
            string concluidas;

            if (tboxNumDoc.Text == "")
            {
                numPed = " not null ";
            }
            else
            {
                numPed = " = " + tboxNumDoc.Text;
            }

            if (tboxNumOS.Text == "")
            {
                numOs = " not null ";
            }
            else
            {
                numOs = " = " + tboxNumOS.Text;
            }

            if (codParceiro == null)
            {
                cliente = " not null ";
            }
            else
            {
                cliente = " = '" + codParceiro + "'";
            }

            if (checkBox1.Checked == true)
            {
                concluidas = " P.DTCONCLUSAO not null AND ";

            }
            else
            {
                concluidas = "";

            }


            string SQLCunsultaEmpr =

                           " SELECT               " +
                           " P.IDOS,              " +
                           " O.NUMDOC,            " +
                           " P.IDPENDENCIA,       " +
                           " P.DTLANC,            " +
                           " P.DESCRICAO,         " +
                           " O.IDCLIENTE,         " +
                           " C.RAZAOSOCIAL,       " +
                           " C.ENDERECO,          " +
                           " P.DTCONCLUSAO        " +
                           " FROM                 " +
                           " TBOS_PENDENCIA P,    " +
                           " TBOS O,              " +
                           " TBCLIENTE C          " +
                           " WHERE                " +
                           " P.IDOS = O.IDOS AND  " +
                           " O.IDCLIENTE = C.ID AND" 
                               + concluidas  +
                                " O.IDOS   " + numOs + "  AND " +
                                " O.NUMDOC   " + numPed + "  AND " +
                                " O.IDCLIENTE  " + cliente + " AND  " +
                                " P.DTLANC  BETWEEN '" + Convert.ToDateTime(tboxDtini.Text).ToString("yyyy-MM-dd") +
                                           "'  AND  '" + Convert.ToDateTime(tboxDtfim.Text).ToString("yyyy-MM-dd") + "' ORDER BY P.DTLANC DESC ";

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
                dgv_resultado_pesquisa.Rows[o].Cells["IDOS"].Value         = conexao.dataReader["IDOS"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["NUMDOC"].Value       = conexao.dataReader["NUMDOC"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["IDPENDENCIA"].Value  = conexao.dataReader["IDPENDENCIA"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["DESCRICAO"].Value    = conexao.dataReader["DESCRICAO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["DTLANC"].Value       = Convert.ToDateTime(conexao.dataReader["DTLANC"].ToString()).ToShortDateString();
               // dgv_resultado_pesquisa.Rows[o].Cells["IDCLIENTE"].Value    = conexao.dataReader["IDCLIENTE"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["RAZAOSOCIAL"].Value  = conexao.dataReader["RAZAOSOCIAL"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["ENDERECO"].Value     = conexao.dataReader["ENDERECO"].ToString();
                try
                {
                    dgv_resultado_pesquisa.Rows[o].Cells["DTCONCLUSAO"].Value = Convert.ToDateTime(conexao.dataReader["DTCONCLUSAO"].ToString()).ToShortDateString();
                }
                catch (Exception)
                {
                }
                o++;

            }
            if (o == 0)
            {
                MessageBox.Show("Nenhum produto cadastrado com os dados informados", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            conexao.Fecha_Conexao();

        }
        private void frmPendencia_Load(object sender, EventArgs e)
        {
            pesquisarOrdemServico();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisarOrdemServico();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Abre_Conexao();
                string SQLCunsultaEmpr = " DELETE FROM TBOS_PENDENCIA WHERE IDOS = @IDOS ";
                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;
                conexao.cmd.Parameters.AddWithValue("IDOS", dgv_resultado_pesquisa.CurrentRow.Cells["IDOS"].Value.ToString());

                conexao.cmd.ExecuteNonQuery();

                conexao.Fecha_Conexao();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmLancaPendencia a = new frmLancaPendencia();
            a.tboxNumPedido.Text = dgv_resultado_pesquisa.CurrentRow.Cells["IDOS"].Value.ToString();
            a.tboxNumDoc.Text = dgv_resultado_pesquisa.CurrentRow.Cells["NUMDOC"].Value.ToString();
            a.textBox1.Text = dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
            a.incluirEditar = "Editar";
            a.ShowDialog(); 

        }
    }
}
