using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        public double Calculate(string operation, double num1, double num2)
        {
            double result;
            switch(operation)
            {
                case "add":
                case "+":
                    result = num1 + num2;
                    break;
                case "subtract":
                case "-":
                    result = num1 - num2;
                    break;
                case "multiply":
                case "*":
                    result = num1 * num2;
                    break;
                case "divide":
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    throw new InvalidOperationException("Specified operation not recognised");
            }
            return result;
        }
    }
}
