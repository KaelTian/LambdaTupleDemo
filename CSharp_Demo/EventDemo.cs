using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CSharp_Demo
{
    public class PriceChangedEventArgs : EventArgs
    {
        public decimal LastPrice { get; private set; }

        public decimal NewPrice { get; private set; }

        public PriceChangedEventArgs(decimal lastPrice, decimal newPrice)
        {
            LastPrice = lastPrice;
            NewPrice = newPrice;
        }
    }

    public class Stock
    {
        private string symbol;
        public string Symbol
        {
            get { return this.symbol; }
        }
        decimal price;

        public Stock(string symbol)
        {
            this.symbol = symbol;
        }

        public event EventHandler<PriceChangedEventArgs> PriceChanged;

        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                if (price == value) return;
                decimal oldPrice = price;
                price = value;
                OnPriceChanged(new PriceChangedEventArgs(oldPrice, price));
            }
        }
    }

    #region Eg

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var stock = new Stock("Kael Symbol");
    //        stock.Price = 110;
    //        stock.PriceChanged += stock_PriceChanged;
    //        stock.Price = 135;
    //        Console.ReadLine();

    //    }

    //    static void stock_PriceChanged(object sender, PriceChangedEventArgs e)
    //    {
    //        if ((e.NewPrice - e.LastPrice) / e.LastPrice > 0.1M)
    //        {
    //            var stock = sender as Stock;
    //            if (stock != null)
    //                Console.WriteLine($"Current symbol:{stock.Symbol}");
    //            Console.WriteLine("Alert, 10% stock price increase!");
    //        }
    //    }
    //}

    #endregion
}
