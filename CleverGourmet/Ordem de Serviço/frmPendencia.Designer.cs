namespace CleverSoft.Ordem_de_Serviço
{
    partial class frmPendencia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tboxNumDoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxDtfim = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.tboxParceiro = new System.Windows.Forms.TextBox();
            this.tboxDtini = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxNumOS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgv_resultado_pesquisa = new System.Windows.Forms.DataGridView();
            this.IDOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMDOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPENDENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTLANC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZAOSOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDERECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTCONCLUSAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCampos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado_pesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.dgv_resultado_pesquisa);
            this.panelCampos.Controls.Add(this.flowLayoutPanel2);
            this.panelCampos.Controls.Add(this.panel1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tboxNumDoc);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tboxDtfim);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnPesquisarCliente);
            this.panel1.Controls.Add(this.tboxParceiro);
            this.panel1.Controls.Add(this.tboxDtini);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tboxNumOS);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 97);
            this.panel1.TabIndex = 122;
            // 
            // tboxNumDoc
            // 
            this.tboxNumDoc.BackColor = System.Drawing.Color.White;
            this.tboxNumDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxNumDoc.Location = new System.Drawing.Point(101, 21);
            this.tboxNumDoc.MaxLength = 45;
            this.tboxNumDoc.Name = "tboxNumDoc";
            this.tboxNumDoc.Size = new System.Drawing.Size(86, 23);
            this.tboxNumDoc.TabIndex = 196;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 195;
            this.label5.Text = "Nº Pedido";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(441, 23);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 19);
            this.checkBox1.TabIndex = 194;
            this.checkBox1.Text = "Exibir Concluidas";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 193;
            this.label4.Text = "a";
            // 
            // tboxDtfim
            // 
            this.tboxDtfim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tboxDtfim.Location = new System.Drawing.Point(322, 21);
            this.tboxDtfim.Name = "tboxDtfim";
            this.tboxDtfim.Size = new System.Drawing.Size(103, 23);
            this.tboxDtfim.TabIndex = 192;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPesquisar.Location = new System.Drawing.Point(761, 56);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(124, 29);
            this.btnPesquisar.TabIndex = 191;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 165;
            this.label6.Text = "Cliente";
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPesquisarCliente.FlatAppearance.BorderSize = 0;
            this.btnPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarCliente.Image = global::CleverSoft.Properties.Resources.magnifier1;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(366, 63);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Size = new System.Drawing.Size(30, 18);
            this.btnPesquisarCliente.TabIndex = 164;
            this.btnPesquisarCliente.TabStop = false;
            this.btnPesquisarCliente.UseVisualStyleBackColor = false;
            // 
            // tboxParceiro
            // 
            this.tboxParceiro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tboxParceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxParceiro.Location = new System.Drawing.Point(9, 60);
            this.tboxParceiro.MaxLength = 45;
            this.tboxParceiro.Name = "tboxParceiro";
            this.tboxParceiro.ReadOnly = true;
            this.tboxParceiro.Size = new System.Drawing.Size(389, 23);
            this.tboxParceiro.TabIndex = 163;
            // 
            // tboxDtini
            // 
            this.tboxDtini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tboxDtini.Location = new System.Drawing.Point(193, 21);
            this.tboxDtini.Name = "tboxDtini";
            this.tboxDtini.Size = new System.Drawing.Size(103, 23);
            this.tboxDtini.TabIndex = 162;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 161;
            this.label3.Text = "Data Lanc.";
            // 
            // tboxNumOS
            // 
            this.tboxNumOS.BackColor = System.Drawing.Color.White;
            this.tboxNumOS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxNumOS.Location = new System.Drawing.Point(9, 21);
            this.tboxNumOS.MaxLength = 45;
            this.tboxNumOS.Name = "tboxNumOS";
            this.tboxNumOS.Size = new System.Drawing.Size(86, 23);
            this.tboxNumOS.TabIndex = 160;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 159;
            this.label2.Text = "Nº OS";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnNovo);
            this.flowLayoutPanel2.Controls.Add(this.btnExcluir);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 516);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(894, 35);
            this.flowLayoutPanel2.TabIndex = 123;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNovo.Location = new System.Drawing.Point(767, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(124, 29);
            this.btnNovo.TabIndex = 190;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcluir.Location = new System.Drawing.Point(637, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(124, 29);
            this.btnExcluir.TabIndex = 191;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgv_resultado_pesquisa
            // 
            this.dgv_resultado_pesquisa.AllowUserToAddRows = false;
            this.dgv_resultado_pesquisa.AllowUserToDeleteRows = false;
            this.dgv_resultado_pesquisa.AllowUserToResizeColumns = false;
            this.dgv_resultado_pesquisa.AllowUserToResizeRows = false;
            this.dgv_resultado_pesquisa.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_resultado_pesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_resultado_pesquisa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_resultado_pesquisa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_resultado_pesquisa.ColumnHeadersHeight = 30;
            this.dgv_resultado_pesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_resultado_pesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDOS,
            this.NUMDOC,
            this.IDPENDENCIA,
            this.DTLANC,
            this.DESCRICAO,
            this.RAZAOSOCIAL,
            this.ENDERECO,
            this.DTCONCLUSAO});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_resultado_pesquisa.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_resultado_pesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_resultado_pesquisa.EnableHeadersVisualStyles = false;
            this.dgv_resultado_pesquisa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_resultado_pesquisa.Location = new System.Drawing.Point(0, 97);
            this.dgv_resultado_pesquisa.MultiSelect = false;
            this.dgv_resultado_pesquisa.Name = "dgv_resultado_pesquisa";
            this.dgv_resultado_pesquisa.ReadOnly = true;
            this.dgv_resultado_pesquisa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_resultado_pesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_resultado_pesquisa.Size = new System.Drawing.Size(894, 419);
            this.dgv_resultado_pesquisa.TabIndex = 124;
            // 
            // IDOS
            // 
            this.IDOS.HeaderText = "Nº OS";
            this.IDOS.Name = "IDOS";
            this.IDOS.ReadOnly = true;
            // 
            // NUMDOC
            // 
            this.NUMDOC.HeaderText = "Nº Pedido";
            this.NUMDOC.Name = "NUMDOC";
            this.NUMDOC.ReadOnly = true;
            this.NUMDOC.Width = 80;
            // 
            // IDPENDENCIA
            // 
            this.IDPENDENCIA.HeaderText = "IDPENDENCIA";
            this.IDPENDENCIA.Name = "IDPENDENCIA";
            this.IDPENDENCIA.ReadOnly = true;
            this.IDPENDENCIA.Visible = false;
            // 
            // DTLANC
            // 
            this.DTLANC.HeaderText = "DT. LANC.";
            this.DTLANC.Name = "DTLANC";
            this.DTLANC.ReadOnly = true;
            this.DTLANC.Width = 120;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.HeaderText = "DESCRIÇÃO";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.ReadOnly = true;
            this.DESCRICAO.Width = 350;
            // 
            // RAZAOSOCIAL
            // 
            this.RAZAOSOCIAL.HeaderText = "NOME CLIENTE";
            this.RAZAOSOCIAL.Name = "RAZAOSOCIAL";
            this.RAZAOSOCIAL.ReadOnly = true;
            this.RAZAOSOCIAL.Width = 350;
            // 
            // ENDERECO
            // 
            this.ENDERECO.HeaderText = "ENDEREÇO";
            this.ENDERECO.Name = "ENDERECO";
            this.ENDERECO.ReadOnly = true;
            this.ENDERECO.Width = 200;
            // 
            // DTCONCLUSAO
            // 
            this.DTCONCLUSAO.HeaderText = "DT. CONCLUSÃO";
            this.DTCONCLUSAO.Name = "DTCONCLUSAO";
            this.DTCONCLUSAO.ReadOnly = true;
            this.DTCONCLUSAO.Width = 150;
            // 
            // frmPendencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Name = "frmPendencia";
            this.Text = "Pendências da OS";
            this.Load += new System.EventHandler(this.frmPendencia_Load);
            this.panelCampos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado_pesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker tboxDtfim;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPesquisarCliente;
        public System.Windows.Forms.TextBox tboxParceiro;
        public System.Windows.Forms.DateTimePicker tboxDtini;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tboxNumOS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.DataGridView dgv_resultado_pesquisa;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.TextBox tboxNumDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMDOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPENDENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTLANC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZAOSOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDERECO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTCONCLUSAO;
    }
}