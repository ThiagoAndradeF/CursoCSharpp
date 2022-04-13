using System;

namespace CursoCSharp.EstruturasDeControle
{
    internal class UsandoContinue
    {
        public static void Executar()
        {
            int intervalo = 50;
            Console.WriteLine("Numeros pares entre 1 e {0} são:", intervalo);

            for (int i = 1; i <= intervalo; i++)
            {
                if (i % 2 == 1)
                {
                    continue;
                   /*Comando usado para continuar executando o código, apesar da invalidação
                   do IF (não é o jeito mais inteligente de mostrar os numeros pares!)
                   JEITO MAIS INTELIGENTE 
                   for(int i=2; i<=intervalo;i+=2){ Console.Write(i+" ");*/
                }
                Console.Write(i + "   ");
            }

        }
    }
}
