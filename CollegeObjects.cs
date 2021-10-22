using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp
{
    public class College
    {
        public string Name { get; set; }

        public DateTime Established { get; set; }

        public List<string> Address { get; set; }

        public List<Student> Students { get; set; }

        public List<Employee> Employees { get; set; }
    }

    public class Person
    {
        public Guid ID { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get { return $"{FirstName} {LastName}"; } }

        public string BadgeNumber { get; set; }

    }

    public enum StudentStatus
    {
        Unknown = 0,
        Undergraduate = 1,
        DidNotFinish = 2,
        Graduate = 3,
        Postgraduate = 4,
    }

    public enum EmployeeStatus
    {
        Unknown = 0,
        Employed = 1,
        Sacked = 2,
        Retired = 3,
    }

    public class Student : Person
    {
        public StudentStatus Status { get; set; }
    }

    public class Employee : Person
    {
        public EmployeeStatus Status {get; set;}
    }

}
