using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverSoft.Ordem_de_Serviço
{
   
    public partial class frmLancaPendencia : Form
    {
        Conexao conexao = new Conexao();
        public string incluirEditar;
        public string dtFinalizado;

        public frmLancaPendencia()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (incluirEditar == "Novo")
            {
                conexao.Abre_Conexao();
                string SQLCunsultaEmpr = "INSERT INTO TBOS_PENDENCIA (   " +
                                                    "      DESCRICAO,    " +
                                                    "      IDOS,         " +
                                                    "      DTLANC,       " +
                                                    "      DTCONCLUSAO   " +
                                                    "  )                 " +
                                                    "  VALUES(           " +
                                                    "      @DESCRICAO,    " +
                                                    "      @IDOS,         " +
                                                    "      @DTLANC,       " +
                                                    "      @DTCONCLUSAO   " +
                                                    "  );                ";


                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;
                conexao.cmd.Parameters.AddWithValue("DESCRICAO", textBox1.Text);
                conexao.cmd.Parameters.AddWithValue("IDOS", tboxNumPedido.Text);
                conexao.cmd.Parameters.AddWithValue("DTLANC", Convert.ToDateTime(tboxDtLanc.Text).ToString("yyyy-MM-dd"));
                conexao.cmd.Parameters.AddWithValue("DTCONCLUSAO", null);


                conexao.cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Fecha_Conexao();
            }
            if (incluirEditar == "Editar")
            {
                conexao.Abre_Conexao();
                string SQLCunsultaEmpr = "UPDATE TBOS_PENDENCIA SET   " +
                                                    "      DESCRICAO   =  @DESCRICAO,   " +
                                                    "      DTCONCLUSAO =  @DTCONCLUSAO WHERE IDOS = @IDOS";
                                                   


                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;
                conexao.cmd.Parameters.AddWithValue("IDOS", tboxNumPedido.Text);
                conexao.cmd.Parameters.AddWithValue("DESCRICAO", textBox1.Text);
                conexao.cmd.Parameters.AddWithValue("DTLANC", Convert.ToDateTime(tboxDtLanc.Text).ToString("yyyy-MM-dd"));
                conexao.cmd.Parameters.AddWithValue("DTCONCLUSAO", dtFinalizado);


                conexao.cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexao.Fecha_Conexao();
            }
               textBox1.Clear();
        }
        private void cboxFinalizado_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxFinalizado.Checked == true)
            {
                try
                {
                    tboxDtFinalizacao.Enabled = true;
                    dtFinalizado = Convert.ToDateTime(tboxDtFinalizacao.Text).ToString("yyyy-MM-dd");
                }
                catch (Exception)
                {
                }

            }
            if (cboxFinalizado.Checked == false)
            {
                tboxDtFinalizacao.Enabled = false;
                dtFinalizado = null;

            }
        }
        private void frmLancaPendencia_Load(object sender, EventArgs e)
        {
            this.lbl_NomeRotina.Text = incluirEditar;
        }
    }
}
