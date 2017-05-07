namespace prj_sigcel
{
    partial class frm_Pesquisas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Pesquisas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tblPesqFeitas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tblPesqMarc = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPesquisas = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbPerg = new System.Windows.Forms.ComboBox();
            this.txtAE = new System.Windows.Forms.TextBox();
            this.btnAddPerg = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPergunta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnChamaSelec = new System.Windows.Forms.Button();
            this.dtPesquisa = new System.Windows.Forms.DateTimePicker();
            this.btnSavePesq = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnm_bairro = new System.Windows.Forms.TextBox();
            this.txtnm_pesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPesqFeitas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPesqMarc)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 37);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(872, 3);
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
            this.tabControl1.Location = new System.Drawing.Point(0, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(938, 487);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnNovo);
            this.tabPage1.Controls.Add(this.btnExcluir);
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(930, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pesquisas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(475, 36);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(82, 30);
            this.btnNovo.TabIndex = 3;
            this.btnNovo.Text = "Nova";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(678, 36);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(82, 30);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(578, 36);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(82, 30);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tblPesqFeitas);
            this.groupBox2.Location = new System.Drawing.Point(467, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 346);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisas Feitas";
            // 
            // tblPesqFeitas
            // 
            this.tblPesqFeitas.AllowUserToAddRows = false;
            this.tblPesqFeitas.AllowUserToDeleteRows = false;
            this.tblPesqFeitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPesqFeitas.Location = new System.Drawing.Point(8, 35);
            this.tblPesqFeitas.MultiSelect = false;
            this.tblPesqFeitas.Name = "tblPesqFeitas";
            this.tblPesqFeitas.ReadOnly = true;
            this.tblPesqFeitas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblPesqFeitas.Size = new System.Drawing.Size(415, 300);
            this.tblPesqFeitas.TabIndex = 2;
            this.tblPesqFeitas.TabStop = false;
            this.tblPesqFeitas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblPesqFeitas_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.tblPesqMarc);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(8, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 395);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisas Marcadas";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(355, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(78, 47);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar Nome";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(37, 32);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(312, 27);
            this.txtBuscar.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Location = new System.Drawing.Point(6, 31);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // tblPesqMarc
            // 
            this.tblPesqMarc.AllowUserToAddRows = false;
            this.tblPesqMarc.AllowUserToDeleteRows = false;
            this.tblPesqMarc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPesqMarc.Location = new System.Drawing.Point(11, 84);
            this.tblPesqMarc.Name = "tblPesqMarc";
            this.tblPesqMarc.ReadOnly = true;
            this.tblPesqMarc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblPesqMarc.Size = new System.Drawing.Size(418, 300);
            this.tblPesqMarc.TabIndex = 1;
            this.tblPesqMarc.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Items.AddRange(new object[] {
            "Qualidade da Segurança - Gonzaga - 15/08",
            "Intenção de Voto - Embare - 20/08",
            "Qualidade da Segurança - Gonzaga - 25/08"});
            this.listBox1.Location = new System.Drawing.Point(6, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(0, 4);
            this.listBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.cmbPesquisas);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.btnChamaSelec);
            this.tabPage2.Controls.Add(this.dtPesquisa);
            this.tabPage2.Controls.Add(this.btnSavePesq);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtnm_bairro);
            this.tabPage2.Controls.Add(this.txtnm_pesquisa);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(930, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Marcar Pesquisa";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(534, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 58;
            this.label3.Text = "Data";
            // 
            // cmbPesquisas
            // 
            this.cmbPesquisas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPesquisas.FormattingEnabled = true;
            this.cmbPesquisas.Location = new System.Drawing.Point(15, 94);
            this.cmbPesquisas.Name = "cmbPesquisas";
            this.cmbPesquisas.Size = new System.Drawing.Size(263, 26);
            this.cmbPesquisas.TabIndex = 57;
            this.cmbPesquisas.TabStop = false;
            this.cmbPesquisas.SelectedIndexChanged += new System.EventHandler(this.cmbPesquisas_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(363, 18);
            this.label7.TabIndex = 56;
            this.label7.Text = "Referenciar perguntas de pesquisa anterior\r\n";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cmbPerg);
            this.panel2.Controls.Add(this.txtAE);
            this.panel2.Controls.Add(this.btnAddPerg);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtAD);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.txtAC);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtAB);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtAA);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtPergunta);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(15, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 279);
            this.panel2.TabIndex = 4;
            // 
            // cmbPerg
            // 
            this.cmbPerg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPerg.FormattingEnabled = true;
            this.cmbPerg.Location = new System.Drawing.Point(11, 7);
            this.cmbPerg.Name = "cmbPerg";
            this.cmbPerg.Size = new System.Drawing.Size(143, 26);
            this.cmbPerg.TabIndex = 59;
            this.cmbPerg.TabStop = false;
            this.cmbPerg.SelectedIndexChanged += new System.EventHandler(this.cmbPerg_SelectedIndexChanged);
            // 
            // txtAE
            // 
            this.txtAE.Location = new System.Drawing.Point(44, 237);
            this.txtAE.Name = "txtAE";
            this.txtAE.Size = new System.Drawing.Size(383, 27);
            this.txtAE.TabIndex = 10;
            this.txtAE.Tag = "4";
            this.txtAE.TextChanged += new System.EventHandler(this.txtAE_TextChanged);
            // 
            // btnAddPerg
            // 
            this.btnAddPerg.Location = new System.Drawing.Point(481, 204);
            this.btnAddPerg.Name = "btnAddPerg";
            this.btnAddPerg.Size = new System.Drawing.Size(116, 54);
            this.btnAddPerg.TabIndex = 11;
            this.btnAddPerg.Text = "Adicionar Pergunta";
            this.btnAddPerg.UseVisualStyleBackColor = true;
            this.btnAddPerg.Click += new System.EventHandler(this.btnAddPerg_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 18);
            this.label13.TabIndex = 53;
            this.label13.Text = "E)";
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(44, 204);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(383, 27);
            this.txtAD.TabIndex = 9;
            this.txtAD.Tag = "3";
            this.txtAD.TextChanged += new System.EventHandler(this.txtAD_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 18);
            this.label12.TabIndex = 51;
            this.label12.Text = "D)";
            // 
            // txtAC
            // 
            this.txtAC.Location = new System.Drawing.Point(44, 171);
            this.txtAC.Name = "txtAC";
            this.txtAC.Size = new System.Drawing.Size(383, 27);
            this.txtAC.TabIndex = 8;
            this.txtAC.Tag = "2";
            this.txtAC.TextChanged += new System.EventHandler(this.txtAC_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 180);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 18);
            this.label11.TabIndex = 49;
            this.label11.Text = "C)";
            // 
            // txtAB
            // 
            this.txtAB.Location = new System.Drawing.Point(44, 138);
            this.txtAB.Name = "txtAB";
            this.txtAB.Size = new System.Drawing.Size(383, 27);
            this.txtAB.TabIndex = 7;
            this.txtAB.Tag = "1";
            this.txtAB.TextChanged += new System.EventHandler(this.txtAB_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 18);
            this.label10.TabIndex = 47;
            this.label10.Text = "B)";
            // 
            // txtAA
            // 
            this.txtAA.Location = new System.Drawing.Point(44, 105);
            this.txtAA.Name = "txtAA";
            this.txtAA.Size = new System.Drawing.Size(383, 27);
            this.txtAA.TabIndex = 6;
            this.txtAA.Tag = "0";
            this.txtAA.TextChanged += new System.EventHandler(this.txtAA_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 18);
            this.label9.TabIndex = 45;
            this.label9.Text = "A)";
            // 
            // txtPergunta
            // 
            this.txtPergunta.Location = new System.Drawing.Point(11, 57);
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(561, 27);
            this.txtPergunta.TabIndex = 5;
            this.txtPergunta.TextChanged += new System.EventHandler(this.txtPergunta_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 18);
            this.label8.TabIndex = 43;
            this.label8.Text = "Pergunta";
            // 
            // btnChamaSelec
            // 
            this.btnChamaSelec.Location = new System.Drawing.Point(706, 281);
            this.btnChamaSelec.Name = "btnChamaSelec";
            this.btnChamaSelec.Size = new System.Drawing.Size(132, 60);
            this.btnChamaSelec.TabIndex = 12;
            this.btnChamaSelec.Text = "Selecionar Funcionários";
            this.btnChamaSelec.UseVisualStyleBackColor = true;
            this.btnChamaSelec.Click += new System.EventHandler(this.btnChamaSelec_Click);
            // 
            // dtPesquisa
            // 
            this.dtPesquisa.Location = new System.Drawing.Point(537, 37);
            this.dtPesquisa.Name = "dtPesquisa";
            this.dtPesquisa.Size = new System.Drawing.Size(352, 27);
            this.dtPesquisa.TabIndex = 3;
            // 
            // btnSavePesq
            // 
            this.btnSavePesq.Location = new System.Drawing.Point(706, 359);
            this.btnSavePesq.Name = "btnSavePesq";
            this.btnSavePesq.Size = new System.Drawing.Size(132, 60);
            this.btnSavePesq.TabIndex = 13;
            this.btnSavePesq.Text = "Salvar Pesquisa";
            this.btnSavePesq.UseVisualStyleBackColor = true;
            this.btnSavePesq.Click += new System.EventHandler(this.btnSavePesq_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bairro";
            // 
            // txtnm_bairro
            // 
            this.txtnm_bairro.Location = new System.Drawing.Point(274, 37);
            this.txtnm_bairro.Name = "txtnm_bairro";
            this.txtnm_bairro.Size = new System.Drawing.Size(233, 27);
            this.txtnm_bairro.TabIndex = 2;
            // 
            // txtnm_pesquisa
            // 
            this.txtnm_pesquisa.Location = new System.Drawing.Point(13, 37);
            this.txtnm_pesquisa.Name = "txtnm_pesquisa";
            this.txtnm_pesquisa.Size = new System.Drawing.Size(233, 27);
            this.txtnm_pesquisa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome da Pesquisa";
            // 
            // frm_Pesquisas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 562);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Pesquisas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_Pesquisas";
            this.Load += new System.EventHandler(this.frm_Pesquisas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblPesqFeitas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPesqMarc)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSavePesq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnm_bairro;
        private System.Windows.Forms.TextBox txtnm_pesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtPesquisa;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAddPerg;
        private System.Windows.Forms.Button btnChamaSelec;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAE;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPergunta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView tblPesqFeitas;
        private System.Windows.Forms.DataGridView tblPesqMarc;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ComboBox cmbPesquisas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPerg;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}