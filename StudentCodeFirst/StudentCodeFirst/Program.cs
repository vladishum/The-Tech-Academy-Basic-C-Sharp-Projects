using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill",
                    DateOfBirth = Convert.ToDateTime("28/09/1991"),
                    Height = 180.0m,
                    Weight = 90
                };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
