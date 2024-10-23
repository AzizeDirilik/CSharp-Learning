using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Worker : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            Console.WriteLine("Eat");
        }

        public void GetSalary()
        {
            Console.WriteLine("Maas al");

        }

        public void Work()
        {
            Console.WriteLine("Calis");
        }
    }
}
