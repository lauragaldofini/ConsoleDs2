using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número");
            double um = Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            double dois = Console.ReadLine());

            Console.WriteLine("Digite a operação");
            string operacao = Console.ReadLine());

            switch (operacao)
            {
                case "+":
                    double result = um + dois;
                    Console.WriteLine("O resultado é:" + result);
                    break;
                case "-":
                    double result2 = um - dois;
                    Console.WriteLine("O resultado é:" + result2);
                    break;
                case "/":
                    double result3 = um / dois;
                    Console.WriteLine("O resultado é:" + result3);
                    break;
                case "*":
                    double result4 = um * dois;
                    Console.WriteLine("O resultado é:" + result4);
                    break;
  }
            Console.ReadKey();
        }
    }
}
