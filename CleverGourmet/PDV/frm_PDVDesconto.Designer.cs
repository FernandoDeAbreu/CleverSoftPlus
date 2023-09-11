namespace CleverSoft
{
    partial class frm_PDVDesconto
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_DescontoReal = new System.Windows.Forms.TextBox();
            this.tbox_DescontoPorcento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(115)))), ((int)(((byte)(169)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbox_DescontoReal);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbox_DescontoPorcento);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(481, 231);
            this.panel1.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(0, -8);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(252, 46);
            this.label1.TabIndex = 44;
            this.label1.Text = "Desconto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbox_DescontoReal
            // 
            this.tbox_DescontoReal.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.tbox_DescontoReal.Location = new System.Drawing.Point(151, 50);
            this.tbox_DescontoReal.Name = "tbox_DescontoReal";
            this.tbox_DescontoReal.Size = new System.Drawing.Size(235, 57);
            this.tbox_DescontoReal.TabIndex = 45;
            this.tbox_DescontoReal.Text = "0,00";
            this.tbox_DescontoReal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_DescontoReal.TextChanged += new System.EventHandler(this.tbox_DescontoReal_TextChanged);
            this.tbox_DescontoReal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_DescontoReal_KeyDown);
            this.tbox_DescontoReal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbox_DescontoReal_KeyUp);
            this.tbox_DescontoReal.Leave += new System.EventHandler(this.tbox_DescontoReal_Leave);
            // 
            // tbox_DescontoPorcento
            // 
            this.tbox_DescontoPorcento.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.tbox_DescontoPorcento.Location = new System.Drawing.Point(151, 129);
            this.tbox_DescontoPorcento.Name = "tbox_DescontoPorcento";
            this.tbox_DescontoPorcento.Size = new System.Drawing.Size(235, 57);
            this.tbox_DescontoPorcento.TabIndex = 46;
            this.tbox_DescontoPorcento.Text = "0,00";
            this.tbox_DescontoPorcento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_DescontoPorcento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_DescontoPorcento_KeyDown);
            this.tbox_DescontoPorcento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbox_DescontoPorcento_KeyUp);
            this.tbox_DescontoPorcento.Leave += new System.EventHandler(this.tbox_DescontoPorcento_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoEllipsis = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(79, 58);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(65, 46);
            this.label2.TabIndex = 47;
            this.label2.Text = "R$";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoEllipsis = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 129);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(53, 46);
            this.label3.TabIndex = 48;
            this.label3.Text = "%";
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
            this.label4.Location = new System.Drawing.Point(-6, 199);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(499, 46);
            this.label4.TabIndex = 49;
            this.label4.Text = "(Esc) - Sair  |  (Tab) - Alternar tipo desconto  | (Enter) - Confirmar";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm_PDVDesconto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 231);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_PDVDesconto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PDVDesconto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbox_DescontoPorcento;
        private System.Windows.Forms.TextBox tbox_DescontoReal;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label4;
    }
}