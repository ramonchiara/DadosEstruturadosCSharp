using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome: ");
            aluno.nome = Console.ReadLine();

            Console.Write("P1: ");
            aluno.p1 = double.Parse(Console.ReadLine());

            Console.Write("P2: ");
            aluno.p2 = double.Parse(Console.ReadLine());

            double media = aluno.calculaMedia();

            String passou;
            if (aluno.verificaSePassou())
            {
                passou = "passou";
            }
            else
            {
                passou = "não passou";
            }

            Console.WriteLine("O aluno {0} {1} com média {2:F1}.\n", aluno.nome, passou, media);
        }
    }

    class Aluno
    {
        public string nome;
        public double p1, p2;

        public double calculaMedia()
        {
            double media = (p1 + p2) / 2;

            return media;
        }

        public bool verificaSePassou()
        {
            bool passou;

            double media = calculaMedia();

            if (media >= 7)
            {
                passou = true;
            }
            else
            {
                passou = false;
            }

            return passou;
        }
    }
}
