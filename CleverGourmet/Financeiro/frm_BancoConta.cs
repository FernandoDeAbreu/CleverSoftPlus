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
    public partial class frm_BancoConta : Modelo
    {
        Conexao conexao = new Conexao();
        string SQLCunsultaEmpr;

        public frm_BancoConta()
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

            DataGridViewTextBoxColumn col_AGENCIA = new DataGridViewTextBoxColumn();
            col_AGENCIA.Name = "AGENCIA";
            col_AGENCIA.HeaderText = "AGÊNCIA";
            col_AGENCIA.Width = 120;
            dgv_resultado_pesquisa.Columns.Add(col_AGENCIA);

            DataGridViewTextBoxColumn col_CONTA = new DataGridViewTextBoxColumn();
            col_CONTA.Name = "CONTA";
            col_CONTA.HeaderText = "CONTA";
            col_CONTA.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_resultado_pesquisa.Columns.Add(col_CONTA);



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
            SQLCunsultaEmpr = "SELECT * FROM TBCONTA WHERE DTEXCLUSAO IS NULL AND DESCRICAO " + descricao;



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
                dgv_resultado_pesquisa.Rows[o].Cells["AGENCIA"].Value = conexao.dataReader[3].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["CONTA"].Value = conexao.dataReader[4].ToString();

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



            try
            {
                if (tboxID.Text == "")
                {
                    #region INSERT
                    conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = "INSERT INTO TBCONTA " +
                                                      "(DESCRICAO    " +
                                                      ",CODBANCO     " +
                                                      ",AGENCIA      " +
                                                      ",CONTA)       " +
                                                      "VALUES        " +
                                                      "(@DESCRICAO   " +
                                                      ",@CODBANCO    " +
                                                      ",@AGENCIA     " +
                                                      ",@CONTA  )    ";


                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.Parameters.AddWithValue("DESCRICAO", tboxDescricao.Text);
                    conexao.cmd.Parameters.AddWithValue("CODBANCO", tboxCodBanco.Text);
                    conexao.cmd.Parameters.AddWithValue("AGENCIA", tboxAgencia.Text);
                    conexao.cmd.Parameters.AddWithValue("CONTA", tboxConta.Text);


                    conexao.cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro realizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conexao.Fecha_Conexao();
                    #endregion
                }
                else
                {
                    #region UPDATE
                    conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = "UPDATE TBCONTA SET " +
                                                      "DESCRICAO   = @DESCRICAO " +
                                                      ",CODBANCO    = @CODBANCO  " +
                                                      ",AGENCIA     = @AGENCIA   " +
                                                      ",CONTA       = @CONTA     " +
                                                      " WHERE  ID = " + tboxID.Text;



                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.Parameters.AddWithValue("DESCRICAO", tboxDescricao.Text);
                    conexao.cmd.Parameters.AddWithValue("CODBANCO", tboxCodBanco.Text);
                    conexao.cmd.Parameters.AddWithValue("AGENCIA", tboxAgencia.Text);
                    conexao.cmd.Parameters.AddWithValue("CONTA", tboxConta.Text);


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
                if (dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString() == "TESOURARIA")
                {
                    MessageBox.Show("Não é possível editar esse registro.", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tboxID.Text        = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
                    tboxDescricao.Text = dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                    tboxCodBanco.Text  = dgv_resultado_pesquisa.CurrentRow.Cells["CODBANCO"].Value.ToString();
                    tboxAgencia.Text   = dgv_resultado_pesquisa.CurrentRow.Cells["AGENCIA"].Value.ToString();
                    tboxConta.Text     = dgv_resultado_pesquisa.CurrentRow.Cells["CONTA"].Value.ToString();
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
                    string SQLCunsultaEmpr = "UPDATE TBCONTA SET DTEXCLUSAO = '" + DateTime.Now + "' WHERE ID = " + id_registro;



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
            tboxCodBanco.Clear();
            tboxConta.Clear();
            tboxAgencia.Clear();

        }
        public override void relatorio1()
        {
            try
            {
                frm_Relatorio a = new frm_Relatorio();
                a.Arquivo_rdlc = "Rpv_BancoConta_Lista.rdlc";
                a.Sql_Relatorio1 = this.SQLCunsultaEmpr;
                a.Dataset_Relatorio1 = "DataSet_BancoConta";
                a.ShowDialog();
            }
            catch (Exception)
            {


            }
        }
        private void frm_BancoConta_Load(object sender, EventArgs e)
        {
            Iniciar_Form();
        }
    }
}
