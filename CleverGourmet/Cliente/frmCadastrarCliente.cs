using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverSoft.Cliente
{
    public partial class frmCadastrarCliente : Padrao
    {
        Conexao conexao = new Conexao();

        public frmCadastrarCliente()
        {
            InitializeComponent();
        }
        private void gravar_Registro()
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
                    string SQLCunsultaEmpr = "INSERT INTO TBCLIENTE " +
                                                 "(RAZAOSOCIAL,         " +
                                                 " TIPOPESSOA,          " +
                                                 " CNPJ_CPF,            " +
                                                 " IE_RG,               " +
                                                 " DTNASC,              " +
                                                 " CEP,                 " +
                                                 " CIDADE,              " +
                                                 " UF,                  " +
                                                 " BAIRRO,              " +
                                                 " ENDERECO,            " +
                                                 " CONDOMINIO,           " +
                                                 " NUM,                 " +
                                                 " COMPLEMENTO,         " +
                                                 " CELULAR,             " +
                                                 " TELEFONE,            " +
                                                 " WHATSAPP,            " +
                                                 " EMAIL,               " +
                                                 " SITE,                " +
                                                 " OBS)                 " +
                                                 " VALUES               " +
                                                 "(@RAZAOSOCIAL,               " +
                                                 " @TIPOPESSOA,         " +
                                                 " @CNPJ_CPF,           " +
                                                 " @IE_RG,              " +
                                                 " @DTNASC,             " +
                                                 " @CEP,                " +
                                                 " @CIDADE,             " +
                                                 " @UF,                 " +
                                                 " @BAIRRO,             " +
                                                 " @ENDERECO,           " +
                                                 " @CONDOMINIO,         " +
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
                    conexao.cmd.Parameters.AddWithValue("RAZAOSOCIAL", tboxnome.Text);
                    conexao.cmd.Parameters.AddWithValue("TIPOPESSOA", tboxTipoPessoa.Text);
                    conexao.cmd.Parameters.AddWithValue("CNPJ_CPF", tboxcpf.Text);
                    conexao.cmd.Parameters.AddWithValue("IE_RG", tboxRg.Text);
                    conexao.cmd.Parameters.AddWithValue("DTNASC", Conversor.converterDataUS(tboxDtNasc.Text));
                    conexao.cmd.Parameters.AddWithValue("CEP", tboxCep.Text);
                    conexao.cmd.Parameters.AddWithValue("CIDADE", tboxCidade.Text);
                    conexao.cmd.Parameters.AddWithValue("UF", tboxUF.Text);
                    conexao.cmd.Parameters.AddWithValue("BAIRRO", tboxBairro.Text);
                    conexao.cmd.Parameters.AddWithValue("ENDERECO", tboxEndereco.Text);
                    conexao.cmd.Parameters.AddWithValue("CONDOMINIO", tboxCondominio.Text);
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
                    string SQLCunsultaEmpr = "UPDATE TBCLIENTE SET " +
                                               " RAZAOSOCIAL   = @RAZAOSOCIAL,       " +
                                               " TIPOPESSOA  = @TIPOPESSOA, " +
                                               " CNPJ_CPF    = @CNPJ_CPF,   " +
                                               " IE_RG       = @IE_RG,      " +
                                               " DTNASC      = @DTNASC,     " +
                                               " CEP         = @CEP,        " +
                                               " CIDADE      = @CIDADE,     " +
                                               " UF          = @UF,         " +
                                               " BAIRRO      = @BAIRRO,     " +
                                               " ENDERECO    = @ENDERECO,   " +
                                               " CONDOMINIO  = @CONDOMINIO,   " +
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
                    conexao.cmd.Parameters.AddWithValue("DTNASC",      Conversor.converterDataUS(tboxDtNasc.Text));
                    conexao.cmd.Parameters.AddWithValue("CEP",         tboxCep.Text);
                    conexao.cmd.Parameters.AddWithValue("CIDADE",      tboxCidade.Text);
                    conexao.cmd.Parameters.AddWithValue("UF",          tboxUF.Text);
                    conexao.cmd.Parameters.AddWithValue("BAIRRO",      tboxBairro.Text);
                    conexao.cmd.Parameters.AddWithValue("ENDERECO",    tboxEndereco.Text);
                    conexao.cmd.Parameters.AddWithValue("CONDOMINIO",  tboxCondominio.Text);
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

                if (MessageBox.Show("Deseja inserir um novo registro?", "Clever Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    limpar_Campos();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }




        }
        private void limpar_Campos()
        {
            tboxmatricula.Clear();
            tboxnome.Clear();
            // tboxTipoPessoa.Clear();
            tboxcpf.Clear();
            tboxRg.Clear();
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
            tboxCondominio.Clear();

        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            gravar_Registro();
         

        }
    }
}
