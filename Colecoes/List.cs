using System;
using System.Collections.Generic;
using System.Text;
namespace CursoCSharp.Colecoes
{
    public class produto
    {
        public string Nome;
        public double Preco;

        public produto(string nome, double preco)
        {
           
            Nome=nome;
            Preco=preco;
        }

        public override bool Equals(object obj)
        {
            var produto = obj as produto;
            return produto != null &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode()
        {
            var hashCode = -347481536;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Nome);
            hashCode = hashCode * -1521134295 + Preco.GetHashCode();
            return hashCode;
        }
    }
    internal class List
    {

        public static void Executar()
        {

            var livro = new produto("Cronicas de gelo e fogo", 20.0);

            var carrinho = new List<produto>();

            carrinho.Add(livro);

            var combo = new List<produto>
            {
                new produto("poster",20.0),
                new produto("camisa", 30),
                new produto("bone", 20)
            };

            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);


            foreach (produto item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }


            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            //Console.WriteLine(carrinho.LastIndexOf(livro));
            Console.WriteLine(carrinho.Count);

        }
    }
}
