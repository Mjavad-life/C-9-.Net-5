using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee john = new Employee("johny", 32, 1221);
            john.DisplayStats();
            john.Name = "mashdy gholy";
            john.DisplayStats();
        }
    }
}
