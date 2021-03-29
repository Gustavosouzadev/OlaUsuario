using System;

namespace OlaUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;

            Console.WriteLine("Escreva seu nome: ");
            nome = Console.ReadLine();

            Console.Clear();

            Console.WriteLine($"Ola! {nome}. ");

        }
    }
}
