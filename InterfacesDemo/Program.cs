namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IWorker> workers = new List<IWorker>
            {
                 new Manager(),
                 new Worker(),
                 new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();

            }

            List<IEat> eats = new List<IEat>
            {
               new Manager(),
                new Worker()
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }

        }
    }
}
