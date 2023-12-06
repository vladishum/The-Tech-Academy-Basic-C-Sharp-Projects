using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    class IntegerOperations
    {
        //Create function FunctionInteger with integer parametar and return value integer
        public int FunctionInteger(int number)
        {
            int result = number * 10;
            return result;
        }

        //Overload function FunctionInteger with decimal parametar and return value integer
        public int FunctionInteger(decimal number)
        {
            int result = Convert.ToInt32(number) / 10;
            return result;
        }

        //Create function FunctionInteger with string parametar and return value integer
        public int FunctionInteger(string number)
        {
            //Check the format of the argument
            try
            {
                int result = Convert.ToInt32(number) * 10;
                return result;
            }

            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }         
        }
    }
}
