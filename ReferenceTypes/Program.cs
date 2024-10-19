namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Asya";

            // Console.WriteLine(person1.FirstName);

            Person person2 = new Person();
            person2 = person1;
            person1.FirstName = "Yalin";
            Console.WriteLine(person1.FirstName);

            Customer customer = new Customer();

            customer.FirstName = "Salih";
            Employee employee = new Employee();

            Person person3 = customer;
            Console.WriteLine(person3.FirstName);

            person3 = employee;
            Console.WriteLine(employee.FirstName);
        }
    }
}
