using Program.Entities;
using Program.Entities.Enums;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            int menu = 1;
            switch(menu)
            {
                case 1: UsingEnums();
                    break;
                default:
                    Console.WriteLine("Error 404");
                    break;
            }
        }

        public static void UsingEnums()
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}