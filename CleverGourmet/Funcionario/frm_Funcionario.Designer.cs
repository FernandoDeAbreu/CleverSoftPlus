namespace CleverSoft
{
    partial class frm_Funcionario
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
            this.label5 = new System.Windows.Forms.Label();
            this.tboxsenha = new System.Windows.Forms.TextBox();
            this.tboxusuario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tboxmatricula = new System.Windows.Forms.TextBox();
            this.tboxnome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxcpf = new System.Windows.Forms.TextBox();
            this.tboxNomeP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxCPFP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tboxsenha);
            this.tabPage1.Controls.Add(this.tboxusuario);
            this.tabPage1.Controls.Add(this.tboxnome);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.tboxmatricula);
            this.tabPage1.Controls.Add(this.tboxcpf);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.SetChildIndex(this.label2, 0);
            this.tabPage1.Controls.SetChildIndex(this.label1, 0);
            this.tabPage1.Controls.SetChildIndex(this.label4, 0);
            this.tabPage1.Controls.SetChildIndex(this.tboxcpf, 0);
            this.tabPage1.Controls.SetChildIndex(this.tboxmatricula, 0);
            this.tabPage1.Controls.SetChildIndex(this.label10, 0);
            this.tabPage1.Controls.SetChildIndex(this.tboxnome, 0);
            this.tabPage1.Controls.SetChildIndex(this.tboxusuario, 0);
            this.tabPage1.Controls.SetChildIndex(this.tboxsenha, 0);
            this.tabPage1.Controls.SetChildIndex(this.label5, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tboxCPFP);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tboxNomeP);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.SetChildIndex(this.label6, 0);
            this.tabPage2.Controls.SetChildIndex(this.tboxNomeP, 0);
            this.tabPage2.Controls.SetChildIndex(this.label7, 0);
            this.tabPage2.Controls.SetChildIndex(this.tboxCPFP, 0);
            // 
            // lbl_NomeRotina
            // 
            this.lbl_NomeRotina.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_NomeRotina.Size = new System.Drawing.Size(84, 40);
            this.lbl_NomeRotina.Text = "Form1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Senha";
            // 
            // tboxsenha
            // 
            this.tboxsenha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxsenha.Location = new System.Drawing.Point(355, 150);
            this.tboxsenha.MaxLength = 11;
            this.tboxsenha.Name = "tboxsenha";
            this.tboxsenha.Size = new System.Drawing.Size(165, 27);
            this.tboxsenha.TabIndex = 49;
            this.tboxsenha.UseSystemPasswordChar = true;
            // 
            // tboxusuario
            // 
            this.tboxusuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxusuario.Location = new System.Drawing.Point(185, 150);
            this.tboxusuario.MaxLength = 11;
            this.tboxusuario.Name = "tboxusuario";
            this.tboxusuario.Size = new System.Drawing.Size(165, 27);
            this.tboxusuario.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 47;
            this.label10.Text = "CPF **";
            // 
            // tboxmatricula
            // 
            this.tboxmatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxmatricula.Location = new System.Drawing.Point(15, 36);
            this.tboxmatricula.Name = "tboxmatricula";
            this.tboxmatricula.ReadOnly = true;
            this.tboxmatricula.Size = new System.Drawing.Size(88, 27);
            this.tboxmatricula.TabIndex = 36;
            this.tboxmatricula.TabStop = false;
            // 
            // tboxnome
            // 
            this.tboxnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxnome.Location = new System.Drawing.Point(15, 92);
            this.tboxnome.MaxLength = 45;
            this.tboxnome.Name = "tboxnome";
            this.tboxnome.Size = new System.Drawing.Size(504, 27);
            this.tboxnome.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nome **";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Usuário";
            // 
            // tboxcpf
            // 
            this.tboxcpf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxcpf.Location = new System.Drawing.Point(15, 150);
            this.tboxcpf.MaxLength = 11;
            this.tboxcpf.Name = "tboxcpf";
            this.tboxcpf.Size = new System.Drawing.Size(165, 27);
            this.tboxcpf.TabIndex = 42;
            // 
            // tboxNomeP
            // 
            this.tboxNomeP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxNomeP.Location = new System.Drawing.Point(8, 88);
            this.tboxNomeP.MaxLength = 45;
            this.tboxNomeP.Name = "tboxNomeP";
            this.tboxNomeP.Size = new System.Drawing.Size(504, 27);
            this.tboxNomeP.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 43;
            this.label6.Text = "Nome";
            // 
            // tboxCPFP
            // 
            this.tboxCPFP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxCPFP.Location = new System.Drawing.Point(7, 38);
            this.tboxCPFP.MaxLength = 45;
            this.tboxCPFP.Name = "tboxCPFP";
            this.tboxCPFP.Size = new System.Drawing.Size(206, 27);
            this.tboxCPFP.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 20);
            this.label7.TabIndex = 45;
            this.label7.Text = "CPF";
            // 
            // frm_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Name = "frm_Funcionario";
            this.Text = "CADASTRO DE FUNCIONÁRIO";
            this.Load += new System.EventHandler(this.Frm_Funcionario_Load);
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
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tboxsenha;
        public System.Windows.Forms.TextBox tboxusuario;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox tboxmatricula;
        public System.Windows.Forms.TextBox tboxnome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tboxcpf;
        public System.Windows.Forms.TextBox tboxCPFP;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tboxNomeP;
        private System.Windows.Forms.Label label6;
    }
}