using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollApplication
{
    class Commissioned : IEmployeeType
    {
        public double pay; // Pay = base week rate + commision rate * sales amount
      
        public Commissioned(int weeklyRate, double commissionRate, int salesAmount)
        {
            pay = weeklyRate + (double)(commissionRate * salesAmount);
        }

        public double Pay()
        {
            
            return pay;
        }
    }
}
