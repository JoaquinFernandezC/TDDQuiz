using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDQuiz
{
    public class Calculator
    {
        public static int Add(string expression, char delimiter)
        {
            int result = 0;
            if (expression.Length > 0)
            {
                int[] numbers = StringToIntList(expression, delimiter);
                foreach (int number in numbers)
                {
                    result += number;
                }
            }
            return result;
        }

        public static int[] StringToIntList(string expression, char delimiter)
        {
            string[] splitted = expression.Split(delimiter);
            int[] numbers = Array.ConvertAll(splitted, int.Parse);
            return numbers;
        }
    }
}
