using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollApplication
{
    class Salaried : IEmployeeType
    {
        public double pay;
        int weeklyRate;
        public Salaried(int weeklyRate)
        {
            weeklyRate = weeklyRate;
        }
        public double Pay()
        {
            pay = weeklyRate;
            return pay;
        }
    }
}
