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
    public partial class frm_ContaGerencialGrupo : Modelo
    {
        Conexao conexao = new Conexao();
        string SQLCunsultaEmpr;
        public frm_ContaGerencialGrupo()
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
            col_NOME.Name = "GRUPOCONTA";
            col_NOME.HeaderText = "CONTA GERENCIAL";
            col_NOME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_resultado_pesquisa.Columns.Add(col_NOME);



            #endregion

            Relatorio1ToolStripMenuItem.Text = "Relatório";
            Relatorio1ToolStripMenuItem.Visible = true;
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
            SQLCunsultaEmpr = "SELECT * FROM TBGRUPOCONTAG WHERE DTEXCLUSAO IS NULL AND ID > 10 AND GRUPOCONTA " + descricao ;



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
                dgv_resultado_pesquisa.Rows[o].Cells["GRUPOCONTA"].Value = conexao.dataReader[1].ToString();

                o++;
            }


            conexao.Fecha_Conexao();

        }

        public override void gravar_Registro()
        {

            if (tboxcategoria.Text == "")
            {
                MessageBox.Show("Campo Nome é obrigatorio.", "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tboxcategoria.Focus();
                return;
            }
        


            try
            {
                if (tboxID.Text == "")
                {
                    #region INSERT
                    conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = "INSERT INTO TBGRUPOCONTAG " +
                                                      "(GRUPOCONTA     " +
                                                      ",STATUS)       " +
                                                      "VALUES         " +
                                                      "(@GRUPOCONTA    " +
                                                      ",@STATUS  )    ";
                                                     

                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.Parameters.AddWithValue("GRUPOCONTA", tboxcategoria.Text);
                    conexao.cmd.Parameters.AddWithValue("STATUS",    "ATIVO");
                  

                    conexao.cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro realizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conexao.Fecha_Conexao();
                    #endregion
                }
                else
                {
                    #region UPDATE
                    conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = "UPDATE TBGRUPOCONTAG SET " +
                                                      "GRUPOCONTA    = @GRUPOCONTA     " +
                                                      " WHERE  ID = " + tboxID.Text;



                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.Parameters.AddWithValue("GRUPOCONTA", tboxcategoria.Text);
                   

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
                    MessageBox.Show("Não é possivel editar o registro selecionado", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tboxID.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
                    tboxcategoria.Text = dgv_resultado_pesquisa.CurrentRow.Cells["GRUPOCONTA"].Value.ToString();
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
                    string SQLCunsultaEmpr = "UPDATE TBGRUPOCONTAG SET DTEXCLUSAO = '" + DateTime.Now + "' WHERE ID = " + id_registro;



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
            tboxcategoria.Clear();          

        }

        public override void relatorio1()
        {
            try
            {
                frm_Relatorio a = new frm_Relatorio();
                a.Arquivo_rdlc = "Rpv_ContaGerancial.rdlc";
                a.Sql_Relatorio1 = this.SQLCunsultaEmpr;
                a.Dataset_Relatorio1 = "DataSet_ContaGerencial";
                a.ShowDialog();
            }
            catch (Exception)
            {


            }
        }

        private void frm_Categoria_Load(object sender, EventArgs e)
        {
            Iniciar_Form();
        }
    }
}
