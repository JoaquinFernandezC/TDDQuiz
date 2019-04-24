using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDQuiz
{
    public class Calculator
    {
        public static int Add(string numbers)
        {
            return 0;
        }

        public static int[] StringToIntList(string expression)
        {
            string[] splitted = expression.Split(',');
            int[] numbers = Array.ConvertAll(splitted, int.Parse);
            return numbers;
        }
    }
}
