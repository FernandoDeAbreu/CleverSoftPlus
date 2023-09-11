namespace CleverSoft.Financeiro
{
    partial class frmFinanceiro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_resultado_pesquisa = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBaixrTitulo = new System.Windows.Forms.Button();
            this.btnRecibo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.btnImprimirFicha = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnTodas = new System.Windows.Forms.RadioButton();
            this.rbtnEmAberto = new System.Windows.Forms.RadioButton();
            this.rbtn_Pagas = new System.Windows.Forms.RadioButton();
            this.tboxNumDocP = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_pesquisarMoeda = new System.Windows.Forms.Button();
            this.btn_pesquisarBancoConta = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.tboxMoeda = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tboxBancoConta = new System.Windows.Forms.TextBox();
            this.tboxTipoData = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tboxDtFim = new System.Windows.Forms.DateTimePicker();
            this.label22 = new System.Windows.Forms.Label();
            this.tboxDTIni = new System.Windows.Forms.DateTimePicker();
            this.btn_pesquisarContaGerencial = new System.Windows.Forms.Button();
            this.tboxHistoricoP = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tboxCategoria = new System.Windows.Forms.TextBox();
            this.btn_pesquisarParceiro = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.tboxParceiro = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tboxNumLanc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado_pesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.dgv_resultado_pesquisa);
            this.panelCampos.Controls.Add(this.panel3);
            this.panelCampos.Controls.Add(this.panel2);
            this.panelCampos.Controls.Add(this.panel1);
            // 
            // dgv_resultado_pesquisa
            // 
            this.dgv_resultado_pesquisa.AllowUserToAddRows = false;
            this.dgv_resultado_pesquisa.AllowUserToDeleteRows = false;
            this.dgv_resultado_pesquisa.AllowUserToResizeRows = false;
            this.dgv_resultado_pesquisa.BackgroundColor = System.Drawing.Color.White;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_resultado_pesquisa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_resultado_pesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_resultado_pesquisa.EnableHeadersVisualStyles = false;
            this.dgv_resultado_pesquisa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_resultado_pesquisa.Location = new System.Drawing.Point(0, 144);
            this.dgv_resultado_pesquisa.MultiSelect = false;
            this.dgv_resultado_pesquisa.Name = "dgv_resultado_pesquisa";
            this.dgv_resultado_pesquisa.ReadOnly = true;
            this.dgv_resultado_pesquisa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_resultado_pesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_resultado_pesquisa.Size = new System.Drawing.Size(894, 322);
            this.dgv_resultado_pesquisa.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBaixrTitulo);
            this.panel1.Controls.Add(this.btnRecibo);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(this.btn_Imprimir);
            this.panel1.Controls.Add(this.btnImprimirFicha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 516);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 35);
            this.panel1.TabIndex = 42;
            // 
            // btnBaixrTitulo
            // 
            this.btnBaixrTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBaixrTitulo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBaixrTitulo.Location = new System.Drawing.Point(543, 3);
            this.btnBaixrTitulo.Name = "btnBaixrTitulo";
            this.btnBaixrTitulo.Size = new System.Drawing.Size(111, 29);
            this.btnBaixrTitulo.TabIndex = 206;
            this.btnBaixrTitulo.Text = "Baixar titulo";
            this.btnBaixrTitulo.UseVisualStyleBackColor = true;
            this.btnBaixrTitulo.Click += new System.EventHandler(this.btnBaixrTitulo_Click);
            // 
            // btnRecibo
            // 
            this.btnRecibo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecibo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRecibo.Location = new System.Drawing.Point(150, 3);
            this.btnRecibo.Name = "btnRecibo";
            this.btnRecibo.Size = new System.Drawing.Size(124, 29);
            this.btnRecibo.TabIndex = 205;
            this.btnRecibo.Text = "Recibo";
            this.btnRecibo.UseVisualStyleBackColor = true;
            this.btnRecibo.Click += new System.EventHandler(this.btnRecibo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditar.Location = new System.Drawing.Point(661, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(111, 29);
            this.btnEditar.TabIndex = 204;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcluir.Location = new System.Drawing.Point(5, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(124, 29);
            this.btnExcluir.TabIndex = 203;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNovo.Location = new System.Drawing.Point(779, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(111, 29);
            this.btnNovo.TabIndex = 200;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Imprimir.Location = new System.Drawing.Point(412, 3);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(124, 29);
            this.btn_Imprimir.TabIndex = 201;
            this.btn_Imprimir.Text = "Relatório simples";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // btnImprimirFicha
            // 
            this.btnImprimirFicha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimirFicha.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnImprimirFicha.Location = new System.Drawing.Point(281, 3);
            this.btnImprimirFicha.Name = "btnImprimirFicha";
            this.btnImprimirFicha.Size = new System.Drawing.Size(124, 29);
            this.btnImprimirFicha.TabIndex = 202;
            this.btnImprimirFicha.Text = "Relatório detalhado";
            this.btnImprimirFicha.UseVisualStyleBackColor = true;
            this.btnImprimirFicha.Click += new System.EventHandler(this.btnImprimirFicha_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tboxNumLanc);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnPesquisar);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.tboxNumDocP);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.btn_pesquisarMoeda);
            this.panel2.Controls.Add(this.btn_pesquisarBancoConta);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.tboxMoeda);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.tboxBancoConta);
            this.panel2.Controls.Add(this.tboxTipoData);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.tboxDtFim);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.tboxDTIni);
            this.panel2.Controls.Add(this.btn_pesquisarContaGerencial);
            this.panel2.Controls.Add(this.tboxHistoricoP);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.tboxCategoria);
            this.panel2.Controls.Add(this.btn_pesquisarParceiro);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.tboxParceiro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 144);
            this.panel2.TabIndex = 43;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPesquisar.Location = new System.Drawing.Point(758, 104);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(124, 29);
            this.btnPesquisar.TabIndex = 193;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnTodas);
            this.groupBox1.Controls.Add(this.rbtnEmAberto);
            this.groupBox1.Controls.Add(this.rbtn_Pagas);
            this.groupBox1.Location = new System.Drawing.Point(523, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 45);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // rbtnTodas
            // 
            this.rbtnTodas.AutoSize = true;
            this.rbtnTodas.Location = new System.Drawing.Point(156, 19);
            this.rbtnTodas.Name = "rbtnTodas";
            this.rbtnTodas.Size = new System.Drawing.Size(57, 19);
            this.rbtnTodas.TabIndex = 138;
            this.rbtnTodas.Text = "Todas";
            this.rbtnTodas.UseVisualStyleBackColor = true;
            // 
            // rbtnEmAberto
            // 
            this.rbtnEmAberto.AutoSize = true;
            this.rbtnEmAberto.Checked = true;
            this.rbtnEmAberto.Location = new System.Drawing.Point(6, 19);
            this.rbtnEmAberto.Name = "rbtnEmAberto";
            this.rbtnEmAberto.Size = new System.Drawing.Size(80, 19);
            this.rbtnEmAberto.TabIndex = 136;
            this.rbtnEmAberto.TabStop = true;
            this.rbtnEmAberto.Text = "Em Aberto";
            this.rbtnEmAberto.UseVisualStyleBackColor = true;
            // 
            // rbtn_Pagas
            // 
            this.rbtn_Pagas.AutoSize = true;
            this.rbtn_Pagas.Location = new System.Drawing.Point(92, 19);
            this.rbtn_Pagas.Name = "rbtn_Pagas";
            this.rbtn_Pagas.Size = new System.Drawing.Size(58, 19);
            this.rbtn_Pagas.TabIndex = 137;
            this.rbtn_Pagas.Text = "Pagas";
            this.rbtn_Pagas.UseVisualStyleBackColor = true;
            // 
            // tboxNumDocP
            // 
            this.tboxNumDocP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxNumDocP.Location = new System.Drawing.Point(619, 65);
            this.tboxNumDocP.MaxLength = 90;
            this.tboxNumDocP.Name = "tboxNumDocP";
            this.tboxNumDocP.Size = new System.Drawing.Size(263, 23);
            this.tboxNumDocP.TabIndex = 134;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(616, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 15);
            this.label21.TabIndex = 135;
            this.label21.Text = "N° Documento";
            // 
            // btn_pesquisarMoeda
            // 
            this.btn_pesquisarMoeda.BackColor = System.Drawing.SystemColors.Control;
            this.btn_pesquisarMoeda.FlatAppearance.BorderSize = 0;
            this.btn_pesquisarMoeda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisarMoeda.Image = global::CleverSoft.Properties.Resources.magnifier1;
            this.btn_pesquisarMoeda.Location = new System.Drawing.Point(840, 23);
            this.btn_pesquisarMoeda.Name = "btn_pesquisarMoeda";
            this.btn_pesquisarMoeda.Size = new System.Drawing.Size(39, 19);
            this.btn_pesquisarMoeda.TabIndex = 133;
            this.btn_pesquisarMoeda.TabStop = false;
            this.btn_pesquisarMoeda.UseVisualStyleBackColor = false;
            this.btn_pesquisarMoeda.Click += new System.EventHandler(this.btn_pesquisarMoeda_Click);
            // 
            // btn_pesquisarBancoConta
            // 
            this.btn_pesquisarBancoConta.BackColor = System.Drawing.SystemColors.Control;
            this.btn_pesquisarBancoConta.FlatAppearance.BorderSize = 0;
            this.btn_pesquisarBancoConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisarBancoConta.Image = global::CleverSoft.Properties.Resources.magnifier1;
            this.btn_pesquisarBancoConta.Location = new System.Drawing.Point(572, 23);
            this.btn_pesquisarBancoConta.Name = "btn_pesquisarBancoConta";
            this.btn_pesquisarBancoConta.Size = new System.Drawing.Size(39, 19);
            this.btn_pesquisarBancoConta.TabIndex = 132;
            this.btn_pesquisarBancoConta.TabStop = false;
            this.btn_pesquisarBancoConta.UseVisualStyleBackColor = false;
            this.btn_pesquisarBancoConta.Click += new System.EventHandler(this.btn_pesquisarBancoConta_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(616, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 15);
            this.label16.TabIndex = 131;
            this.label16.Text = "Moeda";
            // 
            // tboxMoeda
            // 
            this.tboxMoeda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxMoeda.Location = new System.Drawing.Point(620, 21);
            this.tboxMoeda.MaxLength = 45;
            this.tboxMoeda.Name = "tboxMoeda";
            this.tboxMoeda.ReadOnly = true;
            this.tboxMoeda.Size = new System.Drawing.Size(262, 23);
            this.tboxMoeda.TabIndex = 129;
            this.tboxMoeda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxMoeda_KeyDown);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(362, 2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 15);
            this.label17.TabIndex = 130;
            this.label17.Text = "Banco / Conta";
            // 
            // tboxBancoConta
            // 
            this.tboxBancoConta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxBancoConta.Location = new System.Drawing.Point(366, 21);
            this.tboxBancoConta.MaxLength = 45;
            this.tboxBancoConta.Name = "tboxBancoConta";
            this.tboxBancoConta.ReadOnly = true;
            this.tboxBancoConta.Size = new System.Drawing.Size(248, 23);
            this.tboxBancoConta.TabIndex = 128;
            this.tboxBancoConta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxBancoConta_KeyDown);
            // 
            // tboxTipoData
            // 
            this.tboxTipoData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tboxTipoData.FormattingEnabled = true;
            this.tboxTipoData.Items.AddRange(new object[] {
            "TODOS",
            "LANÇAMENTO",
            "PAGAMENTO",
            "COMPETÊNCIA",
            "VENCIMENTO"});
            this.tboxTipoData.Location = new System.Drawing.Point(118, 110);
            this.tboxTipoData.Name = "tboxTipoData";
            this.tboxTipoData.Size = new System.Drawing.Size(147, 23);
            this.tboxTipoData.TabIndex = 127;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(389, 114);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(14, 15);
            this.label23.TabIndex = 126;
            this.label23.Text = "à";
            // 
            // tboxDtFim
            // 
            this.tboxDtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tboxDtFim.Location = new System.Drawing.Point(409, 110);
            this.tboxDtFim.Name = "tboxDtFim";
            this.tboxDtFim.Size = new System.Drawing.Size(109, 23);
            this.tboxDtFim.TabIndex = 125;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(115, 91);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 15);
            this.label22.TabIndex = 124;
            this.label22.Text = "Data de ";
            // 
            // tboxDTIni
            // 
            this.tboxDTIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tboxDTIni.Location = new System.Drawing.Point(271, 110);
            this.tboxDTIni.Name = "tboxDTIni";
            this.tboxDTIni.Size = new System.Drawing.Size(112, 23);
            this.tboxDTIni.TabIndex = 123;
            // 
            // btn_pesquisarContaGerencial
            // 
            this.btn_pesquisarContaGerencial.BackColor = System.Drawing.SystemColors.Control;
            this.btn_pesquisarContaGerencial.FlatAppearance.BorderSize = 0;
            this.btn_pesquisarContaGerencial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisarContaGerencial.Image = global::CleverSoft.Properties.Resources.magnifier1;
            this.btn_pesquisarContaGerencial.Location = new System.Drawing.Point(221, 66);
            this.btn_pesquisarContaGerencial.Name = "btn_pesquisarContaGerencial";
            this.btn_pesquisarContaGerencial.Size = new System.Drawing.Size(38, 21);
            this.btn_pesquisarContaGerencial.TabIndex = 122;
            this.btn_pesquisarContaGerencial.TabStop = false;
            this.btn_pesquisarContaGerencial.UseVisualStyleBackColor = false;
            this.btn_pesquisarContaGerencial.Click += new System.EventHandler(this.btn_pesquisarContaGerencial_Click);
            // 
            // tboxHistoricoP
            // 
            this.tboxHistoricoP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxHistoricoP.Location = new System.Drawing.Point(267, 65);
            this.tboxHistoricoP.MaxLength = 90;
            this.tboxHistoricoP.Name = "tboxHistoricoP";
            this.tboxHistoricoP.Size = new System.Drawing.Size(347, 23);
            this.tboxHistoricoP.TabIndex = 119;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(267, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 15);
            this.label19.TabIndex = 121;
            this.label19.Text = "Historico";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 47);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 15);
            this.label20.TabIndex = 120;
            this.label20.Text = "Conta Gerencial";
            // 
            // tboxCategoria
            // 
            this.tboxCategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxCategoria.Location = new System.Drawing.Point(9, 65);
            this.tboxCategoria.MaxLength = 45;
            this.tboxCategoria.Name = "tboxCategoria";
            this.tboxCategoria.ReadOnly = true;
            this.tboxCategoria.Size = new System.Drawing.Size(252, 23);
            this.tboxCategoria.TabIndex = 118;
            this.tboxCategoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxCategoria_KeyDown);
            // 
            // btn_pesquisarParceiro
            // 
            this.btn_pesquisarParceiro.BackColor = System.Drawing.SystemColors.Control;
            this.btn_pesquisarParceiro.FlatAppearance.BorderSize = 0;
            this.btn_pesquisarParceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisarParceiro.Image = global::CleverSoft.Properties.Resources.magnifier1;
            this.btn_pesquisarParceiro.Location = new System.Drawing.Point(323, 23);
            this.btn_pesquisarParceiro.Name = "btn_pesquisarParceiro";
            this.btn_pesquisarParceiro.Size = new System.Drawing.Size(39, 19);
            this.btn_pesquisarParceiro.TabIndex = 117;
            this.btn_pesquisarParceiro.TabStop = false;
            this.btn_pesquisarParceiro.UseVisualStyleBackColor = false;
            this.btn_pesquisarParceiro.Click += new System.EventHandler(this.btn_pesquisarParceiro_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 2);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 15);
            this.label18.TabIndex = 116;
            this.label18.Text = "Parceiro";
            // 
            // tboxParceiro
            // 
            this.tboxParceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxParceiro.Location = new System.Drawing.Point(9, 21);
            this.tboxParceiro.MaxLength = 45;
            this.tboxParceiro.Name = "tboxParceiro";
            this.tboxParceiro.ReadOnly = true;
            this.tboxParceiro.Size = new System.Drawing.Size(354, 23);
            this.tboxParceiro.TabIndex = 115;
            this.tboxParceiro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxParceiro_KeyDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 466);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(894, 50);
            this.panel3.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(790, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 197;
            this.label5.Text = "Total R$: ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 196;
            this.label4.Text = "Desconto R$";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(580, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 195;
            this.label3.Text = "Juros R$: ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 194;
            this.label2.Text = "Valor R$: ";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(583, 21);
            this.textBox4.MaxLength = 45;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(97, 23);
            this.textBox4.TabIndex = 122;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(688, 21);
            this.textBox3.MaxLength = 45;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(97, 23);
            this.textBox3.TabIndex = 121;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(478, 21);
            this.textBox2.MaxLength = 45;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(97, 23);
            this.textBox2.TabIndex = 120;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(793, 21);
            this.textBox1.MaxLength = 45;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(97, 23);
            this.textBox1.TabIndex = 119;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tboxNumLanc
            // 
            this.tboxNumLanc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxNumLanc.Location = new System.Drawing.Point(8, 109);
            this.tboxNumLanc.MaxLength = 90;
            this.tboxNumLanc.Name = "tboxNumLanc";
            this.tboxNumLanc.Size = new System.Drawing.Size(104, 23);
            this.tboxNumLanc.TabIndex = 194;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 195;
            this.label6.Text = "N° Lançamento";
            // 
            // frmFinanceiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Name = "frmFinanceiro";
            this.Text = "frmFinanceiro";
            this.Load += new System.EventHandler(this.frmFinanceiro_Load);
            this.panelCampos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado_pesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_resultado_pesquisa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox tboxTipoData;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker tboxDtFim;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DateTimePicker tboxDTIni;
        private System.Windows.Forms.Button btn_pesquisarContaGerencial;
        public System.Windows.Forms.TextBox tboxHistoricoP;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox tboxCategoria;
        private System.Windows.Forms.Button btn_pesquisarParceiro;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox tboxParceiro;
        private System.Windows.Forms.RadioButton rbtnTodas;
        private System.Windows.Forms.RadioButton rbtn_Pagas;
        private System.Windows.Forms.RadioButton rbtnEmAberto;
        public System.Windows.Forms.TextBox tboxNumDocP;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_pesquisarMoeda;
        private System.Windows.Forms.Button btn_pesquisarBancoConta;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox tboxMoeda;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox tboxBancoConta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.Button btnImprimirFicha;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox4;
        public System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRecibo;
        private System.Windows.Forms.Button btnBaixrTitulo;
        public System.Windows.Forms.TextBox tboxNumLanc;
        private System.Windows.Forms.Label label6;
    }
}