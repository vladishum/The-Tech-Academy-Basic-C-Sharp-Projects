using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Overload the Equals method for objects
        public override bool Equals(object o)
        {
            if (o == null)
                return false;

            var second = o as Employee;

            return second != null && Id == second.Id;
        }

        //The compiler asks for this override as well 
        public override int GetHashCode()
        {
            return Id;
        }

        //Overload the operator == on weather the Id property
        public static bool operator== (Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;          
        }

        //Overload the operator != on weather the Id property
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;
        }
    }
}
