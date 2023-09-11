using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverSoft
{
    public partial class frmAbrirCaixa : Form
    {

        Conexao conexao = new Conexao();
        public int idFunc;
        public frmAbrirCaixa()
        {
            InitializeComponent();
        }
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Abre_Conexao();

                string SQLCunsultaEmpr =
                    " INSERT INTO TBCAIXA(" +
                    "         DATA,       " +
                    "         IDFUNC,     " +
                    "         SUPRIMENTO, " +
                    "         STATUS      " +
                    "     )               " +
                    "     VALUES(         " +
                    "         @DATA,      " +
                    "         @IDFUNC,    " +
                    "         @SUPRIMENTO," +
                    "         @STATUS     " +
                    "     );              ";

                conexao.cmd.Connection = conexao.conexao;
                conexao.cmd.CommandText = SQLCunsultaEmpr;
                conexao.cmd.Parameters.AddWithValue("DATA", Convert.ToDateTime(DateTime.Now).ToString("yyyy-MM-dd"));
                conexao.cmd.Parameters.AddWithValue("IDFUNC", idFunc);
                conexao.cmd.Parameters.AddWithValue("SUPRIMENTO", Conversor.converterMoeda(tboxSuprimento.Text));
                conexao.cmd.Parameters.AddWithValue("STATUS", "ABERTO");


                conexao.cmd.ExecuteNonQuery();
                conexao.cmd.Parameters.Clear();


                conexao.Fecha_Conexao();
                MessageBox.Show("Caixa aberto com sucesso para o usuário: " + tboxParceiro.Text, "Clever Sistema",MessageBoxButtons.OK);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro, entre em contado com o suporte.  " + ex);
            }
          
                       
        }
        private void tboxSuprimento_Leave(object sender, EventArgs e)
        {

            tboxSuprimento.Text = Conversor.converterMoeda(tboxSuprimento.Text);
        }
        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
