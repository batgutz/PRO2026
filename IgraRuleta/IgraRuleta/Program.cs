namespace IgraRuleta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Dobrodošli v igro Ruleta -----");
            Console.WriteLine("Vnesite začetni denarni vložek");

            int stanje=int.Parse(Console.ReadLine());

            Console.WriteLine("Vnesite še začetno višino stave");
            int stava = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Začetni denarni vložek: "+stanje);
            Console.WriteLine("Začetna višina stave: "+ stava);

            int zacstanje = stanje;
            int zacstava = stava;
            int min = 999999999;
            int max = -99999999;

            Random r = new Random();

            for (int k = 0; k < 10; k++) {
                int st = r.Next(37);

                if (st % 2 == 0 && st != 0)
                {
                    stanje += stava;
                    stava = zacstava;
                    Console.WriteLine(k + " " + " rdeča - zmaga " + stanje);
                }
                    else {
                        stanje -= stava;
                        stava =2*stava;
                        Console.WriteLine(k + " " + " črna - izguba " + stanje);
                    }

                if (stanje < min)
                    min = stanje;
                if (stanje > max)
                    max = stanje;

            }
            Console.WriteLine("število metov 10");
            Console.WriteLine("začetno stanje " + zacstanje);
            Console.WriteLine("končno stanje " + stanje);
            Console.WriteLine("min " + min);
            Console.WriteLine("max " + max);
            Console.WriteLine("dobiček " + (stanje - zacstanje));
        }
    }
}