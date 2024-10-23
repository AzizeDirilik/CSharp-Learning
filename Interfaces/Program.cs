namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  Demo();
            ICustomerDal[] customerDals = new ICustomerDal[3] 
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal(),
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Delete();
            }
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }
    }
}
