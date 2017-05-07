using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace prj_sigcel.Formulários
{
    public partial class frm_func_selecionados : Form
    {
        MySqlConnection ConexaoLocal;
        public frm_func_selecionados(MySqlConnection Conexao)
        {
            InitializeComponent();
            ConexaoLocal = Conexao;
        }

        string comando = "";

        private void frm_func_selecionados_Load(object sender, EventArgs e)
        {
            comando = "select f.cd_cpf_funcionario as 'Cpf',f.nm_funcionario as 'Nome' from funcionario f inner join funcionario_pesquisa fp on f.cd_cpf_funcionario = fp.cd_cpf_funcionario where fp.cd_pesquisa = " + cls_coisas_genericas.FuncSelec + "; ";

            tblFuncSelecionados.DataSource = null;
            tblFuncSelecionados.Rows.Clear();
            tblFuncSelecionados.Columns.Clear();

            MySqlDataAdapter dadosLocal;
            DataTable tabela;

            dadosLocal = new MySqlDataAdapter(comando, ConexaoLocal);
            tabela = new DataTable();

            dadosLocal.Fill(tabela);


            tblFuncSelecionados.DataSource = tabela;
            tblFuncSelecionados.AutoResizeColumns();
            tblFuncSelecionados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.Close();

            frm_selecionar_func selecionar = new frm_selecionar_func(ConexaoLocal);
            selecionar.ShowDialog();
        }
    }
}
