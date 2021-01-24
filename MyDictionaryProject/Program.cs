using System;

namespace MyDictionaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string, string> employees = new MyList<string, string>();

            Employee List
            employees.Add("Sema Mercan", "Software Developer");
            employees.Add("Makbule Savaş", "Software Developer");
            employees.Add("Esma Saraç", "Director");
            employees.Add("Merve Duran", "Engineer");
            employees.Add("Hazal Sema Saraç", "Intern");

            for (int i = 0; i < employees.Names.Length; i++)
            {
                Console.WriteLine("Employee : " + employees.Names[i] + " : " + employees.Business[i]);
            }


            //Ya da Employee.cs classındaki property'ler ile aşağıdaki kod parçasını kullanabiliriz.
            //Employee employee1 = new Employee();
            //employee1.EmployeesName = "Sema Mercan";
            //employee1.EmployeesBusiness = "Software Developer";

            //Employee employee2 = new Employee();
            //employee2.EmployeesName = "Esma Saraç";
            //employee2.EmployeesBusiness = "Director";

            //Employee employee3 = new Employee();
            //employee3.EmployeesName = "Merve Duran";
            //employee3.EmployeesBusiness = "Engineer";

            //Employee employee4 = new Employee();
            //employee4.EmployeesName = "Hazal Sema Saraç";
            //employee4.EmployeesBusiness = "Intern";

            //Employee[] companyEmployees = new Employee[] { employee1, employee2, employee3, employee4 };
            //foreach (var employee in companyEmployees)
            //{
            //    Console.WriteLine("Employee : " + employee.EmployeesName + " : " + employee.EmployeesBusiness);

            //}
        }
    }
}
