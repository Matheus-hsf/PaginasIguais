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
    public partial class CadPessoas : Form
    {
        public static Form1 main;
        public CadPessoas()
        {
            InitializeComponent();
        }
        public CadPessoas(Form1 x)
        {
            InitializeComponent();
            main = x;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void CadPessoas_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            foreach (Turma x in ControllerTurma.turmas)
            {
                comboBox1.Items.Add(x.Nome);
            }
>>>>>>> checar
        }

        private void CadPessoas_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Visible = true;
            main.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            main.Show();
            main.Visible = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
            if (textBox1.Text == "")
            {
                MessageBox.Show("Por favor insira o nome");
            }
            else if (comboBox1.Text == "" || comboBox1.Text == null)
            {
                MessageBox.Show("Por favor selecione uma turma, caso não seja possível, por favor cadastre uma nova turma");
            }
            else
            {
                Pessoa x = new Pessoa(textBox1.Text);
                x.Turma = comboBox1.Text;
                List<int> nmr = new List<int>();
                string queVem = "";
                foreach (char vv in textBox2.Text)
                {
                    if (vv.ToString() != ",")
                    {
                        if (vv.ToString() != " ")
                        {
                            queVem += vv.ToString();
                        }
                    }
                    else
                    {
                        if (queVem != "")
                        {
                            nmr.Add(Int32.Parse(queVem));
                        }
                        queVem = "";
                    }
                }
                nmr.Add(Int32.Parse(queVem));

                x.SetPaginas(nmr);

                ControllerPessoas.listaDePessoas.Add(x);

                MessageBox.Show("A pessoa '" + textBox1.Text + "' foi cadastrada");

                main.Show();
                main.Visible = true;
                this.Close();
            }
        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != ' '))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
>>>>>>> checar

        }
    }
}
