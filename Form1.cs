using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppNotas
{
    public partial class Form1 : Form
    {
        double media;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double notaUm = double.Parse(txtNotaUm.Text);
            double notaDois = double.Parse(txtNotaDois.Text);
            double notaTres = double.Parse(txtNotaTres.Text);

            media = (notaUm + notaDois + notaTres)/3;

            lblMedia.Text = media.ToString("F2");
        }

        private void btnSituasao_Click(object sender, EventArgs e)
        {
            if (media >= 6)
            {
                lblSituasao.Text = "APROVADO";
                lblSituasao.ForeColor = Color.Blue;
            }
            else
            {
                lblSituasao.Text = "REPROVADO";
                lblSituasao.ForeColor = Color.Red;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNotaUm.Clear();
            txtNotaDois.Clear();
            txtNotaTres.Clear();

            txtNotaUm.Focus();

            lblMedia.Text = "0";
            lblSituasao.Text = "SITUAÇÃO";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
