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
    public partial class frm_eventos : Form
    {
        MySqlConnection ConexaoLocal;
        bool alterar = false;
        string dtCompAlterar = "";
        string hrAlterar = "";

        public frm_eventos(MySqlConnection Conexao)
        {
            InitializeComponent();
            ConexaoLocal = Conexao;

            string comando = "Select nm_tipo_compromisso from tipo_compromisso; ";
            MySqlCommand cSQL = new MySqlCommand(comando, ConexaoLocal);
            MySqlDataReader dados = cSQL.ExecuteReader();
            while (dados.Read())
            {
                cbTipo.Items.Add(dados[0].ToString());
            }
            dados.Close();

            cbTipo.SelectedIndex = -1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string trocaData(string data)
        {
            string dia,mes,ano;

            dia = data.Substring(0, 2);
            mes = data.Substring(3, 2);
            ano = data.Substring(6, 4);

            data = ano + "-" + mes + "-" + dia;

            return data;
        }

        private void cbMili_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMili.Checked == true)
            {
                gbInfoEmail.Enabled = true;
            }
            else
            {
                gbInfoEmail.Enabled = false;
            }
        }

        private void cbFunc_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFunc.Checked == true)
            {
                gbInfoEmail.Enabled = true;
            }
            else
            {
                gbInfoEmail.Enabled = false;
            }
        }

        private void btn_selecionar_materiais_Click(object sender, EventArgs e)
        {
            //Formulários.frm_materiais_eventos frmMatEve = new Formulários.frm_materiais_eventos(ConexaoLocal);
            pnlSelecionarMateriais.Visible = true;
            //frmMatEve.ShowDialog();

        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNome.Checked)
            {
                txt_consulta.Visible = true;
                dtp_consulta.Visible = false;
                txt_consulta.Focus();
            }
            else
            {
                dtp_consulta.Visible = true;
                txt_consulta.Visible = false;
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if (rdbNome.Checked == true && txtNome.Text == "")
            {

                if (MessageBox.Show("Sem definir filtro a consulta pode levar algum tempo. \n Deseja continuar???", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }
            else
            {
                if (MessageBox.Show("A consulta pode levar algum tempo. \n Deseja continuar???", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            string Data = dtp_consulta.Value.ToShortDateString();
          //  MessageBox.Show(Data);
            //faz um select e ve se tem dia
            Data = trocaData(Data);
           // MessageBox.Show(Data);

            string ComandoSelect = "select dt_compromisso as 'Data',hr_compromisso as 'Início',hr_fim_compromisso as 'Término',nm_compromisso as 'Nome Evento',nm_cidade_compromisso as 'Cidade',nm_bairro_compromisso as 'Bairro', nm_rua_funcionario as 'Rua',cd_numero_compromisso as 'Numero', nm_tipo_compromisso as 'Evento',if (ic_chama_funcionario=1,'X','') as 'Enviar Email Para Funcionarios', if(ic_chama_militancia=1,'X','') as 'Enviar Email Para Militancias' from compromisso c inner join tipo_compromisso t on c.cd_tipo_compromisso = t.cd_tipo_compromisso";

            if (rdbData.Checked) { ComandoSelect += " where dt_compromisso = '" + Data + "';"; }
            if (txt_consulta.Text.Trim() != "")
                if (rdbNome.Checked) { ComandoSelect += " where nm_compromisso like '%" + txt_consulta.Text + "%';"; }

            //try
            //{
                tbl_consulta_evento.DataSource = null;
                tbl_consulta_evento.Rows.Clear();
                tbl_consulta_evento.Columns.Clear();

                MySqlDataAdapter dadoslocal;
                DataTable tabelinha;

                dadoslocal = new MySqlDataAdapter(ComandoSelect, ConexaoLocal);
           
                tabelinha = new DataTable();
                dadoslocal.Fill(tabelinha);

                tbl_consulta_evento.DataSource = tabelinha;
              //  tbl_consulta_evento.Columns[0].Visible = false;
                tbl_consulta_evento.AutoResizeColumns();
                tbl_consulta_evento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                
                    if (tbl_consulta_evento.RowCount == 0)
                    {
                        if (rdbData.Checked)
                        {
                            MessageBox.Show("Não há pesquisas nesta data", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Não há pesquisas com este nome", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
              
            //}
            //catch
            //{
              //  MessageBox.Show("Ocorreu um erro na consulta dos Eventos, tente novamente. ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            // concertar 
            #region Alteração
            if (alterar)
            {
                if (MessageBox.Show("Deseja realmente editar o Evento ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                string emfunc, emMili;
                if (cbFunc.Checked)
                    emfunc = "true";
                else
                    emfunc = "false";

                if (cbMili.Checked)
                    emMili = "true";
                else
                    emMili = "false";

                #region comando update
                string comandoUpdate = "update compromisso set ";
                comandoUpdate += " nm_compromisso = '" + txtNome.Text + "', ";
                comandoUpdate += " hr_fim_compromisso = '" + txt_fim_hr.Text + "', ";
                comandoUpdate += " nm_cidade_compromisso = '" + txtCidade.Text + "', ";
                comandoUpdate += " nm_bairro_compromisso = '" + txtBairro.Text + "', ";
                comandoUpdate += " nm_rua_funcionario = '" + txtRua.Text + "', ";
                comandoUpdate += " cd_numero_compromisso = '" + txtNum.Text + "', ";
                comandoUpdate += " ic_chama_funcionario = "+emfunc+", ";
                comandoUpdate += " ic_chama_militancia = "+emMili+", ";
                comandoUpdate += " nm_email_compromisso = '" + txtemail.Text + "' where dt_compromisso = '" + dtCompAlterar + "' and hr_compromisso = '" + hrAlterar + "';";
                #endregion

                MySqlCommand cSQL2;
                cSQL2 = new MySqlCommand(comandoUpdate, ConexaoLocal);
                cSQL2.ExecuteNonQuery();

                MessageBox.Show("Evento alterado com sucesso !","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            #endregion


            if (txtNome.Text.Trim() == "" || txtCidade.Text.Trim() == "" || txtBairro.Text.Trim() == "" || txtRua.Text.Trim() == "" || txtNum.Text.Trim() == "" || txtHora.Text.Trim() == "" || cbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Todos os campos devem ser Preenchidos corretamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string Email = "null";
            string EmailFuncionario = "false";
            string EmailMilitancia = "false";
            string data = dt_Eventos.Value.ToShortDateString();
            data = trocaData(data);
            if (cbFunc.Checked)
                EmailFuncionario = "true";
            if (cbMili.Checked)
                EmailMilitancia = "true";
            int tipoevento = cbTipo.SelectedIndex + 1;

            if (cbFunc.Checked || cbMili.Checked)
                Email = "'"+txtemail.Text.Trim()+"'";
                // informações do email se checkbox estiverem true    

               
            string comando = "insert into compromisso values ('" + data + "','" + txtHora.Text.Trim() + "','"+ txt_fim_hr.Text.Trim() +"','" + txtNome.Text.Trim() + "','" + txtCidade.Text.Trim() + "','" + txtBairro.Text.Trim() + "','" + txtRua.Text.Trim() + "','" + txtNum.Text.Trim() +"'," + EmailFuncionario + "," + EmailMilitancia + "," + tipoevento.ToString() + "," + Email + ");";


                try
                {
                    MySqlCommand cSQL = new MySqlCommand(comando, ConexaoLocal);
                    cSQL.ExecuteNonQuery();
                    int a = tblMaterialSelecionado.Rows.Count;
                    if (a != 0)
                    {
                       // MessageBox.Show("foi");
                        for (int i = 0; i < tblMaterialSelecionado.Rows.Count; i++)
                        {
                            string cdmat = tblMaterialSelecionado.Rows[i].Cells[0].Value.ToString();
                            string quant = tblMaterialSelecionado.Rows[i].Cells[2].Value.ToString();
                            string comando2 = "insert into material_compromisso values ('" + data + "','" + txtHora.Text.Trim() + "'," + cdmat + "," + quant + ")";
                            MySqlCommand cInsert = new MySqlCommand(comando2, ConexaoLocal);
                            cInsert.ExecuteNonQuery();
                            int atual = qtAtual - int.Parse(quant);
                            string comandoUpdt = "update material set qt_atual = " + atual + " where cd_material = " + cdmat + ";";
                            MySqlCommand cUpdate = new MySqlCommand(comandoUpdt, ConexaoLocal);
                            cUpdate.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        //MessageBox.Show("nao foi");
                    }
                }
                catch
                {
                    MessageBox.Show("Erro na conexao com o banco de dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            

            MessageBox.Show("Evento gravado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCidade.Clear(); txtBairro.Clear(); txtRua.Clear(); txtNum.Clear(); txtNome.Clear(); txtHora.Clear(); cbTipo.SelectedIndex = -1;
            for (int i = 0; i < tblMaterialSelecionado.Rows.Count; i++)
			{
                tblMaterialSelecionado.Rows.Remove(tblMaterialSelecionado.Rows[i]);
            }
            cbMili.Checked = false;
            cbFunc.Checked = false;
            txtemail.Clear();
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            #region Validacoes de Consulta
            if (tbl_consulta_evento.RowCount <= 0)
            {
                MessageBox.Show("Faça uma busca pelo Evento a ser editado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tbl_consulta_evento.CurrentRow == null)
            {
                MessageBox.Show("Selecione o Evento a ser editado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int linha = tbl_consulta_evento.CurrentRow.Index;
            string nome = tbl_consulta_evento.Rows[linha].Cells[3].Value.ToString();
            if (MessageBox.Show("Deseja editar o Evento " + nome + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            cbTipo.SelectedIndex = -1;
            string data = tbl_consulta_evento.Rows[linha].Cells[0].Value.ToString();
            string dataHora = tbl_consulta_evento.Rows[linha].Cells[1].Value.ToString();

            DateTime datamsm = DateTime.Parse(data); 
            dtCompAlterar = datamsm.ToShortDateString();
            dtCompAlterar = trocaData(dtCompAlterar);
            hrAlterar = dataHora;

            string fim_hr = tbl_consulta_evento.Rows[linha].Cells[2].Value.ToString();
            string cidade = tbl_consulta_evento.Rows[linha].Cells[4].Value.ToString();
            string bairro = tbl_consulta_evento.Rows[linha].Cells[5].Value.ToString();
            string rua = tbl_consulta_evento.Rows[linha].Cells[6].Value.ToString();
            string numero = tbl_consulta_evento.Rows[linha].Cells[7].Value.ToString();
            string emailfunc = tbl_consulta_evento.Rows[linha].Cells[8].Value.ToString();
            string emailMili = tbl_consulta_evento.Rows[linha].Cells[9].Value.ToString();


            tabControl1.SelectedTab = tabPage2;
            txt_fim_hr.Text = fim_hr;
            txtNome.Text = nome;
            txtHora.Text = dataHora;
            txtCidade.Text = cidade;
            txtBairro.Text = bairro;
            txtRua.Text = rua;
            txtNum.Text = numero;
            #region converte data
              int dia, mes, ano;
              dia = int.Parse(data.Substring(0, 2));
              mes = int.Parse(data.Substring(3, 2));
              ano = int.Parse(data.Substring(6, 4));
            #endregion
              if (emailfunc == "")
                  cbFunc.Checked = false;
              else
                  cbFunc.Checked = true;

              alterar = true;

            dt_Eventos.Value = new DateTime(ano, mes, dia);

            txtHora.Enabled = false;
            dt_Eventos.Enabled = false;



            #endregion
        }
        int qtAtual;
        int cdMaterial;

        #region btn adiciona material tela cadastro
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (cmbMaterial.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o material.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int a = int.Parse(txtQuantidade.Text);
            }
            catch
            {
                if (txtQuantidade.Text.Trim() == "")
                {
                    MessageBox.Show("Escreva a quantidade do material desejado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtQuantidade.Focus();
                    return;
                }
                MessageBox.Show("Escreva apenas numeros", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtQuantidade.Clear();
                txtQuantidade.Focus();
                return;
            }

            string Cselect = "select qt_atual,cd_material from material where nm_material = '" + cmbMaterial.SelectedItem + "';";

            MySqlCommand cSQL = new MySqlCommand(Cselect, ConexaoLocal);
            MySqlDataReader dados = cSQL.ExecuteReader();
            if (dados.Read())
            {
                cdMaterial = int.Parse(dados[1].ToString());
                qtAtual = int.Parse(dados[0].ToString());
                if (qtAtual > int.Parse(txtQuantidade.Text))
                {
                    tblMaterialSelecionado.Rows.Add(cdMaterial.ToString(), cmbMaterial.SelectedItem, txtQuantidade.Text);
                    cmbMaterial.SelectedIndex.ToString();
                    cmbMaterial.SelectedIndex = -1;
                    txtQuantidade.Text = "";
                }
                else
                {
                    MessageBox.Show("Não há material suficiente peça menos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dados.Close();
                    return;
                }
                dados.Close();
            }
        }
        #endregion

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        #region form load
        private void frm_eventos_Load(object sender, EventArgs e)
        {
            string cmdSelects = "select nm_material from material";
            MySqlCommand Csql = new MySqlCommand(cmdSelects, ConexaoLocal);
            MySqlDataReader dadinhos = Csql.ExecuteReader();
            while (dadinhos.Read())
            {
                   cmbMaterial.Items.Add(dadinhos[0].ToString());
            }
            dadinhos.Close();
        }
        #endregion

        #region botao remove material tela cadastro
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (tblMaterialSelecionado.CurrentRow == null)
            {
                MessageBox.Show("Selecione um material para ser removido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int linha = tblMaterialSelecionado.CurrentRow.Index;
            tblMaterialSelecionado.Rows.Remove(tblMaterialSelecionado.Rows[linha]);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pnlSelecionarMateriais.Visible = false;
        }

        private void btnGravar2_Click(object sender, EventArgs e)
        {
            pnlSelecionarMateriais.Visible = false;
        }
        #endregion 

        string data;
        string hora;

        #region Botao Material Selecionado
        private void btnMaterialSelecionado_Click(object sender, EventArgs e)
        {
            if (tbl_consulta_evento.RowCount <= 0)
            {
                MessageBox.Show("Faça uma busca pelo Evento para visualizar os materiais selecionados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tbl_consulta_evento.CurrentRow == null)
            {
                MessageBox.Show("Selecione o Evento para visualizar os materiais selecionados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int linha = tbl_consulta_evento.CurrentRow.Index;
            data = tbl_consulta_evento.Rows[linha].Cells[0].Value.ToString();
            hora = tbl_consulta_evento.Rows[linha].Cells[1].Value.ToString(); ;
            data = trocaData(data);
            string cslct = "select mc.cd_material as 'Código',m.nm_material as 'Nome' ,mc.qt_levar as 'Quantidade' from material_compromisso mc join material m on(mc.cd_material = m.cd_material) where mc.dt_compromisso = '"+data+"' and '"+hora+"';";


            tblmateriais_visualizar.DataSource = null;
            tblmateriais_visualizar.Rows.Clear();
            tblmateriais_visualizar.Columns.Clear();

            MySqlDataAdapter dadoslocal;
            DataTable tabelinha;

            dadoslocal = new MySqlDataAdapter(cslct, ConexaoLocal);
            tabelinha = new DataTable();
            dadoslocal.Fill(tabelinha);

            tblmateriais_visualizar.DataSource = tabelinha;
            //  tbl_consulta_evento.Columns[0].Visible = false;
            tblmateriais_visualizar.AutoResizeColumns();
            tblmateriais_visualizar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            pnl_materiais_visualizar.Visible = true;
            pnl_materiais_visualizar.Height = 217;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pnl_materiais_visualizar.Visible = false;
        }
        #endregion

        private void btnAlteraMaterial_Click(object sender, EventArgs e)
        {
            if (tblmateriais_visualizar.RowCount <= 0)
            {
                MessageBox.Show("Esse evento nao tem nenhum material selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tblmateriais_visualizar.CurrentRow == null)
            {
                MessageBox.Show("Selecione o material para poder alterar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int linha = tblmateriais_visualizar.CurrentRow.Index;
            txtQuantiAlterar.Text = tblmateriais_visualizar.Rows[linha].Cells[2].Value.ToString();

            pnl_materiais_visualizar.Height = 270;

            


        }

        private void Gravar3_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtQuantiAlterar.Text);



            }
            catch 
            {
                MessageBox.Show("Escreva apenas numeros","Erro",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtQuantiAlterar.Clear();
                txtQuantiAlterar.Focus();
                return;
            }

            string comandUpdt = "update material_compromisso set qt_levar = " + txtQuantiAlterar.Text.Trim() + "where dt_compromisso = '"+data+"' and hr_compromisso = '"+hora+"';";
            try
            {
                MySqlCommand cUpdt = new MySqlCommand(comandUpdt, ConexaoLocal);
                cUpdt.ExecuteNonQuery();
                // falta pegar o material principal e alteralo de acordo com a quantidade alterada
            }
            catch (Exception)
            {
                MessageBox.Show("Erro na conexao com o banco de dados", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnExcluirMaterial_Click(object sender, EventArgs e)
        {
            if (tblmateriais_visualizar.RowCount <= 0)
            {
                MessageBox.Show("Esse evento nao tem nenhum material selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tblmateriais_visualizar.CurrentRow == null)
            {
                MessageBox.Show("Selecione o material para poder excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int linha = tbl_consulta_evento.CurrentRow.Index;
            string cdmat = tbl_consulta_evento.Rows[linha].Cells[0].Value.ToString();
            



        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            string comando;

            #region Validações
            if (tbl_consulta_evento.RowCount <= 0)
            {
                MessageBox.Show("Faça uma busca pelo Evento a ser excluido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tbl_consulta_evento.CurrentRow == null)
            {
                MessageBox.Show("Selecione o Evento a ser excluido.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Deseja mesmo excluir este Evento?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                return;
            }
            #endregion

            #region Excluir
            int linha = tbl_consulta_evento.CurrentRow.Index;
          DateTime data = DateTime.Parse(tbl_consulta_evento.Rows[linha].Cells[0].Value.ToString());
          data = DateTime.Parse(data.ToShortDateString());
          string hora = tbl_consulta_evento.Rows[linha].Cells[1].Value.ToString();
          string datamsm = data.ToShortDateString();
         
          datamsm = trocaData(datamsm);
         
          comando = "Delete from material_compromisso where dt_compromisso = '" + datamsm + "' and hr_compromisso = '" + hora + "';";
          MySqlCommand cSQL = new MySqlCommand(comando, ConexaoLocal);
          cSQL.ExecuteNonQuery();

          comando = "delete from compromisso where dt_compromisso = '" + datamsm + "' and hr_compromisso = '" + hora + "';";
          cSQL = new MySqlCommand(comando, ConexaoLocal);
          cSQL.ExecuteNonQuery();

          MessageBox.Show("Excluído com sucesso", "Excluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
            #endregion

            #region Atualizar Grid
          comando = "select dt_compromisso as 'Data',hr_compromisso as 'Início',hr_fim_compromisso as 'Término',nm_compromisso as 'Nome Evento',nm_cidade_compromisso as 'Cidade',nm_bairro_compromisso as 'Bairro', nm_rua_funcionario as 'Rua',cd_numero_compromisso as 'Numero', nm_tipo_compromisso as 'Evento',if (ic_chama_funcionario=1,'X','') as 'Enviar Email Para Funcionarios', if(ic_chama_militancia=1,'X','') as 'Enviar Email Para Militancias' from compromisso c inner join tipo_compromisso t on c.cd_tipo_compromisso = t.cd_tipo_compromisso";

          tbl_consulta_evento.DataSource = null;
          tbl_consulta_evento.Rows.Clear();
          tbl_consulta_evento.Columns.Clear();

          MySqlDataAdapter dadoslocal;
          DataTable tabelinha;

          dadoslocal = new MySqlDataAdapter(comando, ConexaoLocal);

          tabelinha = new DataTable();
          dadoslocal.Fill(tabelinha);

          tbl_consulta_evento.DataSource = tabelinha;
          //  tbl_consulta_evento.Columns[0].Visible = false;
          tbl_consulta_evento.AutoResizeColumns();
          tbl_consulta_evento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
          #endregion
        }


    }
}
