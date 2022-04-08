using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollApplication
{
    class Salaried : IEmployeeType
    {
        public double pay;
        public Salaried(int weeklyRate)
        {
            pay = weeklyRate;
        }
        public double Pay()
        {
            return pay;
        }
    }
}
