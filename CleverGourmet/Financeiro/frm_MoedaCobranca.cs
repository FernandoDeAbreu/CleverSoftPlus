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
    public partial class frm_MoedaCobranca : Modelo
    {
        Conexao conexao = new Conexao();
        string SQLCunsultaEmpr;
        public string codBancoConta;
        public string codMoeda;

        public frm_MoedaCobranca()
        {
            InitializeComponent();
        }

        private void Iniciar_Form()
        {
            #region MONTAR GRID CONSULTA

            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.Name = "ID";
            col_ID.HeaderText = "ID";
            col_ID.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_ID);

            DataGridViewTextBoxColumn col_NOME = new DataGridViewTextBoxColumn();
            col_NOME.Name = "DESCRICAO";
            col_NOME.HeaderText = "DESCRICAO";
            col_NOME.Width = 250;
            dgv_resultado_pesquisa.Columns.Add(col_NOME);

            DataGridViewTextBoxColumn col_CODBANCO = new DataGridViewTextBoxColumn();
            col_CODBANCO.Name = "CODBANCO";
            col_CODBANCO.HeaderText = "CÓD. BANCO";
            col_CODBANCO.Width = 120;
            dgv_resultado_pesquisa.Columns.Add(col_CODBANCO);

            DataGridViewTextBoxColumn col_BANCO = new DataGridViewTextBoxColumn();
            col_BANCO.Name = "BANCO";
            col_BANCO.HeaderText = "BANCO";
            col_BANCO.Width = 120;
            dgv_resultado_pesquisa.Columns.Add(col_BANCO);

            DataGridViewTextBoxColumn col_CODMOEDA = new DataGridViewTextBoxColumn();
            col_CODMOEDA.Name = "CODMOEDA";
            col_CODMOEDA.HeaderText = "CÓD. MOEDA";
            col_CODMOEDA.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_resultado_pesquisa.Columns.Add(col_CODMOEDA);

            DataGridViewTextBoxColumn col_MOEDA = new DataGridViewTextBoxColumn();
            col_MOEDA.Name = "MOEDA";
            col_MOEDA.HeaderText = "MOEDA";
            col_MOEDA.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_resultado_pesquisa.Columns.Add(col_MOEDA);



            #endregion

            Relatorio1ToolStripMenuItem.Visible = true;
            Relatorio1ToolStripMenuItem.Text = "Relatório";
        }

        public override void pesquisar_Registro()
        {
            tabControl1.SelectedTab = tabPage2;

            string descricao;



            if (tboxcategoriaP.Text != "")
            {
                descricao = " LIKE '%" + tboxcategoriaP.Text + "%'";
            }
            else
            {
                descricao = " IS NOT NULL ";
            }



            conexao.Abre_Conexao();
            dgv_resultado_pesquisa.Rows.Clear();
            SQLCunsultaEmpr = " SELECT                 " +
                              " B.ID,                  " +
                              " B.DESCRICAO,           " +
                              " B.IDCONTA,             " +
                              " C.DESCRICAO AS CONTA, " +
                              " B.IDMOEDA,             " +
                              " M.MOEDA   " +
                              " FROM                   " +
                              " TBCOBRANCA B,   " +
                              " TBCONTA    C,   " +
                              " TBMOEDA    M    " +
                              " WHERE                  " +
                              " B.IDCONTA = C.ID AND   " +
                              " B.IDMOEDA = M.ID  AND B.DTEXCLUSAO IS NULL AND B.DESCRICAO " + descricao;


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
                dgv_resultado_pesquisa.Rows[o].Cells["CODBANCO"].Value = conexao.dataReader[2].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["BANCO"].Value = conexao.dataReader[3].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["CODMOEDA"].Value = conexao.dataReader[4].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["MOEDA"].Value = conexao.dataReader[5].ToString();

                o++;
            }


            conexao.Fecha_Conexao();

        }

        public override void gravar_Registro()
        {

            if (tboxDescricao.Text == "")
            {
                MessageBox.Show("Campo Nome é obrigatorio.", "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tboxDescricao.Focus();
                return;
            }

            if (tboxBancoConta.Text == "")
            {
                MessageBox.Show("Campo Banco / Conta é obrigatorio.", "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (tboxMoeda.Text == "")
            {
                MessageBox.Show("Campo Moeda é obrigatorio.", "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                if (tboxID.Text == "")
                {
                    #region INSERT
                    conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = "INSERT INTO TBCOBRANCA " +
                                                      "(DESCRICAO    " +
                                                      ",IDCONTA     " +
                                                      ",IDMOEDA)    " +
                                                      "VALUES        " +
                                                      "(@DESCRICAO   " +
                                                      ",@IDCONTA    " +
                                                      ",@IDMOEDA  )    ";


                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.Parameters.AddWithValue("DESCRICAO", tboxDescricao.Text);
                    conexao.cmd.Parameters.AddWithValue("IDCONTA", codBancoConta);
                    conexao.cmd.Parameters.AddWithValue("IDMOEDA", codMoeda);


                    conexao.cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro realizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conexao.Fecha_Conexao();
                    #endregion
                }
                else
                {
                    #region UPDATE
                    conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = "UPDATE TBCOBRANCA SET " +
                                                      "DESCRICAO   = @DESCRICAO " +
                                                      ",IDCONTA    = @IDCONTA  " +
                                                      ",IDMOEDA     = @IDMOEDA   " +
                                                      " WHERE  ID = " + tboxID.Text;



                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.Parameters.AddWithValue("DESCRICAO", tboxDescricao.Text);
                    conexao.cmd.Parameters.AddWithValue("IDCONTA", codBancoConta);
                    conexao.cmd.Parameters.AddWithValue("IDMOEDA", codMoeda);


                    conexao.cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro Atualizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conexao.Fecha_Conexao();
                    #endregion
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }




        }

        public override void editar_Registro()
        {
            try
            {
                if (dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString() == "1")
                {
                    MessageBox.Show("Não é possível editar esse registro.", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tboxID.Text         = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
                    tboxDescricao.Text  = dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                    codBancoConta        = dgv_resultado_pesquisa.CurrentRow.Cells["CODBANCO"].Value.ToString();
                    tboxBancoConta.Text = dgv_resultado_pesquisa.CurrentRow.Cells["CODBANCO"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["BANCO"].Value.ToString();
                    codMoeda             = dgv_resultado_pesquisa.CurrentRow.Cells["CODMOEDA"].Value.ToString();
                    tboxMoeda.Text      = dgv_resultado_pesquisa.CurrentRow.Cells["CODMOEDA"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["MOEDA"].Value.ToString();

                    tabControl1.SelectedTab = tabPage1;
                }
                
            }
            catch (Exception)
            {


            }

        }

        public override void excluir_Registro()
        {
            try
            {
                if (MessageBox.Show("Realmente deseje excluir o item selecionado?", "Clever Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    if (tabControl1.SelectedTab == tabPage1)
                    {
                        id_registro = Convert.ToInt32(tboxID.Text);
                    }
                    else
                    {
                        id_registro = Convert.ToInt32(dgv_resultado_pesquisa.CurrentRow.Cells[0].Value.ToString());
                    }
                    conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = "UPDATE TBCOBRANCA SET DTEXCLUSAO = '" + DateTime.Now + "' WHERE ID = " + id_registro;



                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro excluido com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conexao.Fecha_Conexao();
                    pesquisar_Registro();

                }
            }
            catch (Exception)
            {


            }
        }

        public override void limpar_Campos()
        {
            tboxID.Clear();
            tboxDescricao.Clear();
            tboxBancoConta.Clear();
            tboxMoeda.Clear();

        }

        public override void relatorio1()
        {
            try
            {
                frm_Relatorio a = new frm_Relatorio();
                a.Arquivo_rdlc = "Rpv_MoedaCobranca.rdlc";
                a.Sql_Relatorio1 = this.SQLCunsultaEmpr;
                a.Dataset_Relatorio1 = "DataSet_MoedaCobranca";
                a.ShowDialog();
            }
            catch (Exception)
            {


            }
        }

        private void btn_PesquisarBanco_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR BANCO / CONTA";
            a.RotinaOrigem = lbl_NomeRotina.Text;
            a.ShowDialog();
        }

        private void btn_PesquisarMoeda_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR MOEDA";
            a.RotinaOrigem = lbl_NomeRotina.Text;
            a.ShowDialog();
        }

        private void frm_MoedaCobranca_Load(object sender, EventArgs e)
        {
            Iniciar_Form();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tboxBancoConta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
