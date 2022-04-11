using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    class FormatandoNumeros
    {
        public static void Executar()
        {
            double valor=14.175;
            Console.WriteLine(valor.ToString("F1"));
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            
            CultureInfo cultura= new CultureInfo("en-US");
            Console.WriteLine(valor.ToString("C0", cultura));
            
            int inteiro=256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
