using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("Programas Aulas Seção 5, selecione:");
            Console.WriteLine("1 - Construtores");
            Console.WriteLine("2 - Sobrecarga");
            Console.WriteLine("3 - Encapsulamento");

            int opcao = int.Parse(Console.ReadLine());
            switch(opcao)
            {
                case 1: Construtores();
                break;

                case 2: Sobrecarga();
                break;

                case 3: Encapsulamento();
                break;

                default: Console.WriteLine("Valor não permitido");
                break;
            }
        }

        public static void Construtores()
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }

        public static void Sobrecarga()
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco);

            Produto p2 = new Produto();

            /* Produto p3 = new Produto
            {
                Nome = "TV",
                Preco = 500.00,
                Quantidade = 5
            }; */

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }

        public static void Encapsulamento()
        {
            Produto p = new Produto("TV", 500.00, 10);

            p.SetNome("T");

            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
        }
    }
}
