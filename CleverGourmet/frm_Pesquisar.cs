using System;
using System.Drawing;
using System.Windows.Forms;

namespace CleverSoft
{
    public partial class frm_Pesquisar : Form
    {
        private Conexao conexao = new Conexao();
        public string RotinaOrigem;
        private frm_ContasReceber frmContasPAgar;
        private frm_ContasPagar instaContapagar;
        private frm_MoedaCobranca instCobranca;
        private frmDigitaPedidoCompras isntPedidoCompra;
        private frm_Secao instSecao;
        private frm_Produto frmProduto;
        private frm_Permissao frmPermissa;
        private frm_ExtratoConta frmExtrato;
        private frmFecharCaixa frmfechaCaixa;
        private frmOrdemServico instOrdemServico;
        private Ordem_de_Serviço.frmMonitorOrdemServico instMonitorOs;

        private Financeiro.frm_Transferir instTransferir;
        private Financeiro.frmFinanceiro instFinanceiro;
        private Financeiro.frmFinanceiroNovo instFinanceiroNovo;

        private Conta_Gerencial.frmContaGerencialNovo instContaGerencialNovo;

        public frm_Pesquisar(Ordem_de_Serviço.frmMonitorOrdemServico monitorOs)
        {
            InitializeComponent();
            instMonitorOs = monitorOs;
            lbl_NomeRotina.Text = instMonitorOs.Text;
        }

        public frm_Pesquisar(frmOrdemServico ordemServico)
        {
            InitializeComponent();
            instOrdemServico = ordemServico;
            lbl_NomeRotina.Text = instOrdemServico.Text;
        }

        public frm_Pesquisar(frmFecharCaixa fechaCaixa)
        {
            InitializeComponent();
            frmfechaCaixa = fechaCaixa;
            lbl_NomeRotina.Text = frmfechaCaixa.Text;
        }

        public frm_Pesquisar(Financeiro.frm_Transferir transferir)
        {
            InitializeComponent();
            instTransferir = transferir;
            lbl_NomeRotina.Text = instTransferir.Text;
        }

        public frm_Pesquisar(Financeiro.frmFinanceiro financeiro)
        {
            InitializeComponent();
            instFinanceiro = financeiro;
            lbl_NomeRotina.Text = instFinanceiro.Text;
        }

        public frm_Pesquisar(Financeiro.frmFinanceiroNovo financeiroNovo)
        {
            InitializeComponent();
            instFinanceiroNovo = financeiroNovo;
            lbl_NomeRotina.Text = instFinanceiroNovo.Text;
        }

        public frm_Pesquisar(frm_ExtratoConta extrato)
        {
            InitializeComponent();
            frmExtrato = extrato;
            lbl_NomeRotina.Text = frmExtrato.Text;
        }

        public frm_Pesquisar(frm_Permissao permissao)
        {
            InitializeComponent();
            frmPermissa = permissao;
            lbl_NomeRotina.Text = frmPermissa.Text;
        }

        public frm_Pesquisar(frm_Produto produto)
        {
            InitializeComponent();
            frmProduto = produto;
            lbl_NomeRotina.Text = frmProduto.Text;
        }

        public frm_Pesquisar(frm_Secao secao)
        {
            InitializeComponent();
            instSecao = secao;
            lbl_NomeRotina.Text = instSecao.Text;
        }

        public frm_Pesquisar(frmDigitaPedidoCompras pedidoCompra)
        {
            InitializeComponent();
            isntPedidoCompra = pedidoCompra;
            lbl_NomeRotina.Text = isntPedidoCompra.Text;
        }

        public frm_Pesquisar(Conta_Gerencial.frmContaGerencialNovo contaGerencialNovo)
        {
            InitializeComponent();
            instContaGerencialNovo = contaGerencialNovo;
            lbl_NomeRotina.Text = instContaGerencialNovo.Text;
        }

        public frm_Pesquisar(frm_ContasReceber contaReceber)
        {
            InitializeComponent();
            frmContasPAgar = contaReceber;
            lbl_NomeRotina.Text = frmContasPAgar.Text;
        }

        public frm_Pesquisar(frm_ContasPagar contapagar)
        {
            InitializeComponent();
            instaContapagar = contapagar;
            lbl_NomeRotina.Text = instaContapagar.Text;
        }

        public frm_Pesquisar(frm_MoedaCobranca cobranca)
        {
            InitializeComponent();
            instCobranca = cobranca;
            lbl_NomeRotina.Text = instCobranca.Text;
        }

        private void pesquisar_Secao()
        {
            #region MONTAR GRID CONSULTA

            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.Name = "ID";
            col_ID.HeaderText = "ID";
            col_ID.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_ID);

            DataGridViewTextBoxColumn col_NOME = new DataGridViewTextBoxColumn();
            col_NOME.Name = "SECAO";
            col_NOME.HeaderText = "SEÇÃO";
            col_NOME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_resultado_pesquisa.Columns.Add(col_NOME);

            DataGridViewTextBoxColumn col_IDDEPTO = new DataGridViewTextBoxColumn();
            col_IDDEPTO.Name = "IDDEPTO";
            col_IDDEPTO.HeaderText = "ID DEPTO";
            col_IDDEPTO.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_resultado_pesquisa.Columns.Add(col_IDDEPTO);

            DataGridViewTextBoxColumn col_GRUPO = new DataGridViewTextBoxColumn();
            col_GRUPO.Name = "DEPARTAMENTO";
            col_GRUPO.HeaderText = "DEPARTAMENTO";
            col_GRUPO.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_resultado_pesquisa.Columns.Add(col_GRUPO);

            #endregion MONTAR GRID CONSULTA

            conexao.Abre_Conexao();
            dgv_resultado_pesquisa.Rows.Clear();
            string SQLCunsultaEmpr = "SELECT " +
                              "C.ID, " +
                              "C.SECAO, " +
                              "C.IDDEPTO, " +
                              "G.DEPARTAMENTO " +
                              "FROM " +
                              "TBSECAO C, " +
                              "TBDEPTO G " +
                              "WHERE C.IDDEPTO = G.ID AND  C.DTEXCLUSAO IS NULL AND C.SECAO LIKE '%" + tboxPesquisar.Text + "%'";

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
                dgv_resultado_pesquisa.Rows[o].Cells["ID"].Value = conexao.dataReader["ID"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["SECAO"].Value = conexao.dataReader["SECAO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["IDDEPTO"].Value = conexao.dataReader["IDDEPTO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["DEPARTAMENTO"].Value = conexao.dataReader["DEPARTAMENTO"].ToString();
                dgv_resultado_pesquisa.DefaultCellStyle.ForeColor = Color.Black;

                o++;
            }

            conexao.Fecha_Conexao();
        }

        private void carregar_Secao()
        {
            try
            {
                frmProduto.tboxSecao.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["SECAO"].Value.ToString();
                frmProduto.tbox_Departamento.Text = dgv_resultado_pesquisa.CurrentRow.Cells["IDDEPTO"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DEPARTAMENTO"].Value.ToString();
                frmProduto.idSecao = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
                frmProduto.idDepto = dgv_resultado_pesquisa.CurrentRow.Cells["IDDEPTO"].Value.ToString();
            }
            catch (Exception)
            { }
        }

        private void pesquisar_Departamento()
        {
            #region MONTAR GRID CONSULTA

            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.Name = "ID";
            col_ID.HeaderText = "ID";
            col_ID.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_ID);

            DataGridViewTextBoxColumn col_DEPARTAMENTO = new DataGridViewTextBoxColumn();
            col_DEPARTAMENTO.Name = "DEPARTAMENTO";
            col_DEPARTAMENTO.HeaderText = "DEPARTAMENTO";
            col_DEPARTAMENTO.Width = 350;
            dgv_resultado_pesquisa.Columns.Add(col_DEPARTAMENTO);

            #endregion MONTAR GRID CONSULTA

            conexao.Abre_Conexao();
            dgv_resultado_pesquisa.Rows.Clear();
            string SQLCunsultaEmpr = "SELECT * FROM TBDEPTO WHERE DTEXCLUSAO IS NULL AND DEPARTAMENTO LIKE '%" + tboxPesquisar.Text + "%'";

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
                dgv_resultado_pesquisa.Rows[o].Cells["ID"].Value = conexao.dataReader["ID"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["DEPARTAMENTO"].Value = conexao.dataReader["DEPARTAMENTO"].ToString();

                o++;
            }

            conexao.Fecha_Conexao();
        }

        private void carregar_Departamento()
        {
            try
            {
                instSecao.tboxDepartamento.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DEPARTAMENTO"].Value.ToString();
                instSecao.codDEPARTAMENTO = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception)
            { }
        }

        private void pesquisar_GrupoContas()
        {
            #region MONTAR GRID CONSULTA

            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.Name = "ID";
            col_ID.HeaderText = "ID";
            col_ID.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_ID);

            DataGridViewTextBoxColumn col_GRUPOCONTA = new DataGridViewTextBoxColumn();
            col_GRUPOCONTA.Name = "GRUPOCONTA";
            col_GRUPOCONTA.HeaderText = "GRUPO DE CONTA";
            col_GRUPOCONTA.Width = 350;
            dgv_resultado_pesquisa.Columns.Add(col_GRUPOCONTA);

            #endregion MONTAR GRID CONSULTA

            conexao.Abre_Conexao();
            dgv_resultado_pesquisa.Rows.Clear();
            string SQLCunsultaEmpr = "SELECT * FROM TBGRUPOCONTAG WHERE DTEXCLUSAO IS NULL AND ID > 10 AND GRUPOCONTA LIKE '%" + tboxPesquisar.Text + "%'";

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
                dgv_resultado_pesquisa.Rows[o].Cells["ID"].Value = conexao.dataReader["ID"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["GRUPOCONTA"].Value = conexao.dataReader["GRUPOCONTA"].ToString();

                o++;
            }

            conexao.Fecha_Conexao();
        }

        private void carregar_GrupoContas()
        {
            instContaGerencialNovo.tboxGrupoContaGerencial.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["GRUPOCONTA"].Value.ToString();
            instContaGerencialNovo.codGrupoConta = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
        }

        private void pesquisar_Fornecedor()
        {
            #region MONTAR GRID CONSULTA

            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.Name = "ID";
            col_ID.HeaderText = "MATRICULA";
            col_ID.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_ID);

            DataGridViewTextBoxColumn col_NOME = new DataGridViewTextBoxColumn();
            col_NOME.Name = "NOME";
            col_NOME.HeaderText = "NOME COMPLETO";
            col_NOME.Width = 350;
            dgv_resultado_pesquisa.Columns.Add(col_NOME);

            DataGridViewTextBoxColumn col_CPF = new DataGridViewTextBoxColumn();
            col_CPF.Name = "CNPJ_CPF";
            col_CPF.HeaderText = "CNPJ / CPF";
            col_CPF.Width = 160;
            dgv_resultado_pesquisa.Columns.Add(col_CPF);

            #endregion MONTAR GRID CONSULTA

            conexao.Abre_Conexao();
            dgv_resultado_pesquisa.Rows.Clear();
            string SQLCunsultaEmpr = "SELECT * FROM TBFORNECEDOR WHERE DTEXCLUSAO IS NULL AND RAZAOSOCIAL LIKE '%" + tboxPesquisar.Text + "%'";

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
                dgv_resultado_pesquisa.Rows[o].Cells["ID"].Value = conexao.dataReader["ID"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["NOME"].Value = conexao.dataReader["RAZAOSOCIAL"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["CNPJ_CPF"].Value = conexao.dataReader["CNPJ_CPF"].ToString();

                o++;
            }

            conexao.Fecha_Conexao();
        }

        private void carregar_Fornecedor()
        {
            try
            {
                frmContasPAgar.tboxParceiro.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["NOME"].Value.ToString();
                frmContasPAgar.codParceiro = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();

                frmContasPAgar.tboxParceiroP.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["NOME"].Value.ToString();
                frmContasPAgar.codParceirop = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception)
            { }

            try
            {
                isntPedidoCompra.codFornec = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
                isntPedidoCompra.tboxParceiro.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["NOME"].Value.ToString();
            }
            catch (Exception)
            { }

            try
            {
                instFinanceiro.codParceiro = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
                instFinanceiro.tboxParceiro.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["NOME"].Value.ToString();
            }
            catch (Exception)
            { }

            try
            {
                instFinanceiroNovo.codParceiro = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
                instFinanceiroNovo.tboxParceiro.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["NOME"].Value.ToString();
            }
            catch (Exception)
            { }

            try
            {
                instOrdemServico.codFornec = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
                instOrdemServico.tboxFornecedor.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["NOME"].Value.ToString();
            }
            catch (Exception)
            { }
        }

        private void pesquisar_Funcionario()
        {
            #region MONTAR GRID CONSULTA

            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.Name = "ID";
            col_ID.HeaderText = "MATRICULA";
            col_ID.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_ID);

            DataGridViewTextBoxColumn col_NOME = new DataGridViewTextBoxColumn();
            col_NOME.Name = "NOME";
            col_NOME.HeaderText = "NOME COMPLETO";
            col_NOME.Width = 350;
            dgv_resultado_pesquisa.Columns.Add(col_NOME);

            DataGridViewTextBoxColumn col_CPF = new DataGridViewTextBoxColumn();
            col_CPF.Name = "CNPJ_CPF";
            col_CPF.HeaderText = "CNPJ / CPF";
            col_CPF.Width = 160;
            dgv_resultado_pesquisa.Columns.Add(col_CPF);

            #endregion MONTAR GRID CONSULTA

            conexao.Abre_Conexao();
            dgv_resultado_pesquisa.Rows.Clear();
            string SQLCunsultaEmpr = "SELECT * FROM TBFUNCIONARIO WHERE DTEXCLUSAO IS NULL AND NOME LIKE '%" + tboxPesquisar.Text + "%'";

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
                dgv_resultado_pesquisa.Rows[o].Cells["ID"].Value = conexao.dataReader["ID"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["NOME"].Value = conexao.dataReader["NOME"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["CNPJ_CPF"].Value = conexao.dataReader["CPF"].ToString();

                o++;
            }

            conexao.Fecha_Conexao();
        }

        private void Carregar_Funcionario()
        {
            if (frmPermissa != null)
            {
                frmPermissa.tboxParceiro.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["NOME"].Value.ToString();
                frmPermissa.codParceiro = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }

            if (frmfechaCaixa != null)
            {
                frmfechaCaixa.tboxParceiro.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["NOME"].Value.ToString();
                frmfechaCaixa.codParceiro = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
        }

        private void pesquisar_Cliente()
        {
            #region MONTAR GRID CONSULTA

            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.Name = "ID";
            col_ID.HeaderText = "MATRICULA";
            col_ID.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_ID);

            DataGridViewTextBoxColumn col_NOME = new DataGridViewTextBoxColumn();
            col_NOME.Name = "NOME";
            col_NOME.HeaderText = "NOME COMPLETO";
            col_NOME.Width = 350;
            dgv_resultado_pesquisa.Columns.Add(col_NOME);

            DataGridViewTextBoxColumn col_CPF = new DataGridViewTextBoxColumn();
            col_CPF.Name = "CNPJ_CPF";
            col_CPF.HeaderText = "CNPJ / CPF";
            col_CPF.Width = 160;
            dgv_resultado_pesquisa.Columns.Add(col_CPF);

            #endregion MONTAR GRID CONSULTA

            conexao.Abre_Conexao();
            dgv_resultado_pesquisa.Rows.Clear();
            string SQLCunsultaEmpr = "SELECT * FROM TBCLIENTE WHERE DTEXCLUSAO IS NULL AND RAZAOSOCIAL LIKE '%" + tboxPesquisar.Text + "%'";

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
                dgv_resultado_pesquisa.Rows[o].Cells["ID"].Value = conexao.dataReader["ID"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["NOME"].Value = conexao.dataReader["RAZAOSOCIAL"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["CNPJ_CPF"].Value = conexao.dataReader["CNPJ_CPF"].ToString();

                o++;
            }

            conexao.Fecha_Conexao();
        }

        private void carregar_Cliente()
        {
            try
            {
                instFinanceiro.tboxParceiro.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["NOME"].Value.ToString();
                instFinanceiro.codParceiro = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception)
            { }

            try
            {
                instFinanceiroNovo.tboxParceiro.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["NOME"].Value.ToString();
                instFinanceiroNovo.codParceiro = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception)
            { }

            try
            {
                instaContapagar.tboxParceiro.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["NOME"].Value.ToString();
                instaContapagar.codParceiro = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();

                instaContapagar.tboxParceiroP.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["NOME"].Value.ToString();
                instaContapagar.codParceirop = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception)
            { }

            try
            {
                instOrdemServico.tboxParceiro.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["NOME"].Value.ToString();
                instOrdemServico.codParceiro = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception)
            { }

            try
            {
                instMonitorOs.tboxParceiro.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["NOME"].Value.ToString();
                instMonitorOs.codParceiro = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception)
            { }
        }

        private void pesquisar_BancoConta()
        {
            #region MONTAR GRID CONSULTA

            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.Name = "ID";
            col_ID.HeaderText = "MATRICULA";
            col_ID.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_ID);

            DataGridViewTextBoxColumn col_NOME = new DataGridViewTextBoxColumn();
            col_NOME.Name = "DESCRICAO";
            col_NOME.HeaderText = "DESCRICAO";
            col_NOME.Width = 350;
            dgv_resultado_pesquisa.Columns.Add(col_NOME);

            DataGridViewTextBoxColumn col_CPF = new DataGridViewTextBoxColumn();
            col_CPF.Name = "CONTA";
            col_CPF.HeaderText = "CONTA";
            col_CPF.Width = 160;
            dgv_resultado_pesquisa.Columns.Add(col_CPF);

            #endregion MONTAR GRID CONSULTA

            conexao.Abre_Conexao();
            dgv_resultado_pesquisa.Rows.Clear();
            string SQLCunsultaEmpr = "SELECT * FROM TBCONTA WHERE DTEXCLUSAO IS NULL AND CONTA LIKE '%" + tboxPesquisar.Text + "%'";

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
                dgv_resultado_pesquisa.Rows[o].Cells["ID"].Value = conexao.dataReader["ID"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["DESCRICAO"].Value = conexao.dataReader["DESCRICAO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["CONTA"].Value = conexao.dataReader["CONTA"].ToString();

                o++;
            }

            conexao.Fecha_Conexao();
        }

        private void carregar_BancoConta()

        {
            try
            {
                if (instTransferir.origemDestino == "Origem")
                {
                    instTransferir.tboxBancoConta.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                    instTransferir.codBancoConta = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
                }
                else if (instTransferir.origemDestino == "Destino")
                {
                    instTransferir.tboxBancoConta1.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                    instTransferir.codBancoConta1 = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
                }
            }
            catch (Exception) { }

            try
            {
                instOrdemServico.tboxBancoConta.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                instOrdemServico.codBancoConta = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception) { }

            try
            {
                instaContapagar.tboxBancoConta.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                instaContapagar.codBancoConta = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception) { }

            try
            {
                instaContapagar.tboxBancoContaP.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                instaContapagar.codBancoContaP = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception) { }

            try
            {
                frmContasPAgar.tboxBancoConta.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                frmContasPAgar.codBancoConta = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception) { }

            try
            {
                instFinanceiro.tboxBancoConta.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                instFinanceiro.codBancoConta = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception) { }

            try
            {
                instFinanceiroNovo.tboxBancoConta.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                instFinanceiroNovo.codBancoConta = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception) { }

            try
            {
                frmContasPAgar.tboxBancoContaP.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                frmContasPAgar.codBancoContaP = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception) { }

            try
            {
                instCobranca.tboxBancoConta.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                instCobranca.codBancoConta = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception) { }

            try
            {
                frmExtrato.tboxBancoConta.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                frmExtrato.codBancoConta = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception) { }
        }

        private void pesquisar_Moeda()
        {
            #region MONTAR GRID CONSULTA

            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.Name = "ID";
            col_ID.HeaderText = "MATRICULA";
            col_ID.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_ID);

            DataGridViewTextBoxColumn col_NOME = new DataGridViewTextBoxColumn();
            col_NOME.Name = "DESCRICAO";
            col_NOME.HeaderText = "DESCRICAO";
            col_NOME.Width = 350;
            dgv_resultado_pesquisa.Columns.Add(col_NOME);

            #endregion MONTAR GRID CONSULTA

            conexao.Abre_Conexao();
            dgv_resultado_pesquisa.Rows.Clear();
            string SQLCunsultaEmpr = "SELECT * FROM TBMOEDA WHERE DTEXCLUSAO IS NULL AND MOEDA LIKE '%" + tboxPesquisar.Text + "%'";

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
                dgv_resultado_pesquisa.Rows[o].Cells["ID"].Value = conexao.dataReader["ID"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["DESCRICAO"].Value = conexao.dataReader["MOEDA"].ToString();

                o++;
            }

            conexao.Fecha_Conexao();
        }

        private void carregar_Moeda()
        {
            try
            {
                if (instTransferir.origemDestino == "Origem")
                {
                    instTransferir.tboxMoeda.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                    instTransferir.codMoeda = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
                }
                else if (instTransferir.origemDestino == "Destino")
                {
                    instTransferir.tboxMoeda1.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                    instTransferir.codMoeda1 = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
                }
            }
            catch (Exception) { }

            try
            {
                instOrdemServico.tboxMoeda.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                instOrdemServico.codMoeda = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception) { }

            try
            {
                instaContapagar.tboxMoeda.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                instaContapagar.codMoeda = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception) { }

            try
            {
                instFinanceiro.tboxMoeda.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                instFinanceiro.codMoeda = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception) { }

            try
            {
                instFinanceiroNovo.tboxMoeda.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                instFinanceiroNovo.codMoeda = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception) { }

            try
            {
                instaContapagar.tboxMoedaP.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                instaContapagar.codMoedaP = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception) { }

            try
            {
                frmContasPAgar.tboxMoeda.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                frmContasPAgar.codMoeda = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception) { }

            try
            {
                frmContasPAgar.tboxMoedaP.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                frmContasPAgar.codMoedaP = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception) { }

            try
            {
                instCobranca.tboxMoeda.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                instCobranca.codMoeda = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception) { }
        }

        private void pesquisar_ContaGerencial()
        {
            #region MONTAR GRID CONSULTA

            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.Name = "ID";
            col_ID.HeaderText = "MATRICULA";
            col_ID.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_ID);

            DataGridViewTextBoxColumn col_NOME = new DataGridViewTextBoxColumn();
            col_NOME.Name = "DESCRICAO";
            col_NOME.HeaderText = "DESCRICAO";
            col_NOME.Width = 350;
            dgv_resultado_pesquisa.Columns.Add(col_NOME);

            #endregion MONTAR GRID CONSULTA

            conexao.Abre_Conexao();
            dgv_resultado_pesquisa.Rows.Clear();
            string SQLCunsultaEmpr = "SELECT * FROM TBCONTAGERENCIAL WHERE DTEXCLUSAO IS NULL AND  ID > 50 AND CONTAGERENCIAL LIKE '%" + tboxPesquisar.Text + "%'";

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
                dgv_resultado_pesquisa.Rows[o].Cells["ID"].Value = conexao.dataReader["ID"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["DESCRICAO"].Value = conexao.dataReader["CONTAGERENCIAL"].ToString();

                o++;
            }

            conexao.Fecha_Conexao();
        }

        private void carregar_ContaGerencial()
        {
            try
            {
                instaContapagar.tboxCategoria.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                instaContapagar.codCategoria = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();

                instaContapagar.tboxCategoriaP.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                instaContapagar.codCategoriaP = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception)
            { }
            try
            {
                instFinanceiro.tboxCategoria.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                instFinanceiro.codCategoria = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception)
            { }

            try
            {
                instFinanceiroNovo.tboxCategoria.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                instFinanceiroNovo.codCategoria = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception)
            { }

            try
            {
                frmContasPAgar.tboxCategoria.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                frmContasPAgar.codCategoria = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();

                frmContasPAgar.tboxCategoriaP.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                frmContasPAgar.codCategoriaP = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception)
            { }

            try
            {
                instOrdemServico.tboxContaGerencial.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                instOrdemServico.codContaGerencial = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
            }
            catch (Exception)
            { }
        }

        private void pesquisar()
        {
            if (this.RotinaOrigem == "PESQUISAR CLIENTE")
            {
                pesquisar_Cliente();
            }

            if (this.RotinaOrigem == "PESQUISAR FORNECEDOR")
            {
                pesquisar_Fornecedor();
            }

            if (this.RotinaOrigem == "PESQUISAR CONTA GERENCIAL")
            {
                pesquisar_ContaGerencial();
            }

            if (this.RotinaOrigem == "PESQUISAR BANCO")
            {
                pesquisar_BancoConta();
            }

            if (this.RotinaOrigem == "PESQUISAR MOEDA")
            {
                pesquisar_Moeda();
            }

            if (this.RotinaOrigem == "FECHAR CAIXA")
            {
                pesquisar_Funcionario();
            }

            if (this.RotinaOrigem == "CADASTRAR PERMISSÃO")
            {
                pesquisar_Funcionario();
            }

            if (this.RotinaOrigem == "TRANSFERIR NUMERAIS - MOEDA")
            {
                pesquisar_Moeda();
            }
            if (this.RotinaOrigem == "TRANSFERIR NUMERAIS")
            {
                pesquisar_BancoConta();
            }
            if (this.RotinaOrigem == "EXTRATO CONTA")
            {
                pesquisar_BancoConta();
            }

            if (this.RotinaOrigem == "CADASTRO DE PRODUTOS")
            {
                pesquisar_Secao();
            }

            if (this.RotinaOrigem == "CADASTRAR SEÇÃO")
            {
                pesquisar_Departamento();
            }

            if (this.RotinaOrigem == "Entrada de mercadoria")
            {
                pesquisar_Fornecedor();
            }

            if (this.RotinaOrigem == "CADASTRO DE CONTA GERENCIAL")
            {
                pesquisar_GrupoContas();
            }

            if (this.RotinaOrigem == "CONTAS A PAGAR")
            {
                if (this.Text == "PESQUISAR FORNECEDOR")
                {
                    pesquisar_Fornecedor();
                }
                if (this.Text == "PESQUISAR BANCO / CONTA")
                {
                    pesquisar_BancoConta();
                }
                if (this.Text == "PESQUISAR MOEDA")
                {
                    pesquisar_Moeda();
                }
                if (this.Text == "PESQUISAR CONTA GERENCIAL")
                {
                    pesquisar_ContaGerencial();
                }
            }

            if (this.RotinaOrigem == "CONTAS A RECEBER")
            {
                if (this.Text == "PESQUISAR CLIENTE")
                {
                    pesquisar_Cliente();
                }
                if (this.Text == "PESQUISAR BANCO / CONTA")
                {
                    pesquisar_BancoConta();
                }
                if (this.Text == "PESQUISAR MOEDA")
                {
                    pesquisar_Moeda();
                }
                if (this.Text == "PESQUISAR CONTA GERENCIAL")
                {
                    pesquisar_ContaGerencial();
                }
            }

            if (this.RotinaOrigem == "CADASTRAR COBRANÇA")
            {
                if (this.Text == "PESQUISAR BANCO / CONTA")
                {
                    pesquisar_BancoConta();
                }
                if (this.Text == "PESQUISAR MOEDA")
                {
                    pesquisar_Moeda();
                }
            }
        }

        private void frm_Pesquisar_Load(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            pesquisar();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (this.RotinaOrigem == "PESQUISAR CLIENTE")
            {
                carregar_Cliente();
            }

            if (this.RotinaOrigem == "PESQUISAR FORNECEDOR")
            {
                carregar_Fornecedor();
            }

            if (this.RotinaOrigem == "PESQUISAR CONTA GERENCIAL")
            {
                carregar_ContaGerencial();
            }
            if (this.RotinaOrigem == "PESQUISAR MOEDA")
            {
                carregar_Moeda();
            }
            if (this.RotinaOrigem == "PESQUISAR BANCO")
            {
                carregar_BancoConta();
            }

            if (this.RotinaOrigem == "FECHAR CAIXA")
            {
                Carregar_Funcionario();
            }

            if (this.RotinaOrigem == "TRANSFERIR NUMERAIS - MOEDA")
            {
                carregar_Moeda();
            }
            if (this.RotinaOrigem == "TRANSFERIR NUMERAIS")
            {
                carregar_BancoConta();
            }
            if (this.RotinaOrigem == "EXTRATO CONTA")
            {
                carregar_BancoConta();
            }

            if (this.RotinaOrigem == "CADASTRAR PERMISSÃO")
            {
                Carregar_Funcionario();
            }

            if (this.RotinaOrigem == "CADASTRO DE PRODUTOS")
            {
                carregar_Secao();
            }
            if (this.RotinaOrigem == "CADASTRAR SEÇÃO")
            {
                carregar_Departamento();
            }

            if (this.RotinaOrigem == "Entrada de mercadoria")
            {
                carregar_Fornecedor();
            }

            if (this.RotinaOrigem == "CADASTRO DE CONTA GERENCIAL")
            {
                carregar_GrupoContas();
            }
            if (this.RotinaOrigem == "CONTAS A PAGAR")
            {
                if (this.Text == "PESQUISAR FORNECEDOR")
                {
                    carregar_Cliente();
                }
                if (this.Text == "PESQUISAR BANCO / CONTA")
                {
                    carregar_BancoConta();
                }
                if (this.Text == "PESQUISAR MOEDA")
                {
                    carregar_Moeda();
                }
                if (this.Text == "PESQUISAR CONTA GERENCIAL")
                {
                    carregar_ContaGerencial();
                }
            }

            if (this.RotinaOrigem == "CONTAS A RECEBER")
            {
                if (this.Text == "PESQUISAR CLIENTE")
                {
                    carregar_Fornecedor();
                }
                if (this.Text == "PESQUISAR BANCO / CONTA")
                {
                    carregar_BancoConta();
                }
                if (this.Text == "PESQUISAR MOEDA")
                {
                    carregar_Moeda();
                }
                if (this.Text == "PESQUISAR CONTA GERENCIAL")
                {
                    carregar_ContaGerencial();
                }
            }

            if (this.RotinaOrigem == "CADASTRAR COBRANÇA")
            {
                if (this.Text == "PESQUISAR BANCO / CONTA")
                {
                    carregar_BancoConta();
                }
                if (this.Text == "PESQUISAR MOEDA")
                {
                    carregar_Moeda();
                }
            }

            this.Close();
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdcionar_Click(object sender, EventArgs e)
        {
            instSecao.ShowDialog();
        }
    }
}