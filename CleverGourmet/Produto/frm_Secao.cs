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
    public partial class frm_Secao : Modelo
    {
        Conexao conexao = new Conexao();
        public string codDEPARTAMENTO;
        string SQLCunsultaEmpr;
        public frm_Secao()
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
            SQLCunsultaEmpr = "SELECT " +
                              "C.ID, " +
                              "C.SECAO, " +
                              "C.IDDEPTO, " +
                              "G.DEPARTAMENTO " +
                              "FROM " +
                              "TBSECAO C, " +
                              "TBDEPTO G " +
                              "WHERE C.IDDEPTO = G.ID AND  C.DTEXCLUSAO IS NULL AND C.SECAO " + descricao ;



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
                    string SQLCunsultaEmpr = "INSERT INTO TBSECAO " +
                                                      "(SECAO     " +
                                                      ",IDDEPTO     " +
                                                      ",STATUS)       " +
                                                      "VALUES         " +
                                                      "(@SECAO    " +
                                                      ",@IDDEPTO    " +
                                                      ",@STATUS  )    ";
                                                     

                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.Parameters.AddWithValue("SECAO", tboxcategoria.Text);
                    conexao.cmd.Parameters.AddWithValue("IDDEPTO", codDEPARTAMENTO);
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
                    string SQLCunsultaEmpr = "UPDATE TBSECAO SET " +
                                                      "SECAO    = @SECAO     " +
                                                      ",IDDEPTO    = @IDDEPTO     " +
                                                      " WHERE  ID = " + tboxID.Text;



                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.Parameters.AddWithValue("SECAO", tboxcategoria.Text);
                    conexao.cmd.Parameters.AddWithValue("IDDEPTO", codDEPARTAMENTO);
                   

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
                
                    tboxID.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
                    tboxcategoria.Text = dgv_resultado_pesquisa.CurrentRow.Cells["SECAO"].Value.ToString();
                    tboxDepartamento.Text = dgv_resultado_pesquisa.CurrentRow.Cells["IDDEPTO"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DEPARTAMENTO"].Value.ToString();
                    codDEPARTAMENTO = dgv_resultado_pesquisa.CurrentRow.Cells["IDDEPTO"].Value.ToString();
                    tabControl1.SelectedTab = tabPage1;
              
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
                    string SQLCunsultaEmpr = "UPDATE TBSECAO SET DTEXCLUSAO = '" + DateTime.Now + "' WHERE ID = " + id_registro;



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
            tboxDepartamento.Clear();
            codDEPARTAMENTO = null;

        }
        public override void relatorio1()
        {
            try
            {
                frm_Relatorio a = new frm_Relatorio();
                a.Arquivo_rdlc = "Rpv_Secao.rdlc";
                a.Sql_Relatorio1 = this.SQLCunsultaEmpr;
                a.Dataset_Relatorio1 = "DataSet_Secao";
                a.ShowDialog();
            }
            catch (Exception)
            {


            }
        }
      
        private void btn_PesquisarGrupo_Click_1(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR GRUPO DE CONTAS";
            a.RotinaOrigem = lbl_NomeRotina.Text;
            a.ShowDialog();
        }

        private void frm_Secao_Load(object sender, EventArgs e)
        {
            Iniciar_Form();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tboxDepartamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
