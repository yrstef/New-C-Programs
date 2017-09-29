using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating integer type variable
            decimal num1, num2, result;
           
            //creating operator string type variable
            string operation;

            //Displaying message
            Console.WriteLine("Please enter your first value");

            //Accepting Value in num1
            num1 = Decimal.Parse(Console.ReadLine());

            //Displaying message
            Console.WriteLine("Enter your second Value");

            //Accepting Value
            num2 = Decimal.Parse(Console.ReadLine());

            //result = num1 + num2; //processing value

            Console.WriteLine("Add of {0} and {1} is {2}", num1, num2, result); //Output

            Console.ReadLine();
        }
    }
}
 