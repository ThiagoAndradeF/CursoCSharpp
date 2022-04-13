using System;

namespace CursoCSharp.EstruturasDeControle
{
    internal class UsandoBreak
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine("Número que queremos é o número: {0}", numero);

            for (int i = 1; i <= 50; i++)
            {
                Console.Write("{0} é o numero que queremos?", i);
                if (i == numero)
                {
                    Console.WriteLine("sim!");
                    break;
                    /*esse break se refere ao for, finalizando o laço logo após 
                    a condicional if ser executado com sucesso*/
                }
                else
                {
                    Console.WriteLine("não!");
                }
            }
            Console.WriteLine("Fim!");
        }
    }
}
