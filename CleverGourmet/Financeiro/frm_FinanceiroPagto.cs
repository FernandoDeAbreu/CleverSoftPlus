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
    public partial class frm_FinanceiroPagto : Form
    {
        public string idlancamento;
        public string rotina;
        Conexao conexao = new Conexao();

        public frm_FinanceiroPagto()
        {
            InitializeComponent();
        }
        private void calcularTotal()
        {
            double valor = double.Parse(tboxValor.Text);
            double desconto = double.Parse(tboxDesconto.Text);
            double juros = double.Parse(tboxJuros.Text);
            double total;

            total = valor + juros - desconto;

            tboxTotal.Text = Convert.ToString(total);
            tboxTotal.Text = Conversor.converterMoeda(tboxTotal.Text);

        }

        private void tboxValor_Leave(object sender, EventArgs e)
        {

            Conversor.converterMoeda(tboxValor.Text);
           
            calcularTotal();
        }

        private void tboxDesconto_Leave(object sender, EventArgs e)
        {

            Conversor.converterMoeda(tboxDesconto.Text);
         
            calcularTotal();
        }

        private void tboxJuros_Leave(object sender, EventArgs e)
        {
            Conversor.converterMoeda(tboxJuros.Text);
          
            calcularTotal();
        }

        private void tboxTotal_Leave(object sender, EventArgs e)
        {

            Conversor.converterMoeda(tboxTotal.Text);

            calcularTotal();


        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            
            conexao.Abre_Conexao();
                    string SQLCunsultaEmpr = " UPDATE TBFINANCEIRO SET " +
                                                       "  DTPGTO         = @DTPGTO     " +
                                                       " ,VALOR          = @VALOR       " +
                                                       " ,VLRDESC        = @VLRDESC     " +
                                                       " ,VLRJUROS       = @VLRJUROS     " +
                                                       " ,VLRTOTAL       = @VLRTOTAL    " +
                                                       " WHERE ID =  " + idlancamento;
                                                    


                    conexao.cmd.Connection = conexao.conexao;
                    conexao.cmd.CommandText = SQLCunsultaEmpr;           
                   
                    conexao.cmd.Parameters.AddWithValue("DTPGTO",        Conversor.converterDataUS(dateTimePicker1.Text));
                    conexao.cmd.Parameters.AddWithValue("VALOR",         Conversor.converterMoeda(tboxValor.Text));
                    conexao.cmd.Parameters.AddWithValue("VLRDESC",       Conversor.converterMoeda(tboxDesconto.Text));
                    conexao.cmd.Parameters.AddWithValue("VLRJUROS",      Conversor.converterMoeda(tboxJuros.Text));
                    conexao.cmd.Parameters.AddWithValue("VLRTOTAL",      Conversor.converterMoeda(tboxTotal.Text));
                    conexao.cmd.ExecuteNonQuery();

            MessageBox.Show("Cadastro Atualizado com sucesso!", "Clever sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conexao.Fecha_Conexao();
            this.Close();

        }
    }
}
