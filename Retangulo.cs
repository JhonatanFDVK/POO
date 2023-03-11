using System;
using System.Globalization;

namespace POO
{
    class Retangulo
    {
        private double _largura;
        private double _altura;

        public Retangulo(double largura, double altura)
        {
            _largura = largura;
            _altura = altura;
        }
        public double Area()
        {
            return _largura * _altura;
        }
        public double Perimetro()
        {
            return 2 * (_largura + _altura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(_largura * _largura + _altura * _altura);
        }
    }
    class Principal
    {
        static void Main()
        {
            /*
            Fazer um programa para ler os valores da largura e altura de um retângulo.
            Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe
            como mostrado no projeto ao lado.
            */

            System.Console.WriteLine("Entre a largura e altura do retângulo:");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Retangulo retangulo = new Retangulo(largura, altura);

            System.Console.WriteLine("ÁREA = " + retangulo.Area().ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("PERÍMETRO = " + retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine("DIAGONAL = " + retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}