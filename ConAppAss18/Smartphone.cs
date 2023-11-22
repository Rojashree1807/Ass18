using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAss18
{
    // Electronic device classes
    class Smartphone : IConnectable, IRechargeable, IDisplayable
    {
        public string Model { get; set; }

        public Smartphone(string model)
        {
            Model = model;
        }

        public bool Connect()
        {
            // Implementation for Connect method
            Console.WriteLine($"{Model} connected successfully.");
            return true;
        }

        public void Charge(int minutes)
        {
            // Implementation for Charge method
            Console.WriteLine($"{Model} is charging for {minutes} minutes.");
        }

        public string Display()
        {
            // Implementation for Display method
            return $"{Model} display: Home screen";
        }
    }

}
