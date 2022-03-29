using System;
using System.Globalization;

namespace TreinoPOO
{
    class Program
    {        
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do Produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
             p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());


            Console.WriteLine("Dados do produto: " + p);
            Console.ReadLine();

            Console.Clear();
            int RespostaMenu = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine("MENU DE OPCOES");
                Console.WriteLine("--------------");
                Console.WriteLine();
                Console.WriteLine("1 - Adicionar Produtos");
                Console.WriteLine("2 - Remover Produtos");
                Console.WriteLine("3 - Sair");

                RespostaMenu = int.Parse(Console.ReadLine());

                switch (RespostaMenu)
                {
                    case 1:
                        Console.Write("Entre com a quantidade de produtos que deseja acrescentar: ");
                        int qtd = int.Parse(Console.ReadLine());
                        p.AdicionarProduto(qtd);
                        Console.WriteLine("Dados do produto: " + p);
                        break;
                    case 2:
                        Console.Write("Entre com a quantidade de produtos que deseja remover: ");
                        qtd = int.Parse(Console.ReadLine());
                        p.RemoverProduto(qtd);
                        Console.WriteLine("Dados do produto: " + p);
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Valor incorreto!");
                        break;
                }
                Console.Clear();
            } while (RespostaMenu != 3);
        }
    }
}



/*            Moedas mod = new Moedas();

            Console.WriteLine("Digite a cotação do Dolar atual");
            double Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.Write("Digite quantos Dolares deseja comprar: ");
            double CompraDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            mod.ConversaoCompraDolar(Cotacao, CompraDolar);*/

/*Pessoa p1;
            p1 = new Pessoa();

            double media, Aumento;

            Console.WriteLine("Dados do funionario:");
            Console.Write("Nome:  ");
            p1.nome = Console.ReadLine();
            Console.Write("Salario:  ");
            p1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Clear();

            Console.WriteLine("Funcionario: " + p1.nome + ", Salario $ " + p1.salario.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salario: ");
            p1.AumentoSalario(Aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine("Funcionario: " + p1.nome + ", Salario $ " + p1.salario);
            Console.WriteLine();*/

/*
Pessoa p1, p2;
p1 = new Pessoa();
p2 = new Pessoa();
Console.Write("Digite o nome da primeira pessoa:");
p1.nome = Console.ReadLine();
Console.Write("Digite a idade: ");
p1.idade = int.Parse(Console.ReadLine());

Console.Write("Digite o nome da segunda pessoa:");
p2.nome = Console.ReadLine();
Console.Write("Digite a idade: ");
p2.idade = int.Parse(Console.ReadLine());

if (p1.idade > p2.idade)
{
    Console.Write("A pessoa mais velha e: " + p1.nome);
}
else
{
    Console.Write("A pessoa mais velha e: " + p2.nome);
}*/

/*            Pessoa p1, p2, p3;
            p1 = new Pessoa();
            p2 = new Pessoa();
            p3 = new Pessoa();

            double media;

            Console.WriteLine("Dados do primeiro funionario:");
            Console.Write("Nome:  ");
            p1.nome = Console.ReadLine();
            Console.Write("Salario:  ");
            p1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do primeiro funionario:");
            Console.Write("Nome:  ");
            p2.nome = Console.ReadLine();
            Console.Write("Salario:  ");
            p2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do primeiro funionario:");
            Console.Write("Nome:  ");
            p3.nome = Console.ReadLine();
            Console.Write("Salario:  ");
            p3.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (p1.salario + p2.salario + p3.salario) / 2;

            Console.Write("A media salarial de todos e : " + media.ToString("F3", CultureInfo.InvariantCulture));*/

/*            FormasGeometricas f = new FormasGeometricas();

            Console.WriteLine("Entre com os dados do retangulo");
            Console.Write("Altura: ");
            double Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Largura: ");
            double Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            f.CalcularArea(Altura, Largura);
            f.CalcularPerimetro(Altura, Largura);
            f.CalcularDiagonal(Altura, Largura);*/