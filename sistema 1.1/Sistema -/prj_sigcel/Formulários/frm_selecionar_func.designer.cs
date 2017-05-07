namespace prj_sigcel.Formulários
{
    partial class frm_selecionar_func
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
            this.tblFunc = new System.Windows.Forms.DataGridView();
            this.tblFuncA = new System.Windows.Forms.DataGridView();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecionados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFuncA)).BeginInit();
            this.SuspendLayout();
            // 
            // tblFunc
            // 
            this.tblFunc.AllowUserToAddRows = false;
            this.tblFunc.AllowUserToDeleteRows = false;
            this.tblFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblFunc.Location = new System.Drawing.Point(21, 28);
            this.tblFunc.Name = "tblFunc";
            this.tblFunc.ReadOnly = true;
            this.tblFunc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblFunc.Size = new System.Drawing.Size(245, 245);
            this.tblFunc.TabIndex = 0;
            // 
            // tblFuncA
            // 
            this.tblFuncA.AllowUserToAddRows = false;
            this.tblFuncA.AllowUserToDeleteRows = false;
            this.tblFuncA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblFuncA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CPF,
            this.Selecionados});
            this.tblFuncA.Location = new System.Drawing.Point(444, 28);
            this.tblFuncA.Name = "tblFuncA";
            this.tblFuncA.ReadOnly = true;
            this.tblFuncA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblFuncA.Size = new System.Drawing.Size(245, 245);
            this.tblFuncA.TabIndex = 1;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            // 
            // Selecionados
            // 
            this.Selecionados.HeaderText = "Pesquisadores Selecionados";
            this.Selecionados.Name = "Selecionados";
            this.Selecionados.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(294, 82);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 47);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Adicionar-->";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(294, 152);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(118, 47);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "<--Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(587, 295);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(92, 43);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frm_selecionar_func
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 352);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tblFuncA);
            this.Controls.Add(this.tblFunc);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_selecionar_func";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selecionar Funcionários";
            this.Load += new System.EventHandler(this.frm_selecionar_func_Load);
            
            ((System.ComponentModel.ISupportInitialize)(this.tblFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFuncA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblFunc;
        private System.Windows.Forms.DataGridView tblFuncA;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Selecionados;
        private System.Windows.Forms.Button btnSalvar;
    }
}