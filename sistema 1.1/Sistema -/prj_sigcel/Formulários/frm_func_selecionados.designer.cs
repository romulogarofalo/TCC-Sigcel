namespace prj_sigcel.Formulários
{
    partial class frm_func_selecionados
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
            this.tblFuncSelecionados = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblFuncSelecionados)).BeginInit();
            this.SuspendLayout();
            // 
            // tblFuncSelecionados
            // 
            this.tblFuncSelecionados.AllowUserToAddRows = false;
            this.tblFuncSelecionados.AllowUserToDeleteRows = false;
            this.tblFuncSelecionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblFuncSelecionados.Location = new System.Drawing.Point(9, 12);
            this.tblFuncSelecionados.Name = "tblFuncSelecionados";
            this.tblFuncSelecionados.ReadOnly = true;
            this.tblFuncSelecionados.Size = new System.Drawing.Size(278, 169);
            this.tblFuncSelecionados.TabIndex = 0;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(201, 205);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(89, 49);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // frm_func_selecionados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 276);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.tblFuncSelecionados);
            this.Name = "frm_func_selecionados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionários Selecionados";
            this.Load += new System.EventHandler(this.frm_func_selecionados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblFuncSelecionados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblFuncSelecionados;
        private System.Windows.Forms.Button btnEditar;
    }
}