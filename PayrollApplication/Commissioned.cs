using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollApplication
{
    class Commissioned : IEmployeeType
    {
        public double pay; // Pay = base week rate + commision rate * sales amount
        public int weeklyRate;
        public double commissionRate;
        public int salesAmount;
        public Commissioned(int weeklyRate, double commissionRate, int salesAmount)
        {
            weeklyRate = weeklyRate;
            commissionRate = commissionRate;
            salesAmount = salesAmount;
        }

        public double Pay()
        {
            pay = weeklyRate + (double)(commissionRate * salesAmount);
            return pay;
        }
    }
}
