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


namespace prj_sigcel
{
    public partial class frm_adicionar_material : Form
    {
        #region Conexão Local
        MySqlConnection ConexaoLocal;
        public bool editar { get; set; }

        public frm_adicionar_material(MySqlConnection Conexao)
        {
            InitializeComponent();
            ConexaoLocal = Conexao;
        }
        #endregion

        #region Load
        private void frm_adicionar_material_Load(object sender, EventArgs e)
        {
           

            txt_nm_material.Focus();


            if (editar)
            {
                this.Text = "Editar Material";
                try
                {

                   
                        txt_nm_material.Text = cls_coisas_genericas.nm_material_editar;
                        txt_qt_material.Text = cls_coisas_genericas.qt_material_editar;

                }
                catch
                {
                    MessageBox.Show("Não é possível editar o material selecionado, tenter novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();
                }
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

                if (editar)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Não foi possível adicionar um novo material, tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nm_material.Focus();
            }
            
        }
        #endregion

        #region Cancelar
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo cancelar?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

    }
}
