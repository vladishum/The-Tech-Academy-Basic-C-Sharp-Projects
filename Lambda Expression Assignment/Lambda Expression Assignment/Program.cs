using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cretae List of employees named campus
            List<Employee> campus = new List<Employee>();

            //Add List Items to campus
            campus.Add(new Employee() { Id = 1, FirstName = "Joe", LastName = "Meck" });
            campus.Add(new Employee() { Id = 2, FirstName = "Moe", LastName = "Sheck" });
            campus.Add(new Employee() { Id = 3, FirstName = "Foe", LastName = "Deck" });
            campus.Add(new Employee() { Id = 4, FirstName = "Doe", LastName = "GLeck" });
            campus.Add(new Employee() { Id = 5, FirstName = "Goe", LastName = "Beck" });
            campus.Add(new Employee() { Id = 6, FirstName = "Joe", LastName = "Jeck" });
            campus.Add(new Employee() { Id = 7, FirstName = "Koe", LastName = "Heck" });
            campus.Add(new Employee() { Id = 8, FirstName = "Foe", LastName = "Leck" });
            campus.Add(new Employee() { Id = 9, FirstName = "Poe", LastName = "Qeck" });
            campus.Add(new Employee() { Id = 10, FirstName = "Joe", LastName = "Zeck" });

            //Create new Employee List
            List<Employee> newList1 = new List<Employee>();

            foreach (Employee employee in campus)//Check for every item in campus
            {
                if (employee.FirstName == "Joe")//If employee FirstName is Joe
                {
                    newList1.Add(employee);//Add it to the new List
                    Console.WriteLine(employee.Id + " " + employee.FirstName + " " +  employee.LastName);
                }
            }

            List<Employee> newList2 = campus.Where(x => x.FirstName == "Joe").ToList();//Adding Joes the new List but with lambda expression
            newList2.ForEach(x => Console.WriteLine(x.Id));

            List<Employee> newList3 = campus.Where(x => x.Id > 5).ToList();//Adding employees with id higher than 5 to a new List with lambda expression
            newList3.ForEach(x => Console.WriteLine(x.Id));

            Console.ReadLine();
        }
    }
}
