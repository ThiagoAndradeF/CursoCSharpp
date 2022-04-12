using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar()
        {
            var num1=3.0;
            num1+=10;
            num1-=3;
            num1/=2;
            num1*=8;

            Console.WriteLine(num1);

            int a=1;
            int b=2;

            b++;
            a--;

            Console.WriteLine($"{a} {b}");
        }
    }
}
