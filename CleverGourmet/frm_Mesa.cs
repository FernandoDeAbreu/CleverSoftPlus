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
    public partial class frm_Mesa : Modelo
    {
        Conexao conexao = new Conexao();
        public frm_Mesa()
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
            col_NOME.Width = 120;
            dgv_resultado_pesquisa.Columns.Add(col_NOME);

            DataGridViewTextBoxColumn col_QTDLUGARES = new DataGridViewTextBoxColumn();
            col_QTDLUGARES.Name = "QTDLUGARES";
            col_QTDLUGARES.HeaderText = "QTDE. LUGARES";
            col_QTDLUGARES.Width = 120;
            dgv_resultado_pesquisa.Columns.Add(col_QTDLUGARES);

            DataGridViewTextBoxColumn col_STATUS = new DataGridViewTextBoxColumn();
            col_STATUS.Name = "LIVRE";
            col_STATUS.HeaderText = "LIVRE";
            col_STATUS.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_resultado_pesquisa.Columns.Add(col_STATUS);


            #endregion
        }
        public override void pesquisar_Registro()
        {
            tabControl1.SelectedTab = tabPage2;

            string descricao;
         

            if (tboxMesaP.Text != "")
            {
                descricao = " LIKE '%" + tboxMesaP.Text + "%'";
            }
            else
            {
                descricao = " IS NOT NULL ";
            }

       


            conexao.Abre_Conexao();
            dgv_resultado_pesquisa.Rows.Clear();
            string SQLCunsultaEmpr = "SELECT * FROM TBMESA WHERE DTEXCLUSAO IS NULL AND DESCRICAO " + descricao + " AND LIVRE = '" + tboxStatus.Text + "'";



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
                dgv_resultado_pesquisa.Rows[o].Cells["ID"].Value        = conexao.dataReader[0].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["DESCRICAO"].Value = conexao.dataReader[1].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["QTDLUGARES"].Value = conexao.dataReader[2].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["LIVRE"].Value     = conexao.dataReader[3].ToString();
            
                o++;
            }


            conexao.Fecha_Conexao();

        }
        public override void gravar_Registro()
        {

            if (tboxMesa.Text == "")
            {
                MessageBox.Show("Campo Nome é obrigatorio.", "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tboxMesa.Focus();
                return;
            }



            try
            {
                if (tboxID.Text == "")
                {
                    #region INSERT
                    conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = "INSERT INTO TBMESA     " +
                                                      "(DESCRICAO     " +
                                                      ",QTDLUGARES     " +
                                                      ",LIVRE)        " +
                                                      "VALUES         " +
                                                      "(@DESCRICAO    " +
                                                      ",@QTDLUGARES    " +
                                                      ",@LIVRE  )     ";
                                                 


                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.Parameters.AddWithValue("DESCRICAO", tboxMesa.Text);
                    conexao.cmd.Parameters.AddWithValue("QTDLUGARES", tboxQtdLugares.Text);
                    conexao.cmd.Parameters.AddWithValue("LIVRE", "SIM");


                    conexao.cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro realizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conexao.Fecha_Conexao();
                    #endregion
                }
                else
                {
                    #region UPDATE
                    conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = "UPDATE TBMESA SET " +
                                                      "DESCRICAO    = @DESCRICAO     " +
                                                      "QTDLUGARE    = @QTDLUGARE     " +
                                                      " WHERE  ID = " + tboxID.Text;



                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.Parameters.AddWithValue("DESCRICAO", tboxMesa.Text);
                    conexao.cmd.Parameters.AddWithValue("QTDLUGARE", tboxQtdLugares.Text);


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
                tboxMesa.Text = dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                tboxQtdLugares.Text = dgv_resultado_pesquisa.CurrentRow.Cells["QTDLUGARES"].Value.ToString();
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
                    string SQLCunsultaEmpr = "UPDATE TBMESA SET DTEXCLUSAO = '" + DateTime.Now + "' WHERE ID = " + id_registro;



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
            tboxMesa.Clear();
            tboxQtdLugares.Clear();

        }

      
        private void frm_Mesa_Load(object sender, EventArgs e)
        {
            Iniciar_Form();

        }
    }
}
