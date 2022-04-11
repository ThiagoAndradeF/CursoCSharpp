using System;

namespace CursoCSharp.Fundamentos
{
    internal class Inferencia
    {
        public static void Executar()
        {
            var nome = "thiago";
            //nome=123;(dá conflito )
            Console.WriteLine(nome);
            /*int idade;(dá problema pois não pode constar variável por inferencia 
             *sem atribuir valor à ela)
             */
            var idade = 20;
            Console.WriteLine(idade);
        }
    }
}
