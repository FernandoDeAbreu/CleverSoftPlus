namespace CleverSoft
{
    partial class frm_PDVPagamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_FormaPagto = new System.Windows.Forms.DataGridView();
            this.TIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDFILIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPARCEIRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDMOEDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOEDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCONTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCONTAGERENCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMDOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTLANC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTVENC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTCOMPETENCIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTPGTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VLRDESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VLRJUROS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VLRTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VALORPAGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HISTORICO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VLREXTENSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCOBRANCA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbox_Comandos = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_troco = new System.Windows.Forms.Label();
            this.lbl_Falta = new System.Windows.Forms.Label();
            this.lblSomatotalPago = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.lbl_Desconto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_vlrOriginal = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FormaPagto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgv_FormaPagto);
            this.panel1.Controls.Add(this.tbox_Comandos);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_troco);
            this.panel1.Controls.Add(this.lbl_Falta);
            this.panel1.Controls.Add(this.lblSomatotalPago);
            this.panel1.Controls.Add(this.lbl_Total);
            this.panel1.Controls.Add(this.lbl_Desconto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_vlrOriginal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 554);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoEllipsis = true;
            this.label4.BackColor = System.Drawing.Color.Navy;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-5, 524);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(765, 46);
            this.label4.TabIndex = 59;
            this.label4.Text = "(Esc) - Sair  |  (F2) - Escolher forma Pgto  | (Enter) - Finalizar Venda";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgv_FormaPagto
            // 
            this.dgv_FormaPagto.AllowUserToAddRows = false;
            this.dgv_FormaPagto.AllowUserToDeleteRows = false;
            this.dgv_FormaPagto.AllowUserToResizeColumns = false;
            this.dgv_FormaPagto.AllowUserToResizeRows = false;
            this.dgv_FormaPagto.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_FormaPagto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_FormaPagto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_FormaPagto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_FormaPagto.ColumnHeadersHeight = 30;
            this.dgv_FormaPagto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_FormaPagto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TIPO,
            this.IDFILIAL,
            this.IDPARCEIRO,
            this.IDMOEDA,
            this.MOEDA,
            this.IDCONTA,
            this.IDCONTAGERENCIAL,
            this.NUMDOC,
            this.DTLANC,
            this.DTVENC,
            this.DTCOMPETENCIA,
            this.DTPGTO,
            this.VALOR,
            this.VLRDESC,
            this.VLRJUROS,
            this.VLRTOTAL,
            this.VALORPAGO,
            this.HISTORICO,
            this.VLREXTENSO,
            this.Column1,
            this.IDCOBRANCA});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_FormaPagto.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_FormaPagto.EnableHeadersVisualStyles = false;
            this.dgv_FormaPagto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_FormaPagto.Location = new System.Drawing.Point(3, 151);
            this.dgv_FormaPagto.MultiSelect = false;
            this.dgv_FormaPagto.Name = "dgv_FormaPagto";
            this.dgv_FormaPagto.ReadOnly = true;
            this.dgv_FormaPagto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_FormaPagto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_FormaPagto.Size = new System.Drawing.Size(740, 199);
            this.dgv_FormaPagto.TabIndex = 41;
            this.dgv_FormaPagto.TabStop = false;
            // 
            // TIPO
            // 
            this.TIPO.HeaderText = "TIPO";
            this.TIPO.Name = "TIPO";
            this.TIPO.ReadOnly = true;
            this.TIPO.Visible = false;
            // 
            // IDFILIAL
            // 
            this.IDFILIAL.HeaderText = "IDFILIAL";
            this.IDFILIAL.Name = "IDFILIAL";
            this.IDFILIAL.ReadOnly = true;
            this.IDFILIAL.Visible = false;
            // 
            // IDPARCEIRO
            // 
            this.IDPARCEIRO.HeaderText = "IDPARCEIRO";
            this.IDPARCEIRO.Name = "IDPARCEIRO";
            this.IDPARCEIRO.ReadOnly = true;
            this.IDPARCEIRO.Visible = false;
            // 
            // IDMOEDA
            // 
            this.IDMOEDA.HeaderText = "IDMOEDA";
            this.IDMOEDA.Name = "IDMOEDA";
            this.IDMOEDA.ReadOnly = true;
            this.IDMOEDA.Visible = false;
            this.IDMOEDA.Width = 50;
            // 
            // MOEDA
            // 
            this.MOEDA.HeaderText = "MOEDA";
            this.MOEDA.Name = "MOEDA";
            this.MOEDA.ReadOnly = true;
            this.MOEDA.Width = 350;
            // 
            // IDCONTA
            // 
            this.IDCONTA.HeaderText = "IDCONTA";
            this.IDCONTA.Name = "IDCONTA";
            this.IDCONTA.ReadOnly = true;
            this.IDCONTA.Visible = false;
            // 
            // IDCONTAGERENCIAL
            // 
            this.IDCONTAGERENCIAL.HeaderText = "IDCATEGORIA";
            this.IDCONTAGERENCIAL.Name = "IDCONTAGERENCIAL";
            this.IDCONTAGERENCIAL.ReadOnly = true;
            this.IDCONTAGERENCIAL.Visible = false;
            // 
            // NUMDOC
            // 
            this.NUMDOC.HeaderText = "NUMDOC";
            this.NUMDOC.Name = "NUMDOC";
            this.NUMDOC.ReadOnly = true;
            this.NUMDOC.Visible = false;
            // 
            // DTLANC
            // 
            this.DTLANC.HeaderText = "DTLANC";
            this.DTLANC.Name = "DTLANC";
            this.DTLANC.ReadOnly = true;
            this.DTLANC.Visible = false;
            // 
            // DTVENC
            // 
            this.DTVENC.HeaderText = "DTVENC";
            this.DTVENC.Name = "DTVENC";
            this.DTVENC.ReadOnly = true;
            this.DTVENC.Width = 150;
            // 
            // DTCOMPETENCIA
            // 
            this.DTCOMPETENCIA.HeaderText = "DTCOMPENTECIA";
            this.DTCOMPETENCIA.Name = "DTCOMPETENCIA";
            this.DTCOMPETENCIA.ReadOnly = true;
            this.DTCOMPETENCIA.Visible = false;
            // 
            // DTPGTO
            // 
            this.DTPGTO.HeaderText = "DTPGTO";
            this.DTPGTO.Name = "DTPGTO";
            this.DTPGTO.ReadOnly = true;
            this.DTPGTO.Visible = false;
            // 
            // VALOR
            // 
            this.VALOR.HeaderText = "VALOR";
            this.VALOR.Name = "VALOR";
            this.VALOR.ReadOnly = true;
            this.VALOR.Width = 150;
            // 
            // VLRDESC
            // 
            this.VLRDESC.HeaderText = "VLDDESC";
            this.VLRDESC.Name = "VLRDESC";
            this.VLRDESC.ReadOnly = true;
            this.VLRDESC.Visible = false;
            // 
            // VLRJUROS
            // 
            this.VLRJUROS.HeaderText = "VLRJUROS";
            this.VLRJUROS.Name = "VLRJUROS";
            this.VLRJUROS.ReadOnly = true;
            this.VLRJUROS.Visible = false;
            // 
            // VLRTOTAL
            // 
            this.VLRTOTAL.HeaderText = "VLRTOTAL";
            this.VLRTOTAL.Name = "VLRTOTAL";
            this.VLRTOTAL.ReadOnly = true;
            this.VLRTOTAL.Visible = false;
            // 
            // VALORPAGO
            // 
            this.VALORPAGO.HeaderText = "VALORPAGO";
            this.VALORPAGO.Name = "VALORPAGO";
            this.VALORPAGO.ReadOnly = true;
            // 
            // HISTORICO
            // 
            this.HISTORICO.HeaderText = "HISTORICO";
            this.HISTORICO.Name = "HISTORICO";
            this.HISTORICO.ReadOnly = true;
            this.HISTORICO.Width = 300;
            // 
            // VLREXTENSO
            // 
            this.VLREXTENSO.HeaderText = "VLREXTENSO";
            this.VLREXTENSO.Name = "VLREXTENSO";
            this.VLREXTENSO.ReadOnly = true;
            this.VLREXTENSO.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // IDCOBRANCA
            // 
            this.IDCOBRANCA.HeaderText = "IDCOBRANCA";
            this.IDCOBRANCA.Name = "IDCOBRANCA";
            this.IDCOBRANCA.ReadOnly = true;
            this.IDCOBRANCA.Visible = false;
            // 
            // tbox_Comandos
            // 
            this.tbox_Comandos.Location = new System.Drawing.Point(7, 156);
            this.tbox_Comandos.Name = "tbox_Comandos";
            this.tbox_Comandos.Size = new System.Drawing.Size(129, 27);
            this.tbox_Comandos.TabIndex = 0;
            this.tbox_Comandos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_Comandos_KeyDown);
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoEllipsis = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(11, 451);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(5);
            this.label11.Size = new System.Drawing.Size(252, 44);
            this.label11.TabIndex = 56;
            this.label11.Text = "Valor Troco";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoEllipsis = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(10, 407);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(5);
            this.label10.Size = new System.Drawing.Size(252, 44);
            this.label10.TabIndex = 55;
            this.label10.Text = "Valor Falta";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoEllipsis = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 359);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5);
            this.label9.Size = new System.Drawing.Size(252, 55);
            this.label9.TabIndex = 54;
            this.label9.Text = "Valor pago";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoEllipsis = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(11, 106);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(299, 46);
            this.label5.TabIndex = 53;
            this.label5.Text = "Valor Total";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 59);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(299, 46);
            this.label3.TabIndex = 52;
            this.label3.Text = "Valor do Desconto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_troco
            // 
            this.lbl_troco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_troco.AutoEllipsis = true;
            this.lbl_troco.BackColor = System.Drawing.Color.Navy;
            this.lbl_troco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_troco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_troco.Font = new System.Drawing.Font("Times New Roman", 32F, System.Drawing.FontStyle.Bold);
            this.lbl_troco.ForeColor = System.Drawing.Color.White;
            this.lbl_troco.Location = new System.Drawing.Point(485, 461);
            this.lbl_troco.Name = "lbl_troco";
            this.lbl_troco.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_troco.Size = new System.Drawing.Size(252, 56);
            this.lbl_troco.TabIndex = 51;
            this.lbl_troco.Text = "0,00";
            this.lbl_troco.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Falta
            // 
            this.lbl_Falta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Falta.AutoEllipsis = true;
            this.lbl_Falta.BackColor = System.Drawing.Color.Navy;
            this.lbl_Falta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Falta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Falta.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Falta.ForeColor = System.Drawing.Color.White;
            this.lbl_Falta.Location = new System.Drawing.Point(485, 414);
            this.lbl_Falta.Name = "lbl_Falta";
            this.lbl_Falta.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_Falta.Size = new System.Drawing.Size(252, 46);
            this.lbl_Falta.TabIndex = 50;
            this.lbl_Falta.Text = "0,00";
            this.lbl_Falta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSomatotalPago
            // 
            this.lblSomatotalPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSomatotalPago.AutoEllipsis = true;
            this.lblSomatotalPago.BackColor = System.Drawing.Color.Navy;
            this.lblSomatotalPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSomatotalPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSomatotalPago.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSomatotalPago.ForeColor = System.Drawing.Color.White;
            this.lblSomatotalPago.Location = new System.Drawing.Point(485, 367);
            this.lblSomatotalPago.Name = "lblSomatotalPago";
            this.lblSomatotalPago.Padding = new System.Windows.Forms.Padding(5);
            this.lblSomatotalPago.Size = new System.Drawing.Size(252, 46);
            this.lblSomatotalPago.TabIndex = 49;
            this.lblSomatotalPago.Text = "0,00";
            this.lblSomatotalPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Total
            // 
            this.lbl_Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Total.AutoEllipsis = true;
            this.lbl_Total.BackColor = System.Drawing.Color.Navy;
            this.lbl_Total.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Total.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Total.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.ForeColor = System.Drawing.Color.White;
            this.lbl_Total.Location = new System.Drawing.Point(484, 106);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_Total.Size = new System.Drawing.Size(252, 46);
            this.lbl_Total.TabIndex = 48;
            this.lbl_Total.Text = "0,00";
            this.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Desconto
            // 
            this.lbl_Desconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Desconto.AutoEllipsis = true;
            this.lbl_Desconto.BackColor = System.Drawing.Color.Navy;
            this.lbl_Desconto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Desconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Desconto.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Desconto.ForeColor = System.Drawing.Color.White;
            this.lbl_Desconto.Location = new System.Drawing.Point(484, 59);
            this.lbl_Desconto.Name = "lbl_Desconto";
            this.lbl_Desconto.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_Desconto.Size = new System.Drawing.Size(252, 46);
            this.lbl_Desconto.TabIndex = 44;
            this.lbl_Desconto.Text = "0,00";
            this.lbl_Desconto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(252, 46);
            this.label1.TabIndex = 43;
            this.label1.Text = "Valor dos Itens";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_vlrOriginal
            // 
            this.lbl_vlrOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_vlrOriginal.AutoEllipsis = true;
            this.lbl_vlrOriginal.BackColor = System.Drawing.Color.Navy;
            this.lbl_vlrOriginal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_vlrOriginal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_vlrOriginal.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vlrOriginal.ForeColor = System.Drawing.Color.White;
            this.lbl_vlrOriginal.Location = new System.Drawing.Point(484, 12);
            this.lbl_vlrOriginal.Name = "lbl_vlrOriginal";
            this.lbl_vlrOriginal.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_vlrOriginal.Size = new System.Drawing.Size(252, 46);
            this.lbl_vlrOriginal.TabIndex = 42;
            this.lbl_vlrOriginal.Text = "0,00";
            this.lbl_vlrOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_PDVPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(115)))), ((int)(((byte)(169)))));
            this.ClientSize = new System.Drawing.Size(748, 554);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_PDVPagamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PDVPagamento";
            this.Load += new System.EventHandler(this.frm_PDVPagamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FormaPagto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dgv_FormaPagto;
        public System.Windows.Forms.Label lbl_Desconto;
        public System.Windows.Forms.Label lbl_vlrOriginal;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbl_troco;
        public System.Windows.Forms.Label lbl_Falta;
        public System.Windows.Forms.Label lblSomatotalPago;
        public System.Windows.Forms.Label lbl_Total;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbox_Comandos;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDFILIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPARCEIRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMOEDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOEDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCONTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCONTAGERENCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMDOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTLANC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTVENC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTCOMPETENCIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTPGTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn VLRDESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn VLRJUROS;
        private System.Windows.Forms.DataGridViewTextBoxColumn VLRTOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn VALORPAGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn HISTORICO;
        private System.Windows.Forms.DataGridViewTextBoxColumn VLREXTENSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCOBRANCA;
    }
}