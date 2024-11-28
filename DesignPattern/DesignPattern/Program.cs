using DesignPattern.FactoryPattern;
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //var log =  Singleton.Log.Instance;
            //log.Save("a");
            //log.Save("b");

            //var a = Singleton.Log.Instance;
            //var b = Singleton.Log.Instance;

            //Console.WriteLine(a == b);


            SaleFactory storeSaleFactory = new StoreSaleFactrory(10);
            SaleFactory internetSaleFactory = new InternetSaleFactory(2);


            //objeto
            ISale sale1 = storeSaleFactory.GetSale();
            sale1.Sell(15);


            ISale sale2 = internetSaleFactory.GetSale();
            sale2.Sell(15);



        }
    }
}
