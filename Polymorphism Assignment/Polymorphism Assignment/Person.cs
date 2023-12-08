using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    public abstract class Person //Abstract class Person with properties and a method
    {
        public string FirstName { get; set; }
        public string LasName { get; set; }

        public abstract void SayName();
    }
}
