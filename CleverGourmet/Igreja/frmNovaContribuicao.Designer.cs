namespace CleverSoft.Igreja
{
    partial class frmNovaContribuicao
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxFormaPagamento = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxDtLanc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxValor = new System.Windows.Forms.TextBox();
            this.cboxContribuicao = new System.Windows.Forms.ComboBox();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.lbl_NomeRotina = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cboxFormaPagamento);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tboxDtLanc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tboxValor);
            this.panel1.Controls.Add(this.cboxContribuicao);
            this.panel1.Controls.Add(this.panelBarraTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 354);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F);
            this.label4.Location = new System.Drawing.Point(16, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 23);
            this.label4.TabIndex = 199;
            this.label4.Text = "Forma de pagamento";
            // 
            // cboxFormaPagamento
            // 
            this.cboxFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxFormaPagamento.Font = new System.Drawing.Font("Calibri", 22F);
            this.cboxFormaPagamento.FormattingEnabled = true;
            this.cboxFormaPagamento.Location = new System.Drawing.Point(16, 153);
            this.cboxFormaPagamento.Name = "cboxFormaPagamento";
            this.cboxFormaPagamento.Size = new System.Drawing.Size(378, 44);
            this.cboxFormaPagamento.TabIndex = 198;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnCancelar.Location = new System.Drawing.Point(17, 282);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(178, 49);
            this.btnCancelar.TabIndex = 197;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNovo.Font = new System.Drawing.Font("Calibri", 14F);
            this.btnNovo.Location = new System.Drawing.Point(201, 282);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(194, 49);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Salvar";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F);
            this.label3.Location = new System.Drawing.Point(16, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contribuição";
            // 
            // tboxDtLanc
            // 
            this.tboxDtLanc.Font = new System.Drawing.Font("Calibri", 22F);
            this.tboxDtLanc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tboxDtLanc.Location = new System.Drawing.Point(17, 226);
            this.tboxDtLanc.Name = "tboxDtLanc";
            this.tboxDtLanc.Size = new System.Drawing.Size(178, 43);
            this.tboxDtLanc.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14F);
            this.label2.Location = new System.Drawing.Point(11, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F);
            this.label1.Location = new System.Drawing.Point(197, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor";
            // 
            // tboxValor
            // 
            this.tboxValor.Font = new System.Drawing.Font("Calibri", 22F);
            this.tboxValor.Location = new System.Drawing.Point(201, 226);
            this.tboxValor.Name = "tboxValor";
            this.tboxValor.Size = new System.Drawing.Size(194, 43);
            this.tboxValor.TabIndex = 0;
            this.tboxValor.Text = "0,00";
            this.tboxValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxValor_KeyDown);
            // 
            // cboxContribuicao
            // 
            this.cboxContribuicao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxContribuicao.Font = new System.Drawing.Font("Calibri", 22F);
            this.cboxContribuicao.FormattingEnabled = true;
            this.cboxContribuicao.Location = new System.Drawing.Point(16, 80);
            this.cboxContribuicao.Name = "cboxContribuicao";
            this.cboxContribuicao.Size = new System.Drawing.Size(378, 44);
            this.cboxContribuicao.TabIndex = 1;
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.panelBarraTitulo.BackgroundImage = global::CleverSoft.Properties.Resources.degrade;
            this.panelBarraTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBarraTitulo.Controls.Add(this.lbl_NomeRotina);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(412, 45);
            this.panelBarraTitulo.TabIndex = 1;
            // 
            // lbl_NomeRotina
            // 
            this.lbl_NomeRotina.AutoSize = true;
            this.lbl_NomeRotina.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NomeRotina.Font = new System.Drawing.Font("Calibri Light", 18F);
            this.lbl_NomeRotina.ForeColor = System.Drawing.Color.Snow;
            this.lbl_NomeRotina.Location = new System.Drawing.Point(0, 7);
            this.lbl_NomeRotina.Name = "lbl_NomeRotina";
            this.lbl_NomeRotina.Size = new System.Drawing.Size(166, 29);
            this.lbl_NomeRotina.TabIndex = 1;
            this.lbl_NomeRotina.Text = "Nome da Rotina";
            // 
            // frmNovaContribuicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 354);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNovaContribuicao";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNovaContribuicao";
            this.Load += new System.EventHandler(this.frmNovaContribuicao_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker tboxDtLanc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxValor;
        private System.Windows.Forms.ComboBox cboxContribuicao;
        internal System.Windows.Forms.Panel panelBarraTitulo;
        internal System.Windows.Forms.Label lbl_NomeRotina;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxFormaPagamento;
    }
}