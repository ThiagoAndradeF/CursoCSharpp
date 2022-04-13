using System;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaDoWhile
    {
        public static void Executar()
        {
            string entrada;
            do //primeiro executa o do, para depois ver a condicional da while
            {
                Console.WriteLine("Digite o seu nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Seja bem vindo {0}", nome);
                Console.WriteLine("Deja continuar? (S/N)");
                entrada = Console.ReadLine();
            } while(entrada.ToLower()=="s");
        }
    }
}
