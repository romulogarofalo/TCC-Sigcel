using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using MySql.Data.MySqlClient;
using prj_sigcel.Formulários;

namespace prj_sigcel
{
    public partial class frm_Pesquisas : Form
    {
        MySqlConnection ConexaoLocal;
        public frm_Pesquisas(MySqlConnection Conexao)
        {
            InitializeComponent();
            ConexaoLocal = Conexao;
        }
        int a = 1;
        bool editar = false;
        string[,] CdNmPesq = new string[50, 2];
        string[,] pergunta = new string[10, 2];
        string[] alternativa = new string[5];
        string[] cdperg = new string[10];
        string[] cdAltern = new string[100];
        string[,] AlternInsert = new string[10, 5];

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnChamaSelec_Click(object sender, EventArgs e)
        { 

            if (editar)
            {
                frm_func_selecionados FuncSelec = new frm_func_selecionados(ConexaoLocal);
                cls_coisas_genericas.FuncSelec = CdNmPesq[cmbPesquisas.SelectedIndex, 0];
                FuncSelec.ShowDialog();
                return;
            }

            frm_selecionar_func selecionar = new frm_selecionar_func(ConexaoLocal);
            selecionar.ShowDialog();
        }

        private string trocaData(string data)
        {
            string dia, mes, ano;

            dia = data.Substring(0, 2);
            mes = data.Substring(3, 2);
            ano = data.Substring(6, 4);

            data = ano + "-" + mes + "-" + dia;

            return data;
        }

        private void frm_Pesquisas_Load(object sender, EventArgs e)
        {
            cmbPesquisas.Items.Clear();
            cmbPerg.Items.Clear();
            txtPergunta.Enabled = true;
            txtAA.Enabled = true;
            txtAB.Enabled = true;
            txtAC.Enabled = true;
            txtAD.Enabled = true;
            txtAE.Enabled = true;

            #region ComboBox
            string comando = "";
            comando += "Select cd_pesquisa,nm_pesquisa from pesquisa";
            MySqlCommand pesquisas = new MySqlCommand(comando, ConexaoLocal);
            MySqlDataReader dados = pesquisas.ExecuteReader();
            for (int i = 0; dados.Read(); i++)
            {
                CdNmPesq[i, 0] = dados[0].ToString();
                CdNmPesq[i, 1] = dados[1].ToString();
                cmbPesquisas.Items.Add(dados[1].ToString());
            }
            //while (dados.Read())
            //{
            //    cmbPesquisas.Items.Add(dados[1].ToString());
            //}
            dados.Close();
            #endregion

            #region tblPesqMarc
            string data;
            data = DateTime.Now.ToShortDateString();
            comando = "";
            comando += "select dt_pesquisa as 'Data',nm_pesquisa as 'Nome', nm_bairro as 'Bairro'";
            comando += " from pesquisa where ic_pesquisa_feita = false;"; 

	

            tblPesqMarc.DataSource = null;
            tblPesqMarc.Rows.Clear();
            tblPesqMarc.Columns.Clear();

            MySqlDataAdapter dadosLocal;
            DataTable tabela;

            dadosLocal = new MySqlDataAdapter(comando, ConexaoLocal);
            tabela = new DataTable();

            dadosLocal.Fill(tabela);


            tblPesqMarc.DataSource = tabela;
            tblPesqMarc.AutoResizeColumns();
            tblPesqMarc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            #endregion


            #region tblPesqFeitas

            
            data = DateTime.Now.ToShortDateString();
            comando = "";
            comando += "select dt_pesquisa as 'Data',nm_pesquisa as 'Nome', nm_bairro as 'Bairro'";
            comando += " from pesquisa where ic_pesquisa_feita = true;";



            tblPesqFeitas.DataSource = null;
            tblPesqFeitas.Rows.Clear();
            tblPesqFeitas.Columns.Clear();

            

            dadosLocal = new MySqlDataAdapter(comando, ConexaoLocal);
            tabela = new DataTable();

            dadosLocal.Fill(tabela);


            tblPesqFeitas.DataSource = tabela;
            tblPesqFeitas.AutoResizeColumns();
            tblPesqFeitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            

            #endregion

            cmbPerg.Items.Add(String.Format("Pergunta {0}", a));
            cmbPerg.SelectedIndex = a - 1;
        }

        private void cmbPesquisas_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Pergunta/ ComboBox

            if (cmbPesquisas.SelectedIndex == -1)
            {
                return;
            }
            


            pergunta = new string[10, 2];
            cmbPerg.Items.Clear();

                    string comando = "";
                    comando += "Select pe.cd_pergunta, pe.nm_pergunta from pergunta pe ";
                   comando += "inner join pesquisa ps on pe.cd_pesquisa = ps.cd_pesquisa where ps.nm_pesquisa = '" + cmbPesquisas.SelectedItem.ToString() + "' "; 
                    MySqlCommand dadosPesq = new MySqlCommand(comando, ConexaoLocal);
                    MySqlDataReader dados = dadosPesq.ExecuteReader();
           
                    //while (dados.Read())
                    //{

                    //    Array.Resize(ref pergunta, pergunta.Length + 1);
                    //    pergunta[y] = dados[y].ToString();
                    //    y++;

                    //}
                    for (int y = 0; dados.Read() == true; y++)
                    {
                        pergunta[y, 0] = dados[0].ToString();
                        pergunta[y, 1] = dados[1].ToString();
                        //MessageBox.Show(pergunta[y,0] + " " + pergunta[y,1]);
                    }
                    dados.Close();

                    btnAddPerg.Visible = false;

            
            for (int i = 0; i < pergunta.Length; i++)
            {
                if (pergunta[i,0] == null)
                    break;
                else
                    cmbPerg.Items.Add(String.Format("Pergunta {0}", (i + 1)));
                //cmbPerg.Items.Add(pergunta[i]);

            }
            cmbPerg.SelectedIndex = 0;

            //string 

            #endregion   
        }

        #region Criar pergunta CMB
        private void btnAddPerg_Click(object sender, EventArgs e)
        {
            if (txtPergunta.Text == "")
            {
                MessageBox.Show("Insira a pergunta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPergunta.Focus();
                return;
            }

            if (!((txtAA.Text != "" && txtAB.Text != "") || (txtAA.Text != "" && txtAC.Text != "") || (txtAA.Text != "" && txtAD.Text != "") || (txtAA.Text != "" && txtAE.Text != "") || (txtAB.Text != "" && txtAC.Text != "") || (txtAD.Text != "" && txtAB.Text != "") || (txtAE.Text != "" && txtAB.Text != "") || (txtAC.Text != "" && txtAD.Text != "") || (txtAC.Text != "" && txtAE.Text != "") || (txtAD.Text != "" && txtAE.Text != "")))
            {
                MessageBox.Show("Insira pelo menos duas Alternativas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAA.Focus();
                return;
            }


           

                if (cmbPerg.Items.Count < 10)
                {
                    cmbPerg.Items.Add(String.Format("Pergunta {0}", cmbPerg.Items.Count + 1));
                    cmbPerg.SelectedIndex = cmbPerg.Items.Count - 1;
                    txtPergunta.Focus();
                    txtAA.Text = "";
                    txtAB.Text = "";
                    txtAC.Text = "";
                    txtAD.Text = "";
                    txtAE.Text = ""; 
                                
                }
                else
                {
                    MessageBox.Show("Apenas 10 perguntas são permitidas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            
            
        }
        #endregion


        private void cmbPerg_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (pergunta[cmbPerg.SelectedIndex, 1] == null)
            {
                txtPergunta.Text = "";
                return;
            }
            else
            {
                txtPergunta.Text = pergunta[cmbPerg.SelectedIndex, 1];
            }

            if (cmbPesquisas.SelectedIndex == -1)
            {
                if (pergunta[cmbPerg.SelectedIndex, 1] == null)
                {
                    txtPergunta.Text = "";
                }
                else
                {
                    txtPergunta.Text = pergunta[cmbPerg.SelectedIndex, 1];
                    
                }

                    txtAA.Text = AlternInsert[cmbPerg.SelectedIndex, 0];
                    txtAB.Text = AlternInsert[cmbPerg.SelectedIndex, 1];
                    txtAC.Text = AlternInsert[cmbPerg.SelectedIndex, 2];
                    txtAD.Text = AlternInsert[cmbPerg.SelectedIndex, 3];
                    txtAE.Text = AlternInsert[cmbPerg.SelectedIndex, 4];

               

                if (AlternInsert[cmbPerg.SelectedIndex, 0] == null)
                {
                    txtAA.Text = "";
                }
                else
                {
                    txtAA.Text = AlternInsert[cmbPerg.SelectedIndex, 0];
                }
                if (AlternInsert[cmbPerg.SelectedIndex, 1] == null)
                {
                    txtAB.Text = "";
                }
                else
                {
                    txtAB.Text = AlternInsert[cmbPerg.SelectedIndex, 1];
                }
                if (AlternInsert[cmbPerg.SelectedIndex, 2] == null)
                {
                    txtAC.Text = "";
                }
                else
                {
                    txtAC.Text = AlternInsert[cmbPerg.SelectedIndex, 2];
                }
                if (AlternInsert[cmbPerg.SelectedIndex, 3] == null)
                {
                    txtAD.Text = "";
                }
                else
                {
                    txtAD.Text = AlternInsert[cmbPerg.SelectedIndex, 3];
                }
                if (AlternInsert[cmbPerg.SelectedIndex, 4] == null)
                {
                    txtAE.Text = "";
                }
                else
                {
                    txtAE.Text = AlternInsert[cmbPerg.SelectedIndex, 4];
                }
                

                return;
            }

            #region Alternativas

            alternativa = new string[5];
            string comando = "select nm_alternativa from alternativa where cd_pergunta = " + pergunta[cmbPerg.SelectedIndex, 0];
            MySqlCommand dadosAltern = new MySqlCommand(comando, ConexaoLocal);
            MySqlDataReader dados = dadosAltern.ExecuteReader();
            int d = 0;
            while (dados.Read())
            {
                alternativa[d] = dados[0].ToString();
                d++;
            }
            dados.Close();

            //MessageBox.Show(alternativa[0]);
            //MessageBox.Show(alternativa[1]);
            //MessageBox.Show(alternativa[2]);

            txtAA.Text = alternativa[0];
            txtAB.Text = alternativa[1];
            txtAC.Text = alternativa[2];
            txtAD.Text = alternativa[3];
            txtAE.Text = alternativa[4];
            txtPergunta.Enabled = false;
            txtAA.Enabled = false;
            txtAB.Enabled = false;
            txtAC.Enabled = false;
            txtAD.Enabled = false;
            txtAE.Enabled = false;


            #endregion
       
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar = true;
            pergunta = new string[10, 2];


            if (tblPesqMarc.RowCount <= 0)
            {
                MessageBox.Show("Não há pesquisas marcadas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tblPesqMarc.CurrentRow == null)
            {
                MessageBox.Show("Selecione em Pesquisas Marcadas a pesquisa a ser editada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int linha = tblPesqMarc.CurrentRow.Index;
            string data = tblPesqMarc.Rows[linha].Cells[0].Value.ToString();
            string nome = tblPesqMarc.Rows[linha].Cells[1].Value.ToString();
            string Bairro = tblPesqMarc.Rows[linha].Cells[2].Value.ToString();
            data = DateTime.Parse(data).ToShortDateString();

            if (MessageBox.Show("Deseja editar " + nome + " no Bairro " + Bairro + "\nData: " + data + " ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            tabControl1.SelectedTab = tabPage2;
            tabPage2.Text = "Editar Pesquisa";

            btnChamaSelec.Text = "Funcionários Selecionados";
 
          #region Txts e Data
            cmbPesquisas.Enabled = false;
            txtnm_pesquisa.Text = nome;
            txtnm_bairro.Text = Bairro;
            dtPesquisa.Text = data;
          #endregion

          #region Perguntas e Alternativas

            cmbPesquisas.SelectedItem = nome;

            #endregion

            

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            btnChamaSelec.Text = "Selecionar Funcionários";
            a = 1;
            cmbPerg.Items.Clear();
            cmbPerg.Items.Add(String.Format("Pergunta {0}", a));
            cmbPerg.SelectedIndex = a - 1;
            tabControl1.SelectedTab = tabPage2;
            tabPage2.Text = "Marcar Pesquisa";
            txtnm_pesquisa.Clear();
            txtnm_bairro.Clear();
            dtPesquisa.Value = DateTime.Today;
            cmbPesquisas.Enabled = true;
            cmbPesquisas.SelectedIndex = -1;
            editar = false;

            txtAA.Clear();
            txtAB.Clear();
            txtAC.Clear();
            txtAD.Clear();
            txtAE.Clear();
            txtPergunta.Clear();
            txtAA.Enabled = true;
            txtAB.Enabled = true;
            txtAC.Enabled = true;
            txtAD.Enabled = true;
            txtAE.Enabled = true;
            txtPergunta.Enabled = true;
            btnAddPerg.Visible = true;

            pergunta = new string[10, 2];

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string comando = "select dt_pesquisa as 'Data', nm_pesquisa as 'Nome', nm_bairro as 'Bairro'";
            comando += " from pesquisa where nm_pesquisa like '%" + txtBuscar.Text + "%' and ic_pesquisa_feita = false ;";

            //string comando = "select dt_pesquisa as 'Data',nm_pesquisa as 'Nome', nm_bairro as 'Bairro' from pesquisa where ic_pesquisa_feita = true;";
            tblPesqMarc.DataSource = null;
            tblPesqMarc.Rows.Clear();
            tblPesqMarc.Columns.Clear();

            MySqlDataAdapter dadosLocal;
            DataTable tabela;

            dadosLocal = new MySqlDataAdapter(comando, ConexaoLocal);
            tabela = new DataTable();

            dadosLocal.Fill(tabela);


            tblPesqMarc.DataSource = tabela;
            tblPesqMarc.AutoResizeColumns();
            tblPesqMarc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void tblPesqFeitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Apenas as Pesquisas Marcadas podem ser editadas e excluídas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            #region Adquirindo Informações p Delete
            int w = 0;
            cdperg = new string[10];
            cdAltern = new string[100];

            if (tblPesqMarc.RowCount <= 0)
            {
                MessageBox.Show("Para excluir, faça uma busca e selecione o material.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tblPesqMarc.CurrentRow == null)
            {
                MessageBox.Show("Selecione o Material a ser excluído.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int linha = tblPesqMarc.CurrentRow.Index;
            string data = tblPesqMarc.Rows[linha].Cells[0].Value.ToString();
            string nome = tblPesqMarc.Rows[linha].Cells[1].Value.ToString();
            data = trocaData(data);

            if (MessageBox.Show("Deseja REALMENTE excluir " + nome + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            string comando = "";
            comando += "select cd_pesquisa from pesquisa where nm_pesquisa = '" + nome + "' and dt_pesquisa ='" + data + "'; ";
            MySqlCommand cSQL = new MySqlCommand(comando, ConexaoLocal);
            MySqlDataReader cdPesq = cSQL.ExecuteReader();

            cdPesq.Read();
            string codPesq = cdPesq[0].ToString();
            cdPesq.Close();

            comando = "select cd_pergunta from pergunta where cd_pesquisa = " + codPesq + ";";
            cSQL = new MySqlCommand(comando, ConexaoLocal);
            MySqlDataReader cdsPergs = cSQL.ExecuteReader();

            for (int i = 0; cdsPergs.Read() == true ; i++)
            {
                cdperg[i] = cdsPergs[0].ToString();
            }
            cdsPergs.Close();

            for (int i = 0; cdperg[i] != null; i++)
            {
                comando = "select cd_alternativa from alternativa where cd_pergunta = " + cdperg[i] + ";";
                    cSQL = new MySqlCommand(comando, ConexaoLocal);
                    MySqlDataReader cdsAlterns = cSQL.ExecuteReader();
                //do
                //{
                //  cdAltern[w] = cdsAlterns[0].ToString();
                //    w ++;
                //} while (cdsAlterns.Read() == true);

                    for (int p = 0; cdsAlterns.Read() == true; p++)
                    {
                        cdAltern[w] = cdsAlterns[0].ToString();
                        w++;

                    }
                cdsAlterns.Close();
            }
            #endregion

            #region Deleta esta budega
            for (int i = 0; cdAltern[i] != null; i++)
            {
                comando = "delete from alternativa where cd_alternativa = " + cdAltern[i] + ";";

                try
                {
                    cSQL = new MySqlCommand(comando, ConexaoLocal);
                    cSQL.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Não foi possível excluir a pesquisa selecionada, por favor tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            for (int i = 0; cdperg[i] != null; i++)
            {
                comando = "delete from pergunta where cd_pergunta = " + cdperg[i] + ";";

                try
                {
                    cSQL = new MySqlCommand(comando, ConexaoLocal);
                    cSQL.ExecuteNonQuery();
                }
                catch
                {
                    MessageBox.Show("Não foi possível excluir a pesquisa selecionada, por favor tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            comando = "delete from funcionario_pesquisa where cd_pesquisa =" + codPesq + ";";
            string comando2 = "delete from pesquisa where cd_pesquisa =" + codPesq + ";";
            try
            {
                cSQL = new MySqlCommand(comando, ConexaoLocal);
                cSQL.ExecuteNonQuery();
                cSQL = new MySqlCommand(comando2, ConexaoLocal);
                cSQL.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Não foi possível excluir a pesquisa selecionada, por favor tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                frm_Pesquisas_Load(sender, e);
            #endregion

            #region Atualizar grid PesqMarc

            comando = "";
            comando += "select dt_pesquisa as 'Data',nm_pesquisa as 'Nome', nm_bairro as 'Bairro'";
            comando += " from pesquisa where ic_pesquisa_feita = false;";

            tblPesqMarc.DataSource = null;
            tblPesqMarc.Rows.Clear();
            tblPesqMarc.Columns.Clear();

            MySqlDataAdapter dadosLocal;
            DataTable tabela;

            dadosLocal = new MySqlDataAdapter(comando, ConexaoLocal);
            tabela = new DataTable();

            dadosLocal.Fill(tabela);


            tblPesqMarc.DataSource = tabela;
            tblPesqMarc.AutoResizeColumns();
            tblPesqMarc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            #endregion

        }

        private void txtPergunta_TextChanged(object sender, EventArgs e)
        {
            if (cmbPesquisas.SelectedIndex == -1)
            {
                pergunta[cmbPerg.SelectedIndex, 1] = txtPergunta.Text;
            }
        }

        private void btnSavePesq_Click(object sender, EventArgs e)
        {
            string comando = "";
            string data = dtPesquisa.Value.ToShortDateString();
            btnChamaSelec.Text = "Selecionar Funcionários";

            DateTime dataesc = dtPesquisa.Value;
            MySqlCommand cSQL;

            
            
            if (editar)
            {
                try
                {
                    data = trocaData(data);
                    comando = "update pesquisa set nm_pesquisa = '" + txtnm_pesquisa.Text + "', nm_bairro = '" + txtnm_bairro.Text + "', dt_pesquisa = '" + data + "' where cd_pesquisa = " + CdNmPesq[cmbPesquisas.SelectedIndex, 0] + ";";
                    cSQL = new MySqlCommand(comando, ConexaoLocal);
                    cSQL.ExecuteNonQuery();
                    editar = false;

                    comando = "delete from funcionario_pesquisa where cd_pesquisa =" + CdNmPesq[cmbPesquisas.SelectedIndex, 0] + ";";
                    cSQL = new MySqlCommand(comando, ConexaoLocal);
                    cSQL.ExecuteNonQuery();

                    #region Alterar funcionario_pesquisa
                    for (int i = 0; cls_coisas_genericas.FuncionariosPesq[i] != null; i++)
                    {
                        string cdPesquisador = cls_coisas_genericas.FuncionariosPesq[i];
                        comando = "insert into funcionario_pesquisa values ";
                        comando += "('" + cdPesquisador + "', " + CdNmPesq[cmbPesquisas.SelectedIndex, 0] + ");";
                        cSQL = new MySqlCommand(comando, ConexaoLocal);
                        cSQL.ExecuteNonQuery();


                    }
                    cls_coisas_genericas.FuncionariosPesq = new string[10];
                    #endregion

                    cls_coisas_genericas.FuncionariosPesq = new string[10];

                    MessageBox.Show("Editado com sucesso", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtnm_pesquisa.Clear();
                    txtnm_bairro.Clear();
                    dtPesquisa.Value = DateTime.Today;
                    cmbPesquisas.SelectedIndex = -1;
                    a = 1;
                    cmbPerg.Items.Clear();
                    cmbPerg.Items.Add(String.Format("Pergunta {0}", a));
                    cmbPerg.SelectedIndex = a - 1;
                    txtPergunta.Clear();
                    txtAA.Clear();
                    txtAB.Clear();
                    txtAC.Clear();
                    txtAD.Clear();
                    txtAE.Clear();

                    btnChamaSelec.Text = "Selecionar Funcionários";

                    return;
                }
                catch
                {
                    MessageBox.Show("Não foi possível editar a pergunta, Por Favor tente novamente", "Tente Novamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            comando = "select cd_pesquisa from pesquisa where nm_pesquisa = '" + txtnm_pesquisa.Text + "'; ";
            cSQL = new MySqlCommand(comando, ConexaoLocal);
            MySqlDataReader validpesq = cSQL.ExecuteReader();
            if (validpesq.Read())
            {
                MessageBox.Show("Uma pesquisa com este nome já existe, escolha outro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnm_pesquisa.Focus();

                return;
            }
            validpesq.Close();

            #region Validações
            if (txtnm_pesquisa.Text == "" || txtnm_bairro.Text == "")
            {
                MessageBox.Show("Preencha corretamente os campos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPergunta.Text == "")
            {
                MessageBox.Show("Insira a pergunta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPergunta.Focus();
                return;
            }

            if (!((txtAA.Text != "" && txtAB.Text != "") || (txtAA.Text != "" && txtAC.Text != "") || (txtAA.Text != "" && txtAD.Text != "") || (txtAA.Text != "" && txtAE.Text != "") || (txtAB.Text != "" && txtAC.Text != "") || (txtAD.Text != "" && txtAB.Text != "") || (txtAE.Text != "" && txtAB.Text != "") || (txtAC.Text != "" && txtAD.Text != "") || (txtAC.Text != "" && txtAE.Text != "") || (txtAD.Text != "" && txtAE.Text != "")))
            {
                MessageBox.Show("Insira pelo menos duas Alternativas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAA.Focus();
                return;
            }
            if (cls_coisas_genericas.FuncionariosPesq[0] == null || cls_coisas_genericas.FuncionariosPesq[0] == "")
            {
                MessageBox.Show("Selecione os pesquisadores que realizarão esta Pesquisa.", "Pesquisadores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnChamaSelec_Click(sender, e);
                 return;
            }
            if (dataesc < DateTime.Today)
            {
                MessageBox.Show("Não é permitido datas anteriores a hoje para a pesquisa", "Data Incorreta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
#endregion

            #region Próximo Código
            string NovoCodigoPesq = "";
           


            comando = "Select max(cd_pesquisa)+1 from pesquisa";
            try
            {
            cSQL = new MySqlCommand(comando, ConexaoLocal);
                MySqlDataReader dados = cSQL.ExecuteReader();
                if (dados.Read())
                {
                    if (dados[0].ToString() == "" || dados[0].ToString() == null)
                    {
                        NovoCodigoPesq = "1";
                    }
                    else
                    {
                        NovoCodigoPesq = dados[0].ToString();
                    }
                }
                dados.Close();

            #endregion

            #region Inserir Pesquisa
          
                data = trocaData(data);

                comando = "insert into pesquisa values ";
                comando += "(" + NovoCodigoPesq + ", '" + txtnm_pesquisa.Text + "', '" + txtnm_bairro.Text + "', '" + data + "', false)";

                cSQL = new MySqlCommand(comando, ConexaoLocal);
                cSQL.ExecuteNonQuery();
            
                #endregion

            #region Inserir Perguntas e Alternativas

            comando = "Select max(cd_pergunta)+1 from pergunta";
             int NovoCodigoPerg = 0;
               MySqlCommand cSQL2 = new MySqlCommand(comando, ConexaoLocal);
                MySqlDataReader dados2 = cSQL2.ExecuteReader();
                if (dados2.Read())
                {
                    if (dados2[0].ToString() == "" || dados2[0].ToString() == null)
                    {
                        NovoCodigoPerg = 1;
                    }
                    else
                    {
                        NovoCodigoPerg = int.Parse(dados2[0].ToString());
                    }
                }
                dados2.Close();

                for (int i = 0; pergunta[i,1] != null; i++)
                {
                    comando = "insert into pergunta values";
                    comando += " (" + (NovoCodigoPerg + i) + ", '" + pergunta[i, 1] + "', " + NovoCodigoPesq + ")";
                    cSQL2 = new MySqlCommand(comando, ConexaoLocal);
                    cSQL2.ExecuteNonQuery();
                    for (int i2 = 0; i2 < 5; i2++)
                    {
                        if (AlternInsert[i, i2] == "" || AlternInsert[i, i2] == null)
                        {

                        }
                        else
                        {
                            comando = "Select max(cd_alternativa)+1 from alternativa";
                            int NovoCodigoAltern = 0;
                            cSQL2 = new MySqlCommand(comando, ConexaoLocal);
                            dados2 = cSQL2.ExecuteReader();
                            if (dados2.Read())
                            {
                                if (dados2[0].ToString() == "" || dados2[0].ToString() == null)
                                {
                                    NovoCodigoAltern = 1;
                                }
                                else
                                {
                                    NovoCodigoAltern = int.Parse(dados2[0].ToString());
                                }
                            }
                            dados2.Close();

                            comando = "insert into alternativa values ";
                            comando += "(" + NovoCodigoAltern + ", '" + AlternInsert[i, i2] + "', " + (NovoCodigoPerg + i) + ", " + NovoCodigoPesq + ")";
                            cSQL2 = new MySqlCommand(comando, ConexaoLocal);
                            cSQL2.ExecuteNonQuery();
                        }
                    }
                }
            #endregion

            #region Inserir funcionario_pesquisa
                for (int i = 0; cls_coisas_genericas.FuncionariosPesq[i] != null ; i++)
                {
                    string cdPesquisador = cls_coisas_genericas.FuncionariosPesq[i];
                    comando = "insert into funcionario_pesquisa values ";
                    comando += "('" + cdPesquisador + "', " + NovoCodigoPesq + ");";
                    cSQL2 = new MySqlCommand(comando, ConexaoLocal);
                    cSQL2.ExecuteNonQuery();

                    
                }
                cls_coisas_genericas.FuncionariosPesq = new string[10];
                #endregion

            }
            catch
            {
                MessageBox.Show("Não foi possível salvar a pesquisa, tente novamente", "Tente novamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                frm_Pesquisas_Load(sender, e);
            MessageBox.Show("Salvo com sucesso", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtnm_pesquisa.Clear();
            txtnm_bairro.Clear();
            dtPesquisa.Value = DateTime.Today;
            cmbPesquisas.SelectedIndex = -1;
            a = 1;
            cmbPerg.Items.Clear();
            cmbPerg.Items.Add(String.Format("Pergunta {0}", a));
            cmbPerg.SelectedIndex = a - 1;
            txtPergunta.Clear();
            txtAA.Clear();
            txtAB.Clear();
            txtAC.Clear();
            txtAD.Clear();
            txtAE.Clear();

            }

        #region Configurando alternativas s/ referencia
        private void txtAA_TextChanged(object sender, EventArgs e)
        {
            if (cmbPesquisas.SelectedIndex == -1)
            {
                AlternInsert[cmbPerg.SelectedIndex, 0] = txtAA.Text;
            }
        }

        private void txtAB_TextChanged(object sender, EventArgs e)
        {
            if (cmbPesquisas.SelectedIndex == -1)
            {
                AlternInsert[cmbPerg.SelectedIndex, 1] = txtAB.Text;
            }
        }

        private void txtAC_TextChanged(object sender, EventArgs e)
        {
            if (cmbPesquisas.SelectedIndex == -1)
            {
                AlternInsert[cmbPerg.SelectedIndex, 2] = txtAC.Text;
            }
        }

        private void txtAD_TextChanged(object sender, EventArgs e)
        {
            if (cmbPesquisas.SelectedIndex == -1)
            {
                AlternInsert[cmbPerg.SelectedIndex, 3] = txtAD.Text;
            }
        }

        private void txtAE_TextChanged(object sender, EventArgs e)
        {
            if (cmbPesquisas.SelectedIndex == -1)
            {
                AlternInsert[cmbPerg.SelectedIndex, 4] = txtAE.Text;
            }
        }

        
       

        

        #endregion

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }












    }
}
