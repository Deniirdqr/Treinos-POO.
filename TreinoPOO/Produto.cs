using System;
using System.Globalization;

namespace TreinoPOO
{
    internal class Produto
    {
        private string _nome;
        private double _preco, _total;
        private int _quantidade;

        /*public Produto(string nome, double preco, int quantidade)
        {
            Nome = Nome;
            Preco = preco;
            Quantidade = quantidade;
        }*/


        public string Nome
        {
            get { return _nome; }
            set {
                if (value != null)
                {
                    _nome = value;
                }
            }
        }
        
        public double Preco
        {
            get { return _preco; }
            set {
                if (value != null && value > 0.0)
                {
                    _preco = value;
                }
            }
        }
        public int Quantidade
        {
            get { return _quantidade; }
            set {
                if (value != null && value > 0)
                {
                    _quantidade = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;            
        }

        public override string ToString()
        {
            return _nome + ", $" + _preco.ToString("F2", CultureInfo.InvariantCulture)
                +", " + _quantidade + " unidades, " + " Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AdicionarProduto(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProduto(int quantidade)
        {
            _quantidade -= quantidade;
        }
    }
}
