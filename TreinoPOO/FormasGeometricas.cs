using System;
using System.Globalization;

namespace TreinoPOO
{
    internal class FormasGeometricas
    {
        public void CalcularArea(double A, double L)
        {
            double Area = A * L;
            Console.WriteLine("Valor da Area: " + Area.ToString("F3", CultureInfo.InvariantCulture));
        }

        public void CalcularPerimetro(double A, double L)
        {
            double Perimetro = (A * 2) + (L * 2);
            Console.WriteLine("Valor da Perimetro: " + Perimetro.ToString("F3", CultureInfo.InvariantCulture));
        }

        public void CalcularDiagonal(double A, double L)
        {
            double Diagonal = ((A * L) / 2);
            Console.WriteLine("Valor da Diagonal: " + Diagonal.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
