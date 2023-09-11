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
    public partial class frm_Pagina_Inicial : Form
    {
        public frm_Pagina_Inicial()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
           
                lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
                lblFecha.Text = DateTime.Now.ToLongDateString();
            
        }
    }
}
