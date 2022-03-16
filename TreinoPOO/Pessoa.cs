using System;
using System.Globalization;

namespace TreinoPOO
{
    public class Pessoa
    {
       public string nome;
       public double salario;

        public void AumentoSalario(double aumento)
        {
            double temp = salario / 100;
            temp = temp * aumento;
            salario = temp + salario;
        }

    }
}
