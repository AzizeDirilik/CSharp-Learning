using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;

namespace InterfaceAbstractDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Entities.Customer
            {
                DateOfBirth = new DateTime(2000, 10, 30),
                FirtName = "Azize",
                LastName = "Dirilik",
                NationalityId = "10007419170"
            });
            


        }
    }

}
