using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
   partial class Employee
    {
        // Field data.
        private string _empName;
        private int _empId;
        private float _currPay;
        private int _empAge;

        private EmployeePayTypeEnum _payType;

        // enum یک پراپرتی از نوع
        public EmployeePayTypeEnum PayType
        {
            get => _payType;
            set => _payType = value;
        }

        // اسم پراپرتی نمیتواند با فیلد همنام باشد
        public string Name
        {
            //  باید یه چیزی برگردونه get 
            get { return _empName; }
            set { _empName = value; }
        }

        //دومین پراپرتی 
        public int Age
        {
            get { return _empAge; }
            set { _empAge = Age; }
        }

        // سومین پراپرتی
        public float Pay
        {
            get { return _currPay; }
            set { _currPay = value; }
        }
    }
}
