namespace CleverSoft.Ordem_de_Serviço
{
    partial class frmMonitorOrdemServico
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_resultado_pesquisa = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnPendencia = new System.Windows.Forms.Button();
            this.btnListaPendencia = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxDtfim = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPesquisarCliente = new System.Windows.Forms.Button();
            this.tboxParceiro = new System.Windows.Forms.TextBox();
            this.tboxDtini = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxNumPedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IDOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMDOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTLANC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZAOSOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONDOMINIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRAZO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTMEDICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTFABRICACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTART = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTINSTALACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTFINALIZADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDFUNCLANC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado_pesquisa)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.dgv_resultado_pesquisa);
            this.panelCampos.Controls.Add(this.panel1);
            this.panelCampos.Controls.Add(this.flowLayoutPanel2);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_resultado_pesquisa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_resultado_pesquisa.ColumnHeadersHeight = 30;
            this.dgv_resultado_pesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_resultado_pesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDOS,
            this.NUMDOC,
            this.DTLANC,
            this.IDCLIENTE,
            this.RAZAOSOCIAL,
            this.CONDOMINIO,
            this.PRAZO,
            this.DTMEDICAO,
            this.DTFABRICACAO,
            this.DTART,
            this.DTINSTALACAO,
            this.DTFINALIZADO,
            this.IDFUNCLANC,
            this.NOME,
            this.OBS});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_resultado_pesquisa.DefaultCellStyle = dataGridViewCellStyle8;
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
            this.dgv_resultado_pesquisa.TabIndex = 119;
            this.dgv_resultado_pesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_resultado_pesquisa_CellDoubleClick);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnNovo);
            this.flowLayoutPanel2.Controls.Add(this.btnPendencia);
            this.flowLayoutPanel2.Controls.Add(this.btnListaPendencia);
            this.flowLayoutPanel2.Controls.Add(this.btnExcluir);
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 516);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(894, 35);
            this.flowLayoutPanel2.TabIndex = 120;
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
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnPendencia
            // 
            this.btnPendencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPendencia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPendencia.Location = new System.Drawing.Point(612, 3);
            this.btnPendencia.Name = "btnPendencia";
            this.btnPendencia.Size = new System.Drawing.Size(149, 29);
            this.btnPendencia.TabIndex = 192;
            this.btnPendencia.Text = "Informar Pedência";
            this.btnPendencia.UseVisualStyleBackColor = true;
            this.btnPendencia.Click += new System.EventHandler(this.btnPendencia_Click);
            // 
            // btnListaPendencia
            // 
            this.btnListaPendencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListaPendencia.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnListaPendencia.Location = new System.Drawing.Point(457, 3);
            this.btnListaPendencia.Name = "btnListaPendencia";
            this.btnListaPendencia.Size = new System.Drawing.Size(149, 29);
            this.btnListaPendencia.TabIndex = 193;
            this.btnListaPendencia.Text = "Relação de Pedência";
            this.btnListaPendencia.UseVisualStyleBackColor = true;
            this.btnListaPendencia.Click += new System.EventHandler(this.btnListaPendencia_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcluir.Location = new System.Drawing.Point(327, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(124, 29);
            this.btnExcluir.TabIndex = 191;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(172, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 29);
            this.button1.TabIndex = 194;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tboxDtfim);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnPesquisarCliente);
            this.panel1.Controls.Add(this.tboxParceiro);
            this.panel1.Controls.Add(this.tboxDtini);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tboxNumPedido);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 97);
            this.panel1.TabIndex = 121;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 15);
            this.label4.TabIndex = 193;
            this.label4.Text = "a";
            // 
            // tboxDtfim
            // 
            this.tboxDtfim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tboxDtfim.Location = new System.Drawing.Point(230, 21);
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
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
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
            this.tboxDtini.Location = new System.Drawing.Point(101, 21);
            this.tboxDtini.Name = "tboxDtini";
            this.tboxDtini.Size = new System.Drawing.Size(103, 23);
            this.tboxDtini.TabIndex = 162;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 161;
            this.label3.Text = "Data Lanc.";
            // 
            // tboxNumPedido
            // 
            this.tboxNumPedido.BackColor = System.Drawing.Color.White;
            this.tboxNumPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxNumPedido.Location = new System.Drawing.Point(9, 21);
            this.tboxNumPedido.MaxLength = 45;
            this.tboxNumPedido.Name = "tboxNumPedido";
            this.tboxNumPedido.Size = new System.Drawing.Size(86, 23);
            this.tboxNumPedido.TabIndex = 160;
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
            // IDOS
            // 
            this.IDOS.HeaderText = "Nº OS";
            this.IDOS.Name = "IDOS";
            this.IDOS.ReadOnly = true;
            this.IDOS.Width = 80;
            // 
            // NUMDOC
            // 
            this.NUMDOC.HeaderText = "Nº Pedido";
            this.NUMDOC.Name = "NUMDOC";
            this.NUMDOC.ReadOnly = true;
            this.NUMDOC.Width = 80;
            // 
            // DTLANC
            // 
            this.DTLANC.HeaderText = "DT. LANC";
            this.DTLANC.Name = "DTLANC";
            this.DTLANC.ReadOnly = true;
            this.DTLANC.Width = 120;
            // 
            // IDCLIENTE
            // 
            this.IDCLIENTE.HeaderText = "ID CLIENTE";
            this.IDCLIENTE.Name = "IDCLIENTE";
            this.IDCLIENTE.ReadOnly = true;
            this.IDCLIENTE.Width = 80;
            // 
            // RAZAOSOCIAL
            // 
            this.RAZAOSOCIAL.HeaderText = "NOME CLEINTE";
            this.RAZAOSOCIAL.Name = "RAZAOSOCIAL";
            this.RAZAOSOCIAL.ReadOnly = true;
            this.RAZAOSOCIAL.Width = 350;
            // 
            // CONDOMINIO
            // 
            this.CONDOMINIO.HeaderText = "CONDOMINIO";
            this.CONDOMINIO.Name = "CONDOMINIO";
            this.CONDOMINIO.ReadOnly = true;
            this.CONDOMINIO.Width = 180;
            // 
            // PRAZO
            // 
            this.PRAZO.HeaderText = "PRAZO";
            this.PRAZO.Name = "PRAZO";
            this.PRAZO.ReadOnly = true;
            this.PRAZO.Width = 80;
            // 
            // DTMEDICAO
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.DTMEDICAO.DefaultCellStyle = dataGridViewCellStyle2;
            this.DTMEDICAO.HeaderText = "DT. MEDIÇÃO";
            this.DTMEDICAO.Name = "DTMEDICAO";
            this.DTMEDICAO.ReadOnly = true;
            this.DTMEDICAO.Width = 120;
            // 
            // DTFABRICACAO
            // 
            dataGridViewCellStyle3.Format = "d";
            this.DTFABRICACAO.DefaultCellStyle = dataGridViewCellStyle3;
            this.DTFABRICACAO.HeaderText = "DT. FABRICAÇÃO";
            this.DTFABRICACAO.Name = "DTFABRICACAO";
            this.DTFABRICACAO.ReadOnly = true;
            this.DTFABRICACAO.Width = 120;
            // 
            // DTART
            // 
            dataGridViewCellStyle4.Format = "d";
            this.DTART.DefaultCellStyle = dataGridViewCellStyle4;
            this.DTART.HeaderText = "DT. ART";
            this.DTART.Name = "DTART";
            this.DTART.ReadOnly = true;
            this.DTART.Width = 120;
            // 
            // DTINSTALACAO
            // 
            dataGridViewCellStyle5.Format = "d";
            this.DTINSTALACAO.DefaultCellStyle = dataGridViewCellStyle5;
            this.DTINSTALACAO.HeaderText = "DT. INSTALAÇÃO";
            this.DTINSTALACAO.Name = "DTINSTALACAO";
            this.DTINSTALACAO.ReadOnly = true;
            this.DTINSTALACAO.Width = 120;
            // 
            // DTFINALIZADO
            // 
            dataGridViewCellStyle6.Format = "d";
            this.DTFINALIZADO.DefaultCellStyle = dataGridViewCellStyle6;
            this.DTFINALIZADO.HeaderText = "DT. FINALIZAÇÃO";
            this.DTFINALIZADO.Name = "DTFINALIZADO";
            this.DTFINALIZADO.ReadOnly = true;
            this.DTFINALIZADO.Width = 120;
            // 
            // IDFUNCLANC
            // 
            dataGridViewCellStyle7.Format = "d";
            this.IDFUNCLANC.DefaultCellStyle = dataGridViewCellStyle7;
            this.IDFUNCLANC.HeaderText = "ID. FUNC.";
            this.IDFUNCLANC.Name = "IDFUNCLANC";
            this.IDFUNCLANC.ReadOnly = true;
            this.IDFUNCLANC.Width = 120;
            // 
            // NOME
            // 
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            this.NOME.Width = 350;
            // 
            // OBS
            // 
            this.OBS.HeaderText = "OBS";
            this.OBS.Name = "OBS";
            this.OBS.ReadOnly = true;
            this.OBS.Width = 500;
            // 
            // frmMonitorOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Name = "frmMonitorOrdemServico";
            this.Text = "Monitor de Ordem de Serviço";
            this.Load += new System.EventHandler(this.frmMonitorOrdemServico_Load);
            this.panelCampos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado_pesquisa)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_resultado_pesquisa;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPesquisarCliente;
        public System.Windows.Forms.TextBox tboxParceiro;
        public System.Windows.Forms.DateTimePicker tboxDtini;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tboxNumPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker tboxDtfim;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPendencia;
        private System.Windows.Forms.Button btnListaPendencia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMDOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTLANC;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZAOSOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONDOMINIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRAZO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTMEDICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTFABRICACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTART;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTINSTALACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTFINALIZADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFUNCLANC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBS;
    }
}