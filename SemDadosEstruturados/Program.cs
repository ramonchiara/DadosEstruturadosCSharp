using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemDadosEstruturados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            String nome = Console.ReadLine();

            Console.Write("P1: ");
            double p1 = double.Parse(Console.ReadLine());

            Console.Write("P2: ");
            double p2 = double.Parse(Console.ReadLine());

            double media = calculaMedia(p1, p2);

            String passou;
            if (verificaSePassou(p1, p2))
            {
                passou = "passou";
            }
            else
            {
                passou = "não passou";
            }

            Console.WriteLine("O aluno {0} {1} com média {2:F1}.\n", nome, passou, media);
        }

        static double calculaMedia(double p1, double p2)
        {
            double media = (p1 + p2) / 2;

            return media;
        }

        static bool verificaSePassou(double p1, double p2)
        {
            bool passou;

            double media = calculaMedia(p1, p2);

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
