using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksProg
{
    public class ProductEventArgument : EventArgs
    {
        private Product product;

        public Product Product
        {
            get { return product; }
            set { product = value; }
        }
    }
}
