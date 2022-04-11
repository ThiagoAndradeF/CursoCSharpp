using System;

namespace CursoCSharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("digite o seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("digite sua idade");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("digite seu salário");
            double salario= double.Parse(Console.ReadLine());

            Console.WriteLine($"{nome} {idade} R${salario}");
        }
    }
}
