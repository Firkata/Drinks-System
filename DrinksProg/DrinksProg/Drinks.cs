using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksProg
{
    public class Drinks : Product
    {
        private List<Extras> extrasList;

        public Drinks()
        {
            extrasList = new List<Extras>();
        }


        //public Drinks(Drinks drink)
        //    : base(drink)
        //{
        //    extrasList = new List<Extras>();
        //}


        public Drinks(string name, decimal price)
            : base(name, price)
        {
            extrasList = new List<Extras>();
        }


        public List<Extras> ExtrasList
        {
            get { return extrasList; }
            set { extrasList = value; }
        }

    }
}
