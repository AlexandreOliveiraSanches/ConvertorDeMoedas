using ConvertorDeMoedas;
using System;
using System.Globalization;

namespace ConvertorDeMoedas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual é a cotação da moeda desejada? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Qual a quantia que você irá comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConvertorDeMoedas.MoedaParaReal(quantia, cotacao);
            Console.WriteLine("Valor a ser pago em reais(juntamente com a taxa IOF): R$" + result.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}