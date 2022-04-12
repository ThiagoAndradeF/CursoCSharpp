using System;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAritmeticos
    {
        public static void Executar()
        {
            int preco = 1000;
            double desconto = 0.1;
            int imposto = 300;
            Console.WriteLine("O valor ficará " + ((preco + imposto) - desconto));

            //IMC
            double peso=64.8;
            var altura=1.75;
            var imc= peso/Math.Pow(altura,2);
            Console.WriteLine($"o seu IMC é {imc}");

            //Numero Par/Impar
            int par=24;
            int impar=55;
            Console.WriteLine("{0} tem resto {1}", par, par%2);
            Console.WriteLine("{0} tem resto {1}", impar, impar%2);
        }

    }
}
