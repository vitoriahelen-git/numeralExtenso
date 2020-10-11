using System;
using Humanizer; 

namespace numeralExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Numero Extenso");
            Console.Write("Digite um numero: "); 
            numero =  Convert.ToInt32 (Console.ReadLine());
            Console.Write($"{numero.ToWords()}");


        }
    }
}
