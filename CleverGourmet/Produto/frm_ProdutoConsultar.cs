using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverSoft
{
    public partial class frm_ProdutoConsultar : ModeloSimples
    {
        Conexao conexao = new Conexao();
        string SQLCunsultaEmpr;
        frm_PDV insPDV;
        frmDigitaPedidoCompras instPedido;
        frmOrdemServico instOrdemServico;
        public frm_ProdutoConsultar(frmOrdemServico ordemServico)
        {
            InitializeComponent();
            instOrdemServico = ordemServico;
        }
        public frm_ProdutoConsultar(frmDigitaPedidoCompras pedido)
        {
            InitializeComponent();
            instPedido = pedido;
        }
        public frm_ProdutoConsultar(frm_PDV pdv)
        {
            InitializeComponent();
            insPDV = pdv;
        }
        public frm_ProdutoConsultar()
        {
            InitializeComponent();
        }
        private void Iniciar_Form()
        {
            #region MONTAR GRID CONSULTA

            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.Name = "ID";
            col_ID.HeaderText = "CÓDIGO";
            col_ID.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_ID);

            DataGridViewTextBoxColumn col_DESCRICAO = new DataGridViewTextBoxColumn();
            col_DESCRICAO.Name = "DESCRICAO";
            col_DESCRICAO.HeaderText = "DESCRIÇÃO";
            col_DESCRICAO.Width = 350;
            dgv_resultado_pesquisa.Columns.Add(col_DESCRICAO);

            DataGridViewTextBoxColumn col_CODAUXILIAR = new DataGridViewTextBoxColumn();
            col_CODAUXILIAR.Name = "CODAUXILIAR";
            col_CODAUXILIAR.HeaderText = "CÓD. AUXILIAR";
            col_CODAUXILIAR.Width = 120;
            dgv_resultado_pesquisa.Columns.Add(col_CODAUXILIAR);

            DataGridViewTextBoxColumn col_MEDIDA = new DataGridViewTextBoxColumn();
            col_MEDIDA.Name = "MEDIDA";
            col_MEDIDA.HeaderText = "MEDIDA";
            col_MEDIDA.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_MEDIDA);

            DataGridViewTextBoxColumn col_PCUSTO = new DataGridViewTextBoxColumn();
            col_PCUSTO.Name = "PCUSTO";
            col_PCUSTO.HeaderText = "PREÇO CUSTO";
            col_PCUSTO.Width = 150;
            col_PCUSTO.Visible = false;
            dgv_resultado_pesquisa.Columns.Add(col_PCUSTO);

            DataGridViewTextBoxColumn col_ESTOQUE = new DataGridViewTextBoxColumn();
            col_ESTOQUE.Name = "ESTOQUE";
            col_ESTOQUE.HeaderText = "ESTOQUE";
            col_ESTOQUE.Width = 100;
            dgv_resultado_pesquisa.Columns.Add(col_ESTOQUE);

            DataGridViewTextBoxColumn col_PVENDA = new DataGridViewTextBoxColumn();
            col_PVENDA.Name = "PVENDA";
            col_PVENDA.HeaderText = "PREÇO VENDA";
            col_PVENDA.Width = 150;
            dgv_resultado_pesquisa.Columns.Add(col_PVENDA);


            #endregion
        }
        private void limparCampos()
        {
            lbl_Codigo.Text = "";
            lbl_Descricao.Text = "";
            lbl_CodBarras.Text = "";
            lbl_Unidade.Text = "";
            lbl_Estoque.Text = "";
            lbl_Preco.Text = "";
            dgv_resultado_pesquisa.Rows.Clear();
        }
        private void preecherLabel()
        {
            try
            {
                lbl_Codigo.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
                lbl_Descricao.Text = dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                lbl_CodBarras.Text = dgv_resultado_pesquisa.CurrentRow.Cells["CODAUXILIAR"].Value.ToString();
                lbl_Unidade.Text = dgv_resultado_pesquisa.CurrentRow.Cells["MEDIDA"].Value.ToString();
                lbl_Estoque.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ESTOQUE"].Value.ToString();
                lbl_Preco.Text = "R$ " + dgv_resultado_pesquisa.CurrentRow.Cells["PVENDA"].Value.ToString();

            }
            catch (Exception)
            {

            }
        }
        private void pesquisar_Descricao()
        {
            limparCampos();
            string descricao = tboxPesquisar.Text;
         


            conexao.Abre_Conexao();
            dgv_resultado_pesquisa.Rows.Clear();
            SQLCunsultaEmpr = "SELECT * FROM TBPRODUTO WHERE DTEXCLUSAO IS NULL AND DESCRICAO LIKE '%" + descricao + "%'";



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
                dgv_resultado_pesquisa.Rows[o].Cells["ID"].Value = conexao.dataReader[0].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["DESCRICAO"].Value = conexao.dataReader[1].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["CODAUXILIAR"].Value = conexao.dataReader[2].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["MEDIDA"].Value = conexao.dataReader[3].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["PCUSTO"].Value = Conversor.converterMoeda(conexao.dataReader[4].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["ESTOQUE"].Value = Conversor.converterMoeda(conexao.dataReader[5].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["PVENDA"].Value = Conversor.converterMoeda(conexao.dataReader[6].ToString());

                
                dgv_resultado_pesquisa.DefaultCellStyle.ForeColor = Color.Black;

                o++;
            }
            preecherLabel();
            if (o == 0)
            {
                MessageBox.Show("Nenhum produto cadastrado com os dados informados","Clever Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            conexao.Fecha_Conexao();

        }
        private void pesquisar_Codbarras()
        {
           // limparCampos();
            string descricao = tboxPesquisar.Text.Trim();

            conexao.Abre_Conexao();
            dgv_resultado_pesquisa.Rows.Clear();
            SQLCunsultaEmpr = "SELECT * FROM TBPRODUTO WHERE DTEXCLUSAO IS NULL AND CODAUXILIAR = '" + descricao + "'";



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
                dgv_resultado_pesquisa.Rows[o].Cells["ID"].Value          = conexao.dataReader[0].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["DESCRICAO"].Value   = conexao.dataReader[1].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["CODAUXILIAR"].Value = conexao.dataReader[2].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["MEDIDA"].Value      = conexao.dataReader[3].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["PCUSTO"].Value      = Conversor.converterMoeda(conexao.dataReader[4].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["ESTOQUE"].Value     = Conversor.converterMoeda(conexao.dataReader[5].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["PVENDA"].Value      = Conversor.converterMoeda(conexao.dataReader[6].ToString());
                dgv_resultado_pesquisa.DefaultCellStyle.ForeColor = Color.Black;


                o++;
            }
            preecherLabel();

            if (o == 0)
            {
                pesquisar_Descricao();
            }


            conexao.Fecha_Conexao();

        }
        private void tboxPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisar_Codbarras();
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.F2)
            {
                tboxPesquisar.Focus();
            }
        }
        private void frm_ProdutoConsultar_Load(object sender, EventArgs e)
        {
            Iniciar_Form();
        }
        private void dgv_resultado_pesquisa_AllowUserToAddRowsChanged(object sender, EventArgs e)
        {
            preecherLabel();
        }
        private void dgv_resultado_pesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            preecherLabel();
        }
        private void dgv_resultado_pesquisa_SelectionChanged(object sender, EventArgs e)
        {
            preecherLabel();
        }
        private void dgv_resultado_pesquisa_Click(object sender, EventArgs e)
        {
            preecherLabel();
        }
        private void dgv_resultado_pesquisa_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            preecherLabel();
        }
        private void dgv_resultado_pesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    insPDV.tboxLocalizarProduto.Text = dgv_resultado_pesquisa.CurrentRow.Cells["CODAUXILIAR"].Value.ToString();
                    this.Close();
                }
                catch (Exception)
                {
                }
                try
                {
                    instPedido.tboxLocalizarProduto.Text = dgv_resultado_pesquisa.CurrentRow.Cells["CODAUXILIAR"].Value.ToString();
                    this.Close();
                }
                catch (Exception)
                {
                }
            }

            if (e.KeyCode == Keys.F2)
            {
                tboxPesquisar.Focus();
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void dgv_resultado_pesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                insPDV.tboxLocalizarProduto.Text = dgv_resultado_pesquisa.CurrentRow.Cells["CODAUXILIAR"].Value.ToString();
                this.Close();
            }
            catch (Exception)
            {
            }

            try
            {
                instPedido.tboxLocalizarProduto.Text = dgv_resultado_pesquisa.CurrentRow.Cells["CODAUXILIAR"].Value.ToString();
                this.Close();
            }
            catch (Exception)
            {
            }

            try
            {
                instOrdemServico.tboxLocalizarProduto.Text = dgv_resultado_pesquisa.CurrentRow.Cells["CODAUXILIAR"].Value.ToString();
                this.Close();
            }
            catch (Exception)
            {
            }
        }
    }
}
