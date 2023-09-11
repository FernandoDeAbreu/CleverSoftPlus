using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverSoft.Produto
{
    public partial class frmAjusteEstoqueRelatorio : Form
    {
        Conexao conexao = new Conexao();
        string tipoMov;

        string SQLCunsultaEmpr;
        public frmAjusteEstoqueRelatorio()
        {
            InitializeComponent();
        }

        private void pesquisarProduto()
        {
            if (rbtnSaida.Checked == true)
            {
                tipoMov = " = 'SD'";
            }
            if (rbtnEntrada.Checked == true)
            {
                tipoMov = " = 'ED' ";
            }
            if (radioButton1.Checked == true)
            {
                tipoMov = " IS NOT NULL";
            }

            conexao.Abre_Conexao();
            SQLCunsultaEmpr =
                             " SELECT          " +
                             " M.DTMOV         " +
                             " ,M.CODPROD      " +
                             " ,P.DESCRICAO    " +
                             " ,P.CODAUXILIAR  " +
                             " ,M.QTDE         " +
                             " ,M.TIPOMOV      " +
                             " ,M.MOTIVO       " +
                             "                 " +
                             " FROM            " +
                             " TBPRODMOV M,    " +
                             " TBPRODUTO P     " +
                             " WHERE           " +
                             " M.CODPROD = P.ID  AND" +
                             " M.TIPOMOV " + tipoMov + " AND "+
                             " M.DTMOV BETWEEN '" + Convert.ToDateTime(tboxDtIni.Text).ToString("yyyy-MM-dd") + "' AND '" + Convert.ToDateTime(tboxDtFim.Text).ToString("yyyy-MM-dd") + "'"; 

            conexao.cmd.Connection = conexao.conexao;
            conexao.cmd.CommandText = SQLCunsultaEmpr;

            conexao.cmd.ExecuteNonQuery();
            conexao.adapter.SelectCommand = conexao.cmd;
            conexao.adapter.Fill(conexao.dataSet, "PCPRODUT");
            conexao.dataReader = conexao.cmd.ExecuteReader();

            conexao.Fecha_Conexao();
        }
        private void btn_Incluir_Click(object sender, EventArgs e)
        {
            pesquisarProduto();
            //try
            //{
                frm_Relatorio a = new frm_Relatorio();
                a.Arquivo_rdlc = "Rpv_MovimentacaoEstoque.rdlc";
                a.Sql_Relatorio1 = this.SQLCunsultaEmpr;
                a.Dataset_Relatorio1 = "DataSet_MovimentacaoEstoque";
                a.ShowDialog();
            //}
            //catch (Exception)
            //{

            //}
        }
    }
}
