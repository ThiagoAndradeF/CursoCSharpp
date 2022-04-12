using System;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Avalie nosso atendemiento com uma nota de 0 a 5!");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Pessimo atendimento!");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim atendimento!");
                    break;
                case 3:
                    Console.WriteLine("Atendimento OK!");
                    break;
                case 4:
                    Console.WriteLine("Bom atendimento!");
                    break;
                case 5:
                    Console.WriteLine("Ótimo atendimento!");
                    break;
                default:
                    Console.WriteLine("Selecione um valor válido!");
                    break;
            }
            Console.WriteLine("Obrigado por responder nossa pesquisa!!");
        }
    }
}
