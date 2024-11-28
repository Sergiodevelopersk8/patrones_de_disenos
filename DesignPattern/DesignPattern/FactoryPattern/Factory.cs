using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern
{
    //creator
    public abstract class SaleFactory
    {
        public abstract ISale GetSale();
    }

    //concret creator
    public class StoreSaleFactrory : SaleFactory
    {
        private decimal _extra;

        public StoreSaleFactrory(decimal extra)
        {
            _extra = extra;
        }

        public override ISale GetSale()
        {
            return new StoreSale(_extra);
        }
    }


    public class InternetSaleFactory : SaleFactory
    {
        private decimal _discount;

        public InternetSaleFactory(decimal discount)
        {
            _discount = discount;
        }

        public override ISale GetSale()
        {
            return new InternetSale(_discount);
        }


    }





    //concret product
    public class StoreSale : ISale
    {
        private decimal _extra;
        public StoreSale(decimal extra)
        {
            _extra = extra;
        }
        public void Sell(decimal total)
        {
            Console.WriteLine($" la venta en la tienda tiene en total de {total + _extra}");
        }
    }



    public class InternetSale : ISale
    {
        private decimal _discount;
        public InternetSale(decimal discount)
        {
            _discount = discount;
        }
        public void Sell(decimal total)
        {
            Console.WriteLine($" la venta en la tienda tiene en total de {total - _discount}");
        }
    }





    //Producto
    public interface ISale
    {
        public void Sell(decimal total);
    }


}
