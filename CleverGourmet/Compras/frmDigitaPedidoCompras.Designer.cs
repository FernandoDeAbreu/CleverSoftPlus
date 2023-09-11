namespace CleverSoft
{
    partial class frmDigitaPedidoCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnImportarXML = new System.Windows.Forms.Button();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.tboxDescontoTotal = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tboxOutrosCustoTotal = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tboxIPItotal = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tboxTotalTotal = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tboxQtdeTotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tboxUnd = new System.Windows.Forms.TextBox();
            this.btn_Incluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.tboxItem = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tboxTotalUnit = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tboxDesconto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tboxOutrosCusto = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tboxIPI = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tboxTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tboxPCusto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tboxQtde = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tboxCodAuxiliar = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxDescricao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_resultado_pesquisa = new System.Windows.Forms.DataGridView();
            this.tboxCodigo = new System.Windows.Forms.TextBox();
            this.tboxLocalizarProduto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.tbox_TotalParcelas = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tboxQtdeParcelas = new System.Windows.Forms.TextBox();
            this.btnI_incluirContasPagar = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.tbox_TotalFinal = new System.Windows.Forms.TextBox();
            this.dgv_formaPagto = new System.Windows.Forms.DataGridView();
            this.tboxNumPedido = new System.Windows.Forms.TextBox();
            this.btnPesquisarParceiro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxParceiro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTVENC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VLREXTENSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODMOEDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDBANCOCONTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCampos.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado_pesquisa)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_formaPagto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.tboxNumPedido);
            this.panelCampos.Controls.Add(this.btnPesquisarParceiro);
            this.panelCampos.Controls.Add(this.label3);
            this.panelCampos.Controls.Add(this.tboxParceiro);
            this.panelCampos.Controls.Add(this.label2);
            this.panelCampos.Controls.Add(this.tabControl2);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(-4, 87);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(902, 468);
            this.tabControl2.TabIndex = 120;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.btnImportarXML);
            this.tabPage3.Controls.Add(this.btnPesquisarProduto);
            this.tabPage3.Controls.Add(this.btnRemover);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.tboxDescontoTotal);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.tboxOutrosCustoTotal);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.tboxIPItotal);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.tboxTotalTotal);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.tboxQtdeTotal);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.tboxUnd);
            this.tabPage3.Controls.Add(this.btn_Incluir);
            this.tabPage3.Controls.Add(this.btnPesquisar);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.tboxItem);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.tboxTotalUnit);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.tboxDesconto);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.tboxOutrosCusto);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.tboxIPI);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.tboxTotal);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.tboxPCusto);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.tboxQtde);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.tboxCodAuxiliar);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.tboxDescricao);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.dgv_resultado_pesquisa);
            this.tabPage3.Controls.Add(this.tboxCodigo);
            this.tabPage3.Controls.Add(this.tboxLocalizarProduto);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.ForeColor = System.Drawing.Color.Black;
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(894, 440);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Pesquisar Produto";
            // 
            // btnImportarXML
            // 
            this.btnImportarXML.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnImportarXML.Location = new System.Drawing.Point(453, 24);
            this.btnImportarXML.Name = "btnImportarXML";
            this.btnImportarXML.Size = new System.Drawing.Size(97, 26);
            this.btnImportarXML.TabIndex = 166;
            this.btnImportarXML.Text = "Importar XML";
            this.btnImportarXML.UseVisualStyleBackColor = true;
            this.btnImportarXML.Click += new System.EventHandler(this.btnImportarXML_Click);
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.BackColor = System.Drawing.Color.White;
            this.btnPesquisarProduto.FlatAppearance.BorderSize = 0;
            this.btnPesquisarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarProduto.Image = global::CleverSoft.Properties.Resources.magnifier1;
            this.btnPesquisarProduto.Location = new System.Drawing.Point(286, 27);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(30, 19);
            this.btnPesquisarProduto.TabIndex = 120;
            this.btnPesquisarProduto.TabStop = false;
            this.btnPesquisarProduto.UseVisualStyleBackColor = false;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Enabled = false;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemover.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemover.Location = new System.Drawing.Point(809, 110);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(79, 26);
            this.btnRemover.TabIndex = 165;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(696, 392);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 15);
            this.label18.TabIndex = 164;
            this.label18.Text = "Descontos";
            // 
            // tboxDescontoTotal
            // 
            this.tboxDescontoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxDescontoTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tboxDescontoTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxDescontoTotal.Location = new System.Drawing.Point(696, 408);
            this.tboxDescontoTotal.MaxLength = 45;
            this.tboxDescontoTotal.Name = "tboxDescontoTotal";
            this.tboxDescontoTotal.ReadOnly = true;
            this.tboxDescontoTotal.Size = new System.Drawing.Size(94, 23);
            this.tboxDescontoTotal.TabIndex = 156;
            this.tboxDescontoTotal.Text = "0,00";
            this.tboxDescontoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(596, 392);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 15);
            this.label20.TabIndex = 163;
            this.label20.Text = "Outros Custo";
            // 
            // tboxOutrosCustoTotal
            // 
            this.tboxOutrosCustoTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxOutrosCustoTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tboxOutrosCustoTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxOutrosCustoTotal.Location = new System.Drawing.Point(596, 408);
            this.tboxOutrosCustoTotal.MaxLength = 45;
            this.tboxOutrosCustoTotal.Name = "tboxOutrosCustoTotal";
            this.tboxOutrosCustoTotal.ReadOnly = true;
            this.tboxOutrosCustoTotal.Size = new System.Drawing.Size(94, 23);
            this.tboxOutrosCustoTotal.TabIndex = 155;
            this.tboxOutrosCustoTotal.Text = "0,00";
            this.tboxOutrosCustoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(496, 392);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(22, 15);
            this.label21.TabIndex = 162;
            this.label21.Text = "IPI";
            // 
            // tboxIPItotal
            // 
            this.tboxIPItotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxIPItotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tboxIPItotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxIPItotal.Location = new System.Drawing.Point(496, 408);
            this.tboxIPItotal.MaxLength = 45;
            this.tboxIPItotal.Name = "tboxIPItotal";
            this.tboxIPItotal.ReadOnly = true;
            this.tboxIPItotal.Size = new System.Drawing.Size(94, 23);
            this.tboxIPItotal.TabIndex = 154;
            this.tboxIPItotal.Text = "0,00";
            this.tboxIPItotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(792, 392);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(34, 15);
            this.label22.TabIndex = 161;
            this.label22.Text = "Total";
            // 
            // tboxTotalTotal
            // 
            this.tboxTotalTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxTotalTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tboxTotalTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxTotalTotal.Location = new System.Drawing.Point(796, 408);
            this.tboxTotalTotal.MaxLength = 45;
            this.tboxTotalTotal.Name = "tboxTotalTotal";
            this.tboxTotalTotal.ReadOnly = true;
            this.tboxTotalTotal.Size = new System.Drawing.Size(94, 23);
            this.tboxTotalTotal.TabIndex = 158;
            this.tboxTotalTotal.Text = "0,00";
            this.tboxTotalTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(393, 392);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(36, 15);
            this.label24.TabIndex = 159;
            this.label24.Text = "Qtde.";
            // 
            // tboxQtdeTotal
            // 
            this.tboxQtdeTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxQtdeTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tboxQtdeTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxQtdeTotal.Location = new System.Drawing.Point(395, 408);
            this.tboxQtdeTotal.MaxLength = 45;
            this.tboxQtdeTotal.Name = "tboxQtdeTotal";
            this.tboxQtdeTotal.ReadOnly = true;
            this.tboxQtdeTotal.Size = new System.Drawing.Size(94, 23);
            this.tboxQtdeTotal.TabIndex = 152;
            this.tboxQtdeTotal.Text = "0,00";
            this.tboxQtdeTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(742, 54);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 15);
            this.label16.TabIndex = 151;
            this.label16.Text = "Und.";
            // 
            // tboxUnd
            // 
            this.tboxUnd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tboxUnd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxUnd.Location = new System.Drawing.Point(742, 70);
            this.tboxUnd.MaxLength = 45;
            this.tboxUnd.Name = "tboxUnd";
            this.tboxUnd.ReadOnly = true;
            this.tboxUnd.Size = new System.Drawing.Size(65, 23);
            this.tboxUnd.TabIndex = 4;
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Incluir.Location = new System.Drawing.Point(683, 110);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(124, 26);
            this.btn_Incluir.TabIndex = 12;
            this.btn_Incluir.Text = "Incluir";
            this.btn_Incluir.UseVisualStyleBackColor = true;
            this.btn_Incluir.Click += new System.EventHandler(this.btn_Incluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPesquisar.Location = new System.Drawing.Point(324, 24);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(124, 26);
            this.btnPesquisar.TabIndex = 148;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 15);
            this.label19.TabIndex = 147;
            this.label19.Text = "Item";
            // 
            // tboxItem
            // 
            this.tboxItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tboxItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxItem.Location = new System.Drawing.Point(12, 70);
            this.tboxItem.MaxLength = 45;
            this.tboxItem.Name = "tboxItem";
            this.tboxItem.ReadOnly = true;
            this.tboxItem.Size = new System.Drawing.Size(81, 23);
            this.tboxItem.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(491, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 15);
            this.label15.TabIndex = 139;
            this.label15.Text = "Total Unit.";
            // 
            // tboxTotalUnit
            // 
            this.tboxTotalUnit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tboxTotalUnit.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxTotalUnit.Location = new System.Drawing.Point(491, 112);
            this.tboxTotalUnit.MaxLength = 45;
            this.tboxTotalUnit.Name = "tboxTotalUnit";
            this.tboxTotalUnit.ReadOnly = true;
            this.tboxTotalUnit.Size = new System.Drawing.Size(90, 23);
            this.tboxTotalUnit.TabIndex = 10;
            this.tboxTotalUnit.Text = "0,00";
            this.tboxTotalUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxTotalUnit.Leave += new System.EventHandler(this.tboxTotalUnit_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(391, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 15);
            this.label14.TabIndex = 137;
            this.label14.Text = "Descontos(R$)";
            // 
            // tboxDesconto
            // 
            this.tboxDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxDesconto.Location = new System.Drawing.Point(391, 112);
            this.tboxDesconto.MaxLength = 45;
            this.tboxDesconto.Name = "tboxDesconto";
            this.tboxDesconto.Size = new System.Drawing.Size(94, 23);
            this.tboxDesconto.TabIndex = 9;
            this.tboxDesconto.Text = "0,00";
            this.tboxDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxDesconto.Leave += new System.EventHandler(this.tboxDesconto_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(288, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 15);
            this.label13.TabIndex = 135;
            this.label13.Text = "Outros Custo(R$)";
            // 
            // tboxOutrosCusto
            // 
            this.tboxOutrosCusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxOutrosCusto.Location = new System.Drawing.Point(291, 112);
            this.tboxOutrosCusto.MaxLength = 45;
            this.tboxOutrosCusto.Name = "tboxOutrosCusto";
            this.tboxOutrosCusto.Size = new System.Drawing.Size(94, 23);
            this.tboxOutrosCusto.TabIndex = 8;
            this.tboxOutrosCusto.Text = "0,00";
            this.tboxOutrosCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxOutrosCusto.Leave += new System.EventHandler(this.tboxOutrosCusto_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(195, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 133;
            this.label12.Text = "IPI(%)";
            // 
            // tboxIPI
            // 
            this.tboxIPI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxIPI.Location = new System.Drawing.Point(195, 112);
            this.tboxIPI.MaxLength = 45;
            this.tboxIPI.Name = "tboxIPI";
            this.tboxIPI.Size = new System.Drawing.Size(90, 23);
            this.tboxIPI.TabIndex = 7;
            this.tboxIPI.Text = "0,00";
            this.tboxIPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxIPI.Leave += new System.EventHandler(this.tboxIPI_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(587, 96);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 15);
            this.label11.TabIndex = 131;
            this.label11.Text = "Total";
            // 
            // tboxTotal
            // 
            this.tboxTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tboxTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxTotal.Location = new System.Drawing.Point(587, 112);
            this.tboxTotal.MaxLength = 45;
            this.tboxTotal.Name = "tboxTotal";
            this.tboxTotal.ReadOnly = true;
            this.tboxTotal.Size = new System.Drawing.Size(90, 23);
            this.tboxTotal.TabIndex = 11;
            this.tboxTotal.Text = "0,00";
            this.tboxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxTotal.Leave += new System.EventHandler(this.tboxTotal_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(99, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 15);
            this.label10.TabIndex = 129;
            this.label10.Text = "P. Custo(R$)";
            // 
            // tboxPCusto
            // 
            this.tboxPCusto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxPCusto.Location = new System.Drawing.Point(98, 112);
            this.tboxPCusto.MaxLength = 45;
            this.tboxPCusto.Name = "tboxPCusto";
            this.tboxPCusto.Size = new System.Drawing.Size(91, 23);
            this.tboxPCusto.TabIndex = 6;
            this.tboxPCusto.Text = "0,00";
            this.tboxPCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxPCusto.Leave += new System.EventHandler(this.tboxPCusto_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 127;
            this.label9.Text = "Qtde.";
            // 
            // tboxQtde
            // 
            this.tboxQtde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxQtde.Location = new System.Drawing.Point(12, 112);
            this.tboxQtde.MaxLength = 45;
            this.tboxQtde.Name = "tboxQtde";
            this.tboxQtde.Size = new System.Drawing.Size(81, 23);
            this.tboxQtde.TabIndex = 5;
            this.tboxQtde.Text = "0,00";
            this.tboxQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxQtde.Leave += new System.EventHandler(this.tboxQtde_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(570, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 15);
            this.label8.TabIndex = 125;
            this.label8.Text = "Código Auxiliar";
            // 
            // tboxCodAuxiliar
            // 
            this.tboxCodAuxiliar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tboxCodAuxiliar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxCodAuxiliar.Location = new System.Drawing.Point(570, 70);
            this.tboxCodAuxiliar.MaxLength = 45;
            this.tboxCodAuxiliar.Name = "tboxCodAuxiliar";
            this.tboxCodAuxiliar.ReadOnly = true;
            this.tboxCodAuxiliar.Size = new System.Drawing.Size(166, 23);
            this.tboxCodAuxiliar.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(195, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 123;
            this.label7.Text = "Descrição";
            // 
            // tboxDescricao
            // 
            this.tboxDescricao.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tboxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxDescricao.Location = new System.Drawing.Point(195, 70);
            this.tboxDescricao.MaxLength = 45;
            this.tboxDescricao.Name = "tboxDescricao";
            this.tboxDescricao.ReadOnly = true;
            this.tboxDescricao.Size = new System.Drawing.Size(369, 23);
            this.tboxDescricao.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 121;
            this.label6.Text = "Código";
            // 
            // dgv_resultado_pesquisa
            // 
            this.dgv_resultado_pesquisa.AllowUserToAddRows = false;
            this.dgv_resultado_pesquisa.AllowUserToDeleteRows = false;
            this.dgv_resultado_pesquisa.AllowUserToResizeColumns = false;
            this.dgv_resultado_pesquisa.AllowUserToResizeRows = false;
            this.dgv_resultado_pesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_resultado_pesquisa.BackgroundColor = System.Drawing.Color.White;
            this.dgv_resultado_pesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_resultado_pesquisa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_resultado_pesquisa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_resultado_pesquisa.ColumnHeadersHeight = 30;
            this.dgv_resultado_pesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_resultado_pesquisa.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_resultado_pesquisa.EnableHeadersVisualStyles = false;
            this.dgv_resultado_pesquisa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_resultado_pesquisa.Location = new System.Drawing.Point(1, 155);
            this.dgv_resultado_pesquisa.MultiSelect = false;
            this.dgv_resultado_pesquisa.Name = "dgv_resultado_pesquisa";
            this.dgv_resultado_pesquisa.ReadOnly = true;
            this.dgv_resultado_pesquisa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_resultado_pesquisa.RowHeadersVisible = false;
            this.dgv_resultado_pesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_resultado_pesquisa.Size = new System.Drawing.Size(892, 234);
            this.dgv_resultado_pesquisa.TabIndex = 116;
            this.dgv_resultado_pesquisa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_resultado_pesquisa_CellClick);
            // 
            // tboxCodigo
            // 
            this.tboxCodigo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tboxCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxCodigo.Location = new System.Drawing.Point(98, 70);
            this.tboxCodigo.MaxLength = 45;
            this.tboxCodigo.Name = "tboxCodigo";
            this.tboxCodigo.ReadOnly = true;
            this.tboxCodigo.Size = new System.Drawing.Size(91, 23);
            this.tboxCodigo.TabIndex = 1;
            // 
            // tboxLocalizarProduto
            // 
            this.tboxLocalizarProduto.Location = new System.Drawing.Point(11, 25);
            this.tboxLocalizarProduto.Margin = new System.Windows.Forms.Padding(0);
            this.tboxLocalizarProduto.MaxLength = 30;
            this.tboxLocalizarProduto.Name = "tboxLocalizarProduto";
            this.tboxLocalizarProduto.Size = new System.Drawing.Size(307, 23);
            this.tboxLocalizarProduto.TabIndex = 0;
            this.tboxLocalizarProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxLocalizarProduto_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 15);
            this.label5.TabIndex = 115;
            this.label5.Text = "Pesquisar produto por Código Auxiliar";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.tbox_TotalParcelas);
            this.tabPage4.Controls.Add(this.label29);
            this.tabPage4.Controls.Add(this.tboxQtdeParcelas);
            this.tabPage4.Controls.Add(this.btnI_incluirContasPagar);
            this.tabPage4.Controls.Add(this.label26);
            this.tabPage4.Controls.Add(this.tbox_TotalFinal);
            this.tabPage4.Controls.Add(this.dgv_formaPagto);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(894, 440);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Forma de pagamento";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(761, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 29);
            this.button1.TabIndex = 184;
            this.button1.Text = "Gravar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 370);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 15);
            this.label17.TabIndex = 183;
            this.label17.Text = "Total das parcelas";
            // 
            // tbox_TotalParcelas
            // 
            this.tbox_TotalParcelas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbox_TotalParcelas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbox_TotalParcelas.Location = new System.Drawing.Point(7, 388);
            this.tbox_TotalParcelas.MaxLength = 45;
            this.tbox_TotalParcelas.Name = "tbox_TotalParcelas";
            this.tbox_TotalParcelas.ReadOnly = true;
            this.tbox_TotalParcelas.Size = new System.Drawing.Size(115, 23);
            this.tbox_TotalParcelas.TabIndex = 182;
            this.tbox_TotalParcelas.Text = "0,00";
            this.tbox_TotalParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(131, 8);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(84, 15);
            this.label29.TabIndex = 179;
            this.label29.Text = "Qtde Parcelas";
            // 
            // tboxQtdeParcelas
            // 
            this.tboxQtdeParcelas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxQtdeParcelas.Location = new System.Drawing.Point(131, 25);
            this.tboxQtdeParcelas.MaxLength = 45;
            this.tboxQtdeParcelas.Name = "tboxQtdeParcelas";
            this.tboxQtdeParcelas.Size = new System.Drawing.Size(84, 23);
            this.tboxQtdeParcelas.TabIndex = 178;
            this.tboxQtdeParcelas.Text = "1";
            this.tboxQtdeParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tboxQtdeParcelas.Leave += new System.EventHandler(this.tboxValor_Leave_1);
            // 
            // btnI_incluirContasPagar
            // 
            this.btnI_incluirContasPagar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnI_incluirContasPagar.Location = new System.Drawing.Point(247, 21);
            this.btnI_incluirContasPagar.Name = "btnI_incluirContasPagar";
            this.btnI_incluirContasPagar.Size = new System.Drawing.Size(124, 29);
            this.btnI_incluirContasPagar.TabIndex = 177;
            this.btnI_incluirContasPagar.Text = "Gerar";
            this.btnI_incluirContasPagar.UseVisualStyleBackColor = true;
            this.btnI_incluirContasPagar.Click += new System.EventHandler(this.btnI_incluirContasPagar_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 4);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 15);
            this.label26.TabIndex = 171;
            this.label26.Text = "Total pedido";
            // 
            // tbox_TotalFinal
            // 
            this.tbox_TotalFinal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbox_TotalFinal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbox_TotalFinal.Location = new System.Drawing.Point(10, 25);
            this.tbox_TotalFinal.MaxLength = 45;
            this.tbox_TotalFinal.Name = "tbox_TotalFinal";
            this.tbox_TotalFinal.ReadOnly = true;
            this.tbox_TotalFinal.Size = new System.Drawing.Size(115, 23);
            this.tbox_TotalFinal.TabIndex = 169;
            this.tbox_TotalFinal.Text = "0,00";
            this.tbox_TotalFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgv_formaPagto
            // 
            this.dgv_formaPagto.AllowUserToAddRows = false;
            this.dgv_formaPagto.AllowUserToDeleteRows = false;
            this.dgv_formaPagto.AllowUserToResizeColumns = false;
            this.dgv_formaPagto.AllowUserToResizeRows = false;
            this.dgv_formaPagto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_formaPagto.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_formaPagto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_formaPagto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_formaPagto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_formaPagto.ColumnHeadersHeight = 30;
            this.dgv_formaPagto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_formaPagto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SEQ,
            this.VALOR,
            this.DTVENC,
            this.VLREXTENSO,
            this.CODMOEDA,
            this.IDBANCOCONTA});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_formaPagto.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_formaPagto.EnableHeadersVisualStyles = false;
            this.dgv_formaPagto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_formaPagto.Location = new System.Drawing.Point(1, 108);
            this.dgv_formaPagto.MultiSelect = false;
            this.dgv_formaPagto.Name = "dgv_formaPagto";
            this.dgv_formaPagto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_formaPagto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_formaPagto.Size = new System.Drawing.Size(889, 254);
            this.dgv_formaPagto.TabIndex = 117;
            // 
            // tboxNumPedido
            // 
            this.tboxNumPedido.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tboxNumPedido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxNumPedido.Location = new System.Drawing.Point(7, 24);
            this.tboxNumPedido.MaxLength = 45;
            this.tboxNumPedido.Name = "tboxNumPedido";
            this.tboxNumPedido.ReadOnly = true;
            this.tboxNumPedido.Size = new System.Drawing.Size(86, 23);
            this.tboxNumPedido.TabIndex = 125;
            // 
            // btnPesquisarParceiro
            // 
            this.btnPesquisarParceiro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPesquisarParceiro.FlatAppearance.BorderSize = 0;
            this.btnPesquisarParceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarParceiro.Image = global::CleverSoft.Properties.Resources.magnifier1;
            this.btnPesquisarParceiro.Location = new System.Drawing.Point(521, 26);
            this.btnPesquisarParceiro.Name = "btnPesquisarParceiro";
            this.btnPesquisarParceiro.Size = new System.Drawing.Size(30, 18);
            this.btnPesquisarParceiro.TabIndex = 124;
            this.btnPesquisarParceiro.TabStop = false;
            this.btnPesquisarParceiro.UseVisualStyleBackColor = false;
            this.btnPesquisarParceiro.Click += new System.EventHandler(this.btnPesquisarParceiro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 123;
            this.label3.Text = "Fornecedor";
            // 
            // tboxParceiro
            // 
            this.tboxParceiro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tboxParceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxParceiro.Location = new System.Drawing.Point(99, 24);
            this.tboxParceiro.MaxLength = 45;
            this.tboxParceiro.Name = "tboxParceiro";
            this.tboxParceiro.ReadOnly = true;
            this.tboxParceiro.Size = new System.Drawing.Size(455, 23);
            this.tboxParceiro.TabIndex = 122;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 121;
            this.label2.Text = "Nº Pedido";
            // 
            // SEQ
            // 
            this.SEQ.HeaderText = "SEQ.";
            this.SEQ.Name = "SEQ";
            this.SEQ.Width = 60;
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            // 
            // DTVENC
            // 
            this.DTVENC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DTVENC.HeaderText = "DT. VENC.";
            this.DTVENC.Name = "DTVENC";
            // 
            // VLREXTENSO
            // 
            this.VLREXTENSO.HeaderText = "VLREXTENSO";
            this.VLREXTENSO.Name = "VLREXTENSO";
            this.VLREXTENSO.Visible = false;
            // 
            // CODMOEDA
            // 
            this.CODMOEDA.HeaderText = "CÓDMOEDA";
            this.CODMOEDA.Name = "CODMOEDA";
            this.CODMOEDA.Visible = false;
            // 
            // IDBANCOCONTA
            // 
            this.IDBANCOCONTA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDBANCOCONTA.HeaderText = "CÓD. BANCO";
            this.IDBANCOCONTA.Name = "IDBANCOCONTA";
            this.IDBANCOCONTA.Visible = false;
            // 
            // frmDigitaPedidoCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Name = "frmDigitaPedidoCompras";
            this.Text = "Entrada de mercadoria";
            this.Load += new System.EventHandler(this.frmDigitaPedidoCompras_Load);
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado_pesquisa)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_formaPagto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox tboxDescontoTotal;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox tboxOutrosCustoTotal;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox tboxIPItotal;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.TextBox tboxTotalTotal;
        private System.Windows.Forms.Label label24;
        public System.Windows.Forms.TextBox tboxQtdeTotal;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox tboxUnd;
        private System.Windows.Forms.Button btn_Incluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox tboxItem;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox tboxTotalUnit;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox tboxDesconto;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox tboxOutrosCusto;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox tboxIPI;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox tboxTotal;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox tboxPCusto;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tboxQtde;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox tboxCodAuxiliar;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tboxDescricao;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dgv_resultado_pesquisa;
        public System.Windows.Forms.TextBox tboxCodigo;
        public System.Windows.Forms.TextBox tboxLocalizarProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox tbox_TotalParcelas;
        private System.Windows.Forms.Label label29;
        public System.Windows.Forms.TextBox tboxQtdeParcelas;
        private System.Windows.Forms.Button btnI_incluirContasPagar;
        private System.Windows.Forms.Label label26;
        public System.Windows.Forms.TextBox tbox_TotalFinal;
        public System.Windows.Forms.DataGridView dgv_formaPagto;
        public System.Windows.Forms.TextBox tboxNumPedido;
        private System.Windows.Forms.Button btnPesquisarParceiro;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tboxParceiro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImportarXML;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTVENC;
        private System.Windows.Forms.DataGridViewTextBoxColumn VLREXTENSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODMOEDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDBANCOCONTA;
    }
}