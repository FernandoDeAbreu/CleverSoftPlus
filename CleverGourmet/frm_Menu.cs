using System;
using System.Drawing;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CleverSoft
{
    public partial class frm_Menu : Form
    {
        ConexaoLicenca Licenca = new ConexaoLicenca();
        Conexao conexao = new Conexao();

        string dtInstalacao;
        string nomeLicenca;
        string qtdVendasPermitidas;
        string email;
        string totalVendas;
        string serialHD;
        string chaveAtivacao;
        int o = 0;

        string sourceFile;
        string destinationFile;
        public int idFunc ;
        public string nomeFunc ;
        public int idFilial;
        public string nomeFilial;
        string versaoSistama = "2.4.9";

        public frm_Menu()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - 30);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

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
           conexao.Abre_Conexao();
           string SQLCunsultaEmpr = "SELECT COUNT(ID) FROM TBVENDA";



            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();

            int o = 0;


            while (conexao.dataReader.Read())
            {
                totalVendas = conexao.dataReader[0].ToString();
                o++;
            }


            conexao.Fecha_Conexao();
        }

        private void licenca()
        {
            getTotalVendas();
            GetVolumeSerial();
            string hd = "";
            Licenca.Abre_Conexao();

            string SQLCunsultaEmpr = "SELECT * FROM TBLICENCA";



            Licenca.cmd.Connection = Licenca.conexao;
            Licenca.cmd.CommandText = SQLCunsultaEmpr;

            Licenca.cmd.ExecuteNonQuery();
            Licenca.adapter.SelectCommand = Licenca.cmd;
            Licenca.adapter.Fill(Licenca.dataSet, "PCPRODUT");
            Licenca.dataReader = Licenca.cmd.ExecuteReader();

           
            while (Licenca.dataReader.Read())
            {

                dtInstalacao   = Licenca.dataReader[1].ToString();
                qtdVendasPermitidas     = Licenca.dataReader[2].ToString();
                nomeLicenca  = Licenca.dataReader[3].ToString();
                email        = Licenca.dataReader[4].ToString();
                hd           = Licenca.dataReader[5].ToString();
                chaveAtivacao = Licenca.dataReader[6].ToString();

            }
        
            if (hd == "") // Verifica se o campo hd esta limpo, se tiver limpor é o primeiro usu.
            {
                #region INSERT
                Licenca.Abre_Conexao();
                string insert = "UPDATE TBLICENCA SET " +
                                                   "HD    = @HD     " +
                                                  " WHERE  ID = 1";

                Licenca.cmd.Connection = Licenca.conexao;
                Licenca.cmd.CommandText = insert;
                Licenca.cmd.Parameters.AddWithValue("HD", serialHD);
                Licenca.cmd.ExecuteNonQuery();

                Licenca.Fecha_Conexao();
                #endregion
            }

            if (chaveAtivacao != "")
            {
                linkLabel1.Visible = false;
            }

           if (Convert.ToInt32(totalVendas) >= Convert.ToInt32(qtdVendasPermitidas))
            {
                frm_Licenca a = new frm_Licenca();
                a.versaoSistema = this.versaoSistama;
                a.nomeLicenca = this.nomeLicenca;
                a.emailLicenca = this.email;
                a.ShowDialog();
                Application.Exit();
            }

            if (serialHD != hd)
            {
                frm_Licenca a = new frm_Licenca();
                a.versaoSistema = this.versaoSistama;
                a.nomeLicenca = this.nomeLicenca;
                a.emailLicenca = this.email;
                a.ShowDialog();
                Application.Exit();
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

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
        
        }

        private void Iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Iconmaximizar_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
            this.Size = new System.Drawing.Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - 30);
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }
        private void Iconrestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1000, 600);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2, (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }
        private void Iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        public void AbrirFormEnPanel(object Formhijo)
        {
            Form fh = Formhijo as Form;
            fh.ShowDialog();
        }
        private void Frm_Menu_Load(object sender, EventArgs e)
        {
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
            lbl_Usuario.Text = "Usuário: " + nomeFunc;
            lbl_Empresa.Text = nomeFilial;
            lbl_versa.Text = "v." + versaoSistama + " A";
            pboxImagemSistema.ImageLocation = Application.StartupPath + @"\imagemSistema.png";
            licenca();
        }
        private void Btn_Usuario_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frm_Funcionario());

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            o++;
           
        }
        private void Btn_pdvGourmet_Click(object sender, EventArgs e)
        {
            frm_PDV a = new frm_PDV();
            a.idFunc = this.idFunc;
            a.lbl_Funcionario.Text = "Operador: " + Convert.ToString(idFunc) + " - " + nomeFunc; 
            a.ShowDialog();
        }
        private void btn_Categoria_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frm_ContaGerencial());
        }
        private void btn_Moeda_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frm_Moeda());
        }
        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Cliente.frmPesquisarCliente());

        }
        private void btn_Mesa_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frm_Mesa());

        }
        private void btn_Produto_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frm_Produto());

        }
        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frm_Fornecedor());
        }
        private void btnContasPagar_Click(object sender, EventArgs e)
        {
            frm_ContasReceber a = new frm_ContasReceber();
            a.ShowDialog();
               
        }
        private void btnContasaReceeber_Click(object sender, EventArgs e)
        {
            frm_ContasReceber a = new frm_ContasReceber();
            a.ShowDialog();
        }
        private void btnBancoConta_Click(object sender, EventArgs e)
        {
            frm_BancoConta a = new frm_BancoConta();
            a.ShowDialog();
        }
        private void cobrançaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_MoedaCobranca a = new frm_MoedaCobranca();
            a.ShowDialog();
        }
        private void btn_Sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do sistema", "Clever Sistema",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btn_Backup_Click(object sender, EventArgs e)
        {

            string data = DateTime.Now.ToShortDateString().Replace("/","");
            string hora = DateTime.Now.ToLongTimeString().Replace(":","");


            try
            {
                sourceFile = @"CleverGoumerDB.mdb";

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
        private void btn_TrocarUsuario_Click(object sender, EventArgs e)
        {
          
            System.Diagnostics.Process.Start(@"CleverSoft.exe");
            Application.Exit();
        }
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
           //**** Cadastrar ******

            if (e.Node.Text == "Cliente")
            {
                AbrirFormEnPanel(new Cliente.frmPesquisarCliente());
            }
            if (e.Node.Text == "Fornecedor")
            {
                AbrirFormEnPanel(new frm_Fornecedor());
            }
            if (e.Node.Text == "Empresa")
            {
                AbrirFormEnPanel(new frm_Filial());
            }
            if (e.Node.Text == "Produto")
            {
                AbrirFormEnPanel(new frm_Produto());
            }

            if (e.Node.Text == "Funcionário")
            {
                AbrirFormEnPanel(new frm_Funcionario());
            }

            if (e.Node.Text == "Departamento")
            {
                AbrirFormEnPanel(new frm_Departamento());
            }
            if (e.Node.Text == "Seção")
            {
                AbrirFormEnPanel(new frm_Secao());
            }

            if (e.Node.Text == "Permissões")
            {
              //  AbrirFormEnPanel(new frm_Permissao(this));
            }
            
            //**** Consulta ******

            if (e.Node.Text == "Preço")
            {
                frm_ProdutoConsultar a = new frm_ProdutoConsultar();
                a.ShowDialog();
            }

            //**** Compras ******

            if (e.Node.Text == "Entrada de Mercadoria")
            {
                frm_PedidoCompra a = new frm_PedidoCompra();
                a.idFunc = this.idFunc;
                a.ShowDialog();
            }

         
            //**** Financeiro ******


            if (e.Node.Text == "Banco / Conta")
            {
                AbrirFormEnPanel(new frm_BancoConta());
            }
            if (e.Node.Text == "Moeda")
            {
                AbrirFormEnPanel(new frm_Moeda());
            }
            if (e.Node.Text == "Cobrança")
            {
                AbrirFormEnPanel(new frm_MoedaCobranca());
            }
            if (e.Node.Text == "Grupo de conta gerencial")
            {
                AbrirFormEnPanel(new frm_ContaGerencialGrupo());
            }
            if (e.Node.Text == "Conta gerencial")
            {
                AbrirFormEnPanel(new frm_ContaGerencial());
            }
            if (e.Node.Text == "Contas a pagar")
            {
                frm_ContasPagar a = new frm_ContasPagar();
                a.ShowDialog();
            }
            if (e.Node.Text == "Contas a receber")
            {
                frm_ContasReceber a = new frm_ContasReceber();
                a.ShowDialog();
            }

            //**** Venda ******

            if (e.Node.Text == "Tela de Vendas (PDV)")
            {
                frm_PDV a = new frm_PDV();
                a.idFunc = this.idFunc;
                a.lbl_Funcionario.Text = "Operador: " + Convert.ToString(idFunc) + " - " + nomeFunc;
                a.ShowDialog();
            }
            if (e.Node.Text == "Histórico de Vendas")
            {
                frm_HistoricoVendas a = new frm_HistoricoVendas();
                a.ShowDialog();
            }
            

            //**** Sistema ******
            if (e.Node.Text == "Configuração")
            {
                AbrirFormEnPanel(new frm_Configuracao());
                pboxImagemSistema.ImageLocation = Application.StartupPath + @"\imagemSistema.png";

            }

            if (e.Node.Text == "Atualização")
            {
                try
                {
                    System.Diagnostics.Process.Start("chrome.exe", "https://drive.google.com/drive/folders/1J3neytPhfcDTk1w8BWyuFwvNKuI0AJHY?usp=sharing");
                }
                catch (Exception)
                {
                    MessageBox.Show("É nescessário o google chrome instalado");
                }
            }

            if (e.Node.Text == "Trocar de usuário")
            {
                System.Diagnostics.Process.Start(@"CleverSoft.exe");
                Application.Exit();
            }

            if (e.Node.Text == "Suporte")
            {
                frm_Suporte a = new frm_Suporte();
                a.ShowDialog();
            }

            if (e.Node.Text == "Licença")
            {
                frm_Licenca a = new frm_Licenca();
                a.versaoSistema = this.versaoSistama;
                a.ShowDialog();
            }

            if (e.Node.Text == "Backup")
            {
                backup();
            }

            if (e.Node.Text == "Fechar sistema")
            {
                if (MessageBox.Show("Deseja sair do sistema", "Clever Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
        private void btn_Configuracao_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frm_Configuracao());
            pboxImagemSistema.ImageLocation = Application.StartupPath + @"\imagemSistema.png";

        }

        private void frm_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("chrome.exe", "https://mpago.la/1HFCcQW");
            }
            catch (Exception)
            {
                MessageBox.Show("É nescessário o google chrome instalado");
            }
        }
    }
}
