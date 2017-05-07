using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace prj_sigcel
{
    public partial class frm_cadastro_funcionario : Form
    {
        bool edicao = false;
        #region Conexao
        MySqlConnection ConexaoLocal;
        public frm_cadastro_funcionario(MySqlConnection conexao)
        {
            InitializeComponent();
            ConexaoLocal = conexao;

            string comando = "Select nm_funcao from funcao; ";
            MySqlCommand cSQL = new MySqlCommand(comando, conexao);
            MySqlDataReader dados = cSQL.ExecuteReader();
            while (dados.Read())
            {
                cb_tipo.Items.Add(dados[0].ToString());
            }
            dados.Close();

            cb_tipo.SelectedIndex = -1;
        }
        #endregion

        #region metodo Alert
        public static void alert(string mensagem, string tipo)
        {
            MessageBox.Show(mensagem, tipo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        #endregion

        #region metodo para tirar as / e trocar por - para inserir no banco de dados
        public string Masktxt(string data)
        {
            string datafinal;
            if (data.Length != 8)
            {
                MessageBox.Show("preencha o campo de data Corretamente DD/MM/AAAA");
                return "";
            }
            return datafinal = data.Substring(4, 4) + "-" + data.Substring(2, 2) + "-" + data.Substring(0, 2);
        }
        #endregion

        #region metodo na imagem para fechar o form
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //falta a message box perguntando se realmente quer sair desta tela
            this.Close();
        }
        #endregion

        #region evento botao buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string comandoConsulta;
            if (txtBuscar.Text.Trim() == "")
            {
                if (MessageBox.Show("Atenção! Sem definir um filtro a busca pode ser demorada.\nDeseja continuar mesmo assim?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                comandoConsulta = "select u.cd_cpf_funcionario as 'CPF', u.nm_funcionario as 'Funcionário',u.nm_email_funcionario as 'Email', u.nm_cidade_funcionario as 'Cidade', u.nm_bairro_funcionario as 'Bairro', u.nm_rua_funcionario as 'Rua', u.cd_numero_funcionario as 'Número', u.nm_complemento_funcionario as 'Complemento',u.nm_celular_funcionario as 'Celular',dt_contratacao as 'Data Contratação', dt_fim_contratacao as 'Data Fim Contratação', c.nm_funcao as 'Função' from funcionario u inner join funcao c on u.cd_funcao = c.cd_funcao;";
            }
            else
            {
                comandoConsulta = "select u.cd_cpf_funcionario as 'CPF', u.nm_funcionario as 'Funcionário',u.nm_email_funcionario as 'Email', u.nm_cidade_funcionario as 'Cidade', u.nm_bairro_funcionario as 'Bairro', u.nm_rua_funcionario as 'Rua', u.cd_numero_funcionario as 'Número', u.nm_complemento_funcionario as 'Complemento',u.nm_celular_funcionario as 'Celular',dt_contratacao as 'Data Contratação', dt_fim_contratacao as 'Data Fim Contratação', c.nm_funcao as 'Função' from funcionario u inner join funcao c on u.cd_funcao = c.cd_funcao where nm_funcionario like '%"+txtBuscar.Text+"%';";
            }

            #region consulta
            
                //"select u.cd_cpf_funcionario, u.nm_funcionario, u.nm_email_funcionario, u.nm_endereco_funcioanrio, u.nm_celular_funcionario, c.nm_funcao";
                  // comandoConsulta +="from funcionario u inner join funcao c ";
                   //comandoConsulta += "on u.cd_funcao = c.cd_funcao ;";
                 //  comandoConsulta += "where nm_funcionario like '%"+txtBuscar.Text+"%'";
                  // comandoConsulta += "order by cd_cpf_funcionario";

            //try
            //{
                tblFuncionarios.DataSource = null;
                tblFuncionarios.Rows.Clear();
                tblFuncionarios.Columns.Clear();

                MySqlDataAdapter dadoslocal;
                DataTable tabela;

                dadoslocal = new MySqlDataAdapter(comandoConsulta, ConexaoLocal);
                tabela = new DataTable();
                dadoslocal.Fill(tabela);

                tblFuncionarios.DataSource = tabela;
                tblFuncionarios.AutoResizeColumns();
                tblFuncionarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //}
            //catch
            //{
            //    MessageBox.Show("deu merda");
            //}


            #endregion 
        }
        #endregion

        #region botao Cadastrar
        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (txt_nome_funcionario.Text.Trim() == "" || txt_cpf_funcionario.Text.Trim() == "" || txt_email_funcionario.Text.Trim() == "" || txt_cidade_funcionario.Text.Trim() == "" || txt_bairro_funcionario.Text.Trim() == "" || txt_rua_funcionario.Text.Trim() == "" || txt_numero_funcionario.Text.Trim() == "" || cb_tipo.SelectedIndex == -1)
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_nome_funcionario.Focus();
                return;
            }
            if (edicao)
            {
                string dt_contratacao,dt_fim_contratacao,nm_complemento;
                int tipo = cb_tipo.SelectedIndex + 1;
                #region montagem comando update
                if (txt_dt_contratacao.Text.Trim() == "")
                    dt_contratacao = "null";
                else
                    dt_contratacao = "'"+Masktxt(txt_dt_contratacao.Text.Trim())+"'";
                if (txt_fim_contratacao.Text.Trim() == "")
                    dt_fim_contratacao = "null";
                else
                    dt_fim_contratacao = "'"+Masktxt(txt_fim_contratacao.Text.Trim())+"'";
                if (txt_complemento.Text.Trim() == "")
                    nm_complemento = "null";
                else
                    nm_complemento = "'" + txt_complemento.Text.Trim() + "'";
                string comandoUpdate = "update funcionario set nm_funcionario = '" + txt_nome_funcionario.Text.Trim() + "', nm_email_funcionario = '" + txt_email_funcionario.Text.Trim() + "', nm_cidade_funcionario = '" + txt_cidade_funcionario.Text.Trim() + "', nm_bairro_funcionario = '" + txt_bairro_funcionario.Text.Trim() + "', nm_rua_funcionario = '" + txt_rua_funcionario.Text.Trim() + "', cd_numero_funcionario = '" + txt_numero_funcionario.Text.Trim() +"', nm_complemento_funcionario ="+nm_complemento+", nm_celular_funcionario = '"+txt_telefone.Text.Trim()+"', dt_contratacao ="+dt_contratacao+", dt_fim_contratacao = "+dt_fim_contratacao+",cd_funcao = "+tipo.ToString()+" where cd_cpf_funcionario = '"+txt_cpf_funcionario.Text+"';";
                #endregion

                MySqlCommand cSQL = new MySqlCommand(comandoUpdate, ConexaoLocal);
                cSQL.ExecuteNonQuery();

                MessageBox.Show("Funcionario gravado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_nome_funcionario.Clear();
                txt_cpf_funcionario.Clear();
                txt_email_funcionario.Clear();
                txt_cidade_funcionario.Clear();
                txt_bairro_funcionario.Clear();
                txt_rua_funcionario.Clear();
                txt_numero_funcionario.Clear();
                txt_complemento.Clear();
                txt_senha.Clear();
                txt_telefone.Clear();
                txt_dt_contratacao.Clear();
                txt_fim_contratacao.Clear();
                cb_tipo.SelectedIndex = -1;
                cbx_funcionario_tercerizado.Checked = false;
                cbx_senha.Checked = false;
                txt_dt_contratacao.Enabled = false;
                txt_fim_contratacao.Enabled = false;
                edicao = false;
                return;
            }
            string comandoselect = "select cd_cpf_funcionario from funcionario where cd_cpf_funcionario = " + txt_cpf_funcionario.Text + ";";
            try
            {
                MySqlCommand cSQL = new MySqlCommand(comandoselect, ConexaoLocal);
                MySqlDataReader dados = cSQL.ExecuteReader();
                if (dados.Read())
                {
                    MessageBox.Show("Já foi adicionado um funcionário com este cpf.");
                    txt_cpf_funcionario.Clear();
                    txt_cpf_funcionario.Focus();
                    dados.Close();
                    return;
                }
                dados.Close();
            }
            catch
            {
                // mandar alguma mensagem de que erro o cpf (ver se colocar letra da merda ou n)
            }

            #region Montagem do Comando Insert
            // comando de insert
            // concatenar todas as partes do endereço 
           // Falidaçoes

            string complemento;
            if (txt_complemento.Text.Trim() == "")
            {
                complemento = "null";
            }
            else
            {
                complemento = "'"+txt_complemento.Text.Trim() +"'";
            }

            string ComandoInsert = "insert into funcionario values ('" + txt_cpf_funcionario.Text.Trim() + "','" + txt_nome_funcionario.Text.Trim() + "','" + txt_email_funcionario.Text.Trim() + "','" + txt_cidade_funcionario.Text + "','" + txt_bairro_funcionario.Text + "','" + txt_rua_funcionario.Text + "','" +txt_numero_funcionario.Text+ "',"+complemento+",'" + txt_telefone.Text + "'";
            if (cbx_funcionario_tercerizado.Checked)
            {

                ComandoInsert += ",'" + Masktxt(txt_dt_contratacao.Text) + "','" + Masktxt(txt_fim_contratacao.Text) + "'";
                // usar o metodo masktxt no que receber das txt de data para ai sim colocar no comando insert
            }
            else
            {
                ComandoInsert += ",null,null";
            }
            if (cbx_senha.Checked)
            {
                ComandoInsert += ",md5('" + txt_senha.Text + "')";
            }
            else
            {
                ComandoInsert += ",md5(null)";
            }

            if (cb_tipo.SelectedIndex == 0)
            {
                alert("Selecione o Cargo do funcionario", "Erro");
                return;
            }
            int tipofuncionario = 0;
            tipofuncionario = cb_tipo.SelectedIndex + 1;
            ComandoInsert += "," + tipofuncionario.ToString() + ");";
            // if para saber o tipo de funcionario
            #endregion

           try
            {                   
                MySqlCommand cInsert = new MySqlCommand(ComandoInsert, ConexaoLocal);
                cInsert.ExecuteNonQuery();
                MessageBox.Show("Cadastrado com Sucesso!");
                 //limpar todas as txtbox e por focus na do começo
                 //E arrumar o Tabindex
                txt_nome_funcionario.Clear();
                txt_cpf_funcionario.Clear();
                txt_email_funcionario.Clear();
                txt_cidade_funcionario.Clear();
                txt_bairro_funcionario.Clear();
                txt_rua_funcionario.Clear();
                txt_numero_funcionario.Clear();
                txt_complemento.Clear();
                txt_senha.Clear();
                txt_telefone.Clear();
                txt_dt_contratacao.Clear();
                txt_fim_contratacao.Clear();
                cb_tipo.SelectedIndex = -1;
                cbx_funcionario_tercerizado.Checked = false;
                cbx_senha.Checked = false;
            }
            catch
            {
                alert("Erro ao tentar Cadastrar, Verifique a conexão com o banco", "Erro");
            }
        }
        #endregion

        #region checkbox do cadastrar 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_funcionario_tercerizado.Checked)
            {
                txt_dt_contratacao.Enabled = true;
                txt_fim_contratacao.Enabled = true;
                
            }
            else
            {
                txt_dt_contratacao.Enabled = false;
                txt_fim_contratacao.Enabled = false;
            }
        }

        private void cbx_senha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_senha.Checked)
            {
                txt_senha.Enabled = true;
            }
            else
            {
                txt_senha.Enabled = false;
            }
        }
        #endregion 

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            #region validação para a exclusao
            if (tblFuncionarios.RowCount <= 0)
            {
                alert("Faça uma busca pelo Funcionario a ser excluído.", "Aviso");
                return;
            }

            if (tblFuncionarios.CurrentRow == null)
            {
                alert("Selecione o funcionario para ser excluído", "Aviso");
                return;
            }
            #endregion
            #region exclusao
            int linha = tblFuncionarios.CurrentRow.Index;
            string cpf = tblFuncionarios.Rows[linha].Cells[0].Value.ToString();
            string nome = tblFuncionarios.Rows[linha].Cells[1].Value.ToString();

            if (MessageBox.Show("Deseja realmente excluir o Funcionario " + nome + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            MySqlCommand cSQL;
            try
            {
                cSQL = new MySqlCommand("delete from funcionario where cd_cpf_funcionario = '"+cpf +"';", ConexaoLocal);
                cSQL.ExecuteNonQuery();
                //limpa a lista 
                tblFuncionarios.DataSource = null;
                tblFuncionarios.Rows.Clear();
                tblFuncionarios.Columns.Clear();
                // pergunta se quer atualizar 
                MessageBox.Show("Funcionario excluído com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch 
            {
                MessageBox.Show("Ocorreu um erro na exclusão do Funcionario, por favor tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            #endregion
            
        }


        #region Botão Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tblFuncionarios.RowCount <= 0)
            {
                MessageBox.Show("Faça uma busca pelo Funcionario a ser editado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tblFuncionarios.CurrentRow == null)
            {
                MessageBox.Show("Selecione o Funcionario a ser editado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // pegar todas as informações e jogar na janelinha do lado e poder editar
            int linha = tblFuncionarios.CurrentRow.Index;
            txt_nome_funcionario.Text = tblFuncionarios.Rows[linha].Cells[1].Value.ToString();
            txt_cpf_funcionario.Text = tblFuncionarios.Rows[linha].Cells[0].Value.ToString();
            txt_email_funcionario.Text = tblFuncionarios.Rows[linha].Cells[2].Value.ToString();
            txt_cidade_funcionario.Text = tblFuncionarios.Rows[linha].Cells[3].Value.ToString();
            txt_bairro_funcionario.Text = tblFuncionarios.Rows[linha].Cells[4].Value.ToString();
            txt_rua_funcionario.Text = tblFuncionarios.Rows[linha].Cells[5].Value.ToString();
            txt_numero_funcionario.Text = tblFuncionarios.Rows[linha].Cells[6].Value.ToString();
            txt_complemento.Text = tblFuncionarios.Rows[linha].Cells[7].Value.ToString();
            txt_telefone.Text = tblFuncionarios.Rows[linha].Cells[8].Value.ToString();
            txt_dt_contratacao.Text = tblFuncionarios.Rows[linha].Cells[9].Value.ToString();
            txt_fim_contratacao.Text = tblFuncionarios.Rows[linha].Cells[10].Value.ToString();

            txt_cpf_funcionario.Enabled = false;
            txt_dt_contratacao.Enabled = true;
            txt_fim_contratacao.Enabled = true;

            tabControl1.SelectedTab = tabPage2;
            edicao = true;
        }
        #endregion

    }
}
