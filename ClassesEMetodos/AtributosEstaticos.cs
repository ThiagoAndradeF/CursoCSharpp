using System;

namespace CursoCSharp.ClassesEMetodos
{
    internal class Produto
    {
        public string Nome;
        public static double  Desconto = 0.1;
        public double Preco;

        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }
        public Produto()
        {
        }
        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }

    internal class AtributosEstaticos
    {
        public static void Executar()
        {
            Produto produto1 = new Produto("Caneta", 3.2, 0.1);
            Produto produto2 = new Produto()
            {
                Nome = "Lápis",
                Preco = 1
            };
            Console.WriteLine("Preco com desconto {0}",
                produto1.CalcularDesconto());
            Console.WriteLine("Preco com desconto {0}",
                produto2.CalcularDesconto());

            Produto.Desconto= 0.5;

        }
    }
}
