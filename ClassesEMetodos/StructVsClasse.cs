using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public struct SPonto
    {
        public int X;
        public int Y;
    }
    public class CPonto
    {
        public int X;
        public int Y;
    }
    class StructVsClasse
    {
        public static void Executar()
        {
            CPonto Ponto1=new CPonto {X=3,Y=4};
            var CopiaPonto1= Ponto1;
            Ponto1.X=10;

            SPonto Ponto2=new SPonto {X=1,Y=2};
            var CopiaPonto2=Ponto2;
            Ponto2.Y=3;

            Console.WriteLine("O valor do X e Y do Ponto1 é {0} e {1}",Ponto1.X, Ponto1.Y);
            Console.WriteLine("O valor do X e Y do CopiaPonto1 é {0} e {1}",CopiaPonto1.X, CopiaPonto1.Y);
            Console.WriteLine("O valor do X e Y do Ponto2 é {0} e {1}",Ponto2.X, Ponto2.Y);
            Console.WriteLine("O valor do X e Y do CopiaPonto2 é {0} e {1}",CopiaPonto2.X, CopiaPonto2.Y);


    


        }
    }
}
