using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos
{
    class Params
    {
        /*criando um método com uma array, usando o termo "params" para criar 
         * método com quantidade de parâmetros variados, determinar o tipo de
         * arquivo na array e nomear a array 
        */
        public static void Recepcionar(params string[] convidados)
        {
           //criar um foreach para listar os membros da array convidados 
           foreach(var pessoa in convidados)
            {
                Console.WriteLine("Ola {0}", pessoa);
            }
        }
        // listar os membros da array "Recepcionar"
        public static void Executar()
        {
            Recepcionar("Pablo","Ana","Maria");
            
        }
    }
}
