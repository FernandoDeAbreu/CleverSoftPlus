using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CleverSoft
{
    public partial class frmLogin : Form
    {
        private Conexao conexao = new Conexao();
        private AtualizarBancoDados atualizarSistema = new AtualizarBancoDados();

        private int idFunc;
        private string nomeFunc;
        private int idFilial;
        private string nomeFilial;
        private string versaoSistama = "0";
        private string versaoExibir;

        public frmLogin()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void VerificarVersao()
        {
            conexao.Abre_Conexao();

            try
            {
                string SQLCunsultaEmpr = "SELECT * FROM TBVERSAO";

                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;
                conexao.cmd.ExecuteNonQuery();
                conexao.adapter.SelectCommand = conexao.cmd;
                conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
                conexao.dataReader = conexao.cmd.ExecuteReader();

                while (conexao.dataReader.Read())
                {
                    versaoSistama = conexao.dataReader["VERSAO"].ToString();
                }
                versaoExibir = "v.2.5." + versaoSistama + " A";
                this.lbl_Versao.Text = versaoExibir;
            }
            catch (Exception)
            {
                versaoSistama = "0";
            }

            conexao.Fecha_Conexao();
        }

        private void login()
        {
            if (tbox_Usuario.Text == "")
            {
                MessageBox.Show("Informe seu usuário.", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbox_Usuario.Focus();

                return;
            }
            if (tbox_Senha.Text == "")
            {
                MessageBox.Show("Informe sua Senha.", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbox_Senha.Focus();

                return;
            }

            conexao.Abre_Conexao();

            string SQLCunsultaEmpr = "SELECT * FROM TBFUNCIONARIO WHERE DTEXCLUSAO IS NULL AND USUARIO = '" + tbox_Usuario.Text + "' AND SENHA = '" + tbox_Senha.Text + "'";

            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;
            //conexao.cmd.Parameters.AddWithValue("USUARIO", tbox_Usuario.Text);
            //conexao.cmd.Parameters.AddWithValue("SENHA", tbox_Senha.Text);

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();

            int o = 0;

            while (conexao.dataReader.Read())
            {
                idFunc = Convert.ToInt32(conexao.dataReader["ID"].ToString());
                nomeFunc = conexao.dataReader["Nome"].ToString();
                // MessageBox.Show("Seja bem Vindo: " + nomeFunc);
                o++;
            }

            if (o == 1)
            {
                pesquisarEmpresa();
                frm_Menux a = new frm_Menux();
                a.idFunc = this.idFunc;
                a.nomeFunc = this.nomeFunc;
                a.idFilial = this.idFilial;
                a.nomeFilial = this.nomeFilial;
                a.lbl_versa.Text = versaoExibir;

                atualizarSistema.versaoSistema = Convert.ToInt32(this.versaoSistama);
                atualizarSistema.atualizar();

                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha invalidos.", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            conexao.Fecha_Conexao();
        }

        private void pesquisarEmpresa()
        {
            conexao.Abre_Conexao();

            string SQLCunsultaEmpr = "SELECT * FROM TBFILIAL";

            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;
            conexao.cmd.Parameters.AddWithValue("USUARIO", tbox_Usuario.Text);
            conexao.cmd.Parameters.AddWithValue("SENHA", tbox_Senha.Text);

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();

            int o = 0;

            while (conexao.dataReader.Read())
            {
                idFilial = Convert.ToInt32(conexao.dataReader["ID"].ToString());
                nomeFilial = conexao.dataReader["RAZAOSOCIAL"].ToString();
                o++;
            }
            conexao.Fecha_Conexao();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            frm_Menu a = new frm_Menu();
            a.Show();
            this.Hide();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            login();
        }

        private void tbox_Usuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tbox_Usuario.Text == "")
                {
                    tbox_Usuario.Focus();
                    return;
                }
                tbox_Senha.Focus();
            }
        }

        private void tbox_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            VerificarVersao();
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongDateString() + ", " + DateTime.Now.ToLongTimeString();
        }
    }
}