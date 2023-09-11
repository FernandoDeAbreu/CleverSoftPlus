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
    public partial class frm_Produto : Modelo
    {
        Conexao conexao = new Conexao();
        OpenFileDialog file = new OpenFileDialog();
        string sourceFile;
        string destinationFile;
        string SQLCunsultaEmpr;
        public string idSecao;
        public string idDepto;
        public frm_Produto()
        {
            InitializeComponent();
        }
        private void Iniciar_Form()
        {
            #region MONTAR GRID CONSULTA

            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.Name = "ID";
            col_ID.HeaderText = "CÓDIGO";
            col_ID.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_ID);

            DataGridViewTextBoxColumn col_TIPO = new DataGridViewTextBoxColumn();
            col_TIPO.Name = "TIPO";
            col_TIPO.HeaderText = "TIPO";
            col_TIPO.Width = 100;
            dgv_resultado_pesquisa.Columns.Add(col_TIPO);

            DataGridViewTextBoxColumn col_DESCRICAO = new DataGridViewTextBoxColumn();
            col_DESCRICAO.Name = "DESCRICAO";
            col_DESCRICAO.HeaderText = "DESCRIÇÃO";
            col_DESCRICAO.Width = 350;
            dgv_resultado_pesquisa.Columns.Add(col_DESCRICAO);

            DataGridViewTextBoxColumn col_CODAUXILIAR = new DataGridViewTextBoxColumn();
            col_CODAUXILIAR.Name = "CODAUXILIAR";
            col_CODAUXILIAR.HeaderText = "CÓD. AUXILIAR";
            col_CODAUXILIAR.Width = 120;
            dgv_resultado_pesquisa.Columns.Add(col_CODAUXILIAR);

            DataGridViewTextBoxColumn col_MEDIDA = new DataGridViewTextBoxColumn();
            col_MEDIDA.Name = "MEDIDA";
            col_MEDIDA.HeaderText = "MEDIDA";
            col_MEDIDA.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_MEDIDA);

            DataGridViewTextBoxColumn col_PCUSTO = new DataGridViewTextBoxColumn();
            col_PCUSTO.Name = "PCUSTO";
            col_PCUSTO.HeaderText = "PREÇO CUSTO";
            col_PCUSTO.Width = 150;
            dgv_resultado_pesquisa.Columns.Add(col_PCUSTO);

            DataGridViewTextBoxColumn col_ESTOQUE = new DataGridViewTextBoxColumn();
            col_ESTOQUE.Name = "ESTOQUE";
            col_ESTOQUE.HeaderText = "ESTOQUE";
            col_ESTOQUE.Width = 100;
            dgv_resultado_pesquisa.Columns.Add(col_ESTOQUE);

            DataGridViewTextBoxColumn col_PVENDA = new DataGridViewTextBoxColumn();
            col_PVENDA.Name = "PVENDA";
            col_PVENDA.HeaderText = "PREÇO VENDA";
            col_PVENDA.Width = 150;
            dgv_resultado_pesquisa.Columns.Add(col_PVENDA);

            DataGridViewTextBoxColumn col_IDDEPTO = new DataGridViewTextBoxColumn();
            col_IDDEPTO.Name = "IDDEPTO";
            col_IDDEPTO.HeaderText = "ID. DEPTO";
            col_IDDEPTO.Visible = false;
            dgv_resultado_pesquisa.Columns.Add(col_IDDEPTO);

            DataGridViewTextBoxColumn col_DEPARTAMENTO = new DataGridViewTextBoxColumn();
            col_DEPARTAMENTO.Name = "DEPARTAMENTO";
            col_DEPARTAMENTO.HeaderText = "DEPARTAMENTO";
            col_DEPARTAMENTO.Width = 170;
            dgv_resultado_pesquisa.Columns.Add(col_DEPARTAMENTO);


            DataGridViewTextBoxColumn col_IDSECAO = new DataGridViewTextBoxColumn();
            col_IDSECAO.Name = "IDSECAO";
            col_IDSECAO.HeaderText = "ID SEÇÃO";
            col_IDSECAO.Visible = false;
            dgv_resultado_pesquisa.Columns.Add(col_IDSECAO);

            DataGridViewTextBoxColumn col_SECAO = new DataGridViewTextBoxColumn();
            col_SECAO.Name = "SECAO";
            col_SECAO.HeaderText = "SEÇÃO";
            col_SECAO.Width = 170;
            dgv_resultado_pesquisa.Columns.Add(col_SECAO);

            DataGridViewTextBoxColumn col_NS = new DataGridViewTextBoxColumn();
            col_NS.Name = "NS";
            col_NS.HeaderText = "SKU";
            col_NS.Width = 170;
            dgv_resultado_pesquisa.Columns.Add(col_NS);

            DataGridViewTextBoxColumn col_OBS = new DataGridViewTextBoxColumn();
            col_OBS.Name = "OBS";
            col_OBS.HeaderText = "OBS";
            col_OBS.Width = 170;
            dgv_resultado_pesquisa.Columns.Add(col_OBS);

            #endregion

            Relatorio1ToolStripMenuItem.Visible = true;
            Relatorio1ToolStripMenuItem.Text = "Relatório";

            Relatorio2ToolStripMenuItem.Visible = true;
            Relatorio2ToolStripMenuItem.Text = "Tabela de Preço";

            pboxIMG.ImageLocation = Application.StartupPath + @"\IMG_PRODUTO\semImagem.jpg";
        }

        public override void pesquisar_Registro()
        {
            tabControl1.SelectedTab = tabPage2;

            string descricao;
            string codigoAuxiliar;


            if (tboxDescricaoP.Text != "")
            {
                descricao = " LIKE '%" + tboxDescricaoP.Text + "%'";
            }
            else
            {
                descricao = " IS NOT NULL ";
            }

            if (tboxCodigoAuxiliarP.Text != "")
            {
                codigoAuxiliar = " = '" + tboxCodigoAuxiliarP.Text + "'";
            }
            else
            {
                codigoAuxiliar = " IS NOT NULL ";
            }



            conexao.Abre_Conexao();
            dgv_resultado_pesquisa.Rows.Clear();
            SQLCunsultaEmpr =  " SELECT              " +
                               " P.ID,               " +
                               " P.DESCRICAO,        " +
                               " P.CODAUXILIAR,      " +
                               " P.MEDIDA,           " +
                               " P.PCUSTO,           " +
                               " P.ESTOQUE,          " +
                               " P.PVENDA,           " +
                               " P.IMG,              " +
                               " S.IDDEPTO,          " +
                               " D.DEPARTAMENTO,     " +
                               " P.IDSECAO,          " +
                               " S.SECAO,             " +
                               " P.TIPO,             " +
                               " P.NS,               " +
                               " P.OBS               " +
                               "                     " +
                               " FROM                " +
                               " TBPRODUTO P,        " +
                               " TBDEPTO   D,        " +
                               " TBSECAO S           " +
                               "                     " +
                               " WHERE               " +
                               "                     " +
                               " P.IDSECAO = S.ID AND" +
                               " S.IDDEPTO = D.ID  AND P.DTEXCLUSAO IS NULL AND P.DESCRICAO " + descricao + " AND P.CODAUXILIAR " + codigoAuxiliar;


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
                dgv_resultado_pesquisa.Rows[o].Cells["ID"].Value            = conexao.dataReader["ID"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["TIPO"].Value          = conexao.dataReader["TIPO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["DESCRICAO"].Value     = conexao.dataReader["DESCRICAO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["CODAUXILIAR"].Value   = conexao.dataReader["CODAUXILIAR"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["MEDIDA"].Value        = conexao.dataReader["MEDIDA"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["PCUSTO"].Value        = Conversor.converterMoeda(conexao.dataReader["PCUSTO"].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["ESTOQUE"].Value       = Conversor.converterMoeda(conexao.dataReader["ESTOQUE"].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["PVENDA"].Value        = Conversor.converterMoeda(conexao.dataReader["PVENDA"].ToString());
                dgv_resultado_pesquisa.Rows[o].Cells["IDDEPTO"].Value       = conexao.dataReader["IDDEPTO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["DEPARTAMENTO"].Value  = conexao.dataReader["DEPARTAMENTO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["IDSECAO"].Value       = conexao.dataReader["IDSECAO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["SECAO"].Value         = conexao.dataReader["SECAO"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["NS"].Value            = conexao.dataReader["NS"].ToString();
                dgv_resultado_pesquisa.Rows[o].Cells["OBS"].Value           = conexao.dataReader["OBS"].ToString();

                dgv_resultado_pesquisa.DefaultCellStyle.ForeColor = Color.Black;



                o++;
            }


            conexao.Fecha_Conexao();

        }

        public override void gravar_Registro()
        {

            if (tboxDescricao.Text == "")
            {
                MessageBox.Show("Campo DESCRICAO é obrigatorio.", "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tboxDescricao.Focus();
                return;
            }
            if (tboxcodAuxiliar.Text == "")
            {
                MessageBox.Show("Campo CODAUXILIAR é obrigatorio.", "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tboxcodAuxiliar.Focus();
                return;
            }
            if (tboxSecao.Text == "")
            {
                MessageBox.Show("Campo seção é obrigatorio.", "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            try
            {
                if (tboxmatricula.Text == "")
                {
                    #region INSERT
                    conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = "INSERT INTO TBPRODUTO   " +
                                                      "(DESCRICAO     " +
                                                      ",CODAUXILIAR   " +
                                                      ",MEDIDA        " +
                                                      ",PCUSTO        " +
                                                      ",ESTOQUE       " +
                                                      ",IMG           " +
                                                      ",IDSECAO       " +
                                                      ",PVENDA        " +
                                                      ",TIPO          " +
                                                      ",NS            " +
                                                      ",OBS)           " +
                                                      "VALUES         " +
                                                      "(@DESCRICAO    " +
                                                      ",@CODAUXILIAR  " +
                                                      ",@MEDIDA       " +
                                                      ",@PCUSTO       " +
                                                      ",@ESTOQUE      " +
                                                      ",@IMG          " +
                                                      ",@IDSECAO      " +
                                                      ",@PVENDA       " +
                                                      ",@TIPO         " +
                                                      ",@NS           " +
                                                      ",@OBS)         ";


                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.Parameters.AddWithValue("DESCRICAO", tboxDescricao.Text);
                    conexao.cmd.Parameters.AddWithValue("CODAUXILIAR", tboxcodAuxiliar.Text);
                    conexao.cmd.Parameters.AddWithValue("MEDIDA", tboxMedida.Text);
                    conexao.cmd.Parameters.AddWithValue("PCUSTO", Conversor.converterMoeda(tboxPrecoCusto.Text));
                    conexao.cmd.Parameters.AddWithValue("ESTOQUE", Conversor.converterMoeda(tboxEstoque.Text));
                    conexao.cmd.Parameters.AddWithValue("IMG",     destinationFile);
                    conexao.cmd.Parameters.AddWithValue("IDSECAO", idSecao);
                    conexao.cmd.Parameters.AddWithValue("PVENDA", Conversor.converterMoeda(tboxVenda.Text));
                    conexao.cmd.Parameters.AddWithValue("TIPO",   cboxTipo.Text);
                    conexao.cmd.Parameters.AddWithValue("NS",     tboxNumSerio.Text);
                    conexao.cmd.Parameters.AddWithValue("OBS",     tboxObs.Text);


                    conexao.cmd.ExecuteNonQuery();

                    salvaImagem();

                    MessageBox.Show("Cadastro realizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conexao.Fecha_Conexao();
                    #endregion
                }
                else
                {
                    #region UPDATE
                    conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = "UPDATE TBPRODUTO SET " +
                                                      " DESCRICAO   = @DESCRICAO    " +
                                                      ",CODAUXILIAR = @CODAUXILIAR  " +
                                                      ",MEDIDA      = @MEDIDA       " +
                                                      ",PCUSTO      = @PCUSTO       " +
                                                      ",ESTOQUE     = @ESTOQUE      " +
                                                      ",IMG         = @IMG      " +
                                                      ",IDSECAO     = @IDSECAO      " +
                                                      ",PVENDA      = @PVENDA        " +
                                                      ",TIPO        = @TIPO        " +
                                                      ",NS          = @NS        " +
                                                      ",OBS         = @OBS        " +
                                                      " WHERE  ID = " + tboxmatricula.Text;



                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;
                    conexao.cmd.Parameters.AddWithValue("DESCRICAO", tboxDescricao.Text);
                    conexao.cmd.Parameters.AddWithValue("CODAUXILIAR", tboxcodAuxiliar.Text);
                    conexao.cmd.Parameters.AddWithValue("MEDIDA", tboxMedida.Text);
                    conexao.cmd.Parameters.AddWithValue("PCUSTO", Conversor.converterMoeda(tboxPrecoCusto.Text));
                    conexao.cmd.Parameters.AddWithValue("ESTOQUE", Conversor.converterMoeda(tboxEstoque.Text));
                    conexao.cmd.Parameters.AddWithValue("IMG", destinationFile);
                    conexao.cmd.Parameters.AddWithValue("IDSECAO", idSecao);
                    conexao.cmd.Parameters.AddWithValue("PVENDA", Conversor.converterMoeda(tboxVenda.Text));
                     conexao.cmd.Parameters.AddWithValue("TIPO",   cboxTipo.Text);
                    conexao.cmd.Parameters.AddWithValue("NS",     tboxNumSerio.Text);
                    conexao.cmd.Parameters.AddWithValue("OBS",     tboxObs.Text);
                    conexao.cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro Atualizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conexao.Fecha_Conexao();

                    #endregion
                }

                limpar_Campos();

            }
            catch (Exception ex)
            {

                string frase = ex.Message;
                string palavra = "UNIQUE";

                if (frase.Contains(palavra))
                {
                    MessageBox.Show("Código auxiliar já cadastrado", "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(ex.Message, "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public override void editar_Registro()
        {
            try
            {
                tboxmatricula.Text     = dgv_resultado_pesquisa.CurrentRow.Cells["ID"].Value.ToString();
                tboxDescricao.Text     = dgv_resultado_pesquisa.CurrentRow.Cells["DESCRICAO"].Value.ToString();
                tboxcodAuxiliar.Text   = dgv_resultado_pesquisa.CurrentRow.Cells["CODAUXILIAR"].Value.ToString();
                tboxMedida.Text        = dgv_resultado_pesquisa.CurrentRow.Cells["MEDIDA"].Value.ToString();
                tboxPrecoCusto.Text    = dgv_resultado_pesquisa.CurrentRow.Cells["PCUSTO"].Value.ToString();
                tboxEstoque.Text       = dgv_resultado_pesquisa.CurrentRow.Cells["ESTOQUE"].Value.ToString();
                tboxVenda.Text         = dgv_resultado_pesquisa.CurrentRow.Cells["PVENDA"].Value.ToString();
                idSecao                = dgv_resultado_pesquisa.CurrentRow.Cells["IDSECAO"].Value.ToString();
                idDepto                = dgv_resultado_pesquisa.CurrentRow.Cells["IDDEPTO"].Value.ToString();
                tboxSecao.Text         = dgv_resultado_pesquisa.CurrentRow.Cells["IDSECAO"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["SECAO"].Value.ToString();
                tbox_Departamento.Text = dgv_resultado_pesquisa.CurrentRow.Cells["IDDEPTO"].Value.ToString() + " - " + dgv_resultado_pesquisa.CurrentRow.Cells["DEPARTAMENTO"].Value.ToString();
                cboxTipo.Text          = dgv_resultado_pesquisa.CurrentRow.Cells["TIPO"].Value.ToString();
                tboxNumSerio.Text      = dgv_resultado_pesquisa.CurrentRow.Cells["NS"].Value.ToString();
                tboxObs.Text           = dgv_resultado_pesquisa.CurrentRow.Cells["OBS"].Value.ToString();

                pboxIMG.ImageLocation = Application.StartupPath + @"\IMG_PRODUTO\" + tboxmatricula.Text + ".jpg";
                file.FileName = Application.StartupPath + @"\IMG_PRODUTO\" + tboxmatricula.Text + ".jpg";
                tabControl1.SelectedTab = tabPage1;
                calcularLucro();
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
                    string SQLCunsultaEmpr = "UPDATE TBPRODUTO SET DTEXCLUSAO = '" + DateTime.Now + "' WHERE ID = " + id_registro;



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
            tboxDescricao.Clear();
            tboxcodAuxiliar.Clear();
            tboxMedida.Text = "UN";
            tboxPrecoCusto.Clear();
            tboxEstoque.Clear();
            tboxVenda.Clear();
            tboxLucro.Clear();
            tbox_Departamento.Clear();
            tboxSecao.Clear();
            idSecao = null;
            idDepto = null;
            tboxObs.Clear();
            tboxNumSerio.Clear();
            pboxIMG.ImageLocation = Application.StartupPath + @"\IMG_PRODUTO\semImagem.jpg";

        }

        private void calcularLucro()
        {
            try
            {
                decimal custo = Convert.ToDecimal(tboxPrecoCusto.Text);
                decimal pvenda = Convert.ToDecimal(tboxVenda.Text);
                decimal lucro;

                lucro = ((pvenda * 100) / custo) - 100;

                tboxLucro.Text = Conversor.converterMoeda(Convert.ToString(lucro));
                tboxLucroRS.Text = Conversor.converterMoeda(Convert.ToString(pvenda - custo));
            }
            catch (Exception)
            {
             
            }
          
        }

        public override void relatorio1()
        {
            try
            {
                frm_Relatorio a = new frm_Relatorio();
                a.Arquivo_rdlc = "Rpv_Produto.rdlc";
                a.Sql_Relatorio = this.SQLCunsultaEmpr;
                a.Dataset_Relatorio1 = "DataSet_Produto";
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
                a.Arquivo_rdlc = "Rpv_Produto_Tabela_Preco.rdlc";
                a.Sql_Relatorio = this.SQLCunsultaEmpr;
                a.Dataset_Relatorio1 = "DataSet_Produto";
                a.ShowDialog();
            }
            catch (Exception)
            {


            }
        }
        
        private void tboxPrecoCusto_Leave(object sender, EventArgs e)
        {
              tboxPrecoCusto.Text = Conversor.converterMoeda(tboxPrecoCusto.Text);
              calcularLucro();
        }

        private void tboxEstoque_Leave(object sender, EventArgs e)
        {
            tboxEstoque.Text = Conversor.converterMoeda(tboxEstoque.Text);
        }

        private void tboxVenda_Leave(object sender, EventArgs e)
        {
            tboxVenda.Text = Conversor.converterMoeda(tboxVenda.Text);
            calcularLucro();
        }

        private void frm_Produto_Load(object sender, EventArgs e)
        {
            Iniciar_Form();
        }

        private void pboxIMG_Click(object sender, EventArgs e)
        {
            file.Filter = "JPG|*.jpg|PNG|*.png";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pboxIMG.ImageLocation = file.FileName;
                salvaImagem();
            }
        }

        private void salvaImagem()
        {
            if (System.IO.File.Exists(Application.StartupPath + @"\IMG_PRODUTO\" + tboxmatricula.Text + ".jpg"))
            {

                try
                {
                    System.IO.File.Delete(Application.StartupPath + @"\IMG_PRODUTO\" + tboxmatricula.Text + ".jpg");
                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message, "1");
                    return;
                }

            }
            try
                {
                    sourceFile = file.FileName;
                    destinationFile = Application.StartupPath + @"\IMG_PRODUTO\" + tboxmatricula.Text + ".jpg";

                    // Para mover um arquivo ou pasta para um novo local:
                    System.IO.File.Copy(sourceFile, destinationFile);

                  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "2");
                    return;

                }
            
        }

        private void btn_PesquisarGrupo_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR SEÇÃO";
            a.RotinaOrigem = lbl_NomeRotina.Text;
            a.ShowDialog();
        }

        private void tboxLucro_Leave(object sender, EventArgs e)
        {
            calcularLucro();
        }
    }
}
