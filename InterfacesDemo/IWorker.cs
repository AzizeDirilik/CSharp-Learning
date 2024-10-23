using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
     interface IWorker
    {
        void Work();
    }

     interface IEat
    {
        void Eat() {
            Console.WriteLine("s");
        }
    }
     interface ISalary
    {
        void GetSalary();
    }
}
