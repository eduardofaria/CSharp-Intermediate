﻿

using System.Globalization;
using CSharp_Intermediate;

namespace CSharp_Intermediate
{



    public class GoldCustomer : Customer_2
    {
        public void OfferVoucher()
        {

        }
    }



    class Program
    {




        // Explaining Getter Setter
        /*
        public class Person
        {
            private DateTime _birthday;

            public void SetBirthdate(DateTime birthdate)
            {
                _birthday = birthdate;
            }

            public DateTime GetBirthdate()
            {
                return _birthday;
            }

        }
        */

        static void Main(string[] args)
        {


            var customer_2 = new Customer_2();


            /* // public int CalculateRating() //
            customer_2.CalculateRating();
            var rating = customer_2.CalculateRating();
            */




            /* // COMPOSITION

            DbMigrator dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();

            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
            */


            /* INHERITANCE //
            var text = new Text();
            text.Width = 100;
            text.Copy();
            Console.WriteLine(text.Width);
            */

            /*
            var cookie = new HttpCookie();
            cookie["name"] = "Edu";

            Console.WriteLine(cookie["name"]);
            */






            //var person = new Person(new DateTime(1982, 1, 1));
            //Console.WriteLine(person.Age);




            // Explaining Getter Setter
            /*
            var person = new Person();
            person.SetBirthdate(new DateTime(1982,1,1));
            Console.WriteLine(person.GetBirthdate());
            */
        }


        static void CustomerExemple()
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
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5, 6 }));

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
