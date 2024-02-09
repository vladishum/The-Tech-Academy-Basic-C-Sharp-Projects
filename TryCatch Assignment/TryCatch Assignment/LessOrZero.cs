using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch_Assignment
{
    public class LessOrZero : Exception//Exception to handle less or zero numbers
    {
        public LessOrZero() : base() { }
        public LessOrZero(string message) : base(message) { }
    }
}
