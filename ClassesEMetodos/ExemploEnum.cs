using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    public enum Genero{ Acao,Comedia,Terror,Animacao,Aventura};

    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    class ExemploEnum
    {
       public static void Executar(){ 
            int id=(int)Genero.Animacao;
            Console.WriteLine(id);

            var filmeParaFamilia=new Filme();
            filmeParaFamilia.Titulo="Meu malvado Favorito";
            filmeParaFamilia.GeneroDoFilme=Genero.Animacao;

            Console.WriteLine("{0} é {1}", filmeParaFamilia.Titulo, 
                filmeParaFamilia.GeneroDoFilme);            
            }
    }
}
