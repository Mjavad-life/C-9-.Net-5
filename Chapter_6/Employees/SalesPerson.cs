using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class SalesPerson : Employee
    {
        public SalesPerson(string fullName, int age, int empId,
         float currPay, string ssn, int numbOfOpts)
            : base(fullName, age, empId, currPay, ssn,
                        EmployeePayTypeEnum.Commission)
        {
            SalesNumber = numbOfOpts;
        }

        // سازنده پیش فرض رو یادم نره
        public SalesPerson() { }
        public int SalesNumber { get; set; }
        
    }
}
