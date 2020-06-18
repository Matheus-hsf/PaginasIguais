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
            foreach (Turma x in ControllerTurma.turmas)
            {
                comboBox1.Items.Add(x.Nome);
            }
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
            Pessoa x = new Pessoa(textBox1.Text);
            x.Turma = comboBox1.SelectedText;
            List<int> nmr = new List<int>();
            string queVem = "";
            label1.Text = textBox2.Text;
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
            //x.SetPaginas(nmr.ToArray());

            x.SetPaginas(nmr);

            ControllerPessoas.listaDePessoas.Add(x);
            foreach (int item in nmr)
            {
                MessageBox.Show(item.ToString()/*textBox1.Text + " foi cadastrado"*/);
            }

            main.Show();
            main.Visible = true;
            this.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
