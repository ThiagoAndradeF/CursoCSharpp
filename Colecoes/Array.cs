using System;

namespace CursoCSharp.Colecoes
{
    internal class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Mario";
            alunos[1] = "Luigi";
            alunos[2] = "Princesa Peach";
            alunos[3] = "Yoshi";
            alunos[4] = "Browser";

            double[] notas = { 9.3, 5.6, 6.7, 9.0, 10 };

            foreach (string aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
            double somatorio=0;
            foreach (double nota in notas)
            {
                somatorio += nota;
            }
            double media= somatorio/ notas.Length;
            Console.WriteLine(media);


            char[] letras={'A','r','r','a','y'};
            string palavra= new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
