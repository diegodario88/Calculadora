using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{

    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calculadora de Notas" + "\n" + "Criação 13/03/2018" + "\n" + "Autor: Diego R. P. Dario" + "\n" + "Versão: beta");
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selecionarArquivo.ShowDialog();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            Valores valor = new Valores();
            valor.nota1 = Convert.ToInt32(txtNota1.Text);
            valor.nota2 = Convert.ToInt32(txtNota2.Text);
            valor.nota3 = Convert.ToInt32(txtNota3.Text);
            valor.nota4 = Convert.ToInt32(txtNota4.Text);
            valor.resultado = (valor.nota1 + valor.nota2 + valor.nota3 + valor.nota4) / 4;
            lblMedia.Text = valor.resultado.ToString();


            if (valor.resultado >= 60)
            {

                btnResultado.Text = "Aprovado";
                btnResultado.BackColor = Color.ForestGreen;
            }
            else
            {
                btnResultado.Text = "Reprovado";
                btnResultado.BackColor = Color.Red;
            }
        }
    }
}
