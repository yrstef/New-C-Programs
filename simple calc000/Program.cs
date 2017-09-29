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
			int num1, num2;
			//creating operator string type variable
			string operand;
			//creating decimal type variable
			decimal result;


			//Displaying prompt for first value
			Console.WriteLine("Please enter your first value");
			//Accepting value in num1
			num1 = Convert.ToInt32(Console.ReadLine());

			//Displaying prompt for operand
			Console.Write("Please enter an operand (+, -, /, *): ");
			//Accepting operand
			operand = Console.ReadLine();

			//Displaying prompt for second value
			Console.WriteLine("Enter your second Value");
			//Accepting value in num2
			num2 = Convert.ToInt32(Console.ReadLine());


			//Calculation Performed via switch case statement
			switch (operand)
			{
				case "x":
					result = num1 * num2;
					break;
				case "/":
					result = num1 / num2;
					break;
				case "+":
					result = num1 + num2;
					break;
				case "-":
					result = num1 - num2;
					break;
                default:
                    result = 0;
                    break;
			}

			//Output
			Console.WriteLine($"{num1} {operand} {num2} = {result}");
			Console.ReadLine();
		}
	}
}
