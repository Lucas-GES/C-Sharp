
using System.Globalization;

namespace PrimeirosExercicios
{
    class Program
    {
        private static void Main(string[] args)
        {
            int program = 0;
            Console.WriteLine("Qual exercicio rodar?");
            Console.WriteLine("1 - Pessoa");
            Console.WriteLine("2 - Funcionários");
            program = int.Parse(Console.ReadLine());
            if(program == 1)
            {
                Pessoa();
            }
            else
            {
                Funcionario();
            }
        }

        public static void Pessoa()
        {
            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.Write("Pessoa mais velha: " + pessoa1.Nome);
            }
            else
            {
                Console.Write("Pessoa mais velha: " + pessoa2.Nome);
            }
        }

        public static void Funcionario()
        {
            Funcionario funcionario1, funcionario2;

            funcionario1 = new Funcionario();
            funcionario2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (funcionario1.Salario + funcionario2.Salario) / 2.0;
            Console.Write("Salário médio = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

}