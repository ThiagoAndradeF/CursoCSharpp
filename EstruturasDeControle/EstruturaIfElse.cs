using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaIfElse
    { 
        public static void Executar()
        {
            Console.WriteLine("digite sua nota");
            double.TryParse(Console.ReadLine(), out double nota);
            if (nota>= 7.0){
                Console.WriteLine("você passou!!!");
                Console.WriteLine("não fez mais que sua obrigação!");
            }
            else { Console.WriteLine("você foi reprovado, que feio!!"); }

        }
    }
}
