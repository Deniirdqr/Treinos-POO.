using System;
using System.Globalization;

namespace TreinoPOO
{
    public class Moedas
    {
        public void ConversaoCompraDolar(double cot, double dol)
        {
            double temp = cot * dol;
            Console.WriteLine("Valor a ser pago em reais = $" + temp.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
