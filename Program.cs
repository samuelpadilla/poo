using System;

namespace poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            Pessoa objetoPessoa = new Pessoa();
            objetoPessoa.nome = "Samuel";

            Console.WriteLine(objetoPessoa.nome);
            Console.ReadKey();
        }
    }
}
