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
    public partial class frm_materiais_eventos : Form
    {
        MySqlConnection ConexaoLocal;

        public frm_materiais_eventos(MySqlConnection conexao)
        {
            InitializeComponent();
            ConexaoLocal = conexao;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
          
        }
        int qtAtual;
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            
            tblMaterialSelecionado.Rows.Add(cmbMaterial.SelectedItem, txtQuantidade.Text);
            cmbMaterial.SelectedIndex.ToString();

            string Cselect = "select qt_atual from material where nm_material ='panfleto';";

            MySqlCommand cSQL = new MySqlCommand(Cselect, ConexaoLocal);
            MySqlDataReader dados= cSQL.ExecuteReader();
            if (dados.Read())
            {
                qtAtual = int.Parse(dados[0].ToString());
                if (qtAtual > int.Parse(txtQuantidade.Text))
                {

                }
                else
                {
                    MessageBox.Show("Não há material suficiente peça menos", "Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    dados.Close();
                    return;
                }
                dados.Close();
            }

        }

        private void frm_materiais_eventos_Load(object sender, EventArgs e)
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

        private void btnGravar_Click(object sender, EventArgs e)
        {

            //string data;
           // string comandoInsrt = "";
            string comandoUpd = "";
            string material = "";
            int quantidade = 0;
            for (int i = 0; i < tblMaterialSelecionado.Rows.Count; i++)
            {
                material = tblMaterialSelecionado.Rows[i].Cells[0].Value.ToString();
                quantidade = int.Parse(tblMaterialSelecionado.Rows[i].Cells[1].Value.ToString());
            //    comandoInsrt = "insert into material_compromisso";
                quantidade = qtAtual - quantidade;
                comandoUpd = "update set qt_atual = "+quantidade+" where nm_material = '"+material+"';";
                // mandar para alguma variavel que depois faça o insert de tudo 

            }



        }
    }
}
