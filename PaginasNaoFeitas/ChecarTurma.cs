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
    public partial class ChecarTurma : Form
    {
        private Form1 main;
        public ChecarTurma()
        {
            InitializeComponent();
        }
        public ChecarTurma(Form1 x)
        {
            InitializeComponent();
            main = x;
        }

        private void ChecarTurma_Load(object sender, EventArgs e)
        {
            foreach (Turma x in ControllerTurma.turmas)
            {
                comboBox1.Items.Add(x.Nome);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
