using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao="olá".ToUpper().Insert(3, "world!")
                .Replace("world!", " Mundo");
            Console.WriteLine(saudacao);
            Console.WriteLine("Teste".Length);
            
            string valorImportante=null;
            Console.WriteLine(valorImportante?.Length);
            /*é necessário o uso de ? antes do . para garantir que não vai dar problema
             *de erro na execução do .
             */         
        }
    }
}
