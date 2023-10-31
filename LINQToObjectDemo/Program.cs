using LINQToObjectDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQToObjectDemo
{
    public class Employee

    {
    public int Id { get; set; }

    public string Name { get; set; }

    public string City { get; set; }

    public int Salary { get; set; }


     }




    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Id = 1, Name = "Sandesh", City = "Pune", Salary = 90000 },
                new Employee { Id = 2, Name = "Rushi", City = "Nagar", Salary = 35000 },
                new Employee { Id = 3, Name = "Raj", City = "Nagpur", Salary = 85000 },
                new Employee { Id = 4, Name = "Sagar", City = "Mumbai", Salary = 20000 },
                new Employee { Id = 5, Name = "Rohit", City = "Solapur", Salary = 50000 },
                new Employee { Id = 6, Name = "Sujit", City = "Pune", Salary = 65000 },
                new Employee { Id = 7, Name = "Omkar", City = "Kolhapur", Salary = 45000 },
                new Employee { Id = 8, Name = "Shubham", City = "Pune", Salary = 40500 },
                new Employee { Id = 9, Name = "Chidanad", City = "Nashik", Salary = 80000 },
            };


            //var result1  = from e in employees
            //             where e.City == "Pune"
            //             select e;
            //foreach(Employee item in result1)
            //{
            //    Console.WriteLine($"{item.Id},{item.Name},{item.City},{item.Salary}");
            //}


            //var result2 = from e in employees
            //              where e.Name.StartsWith("S")
            //              select e;
            //foreach (Employee item in result1)
            //{
            //    Console.WriteLine($"{item.Id},{item.Name},{item.City},{item.Salary}");
            //}

            //var result3 = from e in employees
            //              where e.Salary> 24000 && e.City=="Pune"
            //              select e;

            //foreach (Employee item in result1)
            //{
            //    Console.WriteLine($"{item.Id},{item.Name},{item.City},{item.Salary}");
            //}


            //var result4 = employees.Where(x => x.City == "Mumbai").ToList();

            //foreach (Employee item in result4)
            //{
            //    Console.WriteLine($"{item.Id},{item.Name},{item.City},{item.Salary}");
            //}


            var result5 = employees.Where(x => x.City == "Pune").OrderBy(x => x.Salary).ToList();

            foreach (Employee item in result5)
            {
                Console.WriteLine($"{item.Id}, {item.Name},{item.City},{item.Salary}");
            }

        }
    }

}
    

