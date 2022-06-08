using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{
    public class Comida { 
        public double Peso;
        public Comida(double peso) { 
            Peso=peso;
            }
        public Comida() { }
        }
    public class Feijao : Comida { 
        public Feijao(double peso) : base(peso){ }
        }
    public class Arroz : Comida { }
    public class Carne : Comida { }
    public class Pessoa { 
        public double Peso;
        public void Comer(Comida comida) { 
            Peso += comida.Peso;
            }
        }
    class Polimorfismo
    {
        public static void Executar()
        {
           
            var igrediente1=new Feijao(0.3);
            var igrediente2=new Arroz();
            igrediente2.Peso=0.1;
            var igrediente3=new Carne();
            igrediente3.Peso=0.4;
            var cliente= new Pessoa();
             cliente.Peso=80.5;
            cliente.Comer(igrediente1);
            cliente.Comer(igrediente2);
            cliente.Comer(igrediente3);
            
             

            Console.WriteLine($"Agora o peso do cliente é {cliente.Peso}KG");
           
        }
    }
}   
