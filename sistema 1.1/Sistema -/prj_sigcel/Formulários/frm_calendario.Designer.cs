namespace prj_sigcel
{
    partial class frm_calendario
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
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.pnlBorda_Func = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.imgSair = new System.Windows.Forms.PictureBox();
            this.pnlAgenda = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.pnlBorda_Func.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSair)).BeginInit();
            this.pnlAgenda.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(7, 41);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 0;
            this.Calendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateSelected);
            // 
            // pnlBorda_Func
            // 
            this.pnlBorda_Func.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlBorda_Func.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBorda_Func.Controls.Add(this.imgSair);
            this.pnlBorda_Func.Controls.Add(this.label2);
            this.pnlBorda_Func.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBorda_Func.Location = new System.Drawing.Point(0, 0);
            this.pnlBorda_Func.Name = "pnlBorda_Func";
            this.pnlBorda_Func.Size = new System.Drawing.Size(242, 34);
            this.pnlBorda_Func.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Agenda Administrador";
            // 
            // imgSair
            // 
            this.imgSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgSair.Image = global::prj_sigcel.Properties.Resources.ico_sair;
            this.imgSair.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.imgSair.Location = new System.Drawing.Point(214, 3);
            this.imgSair.Name = "imgSair";
            this.imgSair.Size = new System.Drawing.Size(24, 24);
            this.imgSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgSair.TabIndex = 3;
            this.imgSair.TabStop = false;
            this.imgSair.Click += new System.EventHandler(this.imgSair_Click);
            // 
            // pnlAgenda
            // 
            this.pnlAgenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlAgenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAgenda.Controls.Add(this.label3);
            this.pnlAgenda.Controls.Add(this.label1);
            this.pnlAgenda.Controls.Add(this.txtNome);
            this.pnlAgenda.Controls.Add(this.txtDescricao);
            this.pnlAgenda.Location = new System.Drawing.Point(243, 41);
            this.pnlAgenda.Name = "pnlAgenda";
            this.pnlAgenda.Size = new System.Drawing.Size(334, 162);
            this.pnlAgenda.TabIndex = 4;
            this.pnlAgenda.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(5, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descrição Compromisso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome Compromisso:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(5, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(321, 20);
            this.txtNome.TabIndex = 1;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(6, 76);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(321, 79);
            this.txtDescricao.TabIndex = 0;
            // 
            // frm_calendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 208);
            this.Controls.Add(this.pnlAgenda);
            this.Controls.Add(this.pnlBorda_Func);
            this.Controls.Add(this.Calendario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_calendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_calendario";
            this.pnlBorda_Func.ResumeLayout(false);
            this.pnlBorda_Func.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSair)).EndInit();
            this.pnlAgenda.ResumeLayout(false);
            this.pnlAgenda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.Panel pnlBorda_Func;
        private System.Windows.Forms.PictureBox imgSair;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel pnlAgenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtDescricao;
    }
}