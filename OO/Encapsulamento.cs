using System;
using Encapsulamento;
namespace CursoCSharp.OO
{
    public class FilhoNaoReconhecido : SubCelebridade{
        public new void MeusAcessos(){
            Console.WriteLine("FILHO NAO RECONHECIDO");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            //Console.WriteLine(SegredoDeFamilia);
            //Console.WriteLine(UsaMuitoPhotoshop);
            }
    }
        
    public class AmigoDistante {
        public readonly SubCelebridade amiga= new SubCelebridade();

            public void MeusAcessos(){
                Console.WriteLine("AMIGO DISTANTE");
                Console.WriteLine(amiga.InfoPublica);
                //Console.WriteLine(amiga.CorDeOlho);
                //Console.WriteLine(NumeroCelular);
                //Console.WriteLine(JeitoDeFalar);
                //Console.WriteLine(SegredoDeFamilia);
                //Console.WriteLine(UsaMuitoPhotoshop;
                }
            }
    class Encapsulamentoo
    {
        public static void Executar(){
            var sub= new SubCelebridade();
            sub.MeusAcessos();
            
            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();


            new FilhoNaoReconhecido().MeusAcessos();
            
            new AmigoDistante().MeusAcessos();


            }
    }
}
