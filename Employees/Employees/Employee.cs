using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    partial class Employee
    {

        public virtual void GiveBonus(float amount)
        {
            currPay = currPay + amount;
        }

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name); 
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay); 
        }

        public double GetBenefitCost()
        {
            return empBenefits.ComputePayDeduction();
        }

        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 20)
                {
                    Console.WriteLine("error");
                }
                else
                {
                    empName = value;
                }
            }
        }
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }


    }
}
