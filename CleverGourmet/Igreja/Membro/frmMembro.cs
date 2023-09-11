using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverSoft.Igreja.Membro
{
    public partial class frmMembro : Padrao
    {
        Conexao conexao = new Conexao();

        public frmMembro()
        {
            InitializeComponent();
        }
        private void select_Membros()
        {

            dgv_Cliente.Rows.Clear();

            try
            {


                conexao.Abre_Conexao();


                string StringSQL =       " SELECT         " +
                                  "  C.CODIGO       " +
                                  " ,C.RAZAOSOCIAL " +
                                  " ,C.FANTASIA    " +
                                  " ,C.TIPOPESSOA  " +
                                  " ,C.CPF         " +
                                  " ,C.RG          " +
                                  " ,C.UFRG        " +
                                  " ,C.ORGAORG     " +
                                  " ,C.IE          " +
                                  " ,C.IM          " +
                                  " ,C.EMAIL       " +
                                  " ,C.CELULAR     " +
                                  " ,C.TELEFONE    " +
                                  " ,C.CEP         " +
                                  " ,C.TELEFONE2   " +
                                  " ,C.ENDERECO    " +
                                  " ,C.UF          " +
                                  " ,C.CIDADE      " +
                                  " ,C.BAIRRO      " +
                                  " ,C.PAIS        " +
                                  " ,C.NOMEMAE     " +
                                  " ,C.NOMEPAI     " +
                                  " ,C.ATIVIDADE   " +
                                  " ,C.AREAATUAL   " +
                                  " ,C.PROFISSAO   " +
                                  " ,C.DTNASC      " +
                                  " ,C.NATURAL     " +
                                  " ,C.DTCAD       " +
                                  " ,C.MATCAD      " +
                                  " ,C.SEXO        " +
                                  " ,F.RAZAOSOCIAL NOMEFILIAL   " +
                                  " ,C.CLIENTEDESDE" +
                                  " ,C.BATAGUA     " +
                                  " ,C.BATESPIRITO " +
                                  " ,C.DIZIMISTA   " +
                                  " ,C.ALUNOEBD    " +
                                  " ,C.DTDESL      " +
                                  " ,C.MOTDESL     " +
                                  " ,C.FOTO        " +
                                  " ,C.CNPJ        " +
                                  " ,C.NUM         " +
                              " FROM TBMEMBRO C, TBFILIAL F  WHERE  C.CODFILIAL = F.ID AND " +
                              "  C.DTEXCLUSAO IS NULL AND C.RAZAOSOCIAL LIKE '%" + tbox_pesquisar.Text + "%' ORDER BY C.CODIGO";



                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = StringSQL;

                conexao.cmd.ExecuteNonQuery();
                conexao.adapter.SelectCommand = conexao.cmd;
                conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
                conexao.dataReader = conexao.cmd.ExecuteReader();

                int o = 0;

                while (conexao.dataReader.Read())
                {

                          dgv_Cliente.Rows.Add();

                          dgv_Cliente.Rows[o].Cells["CODIGO"].Value       = conexao.dataReader["CODIGO"].ToString();     
                          dgv_Cliente.Rows[o].Cells["RAZAOSOCIAL"].Value  = conexao.dataReader["RAZAOSOCIAL"].ToString();
                          dgv_Cliente.Rows[o].Cells["FANTASIA"].Value     = conexao.dataReader["FANTASIA"].ToString(); 
                          dgv_Cliente.Rows[o].Cells["TIPOPESSOA"].Value   = conexao.dataReader["TIPOPESSOA"].ToString();  
                          dgv_Cliente.Rows[o].Cells["CPF"].Value          = conexao.dataReader["CPF"].ToString();           
                          dgv_Cliente.Rows[o].Cells["RG"].Value           = conexao.dataReader["RG"].ToString();            
                          dgv_Cliente.Rows[o].Cells["UFRG"].Value         = conexao.dataReader["UFRG"].ToString();          
                          dgv_Cliente.Rows[o].Cells["ORGAORG"].Value      = conexao.dataReader["ORGAORG"].ToString();       
                          dgv_Cliente.Rows[o].Cells["IE"].Value           = conexao.dataReader["IE"].ToString();            
                          dgv_Cliente.Rows[o].Cells["IM"].Value           = conexao.dataReader["IM"].ToString();            
                          dgv_Cliente.Rows[o].Cells["EMAIL"].Value        = conexao.dataReader["EMAIL"].ToString();         
                          dgv_Cliente.Rows[o].Cells["CELULAR"].Value      = conexao.dataReader["CELULAR"].ToString();       
                          dgv_Cliente.Rows[o].Cells["TELEFONE"].Value     = conexao.dataReader["TELEFONE"].ToString();      
                          dgv_Cliente.Rows[o].Cells["CEP"].Value          = conexao.dataReader["CEP"].ToString();           
                          dgv_Cliente.Rows[o].Cells["TELEFONE2"].Value    = conexao.dataReader["TELEFONE2"].ToString();     
                          dgv_Cliente.Rows[o].Cells["ENDERECO"].Value     = conexao.dataReader["ENDERECO"].ToString();      
                          dgv_Cliente.Rows[o].Cells["UF"].Value           = conexao.dataReader["UF"].ToString();            
                          dgv_Cliente.Rows[o].Cells["CIDADE"].Value       = conexao.dataReader["CIDADE"].ToString();        
                          dgv_Cliente.Rows[o].Cells["BAIRRO"].Value       = conexao.dataReader["BAIRRO"].ToString();        
                          dgv_Cliente.Rows[o].Cells["PAIS"].Value         = conexao.dataReader["PAIS"].ToString();          
                          dgv_Cliente.Rows[o].Cells["NOMEMAE"].Value      = conexao.dataReader["NOMEMAE"].ToString();       
                          dgv_Cliente.Rows[o].Cells["NOMEPAI"].Value      = conexao.dataReader["NOMEPAI"].ToString();       
                          dgv_Cliente.Rows[o].Cells["ATIVIDADE"].Value    = conexao.dataReader["ATIVIDADE"].ToString();     
                          dgv_Cliente.Rows[o].Cells["AREAATUAL"].Value    = conexao.dataReader["AREAATUAL"].ToString();     
                          dgv_Cliente.Rows[o].Cells["PROFISSAO"].Value    = conexao.dataReader["PROFISSAO"].ToString();     
                          dgv_Cliente.Rows[o].Cells["NATURAL"].Value      = conexao.dataReader["NATURAL"].ToString();       
                          dgv_Cliente.Rows[o].Cells["DTCAD"].Value        = conexao.dataReader["DTCAD"].ToString();         
                          dgv_Cliente.Rows[o].Cells["MATCAD"].Value       = conexao.dataReader["MATCAD"].ToString();        
                          dgv_Cliente.Rows[o].Cells["SEXO"].Value         = conexao.dataReader["SEXO"].ToString();
                          dgv_Cliente.Rows[o].Cells["CODFILIAL"].Value    = conexao.dataReader["NOMEFILIAL"].ToString();
                          dgv_Cliente.Rows[o].Cells["CLIENTEDESDE"].Value = conexao.dataReader["CLIENTEDESDE"].ToString(); 
                          dgv_Cliente.Rows[o].Cells["BATAGUA"].Value      = conexao.dataReader["BATAGUA"].ToString();       
                          dgv_Cliente.Rows[o].Cells["BATESPIRITO"].Value  = conexao.dataReader["BATESPIRITO"].ToString();   
                          dgv_Cliente.Rows[o].Cells["DIZIMISTA"].Value    = conexao.dataReader["DIZIMISTA"].ToString();     
                          dgv_Cliente.Rows[o].Cells["ALUNOEBD"].Value     = conexao.dataReader["ALUNOEBD"].ToString();
                          dgv_Cliente.Rows[o].Cells["DTNASC"].Value       = Conversor.converterDataBR(conexao.dataReader["DTNASC"].ToString()); 
                          dgv_Cliente.Rows[o].Cells["DTDESL"].Value       = Conversor.converterDataBR(conexao.dataReader["DTDESL"].ToString());      
                          dgv_Cliente.Rows[o].Cells["MOTDESL"].Value      = conexao.dataReader["MOTDESL"].ToString();       
                          dgv_Cliente.Rows[o].Cells["DIRFOTO"].Value      = conexao.dataReader["FOTO"].ToString();          
                          dgv_Cliente.Rows[o].Cells["CNPJ"].Value         = conexao.dataReader["CNPJ"].ToString();          
                          dgv_Cliente.Rows[o].Cells["NUM"].Value          = conexao.dataReader["NUM"].ToString();           
                          


                    o++;
                 //   lbl_QtdLinhas.Text = "Foram listatos " + Convert.ToString(o) + " registros ";


                }

                conexao.Fecha_Conexao();

            }

            catch (Exception e)
            {

                MessageBox.Show("Ocorreu um erro ao pesquisar registros!", "Clever Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (MessageBox.Show("Deseja exibir messagem original do erro?", "Clever Sistemas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    MessageBox.Show("Erro: " + e, "Clever Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void frmMembro_Load(object sender, EventArgs e)
        {
            select_Membros();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            select_Membros();
        }

        private void tbox_pesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void tbox_pesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            select_Membros();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            conexao.Abre_Conexao();
            string SQLCunsultaEmpr = "UPDATE TBMEMBRO SET " +
                                              " DTEXCLUSAO  = DATE('now')    " +
                                              " WHERE  CODIGO = " + dgv_Cliente.CurrentRow.Cells["CODIGO"].Value.ToString();

            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;
            conexao.cmd.ExecuteNonQuery();

            MessageBox.Show("Cadastro Atualizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            conexao.Fecha_Conexao();


            select_Membros();
        }
    }
}
