using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverSoft.Conta_Gerencial
{
    public partial class frmContaGerencial : Padrao
    {
        Conexao conexao = new Conexao();
        public string codGrupoConta;
        string SQLCunsultaEmpr;
        public frmContaGerencial()
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
            col_ID.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_IDGRUPO);

            DataGridViewTextBoxColumn col_GRUPO = new DataGridViewTextBoxColumn();
            col_GRUPO.Name = "GRUPOCONTA";
            col_GRUPO.HeaderText = "GRUPO DE CONTAS";
            col_GRUPO.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_resultado_pesquisa.Columns.Add(col_GRUPO);


            #endregion

        }
        private void pesquisar_Registro()
        {

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
        private void editar_Registro()
        {
            try
            {

                //tboxID.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
                //tboxcategoria.Text = dgv_resultado_pesquisa.CurrentRow.Cells["CONTAGERENCIAL"].Value.ToString();
                //tboxGrupoContaGerencial.Text = dgv_resultado_pesquisa.CurrentRow.Cells["IDGRUPOCONTA"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["GRUPOCONTA"].Value.ToString();
                //codGrupoConta = dgv_resultado_pesquisa.CurrentRow.Cells["IDGRUPOCONTA"].Value.ToString();
                //tabControl1.SelectedTab = tabPage1;

            }
            catch (Exception)
            {


            }

        }
        private void btn_Imprimir_Click(object sender, EventArgs e)
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
        private void frmContaGerencial_Load(object sender, EventArgs e)
        {
            Iniciar_Form();
            pesquisar_Registro();
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            pesquisar_Registro();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Realmente deseje excluir o item selecionado?", "Clever Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    
                    int id_registro = Convert.ToInt32(dgv_resultado_pesquisa.CurrentRow.Cells[0].Value.ToString());
                    
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmContaGerencialNovo a = new frmContaGerencialNovo();
            a.ShowDialog();
                
        }
    }
}
