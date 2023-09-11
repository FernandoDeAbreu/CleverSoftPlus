﻿using System;
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
    public partial class frmPesquisarCliente : Padrao
    {
        Conexao conexao = new Conexao();
        string SQLCunsultaEmpr;
        string limit;
        public frmPesquisarCliente()
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

            DataGridViewTextBoxColumn col_CONDOMINIO = new DataGridViewTextBoxColumn();
            col_CONDOMINIO.Name = "CONDOMINIO";
            col_CONDOMINIO.HeaderText = "CONDOMINIO";
            col_CONDOMINIO.Width = 200;
            dgv_resultado_pesquisa.Columns.Add(col_CONDOMINIO);

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

        }
        private void pesquisar_Registro()
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
            SQLCunsultaEmpr = "SELECT * FROM TBCLIENTE WHERE DTEXCLUSAO IS NULL AND RAZAOSOCIAL " + nome + " AND CNPJ_CPF " + cpf + limit;



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
                dgv_resultado_pesquisa.Rows[o].Cells["DTNASC"].Value       = Conversor.converterDataBR(conexao.dataReader["DTNASC"].ToString());
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
                dgv_resultado_pesquisa.Rows[o].Cells["CONDOMINIO"].Value    = conexao.dataReader["CONDOMINIO"].ToString();


                o++;
            }


            conexao.Fecha_Conexao();

        }
        private void editar_Registro()
        {
            try
            {
                frmCadastrarCliente a = new frmCadastrarCliente();
                a.tboxmatricula.Text   = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
                a.tboxnome.Text        = dgv_resultado_pesquisa.CurrentRow.Cells["NOME"].Value.ToString();
                a.tboxTipoPessoa.Text  = dgv_resultado_pesquisa.CurrentRow.Cells["TIPOPESSOA"].Value.ToString();
                a.tboxcpf.Text         = dgv_resultado_pesquisa.CurrentRow.Cells["CNPJ_CPF"].Value.ToString();
                a.tboxRg.Text          = dgv_resultado_pesquisa.CurrentRow.Cells["IE_RG"].Value.ToString();
                a.tboxDtNasc.Text      = dgv_resultado_pesquisa.CurrentRow.Cells["DTNASC"].Value.ToString();
                a.tboxCep.Text         = dgv_resultado_pesquisa.CurrentRow.Cells["CEP"].Value.ToString();
                a.tboxCidade.Text      = dgv_resultado_pesquisa.CurrentRow.Cells["CIDADE"].Value.ToString();
                a.tboxUF.Text          = dgv_resultado_pesquisa.CurrentRow.Cells["UF"].Value.ToString();
                a.tboxBairro.Text      = dgv_resultado_pesquisa.CurrentRow.Cells["BAIRRO"].Value.ToString();
                a.tboxEndereco.Text    = dgv_resultado_pesquisa.CurrentRow.Cells["ENDERECO"].Value.ToString();
                a.tboxNumero.Text      = dgv_resultado_pesquisa.CurrentRow.Cells["NUM"].Value.ToString();
                a.tboxComplemento.Text = dgv_resultado_pesquisa.CurrentRow.Cells["COMPLEMENTO"].Value.ToString();
                a.tboxCelular.Text     = dgv_resultado_pesquisa.CurrentRow.Cells["CELULAR"].Value.ToString();
                a.tboxTelefone.Text    = dgv_resultado_pesquisa.CurrentRow.Cells["TELEFONE"].Value.ToString();
                a.tboxWhatsApp.Text    = dgv_resultado_pesquisa.CurrentRow.Cells["WHATSAPP"].Value.ToString();
                a.tboxEmail.Text       = dgv_resultado_pesquisa.CurrentRow.Cells["EMAIL"].Value.ToString();
                a.tboxSite.Text        = dgv_resultado_pesquisa.CurrentRow.Cells["SITE"].Value.ToString();
                a.tboxObs.Text         = dgv_resultado_pesquisa.CurrentRow.Cells["OBS"].Value.ToString();
                a.tboxCondominio.Text        = dgv_resultado_pesquisa.CurrentRow.Cells["CONDOMINIO"].Value.ToString();
                a.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Houve um erro ao relalizar o processo","Clever Sistema",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }
        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Relatorio a = new frm_Relatorio();
                a.Arquivo_rdlc = "Rpv_Cliente_Simples.rdlc";
                a.Sql_Relatorio1 = this.SQLCunsultaEmpr;
                a.Dataset_Relatorio1 = "DataSet_Cliente";
                a.ShowDialog();
            }
            catch (Exception)
            {


            }
        }
        private void btnImprimirFicha_Click(object sender, EventArgs e)
        {
            try
            {
                frm_Relatorio a = new frm_Relatorio();
                a.Arquivo_rdlc = "Rpv_Cliente_Detalhado.rdlc";
                a.Sql_Relatorio1 = this.SQLCunsultaEmpr;
                a.Dataset_Relatorio1 = "DataSet_Cliente";
                a.ShowDialog();
            }
            catch (Exception)
            {


            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            limit = "";
            pesquisar_Registro();
        }
        private void frmPesquisarCliente_Load(object sender, EventArgs e)
        {
            Iniciar_Form();
            limit = " LIMIT 25";
            pesquisar_Registro();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Realmente deseje excluir o item selecionado?", "Clever Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = "UPDATE TBCLIENTE SET DTEXCLUSAO = '" + DateTime.Now + "' WHERE ID = " + Convert.ToInt32(dgv_resultado_pesquisa.CurrentRow.Cells[0].Value.ToString());


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
            frmCadastrarCliente a = new frmCadastrarCliente();
            a.ShowDialog();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar_Registro();
        }
    }
}
