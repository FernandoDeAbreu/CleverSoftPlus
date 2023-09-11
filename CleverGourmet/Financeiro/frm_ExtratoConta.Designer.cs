namespace CleverSoft
{
    partial class frm_ExtratoConta
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
            this.btn_pesquisar1 = new System.Windows.Forms.Button();
            this.btn_PesquisarBanco = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxBancoConta = new System.Windows.Forms.TextBox();
            this.tbox_dtIni = new System.Windows.Forms.DateTimePicker();
            this.tbox_dtFim = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(542, 44);
            // 
            // lbl_NomeRotina
            // 
            this.lbl_NomeRotina.Size = new System.Drawing.Size(175, 40);
            this.lbl_NomeRotina.Text = "ModeloSimples";
            // 
            // iconcerrar
            // 
            this.iconcerrar.Location = new System.Drawing.Point(511, 4);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbox_dtFim);
            this.panel1.Controls.Add(this.tbox_dtIni);
            this.panel1.Controls.Add(this.btn_PesquisarBanco);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tboxBancoConta);
            this.panel1.Controls.Add(this.btn_pesquisar1);
            this.panel1.Size = new System.Drawing.Size(542, 297);
            this.panel1.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.Controls.SetChildIndex(this.btn_pesquisar1, 0);
            this.panel1.Controls.SetChildIndex(this.tboxBancoConta, 0);
            this.panel1.Controls.SetChildIndex(this.label4, 0);
            this.panel1.Controls.SetChildIndex(this.btn_PesquisarBanco, 0);
            this.panel1.Controls.SetChildIndex(this.tbox_dtIni, 0);
            this.panel1.Controls.SetChildIndex(this.tbox_dtFim, 0);
            // 
            // btn_pesquisar1
            // 
            this.btn_pesquisar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_pesquisar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_pesquisar1.FlatAppearance.BorderSize = 0;
            this.btn_pesquisar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_pesquisar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_pesquisar1.ForeColor = System.Drawing.Color.White;
            this.btn_pesquisar1.Image = global::CleverSoft.Properties.Resources.find;
            this.btn_pesquisar1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pesquisar1.Location = new System.Drawing.Point(378, 244);
            this.btn_pesquisar1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pesquisar1.Name = "btn_pesquisar1";
            this.btn_pesquisar1.Size = new System.Drawing.Size(150, 39);
            this.btn_pesquisar1.TabIndex = 13;
            this.btn_pesquisar1.Text = "Pesquisar";
            this.btn_pesquisar1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pesquisar1.UseVisualStyleBackColor = false;
            this.btn_pesquisar1.Click += new System.EventHandler(this.btn_pesquisar1_Click);
            // 
            // btn_PesquisarBanco
            // 
            this.btn_PesquisarBanco.BackColor = System.Drawing.SystemColors.Control;
            this.btn_PesquisarBanco.FlatAppearance.BorderSize = 0;
            this.btn_PesquisarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PesquisarBanco.Image = global::CleverSoft.Properties.Resources.magnifier1;
            this.btn_PesquisarBanco.Location = new System.Drawing.Point(257, 81);
            this.btn_PesquisarBanco.Name = "btn_PesquisarBanco";
            this.btn_PesquisarBanco.Size = new System.Drawing.Size(51, 23);
            this.btn_PesquisarBanco.TabIndex = 108;
            this.btn_PesquisarBanco.TabStop = false;
            this.btn_PesquisarBanco.UseVisualStyleBackColor = false;
            this.btn_PesquisarBanco.Click += new System.EventHandler(this.btn_PesquisarBanco_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 107;
            this.label4.Text = "Banco / Conta";
            // 
            // tboxBancoConta
            // 
            this.tboxBancoConta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxBancoConta.Location = new System.Drawing.Point(11, 80);
            this.tboxBancoConta.MaxLength = 45;
            this.tboxBancoConta.Name = "tboxBancoConta";
            this.tboxBancoConta.ReadOnly = true;
            this.tboxBancoConta.Size = new System.Drawing.Size(299, 25);
            this.tboxBancoConta.TabIndex = 106;
            // 
            // tbox_dtIni
            // 
            this.tbox_dtIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbox_dtIni.Location = new System.Drawing.Point(11, 136);
            this.tbox_dtIni.Name = "tbox_dtIni";
            this.tbox_dtIni.Size = new System.Drawing.Size(144, 25);
            this.tbox_dtIni.TabIndex = 109;
            // 
            // tbox_dtFim
            // 
            this.tbox_dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbox_dtFim.Location = new System.Drawing.Point(166, 136);
            this.tbox_dtFim.Name = "tbox_dtFim";
            this.tbox_dtFim.Size = new System.Drawing.Size(144, 25);
            this.tbox_dtFim.TabIndex = 110;
            // 
            // frm_ExtratoConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 297);
            this.Name = "frm_ExtratoConta";
            this.Text = "EXTRATO CONTA";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_pesquisar1;
        private System.Windows.Forms.Button btn_PesquisarBanco;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tboxBancoConta;
        private System.Windows.Forms.DateTimePicker tbox_dtFim;
        private System.Windows.Forms.DateTimePicker tbox_dtIni;
    }
}