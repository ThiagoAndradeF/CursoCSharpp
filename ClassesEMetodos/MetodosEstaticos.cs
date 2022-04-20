namespace CursoCSharp.ClassesEMetodos
{
    public class CalculadorEstatica
    {
        // Método de Classe ou Método estático!!
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
        // Método de instância!!
        public int Somar(int a, int b)
        {
            return a + b;
        }


    }

    internal class MetodosEstaticos
    {
        public static void Executar()
        {
            //usando método estático
            var resultado= CalculadorEstatica.Multiplicar(2,2);
            System.Console.WriteLine("Resultado: {0}", resultado);

            //instanciando método para usalo
            var calc= new CalculadorEstatica();
            System.Console.WriteLine("Resultado: {0}", calc.Somar(2,2));

        }
    }
}
