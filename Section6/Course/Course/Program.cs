using System.Globalization;

namespace Course
{
    class Program
    {
        private static void Main(string[] args)
        {
            int teste = 4;

            switch (teste)
            {
                case 1:
                    Struct();
                    break;
                case 2:
                    Nullable();
                    break;
                case 3:
                    Coalencia();
                    break;
                case 4:
                    Vetores1();
                    break;
                default:
                    Console.WriteLine("Error 404...");
                    break;
            }
        }

        public static void Struct()
        {
            // Struct
            Point p;
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);
            p = new Point();
            Console.WriteLine(p);
        }

        public static void Nullable()
        {
            // Nullable
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");

            if (y.HasValue)
                Console.WriteLine(y.Value);
            else
                Console.WriteLine("Y is null");

        }

        public static void Coalencia()
        {
            // Operador Coalência
            double? x = null;
            double? y = 10;

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        public static void Vetores1()
        {
            Console.Write("Digite o tamanho do array: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o valor " + (i + 1) + ": ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;

            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

}