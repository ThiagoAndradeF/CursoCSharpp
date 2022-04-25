﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public class CarroOpcional
    {
        double desconto=0.1;
        string nome;
        public string Nome
        {
            get
            {
                return "Opcional: "+ nome;
            }
            set{
                nome=value;
                }
        }
        //Propriedade Autoimplementada
        public double Preco {get;set;}

        //Somente leitura
        public double PrecoComDesconto{
            get=> Preco -(desconto*Preco); //Lambda
            //get{
            //return Preco-(desconto*Preco); }
            }
        public CarroOpcional(){ }
        public CarroOpcional(string nome,double preco)
        {
            //this.nome=nome;
            Nome=nome;
            Preco = preco;
        }
    }
    class Props
    {

        public static void Executar(){
            var op1=  new CarroOpcional("Ar Condicionado",3499.9);
            Console.WriteLine(op1.PrecoComDesconto);
            //op1.PrecoComDesconto=3000;**não funciona pois apenas tem o método get atribuido
            //não tem o set atribuido.
            var op2= new CarroOpcional();
            op2.Nome="Direção Elétrica";
            op2.Preco=2349.9;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);

            //mesmo sem declarar o PrecoComDesconto, é possível ver o PrecoComDesconto 
            //do op2, pois o Preco foi declarado e o Desconto determinado na própria classe.

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);
        } 
        
    }
}