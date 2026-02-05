namespace Avto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Avto a1 = new Avto("GO-GF-915",165,6.8);
            a1.Izpis();


            Avto a2 = new Avto("LJ-B3-785", 200, 7.2,28.9,87345);
            a2.Izpis();
            Console.WriteLine("lahko prevozite se "+a2.Doseg()+" km");
            Console.WriteLine("naslednji servis "+a2.NaslednjiServis(15000));
        }
    }
}