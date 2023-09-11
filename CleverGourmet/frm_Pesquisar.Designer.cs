namespace CleverSoft
{
    partial class frm_Pesquisar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Pesquisar));
            this.dgv_resultado_pesquisa = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tboxPesquisar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_NomeRotina = new System.Windows.Forms.Label();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.tbox_qtde = new System.Windows.Forms.TextBox();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado_pesquisa)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_resultado_pesquisa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_resultado_pesquisa.ColumnHeadersHeight = 30;
            this.dgv_resultado_pesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_resultado_pesquisa.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_resultado_pesquisa.EnableHeadersVisualStyles = false;
            this.dgv_resultado_pesquisa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_resultado_pesquisa.Location = new System.Drawing.Point(3, 98);
            this.dgv_resultado_pesquisa.MultiSelect = false;
            this.dgv_resultado_pesquisa.Name = "dgv_resultado_pesquisa";
            this.dgv_resultado_pesquisa.ReadOnly = true;
            this.dgv_resultado_pesquisa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_resultado_pesquisa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_resultado_pesquisa.Size = new System.Drawing.Size(634, 236);
            this.dgv_resultado_pesquisa.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tboxPesquisar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.tbox_qtde);
            this.panel1.Controls.Add(this.dgv_resultado_pesquisa);
            this.panel1.Controls.Add(this.btn_Pesquisar);
            this.panel1.Controls.Add(this.btn_Confirmar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 410);
            this.panel1.TabIndex = 42;
            // 
            // tboxPesquisar
            // 
            this.tboxPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxPesquisar.Location = new System.Drawing.Point(5, 65);
            this.tboxPesquisar.MaxLength = 45;
            this.tboxPesquisar.Name = "tboxPesquisar";
            this.tboxPesquisar.Size = new System.Drawing.Size(630, 23);
            this.tboxPesquisar.TabIndex = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 15);
            this.label2.TabIndex = 101;
            this.label2.Text = "Dados para a pesquisa";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(115)))), ((int)(((byte)(169)))));
            this.panel2.BackgroundImage = global::CleverSoft.Properties.Resources.degrade;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbl_NomeRotina);
            this.panel2.Controls.Add(this.iconcerrar);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 39);
            this.panel2.TabIndex = 46;
            // 
            // lbl_NomeRotina
            // 
            this.lbl_NomeRotina.AutoEllipsis = true;
            this.lbl_NomeRotina.AutoSize = true;
            this.lbl_NomeRotina.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NomeRotina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_NomeRotina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_NomeRotina.Font = new System.Drawing.Font("Calibri Light", 18F);
            this.lbl_NomeRotina.ForeColor = System.Drawing.Color.White;
            this.lbl_NomeRotina.Location = new System.Drawing.Point(-5, -8);
            this.lbl_NomeRotina.Name = "lbl_NomeRotina";
            this.lbl_NomeRotina.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lbl_NomeRotina.Size = new System.Drawing.Size(337, 37);
            this.lbl_NomeRotina.TabIndex = 32;
            this.lbl_NomeRotina.Text = "MENU INICIAL - CLEVER SISTEMA";
            this.lbl_NomeRotina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // iconcerrar
            // 
            this.iconcerrar.BackColor = System.Drawing.Color.Transparent;
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(618, 4);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(18, 18);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 31;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // tbox_qtde
            // 
            this.tbox_qtde.Location = new System.Drawing.Point(483, 339);
            this.tbox_qtde.Name = "tbox_qtde";
            this.tbox_qtde.ReadOnly = true;
            this.tbox_qtde.Size = new System.Drawing.Size(154, 23);
            this.tbox_qtde.TabIndex = 45;
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_Pesquisar.FlatAppearance.BorderSize = 0;
            this.btn_Pesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Pesquisar.ForeColor = System.Drawing.Color.White;
            this.btn_Pesquisar.Image = global::CleverSoft.Properties.Resources.find;
            this.btn_Pesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Pesquisar.Location = new System.Drawing.Point(486, 369);
            this.btn_Pesquisar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(150, 34);
            this.btn_Pesquisar.TabIndex = 43;
            this.btn_Pesquisar.Text = "Pesquisar";
            this.btn_Pesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Pesquisar.UseVisualStyleBackColor = false;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_Confirmar.FlatAppearance.BorderSize = 0;
            this.btn_Confirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_Confirmar.Image = global::CleverSoft.Properties.Resources.accept_button;
            this.btn_Confirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Confirmar.Location = new System.Drawing.Point(329, 369);
            this.btn_Confirmar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(150, 34);
            this.btn_Confirmar.TabIndex = 44;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(2, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 102;
            this.label1.Text = "Clever Sistemas";
            // 
            // frm_Pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 410);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Pesquisar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar";
            this.Load += new System.EventHandler(this.frm_Pesquisar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado_pesquisa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_resultado_pesquisa;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btn_Pesquisar;
        public System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.TextBox tbox_qtde;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label lbl_NomeRotina;
        public System.Windows.Forms.PictureBox iconcerrar;
        public System.Windows.Forms.TextBox tboxPesquisar;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
    }
}