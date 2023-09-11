namespace CleverSoft.Conta_Gerencial
{
    partial class frmContaGerencialNovo
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
            this.btn_PesquisarGrupo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxGrupoContaGerencial = new System.Windows.Forms.TextBox();
            this.tboxID = new System.Windows.Forms.TextBox();
            this.tboxcategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panelCampos.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.panel3);
            this.panelCampos.Controls.Add(this.btn_PesquisarGrupo);
            this.panelCampos.Controls.Add(this.tboxGrupoContaGerencial);
            this.panelCampos.Controls.Add(this.label4);
            this.panelCampos.Controls.Add(this.label3);
            this.panelCampos.Controls.Add(this.label2);
            this.panelCampos.Controls.Add(this.tboxID);
            this.panelCampos.Controls.Add(this.tboxcategoria);
            // 
            // btn_PesquisarGrupo
            // 
            this.btn_PesquisarGrupo.BackColor = System.Drawing.SystemColors.Control;
            this.btn_PesquisarGrupo.FlatAppearance.BorderSize = 0;
            this.btn_PesquisarGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PesquisarGrupo.Image = global::CleverSoft.Properties.Resources.magnifier1;
            this.btn_PesquisarGrupo.Location = new System.Drawing.Point(513, 71);
            this.btn_PesquisarGrupo.Name = "btn_PesquisarGrupo";
            this.btn_PesquisarGrupo.Size = new System.Drawing.Size(37, 19);
            this.btn_PesquisarGrupo.TabIndex = 87;
            this.btn_PesquisarGrupo.TabStop = false;
            this.btn_PesquisarGrupo.UseVisualStyleBackColor = false;
            this.btn_PesquisarGrupo.Click += new System.EventHandler(this.btn_PesquisarGrupo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 15);
            this.label4.TabIndex = 86;
            this.label4.Text = "Grupo conta gerencial";
            // 
            // tboxGrupoContaGerencial
            // 
            this.tboxGrupoContaGerencial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxGrupoContaGerencial.Location = new System.Drawing.Point(9, 69);
            this.tboxGrupoContaGerencial.MaxLength = 45;
            this.tboxGrupoContaGerencial.Name = "tboxGrupoContaGerencial";
            this.tboxGrupoContaGerencial.ReadOnly = true;
            this.tboxGrupoContaGerencial.Size = new System.Drawing.Size(543, 23);
            this.tboxGrupoContaGerencial.TabIndex = 85;
            // 
            // tboxID
            // 
            this.tboxID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxID.Location = new System.Drawing.Point(9, 25);
            this.tboxID.Name = "tboxID";
            this.tboxID.ReadOnly = true;
            this.tboxID.Size = new System.Drawing.Size(102, 23);
            this.tboxID.TabIndex = 82;
            this.tboxID.TabStop = false;
            // 
            // tboxcategoria
            // 
            this.tboxcategoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tboxcategoria.Location = new System.Drawing.Point(9, 113);
            this.tboxcategoria.MaxLength = 45;
            this.tboxcategoria.Name = "tboxcategoria";
            this.tboxcategoria.Size = new System.Drawing.Size(543, 23);
            this.tboxcategoria.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 83;
            this.label2.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 84;
            this.label3.Text = "Conta Gerencial";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSalvar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 516);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(894, 35);
            this.panel3.TabIndex = 204;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSalvar.Location = new System.Drawing.Point(765, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(124, 29);
            this.btnSalvar.TabIndex = 195;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // frmContaGerencialNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Name = "frmContaGerencialNovo";
            this.Text = "Conta Gerencial";
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_PesquisarGrupo;
        public System.Windows.Forms.TextBox tboxGrupoContaGerencial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tboxID;
        public System.Windows.Forms.TextBox tboxcategoria;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSalvar;
    }
}