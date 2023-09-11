namespace CleverSoft
{
    partial class frm_Relatorio
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
            this.Rpv_Relatorios = new Microsoft.Reporting.WinForms.ReportViewer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bt_Sair = new System.Windows.Forms.Button();
            this.bt_Email = new System.Windows.Forms.Button();
            this.bt_Exporta_XLS = new System.Windows.Forms.Button();
            this.bt_Exporta_DOC = new System.Windows.Forms.Button();
            this.bt_Exporta_PDF = new System.Windows.Forms.Button();
            this.bt_Imprimir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rpv_Relatorios
            // 
            this.Rpv_Relatorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rpv_Relatorios.Location = new System.Drawing.Point(0, 0);
            this.Rpv_Relatorios.Name = "Rpv_Relatorios";
            this.Rpv_Relatorios.ServerReport.BearerToken = null;
            this.Rpv_Relatorios.Size = new System.Drawing.Size(933, 548);
            this.Rpv_Relatorios.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bt_Sair);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.bt_Email);
            this.flowLayoutPanel1.Controls.Add(this.bt_Exporta_XLS);
            this.flowLayoutPanel1.Controls.Add(this.bt_Exporta_DOC);
            this.flowLayoutPanel1.Controls.Add(this.bt_Exporta_PDF);
            this.flowLayoutPanel1.Controls.Add(this.bt_Imprimir);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 548);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(933, 40);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // bt_Sair
            // 
            this.bt_Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Sair.BackColor = System.Drawing.Color.White;
            this.bt_Sair.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sair.Image = global::CleverSoft.Properties.Resources.bt_Sair;
            this.bt_Sair.Location = new System.Drawing.Point(804, 3);
            this.bt_Sair.Name = "bt_Sair";
            this.bt_Sair.Size = new System.Drawing.Size(126, 32);
            this.bt_Sair.TabIndex = 13;
            this.bt_Sair.Text = "FECHAR (ESC)";
            this.bt_Sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Sair.UseVisualStyleBackColor = false;
            this.bt_Sair.Click += new System.EventHandler(this.bt_Sair_Click);
            // 
            // bt_Email
            // 
            this.bt_Email.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Email.BackColor = System.Drawing.Color.White;
            this.bt_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Email.Image = global::CleverSoft.Properties.Resources.bt_email;
            this.bt_Email.Location = new System.Drawing.Point(536, 3);
            this.bt_Email.Name = "bt_Email";
            this.bt_Email.Size = new System.Drawing.Size(126, 32);
            this.bt_Email.TabIndex = 12;
            this.bt_Email.Text = "ENVIAR EMAIL";
            this.bt_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Email.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Email.UseVisualStyleBackColor = false;
            this.bt_Email.Visible = false;
            // 
            // bt_Exporta_XLS
            // 
            this.bt_Exporta_XLS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Exporta_XLS.BackColor = System.Drawing.Color.White;
            this.bt_Exporta_XLS.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exporta_XLS.Image = global::CleverSoft.Properties.Resources.bt_Excel;
            this.bt_Exporta_XLS.Location = new System.Drawing.Point(404, 3);
            this.bt_Exporta_XLS.Name = "bt_Exporta_XLS";
            this.bt_Exporta_XLS.Size = new System.Drawing.Size(126, 32);
            this.bt_Exporta_XLS.TabIndex = 11;
            this.bt_Exporta_XLS.Text = "GERAR EXCEL";
            this.bt_Exporta_XLS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Exporta_XLS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Exporta_XLS.UseVisualStyleBackColor = false;
            this.bt_Exporta_XLS.Click += new System.EventHandler(this.bt_Exporta_XLS_Click);
            // 
            // bt_Exporta_DOC
            // 
            this.bt_Exporta_DOC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Exporta_DOC.BackColor = System.Drawing.Color.White;
            this.bt_Exporta_DOC.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exporta_DOC.Image = global::CleverSoft.Properties.Resources.bt_Word;
            this.bt_Exporta_DOC.Location = new System.Drawing.Point(272, 3);
            this.bt_Exporta_DOC.Name = "bt_Exporta_DOC";
            this.bt_Exporta_DOC.Size = new System.Drawing.Size(126, 32);
            this.bt_Exporta_DOC.TabIndex = 10;
            this.bt_Exporta_DOC.Text = "GERAR WORD";
            this.bt_Exporta_DOC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Exporta_DOC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Exporta_DOC.UseVisualStyleBackColor = false;
            this.bt_Exporta_DOC.Click += new System.EventHandler(this.bt_Exporta_DOC_Click);
            // 
            // bt_Exporta_PDF
            // 
            this.bt_Exporta_PDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Exporta_PDF.BackColor = System.Drawing.Color.White;
            this.bt_Exporta_PDF.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Exporta_PDF.Image = global::CleverSoft.Properties.Resources.bt_pdf;
            this.bt_Exporta_PDF.Location = new System.Drawing.Point(140, 3);
            this.bt_Exporta_PDF.Name = "bt_Exporta_PDF";
            this.bt_Exporta_PDF.Size = new System.Drawing.Size(126, 32);
            this.bt_Exporta_PDF.TabIndex = 9;
            this.bt_Exporta_PDF.Text = "GERAR PDF";
            this.bt_Exporta_PDF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Exporta_PDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Exporta_PDF.UseVisualStyleBackColor = false;
            this.bt_Exporta_PDF.Click += new System.EventHandler(this.bt_Exporta_PDF_Click);
            // 
            // bt_Imprimir
            // 
            this.bt_Imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Imprimir.BackColor = System.Drawing.Color.White;
            this.bt_Imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Imprimir.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Imprimir.Image = global::CleverSoft.Properties.Resources.printer1;
            this.bt_Imprimir.Location = new System.Drawing.Point(8, 3);
            this.bt_Imprimir.Name = "bt_Imprimir";
            this.bt_Imprimir.Size = new System.Drawing.Size(126, 32);
            this.bt_Imprimir.TabIndex = 8;
            this.bt_Imprimir.Text = "IMPRIMIR";
            this.bt_Imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_Imprimir.UseVisualStyleBackColor = false;
            this.bt_Imprimir.Click += new System.EventHandler(this.bt_Imprimir_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(668, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 28);
            this.panel1.TabIndex = 2;
            // 
            // frm_Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 588);
            this.Controls.Add(this.Rpv_Relatorios);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Relatorio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatórios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Relatorio_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Rpv_Relatorios;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bt_Sair;
        private System.Windows.Forms.Button bt_Email;
        private System.Windows.Forms.Button bt_Exporta_XLS;
        private System.Windows.Forms.Button bt_Exporta_DOC;
        private System.Windows.Forms.Button bt_Exporta_PDF;
        private System.Windows.Forms.Button bt_Imprimir;
        private System.Windows.Forms.Panel panel1;
    }
}