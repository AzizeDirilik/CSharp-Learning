﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ConsumerCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("ihtiyac kredisi hesaplandi");
        }
    }
}
