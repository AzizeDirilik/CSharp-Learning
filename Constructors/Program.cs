namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer() { Id = 1, FirstName = "Azize", LastName = "Dirilik", City = "Kahramanmaras" };
            Customer customer2 = new Customer(1, "Mustafa", "Gulac", "Bursa");
            Console.WriteLine(customer2.Id);
            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer2.LastName);
            Console.WriteLine(customer2.City);


        }
    }
}
