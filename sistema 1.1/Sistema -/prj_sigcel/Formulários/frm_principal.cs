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
using System.Net;
using System.Net.Mail;

namespace prj_sigcel
{
    public partial class frm_Principal : Form
    {
        MySqlConnection Connection;
        bool ic_situacao;

        public frm_Principal()
        {
            InitializeComponent();
        }

        public void FazerLogin()
        {
            frm_login frmL = new frm_login(Connection);
            frmL.ShowDialog();
            if (cls_coisas_genericas.FuncionarioAtual != "")
                lbl_logado.Text = cls_coisas_genericas.FuncionarioAtual;
            else
                lbl_logado.Text = "";
        }

        #region FormLoad
        private void frm_Principal_Load(object sender, EventArgs e)
        {
            #region Conexão com o Banco de dados
            string stringConexao = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=sigcel";
            lbl_logado.Text = "";
            try
            {
                Connection = new MySqlConnection(stringConexao);
                Connection.Open();
                ic_situacao = true;



                //string dataAtual = DateTime.Now.ToString();


                //#region Declaração de Variáveis
                //string remetente = "";
                //string senha = "";
                //string destinatario = "";
                //string assunto = "";
                //string texto = "";
                //#endregion

                //#region Atribuição dos Valores
                //remetente = "sigceletec@gmail.com";
                //senha = "sigcel123";
                //destinatario = "romulogarofalo@gmail.com";


                //assunto = "";// select no banco quando colocar o nome do evento
                //texto = "";// tira tambem do select no banco 
                //#endregion

                //#region Configurações do Remetente ( GMAIL )
                //SmtpClient client = new SmtpClient();
                //client.Credentials = new NetworkCredential(remetente, senha);

                // //GMAIL
                //client.Host = "smtp.gmail.com";
                //client.Port = 587;
                //client.EnableSsl = true;

                ////HOTMAIL
                ////client.Host = "smtp.live.com";
                ////client.Port = 465;
                ////client.EnableSsl = false;
                //#endregion

                //#region Configuração do Email
                //MailMessage mail = new MailMessage();
                //mail.To.Add(destinatario);
                //mail.From = new MailAddress(remetente, "Sigcel", Encoding.UTF8);
                //mail.Subject = assunto;
                //mail.SubjectEncoding = Encoding.UTF8;
                //mail.Body = "<html><body><b><i>" + texto + "</i></b></body></html>";
                //mail.BodyEncoding = System.Text.Encoding.UTF8;
                //mail.IsBodyHtml = true;
                //mail.Priority = MailPriority.High;
                //#endregion

                //#region Envio do Email
                //try
                //{
                //    client.Send(mail);
                //}
                //catch
                //{
                //    MessageBox.Show("erro no envio dos emails");
                //}
                //#endregion




                FazerLogin();

            }
            catch
            {
                MessageBox.Show("Ocorreu um erro de conexão com o Banco de Dados. Por favor verifique a rede e tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
            #endregion
            // frm_login frmlo = new frm_login();
            // frmlo.ShowDialog();
        }
        #endregion

        #region Clique "Funcionário"
        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_cadastro_funcionario cad_func;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frm_cadastro_funcionario))
                {
                    childForm.Focus();
                    return;
                }
            }
            cad_func = new frm_cadastro_funcionario(Connection);
            cad_func.MdiParent = this;
            cad_func.Show();
        }
        #endregion
        #region Clique "Pesquisa"
        private void pesquisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Pesquisas frmpesq;
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == typeof(frm_Pesquisas))
                {
                    childForm.Focus();
                    return;
                }
            }
            frmpesq = new frm_Pesquisas(Connection);
            frmpesq.MdiParent = this;
            frmpesq.Show();
        }
        #endregion
        #region Clique "Eventos"
        private void eentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_eventos frm_even;
            foreach (Form childform in this.MdiChildren)
            {
                if (childform.GetType() == typeof(frm_eventos))
                {
                    childform.Focus();
                    return;
                }
            }
            frm_even = new frm_eventos(Connection);
            frm_even.MdiParent = this;
            frm_even.Show();
        }
        #endregion
        #region Clique "Gráficos"
        private void graficosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_graficos frmgra;
            foreach (Form formaFilhote in this.MdiChildren)
            {
                if (formaFilhote.GetType() == typeof(frm_graficos))
                {
                    formaFilhote.Focus();
                    return;
                }
            }
            frmgra = new frm_graficos(Connection);
            frmgra.MdiParent = this;
            frmgra.Show();
        }
        #endregion
        #region Data e Hora (Form Principal)
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
            lblData.Text = DateTime.Now.ToShortDateString();
        }
        #endregion
        #region Aplicação "Calculadora"
        private void imgAppCalc_Click(object sender, EventArgs e)
        {
            frm_Calculadora frmCalc;
            foreach (Form formaFilhote in this.MdiChildren)
            {
                if (formaFilhote.GetType() == typeof(frm_Calculadora))
                {
                    formaFilhote.Focus();
                    return;
                }
            }
            frmCalc = new frm_Calculadora();
            frmCalc.MdiParent = this;
            frmCalc.Show();
        }
        #endregion
        #region Aplicação "Calendário"
        private void imgAppCalendario_Click(object sender, EventArgs e)
        {
            frm_calendario frmCalend;
            foreach (Form formaFilhote in this.MdiChildren)
            {
                if (formaFilhote.GetType() == typeof(frm_calendario))
                {
                    formaFilhote.Focus();
                    return;
                }
            }
            frmCalend = new frm_calendario();
            frmCalend.MdiParent = this;
            frmCalend.Show();
        }
        #endregion
        #region Aplicação "Configurações"
        private void imgAppConfig_Click(object sender, EventArgs e)
        {
            pnlConfig.Show();
            pnl_backup.Visible = false;
        }
        #endregion
        #region Fechar "Configurações"
        private void imgSair_Click(object sender, EventArgs e)
        {
            pnlConfig.Hide();
        }
        #endregion
        #region MouseEnter & MouseLeave (Alteração da cor dos títulos dos menus)
        private void eentosToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            eentosToolStripMenuItem.ForeColor = Color.Black;
        }

        private void eentosToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            eentosToolStripMenuItem.ForeColor = Color.White;
        }

        private void pesquisaToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            pesquisaToolStripMenuItem.ForeColor = Color.Black;
        }

        private void pesquisaToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            pesquisaToolStripMenuItem.ForeColor = Color.White;
        }

        private void graficosToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            graficosToolStripMenuItem.ForeColor = Color.Black;
        }

        private void graficosToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            graficosToolStripMenuItem.ForeColor = Color.White;
        }

        private void testeToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            testeToolStripMenuItem.ForeColor = Color.Black;
        }

        private void testeToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            testeToolStripMenuItem.ForeColor = Color.White;
        }

        private void materiaisToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            materiaisToolStripMenuItem.ForeColor = Color.Black;
        }

        private void materiaisToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            materiaisToolStripMenuItem.ForeColor = Color.White;
        }
        #endregion
        #region Trocar usuário (Abre tela de login)
        private void trocarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // frm_Principal frmPrincipal = new frm_Principal();
           // frmPrincipal.Close();
           // frm_login frmLogin = new frm_login();
           // frmLogin.ShowDialog();
        }
        #endregion
        #region Encerrar Programa
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region Altera cor dos botões de logout
        private void btnTrocarUser_MouseEnter(object sender, EventArgs e)
        {
            btnTrocarUser.BackColor = Color.Gray;
            label3.BackColor = Color.Gray;
            pbLogout.BackColor = Color.Gray;
        }

        private void btnTrocarUser_MouseLeave(object sender, EventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#2F323A");
            btnTrocarUser.BackColor = color;
            label3.BackColor = color;
            pbLogout.BackColor = color;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BackColor = Color.Gray;
            btnTrocarUser.BackColor = Color.Gray;
            pbLogout.BackColor = Color.Gray;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#2F323A");
            label3.BackColor = color;
            btnTrocarUser.BackColor = color;
            pbLogout.BackColor = color;
        }

        private void pbLogout_MouseEnter(object sender, EventArgs e)
        {
            btnTrocarUser.BackColor = Color.Gray;
            label3.BackColor = Color.Gray;
            pbLogout.BackColor = Color.Gray;
        }

        private void pbLogout_MouseLeave(object sender, EventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#2F323A");
            btnTrocarUser.BackColor = color;
            label3.BackColor = color;
            pbLogout.BackColor = color;
        }

        private void btnEncerrar_MouseEnter(object sender, EventArgs e)
        {
            btnEncerrar.BackColor = Color.Gray;
            label8.BackColor = Color.Gray;
            pbExit.BackColor = Color.Gray;
        }

        private void btnEncerrar_MouseLeave(object sender, EventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#2F323A");
            btnEncerrar.BackColor = color;
            label8.BackColor = color;
            pbExit.BackColor = color;
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            btnEncerrar.BackColor = Color.Gray;
            label8.BackColor = Color.Gray;
            pbExit.BackColor = Color.Gray;
        }

        private void label8_MouseLeave(object sender, EventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#2F323A");
            btnEncerrar.BackColor = color;
            label8.BackColor = color;
            pbExit.BackColor = color;
        }

        private void pbExit_MouseEnter(object sender, EventArgs e)
        {
            btnEncerrar.BackColor = Color.Gray;
            label8.BackColor = Color.Gray;
            pbExit.BackColor = Color.Gray;
        }

        private void pbExit_MouseLeave(object sender, EventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#2F323A");
            btnEncerrar.BackColor = color;
            label8.BackColor = color;
            pbExit.BackColor = color;
        }
        #endregion
        #region Clique "Logout" (Aparecer opções)
        private void lblLogout_Click(object sender, EventArgs e)
        {
            if (pnlOpcoesLogout.Visible == true)
            {
                pnlOpcoesLogout.Visible = false;
            }
            else
            {
                pnlOpcoesLogout.Visible = true;
            }
            return;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (pnlOpcoesLogout.Visible == true)
            {
                pnlOpcoesLogout.Visible = false;
            }
            else
            {
                pnlOpcoesLogout.Visible = true;
            }
            return;
        }

        private void pnlLogout_Click(object sender, EventArgs e)
        {
            if (pnlOpcoesLogout.Visible == true)
            {
                pnlOpcoesLogout.Visible = false;
            }
            else
            {
                pnlOpcoesLogout.Visible = true;
            }
            return;
        }
        #endregion
        #region Clique "Materiais"
        private void materiaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulários.frm_cadastro_materiais frm_cad_materiais;
            foreach (Form miniformizinho in this.MdiChildren)
            {
                if (miniformizinho.GetType() == typeof(Formulários.frm_cadastro_materiais))
                {
                    miniformizinho.Focus();
                    return;
                }
            }
            frm_cad_materiais = new Formulários.frm_cadastro_materiais(Connection);
            frm_cad_materiais.MdiParent = this;
            frm_cad_materiais.Show();
        }
        #endregion
        #region Altera cor dos aplicativos (Hover ícones)
        private void imgAppCalc_MouseEnter(object sender, EventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#c2e0ff");
            imgAppCalc.BackColor = color;
            Color CorBorda = System.Drawing.ColorTranslator.FromHtml("#c2e0ff");
            pnlBorda1.BackColor = CorBorda;
            Color CorBordaExt = System.Drawing.ColorTranslator.FromHtml("#3399ff");
            pnlBordaExt1.BackColor = CorBordaExt;
            label1.ForeColor = Color.Black;
        }

        private void imgAppCalc_MouseLeave(object sender, EventArgs e)
        {
            imgAppCalc.BackColor = Color.Gray;
            Color CorBorda = Color.Gray;//System.Drawing.ColorTranslator.FromHtml("#2f323a");
            pnlBorda1.BackColor = CorBorda;
            pnlBordaExt1.BackColor = CorBorda;
            label1.ForeColor = Color.White;
        }

        private void imgAppCalendario_MouseEnter(object sender, EventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#c2e0ff");
            imgAppCalendario.BackColor = color;
            Color CorBorda = System.Drawing.ColorTranslator.FromHtml("#c2e0ff");
            pnlBorda2.BackColor = CorBorda;
            Color CorBordaExt = System.Drawing.ColorTranslator.FromHtml("#3399ff");
            pnlBordaExt2.BackColor = CorBordaExt;
            label2.ForeColor = Color.Black;
        }

        private void imgAppCalendario_MouseLeave(object sender, EventArgs e)
        {
            imgAppCalendario.BackColor = Color.Gray;
            Color CorBorda = Color.Gray;//System.Drawing.ColorTranslator.FromHtml("#2f323a");
            pnlBorda2.BackColor = CorBorda;
            pnlBordaExt2.BackColor = CorBorda;
            label2.ForeColor = Color.White;
        }

        private void imgAppBackup_MouseEnter(object sender, EventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#c2e0ff");
            imgAppBackup.BackColor = color;
            Color CorBorda = System.Drawing.ColorTranslator.FromHtml("#c2e0ff");
            pnlBorda3.BackColor = CorBorda;
            Color CorBordaExt = System.Drawing.ColorTranslator.FromHtml("#3399ff");
            pnlBordaExt3.BackColor = CorBordaExt;
            lblBackup.ForeColor = Color.Black;
        }

        private void imgAppBackup_MouseLeave(object sender, EventArgs e)
        {
            imgAppBackup.BackColor = Color.Gray;
            Color CorBorda = Color.Gray;//System.Drawing.ColorTranslator.FromHtml("#2f323a");
            pnlBorda3.BackColor = CorBorda;
            pnlBordaExt3.BackColor = CorBorda;
            lblBackup.ForeColor = Color.White;
        }

        private void imgAppConfig_MouseEnter(object sender, EventArgs e)
        {
            Color color = System.Drawing.ColorTranslator.FromHtml("#c2e0ff");
            imgAppConfig.BackColor = color;
            Color CorBorda = System.Drawing.ColorTranslator.FromHtml("#c2e0ff");
            pnlBorda4.BackColor = CorBorda;
            Color CorBordaExt = System.Drawing.ColorTranslator.FromHtml("#3399ff");
            pnlBordaExt4.BackColor = CorBordaExt;
            label4.ForeColor = Color.Black;
        }

        private void imgAppConfig_MouseLeave(object sender, EventArgs e)
        {
            imgAppConfig.BackColor = Color.Gray;
            Color CorBorda = Color.Gray;//System.Drawing.ColorTranslator.FromHtml("#2f323a");
            pnlBorda4.BackColor = CorBorda;
            pnlBordaExt4.BackColor = CorBorda;
            label4.ForeColor = Color.White;
        }
        #endregion
        #region Clique "backup"
        private void imgAppBackup_Click(object sender, EventArgs e)
        {
            pnl_backup.Visible = true;
            pnl_backup.Location = new Point(328, 218);
            pnlConfig.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pnl_backup.Visible = false;
        }

        private void btn_exportar_dados_Click(object sender, EventArgs e)
        {
            dialog_export.ShowDialog();
        }

        private void btn_importar_dados_Click(object sender, EventArgs e)
        {
            dialog_import.ShowDialog();
        }
        #endregion

        private void frm_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ic_situacao)
            {
                ic_situacao = false;
                Connection.Close();
            }
            // falta um if para saber se a conexao foi aberta e fechar apenas se for aberta pq se n da erro
        }



    }
}
