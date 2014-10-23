using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryInformationApp
{
    class Calculator
    {
        public double Add(double firstNo,double secondNo)
        {
            return firstNo + secondNo;
        }

        public double Subtrect(double firstNo,double secondNo)
        {
            return firstNo - secondNo;
        }

        public double Divide(double firstNo, double secondNo)
        {
            return firstNo/secondNo;
        }

        public double Multiply(double firstNo,double secondNo)
        {
            return firstNo*secondNo;
        }
    }
}
