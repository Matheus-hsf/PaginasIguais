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

        }
    }
}
