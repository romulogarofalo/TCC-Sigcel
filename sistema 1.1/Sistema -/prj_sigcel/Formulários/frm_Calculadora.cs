using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj_sigcel
{
    public partial class frm_Calculadora : Form
    {
        #region Variáveis
        double valor = 0;
        string operacao = "";
        bool operacao_apertada = false;
        #endregion

        public frm_Calculadora()
        {
            InitializeComponent();
        }

        #region Fechar
        private void imgSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Clique dos botões
        private void btnPonto_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (operacao_apertada))
                txtResult.Clear();
            operacao_apertada = false;
            Button b = (Button)sender;
            if (b.Text == ".")
            {
                if (!txtResult.Text.Contains("."))
                    txtResult.Text = txtResult.Text + b.Text;
            }
            else
                txtResult.Text = txtResult.Text + b.Text;
        }

        #endregion

        #region Botão "CE" - Limpar
        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }
        #endregion

        #region Operações matemáticas
        private void operacao_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (valor != 0)
            {
                if (b.Text == "√¯")
                    txtResult.Text = Math.Sqrt(Double.Parse(txtResult.Text)).ToString();
                btnIgual.PerformClick();
                operacao_apertada = true;
                operacao = b.Text;
                equacao.Text = valor + " " + operacao;
            }
            else if (b.Text == "√¯")
            {
                txtResult.Text = Math.Sqrt(Double.Parse(txtResult.Text)).ToString();
                valor = Math.Sqrt(Double.Parse(txtResult.Text));
            }
            else
            {
                operacao = b.Text;
                valor = double.Parse(txtResult.Text);
                operacao_apertada = true;
                equacao.Text = valor + " " + operacao;
            }
        }
        #endregion

        #region Solução
        private void btnIgual_Click(object sender, EventArgs e)
        {
            equacao.Text = "";
            switch (operacao)
            {
                case "+":
                    txtResult.Text = (valor + double.Parse(txtResult.Text)).ToString();
                    break;
                case "-":
                    txtResult.Text = (valor - double.Parse(txtResult.Text)).ToString();
                    break;
                case "*":
                    txtResult.Text = (valor * double.Parse(txtResult.Text)).ToString();
                    break;
                case "/":
                    txtResult.Text = (valor / double.Parse(txtResult.Text)).ToString();
                    break;
                default:
                    break;
            }//fim do switch

            try
            {
                valor = Int64.Parse(txtResult.Text);
                operacao = "";
            }
            catch
            {
                //MessageBox.Show("Formato incorreto, refaça a operação");
                txtResult.Text = "Formato incorreto";
                //txtResult.Text
                equacao.Text = "";
            }
        }
        #endregion

        #region Botão "C" Limpar
        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            valor = 0;
            equacao.Text = "";
        }
        #endregion
    }
}
