using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosParesEImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero: ");
            long numero = Convert.ToInt64(Console.ReadLine());
            long sobrante = numero % 2; //residuo al dividir el numero en 2
            if (sobrante == 0)
            {
                Console.WriteLine(numero + ", El numero es par.");
            }
            else 
            {
                Console.WriteLine(numero + ", El numero es impar.");
            }
            Console.ReadKey();
        }
    }
}
