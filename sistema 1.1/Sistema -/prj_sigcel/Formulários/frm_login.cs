using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace prj_sigcel
{
    public partial class frm_login : Form
    {
        MySqlConnection BananaLocal;
        
        public frm_login(MySqlConnection Conexaos)
        {
            // mudei o construtor do frm_login para receber a conexao do frm_principal
            InitializeComponent();
            // passei a conexao do frm_principal para a desse form que no caso é a Bananalocal
            BananaLocal = Conexaos;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            #region Validação de Existência
            if (txtLogin.Text == "")
            {
                MessageBox.Show("Login é obrigatório!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLogin.Focus();
                return;
            }
            if (txtSenha.Text == "")
            {
                MessageBox.Show("Senha é obrigatória!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return;
            }
            #endregion
            #region verifica login e senha
            string comandoSelectSenha = "select nm_email_funcionario, nm_funcionario from funcionario where nm_email_funcionario = '" + txtLogin.Text + "' and cd_senha_funcionario = md5('" + txtSenha.Text + "');";

            MySqlCommand cSQL = new MySqlCommand(comandoSelectSenha, BananaLocal);
            MySqlDataReader dadinhos = cSQL.ExecuteReader();
            if (!dadinhos.Read())
            {
                MessageBox.Show("Login e/ou Senha Inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Clear();
                txtLogin.Clear();
                txtLogin.Focus();
                return;
            }
            else
            {
                cls_coisas_genericas.FuncionarioAtual = dadinhos[1].ToString();
                this.Close();
            }
            dadinhos.Close();
            dadinhos.Dispose(); // para limpar a memória
            this.Close();
            #endregion
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
