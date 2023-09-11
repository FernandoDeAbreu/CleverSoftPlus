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


namespace CleverGourmet
{
    public partial class frm_MateriaPrima : Modelo
    {
        Conexao conexao = new Conexao();

        public frm_MateriaPrima()
        {
            InitializeComponent();
        }

        private void Iniciar_Form()
        {
           // tabControl1.TabPages.Remove(tabPage2);
            #region MONTAR GRID CONSULTA

            DataGridViewTextBoxColumn col_ID = new DataGridViewTextBoxColumn();
            col_ID.Name = "ID";
            col_ID.HeaderText = "CÓDIGO";
            col_ID.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_ID);

            DataGridViewTextBoxColumn col_DESCRICAO = new DataGridViewTextBoxColumn();
            col_DESCRICAO.Name = "DESCRICAO";
            col_DESCRICAO.HeaderText = "DESCRIÇÃO";
            col_DESCRICAO.Width = 350;
            dgv_resultado_pesquisa.Columns.Add(col_DESCRICAO);

            DataGridViewTextBoxColumn col_MEDIDA = new DataGridViewTextBoxColumn();
            col_MEDIDA.Name = "MEDIDA";
            col_MEDIDA.HeaderText = "MEDIDA";
            col_MEDIDA.Width = 90;
            dgv_resultado_pesquisa.Columns.Add(col_MEDIDA);

            DataGridViewTextBoxColumn col_PCUSTO = new DataGridViewTextBoxColumn();
            col_PCUSTO.Name = "PCUSTO";
            col_PCUSTO.HeaderText = "PREÇO CUSTO";
            col_PCUSTO.Width = 150;
            dgv_resultado_pesquisa.Columns.Add(col_PCUSTO);

            DataGridViewTextBoxColumn col_ESTOQUE = new DataGridViewTextBoxColumn();
            col_ESTOQUE.Name = "QTDPECAS";
            col_ESTOQUE.HeaderText = "QTDE. PEÇAS";
            col_ESTOQUE.Width = 100;
            dgv_resultado_pesquisa.Columns.Add(col_ESTOQUE);

            #endregion

        }

        private void frm_MateriaPrima_Load(object sender, EventArgs e)
        {
            Iniciar_Form();
        }
    }
}
