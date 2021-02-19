using System;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesPerson fred = new SalesPerson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;

            Console.WriteLine("***** The Employee Class Hierarchy *****\n");

            Manager chucky = new Manager("Chucky", 50, 92, 100000, 9000);
            chucky.GiveBonus(300);
            chucky.DisplayStats();

            Console.WriteLine();

            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, 31);
            fran.GiveBonus(200);
            fran.DisplayStats();

            for(int i = 0; i< 100 )
            {
                Console.Beep();
            }
            Console.ReadLine();
        }
    }
}
