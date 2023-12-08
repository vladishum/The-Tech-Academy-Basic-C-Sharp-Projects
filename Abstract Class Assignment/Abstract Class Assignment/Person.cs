﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Assignment
{
    //Abstract class with properties and abstract method
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void SayName();
    }
}
