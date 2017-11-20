using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksProg
{
    [System.Xml.Serialization.XmlInclude(typeof(Drinks)), System.Xml.Serialization.XmlInclude(typeof(Extras))]
    public abstract class Product
    {

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        private string currency;

        public string Currency
        {
            get { return currency; }
            set { currency = value; }
        }

        public Product()
        {

        }


        //public Product(Product product)
        //{
        //    Name = product.Name;
        //    Price = product.Price;
        //    Currency = product.Currency;
        //}


        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

    }
    
}
