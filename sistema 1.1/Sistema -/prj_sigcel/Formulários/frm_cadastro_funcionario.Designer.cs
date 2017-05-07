namespace prj_sigcel
{
    partial class frm_cadastro_funcionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cadastro_funcionario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tblFuncionarios = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_cpf_funcionario = new System.Windows.Forms.MaskedTextBox();
            this.cbx_senha = new System.Windows.Forms.CheckBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_fim_contratacao = new System.Windows.Forms.MaskedTextBox();
            this.txt_dt_contratacao = new System.Windows.Forms.MaskedTextBox();
            this.cbx_funcionario_tercerizado = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_email_funcionario = new System.Windows.Forms.TextBox();
            this.lb_dtFinal = new System.Windows.Forms.Label();
            this.lb_dtComeco = new System.Windows.Forms.Label();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_complemento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_rua_funcionario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_cidade_funcionario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_numero_funcionario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_bairro_funcionario = new System.Windows.Forms.TextBox();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nome_funcionario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFuncionarios)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 37);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Funcionário";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(876, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-2, 72);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(906, 497);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnBuscar);
            this.tabPage1.Controls.Add(this.btnExcluir);
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.txtBuscar);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Controls.Add(this.tblFuncionarios);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(898, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.Location = new System.Drawing.Point(356, 54);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 28);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcluir.BackgroundImage")));
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Location = new System.Drawing.Point(121, 6);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(107, 42);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Location = new System.Drawing.Point(10, 6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(105, 42);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(38, 54);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(312, 27);
            this.txtBuscar.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(7, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // tblFuncionarios
            // 
            this.tblFuncionarios.AllowUserToAddRows = false;
            this.tblFuncionarios.AllowUserToDeleteRows = false;
            this.tblFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblFuncionarios.Location = new System.Drawing.Point(6, 88);
            this.tblFuncionarios.Name = "tblFuncionarios";
            this.tblFuncionarios.ReadOnly = true;
            this.tblFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblFuncionarios.Size = new System.Drawing.Size(886, 357);
            this.tblFuncionarios.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txt_cpf_funcionario);
            this.tabPage2.Controls.Add(this.cbx_senha);
            this.tabPage2.Controls.Add(this.txt_senha);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txt_fim_contratacao);
            this.tabPage2.Controls.Add(this.txt_dt_contratacao);
            this.tabPage2.Controls.Add(this.cbx_funcionario_tercerizado);
            this.tabPage2.Controls.Add(this.btnCadastrar);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txt_email_funcionario);
            this.tabPage2.Controls.Add(this.lb_dtFinal);
            this.tabPage2.Controls.Add(this.lb_dtComeco);
            this.tabPage2.Controls.Add(this.txt_telefone);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txt_complemento);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txt_rua_funcionario);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txt_cidade_funcionario);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txt_numero_funcionario);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txt_bairro_funcionario);
            this.tabPage2.Controls.Add(this.cb_tipo);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txt_nome_funcionario);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(898, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_cpf_funcionario
            // 
            this.txt_cpf_funcionario.Location = new System.Drawing.Point(238, 36);
            this.txt_cpf_funcionario.Mask = "000,000,000-00";
            this.txt_cpf_funcionario.Name = "txt_cpf_funcionario";
            this.txt_cpf_funcionario.Size = new System.Drawing.Size(140, 27);
            this.txt_cpf_funcionario.TabIndex = 34;
            // 
            // cbx_senha
            // 
            this.cbx_senha.AutoSize = true;
            this.cbx_senha.Location = new System.Drawing.Point(478, 175);
            this.cbx_senha.Name = "cbx_senha";
            this.cbx_senha.Size = new System.Drawing.Size(181, 22);
            this.cbx_senha.TabIndex = 33;
            this.cbx_senha.Text = "Acesso ao sistema";
            this.cbx_senha.UseVisualStyleBackColor = true;
            this.cbx_senha.CheckedChanged += new System.EventHandler(this.cbx_senha_CheckedChanged);
            // 
            // txt_senha
            // 
            this.txt_senha.Enabled = false;
            this.txt_senha.Location = new System.Drawing.Point(665, 173);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(116, 27);
            this.txt_senha.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(662, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 18);
            this.label11.TabIndex = 31;
            this.label11.Text = "Senha";
            // 
            // txt_fim_contratacao
            // 
            this.txt_fim_contratacao.Enabled = false;
            this.txt_fim_contratacao.Location = new System.Drawing.Point(234, 334);
            this.txt_fim_contratacao.Mask = "00/00/0000";
            this.txt_fim_contratacao.Name = "txt_fim_contratacao";
            this.txt_fim_contratacao.Size = new System.Drawing.Size(101, 27);
            this.txt_fim_contratacao.TabIndex = 30;
            this.txt_fim_contratacao.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txt_dt_contratacao
            // 
            this.txt_dt_contratacao.Enabled = false;
            this.txt_dt_contratacao.Location = new System.Drawing.Point(13, 334);
            this.txt_dt_contratacao.Mask = "00/00/0000";
            this.txt_dt_contratacao.Name = "txt_dt_contratacao";
            this.txt_dt_contratacao.Size = new System.Drawing.Size(102, 27);
            this.txt_dt_contratacao.TabIndex = 29;
            this.txt_dt_contratacao.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cbx_funcionario_tercerizado
            // 
            this.cbx_funcionario_tercerizado.AutoSize = true;
            this.cbx_funcionario_tercerizado.Location = new System.Drawing.Point(211, 257);
            this.cbx_funcionario_tercerizado.Name = "cbx_funcionario_tercerizado";
            this.cbx_funcionario_tercerizado.Size = new System.Drawing.Size(229, 22);
            this.cbx_funcionario_tercerizado.TabIndex = 28;
            this.cbx_funcionario_tercerizado.Text = "Funcionário Terceirizado ";
            this.cbx_funcionario_tercerizado.UseVisualStyleBackColor = true;
            this.cbx_funcionario_tercerizado.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Location = new System.Drawing.Point(665, 307);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(116, 54);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Gravar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(382, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 18);
            this.label14.TabIndex = 26;
            this.label14.Text = "E-mail";
            // 
            // txt_email_funcionario
            // 
            this.txt_email_funcionario.Location = new System.Drawing.Point(384, 35);
            this.txt_email_funcionario.Name = "txt_email_funcionario";
            this.txt_email_funcionario.Size = new System.Drawing.Size(240, 27);
            this.txt_email_funcionario.TabIndex = 3;
            // 
            // lb_dtFinal
            // 
            this.lb_dtFinal.AutoSize = true;
            this.lb_dtFinal.Location = new System.Drawing.Point(231, 313);
            this.lb_dtFinal.Name = "lb_dtFinal";
            this.lb_dtFinal.Size = new System.Drawing.Size(185, 18);
            this.lb_dtFinal.TabIndex = 23;
            this.lb_dtFinal.Text = "Data do Fim Contrato";
            // 
            // lb_dtComeco
            // 
            this.lb_dtComeco.AutoSize = true;
            this.lb_dtComeco.Location = new System.Drawing.Point(10, 313);
            this.lb_dtComeco.Name = "lb_dtComeco";
            this.lb_dtComeco.Size = new System.Drawing.Size(178, 18);
            this.lb_dtComeco.TabIndex = 21;
            this.lb_dtComeco.Text = "Data da Contratação";
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(13, 255);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(151, 27);
            this.txt_telefone.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Telefone (Celular)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Complemento";
            // 
            // txt_complemento
            // 
            this.txt_complemento.Location = new System.Drawing.Point(13, 173);
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(80, 27);
            this.txt_complemento.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Rua";
            // 
            // txt_rua_funcionario
            // 
            this.txt_rua_funcionario.Location = new System.Drawing.Point(373, 116);
            this.txt_rua_funcionario.Name = "txt_rua_funcionario";
            this.txt_rua_funcionario.Size = new System.Drawing.Size(301, 27);
            this.txt_rua_funcionario.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cidade";
            // 
            // txt_cidade_funcionario
            // 
            this.txt_cidade_funcionario.Location = new System.Drawing.Point(13, 116);
            this.txt_cidade_funcionario.Name = "txt_cidade_funcionario";
            this.txt_cidade_funcionario.Size = new System.Drawing.Size(118, 27);
            this.txt_cidade_funcionario.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(677, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Número";
            // 
            // txt_numero_funcionario
            // 
            this.txt_numero_funcionario.Location = new System.Drawing.Point(680, 116);
            this.txt_numero_funcionario.Name = "txt_numero_funcionario";
            this.txt_numero_funcionario.Size = new System.Drawing.Size(80, 27);
            this.txt_numero_funcionario.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bairro";
            // 
            // txt_bairro_funcionario
            // 
            this.txt_bairro_funcionario.Location = new System.Drawing.Point(137, 116);
            this.txt_bairro_funcionario.Name = "txt_bairro_funcionario";
            this.txt_bairro_funcionario.Size = new System.Drawing.Size(230, 27);
            this.txt_bairro_funcionario.TabIndex = 6;
            // 
            // cb_tipo
            // 
            this.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Location = new System.Drawing.Point(630, 36);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(224, 26);
            this.cb_tipo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(627, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo (Área)";
            // 
            // txt_nome_funcionario
            // 
            this.txt_nome_funcionario.Location = new System.Drawing.Point(13, 36);
            this.txt_nome_funcionario.Name = "txt_nome_funcionario";
            this.txt_nome_funcionario.Size = new System.Drawing.Size(219, 27);
            this.txt_nome_funcionario.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome";
            // 
            // frm_cadastro_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(910, 574);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_cadastro_funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "\'";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFuncionarios)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txt_rua_funcionario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_cidade_funcionario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_numero_funcionario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_bairro_funcionario;
        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_nome_funcionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_email_funcionario;
        private System.Windows.Forms.Label lb_dtFinal;
        private System.Windows.Forms.Label lb_dtComeco;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_complemento;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DataGridView tblFuncionarios;
        private System.Windows.Forms.CheckBox cbx_funcionario_tercerizado;
        private System.Windows.Forms.MaskedTextBox txt_dt_contratacao;
        private System.Windows.Forms.MaskedTextBox txt_fim_contratacao;
        private System.Windows.Forms.CheckBox cbx_senha;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txt_cpf_funcionario;
    }
}