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
    public partial class ModeloSimples : Form
    {
        public int id_registro;

        public string tituloMessageBox = "Clever Sistema";
        public ModeloSimples()
        {
            InitializeComponent();
        }
        private void Iniciar_Form()
        {
            lbl_NomeRotina.Text = this.Text;

        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModeloSimples_Load(object sender, EventArgs e)
        {
            Iniciar_Form();
        }
    }
}
