using System;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaWhile
    {
        public static void Executar()
        {
            Random random = new Random();
            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;
            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Insira um palpite:");
                int.TryParse(Console.ReadLine(), out int palpite);
                tentativas++;
                tentativasRestantes--;
                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    ConsoleColor corInicial = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Você acertou em {0} tentativas", tentativas);
                    Console.BackgroundColor= corInicial;
                }
                else if (numeroSecreto > palpite)
                {
                    Console.WriteLine("Numero secreto é maior que o número apresentado");
                    Console.WriteLine("{0} chances restantes!", tentativasRestantes);
                }
                else
                {
                    Console.WriteLine("Numero secreto é menor que o número apresentado");
                    Console.WriteLine("{0} chances restantes!", tentativasRestantes);
                }
            }
        }
    }
}
