using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    class Manager : Employee
    {
        public int StocOptions { get; set; }

        public Manager() { }
        public Manager(string fullName, int age, int empID, float currPay, int numbOfOptions) : base(fullName, age, empID, currPay)
        {
            StocOptions = numbOfOptions;
        }
        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random r = new Random();
            StocOptions += r.Next(500);
        }
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number of stock options = {0}", StocOptions);
        }
    }   
}
