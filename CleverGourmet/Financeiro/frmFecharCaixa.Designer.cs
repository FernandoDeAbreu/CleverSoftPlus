namespace CleverSoft
{
    partial class frmFecharCaixa
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
            this.btnPesquisarParceiro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxParceiro = new System.Windows.Forms.TextBox();
            this.tboxDtini = new System.Windows.Forms.DateTimePicker();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.dgv_Resultado_vendas = new System.Windows.Forms.DataGridView();
            this.NUMVENDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMPREST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMDOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PREST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZAOSOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VLRTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTLANC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTVENC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCOBRANCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COBRANCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tboxValorTotal = new System.Windows.Forms.TextBox();
            this.tboxQtdeVendas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelCampos.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Resultado_vendas)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.label4);
            this.panelCampos.Controls.Add(this.label2);
            this.panelCampos.Controls.Add(this.tboxQtdeVendas);
            this.panelCampos.Controls.Add(this.tboxValorTotal);
            this.panelCampos.Controls.Add(this.dgv_Resultado_vendas);
            this.panelCampos.Controls.Add(this.flowLayoutPanel2);
            this.panelCampos.Controls.Add(this.btn_Pesquisar);
            this.panelCampos.Controls.Add(this.tboxDtini);
            this.panelCampos.Controls.Add(this.btnPesquisarParceiro);
            this.panelCampos.Controls.Add(this.label3);
            this.panelCampos.Controls.Add(this.tboxParceiro);
            // 
            // btnPesquisarParceiro
            // 
            this.btnPesquisarParceiro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPesquisarParceiro.FlatAppearance.BorderSize = 0;
            this.btnPesquisarParceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarParceiro.Image = global::CleverSoft.Properties.Resources.magnifier1;
            this.btnPesquisarParceiro.Location = new System.Drawing.Point(431, 28);
            this.btnPesquisarParceiro.Name = "btnPesquisarParceiro";
            this.btnPesquisarParceiro.Size = new System.Drawing.Size(30, 18);
            this.btnPesquisarParceiro.TabIndex = 127;
            this.btnPesquisarParceiro.TabStop = false;
            this.btnPesquisarParceiro.UseVisualStyleBackColor = false;
            this.btnPesquisarParceiro.Click += new System.EventHandler(this.btnPesquisarParceiro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 126;
            this.label3.Text = "Operador";
            // 
            // tboxParceiro
            // 
            this.tboxParceiro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tboxParceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxParceiro.Location = new System.Drawing.Point(9, 26);
            this.tboxParceiro.MaxLength = 45;
            this.tboxParceiro.Name = "tboxParceiro";
            this.tboxParceiro.ReadOnly = true;
            this.tboxParceiro.Size = new System.Drawing.Size(455, 23);
            this.tboxParceiro.TabIndex = 125;
            // 
            // tboxDtini
            // 
            this.tboxDtini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tboxDtini.Location = new System.Drawing.Point(470, 26);
            this.tboxDtini.Name = "tboxDtini";
            this.tboxDtini.Size = new System.Drawing.Size(108, 23);
            this.tboxDtini.TabIndex = 128;
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pesquisar.Image = global::CleverSoft.Properties.Resources.find1;
            this.btn_Pesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Pesquisar.Location = new System.Drawing.Point(785, 21);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(100, 30);
            this.btn_Pesquisar.TabIndex = 129;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnFechar);
            this.flowLayoutPanel2.Controls.Add(this.btn_Imprimir);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 512);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(894, 39);
            this.flowLayoutPanel2.TabIndex = 130;
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Image = global::CleverSoft.Properties.Resources.accept_button1;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(785, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(106, 30);
            this.btnFechar.TabIndex = 136;
            this.btnFechar.Text = "Fechar Caixa";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Imprimir.Image = global::CleverSoft.Properties.Resources.printer1;
            this.btn_Imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Imprimir.Location = new System.Drawing.Point(673, 3);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(106, 30);
            this.btn_Imprimir.TabIndex = 137;
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // dgv_Resultado_vendas
            // 
            this.dgv_Resultado_vendas.AllowUserToAddRows = false;
            this.dgv_Resultado_vendas.AllowUserToDeleteRows = false;
            this.dgv_Resultado_vendas.AllowUserToResizeColumns = false;
            this.dgv_Resultado_vendas.AllowUserToResizeRows = false;
            this.dgv_Resultado_vendas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Resultado_vendas.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Resultado_vendas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Resultado_vendas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Resultado_vendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Resultado_vendas.ColumnHeadersHeight = 30;
            this.dgv_Resultado_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Resultado_vendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUMVENDA,
            this.NUMPREST,
            this.NUMDOC,
            this.PREST,
            this.IDCLIENTE,
            this.RAZAOSOCIAL,
            this.VLRTOTAL,
            this.DTLANC,
            this.DTVENC,
            this.IDCOBRANCA,
            this.COBRANCA,
            this.STATUS});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Resultado_vendas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Resultado_vendas.EnableHeadersVisualStyles = false;
            this.dgv_Resultado_vendas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_Resultado_vendas.Location = new System.Drawing.Point(4, 80);
            this.dgv_Resultado_vendas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_Resultado_vendas.MultiSelect = false;
            this.dgv_Resultado_vendas.Name = "dgv_Resultado_vendas";
            this.dgv_Resultado_vendas.ReadOnly = true;
            this.dgv_Resultado_vendas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Resultado_vendas.RowHeadersVisible = false;
            this.dgv_Resultado_vendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Resultado_vendas.Size = new System.Drawing.Size(885, 376);
            this.dgv_Resultado_vendas.TabIndex = 131;
            // 
            // NUMVENDA
            // 
            this.NUMVENDA.HeaderText = "Venda";
            this.NUMVENDA.Name = "NUMVENDA";
            this.NUMVENDA.ReadOnly = true;
            // 
            // NUMPREST
            // 
            this.NUMPREST.HeaderText = "Nº Lanc.";
            this.NUMPREST.Name = "NUMPREST";
            this.NUMPREST.ReadOnly = true;
            // 
            // NUMDOC
            // 
            this.NUMDOC.HeaderText = "Nº doc.";
            this.NUMDOC.Name = "NUMDOC";
            this.NUMDOC.ReadOnly = true;
            this.NUMDOC.Visible = false;
            // 
            // PREST
            // 
            this.PREST.HeaderText = "Prest.";
            this.PREST.Name = "PREST";
            this.PREST.ReadOnly = true;
            this.PREST.Width = 60;
            // 
            // IDCLIENTE
            // 
            this.IDCLIENTE.HeaderText = "IDCLIENTE";
            this.IDCLIENTE.Name = "IDCLIENTE";
            this.IDCLIENTE.ReadOnly = true;
            this.IDCLIENTE.Visible = false;
            // 
            // RAZAOSOCIAL
            // 
            this.RAZAOSOCIAL.HeaderText = "Cliente";
            this.RAZAOSOCIAL.Name = "RAZAOSOCIAL";
            this.RAZAOSOCIAL.ReadOnly = true;
            this.RAZAOSOCIAL.Width = 250;
            // 
            // VLRTOTAL
            // 
            this.VLRTOTAL.HeaderText = "Valor";
            this.VLRTOTAL.Name = "VLRTOTAL";
            this.VLRTOTAL.ReadOnly = true;
            // 
            // DTLANC
            // 
            this.DTLANC.HeaderText = "Dt. Lanc.";
            this.DTLANC.Name = "DTLANC";
            this.DTLANC.ReadOnly = true;
            // 
            // DTVENC
            // 
            this.DTVENC.HeaderText = "Dt. Venc.";
            this.DTVENC.Name = "DTVENC";
            this.DTVENC.ReadOnly = true;
            // 
            // IDCOBRANCA
            // 
            this.IDCOBRANCA.HeaderText = "IDCOBRANCA";
            this.IDCOBRANCA.Name = "IDCOBRANCA";
            this.IDCOBRANCA.ReadOnly = true;
            this.IDCOBRANCA.Visible = false;
            // 
            // COBRANCA
            // 
            this.COBRANCA.HeaderText = "Cobrança";
            this.COBRANCA.Name = "COBRANCA";
            this.COBRANCA.ReadOnly = true;
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "Status";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            // 
            // tboxValorTotal
            // 
            this.tboxValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxValorTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tboxValorTotal.Location = new System.Drawing.Point(785, 478);
            this.tboxValorTotal.Name = "tboxValorTotal";
            this.tboxValorTotal.ReadOnly = true;
            this.tboxValorTotal.Size = new System.Drawing.Size(100, 23);
            this.tboxValorTotal.TabIndex = 132;
            this.tboxValorTotal.Text = "0,00";
            this.tboxValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tboxQtdeVendas
            // 
            this.tboxQtdeVendas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxQtdeVendas.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tboxQtdeVendas.Location = new System.Drawing.Point(699, 478);
            this.tboxQtdeVendas.Name = "tboxQtdeVendas";
            this.tboxQtdeVendas.ReadOnly = true;
            this.tboxQtdeVendas.Size = new System.Drawing.Size(80, 23);
            this.tboxQtdeVendas.TabIndex = 133;
            this.tboxQtdeVendas.Text = "0,00";
            this.tboxQtdeVendas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(782, 460);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 134;
            this.label2.Text = "Valor Total";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(696, 460);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 135;
            this.label4.Text = "Qtde.";
            // 
            // frmFecharCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Name = "frmFecharCaixa";
            this.Text = "FECHAR CAIXA";
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Resultado_vendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisarParceiro;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tboxParceiro;
        private System.Windows.Forms.DateTimePicker tboxDtini;
        private System.Windows.Forms.Button btn_Pesquisar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.DataGridView dgv_Resultado_vendas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxQtdeVendas;
        private System.Windows.Forms.TextBox tboxValorTotal;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMVENDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMPREST;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMDOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn PREST;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZAOSOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn VLRTOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTLANC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTVENC;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCOBRANCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn COBRANCA;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
    }
}