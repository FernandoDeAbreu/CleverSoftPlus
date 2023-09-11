namespace CleverSoft
{
    partial class frm_FinanceiroPagto
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_NomeRotina = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.tboxTotal = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tboxJuros = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tboxDesconto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tboxValor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(115)))), ((int)(((byte)(169)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lbl_NomeRotina);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Controls.Add(this.btn_Confirmar);
            this.panel1.Controls.Add(this.tboxTotal);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.tboxJuros);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.tboxDesconto);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.tboxValor);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 431);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_NomeRotina
            // 
            this.lbl_NomeRotina.AutoEllipsis = true;
            this.lbl_NomeRotina.AutoSize = true;
            this.lbl_NomeRotina.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NomeRotina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_NomeRotina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_NomeRotina.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NomeRotina.ForeColor = System.Drawing.Color.White;
            this.lbl_NomeRotina.Location = new System.Drawing.Point(3, 0);
            this.lbl_NomeRotina.Name = "lbl_NomeRotina";
            this.lbl_NomeRotina.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_NomeRotina.Size = new System.Drawing.Size(275, 40);
            this.lbl_NomeRotina.TabIndex = 80;
            this.lbl_NomeRotina.Text = "INFORMAR PAGAMENTO";
            this.lbl_NomeRotina.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 79;
            this.label1.Text = "Data pagto";
            // 
            // btn_excluir
            // 
            this.btn_excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.Image = global::CleverSoft.Properties.Resources.cancel;
            this.btn_excluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_excluir.Location = new System.Drawing.Point(333, 380);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(150, 39);
            this.btn_excluir.TabIndex = 7;
            this.btn_excluir.Text = "Cancelar";
            this.btn_excluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Confirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_Confirmar.FlatAppearance.BorderSize = 0;
            this.btn_Confirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btn_Confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_Confirmar.Image = global::CleverSoft.Properties.Resources.accept_button;
            this.btn_Confirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Confirmar.Location = new System.Drawing.Point(175, 380);
            this.btn_Confirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(150, 39);
            this.btn_Confirmar.TabIndex = 10;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // tboxTotal
            // 
            this.tboxTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxTotal.Location = new System.Drawing.Point(360, 154);
            this.tboxTotal.MaxLength = 45;
            this.tboxTotal.Name = "tboxTotal";
            this.tboxTotal.ReadOnly = true;
            this.tboxTotal.Size = new System.Drawing.Size(124, 27);
            this.tboxTotal.TabIndex = 73;
            this.tboxTotal.Text = "0,00";
            this.tboxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxTotal.Leave += new System.EventHandler(this.tboxTotal_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(12, 157);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 20);
            this.label15.TabIndex = 77;
            this.label15.Text = "Total R$";
            // 
            // tboxJuros
            // 
            this.tboxJuros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxJuros.Location = new System.Drawing.Point(360, 121);
            this.tboxJuros.MaxLength = 45;
            this.tboxJuros.Name = "tboxJuros";
            this.tboxJuros.Size = new System.Drawing.Size(124, 27);
            this.tboxJuros.TabIndex = 72;
            this.tboxJuros.Text = "0,00";
            this.tboxJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxJuros.Leave += new System.EventHandler(this.tboxJuros_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(12, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 20);
            this.label14.TabIndex = 76;
            this.label14.Text = "Juros R$";
            // 
            // tboxDesconto
            // 
            this.tboxDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxDesconto.Location = new System.Drawing.Point(360, 88);
            this.tboxDesconto.MaxLength = 45;
            this.tboxDesconto.Name = "tboxDesconto";
            this.tboxDesconto.Size = new System.Drawing.Size(124, 27);
            this.tboxDesconto.TabIndex = 71;
            this.tboxDesconto.Text = "0,00";
            this.tboxDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxDesconto.Leave += new System.EventHandler(this.tboxDesconto_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 20);
            this.label13.TabIndex = 75;
            this.label13.Text = "Descontos R$";
            // 
            // tboxValor
            // 
            this.tboxValor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxValor.Location = new System.Drawing.Point(360, 55);
            this.tboxValor.MaxLength = 45;
            this.tboxValor.Name = "tboxValor";
            this.tboxValor.ReadOnly = true;
            this.tboxValor.Size = new System.Drawing.Size(124, 27);
            this.tboxValor.TabIndex = 70;
            this.tboxValor.Text = "0,00";
            this.tboxValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxValor.Leave += new System.EventHandler(this.tboxValor_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(12, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 20);
            this.label12.TabIndex = 74;
            this.label12.Text = "Valor R$";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(360, 188);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(124, 27);
            this.dateTimePicker1.TabIndex = 81;
            // 
            // frm_FinanceiroPagto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 431);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_FinanceiroPagto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_FinanceiroPagto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TextBox tboxTotal;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox tboxJuros;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.TextBox tboxDesconto;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox tboxValor;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button btn_Confirmar;
        public System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbl_NomeRotina;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}