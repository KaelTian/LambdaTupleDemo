using System;
using System.Security.Cryptography.X509Certificates;

namespace CSharp_Demo
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var stock = new Stock("Kael Symbol");
        //    stock.Price = 110;
        //    stock.PriceChanged += stock_PriceChanged;
        //    stock.Price = 135;
        //    Console.ReadLine();

        //}

        //static void stock_PriceChanged(object sender, PriceChangedEventArgs e)
        //{
        //    if ((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
        //    {
        //        var stock = sender as Stock;
        //        if (stock != null)
        //            Console.WriteLine($"Current symbol:{stock.Symbol}");
        //        Console.WriteLine("Alert, 10% stock price increase!");
        //    }
        //}

        //delegate int Square(int x);
        static void Main(string[] args)
        {
            //Square square = x => x * x;
            //Console.WriteLine(square(4));


            Func<int, int> sqr = x => x * x;
            Console.WriteLine(sqr(6));

            var tuple = (Name: "Kael", Age: 18);

            var tupleDemo = new TupleDemo();
            var person = tupleDemo.GetPerson();
            (string name, int age) = tupleDemo.GetPerson(); 
            //Tuple
            //ValueTuple
            //两个是不同的,ValueType是C# 7的新语法
            Console.ReadLine();

        }

    

    }
}
