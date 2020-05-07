using System;

namespace kata_1
{
    public class StringCalculator
    {
        public int Sum(string numbers)
        {
            var numberArray = numbers.Split(",");
            if (numberArray.Length == 1)
            {
                if (!string.IsNullOrEmpty(numberArray[0]))
                    return Convert.ToInt32(numberArray[0]);
                return 0;
            }
            else
            {
                var number1 = Convert.ToInt32(numberArray[0]);
                var number2 = Convert.ToInt32(numberArray[1]);
                return number1 + number2;
            }
        }
    }
}