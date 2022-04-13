using System;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaFor
    {
        public static void Executar()
        {
            //int i=0;
            //while (i < 10)
            //{ Console.WriteLine("Aluno{0} ",i);
            //    i++;} 
            //for (int i=1;i<10;i++) {
            //    Console.WriteLine("Aluno {0}",i);
            //}
            Console.WriteLine("digite a quantidade de alunos que há na sala");
            int.TryParse(Console.ReadLine(), out int numAlunos);

            double somatorio = 0;
            for (int i = 1; i <= numAlunos; i++)
            {
                Console.Write("digite a nota do aluno {0} no console: ", i);
                double.TryParse(Console.ReadLine(), out double notaAtual);
                somatorio += notaAtual;

            }
            //double media = numAlunos > 0 ? somatorio / numAlunos : 0;
            if (numAlunos > 0)
            {
                double media=somatorio/numAlunos;
                Console.WriteLine("A media da turma é{0}: ", media);
            }else { 
                double media=0;
                Console.WriteLine("A media da turma é{0}: ", media);}
            

        }
    }
}

