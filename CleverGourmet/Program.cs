using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CleverSoft
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary> sfdsdfgsdfgsdfgsdfg
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new frm_Suporte());
            Application.Run(new frmLogin());

            //Application.Run(new Ordem_de_Serviço.frmMonitorOrdemServico());
           /// Application.Run(new Igreja.frmReceberContribuicao());
        }
    }
}
