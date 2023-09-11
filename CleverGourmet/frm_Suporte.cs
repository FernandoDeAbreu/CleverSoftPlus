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
    public partial class frm_Suporte : ModeloSimples
    {
        ConexaoLicenca Licenca = new ConexaoLicenca();
        Conexao conexao = new Conexao();

        string SQLCunsultaEmpr;
        public frm_Suporte()
        {
            InitializeComponent();
        }
        void pesquisar_Registro()
        {


            tabControl1.SelectedIndex = 0;


            conexao.Abre_Conexao();
            try
            {
                dgv_resultado_pesquisa.Columns.Clear();
                SQLCunsultaEmpr = tboxSQL.Text;



                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;

                conexao.cmd.ExecuteNonQuery();
                conexao.adapter.SelectCommand = conexao.cmd;

                DataTable clientes = new DataTable();
                conexao.adapter.Fill(clientes);

                dgv_resultado_pesquisa.DataSource = clientes;
            }
            catch (Exception ex)
            {
                tabControl1.SelectedIndex = 1;
                richTextBox1.Text = Convert.ToString(ex);
            }
         

            conexao.Fecha_Conexao();

        }

        void pesquisar_Licenca()
        {


            tabControl1.SelectedIndex = 0;


            Licenca.Abre_Conexao();
            try
            {
                dgv_resultado_pesquisa.Columns.Clear();
                SQLCunsultaEmpr = tboxSQL.Text;



                Licenca.cmd.Connection = Licenca.conexao;
                Licenca.cmd.CommandText = SQLCunsultaEmpr;

                Licenca.cmd.ExecuteNonQuery();
                Licenca.adapter.SelectCommand = Licenca.cmd;

                DataTable clientes = new DataTable();
                Licenca.adapter.Fill(clientes);

                dgv_resultado_pesquisa.DataSource = clientes;
            }
            catch (Exception ex)
            {
                tabControl1.SelectedIndex = 1;
                richTextBox1.Text = Convert.ToString(ex);
            }


            Licenca.Fecha_Conexao();

        }

        private void tboxSQL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                pesquisar_Registro();
            }
            if (e.KeyCode == Keys.F10)
            {
                pesquisar_Licenca();
            }
        }

        private void tboxSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (tboxSenha.Text == "fernandoAbreu")
                {
                    splitContainer1.Visible = true;
                }
            }
        }

        private void btn_Anydesk_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\AnyDesk.exe");
        }
    }
}
