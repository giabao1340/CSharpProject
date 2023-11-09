using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau_3
{
    internal class Laptop: Computer
    {
        private double battery;
        private double screenSize;
        //Constructor
        public Laptop() { }
        public Laptop(string cpu, int ram, int storage, double price,double battery, double screenSize)
            : base(cpu, ram, storage, price)
        {
            this.battery = battery;
            this.screenSize = screenSize;
         
        }
        //Method
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Battery: ");
            battery = double.Parse(Console.ReadLine());
            Console.Write("Screen size: ");
            screenSize = double.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return base.ToString() + $", Battery: {battery}, Screen size: {screenSize}";
        }

    }
}
