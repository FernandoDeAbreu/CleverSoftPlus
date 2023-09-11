namespace CleverSoft
{
    partial class frmAbrirCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbrirCaixa));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxParceiro = new System.Windows.Forms.TextBox();
            this.tboxSuprimento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_NomeRotina = new System.Windows.Forms.Label();
            this.iconcerrar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(130, 23);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 128;
            this.label3.Text = "Operador";
            // 
            // tboxParceiro
            // 
            this.tboxParceiro.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tboxParceiro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxParceiro.Location = new System.Drawing.Point(9, 108);
            this.tboxParceiro.MaxLength = 45;
            this.tboxParceiro.Name = "tboxParceiro";
            this.tboxParceiro.ReadOnly = true;
            this.tboxParceiro.Size = new System.Drawing.Size(401, 23);
            this.tboxParceiro.TabIndex = 127;
            this.tboxParceiro.TabStop = false;
            // 
            // tboxSuprimento
            // 
            this.tboxSuprimento.Font = new System.Drawing.Font("Calibri", 11F);
            this.tboxSuprimento.Location = new System.Drawing.Point(9, 153);
            this.tboxSuprimento.Name = "tboxSuprimento";
            this.tboxSuprimento.Size = new System.Drawing.Size(100, 25);
            this.tboxSuprimento.TabIndex = 0;
            this.tboxSuprimento.Text = "0,00";
            this.tboxSuprimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tboxSuprimento.Leave += new System.EventHandler(this.tboxSuprimento_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 130;
            this.label1.Text = "Suprimento";
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Confirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Confirmar.Location = new System.Drawing.Point(315, 248);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(100, 30);
            this.btn_Confirmar.TabIndex = 1;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelBarraTitulo);
            this.panel1.Controls.Add(this.btn_Confirmar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 290);
            this.panel1.TabIndex = 131;
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.panelBarraTitulo.BackgroundImage = global::CleverSoft.Properties.Resources.degrade;
            this.panelBarraTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBarraTitulo.Controls.Add(this.label2);
            this.panelBarraTitulo.Controls.Add(this.lbl_NomeRotina);
            this.panelBarraTitulo.Controls.Add(this.iconcerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(422, 45);
            this.panelBarraTitulo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Clever Sistemas";
            // 
            // lbl_NomeRotina
            // 
            this.lbl_NomeRotina.AutoSize = true;
            this.lbl_NomeRotina.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NomeRotina.Font = new System.Drawing.Font("Calibri Light", 18F);
            this.lbl_NomeRotina.ForeColor = System.Drawing.Color.Snow;
            this.lbl_NomeRotina.Location = new System.Drawing.Point(-1, -2);
            this.lbl_NomeRotina.Name = "lbl_NomeRotina";
            this.lbl_NomeRotina.Size = new System.Drawing.Size(115, 29);
            this.lbl_NomeRotina.TabIndex = 1;
            this.lbl_NomeRotina.Text = "Abrir Caixa";
            // 
            // iconcerrar
            // 
            this.iconcerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconcerrar.BackColor = System.Drawing.Color.Transparent;
            this.iconcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconcerrar.Image = ((System.Drawing.Image)(resources.GetObject("iconcerrar.Image")));
            this.iconcerrar.Location = new System.Drawing.Point(401, 3);
            this.iconcerrar.Name = "iconcerrar";
            this.iconcerrar.Size = new System.Drawing.Size(18, 18);
            this.iconcerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconcerrar.TabIndex = 13;
            this.iconcerrar.TabStop = false;
            this.iconcerrar.Click += new System.EventHandler(this.iconcerrar_Click);
            // 
            // frmAbrirCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 290);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxSuprimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxParceiro);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbrirCaixa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abrir Caixa";
            this.panel1.ResumeLayout(false);
            this.panelBarraTitulo.ResumeLayout(false);
            this.panelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tboxParceiro;
        private System.Windows.Forms.TextBox tboxSuprimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Panel panelBarraTitulo;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label lbl_NomeRotina;
        internal System.Windows.Forms.PictureBox iconcerrar;
    }
}