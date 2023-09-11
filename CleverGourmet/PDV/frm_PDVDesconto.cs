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
    public partial class frm_PDVDesconto : Form
    {
        frm_PDV instPagamento;
        
       
        

        public frm_PDVDesconto(frm_PDV pagamento)
        {
            InitializeComponent();
            instPagamento = pagamento;
        }
        private void calcularDescontoPorcento()
        {
            try
            {

            decimal vrlDesconto = Convert.ToDecimal(tbox_DescontoPorcento.Text);
            decimal pvenda;
            decimal punit;

            
                for (int i = 0; i < instPagamento.dgv_Itens_Venda.RowCount; i++)
                {
                    punit = Convert.ToDecimal(instPagamento.dgv_Itens_Venda.Rows[i].Cells["PUNIT"].Value.ToString());

                    pvenda = punit - ((punit * vrlDesconto) / 100);

                    instPagamento.dgv_Itens_Venda.Rows[i].Cells["PDESC"].Value =  double.Parse(Convert.ToString( punit - pvenda)).ToString("N4");
                    instPagamento.dgv_Itens_Venda.Rows[i].Cells["PVENDA"].Value = Conversor.converterMoeda(Convert.ToString(pvenda));
                }
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Valor invalido informado", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbox_DescontoPorcento.Text = "";
                tbox_DescontoPorcento.Focus();
            }
        }

        private void calcularDescontoReal()
        {
            try
            {

            decimal vrlDesconto = Convert.ToDecimal(tbox_DescontoReal.Text);
            decimal pvenda;
            decimal punit;

             vrlDesconto = (vrlDesconto * 100) / Convert.ToDecimal(instPagamento.lbl_vlrOriginal.Text);



           
                for (int i = 0; i < instPagamento.dgv_Itens_Venda.RowCount; i++)
                {
                    punit = Convert.ToDecimal(instPagamento.dgv_Itens_Venda.Rows[i].Cells["PUNIT"].Value.ToString());

                    pvenda = punit - ((punit * vrlDesconto) / 100);

                    instPagamento.dgv_Itens_Venda.Rows[i].Cells["PDESC"].Value  = double.Parse(Convert.ToString(punit - pvenda)).ToString("N4");
                    instPagamento.dgv_Itens_Venda.Rows[i].Cells["PVENDA"].Value = double.Parse(Convert.ToString(Convert.ToString(pvenda))).ToString("N4");
                }
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Valor invalido informado", "Clever Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbox_DescontoReal.Text = "";
                tbox_DescontoReal.Focus();
            }
        }
        private void tbox_DescontoReal_KeyUp(object sender, KeyEventArgs e)
        {
            tbox_DescontoPorcento.Text = "0,00";
        }

        private void tbox_DescontoPorcento_KeyUp(object sender, KeyEventArgs e)
        {
            tbox_DescontoReal.Text = "0,00";
        }

        private void tbox_DescontoReal_Leave(object sender, EventArgs e)
        {
            try
            {
                tbox_DescontoReal.Text = Conversor.converterMoeda(tbox_DescontoReal.Text);
            }
            catch (Exception)
            {
             
            }
        }

        private void tbox_DescontoPorcento_Leave(object sender, EventArgs e)
        {
            try
            {
                tbox_DescontoPorcento.Text = Conversor.converterMoeda(tbox_DescontoPorcento.Text);
            }
            catch (Exception)
            {

            }
        }

        private void tbox_DescontoReal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                calcularDescontoReal();
            }      
                    


        }

        private void tbox_DescontoPorcento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                calcularDescontoPorcento();
            }
        }

        private void tbox_DescontoReal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
