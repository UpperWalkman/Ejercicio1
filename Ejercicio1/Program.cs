using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeros = "5 23";
            string[] enteros = numeros.Split(' ');
            string resultado = string.Empty;
            int a = int.Parse(enteros[0]);
            int b = int.Parse(enteros[1]);
            for (int i = a; i <= b; i++)
            {
                if(i % a == 0)
                {
                    resultado += $"{i} ";
                }
            }
            Console.WriteLine(resultado);
        }
    }
}
