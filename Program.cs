using System;
using System.Threading.Tasks;

namespace VenCommandLineProgressBar
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var max = 100;
            for (int i = 0; i < max+1; i++)
            {
                Console.Write($"[{new string('#', i) + new string('-', max - i)}] ({i/(double)max*100:00}%)\r");
                await Task.Delay(100);
            }
            Console.WriteLine();
        }
    }
}
