using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("oracle added");

        }

        public void Delete()
        {
            Console.WriteLine("oracle deleted");

        }

        public void Update()
        {
            Console.WriteLine("oracle updated");

        }
    }
}
