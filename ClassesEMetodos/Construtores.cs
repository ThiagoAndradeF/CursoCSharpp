using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro{
        public string Modelo;
        public string Fabricante;
        public int Ano;
        //nessa estrutura, se o contrutor não for definido, é utilizado o construtor padrão
        
        //entretanto, é possível criar um construtor, que por automatico desabilita  construtor padrão implícito
        public Carro(string modelo, string fabricante, int ano){
            Modelo=modelo; /* é possível usar nomes iguais, alterando os parametros para exatamente o nome dos atributos das classes 
            e usando o this; ficando This.Modelo=Modelo*/
            Fabricante=fabricante;
            Ano=ano;
            }

        //dessa forma, pode-se deixar o construtor padrão explícito
        public Carro(){ }
    }
    class Construtores
    {
        public static void Executar()
        {


            //criar variável usando construtor padrão 
            var carro1= new Carro();
            
               carro1.Fabricante="BMW";
               carro1.Modelo="325i";
               carro1.Ano= 2017;
            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");
            

            //criar variável usando construtor criado manualmente
            var carro2= new Carro("Ka","Ford",2012);//passando informações por parâmetra
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");

            var carro3=new Carro()//nomeando vareáveis envolvidas manualmente
            {
                Fabricante= "Chevrolet",
                Modelo= "Vectra",
                Ano= 2015
            };
            Console.WriteLine($"{carro3.Fabricante} {carro3.Modelo} {carro3.Ano}");

        }
    }
}
