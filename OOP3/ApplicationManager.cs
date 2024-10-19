using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        public void SubmitApplication(ICreditManager creditManager)
        {
            creditManager.Calculate();
        }

        public void providePreliminaryInformation(List <ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
