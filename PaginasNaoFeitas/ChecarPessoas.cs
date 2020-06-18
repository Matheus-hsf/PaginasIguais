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


        private void ChecarPessoas_Load(object sender, EventArgs e)
        {
            foreach (Turma x in ControllerTurma.turmas)
            {
                comboBox1.Items.Add(x.Nome);
            }
        }
    }
}
