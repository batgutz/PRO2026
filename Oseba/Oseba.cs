using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Oseba
{
    internal class Oseba
    {

        string ime;
        int starost;

        public Oseba(string i, int s) //nov avto
        {
            ime = i;
            starost = s;
        }

        public int GetAgeinMonths()
        {
            return starost*12;
        }

        public String IsAdult(Oseba x)
        {

            if (this.starost > 17 && this.ime == x.ime)
            {
                return "DA";
            }
            else
            {
                return "NE";
            }
        }
        //public bool IsAdult(Oseba x)
        //{
            
        //    if (this.starost >17 && this.ime == x.ime)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
