namespace CleverSoft
{
    partial class frm_Permissao
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
            this.ROTINA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CH = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_PesquisarUsuario = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxParceiro = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado_pesquisa)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NomeRotina
            // 
            this.lbl_NomeRotina.Size = new System.Drawing.Size(161, 29);
            this.lbl_NomeRotina.Text = "ModeloSimples";
            // 
            // iconcerrar
            // 
            this.iconcerrar.Location = new System.Drawing.Point(880, 3);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.btn_Salvar);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.btn_PesquisarUsuario);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tboxParceiro);
            this.panel1.Controls.Add(this.dgv_resultado_pesquisa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Size = new System.Drawing.Size(900, 600);
            this.panel1.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.Controls.SetChildIndex(this.dgv_resultado_pesquisa, 0);
            this.panel1.Controls.SetChildIndex(this.tboxParceiro, 0);
            this.panel1.Controls.SetChildIndex(this.label4, 0);
            this.panel1.Controls.SetChildIndex(this.btn_PesquisarUsuario, 0);
            this.panel1.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.panel1.Controls.SetChildIndex(this.btn_Salvar, 0);
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
            this.dgv_resultado_pesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ROTINA,
            this.CH});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_resultado_pesquisa.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_resultado_pesquisa.EnableHeadersVisualStyles = false;
            this.dgv_resultado_pesquisa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_resultado_pesquisa.Location = new System.Drawing.Point(4, 134);
            this.dgv_resultado_pesquisa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_resultado_pesquisa.MultiSelect = false;
            this.dgv_resultado_pesquisa.Name = "dgv_resultado_pesquisa";
            this.dgv_resultado_pesquisa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_resultado_pesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_resultado_pesquisa.Size = new System.Drawing.Size(891, 418);
            this.dgv_resultado_pesquisa.TabIndex = 42;
            this.dgv_resultado_pesquisa.Click += new System.EventHandler(this.dgv_resultado_pesquisa_Click);
            this.dgv_resultado_pesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_resultado_pesquisa_KeyDown);
            // 
            // ROTINA
            // 
            this.ROTINA.HeaderText = "ROTINA";
            this.ROTINA.Name = "ROTINA";
            this.ROTINA.ReadOnly = true;
            this.ROTINA.Width = 500;
            // 
            // CH
            // 
            this.CH.FalseValue = "0";
            this.CH.HeaderText = "CH";
            this.CH.Name = "CH";
            this.CH.TrueValue = "1";
            this.CH.Width = 40;
            // 
            // btn_PesquisarUsuario
            // 
            this.btn_PesquisarUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.btn_PesquisarUsuario.FlatAppearance.BorderSize = 0;
            this.btn_PesquisarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PesquisarUsuario.Image = global::CleverSoft.Properties.Resources.magnifier1;
            this.btn_PesquisarUsuario.Location = new System.Drawing.Point(499, 78);
            this.btn_PesquisarUsuario.Name = "btn_PesquisarUsuario";
            this.btn_PesquisarUsuario.Size = new System.Drawing.Size(51, 20);
            this.btn_PesquisarUsuario.TabIndex = 83;
            this.btn_PesquisarUsuario.TabStop = false;
            this.btn_PesquisarUsuario.UseVisualStyleBackColor = false;
            this.btn_PesquisarUsuario.Click += new System.EventHandler(this.btn_PesquisarUsuario_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 15);
            this.label4.TabIndex = 82;
            this.label4.Text = "Usuário Sistema";
            // 
            // tboxParceiro
            // 
            this.tboxParceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxParceiro.Location = new System.Drawing.Point(8, 77);
            this.tboxParceiro.MaxLength = 45;
            this.tboxParceiro.Name = "tboxParceiro";
            this.tboxParceiro.ReadOnly = true;
            this.tboxParceiro.Size = new System.Drawing.Size(543, 23);
            this.tboxParceiro.TabIndex = 81;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(590, 67);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(126, 32);
            this.btnPesquisar.TabIndex = 84;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_Salvar.FlatAppearance.BorderSize = 0;
            this.btn_Salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salvar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Salvar.ForeColor = System.Drawing.Color.White;
            this.btn_Salvar.Image = global::CleverSoft.Properties.Resources.diskette;
            this.btn_Salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salvar.Location = new System.Drawing.Point(739, 558);
            this.btn_Salvar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(150, 34);
            this.btn_Salvar.TabIndex = 85;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Salvar.UseVisualStyleBackColor = false;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // frm_Permissao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Name = "frm_Permissao";
            this.Text = "CADASTRAR PERMISSÃO";
            this.Load += new System.EventHandler(this.frm_Permissao_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado_pesquisa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_resultado_pesquisa;
        private System.Windows.Forms.Button btn_PesquisarUsuario;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tboxParceiro;
        private System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ROTINA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CH;
    }
}