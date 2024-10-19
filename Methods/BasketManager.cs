using Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Sepete eklendi : " + product.Name, product.Stock);


        }


    }
}
