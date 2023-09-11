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
    public partial class frm_Funcionario : Modelo
    {
        Conexao conexao = new Conexao();
        public frm_Funcionario()
        {
            InitializeComponent();
        }
        private void Iniciar_Form()
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
            col_CPF.Name = "CPF";
            col_CPF.HeaderText = "CPF";
            col_CPF.Width = 120;
            dgv_resultado_pesquisa.Columns.Add(col_CPF);

            DataGridViewTextBoxColumn col_USUARIO= new DataGridViewTextBoxColumn();
            col_USUARIO.Name = "USUARIO";
            col_USUARIO.HeaderText = "USUÁRIO";
            col_USUARIO.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_resultado_pesquisa.Columns.Add(col_USUARIO);

            DataGridViewTextBoxColumn col_SENHA = new DataGridViewTextBoxColumn();
            col_SENHA.Name = "SENHA";
            col_SENHA.HeaderText = "SENHA";
            col_SENHA.Width = 150;
            col_SENHA.Visible = false;
            dgv_resultado_pesquisa.Columns.Add(col_SENHA);


            #endregion
            panel3.Visible = false;
        }
        public override void pesquisar_Registro()
        {
            tabControl1.SelectedTab = tabPage2;

            string nome;
            string cpf;


            if (tboxNomeP.Text != "")
            {
                nome = " LIKE '%" + tboxNomeP.Text + "%'";
            }
            else
            {
                nome = " IS NOT NULL ";
            }

            if (tboxCPFP.Text != "")
            {
                cpf = " = '" + tboxCPFP.Text + "'";
            }
            else
            {
                cpf = " IS NOT NULL ";
            }



            conexao.Abre_Conexao();

            dgv_resultado_pesquisa.Rows.Clear();
            string SQLCunsultaEmpr = "SELECT * FROM TBFUNCIONARIO WHERE DTEXCLUSAO IS NULL AND NOME " + nome + " AND CPF " + cpf;
                                         


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
                dgv_resultado_pesquisa.Rows[o].Cells["NOME"].Value = conexao.dataReader[1].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["CPF"].Value = conexao.dataReader[2].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["USUARIO"].Value = conexao.dataReader[3].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["SENHA"].Value = conexao.dataReader[4].ToString();
              

                o++;
            }


            conexao.Fecha_Conexao();

        }
        public override void gravar_Registro()
        {

            if (tboxnome.Text == "")
            {
                MessageBox.Show("Campo Nome é obrigatorio.", "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tboxnome.Focus();
                return;
            }
            if (tboxcpf.Text == "")
            {
                MessageBox.Show("Campo CPF é obrigatorio.", "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tboxcpf.Focus();
                return;
            }
           

            try
            {
                if (tboxmatricula.Text == "")
                {
                    #region INSERT
                    conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = "INSERT INTO TBFUNCIONARIO " +
                                                      "(NOME       " +
                                                      ",CPF        " +
                                                      ",USUARIO     " +
                                                      ",SENHA)   " +
                                                      "VALUES      " +
                                                      "(@NOME      " +
                                                      ",@CPF       " +
                                                      ",@USUARIO  " +
                                                      ",@SENHA)    ";


                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.Parameters.AddWithValue("NOME", tboxnome.Text);
                    conexao.cmd.Parameters.AddWithValue("CPF", tboxcpf.Text);
                    conexao.cmd.Parameters.AddWithValue("USUARIO", tboxusuario.Text);
                    conexao.cmd.Parameters.AddWithValue("SENHA", tboxsenha.Text);


                    conexao.cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro realizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conexao.Fecha_Conexao();
                    #endregion
                }
                else
                {
                    #region UPDATE
                    conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = "UPDATE TBFUNCIONARIO SET " +
                                                      "NOME      = @NOME     " +
                                                      ",CPF      = @CPF       " +
                                                      ",USUARIO  = @USUARIO    " +
                                                      ",SENHA    = @SENHA  " +
                                                      " WHERE  ID = " + tboxmatricula.Text;



                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.Parameters.AddWithValue("NOME", tboxnome.Text);
                    conexao.cmd.Parameters.AddWithValue("CPF", tboxcpf.Text);
                    conexao.cmd.Parameters.AddWithValue("USUARIO", tboxusuario.Text);
                    conexao.cmd.Parameters.AddWithValue("SENHA", tboxsenha.Text);
                    
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
                tboxmatricula.Text = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
                tboxnome.Text = dgv_resultado_pesquisa.CurrentRow.Cells["NOME"].Value.ToString();
                tboxcpf.Text = dgv_resultado_pesquisa.CurrentRow.Cells["CPF"].Value.ToString();
                tboxusuario.Text = dgv_resultado_pesquisa.CurrentRow.Cells["USUARIO"].Value.ToString();
                tboxsenha.Text = dgv_resultado_pesquisa.CurrentRow.Cells["SENHA"].Value.ToString();
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
                        id_registro = Convert.ToInt32(tboxmatricula.Text);
                    }
                    else
                    {
                        id_registro = Convert.ToInt32(dgv_resultado_pesquisa.CurrentRow.Cells[0].Value.ToString());
                    }
                    conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = "UPDATE TBFUNCIONARIO SET DTEXCLUSAO = '" + DateTime.Now + "' WHERE ID = " + id_registro;



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
            tboxmatricula.Clear();
            tboxnome.Clear();
            tboxcpf.Clear();
            tboxusuario.Clear();
            tboxsenha.Clear();

        }
        private void Frm_Funcionario_Load(object sender, EventArgs e)
        {
            Iniciar_Form();
        }
    }
}
