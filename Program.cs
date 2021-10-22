using System;
using System.Collections.Generic;
using System.Linq;

namespace CollegeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            College college = new College();

            College college2 = new College();

            college2.Name = "College of Programming number 2";

            college.Name = "College of Programming";
            
            college.Established = new DateTime(2021, 10, 20, 9, 30, 0);

            Console.WriteLine($"Welcome to the {college.Name}, Established {college.Established}");

            PopulateDataManually(college);

            PopulateStudentsWithFaker(college);

            PopulateEmployeesWithFaker(college);

            PrintStudentsWhoDidNotFinish(college);

            PrintListOfGraduates(college);
        }

        static void PopulateDataManually(College college)
        {
            Employee employee1 = new Employee();
            employee1.FirstName = "Trevor";
            employee1.LastName = "MacDonald";
            employee1.Status = EmployeeStatus.Employed;

            Employee employee2 = new Employee();
            employee2.FirstName = "Trevor";
            employee2.LastName = "MacDonald";
            employee2.Status = EmployeeStatus.Employed;

            Student student1 = new Student();
            student1.FirstName = "Paul";
            student1.LastName = "Daniels";
            student1.Status = StudentStatus.Undergraduate;

            college.Employees = new List<Employee>
            {
                employee1,
                employee2
            };

            college.Students = new List<Student>
            {
                student1
            };
        }

        static void PopulateStudentsWithFaker(College college) {
            
            for (int i = 0; i < 200; i++)
            {
                college.Students.Add(new Student
                {
                    FirstName = Faker.Name.First(),
                    LastName = Faker.Name.Last(),
                    Status = Faker.Enum.Random<StudentStatus>()
                });
            }
        }

        static void PopulateEmployeesWithFaker(College college) {
            
            for (int i = 0; i < 50; i++)
            {
                college.Employees.Add(new Employee
                {
                    FirstName = Faker.Name.First(),
                    LastName = Faker.Name.Last(),
                    Status = Faker.Enum.Random<EmployeeStatus>()
                });
            }
        }

        static void PrintStudentsWhoDidNotFinish(College college)
        {
            foreach (Student student in college.Students)
            {
                if (student.Status == StudentStatus.DidNotFinish)
                {
                    Console.WriteLine($"Student {student.FullName} did not finish");
                }
            }
        }

        static List<Student> GraduateStudents(College college)
        {
            return college.Students.Where(s => s.Status == StudentStatus.Graduate).ToList();
        }

        static void PrintListOfGraduates(College college)
        {
            List<Student> graduateStudents = GraduateStudents(college);

            Console.WriteLine("List of graduate students :-");

            foreach (Student student in graduateStudents)
            {
                Console.WriteLine(student.FullName);
            }
        }
    }
}
