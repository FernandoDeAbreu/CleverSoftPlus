using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverSoft.Conta_Gerencial
{
    public partial class frmContaGerencialNovo : Padrao
    {
        Conexao conexao = new Conexao();
        public string codGrupoConta;
        string SQLCunsultaEmpr;
        public frmContaGerencialNovo()
        {
            InitializeComponent();
        }

        private void btn_PesquisarGrupo_Click(object sender, EventArgs e)
        {
            frm_Pesquisar a = new frm_Pesquisar(this);
            a.Text = "PESQUISAR GRUPO DE CONTAS";
            a.RotinaOrigem = lbl_NomeRotina.Text;
            a.ShowDialog();
        }
    }
}
