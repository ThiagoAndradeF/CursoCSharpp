using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class IfElseIf
    {
        public static void Executar() {
            Console.WriteLine("digite sua nota!");
            double.TryParse(Console.ReadLine(), out double nota);
            if (nota >= 9){
                Console.WriteLine("Quadro de honra!!");
            }else if (nota >= 7)
            {
                Console.WriteLine("Você foi aprovado!!");
            }else if (nota >= 5)
            {
                Console.WriteLine("Você ficou de recuperação!!");
            }
            else { Console.WriteLine("te vejo ano que vem!!"); };
            }
    }
}
