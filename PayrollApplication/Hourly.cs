using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollApplication
{
    class Hourly : IEmployeeType
    {
        public double pay;
        public int hoursWorked;
        public double hourlyRate;
        public Hourly(int hoursWorked, double hourlyRate)
        {
            hoursWorked = hoursWorked;
            hourlyRate = hourlyRate;
        }

        public double Pay()
        {
            pay = hourlyRate * hoursWorked;
            return pay;
        }
    }
}
