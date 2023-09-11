using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverSoft.Produto
{
    public partial class frmAjustarEstoque : Padrao
    {
        Conexao conexao = new Conexao();
        string SQLCunsultaEmpr;
        public int idFunc;
        public frmAjustarEstoque()
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

            DataGridViewTextBoxColumn col_TIPO = new DataGridViewTextBoxColumn();
            col_TIPO.Name = "TIPO";
            col_TIPO.HeaderText = "TIPO";
            col_TIPO.Width = 100;
            dgv_resultado_pesquisa.Columns.Add(col_TIPO);

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

            DataGridViewTextBoxColumn col_IDDEPTO = new DataGridViewTextBoxColumn();
            col_IDDEPTO.Name = "IDDEPTO";
            col_IDDEPTO.HeaderText = "ID. DEPTO";
            col_IDDEPTO.Visible = false;
            dgv_resultado_pesquisa.Columns.Add(col_IDDEPTO);

            DataGridViewTextBoxColumn col_DEPARTAMENTO = new DataGridViewTextBoxColumn();
            col_DEPARTAMENTO.Name = "DEPARTAMENTO";
            col_DEPARTAMENTO.HeaderText = "DEPARTAMENTO";
            col_DEPARTAMENTO.Width = 170;
            dgv_resultado_pesquisa.Columns.Add(col_DEPARTAMENTO);


            DataGridViewTextBoxColumn col_IDSECAO = new DataGridViewTextBoxColumn();
            col_IDSECAO.Name = "IDSECAO";
            col_IDSECAO.HeaderText = "ID SEÇÃO";
            col_IDSECAO.Visible = false;
            dgv_resultado_pesquisa.Columns.Add(col_IDSECAO);

            DataGridViewTextBoxColumn col_SECAO = new DataGridViewTextBoxColumn();
            col_SECAO.Name = "SECAO";
            col_SECAO.HeaderText = "SEÇÃO";
            col_SECAO.Width = 170;
            dgv_resultado_pesquisa.Columns.Add(col_SECAO);

            DataGridViewTextBoxColumn col_NS = new DataGridViewTextBoxColumn();
            col_NS.Name = "NS";
            col_NS.HeaderText = "N/S";
            col_NS.Width = 170;
            dgv_resultado_pesquisa.Columns.Add(col_NS);

            DataGridViewTextBoxColumn col_OBS = new DataGridViewTextBoxColumn();
            col_OBS.Name = "OBS";
            col_OBS.HeaderText = "OBS";
            col_OBS.Width = 170;
            dgv_resultado_pesquisa.Columns.Add(col_OBS);

            #endregion

            //Relatorio1ToolStripMenuItem.Visible = true;
            //Relatorio1ToolStripMenuItem.Text = "Relatório";

            //Relatorio2ToolStripMenuItem.Visible = true;
            //Relatorio2ToolStripMenuItem.Text = "Tabela de Preço";

            //pboxIMG.ImageLocation = Application.StartupPath + @"\IMG_PRODUTO\semImagem.jpg";
        }
        private void pesquisar_Registro()
        {

            string descricao;
            string codigoAuxiliar;


            if (tboxDescricaoP.Text != "")
            {
                descricao = " LIKE '%" + tboxDescricaoP.Text + "%'";
            }
            else
            {
                descricao = " IS NOT NULL ";
            }

            if (tboxCodigoAuxiliarP.Text != "")
            {
                codigoAuxiliar = " = '" + tboxCodigoAuxiliarP.Text + "'";
            }
            else
            {
                codigoAuxiliar = " IS NOT NULL ";
            }



            conexao.Abre_Conexao();
            dgv_resultado_pesquisa.Rows.Clear();
            SQLCunsultaEmpr =  " SELECT              " +
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
                               " S.IDDEPTO = D.ID  AND P.DTEXCLUSAO IS NULL AND P.DESCRICAO " + descricao + " AND P.CODAUXILIAR " + codigoAuxiliar;


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
                dgv_resultado_pesquisa.Rows[o].Cells["ID"].Value            = conexao.dataReader["ID"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["TIPO"].Value          = conexao.dataReader["TIPO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["DESCRICAO"].Value     = conexao.dataReader["DESCRICAO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["CODAUXILIAR"].Value   = conexao.dataReader["CODAUXILIAR"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["MEDIDA"].Value        = conexao.dataReader["MEDIDA"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["PCUSTO"].Value        = Conversor.converterMoeda(conexao.dataReader["PCUSTO"].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["ESTOQUE"].Value       = Conversor.converterMoeda(conexao.dataReader["ESTOQUE"].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["PVENDA"].Value        = Conversor.converterMoeda(conexao.dataReader["PVENDA"].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["IDDEPTO"].Value       = conexao.dataReader["IDDEPTO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["DEPARTAMENTO"].Value  = conexao.dataReader["DEPARTAMENTO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["IDSECAO"].Value       = conexao.dataReader["IDSECAO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["SECAO"].Value         = conexao.dataReader["SECAO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["NS"].Value            = conexao.dataReader["NS"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["OBS"].Value           = conexao.dataReader["OBS"].ToString();

                dgv_resultado_pesquisa.DefaultCellStyle.ForeColor = Color.Black;



                o++;
            }


            conexao.Fecha_Conexao();

        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar_Registro();
        }
        private void frmAjustarEstoque_Load(object sender, EventArgs e)
        {
            Iniciar_Form();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmAjustarEstoque2 a = new frmAjustarEstoque2();
            a.ShowDialog();
        }
        private void btnTabelaPreco_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Relatorio a = new frm_Relatorio();
                a.Arquivo_rdlc = "Rpv_Produto_Tabela_Preco.rdlc";
                a.Sql_Relatorio1 = this.SQLCunsultaEmpr;
                a.Dataset_Relatorio1 = "DataSet_Produto";
                a.ShowDialog();
            }
            catch (Exception)
            {

            }
        }
        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Relatorio a = new frm_Relatorio();
                a.Arquivo_rdlc = "Rpv_Produto.rdlc";
                a.Sql_Relatorio1 = this.SQLCunsultaEmpr;
                a.Dataset_Relatorio1 = "DataSet_Produto";
                a.ShowDialog();
            }
            catch (Exception)
            {

            }
        }

        private void btnMovimentacao_Click(object sender, EventArgs e)
        {
            CleverSoft.Produto.frmAjusteEstoqueRelatorio a = new frmAjusteEstoqueRelatorio();
            a.ShowDialog();
        
        }
    }
}
