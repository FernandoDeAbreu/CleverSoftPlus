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
    public partial class Modelo : Form
    {
        public int id_registro;

        public string tituloMessageBox = "Clever Sistema";

        public Modelo()
        {
            InitializeComponent();
        }

        private void Iniciar_Form()
        {
            lbl_NomeRotina.Text = this.Text;

        }
        private void Btn_fechar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;

        }
        public void Modelo_Load(object sender, EventArgs e)
        {
            Iniciar_Form();
        }
        public virtual void pesquisar_Registro()
        {
            for (int i = 0; i < dgv_resultado_pesquisa.Rows.Count; i++)
            {
                dgv_resultado_pesquisa.DefaultCellStyle.ForeColor = Color.Black;
            }
        }

        public virtual void gravar_Registro()
        {
        }

        public virtual void editar_Registro()
        {
        }

        public virtual void excluir_Registro()
        {

        }

        public virtual void relatorio1()
        {

        }

        public virtual void relatorio2()
        {

        }

        public virtual void relatorio3()
        {

        }

        public virtual void relatorio4()
        {

        }

        public virtual void relatorio5()
        {

        }

        public virtual void relatorio6()
        {

        }

        public virtual void relatorio7()
        {

        }

        public virtual void relatorio8()
        {

        }

        public virtual void relatorio9()
        {

        }

        public virtual void relatorio10()
        {

        }

        public virtual void limpar_Campos()
        {

        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            gravar_Registro();
        }

        private void Btn_Pesquisar_Click(object sender, EventArgs e)
        {
            pesquisar_Registro();
            tbox_qtde.Text = "Foram listados: " + dgv_resultado_pesquisa.RowCount;

        }

        private void Btn_editar_Click(object sender, EventArgs e)
        {
            editar_Registro();
        }

        private void Btn_excluir_Click(object sender, EventArgs e)
        {
            excluir_Registro();
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorio1();
        }

        private void Dgv_resultado_pesquisa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            editar_Registro();
        }

        private void Modelo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                pesquisar_Registro();
                tbox_qtde.Text = "Foram listados: " + dgv_resultado_pesquisa.RowCount;
            }

        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            limpar_Campos();
            tabControl1.SelectedIndex = 0;
        }

        private void Relatorio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorio1();
        }

        private void Relatorio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorio2();
        }

        private void Relatorio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorio3();
        }

        private void relatorio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorio4();
        }

        private void relatorio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorio5();
        }

        private void relatorio6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorio6();
        }

        private void relatorio7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorio7();
        }

        private void relatorio8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorio8();
        }

        private void relatorio9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorio9();
        }

        private void relatorio10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            relatorio10();
        }
    }
}
