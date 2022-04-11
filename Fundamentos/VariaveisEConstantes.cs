using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar()
        {
            
            byte mxByte = byte.MaxValue;
            Console.WriteLine("maior valor de byte " + mxByte);

            short mxShort = short.MaxValue;
            Console.WriteLine("maior valor de short " + mxShort);

            int mxInt = int.MaxValue;
            Console.WriteLine("maior valor de int " + mxInt);

            long mxLong =long.MaxValue;
            Console.WriteLine("maior valor de byte " + mxLong);

            sbyte minsByte = sbyte.MinValue;
            Console.WriteLine("menor valor de sbyte " + minsByte);

            double PiDouble= 3.141592;
            Console.WriteLine("maior valor de PI em double " + PiDouble);
            //é necessário o uso da letra f no final do numero descrito em float
            float PiFloat = 3.14f;
            Console.WriteLine("valor de PI em float " + PiFloat);

            bool verdade = true;
            Console.WriteLine("resposta de bool como verdade "+ verdade);

            char inicial = 't';
            Console.WriteLine("a inicial do meu nome é " + inicial);
            //para char uso de '' e para string ""
            string nome = "Thiago Andrade Ferreira";
            Console.WriteLine("o meu nome é: " + nome);
        









        }
    }
}
