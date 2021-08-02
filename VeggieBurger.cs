using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class VeggieBurger: Burger
    {
        string patty = "mushroom";

        public override string getPatty()
        {
            return patty;
        }


    }
}
