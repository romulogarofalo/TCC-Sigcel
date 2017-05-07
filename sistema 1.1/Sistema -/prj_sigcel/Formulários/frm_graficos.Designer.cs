namespace prj_sigcel
{
    partial class frm_graficos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_graficos));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCarregarPesq = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_perguntas = new System.Windows.Forms.ComboBox();
            this.btnGeraGrafico = new System.Windows.Forms.Button();
            this.btn_verGraficoGrande = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.cmbFaixaSalarial = new System.Windows.Forms.ComboBox();
            this.cmbEscolaridade = new System.Windows.Forms.ComboBox();
            this.cmbIdade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.cmb_bananinha = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbxPesquisas = new System.Windows.Forms.ListBox();
            this.btnReferencia = new System.Windows.Forms.Button();
            this.tblEleitores = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEleitores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 37);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gráficos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(877, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Grafico
            // 
            chartArea1.Name = "ChartArea1";
            this.Grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Grafico.Legends.Add(legend1);
            this.Grafico.Location = new System.Drawing.Point(374, 214);
            this.Grafico.Name = "Grafico";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Grafico.Series.Add(series1);
            this.Grafico.Size = new System.Drawing.Size(531, 325);
            this.Grafico.TabIndex = 3;
            this.Grafico.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Selecionar Pesquisas";
            // 
            // btnCarregarPesq
            // 
            this.btnCarregarPesq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarregarPesq.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregarPesq.Location = new System.Drawing.Point(309, 71);
            this.btnCarregarPesq.Name = "btnCarregarPesq";
            this.btnCarregarPesq.Size = new System.Drawing.Size(116, 61);
            this.btnCarregarPesq.TabIndex = 29;
            this.btnCarregarPesq.Text = "Carregar Pesquisas";
            this.btnCarregarPesq.UseVisualStyleBackColor = true;
            this.btnCarregarPesq.Click += new System.EventHandler(this.btnCarregarPesq_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 18);
            this.label4.TabIndex = 30;
            this.label4.Text = "Selecionar Pergunta Específica";
            // 
            // cmb_perguntas
            // 
            this.cmb_perguntas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_perguntas.FormattingEnabled = true;
            this.cmb_perguntas.Location = new System.Drawing.Point(7, 396);
            this.cmb_perguntas.Name = "cmb_perguntas";
            this.cmb_perguntas.Size = new System.Drawing.Size(354, 26);
            this.cmb_perguntas.TabIndex = 31;
            // 
            // btnGeraGrafico
            // 
            this.btnGeraGrafico.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeraGrafico.Location = new System.Drawing.Point(8, 433);
            this.btnGeraGrafico.Name = "btnGeraGrafico";
            this.btnGeraGrafico.Size = new System.Drawing.Size(353, 33);
            this.btnGeraGrafico.TabIndex = 32;
            this.btnGeraGrafico.Text = "Gerar gráfico";
            this.btnGeraGrafico.UseVisualStyleBackColor = true;
            this.btnGeraGrafico.Click += new System.EventHandler(this.btnGeraGrafico_Click);
            // 
            // btn_verGraficoGrande
            // 
            this.btn_verGraficoGrande.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_verGraficoGrande.Location = new System.Drawing.Point(8, 506);
            this.btn_verGraficoGrande.Name = "btn_verGraficoGrande";
            this.btn_verGraficoGrande.Size = new System.Drawing.Size(353, 33);
            this.btn_verGraficoGrande.TabIndex = 33;
            this.btn_verGraficoGrande.Text = "Ver o gráfico maior";
            this.btn_verGraficoGrande.UseVisualStyleBackColor = true;
            this.btn_verGraficoGrande.Visible = false;
            this.btn_verGraficoGrande.Click += new System.EventHandler(this.btn_verGraficoGrande_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExcel.Location = new System.Drawing.Point(443, 71);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(100, 91);
            this.btnExcel.TabIndex = 34;
            this.btnExcel.Text = "Importar Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Visible = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // cmbFaixaSalarial
            // 
            this.cmbFaixaSalarial.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFaixaSalarial.FormattingEnabled = true;
            this.cmbFaixaSalarial.Items.AddRange(new object[] {
            "Todos",
            "500 à 1500 reais",
            "1501 à 2500 reais ",
            "2501 à 3500 reais",
            "3501 à 4500 reais",
            "mais de 4500"});
            this.cmbFaixaSalarial.Location = new System.Drawing.Point(141, 18);
            this.cmbFaixaSalarial.Name = "cmbFaixaSalarial";
            this.cmbFaixaSalarial.Size = new System.Drawing.Size(196, 26);
            this.cmbFaixaSalarial.TabIndex = 37;
            // 
            // cmbEscolaridade
            // 
            this.cmbEscolaridade.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEscolaridade.FormattingEnabled = true;
            this.cmbEscolaridade.Items.AddRange(new object[] {
            "Todos",
            "Não sabe ler nem escrever",
            "Ensino fundamental incompleto",
            "Ensino fundamental completo",
            "Ensino médio incompleto",
            "Ensino médio completo",
            "Ensino superior incompleto",
            "Ensino superior completo",
            "Pós-graduação"});
            this.cmbEscolaridade.Location = new System.Drawing.Point(141, 49);
            this.cmbEscolaridade.Name = "cmbEscolaridade";
            this.cmbEscolaridade.Size = new System.Drawing.Size(196, 26);
            this.cmbEscolaridade.TabIndex = 38;
            // 
            // cmbIdade
            // 
            this.cmbIdade.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIdade.FormattingEnabled = true;
            this.cmbIdade.Items.AddRange(new object[] {
            "Todos",
            "16 a 25 anos",
            "26 a 35 anos",
            "36 a 45 anos",
            "46 a 55 anos ",
            "56 pra cima"});
            this.cmbIdade.Location = new System.Drawing.Point(141, 80);
            this.cmbIdade.Name = "cmbIdade";
            this.cmbIdade.Size = new System.Drawing.Size(196, 26);
            this.cmbIdade.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 40;
            this.label5.Text = "Faixa Salarial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 18);
            this.label6.TabIndex = 41;
            this.label6.Text = "Escolaridade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 42;
            this.label7.Text = "Idade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 18);
            this.label8.TabIndex = 43;
            this.label8.Text = "Sexo";
            // 
            // cmbSexo
            // 
            this.cmbSexo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Todos",
            "Homem",
            "Mulher",
            "Outro(a)"});
            this.cmbSexo.Location = new System.Drawing.Point(141, 111);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(196, 26);
            this.cmbSexo.TabIndex = 44;
            // 
            // cmb_bananinha
            // 
            this.cmb_bananinha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_bananinha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_bananinha.FormattingEnabled = true;
            this.cmb_bananinha.Location = new System.Drawing.Point(7, 92);
            this.cmb_bananinha.Name = "cmb_bananinha";
            this.cmb_bananinha.Size = new System.Drawing.Size(284, 26);
            this.cmb_bananinha.TabIndex = 45;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbEscolaridade);
            this.groupBox1.Controls.Add(this.cmbSexo);
            this.groupBox1.Controls.Add(this.cmbFaixaSalarial);
            this.groupBox1.Controls.Add(this.cmbIdade);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 144);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // lbxPesquisas
            // 
            this.lbxPesquisas.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPesquisas.FormattingEnabled = true;
            this.lbxPesquisas.ItemHeight = 18;
            this.lbxPesquisas.Location = new System.Drawing.Point(9, 131);
            this.lbxPesquisas.Name = "lbxPesquisas";
            this.lbxPesquisas.Size = new System.Drawing.Size(281, 76);
            this.lbxPesquisas.TabIndex = 50;
            // 
            // btnReferencia
            // 
            this.btnReferencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReferencia.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReferencia.Location = new System.Drawing.Point(309, 142);
            this.btnReferencia.Name = "btnReferencia";
            this.btnReferencia.Size = new System.Drawing.Size(116, 61);
            this.btnReferencia.TabIndex = 51;
            this.btnReferencia.Text = "Referenciar Pesquisas";
            this.btnReferencia.UseVisualStyleBackColor = true;
            this.btnReferencia.Click += new System.EventHandler(this.btnReferencia_Click);
            // 
            // tblEleitores
            // 
            this.tblEleitores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblEleitores.Location = new System.Drawing.Point(572, 72);
            this.tblEleitores.Name = "tblEleitores";
            this.tblEleitores.Size = new System.Drawing.Size(53, 70);
            this.tblEleitores.TabIndex = 52;
            this.tblEleitores.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frm_graficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 574);
            this.Controls.Add(this.tblEleitores);
            this.Controls.Add(this.btnReferencia);
            this.Controls.Add(this.lbxPesquisas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_bananinha);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btn_verGraficoGrande);
            this.Controls.Add(this.btnGeraGrafico);
            this.Controls.Add(this.cmb_perguntas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCarregarPesq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grafico);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_graficos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_graficos";
            this.Load += new System.EventHandler(this.frm_graficos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grafico)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEleitores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Grafico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCarregarPesq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_perguntas;
        private System.Windows.Forms.Button btnGeraGrafico;
        private System.Windows.Forms.Button btn_verGraficoGrande;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.ComboBox cmbFaixaSalarial;
        private System.Windows.Forms.ComboBox cmbEscolaridade;
        private System.Windows.Forms.ComboBox cmbIdade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.ComboBox cmb_bananinha;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxPesquisas;
        private System.Windows.Forms.Button btnReferencia;
        private System.Windows.Forms.DataGridView tblEleitores;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}