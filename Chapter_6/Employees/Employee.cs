using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    // داریم پارشال بازی در میاریم
    abstract partial  class Employee
    {
        
        // Constructors.
        public Employee() { }

        public Employee(string name, int id, float pay)
            : this(name, 0, id, pay, EmployeePayTypeEnum.Salaried) { }
        public Employee(string name, int age, int id, float pay, EmployeePayTypeEnum payType)
        {
            Name = name;
            Age = age;
            Id = id;
            Pay = pay;     
            PayType = payType;
        }

        public Employee(string name , int age , int id , float pay , string empSsn , EmployeePayTypeEnum payType)
        {
            Name = name;
            Age = age;
            Id = id;
            Pay = pay;
            SocialSecurityNumber = empSsn;
            PayType = payType;

        }


        // Methods

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

        // Expose certain benefit behaviors of object.
        public double GetBenefitCost()
        => EmpBenefits.ComputePayDeduction();


        public virtual void DisplayStats()
        {
            Console.WriteLine("Name: {0}", EmpName);
            Console.WriteLine("ID: {0}", EmpId);
            Console.WriteLine("Pay: {0}", CurrPay);
            Console.WriteLine("Age: {0}", EmpAge);
        }

        public static void GivePromotion(Employee employ)
        {   
            // add switch and pattern matching to explicit casting
            switch (employ)
            {
                case SalesPerson s:
                    Console.WriteLine("{0} sold {1}",
                        employ.Name , s.SalesNumber);
                    break;
                case Manager m:
                    Console.WriteLine("{0} has {1} promotion"
                        ,employ.Name, m.StockOptions);
                    break;
                
            }

            if (employ is SalesPerson)
            {
                Console.WriteLine("{0} promote shod va {1} sale anjam dad",
                        employ.Name,((SalesPerson)employ).SalesNumber);
            }
            else if (employ is Manager)
            {
                Console.WriteLine("{0} had {1} stock options",
                    employ.Name,((Manager)employ).StockOptions);
            }
        }

        
    }
}
