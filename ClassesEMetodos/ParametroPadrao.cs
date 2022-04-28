using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametroPadrao
    {
        public static int Somar(int a=1, int b=2) // Definir valor padrão para as variáveis, é possível
        {
            return a + b;
        }
        public static void Executar()
        {
            Console.WriteLine(Somar(10,20));
            Console.WriteLine(Somar(50));
            Console.WriteLine(Somar());
            Console.WriteLine(Somar(b:7));
        }
    }
}
