using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número?");
            int numero = int.Parse(Console.ReadLine());
            int resultado;

            for(var contador = 0; contador <= 10; contador++)
            {
             resultado = numero*contador;
             Console.WriteLine(resultado);
            }

            
        }
    }
}
