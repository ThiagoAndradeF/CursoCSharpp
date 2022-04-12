namespace CursoCSharp.Fundamentos
{
    internal class OperadoresLogicos
    {
        public static void Executar()
        {
            bool executouTrabalho1 = true;
            bool executouTrabalho2 = false;
            
            bool comprouTV52 = executouTrabalho1 && executouTrabalho2;
            System.Console.WriteLine("comprou a tv 52? {0}", comprouTV52);
            
            bool comprouTV32 = executouTrabalho1 ^ executouTrabalho2;
            System.Console.WriteLine("comprou a tv de 32? {0}", comprouTV32);
            
            bool sorvete = executouTrabalho1 || executouTrabalho2;
            System.Console.WriteLine("tomou sorvete? {0}", sorvete);

            System.Console.WriteLine("ficou mais saudável? {0}", !sorvete);
        }
    }
}
