namespace CleverSoft
{
    partial class frm_Departamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tboxID = new System.Windows.Forms.TextBox();
            this.tboxcategoria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxcategoriaP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tboxID);
            this.tabPage1.Controls.Add(this.tboxcategoria);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Size = new System.Drawing.Size(1000, 552);
            this.tabPage1.Controls.SetChildIndex(this.label2, 0);
            this.tabPage1.Controls.SetChildIndex(this.label1, 0);
            this.tabPage1.Controls.SetChildIndex(this.tboxcategoria, 0);
            this.tabPage1.Controls.SetChildIndex(this.tboxID, 0);
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(1008, 582);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tboxcategoriaP);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.SetChildIndex(this.label6, 0);
            this.tabPage2.Controls.SetChildIndex(this.tboxcategoriaP, 0);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1002, 598);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1004, 44);
            // 
            // lbl_NomeRotina
            // 
            this.lbl_NomeRotina.Size = new System.Drawing.Size(86, 40);
            this.lbl_NomeRotina.Text = "Form1";
            // 
            // iconcerrar
            // 
            this.iconcerrar.Location = new System.Drawing.Point(973, 4);
            // 
            // tboxID
            // 
            this.tboxID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxID.Location = new System.Drawing.Point(11, 41);
            this.tboxID.Name = "tboxID";
            this.tboxID.ReadOnly = true;
            this.tboxID.Size = new System.Drawing.Size(169, 27);
            this.tboxID.TabIndex = 40;
            this.tboxID.TabStop = false;
            // 
            // tboxcategoria
            // 
            this.tboxcategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxcategoria.Location = new System.Drawing.Point(11, 102);
            this.tboxcategoria.MaxLength = 45;
            this.tboxcategoria.Name = "tboxcategoria";
            this.tboxcategoria.Size = new System.Drawing.Size(504, 27);
            this.tboxcategoria.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Departamento **";
            // 
            // tboxcategoriaP
            // 
            this.tboxcategoriaP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxcategoriaP.Location = new System.Drawing.Point(8, 40);
            this.tboxcategoriaP.MaxLength = 45;
            this.tboxcategoriaP.Name = "tboxcategoriaP";
            this.tboxcategoriaP.Size = new System.Drawing.Size(504, 27);
            this.tboxcategoriaP.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Grupo";
            // 
            // frm_Departamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 598);
            this.Name = "frm_Departamento";
            this.Text = "CADASTRAR DEPARTAMENTO";
            this.Load += new System.EventHandler(this.frm_Grupo_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox tboxID;
        public System.Windows.Forms.TextBox tboxcategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tboxcategoriaP;
        private System.Windows.Forms.Label label6;
    }
}