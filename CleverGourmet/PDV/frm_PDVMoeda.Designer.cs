namespace CleverSoft
{
    partial class frm_PDVMoeda
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
            this.cbox_moeda = new System.Windows.Forms.ComboBox();
            this.tboxVAlor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tboxNumDoc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxAutorizacao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox_qtdeParcelas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxDtVenc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(115)))), ((int)(((byte)(169)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbox_moeda);
            this.panel1.Controls.Add(this.tboxVAlor);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tboxNumDoc);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tboxAutorizacao);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbox_qtdeParcelas);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tboxDtVenc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 427);
            this.panel1.TabIndex = 1;
            // 
            // cbox_moeda
            // 
            this.cbox_moeda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_moeda.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.cbox_moeda.FormattingEnabled = true;
            this.cbox_moeda.Location = new System.Drawing.Point(193, 40);
            this.cbox_moeda.Name = "cbox_moeda";
            this.cbox_moeda.Size = new System.Drawing.Size(329, 53);
            this.cbox_moeda.TabIndex = 0;
            this.cbox_moeda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            this.cbox_moeda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyUp);
            // 
            // tboxVAlor
            // 
            this.tboxVAlor.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.tboxVAlor.Location = new System.Drawing.Point(262, 335);
            this.tboxVAlor.Name = "tboxVAlor";
            this.tboxVAlor.Size = new System.Drawing.Size(260, 50);
            this.tboxVAlor.TabIndex = 5;
            this.tboxVAlor.Text = "0,00";
            this.tboxVAlor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tboxVAlor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxVAlor_KeyDown);
            this.tboxVAlor.Leave += new System.EventHandler(this.tboxVAlor_Leave);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoEllipsis = true;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(89, 334);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5);
            this.label8.Size = new System.Drawing.Size(113, 51);
            this.label8.TabIndex = 59;
            this.label8.Text = "Valor :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tboxNumDoc
            // 
            this.tboxNumDoc.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.tboxNumDoc.Location = new System.Drawing.Point(262, 276);
            this.tboxNumDoc.MaxLength = 15;
            this.tboxNumDoc.Name = "tboxNumDoc";
            this.tboxNumDoc.Size = new System.Drawing.Size(260, 50);
            this.tboxNumDoc.TabIndex = 4;
            this.tboxNumDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tboxNumDoc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoEllipsis = true;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 275);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.Size = new System.Drawing.Size(179, 51);
            this.label7.TabIndex = 57;
            this.label7.Text = "NSU/DOC :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tboxAutorizacao
            // 
            this.tboxAutorizacao.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.tboxAutorizacao.Location = new System.Drawing.Point(262, 217);
            this.tboxAutorizacao.MaxLength = 15;
            this.tboxAutorizacao.Name = "tboxAutorizacao";
            this.tboxAutorizacao.Size = new System.Drawing.Size(260, 50);
            this.tboxAutorizacao.TabIndex = 3;
            this.tboxAutorizacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tboxAutorizacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(-5, 216);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5);
            this.label6.Size = new System.Drawing.Size(207, 51);
            this.label6.TabIndex = 55;
            this.label6.Text = "Autorização :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbox_qtdeParcelas
            // 
            this.tbox_qtdeParcelas.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.tbox_qtdeParcelas.Location = new System.Drawing.Point(262, 158);
            this.tbox_qtdeParcelas.MaxLength = 15;
            this.tbox_qtdeParcelas.Name = "tbox_qtdeParcelas";
            this.tbox_qtdeParcelas.Size = new System.Drawing.Size(260, 50);
            this.tbox_qtdeParcelas.TabIndex = 2;
            this.tbox_qtdeParcelas.Text = "1";
            this.tbox_qtdeParcelas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_qtdeParcelas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            this.tbox_qtdeParcelas.Leave += new System.EventHandler(this.tbox_qtdeParcelas_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(48, 157);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(154, 51);
            this.label5.TabIndex = 53;
            this.label5.Text = "Parcelas :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tboxDtVenc
            // 
            this.tboxDtVenc.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.tboxDtVenc.Location = new System.Drawing.Point(262, 99);
            this.tboxDtVenc.Name = "tboxDtVenc";
            this.tboxDtVenc.Size = new System.Drawing.Size(260, 50);
            this.tboxDtVenc.TabIndex = 1;
            this.tboxDtVenc.Text = "01/01/2021";
            this.tboxDtVenc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tboxDtVenc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            this.tboxDtVenc.Leave += new System.EventHandler(this.tboxDtVenc_Leave);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(47, 98);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(155, 51);
            this.label3.TabIndex = 51;
            this.label3.Text = "Dt. Venc.:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label4.Location = new System.Drawing.Point(-1, 395);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(548, 46);
            this.label4.TabIndex = 49;
            this.label4.Text = "(Esc) - Sair  |  (Tab) - Próx. campo | (Enter) - Confirmar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(63, 39);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(139, 51);
            this.label2.TabIndex = 47;
            this.label2.Text = "Moeda :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label1.Location = new System.Drawing.Point(-4, -12);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(370, 56);
            this.label1.TabIndex = 44;
            this.label1.Text = "Forma de Pagamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm_PDVMoeda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 427);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_PDVMoeda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PDVMoeda";
            this.Load += new System.EventHandler(this.frm_PDVMoeda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tboxDtVenc;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tboxNumDoc;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxAutorizacao;
        public System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbox_qtdeParcelas;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbox_moeda;
        public System.Windows.Forms.TextBox tboxVAlor;
    }
}