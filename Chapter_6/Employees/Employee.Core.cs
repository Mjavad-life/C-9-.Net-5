using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
   partial class Employee
    {

        // Field data.
        // turn private to protected
        // turn camel case to pascal case _empName to EmpName
        protected string EmpName;
        protected int EmpId;
        protected float CurrPay;
        protected int EmpAge;
        protected string EmpSsn;

        protected EmployeePayTypeEnum EmpPayType;

        //آورده BenefitPackage یک نمونه از کلاس 
        protected BenefitPackage EmpBenefits = new BenefitPackage();

        
        // Expose object through a custom property.
        public BenefitPackage Benefits
        {
            get { return EmpBenefits; }
            set { EmpBenefits = value; }
        }

        // اولین پراپرتی
        // اسم پراپرتی نمیتواند با فیلد همنام باشد
        public string Name
        {
            //  باید یه چیزی برگردونه get 
            get { return EmpName; }
            set { EmpName = value; }
        }

        //دومین پراپرتی 
        public int Id
        {
            get { return EmpId; }
            set { EmpId = value; }
        }

        //سومین پراپرتی
        public float Pay
        {
            get { return CurrPay; }
            set { CurrPay = value; }
        }
        
        // چهارمین پراپرتی
        public int Age
        {
            get { return EmpAge; }
            set { EmpAge = Age; }
        }
        
        // پنجمین پراپرتی
        public string SocialSecurityNumber
        {
            get { return EmpSsn; }
            set { EmpSsn = value; }
        }

        //ششمین پراپرتی
        // enum یک پراپرتی از نوع
        public EmployeePayTypeEnum PayType
        {
            get => EmpPayType;
            set => EmpPayType = value;
        }
    }
}
