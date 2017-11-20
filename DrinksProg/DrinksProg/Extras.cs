using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksProg
{
    public class Extras : Product
    {
        private bool isExtraOfDrink;

        public Extras()
        {

        }


        //public Extras(Extras extra)
        //    : base(extra)
        //{
        //    IsExtraOfDrink = extra.IsExtraOfDrink;
        //}


        public Extras(string name, decimal price)
            :base(name,price)
        {
            
        }


        public bool IsExtraOfDrink
        {
            get { return isExtraOfDrink; }
            set { isExtraOfDrink = value; }
        }

        
    }
}
