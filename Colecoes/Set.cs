using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes
{
    class Set
    {


        public static void Executar()
        {
            var vassoura= new produto("vassoura",20);
            var carrinho= new HashSet<produto>();
            var combo= new HashSet<produto>{ 
                new produto("carrinho de mao",200),
                new produto("pá",60),
                new produto("capacete", 20)
                };
            carrinho.UnionWith(combo);
            carrinho.Add(vassoura);
            Console.WriteLine(carrinho.Count);
            foreach(var item in carrinho){
                Console.WriteLine($"{item.Nome} {item.Preco}");
            }
            Console.WriteLine(carrinho.Count);
            carrinho.Add(vassoura);
            Console.WriteLine(carrinho.Count);

        }
    }
}
