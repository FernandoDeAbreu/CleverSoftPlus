namespace CleverSoft
{
    partial class frm_Mesa
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
            this.label5 = new System.Windows.Forms.Label();
            this.tboxQtdLugares = new System.Windows.Forms.TextBox();
            this.tboxID = new System.Windows.Forms.TextBox();
            this.tboxMesa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxMesaP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tboxQtdLugares);
            this.tabPage1.Controls.Add(this.tboxID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tboxMesa);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.SetChildIndex(this.label2, 0);
            this.tabPage1.Controls.SetChildIndex(this.tboxMesa, 0);
            this.tabPage1.Controls.SetChildIndex(this.label1, 0);
            this.tabPage1.Controls.SetChildIndex(this.tboxID, 0);
            this.tabPage1.Controls.SetChildIndex(this.tboxQtdLugares, 0);
            this.tabPage1.Controls.SetChildIndex(this.label5, 0);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.tboxStatus);
            this.tabPage2.Controls.Add(this.tboxMesaP);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.SetChildIndex(this.label6, 0);
            this.tabPage2.Controls.SetChildIndex(this.tboxMesaP, 0);
            this.tabPage2.Controls.SetChildIndex(this.tboxStatus, 0);
            this.tabPage2.Controls.SetChildIndex(this.label4, 0);
            // 
            // lbl_NomeRotina
            // 
            this.lbl_NomeRotina.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbl_NomeRotina.Size = new System.Drawing.Size(84, 40);
            this.lbl_NomeRotina.Text = "Form1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "Qtde. Lugares";
            // 
            // tboxQtdLugares
            // 
            this.tboxQtdLugares.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxQtdLugares.Location = new System.Drawing.Point(520, 98);
            this.tboxQtdLugares.MaxLength = 45;
            this.tboxQtdLugares.Name = "tboxQtdLugares";
            this.tboxQtdLugares.Size = new System.Drawing.Size(91, 27);
            this.tboxQtdLugares.TabIndex = 44;
            // 
            // tboxID
            // 
            this.tboxID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxID.Location = new System.Drawing.Point(11, 41);
            this.tboxID.Name = "tboxID";
            this.tboxID.ReadOnly = true;
            this.tboxID.Size = new System.Drawing.Size(161, 27);
            this.tboxID.TabIndex = 36;
            this.tboxID.TabStop = false;
            // 
            // tboxMesa
            // 
            this.tboxMesa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxMesa.Location = new System.Drawing.Point(11, 98);
            this.tboxMesa.MaxLength = 45;
            this.tboxMesa.Name = "tboxMesa";
            this.tboxMesa.Size = new System.Drawing.Size(504, 27);
            this.tboxMesa.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Mesa **";
            // 
            // tboxMesaP
            // 
            this.tboxMesaP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxMesaP.Location = new System.Drawing.Point(9, 33);
            this.tboxMesaP.MaxLength = 45;
            this.tboxMesaP.Name = "tboxMesaP";
            this.tboxMesaP.Size = new System.Drawing.Size(504, 27);
            this.tboxMesaP.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Mesa";
            // 
            // tboxStatus
            // 
            this.tboxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tboxStatus.FormattingEnabled = true;
            this.tboxStatus.Items.AddRange(new object[] {
            "SIM",
            "NÃO"});
            this.tboxStatus.Location = new System.Drawing.Point(8, 90);
            this.tboxStatus.Name = "tboxStatus";
            this.tboxStatus.Size = new System.Drawing.Size(144, 28);
            this.tboxStatus.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Livre";
            // 
            // frm_Mesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Name = "frm_Mesa";
            this.Text = "CADASTRO DE MESAS";
            this.Load += new System.EventHandler(this.frm_Mesa_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox tboxID;
        public System.Windows.Forms.TextBox tboxMesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tboxMesaP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox tboxStatus;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tboxQtdLugares;
    }
}