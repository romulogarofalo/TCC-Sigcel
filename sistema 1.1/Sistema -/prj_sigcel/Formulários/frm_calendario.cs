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
    public partial class frm_calendario : Form
    {
        public frm_calendario()
        {
            InitializeComponent();
        }

        private void Calendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.Location = new Point(233, 200);
            this.Size = new Size(582, this.Size.Height - 0);
            pnlAgenda.Visible = true;
            label2.Font = new Font("Verdana", 14);
            label2.Location = new Point(2, 5);
            txtNome.Focus();
        }

        private void imgSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
