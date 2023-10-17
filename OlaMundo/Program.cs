using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade minima do estoque.");
            int quantidadeMinima = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade maxima");
            int quantidadeMaxima = int.Parse(Console.ReadLine());
            int Calculo = CalcularMedia(quantidadeMinima, quantidadeMaxima);
            Console.WriteLine("A quantidade Media é de: "+Calculo);
            Console.ReadLine();
        }
        public static int CalcularMedia(int minimo, int max)
        {
            int estoqueMedio = (minimo + max) / 2;
            return estoqueMedio;
        }
    }
}
