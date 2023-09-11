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
    public partial class frm_Fornecedor : Modelo
    {
        Conexao conexao = new Conexao();
        string SQLCunsultaEmpr;

        public frm_Fornecedor()
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

            DataGridViewTextBoxColumn col_TIPOPESSOA = new DataGridViewTextBoxColumn();
            col_TIPOPESSOA.Name = "TIPOPESSOA";
            col_TIPOPESSOA.HeaderText = "TIPO PESSOA";
            col_TIPOPESSOA.Width = 100;
            dgv_resultado_pesquisa.Columns.Add(col_TIPOPESSOA);

            DataGridViewTextBoxColumn col_CPF = new DataGridViewTextBoxColumn();
            col_CPF.Name = "CNPJ_CPF";
            col_CPF.HeaderText = "CNPJ / CPF";
            col_CPF.Width = 120;
            dgv_resultado_pesquisa.Columns.Add(col_CPF);

            DataGridViewTextBoxColumn col_IE_RG = new DataGridViewTextBoxColumn();
            col_IE_RG.Name = "IE_RG";
            col_IE_RG.HeaderText = "IE / RG";
            col_IE_RG.Width = 120;
            dgv_resultado_pesquisa.Columns.Add(col_IE_RG);

            DataGridViewTextBoxColumn col_DTNASC = new DataGridViewTextBoxColumn();
            col_DTNASC.Name = "DTNASC";
            col_DTNASC.HeaderText = "DATA NASCIMENTO";
            col_DTNASC.Width = 150;
            dgv_resultado_pesquisa.Columns.Add(col_DTNASC);

            DataGridViewTextBoxColumn col_CEP = new DataGridViewTextBoxColumn();
            col_CEP.Name = "CEP";
            col_CEP.HeaderText = "CEP";
            col_CEP.Width = 120;
            dgv_resultado_pesquisa.Columns.Add(col_CEP);

            DataGridViewTextBoxColumn col_CIDADE = new DataGridViewTextBoxColumn();
            col_CIDADE.Name = "CIDADE";
            col_CIDADE.HeaderText = "CIDADE";
            col_CIDADE.Width = 180;
            dgv_resultado_pesquisa.Columns.Add(col_CIDADE);

            DataGridViewTextBoxColumn col_UF = new DataGridViewTextBoxColumn();
            col_UF.Name = "UF";
            col_UF.HeaderText = "UF";
            col_UF.Width = 70;
            dgv_resultado_pesquisa.Columns.Add(col_UF);

            DataGridViewTextBoxColumn col_BAIRRO = new DataGridViewTextBoxColumn();
            col_BAIRRO.Name = "BAIRRO";
            col_BAIRRO.HeaderText = "BAIRRO";
            col_BAIRRO.Width = 150;
            dgv_resultado_pesquisa.Columns.Add(col_BAIRRO);

            DataGridViewTextBoxColumn col_ENDERECO = new DataGridViewTextBoxColumn();
            col_ENDERECO.Name = "ENDERECO";
            col_ENDERECO.HeaderText = "ENDERECO";
            col_ENDERECO.Width = 350;
            dgv_resultado_pesquisa.Columns.Add(col_ENDERECO);

            DataGridViewTextBoxColumn col_NUM = new DataGridViewTextBoxColumn();
            col_NUM.Name = "NUM";
            col_NUM.HeaderText = "Nº";
            col_NUM.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_NUM);

            DataGridViewTextBoxColumn col_COMPLEMENTO = new DataGridViewTextBoxColumn();
            col_COMPLEMENTO.Name = "COMPLEMENTO";
            col_COMPLEMENTO.HeaderText = "COMPLEMENTO";
            col_COMPLEMENTO.Width = 250;
            dgv_resultado_pesquisa.Columns.Add(col_COMPLEMENTO);

            DataGridViewTextBoxColumn col_CELULAR = new DataGridViewTextBoxColumn();
            col_CELULAR.Name = "CELULAR";
            col_CELULAR.HeaderText = "CELULAR";
            col_CELULAR.Width = 150;
            dgv_resultado_pesquisa.Columns.Add(col_CELULAR);

            DataGridViewTextBoxColumn col_TELEFONE = new DataGridViewTextBoxColumn();
            col_TELEFONE.Name = "TELEFONE";
            col_TELEFONE.HeaderText = "TELEFONE";
            col_TELEFONE.Width = 150;
            dgv_resultado_pesquisa.Columns.Add(col_TELEFONE);
            
            DataGridViewTextBoxColumn col_WHATSAPP = new DataGridViewTextBoxColumn();
            col_WHATSAPP.Name = "WHATSAPP";
            col_WHATSAPP.HeaderText = "WHATSAPP";
            col_WHATSAPP.Width = 150;
            dgv_resultado_pesquisa.Columns.Add(col_WHATSAPP);

            DataGridViewTextBoxColumn col_EMAIL = new DataGridViewTextBoxColumn();
            col_EMAIL.Name = "EMAIL";
            col_EMAIL.HeaderText = "E-MAIL";
            col_EMAIL.Width = 200;
            dgv_resultado_pesquisa.Columns.Add(col_EMAIL);

            DataGridViewTextBoxColumn col_SITE = new DataGridViewTextBoxColumn();
            col_SITE.Name = "SITE";
            col_SITE.HeaderText = "SITE";
            col_SITE.Width = 250;
            dgv_resultado_pesquisa.Columns.Add(col_SITE);

            DataGridViewTextBoxColumn col_OBS = new DataGridViewTextBoxColumn();
            col_OBS.Name = "OBS";
            col_OBS.HeaderText = "OBS";
            col_OBS.Width = 300;
            dgv_resultado_pesquisa.Columns.Add(col_OBS);








            #endregion

            Relatorio1ToolStripMenuItem.Visible = true;
            Relatorio1ToolStripMenuItem.Text = "Relatório simples";

            Relatorio2ToolStripMenuItem.Visible = true;
            Relatorio2ToolStripMenuItem.Text = "Relatório Detalhado";
        }

        public override void pesquisar_Registro()
        {

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
            SQLCunsultaEmpr = "SELECT * FROM TBFORNECEDOR WHERE DTEXCLUSAO IS NULL AND RAZAOSOCIAL " + nome + " AND CNPJ_CPF " + cpf;



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
                dgv_resultado_pesquisa.Rows[o].Cells["IE_RG"].Value        = conexao.dataReader["IE_RG"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["DTNASC"].Value       = conexao.dataReader["DTNASC"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["CEP"].Value          = conexao.dataReader["CEP"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["CIDADE"].Value       = conexao.dataReader["CIDADE"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["UF"].Value           = conexao.dataReader["UF"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["BAIRRO"].Value       = conexao.dataReader["BAIRRO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["ENDERECO"].Value     = conexao.dataReader["ENDERECO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["NUM"].Value          = conexao.dataReader["NUM"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["COMPLEMENTO"].Value  = conexao.dataReader["COMPLEMENTO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["CELULAR"].Value      = conexao.dataReader["CELULAR"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["TELEFONE"].Value     = conexao.dataReader["TELEFONE"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["WHATSAPP"].Value     = conexao.dataReader["WHATSAPP"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["EMAIL"].Value        = conexao.dataReader["EMAIL"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["SITE"].Value         = conexao.dataReader["SITE"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["OBS"].Value          = conexao.dataReader["OBS"].ToString();


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
                    string SQLCunsultaEmpr = "INSERT INTO TBFORNECEDOR " +
                                                 "(RAZAOSOCIAL,                " +
                                                 " TIPOPESSOA,          " +
                                                 " CNPJ_CPF,            " +
                                                 " IE_RG,               " +
                                                 " DTNASC,              " +
                                                 " CEP,                 " +
                                                 " CIDADE,              " +
                                                 " UF,                  " +
                                                 " BAIRRO,              " +
                                                 " ENDERECO,            " +
                                                 " NUM,                 " +
                                                 " COMPLEMENTO,         " +
                                                 " CELULAR,             " +
                                                 " TELEFONE,            " +
                                                 " WHATSAPP,            " +
                                                 " EMAIL,               " +
                                                 " SITE,                " +
                                                 " OBS)                 " +
                                                 " VALUES               " +
                                                 "(@NOME,               " +
                                                 " @TIPOPESSOA,         " +
                                                 " @CNPJ_CPF,           " +
                                                 " @IE_RG,              " +
                                                 " @DTNASC,             " +
                                                 " @CEP,                " +
                                                 " @CIDADE,             " +
                                                 " @UF,                 " +
                                                 " @BAIRRO,             " +
                                                 " @ENDERECO,           " +
                                                 " @NUM,                " +
                                                 " @COMPLEMENTO,        " +
                                                 " @CELULAR,            " +
                                                 " @TELEFONE,           " +
                                                 " @WHATSAPP,           " +
                                                 " @EMAIL,              " +
                                                 " @SITE,               " +
                                                 " @OBS)                ";


                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.Parameters.AddWithValue("NOME", tboxnome.Text);
                    conexao.cmd.Parameters.AddWithValue("TIPOPESSOA", tboxTipoPessoa.Text);
                    conexao.cmd.Parameters.AddWithValue("CNPJ_CPF", tboxcpf.Text);
                    conexao.cmd.Parameters.AddWithValue("IE_RG", tboxRg.Text);
                    conexao.cmd.Parameters.AddWithValue("DTNASC", tboxDtNasc.Text);
                    conexao.cmd.Parameters.AddWithValue("CEP", tboxCep.Text);
                    conexao.cmd.Parameters.AddWithValue("CIDADE", tboxCidade.Text);
                    conexao.cmd.Parameters.AddWithValue("UF", tboxUF.Text);
                    conexao.cmd.Parameters.AddWithValue("BAIRRO", tboxBairro.Text);
                    conexao.cmd.Parameters.AddWithValue("ENDERECO", tboxEndereco.Text);
                    conexao.cmd.Parameters.AddWithValue("NUM", tboxNumero.Text);
                    conexao.cmd.Parameters.AddWithValue("COMPLEMENTO", tboxComplemento.Text);
                    conexao.cmd.Parameters.AddWithValue("CELULAR", tboxCelular.Text);
                    conexao.cmd.Parameters.AddWithValue("TELEFONE", tboxTelefone.Text);
                    conexao.cmd.Parameters.AddWithValue("WHATSAPP", tboxWhatsApp.Text);
                    conexao.cmd.Parameters.AddWithValue("EMAIL", tboxEmail.Text);
                    conexao.cmd.Parameters.AddWithValue("SITE", tboxSite.Text);
                    conexao.cmd.Parameters.AddWithValue("OBS", tboxObs.Text);


                    conexao.cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro realizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conexao.Fecha_Conexao();
                    #endregion
                }
                else
                {
                    #region UPDATE
                    conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = "UPDATE TBFORNECEDOR SET " +
                                               " RAZAOSOCIAL = @RAZAOSOCIAL,       " +
                                               " TIPOPESSOA  = @TIPOPESSOA, " +
                                               " CNPJ_CPF    = @CNPJ_CPF,   " +
                                               " IE_RG       = @IE_RG,      " +
                                               " DTNASC      = @DTNASC,     " +
                                               " CEP         = @CEP,        " +
                                               " CIDADE      = @CIDADE,     " +
                                               " UF          = @UF,         " +
                                               " BAIRRO      = @BAIRRO,     " +
                                               " ENDERECO    = @ENDERECO,   " +
                                               " NUM         = @NUM,        " +
                                               " COMPLEMENTO = @COMPLEMENTO," +
                                               " CELULAR     = @CELULAR,    " +
                                               " TELEFONE    = @TELEFONE,   " +
                                               " WHATSAPP    = @WHATSAPP,   " +
                                               " EMAIL       = @EMAIL,      " +
                                               " SITE        = @SITE,       " +
                                               " OBS         = @OBS        " +
                                               " WHERE  ID = " + tboxmatricula.Text;


                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.Parameters.AddWithValue("RAZAOSOCIAL", tboxnome.Text);
                    conexao.cmd.Parameters.AddWithValue("TIPOPESSOA",  tboxTipoPessoa.Text);
                    conexao.cmd.Parameters.AddWithValue("CNPJ_CPF",    tboxcpf.Text);
                    conexao.cmd.Parameters.AddWithValue("IE_RG",       tboxRg.Text);
                    conexao.cmd.Parameters.AddWithValue("DTNASC",      tboxDtNasc.Text);
                    conexao.cmd.Parameters.AddWithValue("CEP",         tboxCep.Text);
                    conexao.cmd.Parameters.AddWithValue("CIDADE",      tboxCidade.Text);
                    conexao.cmd.Parameters.AddWithValue("UF",          tboxUF.Text);
                    conexao.cmd.Parameters.AddWithValue("BAIRRO",      tboxBairro.Text);
                    conexao.cmd.Parameters.AddWithValue("ENDERECO",    tboxEndereco.Text);
                    conexao.cmd.Parameters.AddWithValue("NUM",         tboxNumero.Text);
                    conexao.cmd.Parameters.AddWithValue("COMPLEMENTO", tboxComplemento.Text);
                    conexao.cmd.Parameters.AddWithValue("CELULAR",     tboxCelular.Text);
                    conexao.cmd.Parameters.AddWithValue("TELEFONE",    tboxTelefone.Text);
                    conexao.cmd.Parameters.AddWithValue("WHATSAPP",    tboxWhatsApp.Text);
                    conexao.cmd.Parameters.AddWithValue("EMAIL",       tboxEmail.Text);
                    conexao.cmd.Parameters.AddWithValue("SITE",        tboxSite.Text);
                    conexao.cmd.Parameters.AddWithValue("OBS",         tboxObs.Text);


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
                tboxmatricula.Text   = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
                tboxnome.Text        = dgv_resultado_pesquisa.CurrentRow.Cells["NOME"].Value.ToString();
                tboxTipoPessoa.Text  = dgv_resultado_pesquisa.CurrentRow.Cells["TIPOPESSOA"].Value.ToString();
                tboxcpf.Text         = dgv_resultado_pesquisa.CurrentRow.Cells["CNPJ_CPF"].Value.ToString();
                tboxRg.Text          = dgv_resultado_pesquisa.CurrentRow.Cells["IE_RG"].Value.ToString();
                tboxDtNasc.Text      = dgv_resultado_pesquisa.CurrentRow.Cells["DTNASC"].Value.ToString();
                tboxCep.Text         = dgv_resultado_pesquisa.CurrentRow.Cells["CEP"].Value.ToString();
                tboxCidade.Text      = dgv_resultado_pesquisa.CurrentRow.Cells["CIDADE"].Value.ToString();
                tboxUF.Text          = dgv_resultado_pesquisa.CurrentRow.Cells["UF"].Value.ToString();
                tboxBairro.Text      = dgv_resultado_pesquisa.CurrentRow.Cells["BAIRRO"].Value.ToString();
                tboxEndereco.Text    = dgv_resultado_pesquisa.CurrentRow.Cells["ENDERECO"].Value.ToString();
                tboxNumero.Text      = dgv_resultado_pesquisa.CurrentRow.Cells["NUM"].Value.ToString();
                tboxComplemento.Text = dgv_resultado_pesquisa.CurrentRow.Cells["COMPLEMENTO"].Value.ToString();
                tboxCelular.Text     = dgv_resultado_pesquisa.CurrentRow.Cells["CELULAR"].Value.ToString();
                tboxTelefone.Text    = dgv_resultado_pesquisa.CurrentRow.Cells["TELEFONE"].Value.ToString();
                tboxWhatsApp.Text    = dgv_resultado_pesquisa.CurrentRow.Cells["WHATSAPP"].Value.ToString();
                tboxEmail.Text       = dgv_resultado_pesquisa.CurrentRow.Cells["EMAIL"].Value.ToString();
                tboxSite.Text        = dgv_resultado_pesquisa.CurrentRow.Cells["SITE"].Value.ToString();
                tboxObs.Text         = dgv_resultado_pesquisa.CurrentRow.Cells["OBS"].Value.ToString();

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
                    string SQLCunsultaEmpr = "UPDATE TBFORNECEDOR SET DTEXCLUSAO = '" + DateTime.Now + "' WHERE ID = " + id_registro;



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
           // tboxTipoPessoa.Clear();
            tboxcpf.Clear();
            tboxRg.Clear();
            tboxDtNasc.Clear();
            tboxCep.Clear();
            tboxCidade.Clear();
            // tboxUF.Clear();
            tboxBairro.Clear();
            tboxEndereco.Clear();
            tboxNumero.Clear();
            tboxComplemento.Clear();
            tboxCelular.Clear();
            tboxTelefone.Clear();
            tboxWhatsApp.Clear();
            tboxEmail.Clear();
            tboxSite.Clear();
            tboxObs.Clear();

        }

        public override void relatorio1()
        {
            try
            {
                frm_Relatorio a = new frm_Relatorio();
                a.Arquivo_rdlc = "Rpv_Fornecedor_Lista.rdlc";
                a.Sql_Relatorio1 = this.SQLCunsultaEmpr;
                a.Dataset_Relatorio1 = "DataSet_Fornecedor";
                a.ShowDialog();
            }
            catch (Exception)
            {


            }
        }

        public override void relatorio2()
        {
            try
            {
                frm_Relatorio a = new frm_Relatorio();
                a.Arquivo_rdlc = "Rpv_Fornecedor_Detalhado.rdlc";
                a.Sql_Relatorio1 = this.SQLCunsultaEmpr;
                a.Dataset_Relatorio1 = "DataSet_Fornecedor";
                a.ShowDialog();
            }
            catch (Exception)
            {


            }
        }

        private void frm_Fornecedor_Load(object sender, EventArgs e)
        {
            Iniciar_Form();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tboxDtNasc_Leave(object sender, EventArgs e)
        {
            try
            {
                tboxDtNasc.Text = Convert.ToDateTime(tboxDtNasc.Text).ToShortDateString();

            }
            catch (Exception)
            {
                MessageBox.Show("Data invalida", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tboxDtNasc.Clear();

            }
        }
    }
}
