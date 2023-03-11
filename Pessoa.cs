using System;

namespace POO
{
    class Pessoa
    {
        public string Nome;
        public int Idade;
    }
    class Principal
    {
        static void Main()
        {
            /*
            Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
            velha.
            */

            Pessoa pessoa01 = new Pessoa();

            System.Console.Write("Nome: ");
            pessoa01.Nome = Console.ReadLine();
            System.Console.Write("Idade: ");
            pessoa01.Idade = int.Parse(Console.ReadLine());

            Pessoa pessoa02 = new Pessoa();

            System.Console.Write("Nome: ");
            pessoa02.Nome = Console.ReadLine();
            System.Console.Write("Idade: ");
            pessoa02.Idade = int.Parse(Console.ReadLine());

            if (pessoa01.Idade > pessoa02.Idade)
            {
                System.Console.WriteLine("Pessoa mais velha: " + pessoa01.Nome);
            }
            else
            {
                System.Console.WriteLine("Pessoa mais velha: " + pessoa02.Nome);
            }

        }
    }
}