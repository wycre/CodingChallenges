using System;

namespace EmployeeManagementSystem
{
    // Complete this part: Delegate for calculating salary: should be public and of tyoe decimal, call it SalaryCalculator and pass object called employee of type Employee to it.
    public delegate decimal SalaryCalculator(Employee employee);

    // Employee Class
    public class Employee
    {
        public string Name { get; set; }
        public string EmployeeType { get; set; }
        public decimal Salary { get; set; }
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }

        public Employee(string name, string employeeType, decimal salary = 0, int hoursWorked = 0, decimal hourlyRate = 0)
        {
            Name = name;
            EmployeeType = employeeType;
            Salary = salary;
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
        }

        // Method to calculate salary for full-time employee
        public static decimal CalculateFullTimeSalary(Employee employee)
        {
            return employee.Salary;  // Fixed salary for full-time employees
        }

        // Method to calculate salary for part-time employee
        public static decimal CalculatePartTimeSalary(Employee employee)
        {
            return employee.HoursWorked * employee.HourlyRate;  // Hourly rate for part-time employees
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a full-time employee
            Employee fullTimeEmployee = new Employee("John", "Full-time", salary: 5000);

            // Create a part-time employee
            Employee partTimeEmployee = new Employee("Jane", "Part-time", hoursWorked: 120, hourlyRate: 20);

            // Delegate instances for calculating salaries
            SalaryCalculator fullTimeSalaryCalculator = new SalaryCalculator(Employee.CalculateFullTimeSalary);
            SalaryCalculator partTimeSalaryCalculator = new SalaryCalculator(Employee.CalculatePartTimeSalary);

            // Calculate and display salaries
            Console.WriteLine($"{fullTimeEmployee.Name} (Full-time) Salary: {fullTimeSalaryCalculator(fullTimeEmployee):C}");
            Console.WriteLine($"{partTimeEmployee.Name} (Part-time) Salary: {partTimeSalaryCalculator(partTimeEmployee):C}");
        }
    }
}