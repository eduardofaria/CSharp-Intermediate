using System.Security.Cryptography.X509Certificates;

namespace CSharp_Intermediate
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);
        }


        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] {1, 2, 3, 4, 5, 6}));

        }

        static void Try_Parse()
        {
            //var number = int.Parse("abc");
            int number;
            var result = int.TryParse("abc", out number);
                if (result)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Conversion fail.");
            }
        }

        static void UsePoint()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine($"Point is at ({point.X}, {point.Y})");
                //Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
                point.Move(100, 200);
                Console.WriteLine($"Point now moved to ({point.X}, {point.Y})");
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");
                //throw;
            }
        }



    }
}
