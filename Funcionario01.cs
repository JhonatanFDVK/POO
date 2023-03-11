using System;
using System.Globalization;

namespace POO
{
    class Funcionario
    {
        public string Nome;
        public double Salario;

        public static double SalarioMedio(params double[] vet)
        {
            double soma = 0; // soma todos os salários digitados.
            double qtdDeSalario = 0; // Conta quantos salário são digitados.

            for (int i = 0; i < vet.Length; i++)
            {
                soma += vet[i];
                qtdDeSalario++;
            }

            return soma / qtdDeSalario; // Retorna a média dos salários.
        }
        public override string ToString() // Imprime todas as informações do funcionário.
        {
            return "Nome: " + Nome + "\n" +
            "Salário: R$ " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }

    class Principal
    {
        static void Main()
        {
            /*
            Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
            médio dos funcionários.
            */

            System.Console.WriteLine("Dados do primeiro funcionário.");
            System.Console.Write("Nome: ");
            string nome01 = Console.ReadLine();
            System.Console.Write("Salário: ");
            double salario01 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Funcionario funcionario01 = new Funcionario()
            {
                Nome = nome01,
                Salario = salario01
            };

            System.Console.WriteLine("Dados do segundo funcionário.");
            System.Console.Write("Nome: ");
            string nome02 = Console.ReadLine();
            System.Console.Write("Salário: ");
            double salario02 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Funcionario funcionario02 = new Funcionario()
            {
                Nome = nome02,
                Salario = salario02
            };

            System.Console.WriteLine("Dados do terceiro funcionário.");
            System.Console.Write("Nome: ");
            string nome03 = Console.ReadLine();
            System.Console.Write("Salário: ");
            double salario03 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Funcionario funcionario03 = new Funcionario()
            {
                Nome = nome03,
                Salario = salario03
            };

            System.Console.WriteLine("Salário médio: R$ " + Funcionario.SalarioMedio(funcionario01.Salario, funcionario02.Salario, funcionario03.Salario).
            ToString("F2", CultureInfo.InvariantCulture));

            System.Console.WriteLine();

            System.Console.WriteLine(funcionario01);
            System.Console.WriteLine(funcionario02);
            System.Console.WriteLine(funcionario03);
        }
    }
}