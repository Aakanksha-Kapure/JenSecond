using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSecondApplication
{
    enum feedback
    {
        poor=1,Fair,Good,Excellent
    };

    class Department
    {
        protected int Did { get; set; }
        protected string Dname { get; set; }
        protected string City { get; set; }

        internal Department(int Did, string Dname, string City)
        {
            this.Did = Did;
            this.Dname = Dname;
            this.City = City;
        }

        protected internal void DisplayDepartmentInfo()
        {
            Console.WriteLine("Did: {0} || Dname: {1} || City:{2}", Did, Dname, City);
        }
        ~Department()
        {
            Console.WriteLine("Department Destructor");
        }
    }

    //Single Inheritance
    class Employee : Department
    {
        internal static string CompanyName = "LTI";
        internal int Eid { get; set; }
        internal string name { get; set; }
        internal string city = "Mumbai";

        internal Employee(int Eid, string name, int Did , string Dname, string City) : base(Did, Dname, City)
        {
            Console.WriteLine("Employee Constructor");
            this.Eid = Eid;
            this.name = name;
        }

        internal void DisplayEmployeeInfo()
        {
            DisplayDepartmentInfo();
            Console.WriteLine("Department City is{0}" ,base.City);
            Console.WriteLine("Eid:{0} || Ename:{1} || feedback:{2}", Eid, name, feedback.Excellent);
            Console.WriteLine("Employee City is :{0}", City);

        }
        ~Employee()
        {
            Console.WriteLine("Employee Destructor");
        }

    }
    /*class PartTimeEmployee : Employee
    {
        internal int HoursofWork { get; set; }
        internal int salary { get; set; }
        internal PartTimeEmployee(int Eid, string name, int Did, string Dname, string City, int HoursofWork, int salary) : base(Eid, name, Did, Dname, City)
        {
            this.HoursofWork = HoursofWork;
            this.salary = salary;
        }
        internal int MonthlySalary()
        {
            int payment = HoursofWork * 30 * salary;
            return payment;
        }
        ~PartTimeEmployee()
        {
            Console.WriteLine("PartTimeEmployee Destructor");
        }
    }*/
    class MultiLevelinheritance
    {
        static void Main()
        {
            //Single level
            Employee emp = new Employee(1001,"Aakanksha",101,"HR","Mumbai");
            emp.DisplayEmployeeInfo();
            //error
            //employee.DisplayDepartment

            //MultiLevel
            /*PartTimeEmployee pt = new PartTimeEmployee(2001, "Aakanksha", 201, "AI", "Mumabi", 67, 200);
            pt.DisplayEmployeeInfo();
            Console.WriteLine("Monthly Salary:{0}", pt.MonthlySalary());
            GC.Collect();*/


        }
    }
}
