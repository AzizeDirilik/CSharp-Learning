namespace OPP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Individual individual = new Individual();

            individual.CustomerId = 1;
            individual.CustomerNumber = "1212";
            individual.TcNumber = "12121212";
            individual.CustomerFirstName = "aaa";
            individual.CustomerLastName = "bbb";


            Customer customer = new Individual();
            CustomerManager manager = new CustomerManager();    
            

        }
    }
}
