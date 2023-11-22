using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAss18
{
    internal class Program
    {
        static void Main()
        {
            // Demonstrate usage
            Smartphone smartphone = new Smartphone("Redmi 12 5G");
            smartphone.Connect();
            smartphone.Charge(60);
            Console.WriteLine(smartphone.Display());

            Console.WriteLine();

            Laptop laptop = new Laptop("ASUS");
            laptop.Connect();
            laptop.Charge(120);
            Console.WriteLine(laptop.Display());
            Console.ReadKey();
        }

    }
}
