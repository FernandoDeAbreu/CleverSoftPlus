namespace CleverSoft
{
    partial class frm_Secao
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
            this.btn_PesquisarGrupo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxDepartamento = new System.Windows.Forms.TextBox();
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
            this.tabPage1.Controls.Add(this.btn_PesquisarGrupo);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tboxDepartamento);
            this.tabPage1.Controls.Add(this.tboxID);
            this.tabPage1.Controls.Add(this.tboxcategoria);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Size = new System.Drawing.Size(994, 554);
            this.tabPage1.Controls.SetChildIndex(this.label2, 0);
            this.tabPage1.Controls.SetChildIndex(this.label1, 0);
            this.tabPage1.Controls.SetChildIndex(this.tboxcategoria, 0);
            this.tabPage1.Controls.SetChildIndex(this.tboxID, 0);
            this.tabPage1.Controls.SetChildIndex(this.tboxDepartamento, 0);
            this.tabPage1.Controls.SetChildIndex(this.label4, 0);
            this.tabPage1.Controls.SetChildIndex(this.btn_PesquisarGrupo, 0);
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(1002, 584);
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
            this.panel1.Size = new System.Drawing.Size(996, 600);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(995, 44);
            // 
            // lbl_NomeRotina
            // 
            this.lbl_NomeRotina.Size = new System.Drawing.Size(75, 35);
            this.lbl_NomeRotina.Text = "Form1";
            // 
            // iconcerrar
            // 
            this.iconcerrar.Location = new System.Drawing.Point(964, 4);
            // 
            // btn_PesquisarGrupo
            // 
            this.btn_PesquisarGrupo.BackColor = System.Drawing.SystemColors.Control;
            this.btn_PesquisarGrupo.FlatAppearance.BorderSize = 0;
            this.btn_PesquisarGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PesquisarGrupo.Image = global::CleverSoft.Properties.Resources.magnifier1;
            this.btn_PesquisarGrupo.Location = new System.Drawing.Point(502, 86);
            this.btn_PesquisarGrupo.Name = "btn_PesquisarGrupo";
            this.btn_PesquisarGrupo.Size = new System.Drawing.Size(51, 25);
            this.btn_PesquisarGrupo.TabIndex = 87;
            this.btn_PesquisarGrupo.TabStop = false;
            this.btn_PesquisarGrupo.UseVisualStyleBackColor = false;
            this.btn_PesquisarGrupo.Click += new System.EventHandler(this.btn_PesquisarGrupo_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 86;
            this.label4.Text = "Departamento";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tboxDepartamento
            // 
            this.tboxDepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxDepartamento.Location = new System.Drawing.Point(11, 85);
            this.tboxDepartamento.MaxLength = 45;
            this.tboxDepartamento.Name = "tboxDepartamento";
            this.tboxDepartamento.ReadOnly = true;
            this.tboxDepartamento.Size = new System.Drawing.Size(543, 27);
            this.tboxDepartamento.TabIndex = 85;
            this.tboxDepartamento.TextChanged += new System.EventHandler(this.tboxDepartamento_TextChanged);
            // 
            // tboxID
            // 
            this.tboxID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxID.Location = new System.Drawing.Point(11, 34);
            this.tboxID.Name = "tboxID";
            this.tboxID.ReadOnly = true;
            this.tboxID.Size = new System.Drawing.Size(176, 27);
            this.tboxID.TabIndex = 82;
            this.tboxID.TabStop = false;
            // 
            // tboxcategoria
            // 
            this.tboxcategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxcategoria.Location = new System.Drawing.Point(11, 137);
            this.tboxcategoria.MaxLength = 45;
            this.tboxcategoria.Name = "tboxcategoria";
            this.tboxcategoria.Size = new System.Drawing.Size(543, 27);
            this.tboxcategoria.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 83;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 84;
            this.label2.Text = "Seção";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tboxcategoriaP
            // 
            this.tboxcategoriaP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxcategoriaP.Location = new System.Drawing.Point(11, 34);
            this.tboxcategoriaP.MaxLength = 45;
            this.tboxcategoriaP.Name = "tboxcategoriaP";
            this.tboxcategoriaP.Size = new System.Drawing.Size(504, 27);
            this.tboxcategoriaP.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Conta Gerencial";
            // 
            // frm_Secao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 600);
            this.Name = "frm_Secao";
            this.Text = "CADASTRAR SEÇÃO";
            this.Load += new System.EventHandler(this.frm_Secao_Load);
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

        private System.Windows.Forms.Button btn_PesquisarGrupo;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tboxDepartamento;
        public System.Windows.Forms.TextBox tboxID;
        public System.Windows.Forms.TextBox tboxcategoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tboxcategoriaP;
        private System.Windows.Forms.Label label6;
    }
}