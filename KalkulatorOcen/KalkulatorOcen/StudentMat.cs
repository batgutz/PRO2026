using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalkulatorOcen
{
    internal class StudentMat : StudentAbs
    {
        public override string Izpis()
        {
            string r = "************* student MAT ***********" + Environment.NewLine;
            r += "delni 1" + delni1 + Environment.NewLine;
            r += "delni 2" + delni2 + Environment.NewLine;
            r += "ocena tock " + KoncnaOcena() + Environment.NewLine;
            r += "črka " + KoncnaCrka() + Environment.NewLine;
            return r;
        }

        public override string KoncnaCrka()
        {
            if (KoncnaOcena() >= 90)
                return "A";
            if (KoncnaOcena() >= 83)
                return "B";
            if (KoncnaOcena() >= 76)
                return "C";
            if (KoncnaOcena() >= 65)
                return "D";
            return "F";

        }

        public override double KoncnaOcena()
        {
            return delni1 * 0.5 + delni2 * 0.5;
        }
    }




}
