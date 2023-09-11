namespace CleverSoft
{
    partial class frm_Suporte
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
            this.tboxSenha = new System.Windows.Forms.TextBox();
            this.dgv_resultado_pesquisa = new System.Windows.Forms.DataGridView();
            this.tboxSQL = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_Anydesk = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado_pesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_NomeRotina
            // 
            this.lbl_NomeRotina.Size = new System.Drawing.Size(161, 29);
            this.lbl_NomeRotina.Text = "ModeloSimples";
            // 
            // iconcerrar
            // 
            this.iconcerrar.Location = new System.Drawing.Point(877, 6);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.btn_Anydesk);
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.tboxSenha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Size = new System.Drawing.Size(900, 600);
            this.panel1.Controls.SetChildIndex(this.tboxSenha, 0);
            this.panel1.Controls.SetChildIndex(this.splitContainer1, 0);
            this.panel1.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.Controls.SetChildIndex(this.btn_Anydesk, 0);
            // 
            // tboxSenha
            // 
            this.tboxSenha.Location = new System.Drawing.Point(5, 50);
            this.tboxSenha.Name = "tboxSenha";
            this.tboxSenha.Size = new System.Drawing.Size(203, 23);
            this.tboxSenha.TabIndex = 13;
            this.tboxSenha.UseSystemPasswordChar = true;
            this.tboxSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxSenha_KeyDown);
            // 
            // dgv_resultado_pesquisa
            // 
            this.dgv_resultado_pesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resultado_pesquisa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_resultado_pesquisa.Location = new System.Drawing.Point(3, 3);
            this.dgv_resultado_pesquisa.Name = "dgv_resultado_pesquisa";
            this.dgv_resultado_pesquisa.Size = new System.Drawing.Size(882, 313);
            this.dgv_resultado_pesquisa.TabIndex = 14;
            // 
            // tboxSQL
            // 
            this.tboxSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tboxSQL.Location = new System.Drawing.Point(0, 0);
            this.tboxSQL.Name = "tboxSQL";
            this.tboxSQL.Size = new System.Drawing.Size(892, 164);
            this.tboxSQL.TabIndex = 15;
            this.tboxSQL.Text = "";
            this.tboxSQL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tboxSQL_KeyDown);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 101);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tboxSQL);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(892, 494);
            this.splitContainer1.SplitterDistance = 164;
            this.splitContainer1.TabIndex = 16;
            this.splitContainer1.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, -22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgv_resultado_pesquisa);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(888, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(888, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(882, 313);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // btn_Anydesk
            // 
            this.btn_Anydesk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Anydesk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Anydesk.BackgroundImage = global::CleverSoft.Properties.Resources.anny;
            this.btn_Anydesk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Anydesk.FlatAppearance.BorderSize = 0;
            this.btn_Anydesk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Anydesk.Location = new System.Drawing.Point(848, 50);
            this.btn_Anydesk.Name = "btn_Anydesk";
            this.btn_Anydesk.Size = new System.Drawing.Size(44, 44);
            this.btn_Anydesk.TabIndex = 17;
            this.btn_Anydesk.UseVisualStyleBackColor = false;
            this.btn_Anydesk.Click += new System.EventHandler(this.btn_Anydesk_Click);
            // 
            // frm_Suporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Name = "frm_Suporte";
            this.Text = "SUPORTE";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultado_pesquisa)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tboxSenha;
        private System.Windows.Forms.RichTextBox tboxSQL;
        private System.Windows.Forms.DataGridView dgv_resultado_pesquisa;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_Anydesk;
    }
}