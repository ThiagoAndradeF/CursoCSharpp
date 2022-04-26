namespace CursoCSharp.ClassesEMetodos
{
    internal class ParametrosPorReferencia
    {
        public static void AlterarRef(ref int numero)
        {
            numero+=1000;
        }
        public static void AlterarOut(out int numero)
        {
            numero=0;
            numero+=15;
        }
        public static void Executar()
        {
            int a=3;
            AlterarRef(ref a);
            System.Console.WriteLine(a);

            //int b// não adiciona valor em out, apenas recebe
            AlterarOut(out int b);
            System.Console.WriteLine(b);

        }
    }
}
