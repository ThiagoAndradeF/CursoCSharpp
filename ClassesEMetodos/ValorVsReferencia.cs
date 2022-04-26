namespace CursoCSharp.ClassesEMetodos
{
    public class Dependente
    {
        public string nome;
        public int idade;
    }

    internal class ValorVsReferencia
    {

        public static void Executar()
        {
            int numero = 3;
            int copiaNumero = numero;
            System.Console.WriteLine($"{numero} {copiaNumero}");
            numero++;
            System.Console.WriteLine($"{numero} {copiaNumero}");

            Dependente dep = new Dependente { nome = "Arnold", idade = 12 };
            Dependente copiaDep = dep;
            System.Console.WriteLine($"{dep.nome} {copiaDep.nome}");

            copiaDep.nome="Lamburi";
            copiaDep.idade=24;


            System.Console.WriteLine($"{dep.nome} {copiaDep.nome}");
            System.Console.WriteLine($"{dep.idade} {copiaDep.idade}");
        }
    }
}
