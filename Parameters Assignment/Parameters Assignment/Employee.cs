using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    //Create class with generic type parameter
    public class Employee<T>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public List<T> Things { get; set; } //List with the generic type parameter of the class
    }
}
