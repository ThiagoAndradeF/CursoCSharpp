using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresRelacionais
    {
        public static void Executar()
        {
            //sempre retorna true ou false
            var notaMin=0.0;
            var notaMax=10.0;
            Console.Write("Digite sua nota");
            double.TryParse(Console.ReadLine(), out double nota);
            var notaCorte=7.0;
            Console.WriteLine("Nota inválida? {0}", (nota>notaMax||nota<notaMin));
            Console.WriteLine("Perfeito? {0}", nota==notaMax);
            Console.WriteLine("Tem como melhorar? {0}", nota!=notaMax);
            Console.WriteLine("Passou na média? {0}", nota>=notaCorte);
            Console.WriteLine("Recuperação? {0}", nota<notaCorte);


        }
    }
}
