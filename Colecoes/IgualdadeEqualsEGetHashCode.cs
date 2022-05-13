using System;
using System.Collections.Generic;
using System.Text;
namespace CursoCSharp.Colecoes
{
    internal class IgualdadeEqualsEGetHashCode
    {
        public static void Executar()
        {
            produto p1 = new produto("caneta", 1.89);
            produto p2 = new produto("caneta", 1.89);

            Console.WriteLine(p1 == p2);
            //Retorna false pois "==" compara o espaçod e memória, e quando se cria 2
            //variáveis, o espaço de memória é diferente, logo p3==p2;

            Console.WriteLine(p1.Equals(p2));
//Para fazer esse tipo de comparação é preciso modificar a própria classe do
//objeto recebido, em produto por exemplo seria preciso adicionar o equals
// Retornará true, pois os valores  de Nome e Preco serão comparados

    }
}
}
