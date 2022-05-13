using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes
{
    internal class Queue
    {
        public static void Executar()
        {
            Queue<string> fila = new Queue<string>();

            Queue fila2 = new Queue();

            fila.Enqueue("Trem");
            fila.Enqueue("Alface");
            fila.Enqueue("Televisão");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);
            fila.Dequeue();
            Console.WriteLine(fila.Count);
            Console.WriteLine(fila.Contains("Televisão"));
            //fila.Enqueue("Item")//Adiciona um item à fila
            //fila.Peek();//Seleciona o primeiro item que está na fila
            //fila.Count;//Conta quantos itens tem na fila
            //fila.Dequeue()//Retira o primeiro item da fila
            //fila.Contains("algumItemEspecífico")// Sempre retornará true(se o item 
            ////estiver contido na fila) ou false(se não estiver contido). 

        }
    }
}
