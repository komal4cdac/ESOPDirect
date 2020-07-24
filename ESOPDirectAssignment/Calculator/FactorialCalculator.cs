using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ESOPDirectAssignment.Calculator
{
    public class FactorialCalculator
    {
        public float GetFactorial(int p)
        {
            if (p < 2)                         
                return 1;

            return p * GetFactorial(p - 1);
            //throw new NotImplementedException();    //to make the test fail
            // return 1;     //to make the test fail

        }
    }
}