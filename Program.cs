using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Github10._02
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ivett";
            Console.WriteLine($"Hello, { name}!");
            Console.WriteLine($"{name}, do you like cats?");
            Console.Write(">>> ");
            string resp = Console.ReadLine();
            if (resp.ToLower().StartsWith("yes"))
            {
                Console.WriteLine("awwwe :3 :3 ");
            }
            else
            {
                Console.WriteLine(":(((((");
            }
        }
    }
}
