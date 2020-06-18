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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void IrProCadPessoa()
        {
            this.Visible = false;
            this.Hide();
            CadPessoas x = new CadPessoas(this);
            x.Visible = true;
            x.StartPosition = FormStartPosition.CenterScreen;
        }
        public void IrProCadTurma()
        {
            this.Visible = false;
            this.Hide();
            CadTurmas x = new CadTurmas(this);
            x.Visible = true;
            x.StartPosition = FormStartPosition.CenterScreen;
        }
        public void IrProCheckTurma()
        {
            this.Visible = false;
            this.Hide();
            ChecarTurma x = new ChecarTurma(this);
            x.Visible = true;
            x.StartPosition = FormStartPosition.CenterScreen;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            IrProCadPessoa();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IrProCadTurma();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IrProCheckTurma();
        }
    }
}
