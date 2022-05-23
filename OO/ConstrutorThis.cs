using System;
using System.Collections.Generic;
using System.Text;
namespace CursoCSharp.OO
{
    internal class ConstrutorThis
    {
        public class Animal
        {
            public string Nome{get;set;}
            public Animal(string nome)
            {
                Nome = nome;
            }
        }
        public class Cachorro : Animal { 
            public double Altura{get; set;}
            public Cachorro(string nome) : base(nome) {
                Console.WriteLine($"Cachorro {nome} inicializado");
                }
            public Cachorro(string nome, double altura) : this(nome) { 
                Altura=altura;
                }
            public override string ToString()
            {
                return $"{Nome} tem {Altura}cm de altura";
            }
        }
        public static void Executar() { 
            
        
            var Spyke= new Cachorro("Spyke");
            var Max= new Cachorro("Max", 40.0);

            Console.WriteLine(Spyke);
            Console.WriteLine(Max);
            
            }

    }
}
