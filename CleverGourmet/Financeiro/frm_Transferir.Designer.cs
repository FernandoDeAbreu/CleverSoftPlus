namespace CleverSoft.Financeiro
{
    partial class frm_Transferir
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
            this.btn_PesquisarBanco = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxBancoConta = new System.Windows.Forms.TextBox();
            this.btn_PesquisarMoeda = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxMoeda = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PesquisarMoeda1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxMoeda1 = new System.Windows.Forms.TextBox();
            this.tboxBancoConta1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbox_Data = new System.Windows.Forms.DateTimePicker();
            this.tbox_Valor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbox_NumIndent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox_NumDoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_NomeRotina
            // 
            this.lbl_NomeRotina.Size = new System.Drawing.Size(175, 40);
            this.lbl_NomeRotina.Text = "ModeloSimples";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Confirmar);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.SetChildIndex(this.groupBox1, 0);
            this.panel1.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.Controls.SetChildIndex(this.groupBox2, 0);
            this.panel1.Controls.SetChildIndex(this.groupBox3, 0);
            this.panel1.Controls.SetChildIndex(this.btn_Confirmar, 0);
            // 
            // btn_PesquisarBanco
            // 
            this.btn_PesquisarBanco.BackColor = System.Drawing.SystemColors.Control;
            this.btn_PesquisarBanco.FlatAppearance.BorderSize = 0;
            this.btn_PesquisarBanco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PesquisarBanco.Image = global::CleverSoft.Properties.Resources.magnifier1;
            this.btn_PesquisarBanco.Location = new System.Drawing.Point(312, 51);
            this.btn_PesquisarBanco.Name = "btn_PesquisarBanco";
            this.btn_PesquisarBanco.Size = new System.Drawing.Size(51, 23);
            this.btn_PesquisarBanco.TabIndex = 108;
            this.btn_PesquisarBanco.TabStop = false;
            this.btn_PesquisarBanco.UseVisualStyleBackColor = false;
            this.btn_PesquisarBanco.Click += new System.EventHandler(this.btn_PesquisarBanco_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 107;
            this.label4.Text = "Banco / Conta";
            // 
            // tboxBancoConta
            // 
            this.tboxBancoConta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxBancoConta.Location = new System.Drawing.Point(15, 50);
            this.tboxBancoConta.MaxLength = 45;
            this.tboxBancoConta.Name = "tboxBancoConta";
            this.tboxBancoConta.ReadOnly = true;
            this.tboxBancoConta.Size = new System.Drawing.Size(350, 25);
            this.tboxBancoConta.TabIndex = 106;
            // 
            // btn_PesquisarMoeda
            // 
            this.btn_PesquisarMoeda.BackColor = System.Drawing.SystemColors.Control;
            this.btn_PesquisarMoeda.FlatAppearance.BorderSize = 0;
            this.btn_PesquisarMoeda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PesquisarMoeda.Image = global::CleverSoft.Properties.Resources.magnifier1;
            this.btn_PesquisarMoeda.Location = new System.Drawing.Point(581, 51);
            this.btn_PesquisarMoeda.Name = "btn_PesquisarMoeda";
            this.btn_PesquisarMoeda.Size = new System.Drawing.Size(51, 23);
            this.btn_PesquisarMoeda.TabIndex = 111;
            this.btn_PesquisarMoeda.TabStop = false;
            this.btn_PesquisarMoeda.UseVisualStyleBackColor = false;
            this.btn_PesquisarMoeda.Click += new System.EventHandler(this.btn_PesquisarMoeda_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 19);
            this.label5.TabIndex = 110;
            this.label5.Text = "Moeda";
            // 
            // tboxMoeda
            // 
            this.tboxMoeda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxMoeda.Location = new System.Drawing.Point(371, 50);
            this.tboxMoeda.MaxLength = 45;
            this.tboxMoeda.Name = "tboxMoeda";
            this.tboxMoeda.ReadOnly = true;
            this.tboxMoeda.Size = new System.Drawing.Size(262, 25);
            this.tboxMoeda.TabIndex = 109;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_PesquisarMoeda);
            this.groupBox1.Controls.Add(this.btn_PesquisarBanco);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tboxMoeda);
            this.groupBox1.Controls.Add(this.tboxBancoConta);
            this.groupBox1.Location = new System.Drawing.Point(11, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 103);
            this.groupBox1.TabIndex = 112;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Origem";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_PesquisarMoeda1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tboxMoeda1);
            this.groupBox2.Controls.Add(this.tboxBancoConta1);
            this.groupBox2.Location = new System.Drawing.Point(11, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 97);
            this.groupBox2.TabIndex = 113;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Destino";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 107;
            this.label1.Text = "Banco / Conta";
            // 
            // btn_PesquisarMoeda1
            // 
            this.btn_PesquisarMoeda1.BackColor = System.Drawing.SystemColors.Control;
            this.btn_PesquisarMoeda1.FlatAppearance.BorderSize = 0;
            this.btn_PesquisarMoeda1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PesquisarMoeda1.Image = global::CleverSoft.Properties.Resources.magnifier1;
            this.btn_PesquisarMoeda1.Location = new System.Drawing.Point(581, 51);
            this.btn_PesquisarMoeda1.Name = "btn_PesquisarMoeda1";
            this.btn_PesquisarMoeda1.Size = new System.Drawing.Size(51, 23);
            this.btn_PesquisarMoeda1.TabIndex = 111;
            this.btn_PesquisarMoeda1.TabStop = false;
            this.btn_PesquisarMoeda1.UseVisualStyleBackColor = false;
            this.btn_PesquisarMoeda1.Click += new System.EventHandler(this.btn_PesquisarMoeda1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::CleverSoft.Properties.Resources.magnifier1;
            this.button2.Location = new System.Drawing.Point(312, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 23);
            this.button2.TabIndex = 108;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 110;
            this.label2.Text = "Moeda";
            // 
            // tboxMoeda1
            // 
            this.tboxMoeda1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxMoeda1.Location = new System.Drawing.Point(371, 50);
            this.tboxMoeda1.MaxLength = 45;
            this.tboxMoeda1.Name = "tboxMoeda1";
            this.tboxMoeda1.ReadOnly = true;
            this.tboxMoeda1.Size = new System.Drawing.Size(262, 25);
            this.tboxMoeda1.TabIndex = 109;
            // 
            // tboxBancoConta1
            // 
            this.tboxBancoConta1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxBancoConta1.Location = new System.Drawing.Point(15, 50);
            this.tboxBancoConta1.MaxLength = 45;
            this.tboxBancoConta1.Name = "tboxBancoConta1";
            this.tboxBancoConta1.ReadOnly = true;
            this.tboxBancoConta1.Size = new System.Drawing.Size(350, 25);
            this.tboxBancoConta1.TabIndex = 106;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbox_Data);
            this.groupBox3.Controls.Add(this.tbox_Valor);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbox_NumIndent);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tbox_NumDoc);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(11, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(665, 91);
            this.groupBox3.TabIndex = 114;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Documento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(222, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 19);
            this.label9.TabIndex = 116;
            this.label9.Text = "Data";
            // 
            // tbox_Data
            // 
            this.tbox_Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tbox_Data.Location = new System.Drawing.Point(226, 43);
            this.tbox_Data.Name = "tbox_Data";
            this.tbox_Data.Size = new System.Drawing.Size(120, 25);
            this.tbox_Data.TabIndex = 115;
            // 
            // tbox_Valor
            // 
            this.tbox_Valor.Location = new System.Drawing.Point(352, 43);
            this.tbox_Valor.Name = "tbox_Valor";
            this.tbox_Valor.Size = new System.Drawing.Size(97, 25);
            this.tbox_Valor.TabIndex = 114;
            this.tbox_Valor.Text = "0,00";
            this.tbox_Valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbox_Valor.Leave += new System.EventHandler(this.tbox_Valor_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(348, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 19);
            this.label8.TabIndex = 113;
            this.label8.Text = "Valor R$";
            // 
            // tbox_NumIndent
            // 
            this.tbox_NumIndent.Location = new System.Drawing.Point(118, 43);
            this.tbox_NumIndent.Name = "tbox_NumIndent";
            this.tbox_NumIndent.Size = new System.Drawing.Size(102, 25);
            this.tbox_NumIndent.TabIndex = 110;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 19);
            this.label6.TabIndex = 109;
            this.label6.Text = "Nº Identificação";
            // 
            // tbox_NumDoc
            // 
            this.tbox_NumDoc.Location = new System.Drawing.Point(15, 43);
            this.tbox_NumDoc.Name = "tbox_NumDoc";
            this.tbox_NumDoc.Size = new System.Drawing.Size(97, 25);
            this.tbox_NumDoc.TabIndex = 108;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 107;
            this.label3.Text = "Nº Documento";
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
            this.btn_Confirmar.Location = new System.Drawing.Point(836, 547);
            this.btn_Confirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(150, 39);
            this.btn_Confirmar.TabIndex = 115;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // frm_Transferir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Name = "frm_Transferir";
            this.Text = "TRANSFERIR NUMERAIS";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_PesquisarBanco;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tboxBancoConta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker tbox_Data;
        private System.Windows.Forms.TextBox tbox_Valor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbox_NumIndent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbox_NumDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PesquisarMoeda1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tboxMoeda1;
        public System.Windows.Forms.TextBox tboxBancoConta1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_PesquisarMoeda;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tboxMoeda;
        public System.Windows.Forms.Button btn_Confirmar;
    }
}