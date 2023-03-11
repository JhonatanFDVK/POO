using System;
using System.Globalization;

namespace POO
{
    class Funcionario
    {
        private string _nome;
        private double _salarioBruto;
        private double _imposto;

        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            _nome = nome;
            _salarioBruto = salarioBruto;
            _imposto = imposto;
        }
        public double SalarioLiquido()
        {
            return _salarioBruto - _imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            _salarioBruto = _salarioBruto + (_salarioBruto * porcentagem / 100.0);
        }
        public override string ToString()
        {
            return "\nNome: " + _nome + "\n" +
            "Salário liquido: R$ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
    class Principal
    {
        static void Main()
        {
            /*
            Fazer um programa para ler os dados de um funcionário (nome,
            salário bruto e imposto). Em seguida, mostrar os dados do
            funcionário (nome e salário líquido). Em seguida, aumentar o salário
            do funcionário com base em uma porcentagem dada (somente o
            salário bruto é afetado pela porcentagem) e mostrar novamente os
            dados do funcionário. Use a classe projetada abaixo.
            */

            System.Console.Write("Nome: ");
            string nome = Console.ReadLine();
            System.Console.Write("Salário bruto: ");
            double salarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("Imposto: ");
            double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Funcionario funcionario = new Funcionario(nome, salarioBruto, imposto);
        
            System.Console.WriteLine(funcionario);

            System.Console.Write("\nDígite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionario.AumentarSalario(porcentagem);

            System.Console.WriteLine("Dados atualizados.\n" + funcionario);
        }
    }
}