namespace CleverSoft.Produto
{
    partial class frmAjustarEstoque2
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
            this.rbtnEntrada = new System.Windows.Forms.RadioButton();
            this.rbtnSaida = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tboxDtMov = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxLocalizarProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tboxCodAuxiliar = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tboxDescricao = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tboxCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxMotivo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxQtde = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_Incluir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtnEntrada
            // 
            this.rbtnEntrada.AutoSize = true;
            this.rbtnEntrada.BackColor = System.Drawing.Color.Transparent;
            this.rbtnEntrada.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEntrada.ForeColor = System.Drawing.Color.White;
            this.rbtnEntrada.Location = new System.Drawing.Point(89, 12);
            this.rbtnEntrada.Name = "rbtnEntrada";
            this.rbtnEntrada.Size = new System.Drawing.Size(97, 23);
            this.rbtnEntrada.TabIndex = 0;
            this.rbtnEntrada.Text = "ENTRADA ";
            this.rbtnEntrada.UseVisualStyleBackColor = false;
            // 
            // rbtnSaida
            // 
            this.rbtnSaida.AutoSize = true;
            this.rbtnSaida.BackColor = System.Drawing.Color.Transparent;
            this.rbtnSaida.Checked = true;
            this.rbtnSaida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSaida.ForeColor = System.Drawing.Color.White;
            this.rbtnSaida.Location = new System.Drawing.Point(12, 12);
            this.rbtnSaida.Name = "rbtnSaida";
            this.rbtnSaida.Size = new System.Drawing.Size(69, 23);
            this.rbtnSaida.TabIndex = 1;
            this.rbtnSaida.TabStop = true;
            this.rbtnSaida.Text = "SAÍDA";
            this.rbtnSaida.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.panel1.BackgroundImage = global::CleverSoft.Properties.Resources.degrade;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.rbtnSaida);
            this.panel1.Controls.Add(this.rbtnEntrada);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 48);
            this.panel1.TabIndex = 3;
            // 
            // tboxDtMov
            // 
            this.tboxDtMov.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tboxDtMov.Location = new System.Drawing.Point(3, 69);
            this.tboxDtMov.Name = "tboxDtMov";
            this.tboxDtMov.Size = new System.Drawing.Size(117, 23);
            this.tboxDtMov.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data Mov.";
            // 
            // tboxLocalizarProduto
            // 
            this.tboxLocalizarProduto.Location = new System.Drawing.Point(126, 69);
            this.tboxLocalizarProduto.MaxLength = 20;
            this.tboxLocalizarProduto.Name = "tboxLocalizarProduto";
            this.tboxLocalizarProduto.Size = new System.Drawing.Size(230, 23);
            this.tboxLocalizarProduto.TabIndex = 6;
            this.tboxLocalizarProduto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_Pesquisar_KeyDown);
            this.tboxLocalizarProduto.Leave += new System.EventHandler(this.tboxLocalizarProduto_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Código de barras";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(451, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 15);
            this.label17.TabIndex = 190;
            this.label17.Text = "Código Auxiliar";
            // 
            // tboxCodAuxiliar
            // 
            this.tboxCodAuxiliar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tboxCodAuxiliar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxCodAuxiliar.Location = new System.Drawing.Point(451, 111);
            this.tboxCodAuxiliar.MaxLength = 45;
            this.tboxCodAuxiliar.Name = "tboxCodAuxiliar";
            this.tboxCodAuxiliar.ReadOnly = true;
            this.tboxCodAuxiliar.Size = new System.Drawing.Size(143, 23);
            this.tboxCodAuxiliar.TabIndex = 187;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(101, 95);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 15);
            this.label18.TabIndex = 189;
            this.label18.Text = "Descrição";
            // 
            // tboxDescricao
            // 
            this.tboxDescricao.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tboxDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxDescricao.Location = new System.Drawing.Point(101, 111);
            this.tboxDescricao.MaxLength = 45;
            this.tboxDescricao.Name = "tboxDescricao";
            this.tboxDescricao.ReadOnly = true;
            this.tboxDescricao.Size = new System.Drawing.Size(344, 23);
            this.tboxDescricao.TabIndex = 186;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 95);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 15);
            this.label20.TabIndex = 188;
            this.label20.Text = "Código";
            // 
            // tboxCodigo
            // 
            this.tboxCodigo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tboxCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxCodigo.Location = new System.Drawing.Point(4, 111);
            this.tboxCodigo.MaxLength = 45;
            this.tboxCodigo.Name = "tboxCodigo";
            this.tboxCodigo.ReadOnly = true;
            this.tboxCodigo.Size = new System.Drawing.Size(91, 23);
            this.tboxCodigo.TabIndex = 185;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 192;
            this.label3.Text = "Motivo do ajuste";
            // 
            // tboxMotivo
            // 
            this.tboxMotivo.Location = new System.Drawing.Point(4, 156);
            this.tboxMotivo.MaxLength = 100;
            this.tboxMotivo.Name = "tboxMotivo";
            this.tboxMotivo.Size = new System.Drawing.Size(441, 23);
            this.tboxMotivo.TabIndex = 191;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 194;
            this.label4.Text = "Quantidade";
            // 
            // tboxQtde
            // 
            this.tboxQtde.Location = new System.Drawing.Point(451, 156);
            this.tboxQtde.MaxLength = 20;
            this.tboxQtde.Name = "tboxQtde";
            this.tboxQtde.Size = new System.Drawing.Size(143, 23);
            this.tboxQtde.TabIndex = 193;
            this.tboxQtde.Text = "1,00";
            this.tboxQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tboxQtde.Leave += new System.EventHandler(this.tboxQtde_Leave);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(362, 71);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(123, 19);
            this.checkBox1.TabIndex = 195;
            this.checkBox1.Text = "Confirma com bip";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Incluir.Location = new System.Drawing.Point(490, 214);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(104, 26);
            this.btn_Incluir.TabIndex = 196;
            this.btn_Incluir.Text = "Confirmar";
            this.btn_Incluir.UseVisualStyleBackColor = true;
            this.btn_Incluir.Click += new System.EventHandler(this.btn_Incluir_Click);
            // 
            // frmAjustarEstoque2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 252);
            this.Controls.Add(this.btn_Incluir);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxQtde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxMotivo);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tboxCodAuxiliar);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tboxDescricao);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tboxCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxLocalizarProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxDtMov);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAjustarEstoque2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustar Estoque";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnEntrada;
        private System.Windows.Forms.RadioButton rbtnSaida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker tboxDtMov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxLocalizarProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox tboxCodAuxiliar;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.TextBox tboxDescricao;
        private System.Windows.Forms.Label label20;
        public System.Windows.Forms.TextBox tboxCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxMotivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxQtde;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_Incluir;
    }
}