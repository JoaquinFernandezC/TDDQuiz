using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDQuiz
{
    public class Calculator
    {
        public static int Add(string expression)
        {
            int result = 0;
            if (expression.Length > 0)
            {
                int[] numbers = StringToIntList(expression);
                foreach (int number in numbers)
                {
                    if (number > 0)
                    {
                        result += number;
                    }                  
                }
            }
            return result;
        }

        public static int[] StringToIntList(string expression)
        {
            char delimiter= ',';
            if (!char.IsDigit(expression[0]))
            {
                delimiter = expression[0];
                expression = expression.Substring(1);
            }
            string[] splitted = expression.Split(delimiter);
            int[] numbers = Array.ConvertAll(splitted, int.Parse);
            return numbers;
        }
    }
}
