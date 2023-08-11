namespace ConvertorDeMoedas
{
    internal class ConvertorDeMoedas
    {
        public static double Iof = 6;

        public static double MoedaParaReal(double quantia, double cotacao) 
        {
            double total = quantia * cotacao;

            return total += total * Iof / 100;
        }

    }
}
