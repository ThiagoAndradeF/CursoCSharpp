using System;

namespace CursoCSharp.EstruturasDeControle
{
    internal class EstruturaIf
    {
        public static void Executar()
        {
            Console.WriteLine("Digite sua nota: ");
            double.TryParse(Console.ReadLine(), out double nota);

            Console.WriteLine("Possui bom comportamento (S/N): ");
            string entradaComportamento = Console.ReadLine();
            bool bomComportamento = false;
            //if (entradaComportamento == "S" || entradaComportamento == "s")
            //    bomComportamento = true;
            //bomComportamento= entradaComportamento=="S"|| entradaComportamento=="s";
            bomComportamento= entradaComportamento.ToLower()=="s";

            if (nota >= 9 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra!");
            }

        }
    }
}
