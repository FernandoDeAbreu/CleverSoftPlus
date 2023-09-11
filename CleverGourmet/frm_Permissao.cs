using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverSoft
{
    public partial class frm_Permissao : ModeloSimples
    {
        Conexao conexao = new Conexao();
        AcessoRotina permissao = new AcessoRotina();
        public string codParceiro;
        frm_Menux frm_menux;

      

        public frm_Permissao(frm_Menux menux)
        {
            InitializeComponent();
            frm_menux = menux;
        }
        private void preencherDataGrid()
        {
            int i = 0;
            dgv_resultado_pesquisa.Rows.Clear();

            foreach (ToolStripItem botao in frm_menux.Cadastrar.Items)
            {
                if (botao.Text != "")
                {
                    dgv_resultado_pesquisa.Rows.Add();
                    dgv_resultado_pesquisa.Rows[i].Cells[0].Value = botao.Text;

                    i++;
                }
            }

           
          
            foreach (ToolStripItem botao in frm_menux.Financeiro.Items)
            {
                if (botao.Text != "")
                {
                    dgv_resultado_pesquisa.Rows.Add();
                    dgv_resultado_pesquisa.Rows[i].Cells[0].Value = botao.Text;

                    i++;
                }
            }

         

          
            foreach (ToolStripItem botao in frm_menux.Sistema.Items)
            {
                if (botao.Text != "")
                {
                    dgv_resultado_pesquisa.Rows.Add();
                    dgv_resultado_pesquisa.Rows[i].Cells[0].Value = botao.Text;

                    i++;
                }
            }
            foreach (ToolStripItem botao in frm_menux.Sair.Items)
            {
                if (botao.Text != "")
                {
                    dgv_resultado_pesquisa.Rows.Add();
                    dgv_resultado_pesquisa.Rows[i].Cells[0].Value = botao.Text;

                    i++;
                }
            }

        }
        private void gravarNovasPermissoes()
        {
            for (int i = 0; i < dgv_resultado_pesquisa.Rows.Count; i++)
            {

                if (Convert.ToString(dgv_resultado_pesquisa.Rows[i].Cells[1].Value) == "1")
                {
                    conexao.Abre_Conexao();
                    string insert = "INSERT INTO TBPERMISSAO ( IDFUNC, NOMEROTINA ) VALUES ( @IDFUNC, @NOMEROTINA) ";

                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = insert;
                    conexao.cmd.Parameters.AddWithValue("IDFUNC", codParceiro);
                    conexao.cmd.Parameters.AddWithValue("NOMEROTINA", dgv_resultado_pesquisa.Rows[i].Cells[0].Value.ToString());

                    conexao.cmd.ExecuteNonQuery();

                    conexao.cmd.Parameters.Clear();
                    conexao.Fecha_Conexao();
                }
                else
                {
                    conexao.Abre_Conexao();
                    string insert = "DELETE FROM TBPERMISSAO WHERE IDFUNC = @IDFUNC AND NOMEROTINA = @NOMEROTINA";

                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = insert;
                    conexao.cmd.Parameters.AddWithValue("IDFUNC", codParceiro);
                    conexao.cmd.Parameters.AddWithValue("NOMEROTINA", dgv_resultado_pesquisa.Rows[i].Cells[0].Value.ToString());

                    conexao.cmd.ExecuteNonQuery();
                    conexao.cmd.Parameters.Clear();


                    conexao.Fecha_Conexao();
                }

            }
        }
        private void excluirPermissoes()
        {
           
                    conexao.Abre_Conexao();
                    string insert = "DELETE FROM TBPERMISSAO WHERE IDFUNC = @IDFUNC";

                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = insert;
                    conexao.cmd.Parameters.AddWithValue("IDFUNC", codParceiro);
                    conexao.cmd.ExecuteNonQuery();
                    conexao.Fecha_Conexao();
            
        }
        private void pesquisarPermissoes()
        {
                      
            for (int i = 0; i < dgv_resultado_pesquisa.Rows.Count; i++)
            {
            conexao.Abre_Conexao();

             String SQLCunsultaEmpr = "SELECT * FROM TBPERMISSAO WHERE IDFUNC = '" + codParceiro + "' AND NOMEROTINA = '" + dgv_resultado_pesquisa.Rows[i].Cells[0].Value.ToString() + "'";



                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;

                conexao.cmd.ExecuteNonQuery();
                conexao.adapter.SelectCommand = conexao.cmd;
                conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
                conexao.dataReader = conexao.cmd.ExecuteReader();

                int o = 0;


                while (conexao.dataReader.Read())
                {
                    o++;
                }
                if (o > 0)
                {
                    dgv_resultado_pesquisa.Rows[i].Cells[1].Value = 1;
                }
                else if(o == 0)
                {
                    dgv_resultado_pesquisa.Rows[i].Cells[1].Value = 0;

                }
                conexao.Fecha_Conexao();

            }

        }
        
        private void frm_Permissao_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_PesquisarUsuario_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "CADASTRAR PERMISSÃO";
            a.RotinaOrigem = lbl_NomeRotina.Text;
            a.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (tboxParceiro.Text != "")
            {
                preencherDataGrid();
                pesquisarPermissoes();
            }
          

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            if (tboxParceiro.Text != "")
            {
                excluirPermissoes();
                gravarNovasPermissoes();
                preencherDataGrid();
                pesquisarPermissoes();
            }
        }

        private void dgv_resultado_pesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
            }
        }

        private void dgv_resultado_pesquisa_Click(object sender, EventArgs e)
        {
        }
    }
}
