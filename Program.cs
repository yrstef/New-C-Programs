using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calc
{
	class Program
	{
		static void Main(string[] args)
		{

            int num1, num2, operand; //creating integer type variables
            float result;  //creating float type variable

			//Displaying prompt for first value
			Console.WriteLine("Please enter your first value: ");
			num1 = Convert.ToInt32(Console.ReadLine());  //Accepting value in num1

			//Displaying prompt for second value
			Console.WriteLine("Enter your second Value: ");
			num2 = Convert.ToInt32(Console.ReadLine());   //Accepting value in num2

			//Displaying prompt for operand
			Console.WriteLine(@"Please enter an operand from the following list:
		 For Multiplication Enter 1
		 For Division Enter 2 
		 For Addition Enter 3
		 For Subtraction Enter 4
");
            operand = Convert.ToInt32(Console.ReadLine());  //Accepting operand


			//Calculation Performed via switch case statement
			switch (operand)
			{
				case 1:
					result = num1 * num2;
                    Console.WriteLine(num1 + " " + operand + " " + num2 + "=" + result);
					break;

				case 2:
					result = num1 / num2;
                    Console.WriteLine(num1 + " " + operand + " " + num2 + "=" + result);
					break;

				case 3:
					result = num1 + num2;
                    Console.WriteLine(num1 + " " + operand + " " + num2 + "=" + result);
					break;

				case 4:
					result = num1 - num2;
                    Console.WriteLine(num1 + " " + operand + " " + num2 + "=" + result);
                    break;
			}



			Console.ReadLine();
		}
	}
}