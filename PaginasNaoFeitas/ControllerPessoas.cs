using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginasNaoFeitas
{
    class ControllerPessoas
    {
        public static List<Pessoa> listaDePessoas = new List<Pessoa>();


        public static List<Pessoa> GetPessoas(string nomeDaTurma)
        {
            List<Pessoa> pessoasDaClasse = new List<Pessoa>();

            foreach (Pessoa item in ControllerPessoas.listaDePessoas)
            {
                if (item.Turma == nomeDaTurma)
                {
                    pessoasDaClasse.Add(item);
                }
            }

            return pessoasDaClasse;

        }

        public static Pessoa GetPessoa(string nomeDaPessoa)
        {
            foreach (Pessoa item in listaDePessoas)
            {
                if (item.Nome == nomeDaPessoa)
                {
                    return item;
                }
            }

            return null;
        }


    }




}
