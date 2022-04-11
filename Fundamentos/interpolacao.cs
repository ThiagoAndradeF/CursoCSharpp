using System;

namespace CursoCSharp.Fundamentos
{
    internal class Interpolacao
    {
        public static void Executar()
        {
            string produto = "notebook gamer";
            string marca = "dell";
            double valor = 5_240.00;
            Console.WriteLine("O " + produto + "da marca " + marca + "custa " + valor);
            Console.WriteLine("O {0} da marca {1} custa {2}", produto, marca, valor);
            Console.WriteLine($"A marca {marca} e muito maneita");
        }

    }
}
