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
    public partial class ConsultarPaginas : Form
    {
        private Form1 main;
        public ConsultarPaginas()
        {
            InitializeComponent();
        }
        public ConsultarPaginas(Form1 x)
        {
            InitializeComponent();
            main = x;
        }

        private void ConsultarPaginas_Load(object sender, EventArgs e)
        {
            foreach (Turma x in ControllerTurma.turmas)
            {
                comboBox1.Items.Add(x.Nome);
            }
        }

        private void ConsultarPaginas_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Visible = true;
            main.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ControllerPessoas.GetPessoas(comboBox1.Text).Count > 0)
            {
                List<int> iguais = new List<int>();
                List<int> envia = new List<int>();

                foreach (int nmrs in ControllerPessoas.GetPessoas(comboBox1.Text)[0].paginasNaoFeitas)
                {
                    for (int i = 1; i < ControllerPessoas.GetPessoas(comboBox1.Text).Count; i++)
                    {
                        foreach (int v in ControllerPessoas.GetPessoas(comboBox1.Text)[i].paginasNaoFeitas)
                        {
                            if (nmrs == v)
                            {
                                iguais.Add(nmrs);
                                break;
                            }
                        }
                    }
                }

                foreach (Pessoa pe in ControllerPessoas.GetPessoas(comboBox1.Text))
                {
                    foreach (int i in iguais)
                    {
                        if (!pe.paginasNaoFeitas.Contains(i))
                        {
                            iguais = iguais.Where(val => val != i).ToList();
                        }
                    }
                }


                envia = iguais.Distinct().ToList();

                foreach (int x in envia)
                {
                    label2.Text += x.ToString();
                    label2.Text += "\n";
                }
            }
        }
    }
}
