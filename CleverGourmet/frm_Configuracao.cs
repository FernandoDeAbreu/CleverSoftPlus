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
    public partial class frm_Configuracao : Modelo
    {
        OpenFileDialog file = new OpenFileDialog();
      
        string sourceFile;
        string destinationFile;
        public frm_Configuracao()
        {
            InitializeComponent();
        }
        private void Iniciar_Form() 
        {
            btn_pesquisar1.Visible = false;
            pictureBox1.ImageLocation = Application.StartupPath + @"\imagemSistema.png";
            pictureBox2.ImageLocation = Application.StartupPath + @"\ofertas-mobile.png";
        }
        private void AuterarImagemMenu(object sender, EventArgs e)
        {
            file.Filter = "JPG|*.jpg|PNG|*.png";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = file.FileName;

                if (System.IO.File.Exists(Application.StartupPath + @"\imagemSistema.png"))
                {

                    try
                    {
                        System.IO.File.Delete(Application.StartupPath + @"\imagemSistema.png");
                    }
                    catch (System.IO.IOException)
                    {
                        return;
                    }

                }
                try
                {
                    sourceFile = file.FileName;
                    destinationFile = Application.StartupPath + @"\imagemSistema.png";

                    // Para mover um arquivo ou pasta para um novo local:
                    System.IO.File.Copy(sourceFile, destinationFile);

                    //    gravarFoto();
                }
                catch (Exception)
                {
                    return;

                }

            }
        }
        private void AuterarImagemPDV(object sender, EventArgs e)
        {
            file.Filter = "JPG|*.jpg|PNG|*.png";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.ImageLocation = file.FileName;

                if (System.IO.File.Exists(Application.StartupPath + @"\ofertas-mobile.png"))
                {

                    try
                    {
                        System.IO.File.Delete(Application.StartupPath + @"\ofertas-mobile.png");
                    }
                    catch (System.IO.IOException)
                    {
                        return;
                    }

                }
                try
                {
                    sourceFile = file.FileName;
                    destinationFile = Application.StartupPath + @"\ofertas-mobile.png";

                    // Para mover um arquivo ou pasta para um novo local:
                    System.IO.File.Copy(sourceFile, destinationFile);

                    //    gravarFoto();
                }
                catch (Exception)
                {
                    return;

                }

            }
        }
        private void frm_Configuracao_Load(object sender, EventArgs e)
        {
            Iniciar_Form();
        }
    }
}
