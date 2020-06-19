using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginasNaoFeitas
{
    class Pessoa
    {
        private string turma;
        private string nome;
        public List<int> paginasNaoFeitas;

        public Pessoa()
        {

        }
        public Pessoa(string nomeNome)
        {
            nome = nomeNome;
        }
        public Pessoa(string nomeNome, string nomeTurma)
        {
            nome = nomeNome;
            turma = nomeTurma;
        }
        public Pessoa(string nomeNome, string nomeTurma, int[] nmrs)
        {
            nome = nomeNome;
            turma = nomeTurma;
            foreach (int x in nmrs)
            {
                this.paginasNaoFeitas.Add(x);
            }
        }



        public string Turma
        {
            get { return turma; }
            set { turma = value; }
        }
        public string Nome
        {
            get{return nome;}
            set{nome = value;}
        }

        public void SetPaginas(int[] nmrs)
        {
            foreach (int x in nmrs)
            {
                this.paginasNaoFeitas.Add(x);
            }
        }
        public void SetPaginas(List<int> x)
        {
            this.paginasNaoFeitas = x;
        }

    }
}
