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
                foreach (var item in numbers)
                {
                    result += item;
                }
            }
            return result;
        }

        public static int[] StringToIntList(string expression)
        {
            string[] splitted = expression.Split(',');
            int[] numbers = Array.ConvertAll(splitted, int.Parse);
            return numbers;
        }
    }
}
