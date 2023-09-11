namespace CleverSoft.Ordem_de_Serviço
{
    partial class frmLancaPendencia
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
            this.tboxDtLanc = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxNumPedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovo = new System.Windows.Forms.Button();
            this.tboxNumDoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxDtFinalizacao = new System.Windows.Forms.DateTimePicker();
            this.cboxFinalizado = new System.Windows.Forms.CheckBox();
            this.lbl_NomeRotina = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.panel1.BackgroundImage = global::CleverSoft.Properties.Resources.degrade;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lbl_NomeRotina);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 53);
            this.panel1.TabIndex = 0;
            // 
            // tboxDtLanc
            // 
            this.tboxDtLanc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tboxDtLanc.Location = new System.Drawing.Point(194, 77);
            this.tboxDtLanc.Name = "tboxDtLanc";
            this.tboxDtLanc.Size = new System.Drawing.Size(103, 23);
            this.tboxDtLanc.TabIndex = 132;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 131;
            this.label3.Text = "Data Lanc.";
            // 
            // tboxNumPedido
            // 
            this.tboxNumPedido.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tboxNumPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxNumPedido.Location = new System.Drawing.Point(10, 77);
            this.tboxNumPedido.MaxLength = 45;
            this.tboxNumPedido.Name = "tboxNumPedido";
            this.tboxNumPedido.ReadOnly = true;
            this.tboxNumPedido.Size = new System.Drawing.Size(86, 23);
            this.tboxNumPedido.TabIndex = 130;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 129;
            this.label2.Text = "Nº OS";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(10, 117);
            this.textBox1.MaxLength = 45;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(665, 23);
            this.textBox1.TabIndex = 133;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 134;
            this.label1.Text = "Descrição";
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNovo.Location = new System.Drawing.Point(549, 232);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(124, 29);
            this.btnNovo.TabIndex = 191;
            this.btnNovo.Text = "Confirmar";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // tboxNumDoc
            // 
            this.tboxNumDoc.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tboxNumDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxNumDoc.Location = new System.Drawing.Point(102, 77);
            this.tboxNumDoc.MaxLength = 45;
            this.tboxNumDoc.Name = "tboxNumDoc";
            this.tboxNumDoc.ReadOnly = true;
            this.tboxNumDoc.Size = new System.Drawing.Size(86, 23);
            this.tboxNumDoc.TabIndex = 193;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 192;
            this.label4.Text = "Nº Pedido";
            // 
            // tboxDtFinalizacao
            // 
            this.tboxDtFinalizacao.Enabled = false;
            this.tboxDtFinalizacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tboxDtFinalizacao.Location = new System.Drawing.Point(303, 77);
            this.tboxDtFinalizacao.Name = "tboxDtFinalizacao";
            this.tboxDtFinalizacao.Size = new System.Drawing.Size(103, 23);
            this.tboxDtFinalizacao.TabIndex = 194;
            // 
            // cboxFinalizado
            // 
            this.cboxFinalizado.AutoSize = true;
            this.cboxFinalizado.Location = new System.Drawing.Point(303, 58);
            this.cboxFinalizado.Name = "cboxFinalizado";
            this.cboxFinalizado.Size = new System.Drawing.Size(84, 19);
            this.cboxFinalizado.TabIndex = 195;
            this.cboxFinalizado.Text = "Finalizado";
            this.cboxFinalizado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cboxFinalizado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cboxFinalizado.UseVisualStyleBackColor = true;
            this.cboxFinalizado.CheckedChanged += new System.EventHandler(this.cboxFinalizado_CheckedChanged);
            // 
            // lbl_NomeRotina
            // 
            this.lbl_NomeRotina.AutoSize = true;
            this.lbl_NomeRotina.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NomeRotina.Font = new System.Drawing.Font("Calibri Light", 18F);
            this.lbl_NomeRotina.ForeColor = System.Drawing.Color.Snow;
            this.lbl_NomeRotina.Location = new System.Drawing.Point(8, 11);
            this.lbl_NomeRotina.Name = "lbl_NomeRotina";
            this.lbl_NomeRotina.Size = new System.Drawing.Size(166, 29);
            this.lbl_NomeRotina.TabIndex = 2;
            this.lbl_NomeRotina.Text = "Nome da Rotina";
            // 
            // frmLancaPendencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 273);
            this.Controls.Add(this.tboxDtFinalizacao);
            this.Controls.Add(this.cboxFinalizado);
            this.Controls.Add(this.tboxNumDoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tboxDtLanc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxNumPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLancaPendencia";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lança Pendência";
            this.Load += new System.EventHandler(this.frmLancaPendencia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DateTimePicker tboxDtLanc;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tboxNumPedido;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovo;
        public System.Windows.Forms.TextBox tboxNumDoc;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker tboxDtFinalizacao;
        public System.Windows.Forms.CheckBox cboxFinalizado;
        internal System.Windows.Forms.Label lbl_NomeRotina;
    }
}