using System;

namespace AMS_Ex6_22
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura = 1.90;
            double pesoIdeal = (72.7 * altura) - 58;

            Console.WriteLine("");
            Console.WriteLine("         ***CÁLCULO DO PESO IDEAL DE UM HOMEM***      ");
        
            Console.WriteLine($"O peso ideal desse homem de acordo com a sua altura é {pesoIdeal} Kg");
            Console.WriteLine("");
        }
    }
}
