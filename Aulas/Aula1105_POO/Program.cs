using System;

namespace Aula1105_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();

            a.Nome = "Godofredo"; // set
            //a.Cpf = "12345678909";
            a.Matricula = "101010";
            Console.WriteLine("Aluno:" + a.Nome); // get

            Aluno b = new Aluno("Julinda", "123");
            b.Matricula = "696969";

            Console.WriteLine(b.ShowInfoPessoa());

            Aluno c = new Aluno("Janacreia");
            c.Matricula = "504531";
            Console.WriteLine(c.ShowInfoPessoa());
            //Pessoa p = new Pessoa();

            Console.ReadKey();
            
        }
    }
}
