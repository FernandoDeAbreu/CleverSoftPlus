using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Management;
namespace CleverSoft
{
    public partial class frm_Licenca : ModeloSimples
    {
        public string versaoSistema;
        public string nomeLicenca;
        public string emailLicenca;
        public string dataInstalacao;
        string idInstall;
        string serialHD;
        ConexaoLicenca Licenca = new ConexaoLicenca();
        
        //*********** LOGICA DA LICENÇA *****************//
        // A Data da instalação é misturado com letras aleatorias
        // A chave de ativação tambem é letras e numeros misturados
        // é feita uma subtração entre os numeros do ID de instalão com a Chave de Instalação
        // o Resultado precisa Dá 2020 para grava no banco a nova chave.


        public frm_Licenca()
        {
            InitializeComponent();
        }
        
        public void GetVolumeSerial()
        {
            string strDriveLetter = "";
           
                if (strDriveLetter == "" || strDriveLetter == null) strDriveLetter = "C";
                ManagementObject disk = new ManagementObject("win32_logicaldisk.deviceid=\"" + strDriveLetter + ":\"");

                disk.Get();
               serialHD = disk["VolumeSerialNumber"].ToString();
            
        }

        private void seperarLetraNumeros()
        {

            idInstall = "";
            string chaveInstall = "";
            string pr = tboxIDinstalação.Text; 
            string string_numeros = tboxIDinstalação.Text;
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

            pr = tboxChave.Text;
            string string_numeros2 = tboxChave.Text;
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


            try
            {
                if (chaveInstall == idInstall+2020)
                {
                    ativar();
                }
                else
                {
                    MessageBox.Show("Não é uma chave Valída", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao ativar o produto", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void licenca()
        {
            GetVolumeSerial();

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
                dataInstalacao = Licenca.dataReader["DTINSTALACAO"].ToString();
                nomeLicenca = Licenca.dataReader["NOME"].ToString();
                emailLicenca = Licenca.dataReader["EMAIL"].ToString();
                tboxIDinstalação.Text = Licenca.dataReader["DTINSTALACAO"].ToString();
                tboxChave.Text = Licenca.dataReader["CHAVE"].ToString();
            }


            tboxEmail.Text = emailLicenca;
            tboxNome.Text = nomeLicenca;
            
            tboxIDinstalação.Text = "CLEVER" + serialHD;


            Licenca.Fecha_Conexao();
        }

        private void ativar()
        {
            #region INSERT
            Licenca.Abre_Conexao();
            string insert = "UPDATE TBLICENCA SET " +
                                               "DTINSTALACAO    = @DTINSTALACAO     " +
                                              ",QTDVENDAPERMITIDAS    = @QTDVENDAPERMITIDAS     " +
                                              ",NOME            = @NOME     " +
                                              ",EMAIL           = @EMAIL     " +
                                              ",HD              = @HD     " +
                                              ",CHAVE           = @CHAVE     " +
                                              " WHERE  ID = 1";

            Licenca.cmd.Connection = Licenca.conexao;
            Licenca.cmd.CommandText = insert;
            Licenca.cmd.Parameters.AddWithValue("DTINSTALACAO", DateTime.Now.ToShortDateString());
            Licenca.cmd.Parameters.AddWithValue("VALIDADEDIAS", "99999999");
            Licenca.cmd.Parameters.AddWithValue("NOME",         tboxNome.Text);
            Licenca.cmd.Parameters.AddWithValue("EMAIL",        tboxEmail.Text);
            Licenca.cmd.Parameters.AddWithValue("HD",           serialHD);
            Licenca.cmd.Parameters.AddWithValue("CHAVE",        tboxChave.Text);
            Licenca.cmd.ExecuteNonQuery();

            MessageBox.Show("Parabéns seu sistema foi ativado com sucesso.","Clever Sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            frmLogin a = new frmLogin();
            a.Show();
            this.Close();
            Licenca.Fecha_Conexao();
            #endregion
        }

        private void frm_Licenca_Load(object sender, EventArgs e)
        {
            licenca();

            richTextBox1.Text = "Clever Sistemas 2021 \n" +
                "Versão " + versaoSistema + "\n" +
                "Copyright " + DateTime.Now.Year + " Fernando Abreu. \n" +
                "Todos os direitos reservados. \n" +
                "\n" +
                "\n" +
                "\n" +
                "LICENCIADO PARA: \n" +
                ""+ nomeLicenca + "\n" +
                ""+ emailLicenca + "";
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            if (tboxNome.Text == "")
            {
                MessageBox.Show("Campo nome deve ser preenchido", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tboxEmail.Text == "")
            {
                MessageBox.Show("Campo email deve ser preenchido", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tboxChave.Text == "")
            {
                MessageBox.Show("Campo Chave de Ativação deve ser preenchido", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            seperarLetraNumeros();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("chrome.exe", "https://api.whatsapp.com/send?phone=5599981227775&text=Ol%C3%A1%20tudo%20bem%3F%20Estou%20na%20tela%20de%20ativa%C3%A7%C3%A3o%20e%20gostaria%20de%20ajuda.");
            }
            catch (Exception)
            {
                MessageBox.Show("É nescessário o google chrome instalado");
            }
        }
    }
}
