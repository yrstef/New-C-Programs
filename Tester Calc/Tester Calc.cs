using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Program
    {

        private static string Calculate(int firstNum, int secondNum, string operation)
        {
            int answer = 0;


            // Switch used as a replacement for if statement
            switch (operation)
            {
                case "x":
                    answer = firstNum * secondNum;
                    break;
                case "/":
                    answer = firstNum / secondNum;
                    break;
                case "+":
                    answer = firstNum + secondNum;
                    break;
                case "-":
                    answer = firstNum - secondNum;
                    break;
                default:
                    return "Sorry that is not correct format! Please restart!";
                    //  break;
            }
            return new StringBuilder(firstNum + operation + secondNum + " = " + answer).ToString();
        }
    }
}