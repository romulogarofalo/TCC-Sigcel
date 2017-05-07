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
    public partial class frm_graficos : Form
    {
        MySqlConnection ConexaoLocal;
        public frm_graficos(MySqlConnection conexao)
        {
            InitializeComponent();

            ConexaoLocal = conexao;
        }
        #region botao fechar
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion 

        private void btn_verGraficoGrande_Click(object sender, EventArgs e)
        {
            Formulários.frm_graficoGrande frmgraficoGrande = new Formulários.frm_graficoGrande();

            frmgraficoGrande.ShowDialog();
        }

        private void frm_graficos_Load(object sender, EventArgs e)
        {
            // trocar a maneira de selecionar as pesquisas 
            cmbEscolaridade.SelectedIndex = 0;
            cmbFaixaSalarial.SelectedIndex = 0;
            cmbIdade.SelectedIndex = 0;
            cmbSexo.SelectedIndex = 0;

            string strgselect = "select nm_pesquisa from pesquisa ";// "where ic_pesquisa_feita = true";

            try
            {
                MySqlCommand Csql = new MySqlCommand(strgselect, ConexaoLocal);
                MySqlDataReader dadinhos = Csql.ExecuteReader();
                while (dadinhos.Read())
                {
                    cmb_bananinha.Items.Add(dadinhos[0].ToString());
                   // cmbReferencia.Items.Add(dadinhos[0].ToString());
                }
                dadinhos.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao estabelecer uma conexão com o banco de dados","Erro");
            }

        }

        private void btnCarregarPesq_Click(object sender, EventArgs e)
        {

            try
            {
                lbxPesquisas.Items.Clear();
                cmb_perguntas.Items.Clear();
                lbxPesquisas.Items.Add(cmb_bananinha.SelectedItem);
                string pesquisaSelecionada = cmb_bananinha.SelectedItem.ToString();
                string slctPerguntas = "select p.nm_pergunta from pergunta p join pesquisa pe on p.cd_pesquisa = pe.cd_pesquisa where pe.nm_pesquisa = '"+pesquisaSelecionada+"'";

                MySqlCommand Csql = new MySqlCommand(slctPerguntas, ConexaoLocal);
                MySqlDataReader dadinhos = Csql.ExecuteReader();
                while (dadinhos.Read())
                {
                    cmb_perguntas.Items.Add(dadinhos[0].ToString());
                }
                dadinhos.Close();

                cmb_perguntas.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao estabelecer uma, conexão com o banco de dados", "Erro"); 
            }
        }
        bool Excel = false;

        #region Botao Gera Grafico
        private void btnGeraGrafico_Click(object sender, EventArgs e)
        {
            if (Excel)
            {
                #region Grafico Excel
                for (int x = 0; x < Grafico.Series.Count; x++)
                {
                    Grafico.Series[x].Points.Clear();
                }

                int i = 0;

                while (Convert.ToString(tblEleitores.Rows[i].Cells[4].Value) != "")
                {
                    lst_Respostas.Items.Add(Convert.ToString(tblEleitores.Rows[i].Cells[4].Value));
                    i++;
                }
                for (i = 0; i < lst_Respostas.Items.Count; i++)
                {
                    if (i == 0)
                        lst_Alternativas.Items.Add(lst_Respostas.Items[i]);
                    else
                    {
                        bool teste = true;
                        for (int I = 0; I < lst_Alternativas.Items.Count; I++)
                        {
                            if (lst_Alternativas.Items[I].ToString() == lst_Respostas.Items[i].ToString())
                                teste = false;
                        }
                        if (teste)
                        {
                            lst_Alternativas.Items.Add(lst_Respostas.Items[i]);
                        }
                    }
                }
                for (i = 0; i < lst_Alternativas.Items.Count; i++)
                {
                    lst_Qt_Alternativa.Items.Add("0");
                }
                for (int I = 0; I < lst_Alternativas.Items.Count; I++)// aq
                {
                    for (i = 0; i < lst_Respostas.Items.Count; i++)
                    {
                        if (lst_Alternativas.Items[I].ToString() == lst_Respostas.Items[i].ToString())
                        {
                            int n = int.Parse(lst_Qt_Alternativa.Items[I].ToString());
                            n = n + 1;
                            lst_Qt_Alternativa.Items[I] = n.ToString();
                        }
                    }
                }
                for (i = 0; i < lst_Alternativas.Items.Count; i++)
                {

                }
                for (i = 0; i < lst_Alternativas.Items.Count; i++)
                {
                    Grafico.Series[0].Points.AddXY(lst_Alternativas.Items[i], int.Parse(lst_Qt_Alternativa.Items[i].ToString()));
                    Grafico.Series[0].LegendText = lst_Alternativas.Items[i].ToString();
                }
                //AQ ACABA OQ EU FIZ
                //MATEUS
                //for (int y = 0; y < tblEleitores.Rows.Count; y++)
                //{
                //    string resultado = Convert.ToString(tblEleitores.Rows[i].Cells[4].Value);
                //    if (Convert.ToString(tblEleitores.Rows[y].Cells[4].Value) == "boa")
                //        countBoa++;
                //    if (Convert.ToString(tblEleitores.Rows[y].Cells[4].Value) == "media")
                //        countMedia++;
                //    if (Convert.ToString(tblEleitores.Rows[y].Cells[4].Value) == "ruim")
                //        countRuim++;
                //}
                //chart1.Series[0].Points.AddXY("Ruim", countRuim);
                //chart1.Series[0].Points.AddXY("Media", countMedia);
                //chart1.Series[0].Points.AddXY("Boa", countBoa); 

                //chart1.Series[0].LegendText = "Segurança";// falta saber de onde veio isso!!!

                Grafico.Visible = true;
                #endregion
                Excel = false;
            }



            string filtro = "";
            if (cmbEscolaridade.SelectedIndex != 0)
            {
                filtro += " and par.cd_escolaridade = " + cmbEscolaridade.SelectedIndex;
            }

            if (cmbIdade.SelectedIndex != 0)
            {
                switch (cmbIdade.SelectedIndex)
                {
                    case 1:
                        filtro += " and par.qt_idade between 16 and 25 ";
                        break;
                    case 2:
                        filtro += " and par.qt_idade between 26 and 35 ";
                        break;
                    case 3:
                        filtro += " and par.qt_idade between 36 and 45 ";
                        break;
                    case 4:
                        filtro += " and par.qt_idade between 46 and 55 ";
                        break;
                    case 5:
                        filtro += " and par.qt_idade > 55 ";
                        break;                
                }
            }
            if (cmbFaixaSalarial.SelectedIndex != 0)
            {
                switch (cmbFaixaSalarial.SelectedIndex)
                {
                                        // Todos
                                        //500 à 1500 reais
                                        //1501 à 2500 reais 
                                        //2501 à 3500 reais
                                        //3501 à 4500 reais
                                        //mais de 4500
                    case 1:
                        filtro += " and par.qt_salario between 500 and 1500 ";
                        break;
                    case 2:
                        filtro += " and par.qt_salario between 1501 and 2500 ";
                        break;
                    case 3:
                        filtro += " and par.qt_salario between 2501 and 3500 ";
                        break;
                    case 4:
                        filtro += " and par.qt_salario between 3501 and 4500 ";
                        break;
                    case 5:
                        filtro += " and par.qt_salario > 4501 ";
                        break;
                }
            }
            if (cmbSexo.SelectedIndex != 0)
            {
                switch(cmbSexo.SelectedIndex)
                {
                    case 1:
                        filtro += " and par.ic_sexo = true ";
                        break;
                    case 2:
                        filtro += " and par.ic_sexo = false ";
                        break;
                    case 3:
                        filtro += " and par.ic_sexo = null ";
                        break;
                }

            }

            Grafico.Series.Clear();
            if (lbxPesquisas.Items.Count > 1)
            {
                foreach (var series in Grafico.Series)
                {
                    series.LegendText = "";
                    series.Points.Clear();
                }
                for (int i = 0; i < lbxPesquisas.Items.Count; i++)
                {
                    lbxPesquisas.SelectedIndex = i;
                    Grafico.Series.Add(lbxPesquisas.SelectedItem.ToString());
                }

                // pegar o nome das pesquisas e perguntas e jogar no select e pegar as coisas nessesarias pra criar o grafico
                // fazer tipo a função la 
                for (int i = 0; i < lbxPesquisas.Items.Count; i++)
                {
                    lbxPesquisas.SelectedIndex = i;
                    string NMpesquisa = lbxPesquisas.SelectedItem.ToString();
                    string NMpergunta = cmb_perguntas.SelectedItem.ToString();
                    string cmdSelects = "Select r.cd_pergunta, p.nm_pergunta, r.cd_alternativa, a.nm_alternativa,count(r.cd_alternativa) from resposta  r join alternativa a on (r.cd_alternativa =a.cd_alternativa) join pergunta p on (r.cd_pesquisa=p.cd_pesquisa and r.cd_pergunta=p.cd_pergunta) join pesquisa pes on (pes.cd_pesquisa = p.cd_pesquisa) join participante par on (par.cd_participante = r.cd_participante) where p.nm_pergunta = '" + NMpergunta + "' and  pes.nm_pesquisa = '" + NMpesquisa + "' "+ filtro +" group by r.cd_pergunta, r.cd_alternativa;";
                    MySqlCommand Csql = new MySqlCommand(cmdSelects, ConexaoLocal);
                    MySqlDataReader dadinhos = Csql.ExecuteReader();
                    lbxPesquisas.SelectedIndex = 0;
                    if (dadinhos.Read())
                    {
                        //Grafico.Series[i].LegendText = dadinhos[1].ToString();
                        do
                        {

                            Grafico.Series[i].Points.AddXY(dadinhos[3].ToString(), dadinhos[4].ToString());
                        }
                        while (dadinhos.Read());
                    }
                    dadinhos.Close();



                }
               // MessageBox.Show("maior que 1");
                    return;
            }


            string NMpergunta1 = cmb_perguntas.SelectedItem.ToString();
            string NMpesquisa1 = cmb_bananinha.SelectedItem.ToString();
            //string cmdSelect = "Select a.nm_alternativa as 'Alternativa', count(r.cd_alternativa) as 'Quantidade' from resposta  r join alternativa a on (r.cd_alternativa =a.cd_alternativa) join pergunta p on (r.cd_pesquisa=p.cd_pesquisa and r.cd_pergunta=p.cd_pergunta) where p.nm_pergunta = 'Qual a Sua Opinião sobre a Segurança' group by r.cd_pergunta, r.cd_alternativa;";
            //MySqlDataAdapter dados = new MySqlDataAdapter(cmdSelect, ConexaoLocal);
            //DataTable tabela = new DataTable();
            //dados.Fill(tabela);
            //Grafico.DataSource = tabela;
            //Grafico.Visible = true;
            try
            {
                foreach (var series in Grafico.Series)
                {
                    series.LegendText = "";
                    series.Points.Clear();
                }
                string cmdSelect = "";
                if (filtro !="")
                    cmdSelect = "Select r.cd_pergunta, p.nm_pergunta, r.cd_alternativa, a.nm_alternativa,count(r.cd_alternativa) from resposta  r join alternativa a on (r.cd_alternativa =a.cd_alternativa) join pergunta p on (r.cd_pesquisa=p.cd_pesquisa and r.cd_pergunta=p.cd_pergunta) join pesquisa pes on (pes.cd_pesquisa = p.cd_pesquisa) join participante par on (par.cd_participante = r.cd_participante) where p.nm_pergunta = '" + NMpergunta1 + "' and  pes.nm_pesquisa = '" + NMpesquisa1 + "' " + filtro + " group by r.cd_pergunta, r.cd_alternativa;";
                else
                    cmdSelect = "Select r.cd_pergunta, p.nm_pergunta, r.cd_alternativa, a.nm_alternativa,count(r.cd_alternativa) from resposta  r join alternativa a on (r.cd_alternativa =a.cd_alternativa) join pergunta p on (r.cd_pesquisa=p.cd_pesquisa and r.cd_pergunta=p.cd_pergunta) join pesquisa pes on (pes.cd_pesquisa = p.cd_pesquisa) join participante par on (par.cd_participante = r.cd_participante) where p.nm_pergunta = '" + NMpergunta1 + "' and  pes.nm_pesquisa = '" + NMpesquisa1 + "' group by r.cd_pergunta, r.cd_alternativa;";
                MySqlCommand Csql = new MySqlCommand(cmdSelect, ConexaoLocal);
                MySqlDataReader dadinhos = Csql.ExecuteReader();
                lbxPesquisas.SelectedIndex = 0;
                Grafico.Series.Add(lbxPesquisas.SelectedItem.ToString());

                if (dadinhos.Read())
                {
                    Grafico.Series[0].LegendText = dadinhos[1].ToString();
                    do
                    {
                        
                        Grafico.Series[0].Points.AddXY(dadinhos[3].ToString(), dadinhos[4].ToString());
                    }
                    while (dadinhos.Read());
                }
                dadinhos.Close();
                filtro = "";
               // Grafico.Series.Add("pesqusia2");
               // Grafico.Series[1].Points.AddXY("algo","23");

            }
            catch
            {
                MessageBox.Show("erro no grafico");
            }
            

        }
        #endregion


        private bool checaList(ListBox list, string select)
        {
            for (int i = 0; i < list.Items.Count; i++)
            {
                list.SelectedIndex = i;
                if (list.SelectedItem.ToString() == select)
                {
                    return true;
                }
            }
            return false;
        }
        private void btnReferencia_Click(object sender, EventArgs e)
        {
            if (checaList(lbxPesquisas,cmb_bananinha.SelectedItem.ToString()))
            {
                MessageBox.Show("Não é possivel referenciar uma pesquisa repetida, por favor selecione outra pesquisa", "Erro");
                return;
            }

            lbxPesquisas.Items.Add(cmb_bananinha.SelectedItem);
        }

        ListBox lst_Respostas = new ListBox();
        ListBox lst_Alternativas = new ListBox();
        ListBox lst_Qt_Alternativa = new ListBox();

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string mensagem = "Deseja realmente abrir o arquivo para importação?";

            if (MessageBox.Show(mensagem, "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }


            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string caminhoNomeArquivo = openFileDialog1.FileName;
                string nomeArquivo = Path.GetFileName(caminhoNomeArquivo);
            }
            lst_Respostas.Items.Clear();
            lst_Alternativas.Items.Clear();
            lst_Qt_Alternativa.Items.Clear();
            Excel = true;
        }
    }
}
