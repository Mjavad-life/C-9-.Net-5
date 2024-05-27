using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Manager : Employee
    {

        // سازنده ای که از سازنده دیگر ارث میبرد
        public Manager(string fullName, int age, int empId,
                 float currPay, string ssn, int numbOfOpts)
                    : base(fullName, age, empId, currPay, ssn,
                                EmployeePayTypeEnum.Salaried)
        {
            // This property is defined by the Manager class.
            StockOptions = numbOfOpts;
        }

        // سازنده پیش فرض رو یادم نره
        public Manager() { }

        // پراپرتی
        public int StockOptions { get; set; }

        // متدی که در کلاس والد مجازی بود رو 
        // intellisense باز نویسی کردم با کمک 
        public override void DisplayStats()
        {
            base.DisplayStats();
        }
    }
}
