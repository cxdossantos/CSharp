using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1405_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();
            Onibus o = new Onibus();

            c.Acelerar();
            c.Acelerar();
            c.Acelerar();
            c.Acelerar();
            c.Acelerar();

            o.Acelerar();
            o.Acelerar();
            o.Acelerar();
            o.Acelerar();

            Console.WriteLine("Velocidade do Carro: " + c.Velocidade);
            Console.WriteLine("Velocidade do Onibus: " + o.Velocidade);

            c.Desacelerar();
            c.Desacelerar();
            o.Desacelerar();
            o.Desacelerar();
            Console.WriteLine("Velocidade do Carro: " + c.Velocidade);
            Console.WriteLine("Velocidade do Onibus: " + o.Velocidade);

            AcelerarBastante(c);
            AcelerarBastante(o);
            Console.WriteLine("Velocidade do Carro: " + c.Velocidade);
            Console.WriteLine("Velocidade do Onibus: " + o.Velocidade);

            Console.ReadKey();
        }

        static void AcelerarBastante(IMeioTransporte meioTransporte)
        {
            for (int i = 0; i < 10; i++)
            {
                meioTransporte.Acelerar();
            }
        }
    }
}
