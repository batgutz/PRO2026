namespace Oseba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oseba o1 = new Oseba("Lynx", 12);
            Console.WriteLine("starost v mesecih : "+o1.GetAgeinMonths());
            Console.WriteLine("oseba polnoletna : "+o1.IsAdult(o1));
        }
    }
}