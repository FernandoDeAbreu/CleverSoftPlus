namespace CleverSoft
{
    partial class frm_ProdutoConsultar
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
            this.tboxPesquisar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Descricao = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Codigo = new System.Windows.Forms.Label();
            this.lbl_CodBarras = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Unidade = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Estoque = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_Preco = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgv_resultado_pesquisa = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado_pesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::CleverSoft.Properties.Resources.degrade;
            // 
            // lbl_NomeRotina
            // 
            this.lbl_NomeRotina.Size = new System.Drawing.Size(161, 29);
            this.lbl_NomeRotina.Text = "ModeloSimples";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgv_resultado_pesquisa);
            this.panel1.Controls.Add(this.lbl_Preco);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lbl_Estoque);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lbl_Unidade);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lbl_CodBarras);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_Codigo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_Descricao);
            this.panel1.Controls.Add(this.tboxPesquisar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Size = new System.Drawing.Size(900, 600);
            this.panel1.Controls.SetChildIndex(this.label2, 0);
            this.panel1.Controls.SetChildIndex(this.tboxPesquisar, 0);
            this.panel1.Controls.SetChildIndex(this.lbl_Descricao, 0);
            this.panel1.Controls.SetChildIndex(this.label3, 0);
            this.panel1.Controls.SetChildIndex(this.lbl_Codigo, 0);
            this.panel1.Controls.SetChildIndex(this.label6, 0);
            this.panel1.Controls.SetChildIndex(this.lbl_CodBarras, 0);
            this.panel1.Controls.SetChildIndex(this.label8, 0);
            this.panel1.Controls.SetChildIndex(this.lbl_Unidade, 0);
            this.panel1.Controls.SetChildIndex(this.label10, 0);
            this.panel1.Controls.SetChildIndex(this.lbl_Estoque, 0);
            this.panel1.Controls.SetChildIndex(this.label12, 0);
            this.panel1.Controls.SetChildIndex(this.lbl_Preco, 0);
            this.panel1.Controls.SetChildIndex(this.dgv_resultado_pesquisa, 0);
            this.panel1.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            // 
            // tboxPesquisar
            // 
            this.tboxPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxPesquisar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tboxPesquisar.Location = new System.Drawing.Point(4, 67);
            this.tboxPesquisar.MaxLength = 45;
            this.tboxPesquisar.Name = "tboxPesquisar";
            this.tboxPesquisar.Size = new System.Drawing.Size(573, 29);
            this.tboxPesquisar.TabIndex = 0;
            this.tboxPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxPesquisar_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 15);
            this.label2.TabIndex = 40;
            this.label2.Text = "Código de barras / Descrição   (Enter para confirmar)";
            // 
            // lbl_Descricao
            // 
            this.lbl_Descricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(115)))), ((int)(((byte)(169)))));
            this.lbl_Descricao.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_Descricao.ForeColor = System.Drawing.Color.White;
            this.lbl_Descricao.Location = new System.Drawing.Point(3, 102);
            this.lbl_Descricao.Name = "lbl_Descricao";
            this.lbl_Descricao.Size = new System.Drawing.Size(891, 48);
            this.lbl_Descricao.TabIndex = 41;
            this.lbl_Descricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Código";
            // 
            // lbl_Codigo
            // 
            this.lbl_Codigo.BackColor = System.Drawing.Color.White;
            this.lbl_Codigo.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_Codigo.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Codigo.Location = new System.Drawing.Point(3, 229);
            this.lbl_Codigo.Name = "lbl_Codigo";
            this.lbl_Codigo.Size = new System.Drawing.Size(148, 34);
            this.lbl_Codigo.TabIndex = 43;
            this.lbl_Codigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CodBarras
            // 
            this.lbl_CodBarras.BackColor = System.Drawing.Color.White;
            this.lbl_CodBarras.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_CodBarras.ForeColor = System.Drawing.Color.Navy;
            this.lbl_CodBarras.Location = new System.Drawing.Point(3, 174);
            this.lbl_CodBarras.Name = "lbl_CodBarras";
            this.lbl_CodBarras.Size = new System.Drawing.Size(438, 34);
            this.lbl_CodBarras.TabIndex = 45;
            this.lbl_CodBarras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "Código de barras";
            // 
            // lbl_Unidade
            // 
            this.lbl_Unidade.BackColor = System.Drawing.Color.White;
            this.lbl_Unidade.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_Unidade.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Unidade.Location = new System.Drawing.Point(158, 229);
            this.lbl_Unidade.Name = "lbl_Unidade";
            this.lbl_Unidade.Size = new System.Drawing.Size(125, 34);
            this.lbl_Unidade.TabIndex = 47;
            this.lbl_Unidade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 46;
            this.label8.Text = "Unidade";
            // 
            // lbl_Estoque
            // 
            this.lbl_Estoque.BackColor = System.Drawing.Color.White;
            this.lbl_Estoque.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_Estoque.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Estoque.Location = new System.Drawing.Point(289, 229);
            this.lbl_Estoque.Name = "lbl_Estoque";
            this.lbl_Estoque.Size = new System.Drawing.Size(152, 34);
            this.lbl_Estoque.TabIndex = 49;
            this.lbl_Estoque.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(289, 211);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 15);
            this.label10.TabIndex = 48;
            this.label10.Text = "Estoque";
            // 
            // lbl_Preco
            // 
            this.lbl_Preco.BackColor = System.Drawing.Color.White;
            this.lbl_Preco.Font = new System.Drawing.Font("Segoe UI Semibold", 45F, System.Drawing.FontStyle.Bold);
            this.lbl_Preco.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Preco.Location = new System.Drawing.Point(447, 174);
            this.lbl_Preco.Name = "lbl_Preco";
            this.lbl_Preco.Size = new System.Drawing.Size(447, 89);
            this.lbl_Preco.TabIndex = 51;
            this.lbl_Preco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(444, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 15);
            this.label12.TabIndex = 50;
            this.label12.Text = "Preço";
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
            this.dgv_resultado_pesquisa.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_resultado_pesquisa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_resultado_pesquisa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_resultado_pesquisa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_resultado_pesquisa.ColumnHeadersHeight = 30;
            this.dgv_resultado_pesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_resultado_pesquisa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_resultado_pesquisa.EnableHeadersVisualStyles = false;
            this.dgv_resultado_pesquisa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_resultado_pesquisa.Location = new System.Drawing.Point(3, 270);
            this.dgv_resultado_pesquisa.MultiSelect = false;
            this.dgv_resultado_pesquisa.Name = "dgv_resultado_pesquisa";
            this.dgv_resultado_pesquisa.ReadOnly = true;
            this.dgv_resultado_pesquisa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_resultado_pesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_resultado_pesquisa.Size = new System.Drawing.Size(893, 307);
            this.dgv_resultado_pesquisa.TabIndex = 52;
            this.dgv_resultado_pesquisa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_resultado_pesquisa_CellDoubleClick);
            this.dgv_resultado_pesquisa.SelectionChanged += new System.EventHandler(this.dgv_resultado_pesquisa_SelectionChanged);
            this.dgv_resultado_pesquisa.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgv_resultado_pesquisa_UserAddedRow);
            this.dgv_resultado_pesquisa.Click += new System.EventHandler(this.dgv_resultado_pesquisa_Click);
            this.dgv_resultado_pesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_resultado_pesquisa_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 15);
            this.label1.TabIndex = 53;
            this.label1.Text = "ENTER para confirmar a pesquisa | TAB para ir para grid | F2 para fazer nova pesq" +
    "uisa | ESC para sair";
            // 
            // frm_ProdutoConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.MaximizeBox = false;
            this.Name = "frm_ProdutoConsultar";
            this.Text = "Consulta Preço";
            this.Load += new System.EventHandler(this.frm_ProdutoConsultar_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado_pesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Preco;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_Estoque;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_Unidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_CodBarras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Descricao;
        public System.Windows.Forms.TextBox tboxPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_resultado_pesquisa;
        private System.Windows.Forms.Label label1;
    }
}