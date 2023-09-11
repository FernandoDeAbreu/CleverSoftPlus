namespace CleverSoft.Igreja.Membro
{
    partial class frmMembro
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Cliente = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox_pesquisar = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.btnImprimirFicha = new System.Windows.Forms.Button();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZAOSOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FANTASIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTNASC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BATAGUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BATESPIRITO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIZIMISTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALUNOEBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CELULAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDERECO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAIRRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UFRG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOPESSOA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORGAORG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMEMAE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMEPAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATIVIDADE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AREAATUAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROFISSAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NATURAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTCAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATCAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODFILIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTEDESDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOTDESL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRFOTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNPJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTDESL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.dgv_Cliente);
            this.panelCampos.Controls.Add(this.panel1);
            this.panelCampos.Controls.Add(this.panel3);
            // 
            // dgv_Cliente
            // 
            this.dgv_Cliente.AllowUserToAddRows = false;
            this.dgv_Cliente.AllowUserToDeleteRows = false;
            this.dgv_Cliente.AllowUserToResizeRows = false;
            this.dgv_Cliente.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Cliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Cliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_Cliente.ColumnHeadersHeight = 30;
            this.dgv_Cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.RAZAOSOCIAL,
            this.FANTASIA,
            this.SEXO,
            this.DTNASC,
            this.BATAGUA,
            this.BATESPIRITO,
            this.DIZIMISTA,
            this.ALUNOEBD,
            this.CELULAR,
            this.TELEFONE,
            this.TELEFONE2,
            this.EMAIL,
            this.ENDERECO,
            this.BAIRRO,
            this.CIDADE,
            this.UF,
            this.PAIS,
            this.CEP,
            this.CPF,
            this.RG,
            this.UFRG,
            this.TIPOPESSOA,
            this.ORGAORG,
            this.IE,
            this.IM,
            this.NOMEMAE,
            this.NOMEPAI,
            this.ATIVIDADE,
            this.AREAATUAL,
            this.PROFISSAO,
            this.NATURAL,
            this.DTCAD,
            this.MATCAD,
            this.CODFILIAL,
            this.CLIENTEDESDE,
            this.MOTDESL,
            this.DIRFOTO,
            this.CNPJ,
            this.NUM,
            this.DTDESL});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Cliente.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_Cliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Cliente.EnableHeadersVisualStyles = false;
            this.dgv_Cliente.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_Cliente.Location = new System.Drawing.Point(0, 71);
            this.dgv_Cliente.MultiSelect = false;
            this.dgv_Cliente.Name = "dgv_Cliente";
            this.dgv_Cliente.ReadOnly = true;
            this.dgv_Cliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Cliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Cliente.Size = new System.Drawing.Size(894, 445);
            this.dgv_Cliente.TabIndex = 201;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbox_pesquisar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 71);
            this.panel1.TabIndex = 202;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPesquisar.Location = new System.Drawing.Point(761, 21);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(124, 29);
            this.btnPesquisar.TabIndex = 192;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 51;
            this.label6.Text = "Nome";
            // 
            // tbox_pesquisar
            // 
            this.tbox_pesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbox_pesquisar.Location = new System.Drawing.Point(9, 27);
            this.tbox_pesquisar.MaxLength = 45;
            this.tbox_pesquisar.Name = "tbox_pesquisar";
            this.tbox_pesquisar.Size = new System.Drawing.Size(504, 23);
            this.tbox_pesquisar.TabIndex = 50;
            this.tbox_pesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_pesquisar_KeyDown);
            this.tbox_pesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbox_pesquisar_KeyUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEditar);
            this.panel3.Controls.Add(this.btnExcluir);
            this.panel3.Controls.Add(this.btnNovo);
            this.panel3.Controls.Add(this.btn_Imprimir);
            this.panel3.Controls.Add(this.btnImprimirFicha);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 516);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(894, 35);
            this.panel3.TabIndex = 203;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEditar.Location = new System.Drawing.Point(636, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(124, 29);
            this.btnEditar.TabIndex = 199;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExcluir.Location = new System.Drawing.Point(4, 2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(124, 29);
            this.btnExcluir.TabIndex = 198;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNovo.Location = new System.Drawing.Point(765, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(124, 29);
            this.btnNovo.TabIndex = 195;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Imprimir.Location = new System.Drawing.Point(507, 3);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(124, 29);
            this.btn_Imprimir.TabIndex = 196;
            this.btn_Imprimir.Text = "Relatório simples";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            // 
            // btnImprimirFicha
            // 
            this.btnImprimirFicha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimirFicha.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnImprimirFicha.Location = new System.Drawing.Point(378, 3);
            this.btnImprimirFicha.Name = "btnImprimirFicha";
            this.btnImprimirFicha.Size = new System.Drawing.Size(124, 29);
            this.btnImprimirFicha.TabIndex = 197;
            this.btnImprimirFicha.Text = "Relatório detalhado";
            this.btnImprimirFicha.UseVisualStyleBackColor = true;
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CÓDIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // RAZAOSOCIAL
            // 
            this.RAZAOSOCIAL.HeaderText = "NOME COMPLETO";
            this.RAZAOSOCIAL.Name = "RAZAOSOCIAL";
            this.RAZAOSOCIAL.ReadOnly = true;
            this.RAZAOSOCIAL.Width = 350;
            // 
            // FANTASIA
            // 
            this.FANTASIA.HeaderText = "CONHECIDO COMO";
            this.FANTASIA.Name = "FANTASIA";
            this.FANTASIA.ReadOnly = true;
            this.FANTASIA.Width = 200;
            // 
            // SEXO
            // 
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.Name = "SEXO";
            this.SEXO.ReadOnly = true;
            // 
            // DTNASC
            // 
            this.DTNASC.HeaderText = "DATA NASC.";
            this.DTNASC.Name = "DTNASC";
            this.DTNASC.ReadOnly = true;
            // 
            // BATAGUA
            // 
            this.BATAGUA.HeaderText = "Batizado Aguas";
            this.BATAGUA.Name = "BATAGUA";
            this.BATAGUA.ReadOnly = true;
            // 
            // BATESPIRITO
            // 
            this.BATESPIRITO.HeaderText = "Batizado Espirito";
            this.BATESPIRITO.Name = "BATESPIRITO";
            this.BATESPIRITO.ReadOnly = true;
            // 
            // DIZIMISTA
            // 
            this.DIZIMISTA.HeaderText = "Dizimista";
            this.DIZIMISTA.Name = "DIZIMISTA";
            this.DIZIMISTA.ReadOnly = true;
            // 
            // ALUNOEBD
            // 
            this.ALUNOEBD.HeaderText = "Aluno EBD";
            this.ALUNOEBD.Name = "ALUNOEBD";
            this.ALUNOEBD.ReadOnly = true;
            // 
            // CELULAR
            // 
            this.CELULAR.HeaderText = "Celular";
            this.CELULAR.Name = "CELULAR";
            this.CELULAR.ReadOnly = true;
            this.CELULAR.Width = 120;
            // 
            // TELEFONE
            // 
            this.TELEFONE.HeaderText = "Telefone";
            this.TELEFONE.Name = "TELEFONE";
            this.TELEFONE.ReadOnly = true;
            this.TELEFONE.Width = 120;
            // 
            // TELEFONE2
            // 
            this.TELEFONE2.HeaderText = "Telefone 2";
            this.TELEFONE2.Name = "TELEFONE2";
            this.TELEFONE2.ReadOnly = true;
            this.TELEFONE2.Width = 120;
            // 
            // EMAIL
            // 
            this.EMAIL.HeaderText = "E-mail";
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.ReadOnly = true;
            this.EMAIL.Width = 200;
            // 
            // ENDERECO
            // 
            this.ENDERECO.HeaderText = "Endereço";
            this.ENDERECO.Name = "ENDERECO";
            this.ENDERECO.ReadOnly = true;
            this.ENDERECO.Width = 350;
            // 
            // BAIRRO
            // 
            this.BAIRRO.HeaderText = "Bairro";
            this.BAIRRO.Name = "BAIRRO";
            this.BAIRRO.ReadOnly = true;
            this.BAIRRO.Width = 200;
            // 
            // CIDADE
            // 
            this.CIDADE.HeaderText = "Cidade";
            this.CIDADE.Name = "CIDADE";
            this.CIDADE.ReadOnly = true;
            this.CIDADE.Width = 200;
            // 
            // UF
            // 
            this.UF.HeaderText = "UF";
            this.UF.Name = "UF";
            this.UF.ReadOnly = true;
            // 
            // PAIS
            // 
            this.PAIS.HeaderText = "Pais";
            this.PAIS.Name = "PAIS";
            this.PAIS.ReadOnly = true;
            // 
            // CEP
            // 
            this.CEP.HeaderText = "CEP";
            this.CEP.Name = "CEP";
            this.CEP.ReadOnly = true;
            this.CEP.Width = 120;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF / CNPJ";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Width = 150;
            // 
            // RG
            // 
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            this.RG.ReadOnly = true;
            this.RG.Width = 150;
            // 
            // UFRG
            // 
            this.UFRG.HeaderText = "UF RG";
            this.UFRG.Name = "UFRG";
            this.UFRG.ReadOnly = true;
            // 
            // TIPOPESSOA
            // 
            this.TIPOPESSOA.HeaderText = "Tipo de pessoa";
            this.TIPOPESSOA.Name = "TIPOPESSOA";
            this.TIPOPESSOA.ReadOnly = true;
            this.TIPOPESSOA.Width = 120;
            // 
            // ORGAORG
            // 
            this.ORGAORG.HeaderText = "Orgão Emissor";
            this.ORGAORG.Name = "ORGAORG";
            this.ORGAORG.ReadOnly = true;
            this.ORGAORG.Width = 120;
            // 
            // IE
            // 
            this.IE.HeaderText = "Insc. Estadual";
            this.IE.Name = "IE";
            this.IE.ReadOnly = true;
            this.IE.Width = 120;
            // 
            // IM
            // 
            this.IM.HeaderText = "Insc. Mun.";
            this.IM.Name = "IM";
            this.IM.ReadOnly = true;
            this.IM.Width = 120;
            // 
            // NOMEMAE
            // 
            this.NOMEMAE.HeaderText = "Nome da Mãe";
            this.NOMEMAE.Name = "NOMEMAE";
            this.NOMEMAE.ReadOnly = true;
            this.NOMEMAE.Width = 350;
            // 
            // NOMEPAI
            // 
            this.NOMEPAI.HeaderText = "Nome do Pai";
            this.NOMEPAI.Name = "NOMEPAI";
            this.NOMEPAI.ReadOnly = true;
            this.NOMEPAI.Width = 350;
            // 
            // ATIVIDADE
            // 
            this.ATIVIDADE.HeaderText = "Atividade";
            this.ATIVIDADE.Name = "ATIVIDADE";
            this.ATIVIDADE.ReadOnly = true;
            this.ATIVIDADE.Width = 120;
            // 
            // AREAATUAL
            // 
            this.AREAATUAL.HeaderText = "Àrea de atuação";
            this.AREAATUAL.Name = "AREAATUAL";
            this.AREAATUAL.ReadOnly = true;
            this.AREAATUAL.Width = 150;
            // 
            // PROFISSAO
            // 
            this.PROFISSAO.HeaderText = "Profisssão";
            this.PROFISSAO.Name = "PROFISSAO";
            this.PROFISSAO.ReadOnly = true;
            this.PROFISSAO.Width = 120;
            // 
            // NATURAL
            // 
            this.NATURAL.HeaderText = "Naturalidade";
            this.NATURAL.Name = "NATURAL";
            this.NATURAL.ReadOnly = true;
            // 
            // DTCAD
            // 
            this.DTCAD.HeaderText = "Data Cadastro";
            this.DTCAD.Name = "DTCAD";
            this.DTCAD.ReadOnly = true;
            this.DTCAD.Visible = false;
            // 
            // MATCAD
            // 
            this.MATCAD.HeaderText = "MATCAD";
            this.MATCAD.Name = "MATCAD";
            this.MATCAD.ReadOnly = true;
            this.MATCAD.Visible = false;
            // 
            // CODFILIAL
            // 
            this.CODFILIAL.HeaderText = "Column1";
            this.CODFILIAL.Name = "CODFILIAL";
            this.CODFILIAL.ReadOnly = true;
            this.CODFILIAL.Visible = false;
            // 
            // CLIENTEDESDE
            // 
            this.CLIENTEDESDE.HeaderText = "Column1";
            this.CLIENTEDESDE.Name = "CLIENTEDESDE";
            this.CLIENTEDESDE.ReadOnly = true;
            this.CLIENTEDESDE.Visible = false;
            // 
            // MOTDESL
            // 
            this.MOTDESL.HeaderText = "Motivo desligamento";
            this.MOTDESL.Name = "MOTDESL";
            this.MOTDESL.ReadOnly = true;
            // 
            // DIRFOTO
            // 
            this.DIRFOTO.HeaderText = "DIRFOTO";
            this.DIRFOTO.Name = "DIRFOTO";
            this.DIRFOTO.ReadOnly = true;
            this.DIRFOTO.Visible = false;
            // 
            // CNPJ
            // 
            this.CNPJ.HeaderText = "CNPJ";
            this.CNPJ.Name = "CNPJ";
            this.CNPJ.ReadOnly = true;
            this.CNPJ.Visible = false;
            // 
            // NUM
            // 
            this.NUM.HeaderText = "NUM";
            this.NUM.Name = "NUM";
            this.NUM.ReadOnly = true;
            this.NUM.Visible = false;
            // 
            // DTDESL
            // 
            this.DTDESL.HeaderText = "DTDESL";
            this.DTDESL.Name = "DTDESL";
            this.DTDESL.ReadOnly = true;
            this.DTDESL.Visible = false;
            // 
            // frmMembro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Name = "frmMembro";
            this.Text = "MEMBROS CADASTRADOS";
            this.Load += new System.EventHandler(this.frmMembro_Load);
            this.panelCampos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cliente)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dgv_Cliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbox_pesquisar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.Button btnImprimirFicha;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZAOSOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn FANTASIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTNASC;
        private System.Windows.Forms.DataGridViewTextBoxColumn BATAGUA;
        private System.Windows.Forms.DataGridViewTextBoxColumn BATESPIRITO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIZIMISTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALUNOEBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CELULAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDERECO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAIRRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UF;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn UFRG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOPESSOA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORGAORG;
        private System.Windows.Forms.DataGridViewTextBoxColumn IE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IM;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMEMAE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMEPAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATIVIDADE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AREAATUAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROFISSAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NATURAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTCAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATCAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODFILIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTEDESDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOTDESL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRFOTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNPJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTDESL;
    }
}