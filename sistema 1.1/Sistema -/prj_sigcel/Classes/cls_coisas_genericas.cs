using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace prj_sigcel
{
    class cls_coisas_genericas
    {

        public static string nm_funcionario { get; set; }
        public static string cd_cpf_funcionario { get; set; }
        public static string nm_email_funcionario { get; set; }
        public static string nm_endereco_funcionario { get; set; }
        public static string nm_celular_funcionario { get; set; }
        public static string nm_funcao { get; set; }

        public static string FuncionarioAtual { get; set; }
        public static string cd_material_editar { get; set; }
        public static string nm_material_editar { get; set; }
        public static string qt_material_editar { get; set; }

        public static DataTable trocartabelas { get; set; }
        public static bool msgAtualizar { get; set; }

        public static void AtualizarGrid(MySqlConnection Conexao)
        {
            MySqlConnection ConexaoLocal = Conexao;
            string comando = "";

            comando += "Select cd_material as 'Código', nm_material as 'Nome', qt_atual as 'Quantidade Atual' from material ";




            MySqlDataAdapter dadosLocal;
            DataTable tabela;

            dadosLocal = new MySqlDataAdapter(comando, ConexaoLocal);
            tabela = new DataTable();

            dadosLocal.Fill(tabela);
            trocartabelas = tabela;
        }

        public bool VerificaSeTemNaTBL(string nome, DataGridView tabela, int coluna)
        {
            bool Existe = false;


            string axu;
            for (int i = 0; i < tabela.Rows.Count; i++)
            {
                axu = tabela.Rows[i].Cells[coluna].Value.ToString();
                if (axu == nome)
                {
                    Existe = true;
                    break;
                }

            }
            return Existe;
        }

        public static string[] FuncionariosPesq = new string[10];

        public static string FuncSelec { get; set; }

        


    }
}
