using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    internal class GetSet
    {

        public class Moto
        {
            private string Marca;
            private string Modelo;
            private int Cilindrada;
            public Moto(string marca, string modelo, int cilindrada)
            {
                //Marca = marca;
                //Modelo = modelo;
                //Cilindrada = cilindrada;
                SetMarca(marca);
                SetModelo(modelo);
                SetCilindrada(cilindrada);
            }
            public Moto() { }
            public string GetMarca()
            {
                return Marca;
            }
            public void SetMarca(string marca)
            {
                Marca = marca;
            }
            public string GetModelo()
            {
                return Modelo;
            }
            public void SetModelo(string modelo)
            {
                Modelo = modelo;
            }
            public int GetCilindrada()
            { 
                return Cilindrada;
            }
            public void SetCilindrada(int cilindrada)
            {
                //1opção
                //if (cilindrada>0)
                //{
                //    Cilindrada = cilindrada;
                //}
                //2opção
                Cilindrada=Math.Abs(cilindrada);
                
            }

        }
        public static void Executar()
        {
            Moto moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 200);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            Moto moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(-2000);
            Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo() + " " + moto2.GetCilindrada());
            //var moto2 = new Moto();
            //moto2.SetMarca("Honda");
            //moto2.SetModelo("CG Titan");
            //moto2.SetCilindrada(150);
            //System.Console.WriteLine(moto2.GetMarca() + " " + moto2.GetModelo()
            //    + " " + moto2.GetCilindrada());
        }
    }
}
