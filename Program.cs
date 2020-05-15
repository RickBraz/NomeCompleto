using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("bom dia usuario por favor digite seu nome: ");

            string nome = Console.ReadLine();

            Console.Write("agora digite seu sobrenome: ");

            string sobrenome = Console.ReadLine();
            string NomeCompleto = nome + " " + sobrenome;
            string NomeCatálogo = sobrenome .ToUpper() + ", " + nome;

            Console.WriteLine(NomeCompleto);
            Console.WriteLine(NomeCatálogo);
        }
    }
}
