using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComDadosEstruturados
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

            double media = calculaMedia(aluno);

            String passou;
            if (verificaSePassou(aluno))
            {
                passou = "passou";
            }
            else
            {
                passou = "não passou";
            }

            Console.WriteLine("O aluno {0} {1} com média {2:F1}.\n", aluno.nome, passou, media);
        }

        static double calculaMedia(Aluno aluno)
        {
            double media = (aluno.p1 + aluno.p2) / 2;

            return media;
        }

        static bool verificaSePassou(Aluno aluno)
        {
            bool passou;

            double media = calculaMedia(aluno);

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

    class Aluno
    {
        public string nome;
        public double p1, p2;
    }
}
