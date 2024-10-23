namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<Person> persons = new List<Person>();

            {
              persons.Add(  new Customer { Id = 1 , FirstName = "Azize", LastName = "Dirilik", City = "Kahramanmaras"});
              persons.Add( new Student { Id =2, FirstName="Mustafa", LastName = "Gulac", Departmant = "Engineering"});
            }

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

        }
    }
}
