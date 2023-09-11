namespace CleverSoft
{
    partial class frm_Orcamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tboxLocalizarProduto = new System.Windows.Forms.TextBox();
            this.tbox_Qtde = new System.Windows.Forms.TextBox();
            this.lbl_vlrOriginal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_vrlDesconto = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_QtdeItens = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_Cliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Itens_Venda)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.label5);
            this.panelCampos.Controls.Add(this.label4);
            this.panelCampos.Controls.Add(this.label3);
            this.panelCampos.Controls.Add(this.tbox_Cliente);
            this.panelCampos.Controls.Add(this.lbl_vlrOriginal);
            this.panelCampos.Controls.Add(this.label11);
            this.panelCampos.Controls.Add(this.lbl_vrlDesconto);
            this.panelCampos.Controls.Add(this.label9);
            this.panelCampos.Controls.Add(this.lbl_QtdeItens);
            this.panelCampos.Controls.Add(this.label2);
            this.panelCampos.Controls.Add(this.tbox_Qtde);
            this.panelCampos.Controls.Add(this.tboxLocalizarProduto);
            this.panelCampos.Controls.Add(this.dgv_Itens_Venda);
            // 
            // dgv_Itens_Venda
            // 
            this.dgv_Itens_Venda.AllowUserToAddRows = false;
            this.dgv_Itens_Venda.AllowUserToDeleteRows = false;
            this.dgv_Itens_Venda.AllowUserToResizeColumns = false;
            this.dgv_Itens_Venda.AllowUserToResizeRows = false;
            this.dgv_Itens_Venda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Itens_Venda.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Itens_Venda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Itens_Venda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_Itens_Venda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Itens_Venda.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_Itens_Venda.EnableHeadersVisualStyles = false;
            this.dgv_Itens_Venda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_Itens_Venda.Location = new System.Drawing.Point(4, 95);
            this.dgv_Itens_Venda.MultiSelect = false;
            this.dgv_Itens_Venda.Name = "dgv_Itens_Venda";
            this.dgv_Itens_Venda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_Itens_Venda.RowHeadersVisible = false;
            this.dgv_Itens_Venda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_Itens_Venda.Size = new System.Drawing.Size(887, 255);
            this.dgv_Itens_Venda.TabIndex = 42;
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
            // tboxLocalizarProduto
            // 
            this.tboxLocalizarProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxLocalizarProduto.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.tboxLocalizarProduto.Location = new System.Drawing.Point(9, 63);
            this.tboxLocalizarProduto.Name = "tboxLocalizarProduto";
            this.tboxLocalizarProduto.Size = new System.Drawing.Size(294, 23);
            this.tboxLocalizarProduto.TabIndex = 44;
            this.tboxLocalizarProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbox_Qtde
            // 
            this.tbox_Qtde.BackColor = System.Drawing.Color.White;
            this.tbox_Qtde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_Qtde.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.tbox_Qtde.Location = new System.Drawing.Point(309, 63);
            this.tbox_Qtde.Name = "tbox_Qtde";
            this.tbox_Qtde.ReadOnly = true;
            this.tbox_Qtde.Size = new System.Drawing.Size(56, 23);
            this.tbox_Qtde.TabIndex = 45;
            this.tbox_Qtde.TabStop = false;
            this.tbox_Qtde.Text = "1,00";
            this.tbox_Qtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_vlrOriginal
            // 
            this.lbl_vlrOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_vlrOriginal.AutoEllipsis = true;
            this.lbl_vlrOriginal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_vlrOriginal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_vlrOriginal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_vlrOriginal.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Bold);
            this.lbl_vlrOriginal.ForeColor = System.Drawing.Color.Black;
            this.lbl_vlrOriginal.Location = new System.Drawing.Point(748, 434);
            this.lbl_vlrOriginal.Name = "lbl_vlrOriginal";
            this.lbl_vlrOriginal.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_vlrOriginal.Size = new System.Drawing.Size(143, 44);
            this.lbl_vlrOriginal.TabIndex = 51;
            this.lbl_vlrOriginal.Text = "0,00";
            this.lbl_vlrOriginal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoEllipsis = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(514, 434);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(5);
            this.label11.Size = new System.Drawing.Size(228, 43);
            this.label11.TabIndex = 50;
            this.label11.Text = "Valor do Total";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_vrlDesconto
            // 
            this.lbl_vrlDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_vrlDesconto.AutoEllipsis = true;
            this.lbl_vrlDesconto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_vrlDesconto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_vrlDesconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_vrlDesconto.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.lbl_vrlDesconto.ForeColor = System.Drawing.Color.Black;
            this.lbl_vrlDesconto.Location = new System.Drawing.Point(748, 401);
            this.lbl_vrlDesconto.Name = "lbl_vrlDesconto";
            this.lbl_vrlDesconto.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_vrlDesconto.Size = new System.Drawing.Size(143, 44);
            this.lbl_vrlDesconto.TabIndex = 49;
            this.lbl_vrlDesconto.Text = "0,00";
            this.lbl_vrlDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoEllipsis = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(517, 402);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5);
            this.label9.Size = new System.Drawing.Size(225, 32);
            this.label9.TabIndex = 48;
            this.label9.Text = "Valor do Desconto";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_QtdeItens
            // 
            this.lbl_QtdeItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_QtdeItens.AutoEllipsis = true;
            this.lbl_QtdeItens.BackColor = System.Drawing.Color.Transparent;
            this.lbl_QtdeItens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_QtdeItens.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_QtdeItens.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QtdeItens.ForeColor = System.Drawing.Color.Black;
            this.lbl_QtdeItens.Location = new System.Drawing.Point(748, 367);
            this.lbl_QtdeItens.Name = "lbl_QtdeItens";
            this.lbl_QtdeItens.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_QtdeItens.Size = new System.Drawing.Size(143, 44);
            this.lbl_QtdeItens.TabIndex = 47;
            this.lbl_QtdeItens.Text = "0,00";
            this.lbl_QtdeItens.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(535, 367);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(207, 41);
            this.label2.TabIndex = 46;
            this.label2.Text = "Quantidade de itens";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbox_Cliente
            // 
            this.tbox_Cliente.BackColor = System.Drawing.Color.White;
            this.tbox_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbox_Cliente.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.tbox_Cliente.Location = new System.Drawing.Point(9, 19);
            this.tbox_Cliente.Name = "tbox_Cliente";
            this.tbox_Cliente.ReadOnly = true;
            this.tbox_Cliente.Size = new System.Drawing.Size(356, 23);
            this.tbox_Cliente.TabIndex = 54;
            this.tbox_Cliente.TabStop = false;
            this.tbox_Cliente.Text = "1 - Consumidor Final";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 15);
            this.label3.TabIndex = 55;
            this.label3.Text = "Pesquisar Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 56;
            this.label4.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 57;
            this.label5.Text = "Qtde.";
            // 
            // frm_Orcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Name = "frm_Orcamento";
            this.Text = "ORÇAMENTO";
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Itens_Venda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_Itens_Venda;
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
        public System.Windows.Forms.TextBox tboxLocalizarProduto;
        private System.Windows.Forms.TextBox tbox_Qtde;
        public System.Windows.Forms.Label lbl_vlrOriginal;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label lbl_vrlDesconto;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label lbl_QtdeItens;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbox_Cliente;
    }
}