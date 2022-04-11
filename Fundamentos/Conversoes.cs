using System;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {
            //inteiro para quebrado
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);
            //quebrado para inteiro, conversão explicita usando cash
            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("nota truncada: {0}", notaTruncada);

            Console.WriteLine("Digite o primeiro numero: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Resultado 1: {0} ", numero1);

            Console.WriteLine("Digite o segundo numero: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0} ", numero2);



        }
    }
}
