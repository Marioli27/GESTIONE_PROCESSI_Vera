using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=0 , numero1 = 1 ,soma =0;
            Console.WriteLine("Inscerisci il primo numero");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inscerisci il secondo numero");
            numero1 = Convert.ToInt32(Console.ReadLine());
            soma = numero + numero1;
            Console.WriteLine("somma = " + soma);
            Console.ReadLine();

        }
    }
}
