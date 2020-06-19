using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaginasNaoFeitas
{
    public partial class ChecarPessoas : Form
    {
        private Form1 main;
        public ChecarPessoas()
        {
            InitializeComponent();
        }
        public ChecarPessoas(Form1 x)
        {
            InitializeComponent();
            main = x;
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = "";
            Pessoa selecionado = ControllerPessoas.GetPessoa(comboBox2.Text);
            label3.Text += selecionado.Nome;
            label3.Text += "\n";
            label3.Text = "Páginas não feitas:";
            label3.Text += "\n";

            foreach (int x in selecionado.paginasNaoFeitas)
            {
                label3.Text += x.ToString();
                label3.Text += "\n";
            }
        }

        private void ChecarPessoas_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Visible = true;
            main.Show();
        }

        private void ChecarPessoas_Load(object sender, EventArgs e)
        {
            foreach (Turma x in ControllerTurma.turmas)
            {
                comboBox1.Items.Add(x.Nome);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            label3.Text = "";
            foreach (Pessoa x in ControllerPessoas.GetPessoas(comboBox1.Text))
            {
                comboBox2.Items.Add(x.Nome);
            }
        }
    }
}
