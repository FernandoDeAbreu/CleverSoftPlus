using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverSoft
{
    public partial class frm_Menux : Form
    {

        ConexaoLicenca Licenca = new ConexaoLicenca();
        Conexao conexao = new Conexao();
      
        string dtInstalacao;
        string nomeLicenca;
        string email;

        string totalCadastroPermitidos;
        string totalVendas;
        string totalProdutos;

        string serialHD;
        string chaveAtivacao;
        int o = 0;

        string sourceFile;
        string destinationFile;
        public int idFunc;
        public string nomeFunc;
        public int idFilial;
        public string nomeFilial;
       

        public frm_Menux()
        {
            InitializeComponent();
            // Essas linhas eliminam a oscilação do formulário ou controles na interface gráfica (mas não 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
           
        }

        #region layout do Form 
        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema", "Clever Sistema", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //METODOS PARA CERRAR,MAXIMIZAR, MINIMIZAR FORMULARIO------------------------------------------------------
        int lx, ly;
        int sw, sh;

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void frm_Menux_Load(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconmaximizar.Visible = false;
            iconrestaurar.Visible = true;


            lbl_NomeUsuario.Text =  nomeFunc;
            lbl_Empresa.Text = nomeFilial;
            pboxImagemSistema.ImageLocation = Application.StartupPath + @"\imagemSistema.png";
            
           

          

            licenca();
            verificapermissoes();
        }

        // /METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------

        #endregion

        public static void abrirNavegador(string x)
        {
            if (MessageBox.Show("Você será redirecionado para o site de sistema. Deseja continuar?", "Clever Sistema") == DialogResult.Yes)
            {
                // System.Diagnostics.Process.Start("cmd", "/C start" + " " + x);
                //try
                //{
                    System.Diagnostics.Process.Start("chrome.exe", x);
                //}
                //catch (Exception)
                //{

                //}
            }
        }
        private void verificapermissoes()
        {
            int cad = 0;
            foreach (ToolStripItem botao in Cadastrar.Items)
            {
               conexao.Abre_Conexao();
               string SQLCunsultaEmpr = "SELECT * FROM TBPERMISSAO WHERE IDFUNC = '" + idFunc + "' AND NOMEROTINA = '" + botao.Text + "'";

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
                   cad++;

                }

                if ( o == 0)
                {
                    botao.Visible = false;
                }
               
                conexao.Fecha_Conexao();
            }
            if (cad <= 0)
            {
                btn_Cadastrar.Visible = false;
            }

            int fin = 0;
            foreach (ToolStripItem botao in Financeiro.Items)
            {
                conexao.Abre_Conexao();
                string SQLCunsultaEmpr = "SELECT * FROM TBPERMISSAO WHERE IDFUNC = '" + idFunc + "' AND NOMEROTINA = '" + botao.Text + "'";

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
                    fin++;
                }

                if (o == 0)
                {
                    botao.Visible = false;
                }

                conexao.Fecha_Conexao();
            }
            if (fin <= 0)
            {
                btn_Financeiro.Visible = false;
            }

            int sis = 0;
            foreach (ToolStripItem botao in Sistema.Items)
            {
                if (botao.Text != "")
                 conexao.Abre_Conexao();
                string SQLCunsultaEmpr = "SELECT * FROM TBPERMISSAO WHERE IDFUNC = '" + idFunc + "' AND NOMEROTINA = '" + botao.Text + "'";

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
                    sis++;
                }

                if (o == 0)
                {
                    botao.Visible = false;
                }

                conexao.Fecha_Conexao();
            }
            if (sis <= 0)
            {
                btn_Sistema.Visible = false;
            }

            int sai = 0;
            foreach (ToolStripItem botao in Sair.Items)
            {
                conexao.Abre_Conexao();
                string SQLCunsultaEmpr = "SELECT * FROM TBPERMISSAO WHERE IDFUNC = '" + idFunc + "' AND NOMEROTINA = '" + botao.Text + "'";

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
                    sai++;
                }

                if (o == 0)
                {
                    botao.Visible = false;
                }

                conexao.Fecha_Conexao();
            }
            if (sai <= 0)
            {
                btn_Sair.Visible = false;
            }

        }
        public void GetVolumeSerial()
        {
            string strDriveLetter = "";

            if (strDriveLetter == "" || strDriveLetter == null) strDriveLetter = "C";
            ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + strDriveLetter + ":\"");

            disk.Get();
            serialHD = disk["VolumeSerialNumber"].ToString();

        }
        private void getTotalVendas()
        {
           string SQLCunsultaEmpr;
           conexao.Abre_Conexao();

            SQLCunsultaEmpr = "SELECT COUNT(ID) FROM TBVENDA";
            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;
            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();
            while (conexao.dataReader.Read())
            {
                totalVendas = conexao.dataReader[0].ToString();
            }

            conexao.Fecha_Conexao();



            conexao.Abre_Conexao();
            SQLCunsultaEmpr = "SELECT COUNT(ID) FROM TBPRODUTO";
            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;
            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();
            while (conexao.dataReader.Read())
            {
                totalProdutos = conexao.dataReader[0].ToString();
            }

            conexao.Fecha_Conexao();
        }
        private void licenca()
        {
            getTotalVendas();
            GetVolumeSerial();
            string hd = "";
            Licenca.Abre_Conexao();

            string SQLCunsultaEmpr = "SELECT ID, DTINSTALACAO, QTDVENDAPERMITIDAS, NOME, EMAIL, HD, CHAVE, QTDEUSUARIO FROM TBLICENCA";



            Licenca.cmd.Connection = Licenca.conexao;
            Licenca.cmd.CommandText = SQLCunsultaEmpr;

            Licenca.cmd.ExecuteNonQuery();
            Licenca.adapter.SelectCommand = Licenca.cmd;
            Licenca.adapter.Fill(Licenca.dataSet, "PCPRODUT");
            Licenca.dataReader = Licenca.cmd.ExecuteReader();

           
            while (Licenca.dataReader.Read())
            {

                dtInstalacao            = Licenca.dataReader[1].ToString();
                totalCadastroPermitidos     = Licenca.dataReader[2].ToString();
                nomeLicenca             = Licenca.dataReader[3].ToString();
                email                   = Licenca.dataReader[4].ToString();
                hd                      = Licenca.dataReader[5].ToString();
                chaveAtivacao           = Licenca.dataReader[6].ToString();

            }
        
           
                #region INSERT
                Licenca.Abre_Conexao();
                string insert = "UPDATE TBLICENCA SET " +
                                                   "DTINSTALACAO = @DTINSTALACAO,     " +
                                                   "HD           = @HD     " +
                                                  " WHERE  ID = 1";

                Licenca.cmd.Connection = Licenca.conexao;
                Licenca.cmd.CommandText = insert;
                Licenca.cmd.Parameters.AddWithValue("DTINSTALACAO", DateTime.Now.ToShortDateString());
                Licenca.cmd.Parameters.AddWithValue("HD", serialHD);

                Licenca.cmd.ExecuteNonQuery();

                Licenca.Fecha_Conexao();
                #endregion

            string idInstall = "";
            string chaveInstall = "";
            string pr = "CLEVER" + hd; 
            string string_numeros = "CLEVER" + hd; 
            int somatorio = 0;
            foreach (char s in pr)
            {
                if (Char.IsDigit(s))
                {
                    string_numeros += s;
                    somatorio += Convert.ToInt32(Convert.ToString(s));
                    idInstall = idInstall + s;
                }

            }

            pr = chaveAtivacao;
            string string_numeros2 = chaveAtivacao;
            int somatorio2 = 0;
            foreach (char s in pr)
            {
                if (Char.IsDigit(s))
                {
                    string_numeros2 += s;
                    somatorio2 += Convert.ToInt32(Convert.ToString(s));
                    chaveInstall = chaveInstall + s;

                }

            }


            
          
                       
           if (Convert.ToInt32(totalVendas) >= Convert.ToInt32(totalCadastroPermitidos))
            {
                MessageBox.Show("Você atingiu o limente de vendas para a versão de teste, compre a versão completa para continuar usando o sistema", "Clever Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_Licenca a = new frm_Licenca();
                a.versaoSistema = this.lbl_versa.Text;
                a.nomeLicenca = this.nomeLicenca;
                a.emailLicenca = this.email;
                a.ShowDialog();
                Application.Exit();
            }

            if (Convert.ToInt32(totalProdutos) >= Convert.ToInt32(totalCadastroPermitidos))
            {
                MessageBox.Show("Você atingiu o limente de cadastros para a versão de teste, compre a versão completa para continuar usando o sistema", "Clever Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_Licenca a = new frm_Licenca();
                a.versaoSistema = this.lbl_versa.Text;
                a.nomeLicenca = this.nomeLicenca;
                a.emailLicenca = this.email;
                a.ShowDialog();
                Application.Exit();
            }


            if (chaveInstall != idInstall + 2020)
            {
                linkLabel1.Visible = true;
            }

            if (chaveAtivacao == "")
            {
                linkLabel1.Visible = true;
            }

            if (serialHD != hd)
            {
                linkLabel1.Visible = true;
            }

            Licenca.Fecha_Conexao();
        }
        private void backup()
        {
            string data = DateTime.Now.ToShortDateString().Replace("/", "");
            string hora = DateTime.Now.ToLongTimeString().Replace(":", "");


            try
            {
                sourceFile = @"CleverDB.s3db";

                destinationFile = Application.StartupPath + @"\BKP_SYSTEM\BKP_" + data + "_" + hora;

                // Para mover um arquivo ou pasta para um novo local:
                System.IO.File.Copy(sourceFile, destinationFile);

                //    gravarFoto();
                MessageBox.Show("Beckup realizado com sucesso!", "Clever Sistema");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;

            }
        }
        private void AbrirFormEnPanel(object formHijo)
        {
            //if (this.panelContenedorForm.Controls.Count > 0)
            //    this.panelContenedorForm.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            //fh.TopLevel = false;
            //fh.FormBorderStyle = FormBorderStyle.None;
            //fh.Dock = DockStyle.Fill;
            //this.panelContenedorForm.Controls.Add(fh);
            //this.panelContenedorForm.Tag = fh;
            fh.ShowDialog();
        }
        //METODO PARA MOSTRAR FORMULARIO DE LOGO Al CERRAR OTROS FORM ----------------------------------------------------------
        private void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            //frm_Pagina_Inicial();
        }
        private void btnProduto_Click(object sender, EventArgs e)
        {
            frm_Produto fm = new frm_Produto();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            Cliente.frmPesquisarCliente fm = new Cliente.frmPesquisarCliente();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btn_Consutar_Produto_Click(object sender, EventArgs e)
        {
            frm_ProdutoConsultar fm = new frm_ProdutoConsultar();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }
       
        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            frm_Fornecedor fm = new frm_Fornecedor();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btn_funcionario_Click(object sender, EventArgs e)
        {
            frm_Funcionario fm = new frm_Funcionario();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btn_Departamento_Click(object sender, EventArgs e)
        {
            frm_Departamento fm = new frm_Departamento();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btn_Secao_Click(object sender, EventArgs e)
        {
            frm_Secao fm = new frm_Secao();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btn_Empresa_Click(object sender, EventArgs e)
        {
            frm_Filial fm = new frm_Filial();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btn_Permissao_Click(object sender, EventArgs e)
        {
            frm_Permissao fm = new frm_Permissao(this);
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }
        private void btnAjustarEstoque_Click(object sender, EventArgs e)
        {
            Produto.frmAjustarEstoque fm = new Produto.frmAjustarEstoque();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            fm.idFunc = idFunc;
            fm.lbl_Funcionario.Text = lbl_NomeUsuario.Text;
            AbrirFormEnPanel(fm);
        }

        private void btn_EntradaMercadoria_Click(object sender, EventArgs e)
        {
            frmDigitaPedidoCompras fm = new frmDigitaPedidoCompras();
            fm.idFunc = this.idFunc;
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btn_PrecificarEntrada_Click(object sender, EventArgs e)
        {
            frmPrecificarEntrada fm = new frmPrecificarEntrada();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btn_HistoricoCompra_Click(object sender, EventArgs e)
        {
            Compras.frmHistoricoCompras fm = new Compras.frmHistoricoCompras();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btn_Banco_Click(object sender, EventArgs e)
        {
            frm_BancoConta fm = new frm_BancoConta();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btn_Moeda_Click(object sender, EventArgs e)
        {
            frm_Moeda fm = new frm_Moeda();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btn_Cobranca_Click(object sender, EventArgs e)
        {
            frm_MoedaCobranca fm = new frm_MoedaCobranca();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btn_GrupoContaGerencial_Click(object sender, EventArgs e)
        {
            frm_ContaGerencialGrupo fm = new frm_ContaGerencialGrupo();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btn_ContaGerencial_Click(object sender, EventArgs e)
        {
            Conta_Gerencial.frmContaGerencial fm = new Conta_Gerencial.frmContaGerencial();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btn_ContaApagar_Click(object sender, EventArgs e)
        {
            CleverSoft.Financeiro.frmFinanceiro fm = new CleverSoft.Financeiro.frmFinanceiro();
            fm.pagarReceber = "CONTAS À PAGAR";
            fm.ShowDialog();

        }

        private void btn_ContasARecener_Click(object sender, EventArgs e)
        {
            CleverSoft.Financeiro.frmFinanceiro fm = new CleverSoft.Financeiro.frmFinanceiro();
            fm.pagarReceber = "CONTAS À RECEBER";
            fm.ShowDialog();
        }

        private void btn_Tranferir_Click(object sender, EventArgs e)
        {
            Financeiro.frm_Transferir fm = new Financeiro.frm_Transferir();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btn_FecharCaixar_Click(object sender, EventArgs e)
        {
            frmFecharCaixa fm = new frmFecharCaixa();
            fm.lbl_Funcionario.Text = Convert.ToString(idFunc) + " - " + nomeFunc;
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btn_Extrato_Click(object sender, EventArgs e)
        {
            frm_ExtratoConta fm = new frm_ExtratoConta();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btnTelaVEnda_Click(object sender, EventArgs e)
        {
            frm_PDV fm = new frm_PDV();
            fm.idFunc = this.idFunc;
            fm.lbl_Funcionario.Text = "Operador: " + Convert.ToString(idFunc) + " - " + nomeFunc;
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btnOrdemServico_Click_1(object sender, EventArgs e)
        {
            Ordem_de_Serviço.frmMonitorOrdemServico fm = new Ordem_de_Serviço.frmMonitorOrdemServico();
            fm.idFunc = this.idFunc;
            fm.lbl_Funcionario.Text = Convert.ToString(idFunc) + " - " + nomeFunc;
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btnNovaOS_Click(object sender, EventArgs e)
        {
            frmOrdemServico fm = new frmOrdemServico();
            fm.idFunc = this.idFunc;
            fm.lbl_Funcionario.Text = Convert.ToString(idFunc) + " - " + nomeFunc;
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btnContribuicao_Click(object sender, EventArgs e)
        {
            Igreja.frmReceberContribuicao fm = new Igreja.frmReceberContribuicao();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }
        private void btn_historicoVenda_Click(object sender, EventArgs e)
        {
            frm_HistoricoVendas fm = new frm_HistoricoVendas();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btn_Configuracao_Click(object sender, EventArgs e)
        {
            frm_Configuracao fm = new frm_Configuracao();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btnTrocaUsuario_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"CleverSoft.exe");
            Application.Exit();
        }

        private void btn_Atualizao_Click(object sender, EventArgs e)
        {
            abrirNavegador("https://clever.infoglobal.com.br/atualizacao/");
        }

        private void btn_Backup_Click(object sender, EventArgs e)
        {
            backup();
        }

        private void btn_Suporte_Click(object sender, EventArgs e)
        {
            frm_Suporte fm = new frm_Suporte();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            
            AbrirFormEnPanel(fm);
        }

        private void btn_Licenca_Click(object sender, EventArgs e)
        {
            frm_Licenca a = new frm_Licenca();
            a.versaoSistema = this.lbl_versa.Text;
            a.ShowDialog();
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconmaximizar.Visible = false;
            iconrestaurar.Visible = true;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void btn_Financeiro_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 3;
        }
        private void btn_RelatorioSede_Click(object sender, EventArgs e)
        {
            Igreja.frmRelatorioSede fm = new Igreja.frmRelatorioSede();
            fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }
        private void btn_Vender_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
        }
        private void panelContenedorPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abrirNavegador("https://clever.infoglobal.com.br/");

        }
        private void frm_Menux_FormClosed(object sender, FormClosedEventArgs e)
        {
           Application.Exit();
        }
        private void frm_Menux_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
        private void btn_OrdemServico_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 7;

        }

        private void btnAbrirCaixar_Click(object sender, EventArgs e)
        {
            int idCaixa;
            conexao.Abre_Conexao();

            string SQLCunsultaEmpr = "SELECT * FROM TBCAIXA WHERE STATUS = 'ABERTO' AND IDFUNC = '" + idFunc + "' AND DATA = '" + Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd") + "'";

            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();

            int o = 0;

            while (conexao.dataReader.Read())
            {
                idCaixa = Convert.ToInt32(conexao.dataReader["ID"].ToString());

                o++;
            }

            if (o == 0)
            {
                frmAbrirCaixa a = new frmAbrirCaixa();
                a.idFunc = idFunc;
                 a.tboxParceiro.Text = lbl_NomeUsuario.Text;
                a.ShowDialog();

            }
            else
            {
                MessageBox.Show("A Caixa de " + DateTime.Now.ToShortDateString() + " para o usuário " + lbl_NomeUsuario.Text + ", já encontra-se aberto.", "Clever Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 

            conexao.Fecha_Conexao();
        }

        private void btn_Sistema_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 6;
        }
    }
}
