namespace KalkulatorOcen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vnesi oddelek studenta");
            int oddelek = int.Parse(Console.ReadLine());

            switch(oddelek)
            {
                case 1:
                    break;
                case 2:
                    StudentMat m = new StudentMat();
                    Console.WriteLine("unesi delni 1");
                    m.Delni1=int.Parse(Console.ReadLine());

                    Console.WriteLine("unesi delni 2");
                    m.Delni2 = int.Parse(Console.ReadLine());

                    Console.WriteLine(m.Izpis());
                    break;
                case 3:
                    break;

            }
        }
    }
}