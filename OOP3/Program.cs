namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditManager consumerCreditmanager = new ConsumerCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager mortgageManager = new MortgageManager();

            ILoggerService databaseLoggerService  = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();



            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.SubmitApplication(mortgageManager, fileLoggerService);


            //List<ICreditManager> credits = new List<ICreditManager>() { mortgageManager, vehicleCreditManager };

            //applicationManager.providePreliminaryInformation(credits);

        }
    }
}
  