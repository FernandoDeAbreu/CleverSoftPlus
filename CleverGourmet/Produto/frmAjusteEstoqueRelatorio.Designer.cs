namespace CleverSoft.Produto
{
    partial class frmAjusteEstoqueRelatorio
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
            this.rbtnSaida = new System.Windows.Forms.RadioButton();
            this.rbtnEntrada = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxDtIni = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxDtFim = new System.Windows.Forms.DateTimePicker();
            this.btn_Incluir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.panel1.BackgroundImage = global::CleverSoft.Properties.Resources.degrade;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.rbtnSaida);
            this.panel1.Controls.Add(this.rbtnEntrada);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 48);
            this.panel1.TabIndex = 4;
            // 
            // rbtnSaida
            // 
            this.rbtnSaida.AutoSize = true;
            this.rbtnSaida.BackColor = System.Drawing.Color.Transparent;
            this.rbtnSaida.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSaida.ForeColor = System.Drawing.Color.White;
            this.rbtnSaida.Location = new System.Drawing.Point(12, 12);
            this.rbtnSaida.Name = "rbtnSaida";
            this.rbtnSaida.Size = new System.Drawing.Size(69, 23);
            this.rbtnSaida.TabIndex = 1;
            this.rbtnSaida.Text = "SAÍDA";
            this.rbtnSaida.UseVisualStyleBackColor = false;
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(191, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 23);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "TODOS";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data Mov.";
            // 
            // tboxDtIni
            // 
            this.tboxDtIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tboxDtIni.Location = new System.Drawing.Point(11, 71);
            this.tboxDtIni.Name = "tboxDtIni";
            this.tboxDtIni.Size = new System.Drawing.Size(117, 23);
            this.tboxDtIni.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "à";
            // 
            // tboxDtFim
            // 
            this.tboxDtFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tboxDtFim.Location = new System.Drawing.Point(148, 71);
            this.tboxDtFim.Name = "tboxDtFim";
            this.tboxDtFim.Size = new System.Drawing.Size(117, 23);
            this.tboxDtFim.TabIndex = 8;
            // 
            // btn_Incluir
            // 
            this.btn_Incluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Incluir.Location = new System.Drawing.Point(480, 210);
            this.btn_Incluir.Name = "btn_Incluir";
            this.btn_Incluir.Size = new System.Drawing.Size(109, 30);
            this.btn_Incluir.TabIndex = 197;
            this.btn_Incluir.Text = "Imprimir";
            this.btn_Incluir.UseVisualStyleBackColor = true;
            this.btn_Incluir.Click += new System.EventHandler(this.btn_Incluir_Click);
            // 
            // frmAjusteEstoqueRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 252);
            this.Controls.Add(this.btn_Incluir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxDtFim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxDtIni);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAjusteEstoqueRelatorio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentação";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rbtnSaida;
        private System.Windows.Forms.RadioButton rbtnEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tboxDtIni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker tboxDtFim;
        private System.Windows.Forms.Button btn_Incluir;
    }
}