using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalaryInformationApp
{
    class Salary
    {
        public string name;
        public double basic;
        public double houseRentPercent;
        public double medicalAllowancePercent;
        private Calculator aCalculator=new Calculator();

        public double GetMedicalAmount()
        {
            return aCalculator.Multiply(basic, medicalAllowancePercent) / 100;
        }

        public double GetHouseRent()
        {
            return aCalculator.Multiply(basic, houseRentPercent)/100;
        }

        public double GetTotal()
        {
            double medicalAmount = GetMedicalAmount();
            double houseRentAmount = GetHouseRent();
            return aCalculator.Add(aCalculator.Add(basic, medicalAmount), houseRentAmount);
        }

    }
}
