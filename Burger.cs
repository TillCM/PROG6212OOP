using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Burger
    {
        private string patty ="beef ";
        private string bun = "plain";

       public virtual string getPatty()
        {
            return patty;
        }

       public  string getbun()
        {
            return bun;
        }

       public  string getbun(string typeofBun)
        {
            return typeofBun;
        }

       public  string getbun (string typeofBunOne, string typeofBunTwo)
        {
            return typeofBunOne + " " + typeofBunTwo;
        }

       public string getbun (string typofBunOne, string typeofBunTwo, string typeofBunThree)
        {
            return typofBunOne + " " + typeofBunTwo + " " + typeofBunThree;
        }



    }
}
