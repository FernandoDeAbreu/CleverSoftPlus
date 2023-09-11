using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverSoft.Produto
{
    public partial class frmAjustarEstoque2 : Form
    {
        Conexao conexao = new Conexao();
        string tipoMov;
        public frmAjustarEstoque2()
        {
            InitializeComponent();
        }
        private void pesquisarProduto()
        {
            conexao.Abre_Conexao();
            string SQLCunsultaEmpr = "SELECT * FROM TBPRODUTO WHERE DTEXCLUSAO IS NULL AND CODAUXILIAR = '" + tboxLocalizarProduto.Text + "'";



            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;
            
            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();

            int o = 0;


            while (conexao.dataReader.Read())
            {
                tboxCodigo.Text = conexao.dataReader["ID"].ToString();
                tboxDescricao.Text = conexao.dataReader["DESCRICAO"].ToString();
                tboxCodAuxiliar.Text = conexao.dataReader["CODAUXILIAR"].ToString();
               
                o++;
            }
            if (o == 0)
            {
                MessageBox.Show("Nenhum produto cadastrado com os dados informados","Clever Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            conexao.Fecha_Conexao();
        }
        private void gravar()
        {
            if (rbtnSaida.Checked == true)
            {
                tipoMov = "SD";
            }
            if (rbtnEntrada.Checked == true)
            {
                tipoMov = "ED";
            }

            conexao.Abre_Conexao();
            string SQLCunsultaEmpr = "INSERT INTO TBPRODMOV ( " +
                                           "  DTMOV   " +
                                           " ,CODPROD " +
                                           " ,QTDE    " +
                                           " ,TIPOMOV " +
                                           " ,MOTIVO )  " +
                                           "  VALUES (   " +
                                           "  @DTMOV   " +
                                           " ,@CODPROD " +
                                           " ,@QTDE    " +
                                           " ,@TIPOMOV " +
                                           " ,@MOTIVO)  ";

                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.Parameters.AddWithValue("DTMOV",   Convert.ToDateTime(tboxDtMov.Text).ToString("yyyy-MM-dd"));
                    conexao.cmd.Parameters.AddWithValue("CODPROD", tboxCodigo.Text);
                    conexao.cmd.Parameters.AddWithValue("QTDE",    tboxQtde.Text);
                    conexao.cmd.Parameters.AddWithValue("TIPOMOV", tipoMov);
                    conexao.cmd.Parameters.AddWithValue("MOTIVO", tboxMotivo.Text);
                  

                    conexao.cmd.ExecuteNonQuery();


                    MessageBox.Show("Cadastro realizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexao.Fecha_Conexao();

            ajustarEstoque();

            tboxLocalizarProduto.Clear();
            tboxCodigo.Clear();
            tboxDescricao.Clear();
            tboxCodAuxiliar.Clear();
            tboxLocalizarProduto.Focus();
        }
        private void ajustarEstoque()
        {
            if (rbtnSaida.Checked == true)
            {
                tipoMov = "-";
            }
            if (rbtnEntrada.Checked == true)
            {
                tipoMov = "+";
            }

            conexao.Abre_Conexao();
            string SQLCunsultaEmpr = "UPDATE TBPRODUTO SET " +
                                                      " ESTOQUE = ESTOQUE "+ tipoMov + " @ESTOQUE  WHERE ID = " + tboxCodigo.Text;

                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.Parameters.AddWithValue("ESTOQUE",    tboxQtde.Text);
                    conexao.cmd.ExecuteNonQuery();


           conexao.Fecha_Conexao();
          
        }
        private void tbox_Pesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tboxLocalizarProduto.Text != "")
                {
                    pesquisarProduto();
                    if (tboxCodigo.Text != "")
                    {
                        if (checkBox1.Checked == true)
                        {
                            gravar();
                        }
                    }
                }

            }
        }
        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            if (tboxCodigo.Text != "")
            {
                gravar();
            }
        }
        private void tboxQtde_Leave(object sender, EventArgs e)
        {
            tboxQtde.Text = Conversor.converterMoeda(tboxQtde.Text);
        }
        private void tboxLocalizarProduto_Leave(object sender, EventArgs e)
        {
            if (tboxLocalizarProduto.Text != "")
            {
                pesquisarProduto();
            }
        }
    }
}
