using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avto
{
    internal class Avto
    {
        int maxhitrost;
        double avgporaba;
        double kolicinagoriva;
        int stprevozenih;
        string regst;

        public Avto(string r,int n,double p) //nov avto
        {
            maxhitrost = n;
            avgporaba = p;
            regst = r;
            stprevozenih = 0;
            kolicinagoriva = 0;
        }
        public Avto(string r,int n, double p,double k,int s)
        {
            maxhitrost = n;
            avgporaba = p;
            regst = r;
            stprevozenih = s;
            kolicinagoriva = k;
        }

        public void Izpis()
        {
            Console.WriteLine("-------- AVTO --------");
            Console.WriteLine("registerska stevilka:   "+regst);
            Console.WriteLine("maksimalna hitrost:   " + maxhitrost);
            Console.WriteLine("povprecna poraba:   " + avgporaba);
            Console.WriteLine("stevilo prevozenih km:   " + stprevozenih);
            Console.WriteLine("kolicina goriva:   " + kolicinagoriva);
            Console.WriteLine("----------------------");
        }

        public double Doseg()
        {
            return kolicinagoriva *100/avgporaba;
        }
        public double NaslednjiServis(int n)
        {
            return n - stprevozenih % n;

        }
    }

}
