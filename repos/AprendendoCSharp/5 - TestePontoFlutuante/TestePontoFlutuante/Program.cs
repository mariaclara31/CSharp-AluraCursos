using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            double peso = 4.0;
            int quantidade = 10;
            Console.WriteLine(peso * quantidade);

            double preco = 5.5;
            int ingressos = 4;
            Console.WriteLine(preco * ingressos);

            int dia = 4;
            int outroDia = 4 + dia;
            Console.WriteLine(outroDia);

            Console.ReadLine();
        }
    }
}
