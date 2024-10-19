using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Musteri eklendi : " + customer.FirstName + " " + customer.LastName);
        }
        public void RemoveCustomer(Customer customer)
        {
            Console.WriteLine("Musteri silindi : " + customer.FirstName + " " + customer.LastName);

        }

        public void CustomerInfo(Customer customer)
        {
            Console.WriteLine("Musteri Id: " + customer.Id);
            Console.WriteLine("Musteri Isim: " + customer.FirstName);
            Console.WriteLine("Musteri Soyisim: " + customer.LastName);



        }
    }
}
