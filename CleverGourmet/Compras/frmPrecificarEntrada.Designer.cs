namespace CleverSoft
{
    partial class frmPrecificarEntrada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_resultado_Entradas = new System.Windows.Forms.DataGridView();
            this.IDENTRADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FORNECEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgv_ItensVenda = new System.Windows.Forms.DataGridView();
            this.ITEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODPROD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODBARRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUCROP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LUCROR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.tboxMargem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tboxNumDoc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxDtFim = new System.Windows.Forms.DateTimePicker();
            this.tboxDtini = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTabelaPreco = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.panelCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado_Entradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItensVenda)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.splitContainer1);
            this.panelCampos.Controls.Add(this.panel1);
            this.panelCampos.Controls.Add(this.panel2);
            // 
            // dgv_resultado_Entradas
            // 
            this.dgv_resultado_Entradas.AllowUserToAddRows = false;
            this.dgv_resultado_Entradas.AllowUserToDeleteRows = false;
            this.dgv_resultado_Entradas.AllowUserToResizeColumns = false;
            this.dgv_resultado_Entradas.AllowUserToResizeRows = false;
            this.dgv_resultado_Entradas.BackgroundColor = System.Drawing.Color.White;
            this.dgv_resultado_Entradas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_resultado_Entradas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_resultado_Entradas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_resultado_Entradas.ColumnHeadersHeight = 30;
            this.dgv_resultado_Entradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_resultado_Entradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDENTRADA,
            this.FORNECEDOR,
            this.DATA,
            this.VALOR});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_resultado_Entradas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_resultado_Entradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_resultado_Entradas.EnableHeadersVisualStyles = false;
            this.dgv_resultado_Entradas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_resultado_Entradas.Location = new System.Drawing.Point(0, 0);
            this.dgv_resultado_Entradas.MultiSelect = false;
            this.dgv_resultado_Entradas.Name = "dgv_resultado_Entradas";
            this.dgv_resultado_Entradas.ReadOnly = true;
            this.dgv_resultado_Entradas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_resultado_Entradas.RowHeadersVisible = false;
            this.dgv_resultado_Entradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_resultado_Entradas.Size = new System.Drawing.Size(890, 126);
            this.dgv_resultado_Entradas.TabIndex = 117;
            this.dgv_resultado_Entradas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_resultado_Entradas_CellClick);
            this.dgv_resultado_Entradas.SelectionChanged += new System.EventHandler(this.dgv_resultado_Entradas_SelectionChanged);
            // 
            // IDENTRADA
            // 
            this.IDENTRADA.HeaderText = "ID";
            this.IDENTRADA.Name = "IDENTRADA";
            this.IDENTRADA.ReadOnly = true;
            this.IDENTRADA.Width = 50;
            // 
            // FORNECEDOR
            // 
            this.FORNECEDOR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FORNECEDOR.HeaderText = "FORNECEDOR";
            this.FORNECEDOR.Name = "FORNECEDOR";
            this.FORNECEDOR.ReadOnly = true;
            // 
            // DATA
            // 
            this.DATA.HeaderText = "DATA";
            this.DATA.Name = "DATA";
            this.DATA.ReadOnly = true;
            this.DATA.Width = 120;
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            this.VALOR.Width = 120;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 100);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgv_resultado_Entradas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_ItensVenda);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(894, 409);
            this.splitContainer1.SplitterDistance = 130;
            this.splitContainer1.TabIndex = 118;
            // 
            // dgv_ItensVenda
            // 
            this.dgv_ItensVenda.AllowUserToAddRows = false;
            this.dgv_ItensVenda.AllowUserToDeleteRows = false;
            this.dgv_ItensVenda.AllowUserToResizeColumns = false;
            this.dgv_ItensVenda.AllowUserToResizeRows = false;
            this.dgv_ItensVenda.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ItensVenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_ItensVenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ItensVenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ItensVenda.ColumnHeadersHeight = 30;
            this.dgv_ItensVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_ItensVenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ITEM,
            this.CODPROD,
            this.DESCRICAO,
            this.CODBARRA,
            this.QTDE,
            this.CUSTO,
            this.PVENDA,
            this.LUCROP,
            this.LUCROR});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ItensVenda.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_ItensVenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ItensVenda.EnableHeadersVisualStyles = false;
            this.dgv_ItensVenda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_ItensVenda.Location = new System.Drawing.Point(0, 46);
            this.dgv_ItensVenda.MultiSelect = false;
            this.dgv_ItensVenda.Name = "dgv_ItensVenda";
            this.dgv_ItensVenda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_ItensVenda.RowHeadersVisible = false;
            this.dgv_ItensVenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_ItensVenda.Size = new System.Drawing.Size(890, 225);
            this.dgv_ItensVenda.TabIndex = 118;
            this.dgv_ItensVenda.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ItensVenda_CellEndEdit);
            // 
            // ITEM
            // 
            this.ITEM.HeaderText = "ITEM";
            this.ITEM.Name = "ITEM";
            this.ITEM.ReadOnly = true;
            this.ITEM.Width = 50;
            // 
            // CODPROD
            // 
            this.CODPROD.HeaderText = "CÓD. PROD.";
            this.CODPROD.Name = "CODPROD";
            this.CODPROD.ReadOnly = true;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESCRICAO.HeaderText = "DESCRIÇÃO";
            this.DESCRICAO.Name = "DESCRICAO";
            this.DESCRICAO.ReadOnly = true;
            // 
            // CODBARRA
            // 
            this.CODBARRA.HeaderText = "CÓD. BARRAS";
            this.CODBARRA.Name = "CODBARRA";
            this.CODBARRA.ReadOnly = true;
            this.CODBARRA.Width = 120;
            // 
            // QTDE
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.QTDE.DefaultCellStyle = dataGridViewCellStyle4;
            this.QTDE.HeaderText = "QTDE";
            this.QTDE.Name = "QTDE";
            this.QTDE.ReadOnly = true;
            this.QTDE.Width = 80;
            // 
            // CUSTO
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CUSTO.DefaultCellStyle = dataGridViewCellStyle5;
            this.CUSTO.HeaderText = "CUSTO";
            this.CUSTO.Name = "CUSTO";
            this.CUSTO.ReadOnly = true;
            this.CUSTO.Width = 80;
            // 
            // PVENDA
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Info;
            this.PVENDA.DefaultCellStyle = dataGridViewCellStyle6;
            this.PVENDA.HeaderText = "P. VENDA";
            this.PVENDA.Name = "PVENDA";
            this.PVENDA.Width = 80;
            // 
            // LUCROP
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.LUCROP.DefaultCellStyle = dataGridViewCellStyle7;
            this.LUCROP.HeaderText = "LUCRO %";
            this.LUCROP.Name = "LUCROP";
            this.LUCROP.Width = 80;
            // 
            // LUCROR
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.LUCROR.DefaultCellStyle = dataGridViewCellStyle8;
            this.LUCROR.HeaderText = "LUCRO R$";
            this.LUCROR.Name = "LUCROR";
            this.LUCROR.Width = 80;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnAplicar);
            this.panel3.Controls.Add(this.tboxMargem);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(890, 46);
            this.panel3.TabIndex = 119;
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(129, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 23);
            this.textBox1.TabIndex = 88;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 86;
            this.label6.Text = "Ajustar para";
            // 
            // btnAplicar
            // 
            this.btnAplicar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAplicar.Image = global::CleverSoft.Properties.Resources.accept_button1;
            this.btnAplicar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAplicar.Location = new System.Drawing.Point(783, 9);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(100, 30);
            this.btnAplicar.TabIndex = 6;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // tboxMargem
            // 
            this.tboxMargem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxMargem.Location = new System.Drawing.Point(3, 18);
            this.tboxMargem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxMargem.MaxLength = 45;
            this.tboxMargem.Name = "tboxMargem";
            this.tboxMargem.Size = new System.Drawing.Size(120, 23);
            this.tboxMargem.TabIndex = 83;
            this.tboxMargem.Text = "0,00";
            this.tboxMargem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxMargem.Enter += new System.EventHandler(this.tboxMargem_Enter);
            this.tboxMargem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxMargem_KeyPress);
            this.tboxMargem.Leave += new System.EventHandler(this.tboxMargem_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 15);
            this.label5.TabIndex = 84;
            this.label5.Text = "Margem de lucro (%)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tboxNumDoc);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tboxDtFim);
            this.panel1.Controls.Add(this.tboxDtini);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 100);
            this.panel1.TabIndex = 119;
            // 
            // tboxNumDoc
            // 
            this.tboxNumDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxNumDoc.Location = new System.Drawing.Point(11, 24);
            this.tboxNumDoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tboxNumDoc.MaxLength = 45;
            this.tboxNumDoc.Name = "tboxNumDoc";
            this.tboxNumDoc.Size = new System.Drawing.Size(139, 23);
            this.tboxNumDoc.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 82;
            this.label4.Text = "Nº Venda";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.Image = global::CleverSoft.Properties.Resources.find1;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(785, 60);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(100, 30);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Período";
            // 
            // tboxDtFim
            // 
            this.tboxDtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tboxDtFim.Location = new System.Drawing.Point(151, 66);
            this.tboxDtFim.Name = "tboxDtFim";
            this.tboxDtFim.Size = new System.Drawing.Size(118, 23);
            this.tboxDtFim.TabIndex = 1;
            // 
            // tboxDtini
            // 
            this.tboxDtini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tboxDtini.Location = new System.Drawing.Point(11, 66);
            this.tboxDtini.Name = "tboxDtini";
            this.tboxDtini.Size = new System.Drawing.Size(118, 23);
            this.tboxDtini.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnTabelaPreco);
            this.panel2.Controls.Add(this.btnConfirmar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 509);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(894, 42);
            this.panel2.TabIndex = 120;
            // 
            // btnTabelaPreco
            // 
            this.btnTabelaPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTabelaPreco.Image = global::CleverSoft.Properties.Resources.printer1;
            this.btnTabelaPreco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabelaPreco.Location = new System.Drawing.Point(657, 4);
            this.btnTabelaPreco.Name = "btnTabelaPreco";
            this.btnTabelaPreco.Size = new System.Drawing.Size(122, 30);
            this.btnTabelaPreco.TabIndex = 6;
            this.btnTabelaPreco.Text = "Tabela de preço";
            this.btnTabelaPreco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTabelaPreco.UseVisualStyleBackColor = true;
            this.btnTabelaPreco.Click += new System.EventHandler(this.btnTabelaPreco_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmar.Image = global::CleverSoft.Properties.Resources.accept_button1;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(785, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(100, 30);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // frmPrecificarEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Name = "frmPrecificarEntrada";
            this.Text = "Precificar Entrada";
            this.panelCampos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado_Entradas)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ItensVenda)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.DataGridView dgv_resultado_Entradas;
        public System.Windows.Forms.DataGridView dgv_ItensVenda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker tboxDtFim;
        private System.Windows.Forms.DateTimePicker tboxDtini;
        private System.Windows.Forms.Button btnConfirmar;
        public System.Windows.Forms.TextBox tboxNumDoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDENTRADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn FORNECEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODPROD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODBARRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PVENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUCROP;
        private System.Windows.Forms.DataGridViewTextBoxColumn LUCROR;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tboxMargem;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTabelaPreco;
    }
}