using System;
using System.Globalization;

namespace POO
{
    class Aluno
    {
        public string Nome;
        public double PrimeiraNota;
        public double SegundaNota;
        public double TerceiraNota;

        public double NotaFinal()
        {
            return PrimeiraNota + SegundaNota + TerceiraNota;
        }
        public bool Situacao()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string Resultado()
        {
            string msg;

            if (Situacao())
            {
                msg = "\nAPROVADO\nNOTA FINAL = " + NotaFinal().ToString("F2", CultureInfo.InvariantCulture);
            }
            else
            {
                msg = "\nREPROVADO\nNOTA FINAL: " + NotaFinal().ToString("F2", CultureInfo.InvariantCulture) +
                "\nFALTAM: " + (60 - NotaFinal()).ToString("F2", CultureInfo.InvariantCulture);
            };

            return msg;
        }
    }
    class Principal
    {
        static void Main()
        {
            /*
            Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
            (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
            ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
            para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver
            este problema.
            */

            Aluno aluno = new Aluno();

            System.Console.Write("ALUNO: ");
            aluno.Nome = Console.ReadLine();
            System.Console.Write("NOTA DO 1° SEMESTRE: ");
            aluno.PrimeiraNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("NOTA DO 2° SEMESTRE: ");
            aluno.SegundaNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.Write("NOTA DO 3° SEMESTRE: ");
            aluno.TerceiraNota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine(aluno.Resultado());
        }
    }
}