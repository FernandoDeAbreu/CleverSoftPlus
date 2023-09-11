namespace CleverSoft
{
    partial class frm_MoedaCobranca
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
            this.tboxDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxcategoriaP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_PesquisarBanco = new System.Windows.Forms.Button();
            this.btn_PesquisarMoeda = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxMoeda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxBancoConta = new System.Windows.Forms.TextBox();
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
            this.tabPage1.Controls.Add(this.btn_PesquisarBanco);
            this.tabPage1.Controls.Add(this.btn_PesquisarMoeda);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tboxMoeda);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tboxBancoConta);
            this.tabPage1.Controls.Add(this.tboxID);
            this.tabPage1.Controls.Add(this.tboxDescricao);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.SetChildIndex(this.label2, 0);
            this.tabPage1.Controls.SetChildIndex(this.label1, 0);
            this.tabPage1.Controls.SetChildIndex(this.tboxDescricao, 0);
            this.tabPage1.Controls.SetChildIndex(this.tboxID, 0);
            this.tabPage1.Controls.SetChildIndex(this.tboxBancoConta, 0);
            this.tabPage1.Controls.SetChildIndex(this.label4, 0);
            this.tabPage1.Controls.SetChildIndex(this.tboxMoeda, 0);
            this.tabPage1.Controls.SetChildIndex(this.label5, 0);
            this.tabPage1.Controls.SetChildIndex(this.btn_PesquisarMoeda, 0);
            this.tabPage1.Controls.SetChildIndex(this.btn_PesquisarBanco, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tboxcategoriaP);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.SetChildIndex(this.label6, 0);
            this.tabPage2.Controls.SetChildIndex(this.tboxcategoriaP, 0);
            // 
            // lbl_NomeRotina
            // 
            this.lbl_NomeRotina.Size = new System.Drawing.Size(86, 40);
            this.lbl_NomeRotina.Text = "Form1";
            // 
            // tboxID
            // 
            this.tboxID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxID.Location = new System.Drawing.Point(12, 44);
            this.tboxID.Name = "tboxID";
            this.tboxID.ReadOnly = true;
            this.tboxID.Size = new System.Drawing.Size(169, 27);
            this.tboxID.TabIndex = 50;
            this.tboxID.TabStop = false;
            // 
            // tboxDescricao
            // 
            this.tboxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxDescricao.Location = new System.Drawing.Point(12, 105);
            this.tboxDescricao.MaxLength = 45;
            this.tboxDescricao.Name = "tboxDescricao";
            this.tboxDescricao.Size = new System.Drawing.Size(482, 27);
            this.tboxDescricao.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Descrição";
            // 
            // tboxcategoriaP
            // 
            this.tboxcategoriaP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxcategoriaP.Location = new System.Drawing.Point(14, 40);
            this.tboxcategoriaP.MaxLength = 45;
            this.tboxcategoriaP.Name = "tboxcategoriaP";
            this.tboxcategoriaP.Size = new System.Drawing.Size(504, 27);
            this.tboxcategoriaP.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 51;
            this.label6.Text = "Descrição";
            // 
            // btn_PesquisarBanco
            // 
            this.btn_PesquisarBanco.BackColor = System.Drawing.SystemColors.Control;
            this.btn_PesquisarBanco.FlatAppearance.BorderSize = 0;
            this.btn_PesquisarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PesquisarBanco.Image = global::CleverSoft.Properties.Resources.magnifier1;
            this.btn_PesquisarBanco.Location = new System.Drawing.Point(443, 162);
            this.btn_PesquisarBanco.Name = "btn_PesquisarBanco";
            this.btn_PesquisarBanco.Size = new System.Drawing.Size(51, 25);
            this.btn_PesquisarBanco.TabIndex = 77;
            this.btn_PesquisarBanco.TabStop = false;
            this.btn_PesquisarBanco.UseVisualStyleBackColor = false;
            this.btn_PesquisarBanco.Click += new System.EventHandler(this.btn_PesquisarBanco_Click);
            // 
            // btn_PesquisarMoeda
            // 
            this.btn_PesquisarMoeda.BackColor = System.Drawing.SystemColors.Control;
            this.btn_PesquisarMoeda.FlatAppearance.BorderSize = 0;
            this.btn_PesquisarMoeda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PesquisarMoeda.Image = global::CleverSoft.Properties.Resources.magnifier1;
            this.btn_PesquisarMoeda.Location = new System.Drawing.Point(443, 222);
            this.btn_PesquisarMoeda.Name = "btn_PesquisarMoeda";
            this.btn_PesquisarMoeda.Size = new System.Drawing.Size(51, 25);
            this.btn_PesquisarMoeda.TabIndex = 76;
            this.btn_PesquisarMoeda.TabStop = false;
            this.btn_PesquisarMoeda.UseVisualStyleBackColor = false;
            this.btn_PesquisarMoeda.Click += new System.EventHandler(this.btn_PesquisarMoeda_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 75;
            this.label5.Text = "Moeda";
            // 
            // tboxMoeda
            // 
            this.tboxMoeda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxMoeda.Location = new System.Drawing.Point(12, 221);
            this.tboxMoeda.MaxLength = 45;
            this.tboxMoeda.Name = "tboxMoeda";
            this.tboxMoeda.ReadOnly = true;
            this.tboxMoeda.Size = new System.Drawing.Size(482, 27);
            this.tboxMoeda.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 74;
            this.label4.Text = "Banco / Conta";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tboxBancoConta
            // 
            this.tboxBancoConta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxBancoConta.Location = new System.Drawing.Point(12, 161);
            this.tboxBancoConta.MaxLength = 45;
            this.tboxBancoConta.Name = "tboxBancoConta";
            this.tboxBancoConta.ReadOnly = true;
            this.tboxBancoConta.Size = new System.Drawing.Size(482, 27);
            this.tboxBancoConta.TabIndex = 72;
            this.tboxBancoConta.TextChanged += new System.EventHandler(this.tboxBancoConta_TextChanged);
            // 
            // frm_MoedaCobranca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Name = "frm_MoedaCobranca";
            this.Text = "CADASTRAR COBRANÇA";
            this.Load += new System.EventHandler(this.frm_MoedaCobranca_Load);
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
        public System.Windows.Forms.TextBox tboxDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tboxcategoriaP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_PesquisarBanco;
        private System.Windows.Forms.Button btn_PesquisarMoeda;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tboxMoeda;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tboxBancoConta;
    }
}