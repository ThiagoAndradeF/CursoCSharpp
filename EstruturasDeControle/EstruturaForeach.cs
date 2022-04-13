using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForeach
    {
        public static void Executar()
        {
            var palavra="opa!";
            foreach(var letra in palavra)
            {
                Console.WriteLine(letra);
            }
            var aluno= new string[] {"Ana", "Bia", "Joaquin"};

            foreach(var nome in aluno)
            {
                Console.WriteLine(nome);
            }

        }
    }
}
