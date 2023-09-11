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
    public partial class frm_ContaGerencial : Modelo
    {
        Conexao conexao = new Conexao();
        public string codGrupoConta;
        string SQLCunsultaEmpr;
        public frm_ContaGerencial()
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
            col_NOME.Name = "CONTAGERENCIAL";
            col_NOME.HeaderText = "CONTA GERENCIAL";
            col_NOME.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_resultado_pesquisa.Columns.Add(col_NOME);

            DataGridViewTextBoxColumn col_IDGRUPO = new DataGridViewTextBoxColumn();
            col_IDGRUPO.Name = "IDGRUPOCONTA";
            col_IDGRUPO.HeaderText = "ID GRUPO";
            col_IDGRUPO.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_resultado_pesquisa.Columns.Add(col_IDGRUPO);

            DataGridViewTextBoxColumn col_GRUPO = new DataGridViewTextBoxColumn();
            col_GRUPO.Name = "GRUPOCONTA";
            col_GRUPO.HeaderText = "GRUPO DE CONTAS";
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
                              "C.CONTAGERENCIAL, " +
                              "C.IDGRUPO, " +
                              "G.GRUPOCONTA " +
                              "FROM " +
                              "TBCONTAGERENCIAL C, " +
                              "TBGRUPOCONTAG G " +
                              "WHERE C.IDGRUPO = G.ID AND C.ID > 50 AND C.DTEXCLUSAO IS NULL AND C.CONTAGERENCIAL " + descricao ;



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
                dgv_resultado_pesquisa.Rows[o].Cells["CONTAGERENCIAL"].Value = conexao.dataReader["CONTAGERENCIAL"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["IDGRUPOCONTA"].Value = conexao.dataReader["IDGRUPO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["GRUPOCONTA"].Value = conexao.dataReader["GRUPOCONTA"].ToString();

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
                    string SQLCunsultaEmpr = "INSERT INTO TBCONTAGERENCIAL " +
                                                      "(CONTAGERENCIAL     " +
                                                      ",IDGRUPO     " +
                                                      ",STATUS)       " +
                                                      "VALUES         " +
                                                      "(@CONTAGERENCIAL    " +
                                                      ",@IDGRUPO    " +
                                                      ",@STATUS  )    ";
                                                     

                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.Parameters.AddWithValue("CONTAGERENCIAL", tboxcategoria.Text);
                    conexao.cmd.Parameters.AddWithValue("IDGRUPO", codGrupoConta);
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
                    string SQLCunsultaEmpr = "UPDATE TBCONTAGERENCIAL SET " +
                                                      "CONTAGERENCIAL    = @CONTAGERENCIAL     " +
                                                      ",IDGRUPO    = @IDGRUPO     " +
                                                      " WHERE  ID = " + tboxID.Text;



                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.Parameters.AddWithValue("CONTAGERENCIAL", tboxcategoria.Text);
                    conexao.cmd.Parameters.AddWithValue("IDGRUPO", codGrupoConta);
                   

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
                    tboxcategoria.Text = dgv_resultado_pesquisa.CurrentRow.Cells["CONTAGERENCIAL"].Value.ToString();
                    tboxGrupoContaGerencial.Text = dgv_resultado_pesquisa.CurrentRow.Cells["IDGRUPOCONTA"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["GRUPOCONTA"].Value.ToString();
                    codGrupoConta = dgv_resultado_pesquisa.CurrentRow.Cells["IDGRUPOCONTA"].Value.ToString();
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
                    string SQLCunsultaEmpr = "UPDATE TBCONTAGERENCIAL SET DTEXCLUSAO = '" + DateTime.Now + "' WHERE ID = " + id_registro;



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
            tboxGrupoContaGerencial.Clear();
            codGrupoConta = null;

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
        private void btn_PesquisarGrupo_Click(object sender, EventArgs e)
        {
            //frm_Pesquisar a = new frm_Pesquisar(this);
            //a.Text = "PESQUISAR GRUPO DE CONTAS";
            //a.RotinaOrigem = lbl_NomeRotina.Text;
            //a.ShowDialog();
        }
    }
}
