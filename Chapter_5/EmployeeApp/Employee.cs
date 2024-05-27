using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    // داریم پارشال بازی در میاریم
    partial class Employee
    {
        
        // Constructors.
        public Employee() { }

        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay, EmployeePayTypeEnum.Salaried) { }
        public Employee(string name, int age, int id, float pay, EmployeePayTypeEnum payType)
        {
            Name = name;
            Age = age;
            _empId = id;
            Pay = pay;
            PayType = payType;
        }

        // Methods.
        public void GiveBonus(float amount)
        {
            Pay = this switch
            {
                { PayType: EmployeePayTypeEnum.Commission }
                    => Pay += .10F * amount,
                { PayType: EmployeePayTypeEnum.Hourly }
                    => Pay += 40F * amount / 2080F,
                { PayType: EmployeePayTypeEnum.Salaried }
                    => Pay += amount,
                  _ => Pay += 0
            };
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", _empName);
            Console.WriteLine("ID: {0}", _empId);
            Console.WriteLine("Pay: {0}", _currPay);
            Console.WriteLine("Age: {0}", _empAge);
        }

        
    }
}
