using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.OO
{   
    public abstract class Celular { 
        public abstract string Assistente();
        public string Tocar(){
            return "trim trim trim";
            }
        }
    public class Iphone : Celular { 
        public override string Assistente(){ 
        return "Olá! meu nome é Siri"; }
        }

    public class Samsumg: Celular{
        public override string Assistente() { 
        return "Olá! Meu nome é Bixby";}
        }
    class Abstract
    {
        public static void Executar() {
            var celulares= new List<Celular>{
                new Iphone(),
                new Samsumg()
                };
            foreach(var celular in celulares) {
                Console.WriteLine(celular.Assistente());}
            }
    }
}
