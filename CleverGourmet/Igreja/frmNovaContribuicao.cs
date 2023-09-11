using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverSoft.Igreja
{
    public partial class frmNovaContribuicao : Form
    {

        Conexao conexao = new Conexao();
        Conversor converter = new Conversor();
        public string codFilial = "1";
        public string codParceiro;
        public string codContaGerencial;
        string codMoeda;
        string codConta;
        string codCobranca;
        private AutoResetEvent receiveNow;
        string tbMensagem = "Messagem de teste";
        string tbTelefone = "+5599991797079";
        public frmNovaContribuicao()
        {
            InitializeComponent();
        }
        private void carregarCombox_ContaGerencial()
        {

            conexao.Abre_Conexao();

            string SQLCunsultaEmpr = "SELECT * FROM TBCONTAGERENCIAL WHERE STATUS = 'ATIVO' ";



            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;


            DataTable dtResultado = new DataTable();
            dtResultado.Clear();//o ponto mais importante (limpa a table antes de preenche-la)
            cboxMoeda.DataSource = null;
            conexao.adapter.Fill(dtResultado);
            cboxMoeda.DataSource = dtResultado;
            cboxMoeda.ValueMember = "ID";
            cboxMoeda.DisplayMember = "CONTAGERENCIAL";
            cboxMoeda.SelectedItem = "";
            cboxMoeda.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.

            conexao.Fecha_Conexao();
        }
        private void carregarCombox_Cobranca()
        {

            conexao.Abre_Conexao();

            string SQLCunsultaEmpr = "SELECT * FROM TBCOBRANCA WHERE DTEXCLUSAO IS NULL ";



            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;


            DataTable dtResultado = new DataTable();
            dtResultado.Clear();//o ponto mais importante (limpa a table antes de preenche-la)
            cboxFormaPagamento.DataSource = null;
            conexao.adapter.Fill(dtResultado);
            cboxFormaPagamento.DataSource = dtResultado;
            cboxFormaPagamento.ValueMember = "ID";
            cboxFormaPagamento.DisplayMember = "DESCRICAO";
            cboxFormaPagamento.SelectedItem = "";
            cboxFormaPagamento.Refresh(); //faz uma nova busca no BD para preencher os valores da cb de departamentos.

            conexao.Fecha_Conexao();


        }
        private void carregar()
        {
            conexao.Abre_Conexao();

            string sql = "SELECT * FROM TBCOBRANCA WHERE DESCRICAO = '" + cboxFormaPagamento.Text + "'";



            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = sql;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();



            while (conexao.dataReader.Read())
            {
                codCobranca = conexao.dataReader["ID"].ToString();
                codMoeda = conexao.dataReader["IDMOEDA"].ToString();
                codConta = conexao.dataReader["IDCONTA"].ToString();
                label5.Text = conexao.dataReader["ID"].ToString();
                label6.Text = conexao.dataReader["IDMOEDA"].ToString();
                label7.Text = conexao.dataReader["IDCONTA"].ToString();
            }


            conexao.Fecha_Conexao();
        }
        private void cboxFormaPagamento_TextChanged(object sender, EventArgs e)
        {
            carregar();
        }
        private void pesquisar_ContaGerencialPadrao()
        {

            conexao.Abre_Conexao();

           string sql = "SELECT VALOR FROM TBPARAMETROS WHERE DESCRICAO = 'CONTA GERENCIAL PARA LANÇAMENTO DE CONTRIBUIÇÕES' ";



            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = sql;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();



            while (conexao.dataReader.Read())
            {
                codContaGerencial = conexao.dataReader[0].ToString();
            }


            conexao.Fecha_Conexao();

        }
        private void gravar_Registro()
        {
            carregar();
            if (Convert.ToDecimal(tboxValor.Text) <= 0)
            {
                MessageBox.Show("Não é possivel lançar o valor informado", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Gravar valor Extensso
           
              string  valor_Extenso = Conversor.EscreverExtenso(Convert.ToDecimal(tboxValor.Text));
           
            //* fim gravar valor Extensso

            try
            {
                
                    #region INSERT
                    conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = " INSERT INTO TBFINANCEIRO " +
                                                    " (TIPO                   " +
                                                    " ,IDFILIAL            " +
                                                    " ,IDPARCEIRO             " +
                                                    " ,IDMOEDA                " +
                                                    " ,IDCONTA                " +
                                                    " ,IDCOBRANCA               " +
                                                    " ,IDCONTAGERENCIAL            " +
                                                    " ,HISTORICO              " +
                                                    " ,NUMDOC                 " +
                                                    " ,DTLANC                 " +
                                                    " ,DTVENC                 " +
                                                    " ,DTPGTO              " +
                                                    " ,DTCOMPETENCIA          " +
                                                    " ,VALOR                  " +
                                                    " ,VLRDESC                " +
                                                    " ,VLRJUROS               " +
                                                    " ,VLRTOTAL               " +
                                                    " ,VLREXTENSO)              " +
                                                    " VALUES                  " +
                                                    " (@TIPO                  " +
                                                    " ,@IDFILIAL              " +
                                                    " ,@IDPARCEIRO            " +
                                                    " ,@IDMOEDA               " +
                                                    " ,@IDCONTA               " +
                                                    " ,@IDCOBRANCA               " +
                                                    " ,@IDCONTAGERENCIAL           " +
                                                    " ,@HISTORICO             " +
                                                    " ,@NUMDOC                " +
                                                    " ,@DTLANC                " +
                                                    " ,@DTVENC                " +
                                                    " ,@DTPGTO                " +
                                                    " ,@DTCOMPETENCIA         " +
                                                    " ,@VALOR                 " +
                                                    " ,@VLRDESC               " +
                                                    " ,@VLRJUROS              " +
                                                    " ,@VLRTOTAL              " +
                                                    " ,@VLREXTENSO)             ";


                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;           
                    conexao.cmd.Parameters.AddWithValue("TIPO",              "R");
                    conexao.cmd.Parameters.AddWithValue("IDFILIAL",          codFilial);
                    conexao.cmd.Parameters.AddWithValue("IDPARCEIRO",        codParceiro);
                    conexao.cmd.Parameters.AddWithValue("IDMOEDA",           codMoeda);
                    conexao.cmd.Parameters.AddWithValue("IDCONTA",           codConta);
                    conexao.cmd.Parameters.AddWithValue("IDCOBRANCA",           codConta);
                    conexao.cmd.Parameters.AddWithValue("IDCONTAGERENCIAL",  codContaGerencial);
                    conexao.cmd.Parameters.AddWithValue("HISTORICO",         "REF.: A CONTRIBUIÇÃO VOLUNTÁRIA (" + cboxMoeda.Text + ")");
                    conexao.cmd.Parameters.AddWithValue("NUMDOC",            "0000");
                    conexao.cmd.Parameters.AddWithValue("DTLANC",            Conversor.converterDataUS(tboxDtLanc.Text));
                    conexao.cmd.Parameters.AddWithValue("DTVENC",            Conversor.converterDataUS(tboxDtLanc.Text));
                    conexao.cmd.Parameters.AddWithValue("DTCOMPETENCIA",     Conversor.converterDataUS(tboxDtLanc.Text));
                    conexao.cmd.Parameters.AddWithValue("DTPGTO",            Conversor.converterDataUS(tboxDtLanc.Text));
                    conexao.cmd.Parameters.AddWithValue("VALOR",             Conversor.converterMoeda(tboxValor.Text));
                    conexao.cmd.Parameters.AddWithValue("VLRDESC",           Conversor.converterMoeda("0,00"));
                    conexao.cmd.Parameters.AddWithValue("VLRJUROS",          Conversor.converterMoeda("0,00"));
                    conexao.cmd.Parameters.AddWithValue("VLRTOTAL",          Conversor.converterMoeda(tboxValor.Text));
                    conexao.cmd.Parameters.AddWithValue("VLREXTENSO",        valor_Extenso);


                    conexao.cmd.ExecuteNonQuery();

                    MessageBox.Show("Cadastro realizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conexao.Fecha_Conexao();
                #endregion
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Clever sistemas", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }




        }
        private void relatorio()
        {
            try
            {
                string SQLCunsultaEmpr = " SELECT                    " +
                                          "  F.ID                    " +
                                          " ,F.IDFILIAL              " +
                                          " ,E.UF                    " +
                                          " ,E.CIDADE                " +
                                          " ,F.TIPO                  " +
                                          " ,F.IDPARCEIRO            " +
                                          " ,P.RAZAOSOCIAL           " +
                                          " ,F.IDMOEDA               " +
                                          " ,M.MOEDA                 " +
                                          " ,F.IDCONTA               " +
                                          " ,C.DESCRICAO AS CONTA    " +
                                          " ,F.IDCONTAGERENCIAL      " +
                                          " ,G.CONTAGERENCIAL        " +
                                          " ,F.HISTORICO             " +
                                          " ,F.NUMDOC                " +
                                          " ,F.DTLANC                " +
                                          " ,F.DTVENC                " +
                                          " ,F.DTCOMPETENCIA         " +
                                          " ,F.DTPGTO                " +
                                          " ,F.VALOR                 " +
                                          " ,F.VLRDESC               " +
                                          " ,F.VLRJUROS              " +
                                          " ,F.VLRTOTAL              " +
                                          " ,F.VLREXTENSO            " +
                                          " ,F.IDVENDA               " +
                                          " FROM                     " +
                                          " TBFINANCEIRO       F,    " +
                                          " TBCONTAGERENCIAL   G,    " +
                                          " TBCONTA            C,    " +
                                          " TBMOEDA            M,    " +
                                          " TBFILIAL           E,    " +
                                          " TBCLIENTE          P     " +
                                          " WHERE                    " +
                                          " F.IDCONTAGERENCIAL = G.ID  AND" +
                                          " F.IDFILIAL    = E.ID  AND" +
                                          " F.IDCONTA = C.ID      AND" +
                                          " F.IDMOEDA = M.ID      AND" +
                                          " F.IDPARCEIRO = P.ID   AND" +
                                          " F.STATUS IS NULL      AND" +
                                          " F.TIPO = 'R'  AND P.ID = " + codParceiro + " AND F.ID = (SELECT MAX(ID)FROM TBFINANCEIRO)";


                frm_PDVComprovante a = new frm_PDVComprovante();
                a.Arquivo_rdlc = "Rpv_Recibo_Dizimo.rdlc";
                a.Sql_Relatorio1 = SQLCunsultaEmpr;

                a.Dataset_Relatorio1 = "DataSet_CR";



                a.ShowDialog();
            }
            catch (Exception)
            {


            }
        }
        private void EnviarModem()
        {
            using (var port = new System.IO.Ports.SerialPort())
            {
                
                port.PortName = "COM10";
                port.Open();
                port.DtrEnable = true;
                port.RtsEnable = true;
                port.Write("AT\r"); // iniciando a comunicação
                port.Write("AT+CMGF=1\r"); // setando a comunicação para o modo texto
                port.Write(string.Format("AT+CMGS=\"{0}\"\r", tbTelefone)); // setando o número do destinatário
                port.Write(tbMensagem + char.ConvertFromUtf32(26)); // enviando a mensagem
            }
        }
        private bool EnviaSms(string numero, string mensagem)
            {
                using (SerialPort serialPort = new SerialPort())
                {
                    bool mensagemEnviada = false;

                    try
                    {
                        receiveNow = new AutoResetEvent(false);
                        serialPort.PortName = "COM10";
                        serialPort.Handshake = Handshake.RequestToSend;
                        serialPort.DtrEnable = true;
                        serialPort.RtsEnable = true;
                        serialPort.NewLine = Environment.NewLine;
                        serialPort.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
                        serialPort.Open();
                        string recievedData = ExecCommand(serialPort, "AT", 300, "Telefone não conectado");
                        recievedData = ExecCommand(serialPort, "AT+CMGF=1", 300, "Falha no formato da mensagem");
                        String command = "AT+CMGS=\"" + numero + "\"";
                        recievedData = ExecCommand(serialPort, command, 300, "Falha no número");
                        command = mensagem + char.ConvertFromUtf32(26) + "\r";
                        recievedData = ExecCommand(serialPort, command, 3000, "Falha ao enviar mensagem");
                        serialPort.Close();
                        if (recievedData.EndsWith("\r\nOK\r\n"))
                        {
                            mensagemEnviada = true;
                        }
                        else if (recievedData.Contains("ERROR"))
                        {
                            mensagemEnviada = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao enviar SMS: " + ex.Message);
                    }
                    return mensagemEnviada;
                }
            }
        private string ExecCommand(SerialPort port, string command, int responseTimeout, string errorMessage)
            {
                try
                {

                    port.DiscardOutBuffer();
                    port.DiscardInBuffer();
                    receiveNow.Reset();
                    port.Write(command + "\r");

                    string input = ReadResponse(port, responseTimeout);
                    if ((input.Length == 0) || ((!input.EndsWith("\r\n> ")) && (!input.EndsWith("\r\nOK\r\n"))))
                        throw new ApplicationException("No success message was received.");
                    return input;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        public string ReadResponse(SerialPort port, int timeout)
            {
                string buffer = string.Empty;
                try
                {
                    do
                    {
                        if (receiveNow.WaitOne(timeout, false))
                        {
                            string t = port.ReadExisting();
                            buffer += t;
                        }
                        else
                        {
                            if (buffer.Length > 0)
                                throw new ApplicationException("A resposta recebida está incompleta.");
                            else
                                throw new ApplicationException("Nenhum dado recebido do telefone.");
                        }
                    }
                    while (!buffer.EndsWith("\r\nOK\r\n") && !buffer.EndsWith("\r\n> ") && !buffer.EndsWith("\r\nERROR\r\n"));
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return buffer;
            }
        public void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
            {
                try
                {
                    if (e.EventType == SerialData.Chars)
                    {
                        receiveNow.Set();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
          this.Close();
          //  EnviarModem();
          
         //  EnviaSms(tbTelefone, tbMensagem);
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
        }
        private void frmNovaContribuicao_Load(object sender, EventArgs e)
        {
            carregarCombox_ContaGerencial();
            carregarCombox_Cobranca();
            pesquisar_ContaGerencialPadrao();
            converter.Moeda(tboxValor);
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja confirmar lançamento?","Clever Sistema",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gravar_Registro();
                relatorio();
            }
        }
        private void tboxValor_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(tboxValor.Text) <= 0)
                {
                    return;
                }

                if (e.KeyCode == Keys.Enter)
                {
                    if (MessageBox.Show("Deseja confirmar lançamento?", "Clever Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        gravar_Registro();
                        relatorio();
                    }
                }
            }
            catch (Exception)
            {

            }
        
        }
        private void cboxFormaPagamento_DisplayMemberChanged(object sender, EventArgs e)
        {
        }
    }
}
