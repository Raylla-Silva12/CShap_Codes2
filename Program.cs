using System;

namespace l_repeticao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nDesenvolva um programa que mostre na tela a tabuada do 4.\n");
            for (int num = 0; num <= 10; num++)
            {
                Console.WriteLine("4 x " + num + " = " + (4 * num));
            }
            Console.ReadKey();
        }
    }
}
