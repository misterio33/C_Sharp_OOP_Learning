using System;
using System.Collections.Generic;
using System.Text;

namespace Employees
{
    abstract partial class Employee
    {
        private string empName;
        private int empID;
        private float currPay;
        private int empAge;
        BenefitPackage empBenefits = new BenefitPackage();

        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            {
                Standart,
                Gold,
                Platinum
            }

            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }
        public Employee() { }
        public Employee(string name, int id, float pay)
        : this(name, 0, id, pay) { }
        public Employee(string name, int age, int id, float pay)
        {
            Name = name;
            ID = id;
            Age = age;
            Pay = pay;
        }
    }
}
