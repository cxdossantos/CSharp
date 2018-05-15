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

            c.Acelerar();
            c.Acelerar();
            c.Acelerar();
            c.Acelerar();
            c.Acelerar();

            Console.WriteLine("Velocidade: " + c.Velocidade);

            c.Desacelerar();
            c.Desacelerar();
            Console.WriteLine("Velocidade: " + c.Velocidade);

            Console.ReadKey();
        }
    }
}
