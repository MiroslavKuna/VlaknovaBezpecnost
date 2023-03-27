
namespace VlaknovaBezpecnost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hrac h = new("hrac1", 100, true);
            

            Task t1 = Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    h.Damage();
                    Console.WriteLine(h.ToString());
                }
            });

            Task t2 = Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    h.Heal();
                    Console.WriteLine(h.ToString());
                }
            });

            Task.WaitAll(t1, t2);
            Console.WriteLine(h.ToString());
            

        }
    }
}