using System;

namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametrosNomeados
    {
        //Nomear parâmetros e declaralos
        public static void Formatar(int dia, int mes, int ano)
        {
            //Colocar em ordem de exibição dos parâmetros nomeados anteriormente
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }

        public static void Executar()
        {   //Determinar os valores dos parâmetros
            Formatar(mes: 1, dia: 3, ano: 1992);
        }
    }
}
