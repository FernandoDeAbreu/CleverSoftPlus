namespace CleverSoft
{
    partial class frm_PDV
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PDV));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbox_Cliente = new System.Windows.Forms.TextBox();
            this.tbox_Qtde = new System.Windows.Forms.TextBox();
            this.tboxLocalizarProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_vlrOriginal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_vrlDesconto = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.lbl_Funcionario = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.lblData = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblNnumVenda = new System.Windows.Forms.ToolStripLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_QtdeItens = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_NomeRotina = new System.Windows.Forms.Label();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.dgv_Itens_Venda = new System.Windows.Forms.DataGridView();
            this.SEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODPROD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODAUXILIAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRICAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCUSTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PDESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PVENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXIBIRTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALDESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pboxImagemSistema = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Itens_Venda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagemSistema)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(115)))), ((int)(((byte)(169)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lbl_vlrOriginal);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.lbl_vrlDesconto);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbl_QtdeItens);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblDescricao);
            this.panel1.Controls.Add(this.dgv_Itens_Venda);
            this.panel1.Controls.Add(this.pboxImagemSistema);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 700);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.tbox_Cliente);
            this.panel3.Controls.Add(this.tbox_Qtde);
            this.panel3.Controls.Add(this.tboxLocalizarProduto);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(7, 539);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(401, 124);
            this.panel3.TabIndex = 57;
            // 
            // tbox_Cliente
            // 
            this.tbox_Cliente.BackColor = System.Drawing.Color.White;
            this.tbox_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_Cliente.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.tbox_Cliente.Location = new System.Drawing.Point(8, 87);
            this.tbox_Cliente.Name = "tbox_Cliente";
            this.tbox_Cliente.ReadOnly = true;
            this.tbox_Cliente.Size = new System.Drawing.Size(387, 32);
            this.tbox_Cliente.TabIndex = 53;
            this.tbox_Cliente.TabStop = false;
            this.tbox_Cliente.Text = "1 - Consumidor Final";
            // 
            // tbox_Qtde
            // 
            this.tbox_Qtde.BackColor = System.Drawing.Color.White;
            this.tbox_Qtde.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_Qtde.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.tbox_Qtde.Location = new System.Drawing.Point(308, 34);
            this.tbox_Qtde.Name = "tbox_Qtde";
            this.tbox_Qtde.ReadOnly = true;
            this.tbox_Qtde.Size = new System.Drawing.Size(87, 32);
            this.tbox_Qtde.TabIndex = 44;
            this.tbox_Qtde.TabStop = false;
            this.tbox_Qtde.Text = "1,00";
            this.tbox_Qtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_Qtde.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tboxLocalizarProduto
            // 
            this.tboxLocalizarProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxLocalizarProduto.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.tboxLocalizarProduto.Location = new System.Drawing.Point(8, 34);
            this.tboxLocalizarProduto.Name = "tboxLocalizarProduto";
            this.tboxLocalizarProduto.Size = new System.Drawing.Size(294, 32);
            this.tboxLocalizarProduto.TabIndex = 43;
            this.tboxLocalizarProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxLocalizarProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxLocalizarProduto_KeyDown);
            this.tboxLocalizarProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxLocalizarProduto_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-1, 8);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(139, 30);
            this.label4.TabIndex = 49;
            this.label4.Text = "Localizar Produto";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(298, 8);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(90, 30);
            this.label5.TabIndex = 50;
            this.label5.Text = "Quatidade";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(-61, 61);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.Size = new System.Drawing.Size(66, 30);
            this.label7.TabIndex = 52;
            this.label7.Text = "Cliente";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_vlrOriginal
            // 
            this.lbl_vlrOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_vlrOriginal.AutoEllipsis = true;
            this.lbl_vlrOriginal.BackColor = System.Drawing.Color.Navy;
            this.lbl_vlrOriginal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_vlrOriginal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_vlrOriginal.Font = new System.Drawing.Font("Times New Roman", 40F, System.Drawing.FontStyle.Bold);
            this.lbl_vlrOriginal.ForeColor = System.Drawing.Color.White;
            this.lbl_vlrOriginal.Location = new System.Drawing.Point(643, 582);
            this.lbl_vlrOriginal.Name = "lbl_vlrOriginal";
            this.lbl_vlrOriginal.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_vlrOriginal.Size = new System.Drawing.Size(352, 84);
            this.lbl_vlrOriginal.TabIndex = 38;
            this.lbl_vlrOriginal.Text = "0,00";
            this.lbl_vlrOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoEllipsis = true;
            this.label11.BackColor = System.Drawing.Color.Navy;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(418, 582);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(5);
            this.label11.Size = new System.Drawing.Size(228, 84);
            this.label11.TabIndex = 37;
            this.label11.Text = "Valor do Total";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_vrlDesconto
            // 
            this.lbl_vrlDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_vrlDesconto.AutoEllipsis = true;
            this.lbl_vrlDesconto.BackColor = System.Drawing.Color.Navy;
            this.lbl_vrlDesconto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_vrlDesconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_vrlDesconto.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vrlDesconto.ForeColor = System.Drawing.Color.White;
            this.lbl_vrlDesconto.Location = new System.Drawing.Point(678, 539);
            this.lbl_vrlDesconto.Name = "lbl_vrlDesconto";
            this.lbl_vrlDesconto.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_vrlDesconto.Size = new System.Drawing.Size(317, 42);
            this.lbl_vrlDesconto.TabIndex = 36;
            this.lbl_vrlDesconto.Text = "0,00";
            this.lbl_vrlDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowItemReorder = true;
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(115)))), ((int)(((byte)(169)))));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2,
            this.lbl_Funcionario,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.lblData,
            this.toolStripSeparator2,
            this.lblNnumVenda});
            this.toolStrip1.Location = new System.Drawing.Point(0, 673);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(998, 25);
            this.toolStrip1.TabIndex = 56;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(102, 22);
            this.toolStripLabel1.Text = "FUNÇÕES ( T )";
            this.toolStripLabel1.Click += new System.EventHandler(this.lbl_TelaFuncoes_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(82, 22);
            this.toolStripLabel2.Text = "                         ";
            // 
            // lbl_Funcionario
            // 
            this.lbl_Funcionario.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_Funcionario.ForeColor = System.Drawing.Color.White;
            this.lbl_Funcionario.Name = "lbl_Funcionario";
            this.lbl_Funcionario.Size = new System.Drawing.Size(165, 22);
            this.lbl_Funcionario.Text = "Operador: Administrador";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripLabel3.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(61, 22);
            this.toolStripLabel3.Text = "Caixa 01";
            // 
            // lblData
            // 
            this.lblData.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblData.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblData.ForeColor = System.Drawing.Color.White;
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(63, 22);
            this.lblData.Text = "00:00:00";
            this.lblData.Click += new System.EventHandler(this.lbl_TelaFuncoes_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lblNnumVenda
            // 
            this.lblNnumVenda.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNnumVenda.ForeColor = System.Drawing.Color.White;
            this.lblNnumVenda.Name = "lblNnumVenda";
            this.lblNnumVenda.Size = new System.Drawing.Size(77, 22);
            this.lblNnumVenda.Text = "Caixa Livre";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoEllipsis = true;
            this.label9.BackColor = System.Drawing.Color.Navy;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(418, 539);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5);
            this.label9.Size = new System.Drawing.Size(277, 42);
            this.label9.TabIndex = 35;
            this.label9.Text = "Valor do Desconto";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_QtdeItens
            // 
            this.lbl_QtdeItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_QtdeItens.AutoEllipsis = true;
            this.lbl_QtdeItens.BackColor = System.Drawing.Color.Navy;
            this.lbl_QtdeItens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_QtdeItens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_QtdeItens.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QtdeItens.ForeColor = System.Drawing.Color.White;
            this.lbl_QtdeItens.Location = new System.Drawing.Point(678, 489);
            this.lbl_QtdeItens.Name = "lbl_QtdeItens";
            this.lbl_QtdeItens.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_QtdeItens.Size = new System.Drawing.Size(317, 49);
            this.lbl_QtdeItens.TabIndex = 34;
            this.lbl_QtdeItens.Text = "0,00";
            this.lbl_QtdeItens.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(418, 489);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(277, 49);
            this.label2.TabIndex = 33;
            this.label2.Text = "Quantidade de itens";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(115)))), ((int)(((byte)(169)))));
            this.panel2.Controls.Add(this.lbl_NomeRotina);
            this.panel2.Controls.Add(this.iconcerrar);
            this.panel2.Location = new System.Drawing.Point(0, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(999, 31);
            this.panel2.TabIndex = 11;
            // 
            // lbl_NomeRotina
            // 
            this.lbl_NomeRotina.AutoEllipsis = true;
            this.lbl_NomeRotina.AutoSize = true;
            this.lbl_NomeRotina.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NomeRotina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_NomeRotina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_NomeRotina.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_NomeRotina.ForeColor = System.Drawing.Color.White;
            this.lbl_NomeRotina.Location = new System.Drawing.Point(3, 1);
            this.lbl_NomeRotina.Name = "lbl_NomeRotina";
            this.lbl_NomeRotina.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_NomeRotina.Size = new System.Drawing.Size(183, 30);
            this.lbl_NomeRotina.TabIndex = 32;
            this.lbl_NomeRotina.Text = "CLEVER SISTEMA - PDV";
            this.lbl_NomeRotina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.BackColor = System.Drawing.Color.Transparent;
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(968, 4);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(25, 20);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 31;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // lblDescricao
            // 
            this.lblDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescricao.AutoEllipsis = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Navy;
            this.lblDescricao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDescricao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Bold);
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(3, 25);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Padding = new System.Windows.Forms.Padding(5);
            this.lblDescricao.Size = new System.Drawing.Size(992, 68);
            this.lblDescricao.TabIndex = 45;
            this.lblDescricao.Text = "CAIXA LIVRE";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_Itens_Venda
            // 
            this.dgv_Itens_Venda.AllowUserToAddRows = false;
            this.dgv_Itens_Venda.AllowUserToDeleteRows = false;
            this.dgv_Itens_Venda.AllowUserToResizeColumns = false;
            this.dgv_Itens_Venda.AllowUserToResizeRows = false;
            this.dgv_Itens_Venda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Itens_Venda.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Itens_Venda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Itens_Venda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Itens_Venda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Itens_Venda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Itens_Venda.ColumnHeadersHeight = 30;
            this.dgv_Itens_Venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Itens_Venda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SEQ,
            this.CODPROD,
            this.CODAUXILIAR,
            this.DESCRICAO,
            this.QTDE,
            this.Column1,
            this.PCUSTO,
            this.PUNIT,
            this.PDESC,
            this.PVENDA,
            this.PTOTAL,
            this.EXIBIRTOTAL,
            this.TOTALDESC});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Itens_Venda.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Itens_Venda.EnableHeadersVisualStyles = false;
            this.dgv_Itens_Venda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_Itens_Venda.Location = new System.Drawing.Point(418, 96);
            this.dgv_Itens_Venda.MultiSelect = false;
            this.dgv_Itens_Venda.Name = "dgv_Itens_Venda";
            this.dgv_Itens_Venda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Itens_Venda.RowHeadersVisible = false;
            this.dgv_Itens_Venda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_Itens_Venda.Size = new System.Drawing.Size(577, 391);
            this.dgv_Itens_Venda.TabIndex = 41;
            // 
            // SEQ
            // 
            this.SEQ.HeaderText = "Item";
            this.SEQ.Name = "SEQ";
            this.SEQ.ToolTipText = "Item";
            this.SEQ.Width = 35;
            // 
            // CODPROD
            // 
            this.CODPROD.HeaderText = "CODPROD";
            this.CODPROD.Name = "CODPROD";
            this.CODPROD.Visible = false;
            // 
            // CODAUXILIAR
            // 
            this.CODAUXILIAR.HeaderText = "Código";
            this.CODAUXILIAR.Name = "CODAUXILIAR";
            this.CODAUXILIAR.Width = 130;
            // 
            // DESCRICAO
            // 
            this.DESCRICAO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DESCRICAO.DefaultCellStyle = dataGridViewCellStyle2;
            this.DESCRICAO.HeaderText = "Descrição";
            this.DESCRICAO.Name = "DESCRICAO";
            // 
            // QTDE
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.QTDE.DefaultCellStyle = dataGridViewCellStyle3;
            this.QTDE.HeaderText = "Qtde.";
            this.QTDE.Name = "QTDE";
            this.QTDE.Width = 40;
            // 
            // Column1
            // 
            dataGridViewCellStyle4.NullValue = "x";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.HeaderText = "x";
            this.Column1.Name = "Column1";
            this.Column1.Width = 15;
            // 
            // PCUSTO
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.PCUSTO.DefaultCellStyle = dataGridViewCellStyle5;
            this.PCUSTO.HeaderText = "VLRCUSTO";
            this.PCUSTO.Name = "PCUSTO";
            this.PCUSTO.Visible = false;
            // 
            // PUNIT
            // 
            this.PUNIT.HeaderText = "Vlr. Unt.";
            this.PUNIT.Name = "PUNIT";
            this.PUNIT.Width = 70;
            // 
            // PDESC
            // 
            this.PDESC.HeaderText = "VLRDESC";
            this.PDESC.Name = "PDESC";
            this.PDESC.Visible = false;
            // 
            // PVENDA
            // 
            this.PVENDA.HeaderText = "VLRVEND";
            this.PVENDA.Name = "PVENDA";
            this.PVENDA.Visible = false;
            // 
            // PTOTAL
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.NullValue = null;
            this.PTOTAL.DefaultCellStyle = dataGridViewCellStyle6;
            this.PTOTAL.HeaderText = "Total";
            this.PTOTAL.Name = "PTOTAL";
            this.PTOTAL.Visible = false;
            this.PTOTAL.Width = 70;
            // 
            // EXIBIRTOTAL
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N2";
            this.EXIBIRTOTAL.DefaultCellStyle = dataGridViewCellStyle7;
            this.EXIBIRTOTAL.HeaderText = "Total";
            this.EXIBIRTOTAL.Name = "EXIBIRTOTAL";
            this.EXIBIRTOTAL.Width = 70;
            // 
            // TOTALDESC
            // 
            dataGridViewCellStyle8.NullValue = "0";
            this.TOTALDESC.DefaultCellStyle = dataGridViewCellStyle8;
            this.TOTALDESC.HeaderText = "TOTALDESC";
            this.TOTALDESC.Name = "TOTALDESC";
            this.TOTALDESC.Visible = false;
            // 
            // pboxImagemSistema
            // 
            this.pboxImagemSistema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxImagemSistema.BackColor = System.Drawing.Color.White;
            this.pboxImagemSistema.Location = new System.Drawing.Point(3, 96);
            this.pboxImagemSistema.Name = "pboxImagemSistema";
            this.pboxImagemSistema.Size = new System.Drawing.Size(409, 570);
            this.pboxImagemSistema.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxImagemSistema.TabIndex = 42;
            this.pboxImagemSistema.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_PDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_PDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Vendas  - PDV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_PDV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Itens_Venda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxImagemSistema)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lbl_NomeRotina;
        public System.Windows.Forms.PictureBox iconcerrar;
        public System.Windows.Forms.DataGridView dgv_Itens_Venda;
        private System.Windows.Forms.TextBox tbox_Qtde;
        private System.Windows.Forms.PictureBox pboxImagemSistema;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblDescricao;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel lblData;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lbl_vlrOriginal;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lbl_QtdeItens;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label lbl_vrlDesconto;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox tbox_Cliente;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lblNnumVenda;
        public System.Windows.Forms.ToolStripLabel lbl_Funcionario;
        public System.Windows.Forms.TextBox tboxLocalizarProduto;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODPROD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODAUXILIAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRICAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PCUSTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUNIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PDESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PVENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PTOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXIBIRTOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALDESC;
    }
}