using ConvertorDeMoedas;
using System;
using System.Globalization;

namespace ConvertorDeMoedas
{
    class Program {
        static void Main(string[] args) {

            

            Console.WriteLine("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result = ConvertorDeMoedas.DolarParaReal(quantia, cotacao);
            Console.WriteLine("Valor a ser pago em reais: " + result.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}