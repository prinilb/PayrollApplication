using System;

namespace PayrollApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployeeType employeeOne = new Hourly(40, 36.75);
            IEmployeeType employeeTwo = new Salaried(1500);
            IEmployeeType employeeThree = new Commissioned(500, 0.2, 1000);

            Console.WriteLine($"Employee One --> Total Pay = {employeeOne.Pay()}\n");
            Console.WriteLine($"Employee Two --> Total Pay = {employeeTwo.Pay()}\n");
            Console.WriteLine($"Employee Three --> Total Pay = {employeeThree.Pay()}\n");
        }
    }
}
