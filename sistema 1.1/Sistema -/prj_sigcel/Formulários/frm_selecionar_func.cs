using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;


namespace prj_sigcel.Formulários
{
    public partial class frm_selecionar_func : Form
    {
        cls_coisas_genericas C = new cls_coisas_genericas();
        MySqlConnection ConexaoLocal;
        public frm_selecionar_func(MySqlConnection Conexao)
        {
            InitializeComponent();
            ConexaoLocal = Conexao;
        }

        private void frm_selecionar_func_Load(object sender, EventArgs e)
        {
            

            string comando = "";
            comando += "select cd_cpf_funcionario as 'CPF' ,nm_funcionario as 'Pesquisadores' from funcionario where cd_funcao = 7 ;";

            tblFunc.DataSource = null;
            tblFunc.Rows.Clear();
            tblFunc.Columns.Clear();

            MySqlDataAdapter dadosLocal;
            DataTable tabela;

            dadosLocal = new MySqlDataAdapter(comando, ConexaoLocal);
            tabela = new DataTable();

            dadosLocal.Fill(tabela);


            tblFunc.DataSource = tabela;
            tblFunc.AutoResizeColumns();
            tblFunc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tblFunc.RowCount <= 0)
            {
                MessageBox.Show("Não há pesquisadores disponíveis.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tblFunc.CurrentRow == null)
            {
                MessageBox.Show("Selecione a Urna a ser selecionada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int linha = tblFunc.CurrentRow.Index;
            string CPF = tblFunc.Rows[linha].Cells[0].Value.ToString();
            string nome = tblFunc.Rows[linha].Cells[1].Value.ToString();

            if (!C.VerificaSeTemNaTBL(nome, tblFuncA, 1))
            {
                tblFuncA.Rows.Add(CPF,nome);
            }
            tblFunc.Rows.RemoveAt(linha);
            tblFunc.AutoResizeColumns();
            tblFunc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tblFuncA.AutoResizeColumns();
            tblFuncA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (tblFuncA.RowCount <= 0)
            {
                MessageBox.Show("Nenhum pesquisador selecionado. Impossível remover da lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tblFuncA.CurrentRow == null)
            {
                MessageBox.Show("Selecione o pesquisador a ser excluído da lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int linha = tblFuncA.CurrentRow.Index;
            string nome = tblFuncA.Rows[linha].Cells[0].Value.ToString();

           
            tblFuncA.Rows.RemoveAt(linha);
            tblFuncA.AutoResizeColumns();
            tblFuncA.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tblFunc.AutoResizeColumns();
            tblFunc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void btnSalvar_Click(object sender, EventArgs e)
        {
            cls_coisas_genericas.FuncionariosPesq = new string[10];
            if (tblFuncA.RowCount <= 0)
            {
                MessageBox.Show("Selecione o(s) pesquisador(es) que realizará(ão) esta pesquisa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            for (int i = 0; i < tblFuncA.Rows.Count ; i++)
            {

                cls_coisas_genericas.FuncionariosPesq[i] = tblFuncA.Rows[i].Cells[0].Value.ToString();
                
               // MessageBox.Show(cls_coisas_genericas.FuncionariosPesq[i, 0] + " - " + cls_coisas_genericas.FuncionariosPesq[i, 1]);
            }
           
            MessageBox.Show("Salvo com sucesso", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        
   
    }
}
