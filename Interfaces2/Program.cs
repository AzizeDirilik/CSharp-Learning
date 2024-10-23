namespace Interfaces2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IPersonManager customer = new CustomerManager();
            //customer.Add();
            //IPersonManager employee = new EmployeeManager();
            //employee.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new CustomerManager());
            projectManager.Add(new InternManager());

        }


    }
    // inhetits --> class
    // implements --> interface
    // interfacelerin ici bos birakilmali 
    // interfaceler new'lenemez
    interface IPersonManager
    {
        void Add();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine( "Musteri Eklendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel Eklendi");

        }
    }
    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");

        }
    }


    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
              personManager.Add();
        }
    }

}
