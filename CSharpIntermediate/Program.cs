using System;

namespace CSharpIntermediate
{
    class Program
    {
        
        static void Main(string[] args)
        {
                        //var person = Person.Parse("John");
            ////person.Name = "Alex";
            //person.Introduce("Irina");

            var customer = new Customer(1, "Alex");

            var order = new Order();
            customer.Orders.Add(order);


            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);


            UsePoints();
            useParams();

            int number;
            var result = int.TryParse("abc", out number);
            if(result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed");




            var customerOne = new CustomerOne(1);
            customerOne.Orders.Add(new OrderOne());
            customerOne.Orders.Add(new OrderOne());
            customerOne.Orders.Add(new OrderOne());
            customerOne.Orders.Add(new OrderOne());
            

            

            Console.WriteLine("Number of customer's orders: " + customerOne.Orders.Count);


            var human = new Human("Carl");
            human.SetBirthday(new DateTime(1987, 1, 1));
            Console.WriteLine(human.GetBirthday());


            Console.WriteLine("Age is " + human.Age);

            Console.WriteLine("Name is " + human.Name);

            var cookie = new HttpCookie();
            cookie["name"] = "Alex";
            Console.WriteLine("This is cookie name " + cookie["name"]);

        }



        static void useParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 4));
            Console.WriteLine(calculator.Add(1, 2, 456, 3425));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5, 6, 6 }));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(40, 60));
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured");
            }
        }

    }
}
