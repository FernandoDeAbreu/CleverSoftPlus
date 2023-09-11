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
    public partial class frm_PDVPesquisarCliente : Form
    {
        Conexao conexao = new Conexao();
        frm_PDV instPDV;
        public frm_PDVPesquisarCliente(frm_PDV pdv)
        {
            InitializeComponent();
            instPDV = pdv;
        }

        public  void pesquisar_Cliente()
        {

            dgv_resultado_pesquisa.Columns.Clear();

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

            DataGridViewTextBoxColumn col_TIPOPESSOA = new DataGridViewTextBoxColumn();
            col_TIPOPESSOA.Name = "TIPOPESSOA";
            col_TIPOPESSOA.HeaderText = "TIPO PESSOA";
            col_TIPOPESSOA.Width = 150;
            dgv_resultado_pesquisa.Columns.Add(col_TIPOPESSOA);

            DataGridViewTextBoxColumn col_CPF = new DataGridViewTextBoxColumn();
            col_CPF.Name = "CNPJ_CPF";
            col_CPF.HeaderText = "CNPJ / CPF";
            col_CPF.Width = 200;
            dgv_resultado_pesquisa.Columns.Add(col_CPF);



            conexao.Abre_Conexao();
            dgv_resultado_pesquisa.Rows.Clear();
            string SQLCunsultaEmpr = "SELECT * FROM TBCLIENTE WHERE DTEXCLUSAO IS NULL AND RAZAOSOCIAL LIKE '%"+ tboxLocalizarProduto.Text +"%'";



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
                dgv_resultado_pesquisa.Rows[o].Cells["ID"].Value           = conexao.dataReader["ID"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["NOME"].Value         = conexao.dataReader["RAZAOSOCIAL"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["TIPOPESSOA"].Value   = conexao.dataReader["TIPOPESSOA"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["CNPJ_CPF"].Value     = conexao.dataReader["CNPJ_CPF"].ToString();

                o++;
            }


            conexao.Fecha_Conexao();

        }

        private void tboxLocalizarProduto_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void tboxLocalizarProduto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tboxLocalizarProduto_KeyDown(object sender, KeyEventArgs e)
        {
            pesquisar_Cliente();

        }

        private void dgv_resultado_pesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    instPDV.idCliente = Convert.ToInt32(dgv_resultado_pesquisa.CurrentRow.Cells[0].Value.ToString());
                    instPDV.tbox_Cliente.Text = dgv_resultado_pesquisa.CurrentRow.Cells[0].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells[1].Value.ToString();
                    this.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private void frm_PDVPesquisar_Load(object sender, EventArgs e)
        {
            tboxLocalizarProduto.Focus();
        }
    }
}
