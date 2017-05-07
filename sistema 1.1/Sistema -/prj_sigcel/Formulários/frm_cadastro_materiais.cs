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
    public partial class frm_cadastro_materiais : Form
    {
        bool editar;
        cls_coisas_genericas f = new cls_coisas_genericas();

        #region Conexão Local
        MySqlConnection ConexaoLocal;

        public frm_cadastro_materiais(MySqlConnection conexao)
        {
            InitializeComponent();
            ConexaoLocal = conexao;
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region Adicionar
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            frm_adicionar_material cadastro = new frm_adicionar_material(ConexaoLocal);
            cadastro.editar = false;
            cadastro.ShowDialog();
        }
        #endregion

        #region Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                if (MessageBox.Show("Sem filtro a busca pode levar algum tempo.\nDeseja continuar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

                string comando = "";
                comando += "Select cd_material as 'Código', nm_material as 'Nome', qt_atual as 'Quantidade Atual' from material ";
                if (txtBuscar.Text != "")
                {
                    comando += "Where nm_material like '%" + txtBuscar.Text + "%' ;";
                }

               
                    tblMateriais.DataSource = null;
                    tblMateriais.Rows.Clear();
                    tblMateriais.Columns.Clear();

                    MySqlDataAdapter dadosLocal;
                    DataTable tabela;

                    dadosLocal = new MySqlDataAdapter(comando, ConexaoLocal);
                    tabela = new DataTable();

                        dadosLocal.Fill(tabela);


                        tblMateriais.DataSource = tabela;
                        tblMateriais.AutoResizeColumns();
                        tblMateriais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        

        }

        #endregion

        private void frm_cadastro_materiais_Load(object sender, EventArgs e)
        {
            txtBuscar.Focus();
        }

        #region Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tblMateriais.RowCount <= 0)
            {
                MessageBox.Show("Faça uma busca e selecione o material a ser editado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tblMateriais.CurrentRow == null)
            {
                MessageBox.Show("Selecione o Material a ser editado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int linha = tblMateriais.CurrentRow.Index;
            string codigo = tblMateriais.Rows[linha].Cells[0].Value.ToString();
            string nome = tblMateriais.Rows[linha].Cells[1].Value.ToString();
            string qt_atual = tblMateriais.Rows[linha].Cells[2].Value.ToString();

            if (MessageBox.Show("Deseja editar o material " + nome + " selecionado ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
             cls_coisas_genericas.cd_material_editar = codigo;
             txt_nm_material.Text = nome;
             txt_qt_material.Text = qt_atual;
             editar = true;

            #region Atualizar Grid
            //cls_coisas_genericas.AtualizarGrid(ConexaoLocal);
            //tblMateriais.DataSource = null;
            //tblMateriais.Rows.Clear();
            //tblMateriais.Columns.Clear();
            //tblMateriais.DataSource = cls_coisas_genericas.trocartabelas;
            //tblMateriais.AutoResizeColumns();
            //tblMateriais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            #endregion

        }
        #endregion

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            if (tblMateriais.RowCount <= 0)
            {
                MessageBox.Show("Para excluir, faça uma busca e selecione o material.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (tblMateriais.CurrentRow == null)
            {
                MessageBox.Show("Selecione o Material a ser excluído.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int linha = tblMateriais.CurrentRow.Index;
            string codigo = tblMateriais.Rows[linha].Cells[0].Value.ToString();
            string nome = tblMateriais.Rows[linha].Cells[1].Value.ToString();


            if (MessageBox.Show("Deseja REALMENTE excluir o Material " + nome + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            #region Valida se material pode ser excluido
            MySqlCommand cSQL = new MySqlCommand("Select cd_material from material_compromisso where cd_material = " + codigo + " ;", ConexaoLocal);
            MySqlDataReader MaterialEmUso = cSQL.ExecuteReader();

            if (MaterialEmUso.Read())
            {
                MessageBox.Show("Material está vinculado a um evento. Impossível excluí-lo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MaterialEmUso.Close();
                return;
            }
            MaterialEmUso.Close();
            #endregion

            #region Exclui Material
            string comando;
            comando = "Delete from material where cd_material = " + codigo + " ;";

            try
            {
                cSQL = new MySqlCommand(comando, ConexaoLocal);
                cSQL.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Não foi possível excluir o material selecionado, por favor tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("O material foi excluido com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            #endregion

            if (MessageBox.Show("Deseja atualizar a lista?\nPode levar algum tempo.", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            #region Atualizar Grid
            tblMateriais.DataSource = null;
            tblMateriais.Rows.Clear();
            tblMateriais.Columns.Clear();
            tblMateriais.DataSource = cls_coisas_genericas.trocartabelas;
            tblMateriais.AutoResizeColumns();
            tblMateriais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            #endregion

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Salvar
            txt_nm_material.Focus();
            if (txt_nm_material.Text == "" || txt_qt_material.Text == "")
            {
                MessageBox.Show("Preencha corretamente os campos");
                txt_nm_material.Focus();
                return;
            }
            string comando = "";
            MySqlCommand cSQL;
            try
            {
                if (!editar)
                {
                    #region Próximo Código
                    string NovoCodigo = "";
                    comando = "Select max(cd_material)+1 from material";
                    cSQL = new MySqlCommand(comando, ConexaoLocal);
                    MySqlDataReader dados = cSQL.ExecuteReader();
                    if (dados.Read())
                    {
                        if (dados[0].ToString() == "" || dados[0].ToString() == null)
                        {
                            NovoCodigo = "1";
                        }
                        else
                        {
                            NovoCodigo = dados[0].ToString();
                        }
                    }
                    dados.Close();
                    #endregion

                    #region Insert
                    int qt = int.Parse(txt_qt_material.Text);
                    string nome = txt_nm_material.Text;
                    comando = "insert into material values (" + NovoCodigo + ", '" + nome + "' , " + qt + ");";

                    #endregion

                }
                else
                {

                    #region Comando UpDate
                    comando = "";
                    comando += "Update material set nm_material = '" + txt_nm_material.Text + "', ";
                    comando += "qt_atual = " + txt_qt_material.Text + " where cd_material = " + cls_coisas_genericas.cd_material_editar + " ;";
                    #endregion
                }

                cSQL = new MySqlCommand(comando, ConexaoLocal);
                cSQL.ExecuteNonQuery();
                MessageBox.Show("Material salvo com sucesso", "Gravado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                editar = false;
            }
            catch
            {
                MessageBox.Show("Não foi possível adicionar um novo material, tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nm_material.Focus();
            }


            
        }
        #endregion

        #region Salvar
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            
            if (txt_nm_material.Text == "" || txt_qt_material.Text == "")
            {
                MessageBox.Show("Preencha corretamente os campos");
                txt_nm_material.Focus();
                return;
            }
            string comando = "";
            MySqlCommand cSQL;
            try
            {
                if (!editar)
                {
                    #region Próximo Código
                    string NovoCodigo = "";
                    comando = "Select max(cd_material)+1 from material";
                    cSQL = new MySqlCommand(comando, ConexaoLocal);
                    MySqlDataReader dados = cSQL.ExecuteReader();
                    if (dados.Read())
                    {
                        if (dados[0].ToString() == "" || dados[0].ToString() == null)
                        {
                            NovoCodigo = "1";
                        }
                        else
                        {
                            NovoCodigo = dados[0].ToString();
                        }
                    }
                    dados.Close();
                    #endregion

                    #region Insert
                    int qt = int.Parse(txt_qt_material.Text);
                    string nome = txt_nm_material.Text;
                    comando = "insert into material values (" + NovoCodigo + ", '" + nome + "' , " + qt + ");";

                    #endregion

                }
                else
                {

                    #region Comando UpDate
                    comando = "";
                    comando += "Update material set nm_material = '" + txt_nm_material.Text + "', ";
                    comando += "qt_atual = " + txt_qt_material.Text + " where cd_material = " + cls_coisas_genericas.cd_material_editar + " ;";
                    #endregion
                }

                cSQL = new MySqlCommand(comando, ConexaoLocal);
                cSQL.ExecuteNonQuery();
                MessageBox.Show("Material salvo com sucesso", "Gravado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Não foi possível adicionar um novo material, tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nm_material.Focus();
            }
        }
        #endregion

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                if (MessageBox.Show("Sem filtro a busca pode levar algum tempo.\nDeseja continuar???", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            string comando = "";
            comando += "Select cd_material as 'Código', nm_material as 'Nome', qt_atual as 'Quantidade Atual' from material ";
            if (txtBuscar.Text != "")
            {
                comando += "Where nm_material like '%" + txtBuscar.Text + "%' ;";
            }


            tblMateriais.DataSource = null;
            tblMateriais.Rows.Clear();
            tblMateriais.Columns.Clear();

            MySqlDataAdapter dadosLocal;
            DataTable tabela;

            dadosLocal = new MySqlDataAdapter(comando, ConexaoLocal);
            tabela = new DataTable();

            dadosLocal.Fill(tabela);


            tblMateriais.DataSource = tabela;
            tblMateriais.AutoResizeColumns();
            tblMateriais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
         
        }
    }
}
