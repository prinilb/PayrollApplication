using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollApplication
{
    class Hourly : IEmployeeType
    {
        public double pay;

        public Hourly(int hoursWorked, double hourlyRate)
        {
            pay = hourlyRate * hoursWorked;
        }

        public double Pay()
        {
            return pay;
        }
    }
}
