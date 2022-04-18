using System;

namespace CursoCSharp.ClassesEMetodos
{
    internal class CalculadoraComum
    { //Criação do método
        public int Somar(int a, int b)
        {
            return a + b;
        }
        public int Subtrair(int a, int b)
        {
            return a - b;
        }
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
        public int Dividir(int a, int b)
        {
            return a / b;
        }
    }

     class CalculadoraCadeia
    {
        private int memoria;//criar variável para armazenar resultado das informações

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this;//esse this, se refere ao CalculadoraCadeira
        }
        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }
        public CalculadoraCadeia Dividir(int a)
        {
            memoria /= a;
            return this;
        }
        public CalculadoraCadeia Subtrair(int a)
        {
            memoria -= a;
            return this;
        }
        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }
        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }
        public int Resultado()
        {
            return memoria;
        }

    }

    internal class MetodosComRetorno
    {
        public static void Executar()
        {
            CalculadoraComum calculadoraComum = new CalculadoraComum();

            //usar o método criado, criando uma variável, atribuindo valor à ela, depois exibindo-a
            int resultado = calculadoraComum.Somar(5, 5);
            Console.WriteLine(resultado);
            //exibir resultado de método, o passando por parâmetro
            Console.WriteLine(calculadoraComum.Subtrair(2, 4));
            Console.WriteLine(calculadoraComum.Multiplicar(3, 2));
            Console.WriteLine(calculadoraComum.Dividir(20, 4));


            var CalculadoraCadeia= new CalculadoraCadeia();

            resultado = CalculadoraCadeia.Somar(3).Multiplicar(2).Resultado();
            Console.WriteLine(resultado); 

        }
        
    }
}