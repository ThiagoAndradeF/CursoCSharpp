using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class DesafioAtributo
    {
        int a=10;
        public static void Executar()
        {
            // acessar variável a dentro do método executar
            //Console.WriteLine(a);(dá errado)

            var Desafio= new DesafioAtributo();
            Console.WriteLine(Desafio.a);
        }
    }
}
