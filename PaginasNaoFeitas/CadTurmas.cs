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
    public partial class CadTurmas : Form
    {
        public static Form1 main;

        public CadTurmas()
        {
            InitializeComponent();
        }
        public CadTurmas(Form1 x)
        {
            InitializeComponent();
            main = x;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main.Visible = true;
            main.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Turma x = new Turma();
            x.Nome = textBox1.Text;
            x.hora = comboBox1.SelectedText.ToString();
            x.minuto = comboBox2.SelectedText.ToString();
            ControllerTurma.turmas.Add(x);
            MessageBox.Show("Classe " + x.Nome + " cadastrado com sucesso!");
            this.Close();
=======
            if (textBox1.Text == "" || textBox1.Text == " ")
            {
                MessageBox.Show("Por favor insira o nome da turma");
            }
            else if (comboBox1.Text == "" || comboBox1.Text == null || comboBox2.Text == "" || comboBox2.Text == null)
            {
                MessageBox.Show("Por favor insira o hora e minutos da turma");
            }
            else
            {
                Turma x = new Turma();
                x.Nome = textBox1.Text;
                x.hora = comboBox1.SelectedText.ToString();
                x.minuto = comboBox2.SelectedText.ToString();
                ControllerTurma.turmas.Add(x);
                MessageBox.Show("Classe " + x.Nome + " cadastrado com sucesso!");
                this.Close();
            }
>>>>>>> checar
        }

        private void CadTurmas_FormClosed(object sender, FormClosedEventArgs e)
        {
            main.Visible = true;
            main.Show();
        }

        private void CadTurmas_Load(object sender, EventArgs e)
        {

        }
    }
}
