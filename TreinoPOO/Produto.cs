using System;
using System.Globalization;

namespace TreinoPOO
{
    internal class Produto
    {
        public string Nome;
        public double Preco, total;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;            
        }

        public override string ToString()
        {
            return Nome + ", $" + Preco.ToString("F3", CultureInfo.InvariantCulture)
                +", " + Quantidade + " unidades, " + " Total: $"
                + ValorTotalEmEstoque().ToString("F3", CultureInfo.InvariantCulture);
        }

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            Quantidade -= quantidade;
        }
    }
}
