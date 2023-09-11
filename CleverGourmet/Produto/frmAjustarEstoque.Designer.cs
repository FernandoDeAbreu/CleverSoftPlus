namespace CleverSoft.Produto
{
    partial class frmAjustarEstoque
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
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnTabelaPreco = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tboxCodigoAuxiliarP = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxDescricaoP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMovimentacao = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_resultado_pesquisa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_resultado_pesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_resultado_pesquisa.EnableHeadersVisualStyles = false;
            this.dgv_resultado_pesquisa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_resultado_pesquisa.Location = new System.Drawing.Point(0, 94);
            this.dgv_resultado_pesquisa.MultiSelect = false;
            this.dgv_resultado_pesquisa.Name = "dgv_resultado_pesquisa";
            this.dgv_resultado_pesquisa.ReadOnly = true;
            this.dgv_resultado_pesquisa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_resultado_pesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_resultado_pesquisa.Size = new System.Drawing.Size(894, 422);
            this.dgv_resultado_pesquisa.TabIndex = 120;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnNovo);
            this.flowLayoutPanel2.Controls.Add(this.btnTabelaPreco);
            this.flowLayoutPanel2.Controls.Add(this.btnRelatorio);
            this.flowLayoutPanel2.Controls.Add(this.btnMovimentacao);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 516);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(894, 35);
            this.flowLayoutPanel2.TabIndex = 121;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNovo.Location = new System.Drawing.Point(767, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(124, 29);
            this.btnNovo.TabIndex = 190;
            this.btnNovo.Text = "Novo Ajuste";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnTabelaPreco
            // 
            this.btnTabelaPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTabelaPreco.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTabelaPreco.Image = global::CleverSoft.Properties.Resources.printer1;
            this.btnTabelaPreco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTabelaPreco.Location = new System.Drawing.Point(620, 3);
            this.btnTabelaPreco.Name = "btnTabelaPreco";
            this.btnTabelaPreco.Size = new System.Drawing.Size(141, 29);
            this.btnTabelaPreco.TabIndex = 191;
            this.btnTabelaPreco.Text = "Tabela de Preço";
            this.btnTabelaPreco.UseVisualStyleBackColor = true;
            this.btnTabelaPreco.Click += new System.EventHandler(this.btnTabelaPreco_Click);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRelatorio.Image = global::CleverSoft.Properties.Resources.printer1;
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.Location = new System.Drawing.Point(473, 3);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(141, 29);
            this.btnRelatorio.TabIndex = 192;
            this.btnRelatorio.Text = "Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tboxCodigoAuxiliarP);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tboxDescricaoP);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 94);
            this.panel1.TabIndex = 122;
            // 
            // tboxCodigoAuxiliarP
            // 
            this.tboxCodigoAuxiliarP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxCodigoAuxiliarP.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.tboxCodigoAuxiliarP.Location = new System.Drawing.Point(4, 22);
            this.tboxCodigoAuxiliarP.MaxLength = 45;
            this.tboxCodigoAuxiliarP.Name = "tboxCodigoAuxiliarP";
            this.tboxCodigoAuxiliarP.Size = new System.Drawing.Size(206, 23);
            this.tboxCodigoAuxiliarP.TabIndex = 56;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPesquisar.Location = new System.Drawing.Point(784, 58);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(106, 29);
            this.btnPesquisar.TabIndex = 191;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label7.Location = new System.Drawing.Point(4, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 15);
            this.label7.TabIndex = 57;
            this.label7.Text = "Código Auxiliar";
            // 
            // tboxDescricaoP
            // 
            this.tboxDescricaoP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxDescricaoP.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.tboxDescricaoP.Location = new System.Drawing.Point(4, 64);
            this.tboxDescricaoP.MaxLength = 45;
            this.tboxDescricaoP.Name = "tboxDescricaoP";
            this.tboxDescricaoP.Size = new System.Drawing.Size(504, 23);
            this.tboxDescricaoP.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.label6.Location = new System.Drawing.Point(4, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 55;
            this.label6.Text = "Descrição";
            // 
            // btnMovimentacao
            // 
            this.btnMovimentacao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMovimentacao.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMovimentacao.Image = global::CleverSoft.Properties.Resources.printer1;
            this.btnMovimentacao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovimentacao.Location = new System.Drawing.Point(326, 3);
            this.btnMovimentacao.Name = "btnMovimentacao";
            this.btnMovimentacao.Size = new System.Drawing.Size(141, 29);
            this.btnMovimentacao.TabIndex = 193;
            this.btnMovimentacao.TabStop = false;
            this.btnMovimentacao.Text = "Movimentação";
            this.btnMovimentacao.UseVisualStyleBackColor = true;
            this.btnMovimentacao.Click += new System.EventHandler(this.btnMovimentacao_Click);
            // 
            // frmAjustarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Name = "frmAjustarEstoque";
            this.Text = "Ajustar Estoque";
            this.Load += new System.EventHandler(this.frmAjustarEstoque_Load);
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
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox tboxCodigoAuxiliarP;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tboxDescricaoP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTabelaPreco;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnMovimentacao;
    }
}