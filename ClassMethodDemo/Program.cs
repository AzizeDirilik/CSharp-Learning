namespace ClassMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "Ayse";
            customer.LastName = "Yilmaz";
            customer.Id = 1;

            Customer customer2 = new Customer();
            customer2.FirstName = "Ali";
            customer2.LastName = "Veli";
            customer2.Id = 2;

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer);
            Console.WriteLine("*******");

            customerManager.RemoveCustomer(customer2);
            Console.WriteLine("*******");
            customerManager.CustomerInfo(customer);







        }
    }
}

